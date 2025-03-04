namespace _04032025
{
    partial class frmSayiTahmin
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
            label1 = new Label();
            btnBaslat = new Button();
            txtTahmin = new TextBox();
            btnTahmin = new Button();
            lblSonuc = new Label();
            lblHak = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(265, 69);
            label1.Name = "label1";
            label1.Size = new Size(647, 96);
            label1.TabIndex = 0;
            label1.Text = "Sayı Tahmin Oyunu";
            // 
            // btnBaslat
            // 
            btnBaslat.Font = new Font("Segoe UI", 12F);
            btnBaslat.ForeColor = Color.Teal;
            btnBaslat.Location = new Point(330, 211);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(491, 98);
            btnBaslat.TabIndex = 1;
            btnBaslat.Text = "Oyunu Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // txtTahmin
            // 
            txtTahmin.Font = new Font("Segoe UI", 14F);
            txtTahmin.Location = new Point(190, 382);
            txtTahmin.Name = "txtTahmin";
            txtTahmin.Size = new Size(491, 82);
            txtTahmin.TabIndex = 2;
            // 
            // btnTahmin
            // 
            btnTahmin.BackColor = Color.Teal;
            btnTahmin.FlatStyle = FlatStyle.Flat;
            btnTahmin.Font = new Font("Segoe UI", 12F);
            btnTahmin.ForeColor = SystemColors.ControlLightLight;
            btnTahmin.Location = new Point(710, 382);
            btnTahmin.Name = "btnTahmin";
            btnTahmin.Size = new Size(300, 82);
            btnTahmin.TabIndex = 3;
            btnTahmin.Text = "Tahmin Et";
            btnTahmin.UseVisualStyleBackColor = false;
            btnTahmin.Click += btnTahmin_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 10F);
            lblSonuc.Location = new Point(190, 508);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(297, 54);
            lblSonuc.TabIndex = 4;
            lblSonuc.Text = "Oyun bekliyor...";
            // 
            // lblHak
            // 
            lblHak.AutoSize = true;
            lblHak.Font = new Font("Segoe UI", 10F);
            lblHak.Location = new Point(190, 601);
            lblHak.Name = "lblHak";
            lblHak.Size = new Size(251, 54);
            lblHak.TabIndex = 5;
            lblHak.Text = "Kalan Hak : 5";
            // 
            // frmSayiTahmin
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1219, 758);
            Controls.Add(lblHak);
            Controls.Add(lblSonuc);
            Controls.Add(btnTahmin);
            Controls.Add(txtTahmin);
            Controls.Add(btnBaslat);
            Controls.Add(label1);
            Name = "frmSayiTahmin";
            Text = "frmSayiTahmin";
            Load += frmSayiTahmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBaslat;
        private TextBox txtTahmin;
        private Button btnTahmin;
        private Label lblSonuc;
        private Label lblHak;
    }
}