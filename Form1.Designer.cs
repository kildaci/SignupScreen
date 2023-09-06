namespace SignupScreen
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.KayitOlButton = new System.Windows.Forms.Button();
            this.GirisYapButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "şifre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(198, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // KayitOlButton
            // 
            this.KayitOlButton.Location = new System.Drawing.Point(83, 181);
            this.KayitOlButton.Name = "KayitOlButton";
            this.KayitOlButton.Size = new System.Drawing.Size(71, 26);
            this.KayitOlButton.TabIndex = 4;
            this.KayitOlButton.Text = "Kayıt Ol";
            this.KayitOlButton.UseVisualStyleBackColor = true;
            this.KayitOlButton.Click += new System.EventHandler(this.KayitOlButton_Click);
            // 
            // GirisYapButton
            // 
            this.GirisYapButton.Location = new System.Drawing.Point(217, 181);
            this.GirisYapButton.Name = "GirisYapButton";
            this.GirisYapButton.Size = new System.Drawing.Size(71, 26);
            this.GirisYapButton.TabIndex = 5;
            this.GirisYapButton.Text = "Giriş Yap";
            this.GirisYapButton.UseVisualStyleBackColor = true;
            this.GirisYapButton.Click += new System.EventHandler(this.GirisYapButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 26);
            this.button3.TabIndex = 6;
            this.button3.Text = "Admin Butonu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.GirisYapButton);
            this.Controls.Add(this.KayitOlButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button KayitOlButton;
        private System.Windows.Forms.Button GirisYapButton;
        private System.Windows.Forms.Button button3;
    }
}

