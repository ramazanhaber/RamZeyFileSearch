
namespace RamZeyFileSearch
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAranilacakText = new System.Windows.Forms.TextBox();
            this.txtDosyaYolu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDosyaTip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 78);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(17, 176);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(740, 312);
            this.listBox1.TabIndex = 1;
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ne Tür Dosyalarda Aransın";
            // 
            // txtAranilacakText
            // 
            this.txtAranilacakText.Location = new System.Drawing.Point(269, 44);
            this.txtAranilacakText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAranilacakText.Name = "txtAranilacakText";
            this.txtAranilacakText.Size = new System.Drawing.Size(342, 29);
            this.txtAranilacakText.TabIndex = 3;
            this.txtAranilacakText.Text = "ca-pub-4274612173345332";
            // 
            // txtDosyaYolu
            // 
            this.txtDosyaYolu.Location = new System.Drawing.Point(269, 6);
            this.txtDosyaYolu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDosyaYolu.Name = "txtDosyaYolu";
            this.txtDosyaYolu.Size = new System.Drawing.Size(342, 29);
            this.txtDosyaYolu.TabIndex = 5;
            this.txtDosyaYolu.Text = "C:\\cc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dosya Yolu";
            // 
            // txtDosyaTip
            // 
            this.txtDosyaTip.Location = new System.Drawing.Point(269, 83);
            this.txtDosyaTip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDosyaTip.Name = "txtDosyaTip";
            this.txtDosyaTip.Size = new System.Drawing.Size(342, 29);
            this.txtDosyaTip.TabIndex = 7;
            this.txtDosyaTip.Text = "*.txt,*.html,*.php";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aranılacak Metin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bulunan Dosyalar :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 510);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDosyaTip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDosyaYolu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAranilacakText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAMZEY DOSYA ARAMA v0.0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAranilacakText;
        private System.Windows.Forms.TextBox txtDosyaYolu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDosyaTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

