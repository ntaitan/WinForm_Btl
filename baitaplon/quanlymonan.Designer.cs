namespace baitaplon
{
    partial class quanlymonan
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dsMonAn = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.cbbNhom = new System.Windows.Forms.ComboBox();
            this.tbTenMon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btXemMon = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.numGia = new System.Windows.Forms.TextBox();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMonAn)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dsMonAn);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(730, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý món ăn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dsMonAn
            // 
            this.dsMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dsMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsMonAn.Location = new System.Drawing.Point(3, 195);
            this.dsMonAn.Name = "dsMonAn";
            this.dsMonAn.RowHeadersWidth = 51;
            this.dsMonAn.RowTemplate.Height = 24;
            this.dsMonAn.Size = new System.Drawing.Size(724, 194);
            this.dsMonAn.TabIndex = 1;
            this.dsMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsMonAn_CellClick);
            this.dsMonAn.SelectionChanged += new System.EventHandler(this.dsMonAn_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên món";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Giá";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nhóm món";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Trạng thái";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(724, 192);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numGia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbbTrangThai);
            this.panel1.Controls.Add(this.cbbNhom);
            this.panel1.Controls.Add(this.tbTenMon);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 186);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên món ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhóm món";
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng"});
            this.cbbTrangThai.Location = new System.Drawing.Point(99, 135);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(213, 24);
            this.cbbTrangThai.TabIndex = 3;
            // 
            // cbbNhom
            // 
            this.cbbNhom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbNhom.FormattingEnabled = true;
            this.cbbNhom.Items.AddRange(new object[] {
            "Khai vị",
            "Ăn vặt",
            "Món chính"});
            this.cbbNhom.Location = new System.Drawing.Point(99, 95);
            this.cbbNhom.Name = "cbbNhom";
            this.cbbNhom.Size = new System.Drawing.Size(213, 24);
            this.cbbNhom.TabIndex = 3;
            // 
            // tbTenMon
            // 
            this.tbTenMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTenMon.Location = new System.Drawing.Point(99, 17);
            this.tbTenMon.Name = "tbTenMon";
            this.tbTenMon.Size = new System.Drawing.Size(213, 22);
            this.tbTenMon.TabIndex = 2;
            this.tbTenMon.TextChanged += new System.EventHandler(this.tbTenMon_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(this.btTimKiem);
            this.panel2.Controls.Add(this.tbTimKiem);
            this.panel2.Location = new System.Drawing.Point(365, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 186);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btXemMon, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btXoa, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btSua, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btThem, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 47);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(359, 130);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btXemMon
            // 
            this.btXemMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btXemMon.Location = new System.Drawing.Point(3, 3);
            this.btXemMon.Name = "btXemMon";
            this.btXemMon.Size = new System.Drawing.Size(173, 59);
            this.btXemMon.TabIndex = 3;
            this.btXemMon.Text = "Xem món";
            this.btXemMon.UseVisualStyleBackColor = true;
            this.btXemMon.Click += new System.EventHandler(this.btXemMon_Click);
            // 
            // btXoa
            // 
            this.btXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btXoa.Location = new System.Drawing.Point(182, 68);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(174, 59);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa món";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSua.Location = new System.Drawing.Point(3, 68);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(173, 59);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sửa món";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.AutoSize = true;
            this.btThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btThem.Location = new System.Drawing.Point(182, 3);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(174, 59);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm Món";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTimKiem.BackColor = System.Drawing.Color.LightBlue;
            this.btTimKiem.Location = new System.Drawing.Point(238, 18);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(113, 24);
            this.btTimKiem.TabIndex = 2;
            this.btTimKiem.Text = "Tìm kiếm món";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTimKiem.Location = new System.Drawing.Point(27, 19);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(205, 22);
            this.tbTimKiem.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(738, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // numGia
            // 
            this.numGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numGia.Location = new System.Drawing.Point(99, 57);
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(213, 22);
            this.numGia.TabIndex = 4;
            // 
            // quanlymonan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(738, 421);
            this.Controls.Add(this.tabControl1);
            this.Name = "quanlymonan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsMonAn)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dsMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.ComboBox cbbNhom;
        private System.Windows.Forms.TextBox tbTenMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btXemMon;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox numGia;
    }
}

