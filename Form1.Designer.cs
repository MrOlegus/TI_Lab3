
namespace RSA_GUI
{
    partial class FormRSA
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelP = new System.Windows.Forms.Label();
            this.textP = new System.Windows.Forms.TextBox();
            this.textQ = new System.Windows.Forms.TextBox();
            this.labelQ = new System.Windows.Forms.Label();
            this.textR = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.textF = new System.Windows.Forms.TextBox();
            this.labelF = new System.Windows.Forms.Label();
            this.textE = new System.Windows.Forms.TextBox();
            this.labelE = new System.Windows.Forms.Label();
            this.textD = new System.Windows.Forms.TextBox();
            this.labelD = new System.Windows.Forms.Label();
            this.textOrigin = new System.Windows.Forms.TextBox();
            this.labelCaption = new System.Windows.Forms.Label();
            this.buttonCrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textSignature = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelP.Location = new System.Drawing.Point(12, 72);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(43, 48);
            this.labelP.TabIndex = 0;
            this.labelP.Text = "p";
            // 
            // textP
            // 
            this.textP.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textP.Location = new System.Drawing.Point(61, 72);
            this.textP.Name = "textP";
            this.textP.Size = new System.Drawing.Size(163, 55);
            this.textP.TabIndex = 1;
            this.textP.TextChanged += new System.EventHandler(this.textD_TextChanged);
            // 
            // textQ
            // 
            this.textQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textQ.Location = new System.Drawing.Point(61, 133);
            this.textQ.Name = "textQ";
            this.textQ.Size = new System.Drawing.Size(163, 55);
            this.textQ.TabIndex = 3;
            this.textQ.TextChanged += new System.EventHandler(this.textD_TextChanged);
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQ.Location = new System.Drawing.Point(12, 133);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(43, 48);
            this.labelQ.TabIndex = 2;
            this.labelQ.Text = "q";
            // 
            // textR
            // 
            this.textR.Enabled = false;
            this.textR.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textR.Location = new System.Drawing.Point(61, 194);
            this.textR.Name = "textR";
            this.textR.Size = new System.Drawing.Size(163, 55);
            this.textR.TabIndex = 5;
            this.textR.TextChanged += new System.EventHandler(this.textD_TextChanged);
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR.Location = new System.Drawing.Point(12, 194);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(34, 48);
            this.labelR.TabIndex = 4;
            this.labelR.Text = "r";
            // 
            // textF
            // 
            this.textF.Enabled = false;
            this.textF.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textF.Location = new System.Drawing.Point(61, 255);
            this.textF.Name = "textF";
            this.textF.Size = new System.Drawing.Size(163, 55);
            this.textF.TabIndex = 7;
            this.textF.TextChanged += new System.EventHandler(this.textD_TextChanged);
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelF.Location = new System.Drawing.Point(12, 255);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(32, 48);
            this.labelF.TabIndex = 6;
            this.labelF.Text = "f";
            // 
            // textE
            // 
            this.textE.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textE.Location = new System.Drawing.Point(61, 316);
            this.textE.Name = "textE";
            this.textE.Size = new System.Drawing.Size(163, 55);
            this.textE.TabIndex = 9;
            this.textE.TextChanged += new System.EventHandler(this.textD_TextChanged);
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelE.Location = new System.Drawing.Point(12, 316);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(43, 48);
            this.labelE.TabIndex = 8;
            this.labelE.Text = "e";
            // 
            // textD
            // 
            this.textD.Enabled = false;
            this.textD.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textD.Location = new System.Drawing.Point(61, 377);
            this.textD.Name = "textD";
            this.textD.Size = new System.Drawing.Size(163, 55);
            this.textD.TabIndex = 11;
            this.textD.TextChanged += new System.EventHandler(this.textD_TextChanged);
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelD.Location = new System.Drawing.Point(12, 377);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(43, 48);
            this.labelD.TabIndex = 10;
            this.labelD.Text = "d";
            // 
            // textOrigin
            // 
            this.textOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textOrigin.Location = new System.Drawing.Point(230, 72);
            this.textOrigin.Multiline = true;
            this.textOrigin.Name = "textOrigin";
            this.textOrigin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textOrigin.Size = new System.Drawing.Size(605, 299);
            this.textOrigin.TabIndex = 12;
            // 
            // labelCaption
            // 
            this.labelCaption.AutoSize = true;
            this.labelCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCaption.Location = new System.Drawing.Point(152, 9);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(490, 48);
            this.labelCaption.TabIndex = 13;
            this.labelCaption.Text = "Цифровая подпись RSA";
            // 
            // buttonCrypt
            // 
            this.buttonCrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCrypt.Location = new System.Drawing.Point(229, 438);
            this.buttonCrypt.Name = "buttonCrypt";
            this.buttonCrypt.Size = new System.Drawing.Size(300, 52);
            this.buttonCrypt.TabIndex = 15;
            this.buttonCrypt.Text = "Найти ключ";
            this.buttonCrypt.UseVisualStyleBackColor = true;
            this.buttonCrypt.Click += new System.EventHandler(this.buttonCrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDecrypt.Location = new System.Drawing.Point(535, 438);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(300, 52);
            this.buttonDecrypt.TabIndex = 16;
            this.buttonDecrypt.Text = "Проверить подпись";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(61, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 52);
            this.button1.TabIndex = 17;
            this.button1.Text = "Случайно";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSignature
            // 
            this.textSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSignature.Location = new System.Drawing.Point(446, 377);
            this.textSignature.Name = "textSignature";
            this.textSignature.Size = new System.Drawing.Size(387, 55);
            this.textSignature.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(230, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 48);
            this.label1.TabIndex = 18;
            this.label1.Text = "Подпись:";
            // 
            // FormRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 498);
            this.Controls.Add(this.textSignature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonCrypt);
            this.Controls.Add(this.labelCaption);
            this.Controls.Add(this.textOrigin);
            this.Controls.Add(this.textD);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.textE);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.textF);
            this.Controls.Add(this.labelF);
            this.Controls.Add(this.textR);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.textQ);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.textP);
            this.Controls.Add(this.labelP);
            this.Name = "FormRSA";
            this.Text = "RSA";
            this.Load += new System.EventHandler(this.FormRSA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.TextBox textP;
        private System.Windows.Forms.TextBox textQ;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.TextBox textR;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.TextBox textF;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.TextBox textE;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.TextBox textD;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.TextBox textOrigin;
        private System.Windows.Forms.Label labelCaption;
        private System.Windows.Forms.Button buttonCrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textSignature;
        private System.Windows.Forms.Label label1;
    }
}

