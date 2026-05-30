namespace AntiVirus
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
            listBoxSonuclar = new ListBox();
            btnTehditOlustur = new Button();
            btnSistemTara = new Button();
            lblSonuc = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxSonuclar
            // 
            listBoxSonuclar.BackColor = SystemColors.InactiveCaptionText;
            listBoxSonuclar.ForeColor = SystemColors.InactiveBorder;
            listBoxSonuclar.FormattingEnabled = true;
            listBoxSonuclar.ItemHeight = 15;
            listBoxSonuclar.Location = new Point(52, 245);
            listBoxSonuclar.Name = "listBoxSonuclar";
            listBoxSonuclar.Size = new Size(653, 154);
            listBoxSonuclar.TabIndex = 5;
            // 
            // btnTehditOlustur
            // 
            btnTehditOlustur.BackColor = SystemColors.ButtonHighlight;
            btnTehditOlustur.FlatStyle = FlatStyle.System;
            btnTehditOlustur.Location = new Point(157, 107);
            btnTehditOlustur.Name = "btnTehditOlustur";
            btnTehditOlustur.Size = new Size(125, 23);
            btnTehditOlustur.TabIndex = 6;
            btnTehditOlustur.Text = "Create a Virus";
            btnTehditOlustur.UseVisualStyleBackColor = false;
            btnTehditOlustur.Click += btnTehditOlustur_Click;
            // 
            // btnSistemTara
            // 
            btnSistemTara.Location = new Point(459, 107);
            btnSistemTara.Name = "btnSistemTara";
            btnSistemTara.Size = new Size(194, 23);
            btnSistemTara.TabIndex = 7;
            btnSistemTara.Text = "Scan The System and Clear";
            btnSistemTara.UseVisualStyleBackColor = true;
            btnSistemTara.Click += btnSistemTara_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(349, 188);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(38, 15);
            lblSonuc.TabIndex = 8;
            lblSonuc.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 36);
            label1.Name = "label1";
            label1.Size = new Size(267, 32);
            label1.TabIndex = 9;
            label1.Text = "AntiVirus Application ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblSonuc);
            Controls.Add(btnSistemTara);
            Controls.Add(btnTehditOlustur);
            Controls.Add(listBoxSonuclar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBoxSonuclar;
        private Button btnTehditOlustur;
        private Button btnSistemTara;
        private Label lblSonuc;
        private Label label1;
    }
}
