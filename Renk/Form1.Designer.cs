namespace Renk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnYesil = new Button();
            btnMavi = new Button();
            btnKirmizi = new Button();
            btnSari = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnYesil
            // 
            btnYesil.Location = new Point(12, 74);
            btnYesil.Name = "btnYesil";
            btnYesil.Size = new Size(94, 58);
            btnYesil.TabIndex = 0;
            btnYesil.Text = "Yeşil";
            btnYesil.UseVisualStyleBackColor = true;
            btnYesil.Click += btnYesil_Click;
            // 
            // btnMavi
            // 
            btnMavi.Location = new Point(112, 74);
            btnMavi.Name = "btnMavi";
            btnMavi.Size = new Size(94, 58);
            btnMavi.TabIndex = 0;
            btnMavi.Text = "Mavi";
            btnMavi.UseVisualStyleBackColor = true;
            btnMavi.Click += btnMavi_Click;
            // 
            // btnKirmizi
            // 
            btnKirmizi.Location = new Point(212, 74);
            btnKirmizi.Name = "btnKirmizi";
            btnKirmizi.Size = new Size(94, 58);
            btnKirmizi.TabIndex = 0;
            btnKirmizi.Text = "Kırmızı";
            btnKirmizi.UseVisualStyleBackColor = true;
            btnKirmizi.Click += btnKirmizi_Click;
            // 
            // btnSari
            // 
            btnSari.Location = new Point(312, 74);
            btnSari.Name = "btnSari";
            btnSari.Size = new Size(94, 58);
            btnSari.TabIndex = 0;
            btnSari.Text = "Sarı";
            btnSari.UseVisualStyleBackColor = true;
            btnSari.Click += btnSari_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 138);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 30);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 141);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 7;
            label1.Text = "Ad";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(112, 183);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(200, 29);
            btnClear.TabIndex = 8;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 596);
            Controls.Add(btnClear);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btnSari);
            Controls.Add(btnKirmizi);
            Controls.Add(btnMavi);
            Controls.Add(btnYesil);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYesil;
        private Button btnMavi;
        private Button btnKirmizi;
        private Button btnSari;
        private TextBox textBox1;
        private Label label1;
        private Button btnClear;
    }
}