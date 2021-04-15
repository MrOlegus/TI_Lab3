using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_GUI
{
    public partial class FormRSA : Form
    {
		const ulong maxNumber = 1000;

		List<ulong> prime = new List<ulong>();

		ulong p, q, r, f, E, d, S;

		string message;                                 // искомый текст
		List<ulong> crypt = new List<ulong>();          // зашифрованный текст

		void findPrimeNumbers()
		{
			for (ulong i = 2; i <= maxNumber; i++)
			{
				bool isPrime = true;
				for (short j = 0; j < prime.Count; j++)
					if (i % prime[j] == 0)
					{
						isPrime = false;
						break;
					}
				if (isPrime)
				{
					prime.Add(i);
				}
			}
		}

		ulong NOD(ulong a, ulong b)
		{
			while (a > 0 && b > 0)
				if (a > b) a %= b;
				else b %= a;
			return a + b;
		}

		List<ulong> getPrimaryMas(ulong n)
		{
			List<ulong> primaryMas = new List<ulong>();
			for (ulong i = 1; i <= maxNumber; i++)
				if (NOD(i, n) == 1)
				{
					primaryMas.Add(i);
				}
			return primaryMas;
		}

		Random rnd = new Random();                    // объект для получения случайных чисел

		ulong Euclidex(ulong a, ulong b)
		{
			long d0 = (long)a; long d1 = (long)b;
			long x0 = 1; long x1 = 0;
			long y0 = 0; long y1 = 1;
			while (d1 > 1)
			{
				long q = d0 / d1;
				long d2 = d0 % d1;
				long x2 = x0 - q * x1;
				long y2 = y0 - q * y1;
				d0 = d1; d1 = d2;
				x0 = x1; x1 = x2;
				y0 = y1; y1 = y2;
			}
			if (y1 < 0) y1 += (long)a;
			return (ulong)y1;
		}

        ulong fastExp(ulong a, ulong z, ulong n)
		{
			ulong a1 = a;
			ulong z1 = z;
			ulong x = 1;
			while (z1 != 0)
			{
				while ((z1 % 2) == 0)
				{
					z1 = z1 / 2;
					a1 = (a1 * a1) % n;
				}
				z1 -= 1;
				x = (x * a1) % n;
			}
			return x;
		}

		ulong getNumber(char letter)
		{
			if ((letter >= 'a') && (letter <= 'z')) return (ulong)letter - 'a' + 1;
			if ((letter >= 'A') && (letter <= 'Z')) return (ulong)letter - 'A' + 1;
			if (letter == ' ') return 28; // пробел считаем символом алфавита
			return 0;
		}

		char getLetter(ulong number)
        {
			if ((number >= 1) && (number <= 26)) return (char)('a' + number - 1);
			if (number == 28) return ' ';
			return '\0';
        }

        private void textD_TextChanged(object sender, EventArgs e) // изменение параметров
        {
			try
			{
				switch (((TextBox)sender).Name)
				{
					case "textP":
						p = (ulong)Convert.ToInt32(textP.Text); break;
					case "textQ":
						q = (ulong)Convert.ToInt32(textQ.Text); break;
					case "textE":
						E = (ulong)Convert.ToInt32(textE.Text); break;
				}
				r = p * q;
				f = (p - 1) * (q - 1);
				d = Euclidex(f, E);
				textR.Text = Convert.ToString(r);
				textF.Text = Convert.ToString(f);
				textD.Text = Convert.ToString(d);
			}
			catch
            {

            }
		}

        private void FormRSA_Load(object sender, EventArgs e)
        {
			findPrimeNumbers();                            // получения массива простых чисел
			//MessageBox.Show("Параметры можно водить самостоятельно, а можно сгенерировать их случайно. Если параметры введены неверно, программа уведомит Вас об этом.\r\nЯзык - английский.\r\nШифруются английские буквы и пробелы, остальное - удаляется.");
		}

		static ulong hPred = 100;

        private ulong H(ulong m, int i)
        {
			if (i == 0) hPred = 100;
			ulong h = (ulong)Math.Pow(hPred + m, 2) % r;
			hPred = h;
		    return h;
        }

        bool isValid() // проверка на корректность параметров
        {
			bool isPPrime = false;
			bool isQPrime = false;

			for (int i = 0; i < prime.Count; i++)
            {
				if (p == prime[i]) isPPrime = true;
				if (q == prime[i]) isQPrime = true;
			}

			if (!isPPrime) 
			{
				MessageBox.Show("Число p - не простое!");
				return false;
			}
			if (!isQPrime)
			{
				MessageBox.Show("Число q - не простое");
				return false;
			}
			if (p == q)
            {
				MessageBox.Show("Параметры p и q не должны быть равны");
				return false;
			}
			if (r != p * q)
			{
				MessageBox.Show("Неверный параметр r");
				return false;
			}
			if (r < 30)
			{
				MessageBox.Show("Параметр r не должен быть меньше 30");
				return false;
			}
			if (f != (p - 1) * (q - 1))
			{
				MessageBox.Show("Неверный параметр f");
				return false;
			}
			if (NOD(E, f) != 1)
			{
				MessageBox.Show("e и f - не взаимнопросты");
				return false;
			}
			if ((E * d) % f != 1)
			{
				MessageBox.Show("Неверный параметр d");
				return false;
			}
			return true;
        }

		public FormRSA()
        {
            InitializeComponent();
        }

		private void buttonCrypt_Click(object sender, EventArgs e)
		{
			if (!isValid())
			{
				return;
			}

			message = textOrigin.Text;           // искомый текст
			for (int i = 0; i < message.Length; i++)
			{
				if (((message[i] < 'a') || (message[i] > 'z')) &&
					((message[i] < 'A') || (message[i] > 'Z')) &&
					(message[i] != ' '))
                {
					message = message.Remove(i, 1);
					i--;
                }
            }
			textOrigin.Text = message;

			//crypt = new List<ulong>();          // зашифрованный текст

			/*
			for (int i = 0; i < message.Length; i++)
			{
				crypt.Add(fastExp(getNumber(message[i]), E, r));
			}

			textCrypt.Text = "";
			for (ushort i = 0; i < crypt.Count; i++)
			{
				textCrypt.Text += crypt[i].ToString();
				textCrypt.Text += " ";
			}
			*/

			ulong h = 0;
			for (int i = 0; i < message.Length; i++)
            {
				h = H(getNumber(message[i]), i);
            }

			S = fastExp(h, d, r);

			textSignature.Text = S.ToString();
		}

		private void buttonDecrypt_Click(object sender, EventArgs e)
		{
			/*
			message = "";
			for (int i = 0; i < crypt.Count; i++)
            {
				message += getLetter(fastExp(crypt[i], d, r));
            }
			textOrigin.Text = message;
			*/

			message = textOrigin.Text;

			ulong h1 = 0;
			for (int i = 0; i < message.Length; i++)
			{
				h1 = H(getNumber(message[i]), i);
			}

			ulong m = Convert.ToUInt64(textSignature.Text);
			ulong h2 = fastExp(m, E, r);

			MessageBox.Show("h1 = " + h1.ToString() + "\r\n" + 
				            "h2 = " + h2.ToString() + "\r\n" +
							((h1 == h2) ? "Подпись действительна" :
							              "Подпись недействительна"));

		}

		private void button1_Click(object sender, EventArgs e)
        {
			p = prime[rnd.Next(0, prime.Count)];      // получение параметра p
			q = prime[rnd.Next(0, prime.Count)];        // получение параметра q
			r = p * q;                                // получение параметра r
			f = (p - 1) * (q - 1);                    // получение значения функции Эйлера
			List<ulong> primaryMas = getPrimaryMas(f);   // получение чисел, взаимнопростых с f
			E = primaryMas[rnd.Next(0, primaryMas.Count - 1)];           // получение параметра e
			d = Euclidex(f, E);                       // получение параметра d

			textP.Text = Convert.ToString(p);
			textQ.Text = Convert.ToString(q);
			textR.Text = Convert.ToString(r);
			textF.Text = Convert.ToString(f);
			textE.Text = Convert.ToString(E);
			textD.Text = Convert.ToString(d);
		}
	}
}