namespace MarketKasaApp
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCocoCola = new Button();
            btnFanta = new Button();
            btnDondurma = new Button();
            btnPatlican = new Button();
            btnBuskivi = new Button();
            btnCikilota = new Button();
            btnNakit = new Button();
            btnKrediKarti = new Button();
            dG1 = new DataGridView();
            lbToplam = new Label();
            btnCay = new Button();
            btnDomates = new Button();
            btnSeker = new Button();
            btnBiber = new Button();
            islem = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dG1).BeginInit();
            SuspendLayout();
            // 
            // btnCocoCola
            // 
            btnCocoCola.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCocoCola.Location = new Point(12, 12);
            btnCocoCola.Name = "btnCocoCola";
            btnCocoCola.Size = new Size(167, 109);
            btnCocoCola.TabIndex = 0;
            btnCocoCola.TabStop = false;
            btnCocoCola.Text = "Coco Cola";
            btnCocoCola.UseVisualStyleBackColor = true;
            btnCocoCola.Click += btnCocoCola_Click;
            // 
            // btnFanta
            // 
            btnFanta.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnFanta.Location = new Point(185, 12);
            btnFanta.Name = "btnFanta";
            btnFanta.Size = new Size(167, 109);
            btnFanta.TabIndex = 1;
            btnFanta.TabStop = false;
            btnFanta.Text = "Fanta";
            btnFanta.UseVisualStyleBackColor = true;
            btnFanta.Click += btnFanta_Click;
            // 
            // btnDondurma
            // 
            btnDondurma.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDondurma.Location = new Point(358, 12);
            btnDondurma.Name = "btnDondurma";
            btnDondurma.Size = new Size(167, 109);
            btnDondurma.TabIndex = 2;
            btnDondurma.TabStop = false;
            btnDondurma.Text = "Dondurma";
            btnDondurma.UseVisualStyleBackColor = true;
            btnDondurma.Click += btnDondurma_Click;
            // 
            // btnPatlican
            // 
            btnPatlican.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPatlican.Location = new Point(12, 127);
            btnPatlican.Name = "btnPatlican";
            btnPatlican.Size = new Size(167, 109);
            btnPatlican.TabIndex = 3;
            btnPatlican.TabStop = false;
            btnPatlican.Text = "Patlıcan";
            btnPatlican.UseVisualStyleBackColor = true;
            btnPatlican.Click += btnPatlican_Click;
            // 
            // btnBuskivi
            // 
            btnBuskivi.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuskivi.Location = new Point(185, 127);
            btnBuskivi.Name = "btnBuskivi";
            btnBuskivi.Size = new Size(167, 109);
            btnBuskivi.TabIndex = 4;
            btnBuskivi.TabStop = false;
            btnBuskivi.Text = "Büskivi";
            btnBuskivi.UseVisualStyleBackColor = true;
            btnBuskivi.Click += btnBuskivi_Click;
            // 
            // btnCikilota
            // 
            btnCikilota.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCikilota.Location = new Point(358, 127);
            btnCikilota.Name = "btnCikilota";
            btnCikilota.Size = new Size(167, 109);
            btnCikilota.TabIndex = 5;
            btnCikilota.TabStop = false;
            btnCikilota.Text = "Çikilota";
            btnCikilota.UseVisualStyleBackColor = true;
            btnCikilota.Click += btnCikilota_Click;
            // 
            // btnNakit
            // 
            btnNakit.Location = new Point(12, 658);
            btnNakit.Name = "btnNakit";
            btnNakit.Size = new Size(167, 80);
            btnNakit.TabIndex = 6;
            btnNakit.TabStop = false;
            btnNakit.Text = "Nakit";
            btnNakit.UseVisualStyleBackColor = true;
            // 
            // btnKrediKarti
            // 
            btnKrediKarti.Location = new Point(185, 658);
            btnKrediKarti.Name = "btnKrediKarti";
            btnKrediKarti.Size = new Size(167, 80);
            btnKrediKarti.TabIndex = 7;
            btnKrediKarti.TabStop = false;
            btnKrediKarti.Text = "Kredi Kartı";
            btnKrediKarti.UseVisualStyleBackColor = true;
            // 
            // dG1
            // 
            dG1.AllowUserToAddRows = false;
            dG1.AllowUserToOrderColumns = true;
            dG1.AllowUserToResizeRows = false;
            dG1.BackgroundColor = Color.Aquamarine;
            dG1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dG1.Columns.AddRange(new DataGridViewColumn[] { islem });
            dG1.Location = new Point(877, 12);
            dG1.Name = "dG1";
            dG1.RowHeadersVisible = false;
            dG1.RowTemplate.Height = 25;
            dG1.Size = new Size(457, 643);
            dG1.TabIndex = 8;
            dG1.TabStop = false;
            // 
            // lbToplam
            // 
            lbToplam.BorderStyle = BorderStyle.FixedSingle;
            lbToplam.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbToplam.ForeColor = Color.Maroon;
            lbToplam.Location = new Point(877, 658);
            lbToplam.Name = "lbToplam";
            lbToplam.Size = new Size(457, 80);
            lbToplam.TabIndex = 9;
            lbToplam.Text = "0,00";
            lbToplam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCay
            // 
            btnCay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCay.Location = new Point(531, 127);
            btnCay.Name = "btnCay";
            btnCay.Size = new Size(167, 109);
            btnCay.TabIndex = 11;
            btnCay.TabStop = false;
            btnCay.Text = "Çay";
            btnCay.UseVisualStyleBackColor = true;
            btnCay.Click += btnCay_Click;
            // 
            // btnDomates
            // 
            btnDomates.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDomates.Location = new Point(531, 12);
            btnDomates.Name = "btnDomates";
            btnDomates.Size = new Size(167, 109);
            btnDomates.TabIndex = 10;
            btnDomates.TabStop = false;
            btnDomates.Text = "Domates";
            btnDomates.UseVisualStyleBackColor = true;
            btnDomates.Click += btnDomates_Click;
            // 
            // btnSeker
            // 
            btnSeker.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeker.Location = new Point(704, 127);
            btnSeker.Name = "btnSeker";
            btnSeker.Size = new Size(167, 109);
            btnSeker.TabIndex = 13;
            btnSeker.TabStop = false;
            btnSeker.Text = "Şeker";
            btnSeker.UseVisualStyleBackColor = true;
            btnSeker.Click += btnSeker_Click;
            // 
            // btnBiber
            // 
            btnBiber.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnBiber.Location = new Point(704, 12);
            btnBiber.Name = "btnBiber";
            btnBiber.Size = new Size(167, 109);
            btnBiber.TabIndex = 12;
            btnBiber.TabStop = false;
            btnBiber.Text = "Biber";
            btnBiber.UseVisualStyleBackColor = true;
            btnBiber.Click += btnBiber_Click;
            // 
            // islem
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Lime;
            dataGridViewCellStyle1.NullValue = "Sil";
            dataGridViewCellStyle1.SelectionBackColor = Color.BlueViolet;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            islem.DefaultCellStyle = dataGridViewCellStyle1;
            islem.HeaderText = "İşlem";
            islem.Name = "islem";
            islem.ReadOnly = true;
            islem.Text = "sil";
            islem.ToolTipText = "SIL";
            islem.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 759);
            Controls.Add(btnSeker);
            Controls.Add(btnBiber);
            Controls.Add(btnCay);
            Controls.Add(btnDomates);
            Controls.Add(lbToplam);
            Controls.Add(dG1);
            Controls.Add(btnKrediKarti);
            Controls.Add(btnNakit);
            Controls.Add(btnCikilota);
            Controls.Add(btnBuskivi);
            Controls.Add(btnPatlican);
            Controls.Add(btnDondurma);
            Controls.Add(btnFanta);
            Controls.Add(btnCocoCola);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Market Kasa Uygulaması";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dG1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCocoCola;
        private Button btnFanta;
        private Button btnDondurma;
        private Button btnPatlican;
        private Button btnBuskivi;
        private Button btnCikilota;
        private Button btnNakit;
        private Button btnKrediKarti;
        private DataGridView dG1;
        private Label lbToplam;
        private Button btnCay;
        private Button btnDomates;
        private Button btnSeker;
        private Button btnBiber;
        private DataGridViewButtonColumn islem;
    }
}
