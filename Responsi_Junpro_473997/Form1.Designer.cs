namespace Responsi_Junpro_473997
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
            pictureBox1 = new PictureBox();
            lb_namaperusahaan = new Label();
            lb_namakaryawan = new Label();
            lb_depkaryawan = new Label();
            tb_nama = new TextBox();
            rtb_departemen = new RichTextBox();
            btn_insert = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            cb_departemen = new ComboBox();
            dgvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lb_namaperusahaan
            // 
            lb_namaperusahaan.AutoSize = true;
            lb_namaperusahaan.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lb_namaperusahaan.Location = new Point(149, 61);
            lb_namaperusahaan.Name = "lb_namaperusahaan";
            lb_namaperusahaan.Size = new Size(195, 30);
            lb_namaperusahaan.TabIndex = 1;
            lb_namaperusahaan.Text = "Nama Perusahaan";
            // 
            // lb_namakaryawan
            // 
            lb_namakaryawan.AutoSize = true;
            lb_namakaryawan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_namakaryawan.Location = new Point(26, 167);
            lb_namakaryawan.Name = "lb_namakaryawan";
            lb_namakaryawan.Size = new Size(127, 21);
            lb_namakaryawan.TabIndex = 2;
            lb_namakaryawan.Text = "Nama Karyawan:";
            // 
            // lb_depkaryawan
            // 
            lb_depkaryawan.AutoSize = true;
            lb_depkaryawan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_depkaryawan.Location = new Point(26, 215);
            lb_depkaryawan.Name = "lb_depkaryawan";
            lb_depkaryawan.Size = new Size(116, 21);
            lb_depkaryawan.TabIndex = 3;
            lb_depkaryawan.Text = "Dep. Karyawan:";
            // 
            // tb_nama
            // 
            tb_nama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_nama.Location = new Point(159, 164);
            tb_nama.Name = "tb_nama";
            tb_nama.Size = new Size(210, 29);
            tb_nama.TabIndex = 4;
            // 
            // rtb_departemen
            // 
            rtb_departemen.BackColor = SystemColors.ScrollBar;
            rtb_departemen.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            rtb_departemen.Location = new Point(435, 25);
            rtb_departemen.Name = "rtb_departemen";
            rtb_departemen.Size = new Size(269, 126);
            rtb_departemen.TabIndex = 6;
            rtb_departemen.Text = "ID Departemen:\nHR: Human Resource\nENG: Engineer \nDEV: Developer\nPM: Product Manager\nFIN: Finance";
            // 
            // btn_insert
            // 
            btn_insert.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_insert.Location = new Point(375, 164);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(104, 77);
            btn_insert.TabIndex = 7;
            btn_insert.Text = "Insert";
            btn_insert.UseVisualStyleBackColor = true;
            btn_insert.Click += btn_insert_Click;
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.Location = new Point(485, 164);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(104, 77);
            btn_update.TabIndex = 8;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.Location = new Point(595, 164);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(104, 77);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // cb_departemen
            // 
            cb_departemen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_departemen.FormattingEnabled = true;
            cb_departemen.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cb_departemen.Location = new Point(159, 207);
            cb_departemen.Name = "cb_departemen";
            cb_departemen.Size = new Size(210, 29);
            cb_departemen.TabIndex = 10;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(26, 260);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(673, 325);
            dgvData.TabIndex = 11;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 615);
            Controls.Add(dgvData);
            Controls.Add(cb_departemen);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_insert);
            Controls.Add(rtb_departemen);
            Controls.Add(tb_nama);
            Controls.Add(lb_depkaryawan);
            Controls.Add(lb_namakaryawan);
            Controls.Add(lb_namaperusahaan);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lb_namaperusahaan;
        private Label lb_namakaryawan;
        private Label lb_depkaryawan;
        private TextBox tb_nama;
        private RichTextBox rtb_departemen;
        private Button btn_insert;
        private Button btn_update;
        private Button btn_delete;
        private ComboBox cb_departemen;
        private DataGridView dgvData;
    }
}