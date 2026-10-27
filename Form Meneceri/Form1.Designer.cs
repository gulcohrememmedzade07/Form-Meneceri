namespace Form_Meneceri
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
            btnQovluq = new Button();
            txtYol = new TextBox();
            btnAc = new Button();
            btnSaxla = new Button();
            btnSil = new Button();
            lstFayllar = new ListBox();
            label1 = new Label();
            txtMetn = new RichTextBox();
            label2 = new Label();
            lblMelumat = new Label();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnQovluq
            // 
            btnQovluq.BackColor = SystemColors.ActiveBorder;
            btnQovluq.FlatStyle = FlatStyle.Flat;
            btnQovluq.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQovluq.Location = new Point(28, 49);
            btnQovluq.Name = "btnQovluq";
            btnQovluq.Size = new Size(161, 51);
            btnQovluq.TabIndex = 0;
            btnQovluq.Text = "Qovluq seç";
            btnQovluq.UseVisualStyleBackColor = false;
            btnQovluq.Click += btnQovluq_Click;
            // 
            // txtYol
            // 
            txtYol.Location = new Point(834, 61);
            txtYol.Name = "txtYol";
            txtYol.PlaceholderText = "C:\\Users\\...\\Documents";
            txtYol.Size = new Size(324, 27);
            txtYol.TabIndex = 4;
            // 
            // btnAc
            // 
            btnAc.BackColor = SystemColors.ActiveBorder;
            btnAc.FlatStyle = FlatStyle.Flat;
            btnAc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAc.Location = new Point(226, 49);
            btnAc.Name = "btnAc";
            btnAc.Size = new Size(161, 51);
            btnAc.TabIndex = 5;
            btnAc.Text = "Aç";
            btnAc.UseVisualStyleBackColor = false;
            btnAc.Click += btnAc_Click;
            // 
            // btnSaxla
            // 
            btnSaxla.BackColor = SystemColors.ActiveBorder;
            btnSaxla.FlatStyle = FlatStyle.Flat;
            btnSaxla.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaxla.Location = new Point(428, 49);
            btnSaxla.Name = "btnSaxla";
            btnSaxla.Size = new Size(161, 51);
            btnSaxla.TabIndex = 6;
            btnSaxla.Text = "Yadda saxla";
            btnSaxla.UseVisualStyleBackColor = false;
            btnSaxla.Click += btnSaxla_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ActiveBorder;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSil.Location = new Point(628, 49);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(161, 51);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // lstFayllar
            // 
            lstFayllar.FormattingEnabled = true;
            lstFayllar.Location = new Point(28, 181);
            lstFayllar.Name = "lstFayllar";
            lstFayllar.Size = new Size(316, 364);
            lstFayllar.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 148);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 9;
            label1.Text = "Fayllar";
            // 
            // txtMetn
            // 
            txtMetn.Location = new Point(404, 184);
            txtMetn.Name = "txtMetn";
            txtMetn.Size = new Size(736, 361);
            txtMetn.TabIndex = 10;
            txtMetn.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(408, 157);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 11;
            label2.Text = "Mətn";
            // 
            // lblMelumat
            // 
            lblMelumat.AutoSize = true;
            lblMelumat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMelumat.Location = new Point(42, 614);
            lblMelumat.Name = "lblMelumat";
            lblMelumat.Size = new Size(87, 23);
            lblMelumat.TabIndex = 12;
            lblMelumat.Text = "Məlumat:";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 694);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1202, 26);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(151, 20);
            lblStatus.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1202, 720);
            Controls.Add(statusStrip1);
            Controls.Add(lblMelumat);
            Controls.Add(label2);
            Controls.Add(txtMetn);
            Controls.Add(label1);
            Controls.Add(lstFayllar);
            Controls.Add(btnSil);
            Controls.Add(btnSaxla);
            Controls.Add(btnAc);
            Controls.Add(txtYol);
            Controls.Add(btnQovluq);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fayl Meneceri";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQovluq;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txtYol;
        private Button btnAc;
        private Button btnSaxla;
        private Button btnSil;
        private ListBox lstFayllar;
        private Label label1;
        private RichTextBox txtMetn;
        private Label label2;
        private Label lblMelumat;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
    }
}
