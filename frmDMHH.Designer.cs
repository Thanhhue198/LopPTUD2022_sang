
namespace LopPTUD2022_sang
{
    partial class frmDMHH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgVnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmahh = new System.Windows.Forms.TextBox();
            this.txttenhh = new System.Windows.Forms.TextBox();
            this.txtdvt = new System.Windows.Forms.TextBox();
            this.txtdgvnd = new System.Windows.Forms.TextBox();
            this.txtnuocsx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnprv = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnrf = new System.Windows.Forms.Button();
            this.btnloc = new System.Windows.Forms.Button();
            this.comgt = new System.Windows.Forms.ComboBox();
            this.comtentruong = new System.Windows.Forms.ComboBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndlt = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.txtmanhom = new System.Windows.Forms.ComboBox();
            this.btnrp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhom,
            this.MaHH,
            this.TenHH,
            this.dvt,
            this.dgVnd,
            this.sanxuat});
            this.grdData.Location = new System.Drawing.Point(12, 88);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 62;
            this.grdData.RowTemplate.Height = 28;
            this.grdData.Size = new System.Drawing.Size(756, 448);
            this.grdData.TabIndex = 0;
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellContentClick);
            // 
            // MaNhom
            // 
            this.MaNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaNhom.DataPropertyName = "MaNhom";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNhom.DefaultCellStyle = dataGridViewCellStyle6;
            this.MaNhom.HeaderText = "Nhóm Hàng";
            this.MaNhom.MinimumWidth = 8;
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.Width = 130;
            // 
            // MaHH
            // 
            this.MaHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaHH.DataPropertyName = "MaHH";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHH.DefaultCellStyle = dataGridViewCellStyle7;
            this.MaHH.HeaderText = "Mã Hàng";
            this.MaHH.MinimumWidth = 8;
            this.MaHH.Name = "MaHH";
            this.MaHH.Width = 110;
            // 
            // TenHH
            // 
            this.TenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenHH.DataPropertyName = "TenHH";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHH.DefaultCellStyle = dataGridViewCellStyle8;
            this.TenHH.HeaderText = "Tên Hàng";
            this.TenHH.MinimumWidth = 8;
            this.TenHH.Name = "TenHH";
            this.TenHH.Width = 115;
            // 
            // dvt
            // 
            this.dvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dvt.DataPropertyName = "dvt";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvt.DefaultCellStyle = dataGridViewCellStyle9;
            this.dvt.HeaderText = "ĐVT";
            this.dvt.MinimumWidth = 8;
            this.dvt.Name = "dvt";
            this.dvt.Width = 77;
            // 
            // dgVnd
            // 
            this.dgVnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgVnd.DataPropertyName = "dgVnd";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            this.dgVnd.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgVnd.HeaderText = "Đơn giá";
            this.dgVnd.MinimumWidth = 8;
            this.dgVnd.Name = "dgVnd";
            // 
            // sanxuat
            // 
            this.sanxuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sanxuat.DataPropertyName = "sanxuat";
            this.sanxuat.HeaderText = "Nước SX";
            this.sanxuat.MinimumWidth = 8;
            this.sanxuat.Name = "sanxuat";
            this.sanxuat.Width = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý Danh mục hàng hóa";
            // 
            // txtmahh
            // 
            this.txtmahh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmahh.Location = new System.Drawing.Point(910, 298);
            this.txtmahh.Name = "txtmahh";
            this.txtmahh.Size = new System.Drawing.Size(290, 30);
            this.txtmahh.TabIndex = 2;
            // 
            // txttenhh
            // 
            this.txttenhh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenhh.Location = new System.Drawing.Point(910, 351);
            this.txttenhh.Name = "txttenhh";
            this.txttenhh.Size = new System.Drawing.Size(290, 30);
            this.txttenhh.TabIndex = 3;
            // 
            // txtdvt
            // 
            this.txtdvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdvt.Location = new System.Drawing.Point(910, 404);
            this.txtdvt.Name = "txtdvt";
            this.txtdvt.Size = new System.Drawing.Size(290, 30);
            this.txtdvt.TabIndex = 4;
            // 
            // txtdgvnd
            // 
            this.txtdgvnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdgvnd.Location = new System.Drawing.Point(910, 457);
            this.txtdgvnd.Name = "txtdgvnd";
            this.txtdgvnd.Size = new System.Drawing.Size(290, 30);
            this.txtdgvnd.TabIndex = 5;
            // 
            // txtnuocsx
            // 
            this.txtnuocsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnuocsx.Location = new System.Drawing.Point(910, 510);
            this.txtnuocsx.Name = "txtnuocsx";
            this.txtnuocsx.Size = new System.Drawing.Size(290, 30);
            this.txtnuocsx.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(799, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã Nhóm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(804, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên HH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(804, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đơn vị tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(804, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(804, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nước SX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(804, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã HH";
            // 
            // btnfirst
            // 
            this.btnfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfirst.Location = new System.Drawing.Point(27, 570);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(88, 47);
            this.btnfirst.TabIndex = 14;
            this.btnfirst.Text = "Đầu";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnprv
            // 
            this.btnprv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprv.Location = new System.Drawing.Point(139, 570);
            this.btnprv.Name = "btnprv";
            this.btnprv.Size = new System.Drawing.Size(87, 47);
            this.btnprv.TabIndex = 15;
            this.btnprv.Text = "Trước";
            this.btnprv.UseVisualStyleBackColor = true;
            this.btnprv.Click += new System.EventHandler(this.btnprv_Click);
            // 
            // btnnext
            // 
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.Location = new System.Drawing.Point(258, 570);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(90, 47);
            this.btnnext.TabIndex = 16;
            this.btnnext.Text = "Sau";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnlast
            // 
            this.btnlast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlast.Location = new System.Drawing.Point(384, 570);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(93, 47);
            this.btnlast.TabIndex = 17;
            this.btnlast.Text = "Cuối";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnrp);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnrf);
            this.groupBox1.Controls.Add(this.btnloc);
            this.groupBox1.Controls.Add(this.comgt);
            this.groupBox1.Controls.Add(this.comtentruong);
            this.groupBox1.Location = new System.Drawing.Point(804, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 201);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc Dữ liệu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(149, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(174, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Giá trị lọc";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(5, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Lọc theo";
            // 
            // btnrf
            // 
            this.btnrf.Location = new System.Drawing.Point(290, 145);
            this.btnrf.Name = "btnrf";
            this.btnrf.Size = new System.Drawing.Size(121, 39);
            this.btnrf.TabIndex = 3;
            this.btnrf.Text = "Hủy lọc dữ liệu";
            this.btnrf.UseVisualStyleBackColor = true;
            this.btnrf.Click += new System.EventHandler(this.btnrf_Click);
            // 
            // btnloc
            // 
            this.btnloc.Location = new System.Drawing.Point(6, 145);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(137, 39);
            this.btnloc.TabIndex = 2;
            this.btnloc.Text = "Lọc";
            this.btnloc.UseVisualStyleBackColor = true;
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // comgt
            // 
            this.comgt.FormattingEnabled = true;
            this.comgt.Location = new System.Drawing.Point(179, 100);
            this.comgt.Name = "comgt";
            this.comgt.Size = new System.Drawing.Size(232, 28);
            this.comgt.TabIndex = 1;
            // 
            // comtentruong
            // 
            this.comtentruong.FormattingEnabled = true;
            this.comtentruong.Items.AddRange(new object[] {
            "manhom",
            "tenhh",
            "sanxuat"});
            this.comtentruong.Location = new System.Drawing.Point(6, 100);
            this.comtentruong.Name = "comtentruong";
            this.comtentruong.Size = new System.Drawing.Size(137, 28);
            this.comtentruong.TabIndex = 0;
            this.comtentruong.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(1126, 619);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(102, 49);
            this.btnexit.TabIndex = 19;
            this.btnexit.Text = "Kết Thúc";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(1002, 619);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(102, 49);
            this.btnupdate.TabIndex = 20;
            this.btnupdate.Text = "Cập Nhật";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndlt
            // 
            this.btndlt.Location = new System.Drawing.Point(875, 619);
            this.btndlt.Name = "btndlt";
            this.btndlt.Size = new System.Drawing.Size(102, 49);
            this.btndlt.TabIndex = 21;
            this.btndlt.Text = "Xóa";
            this.btndlt.UseVisualStyleBackColor = true;
            this.btndlt.Click += new System.EventHandler(this.btndlt_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(752, 619);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(102, 49);
            this.btnedit.TabIndex = 22;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnaddnew
            // 
            this.btnaddnew.Location = new System.Drawing.Point(629, 619);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(102, 49);
            this.btnaddnew.TabIndex = 23;
            this.btnaddnew.Text = "Thêm Mới";
            this.btnaddnew.UseVisualStyleBackColor = true;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // txtmanhom
            // 
            this.txtmanhom.FormattingEnabled = true;
            this.txtmanhom.Location = new System.Drawing.Point(910, 252);
            this.txtmanhom.Name = "txtmanhom";
            this.txtmanhom.Size = new System.Drawing.Size(290, 28);
            this.txtmanhom.TabIndex = 24;
            // 
            // btnrp
            // 
            this.btnrp.Location = new System.Drawing.Point(154, 145);
            this.btnrp.Name = "btnrp";
            this.btnrp.Size = new System.Drawing.Size(112, 39);
            this.btnrp.TabIndex = 7;
            this.btnrp.Text = "Xuất báo cáo";
            this.btnrp.UseVisualStyleBackColor = true;
            this.btnrp.Click += new System.EventHandler(this.btnrp_Click);
            // 
            // frmDMHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1240, 680);
            this.Controls.Add(this.txtmanhom);
            this.Controls.Add(this.btnaddnew);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndlt);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprv);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnuocsx);
            this.Controls.Add(this.txtdgvnd);
            this.Controls.Add(this.txtdvt);
            this.Controls.Add(this.txttenhh);
            this.Controls.Add(this.txtmahh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdData);
            this.KeyPreview = true;
            this.Name = "frmDMHH";
            this.Text = "frmDMHH";
            this.Load += new System.EventHandler(this.frmDMHH_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDMHH_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgVnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanxuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmahh;
        private System.Windows.Forms.TextBox txttenhh;
        private System.Windows.Forms.TextBox txtdvt;
        private System.Windows.Forms.TextBox txtdgvnd;
        private System.Windows.Forms.TextBox txtnuocsx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnprv;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comgt;
        private System.Windows.Forms.ComboBox comtentruong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnrf;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndlt;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnaddnew;
        private System.Windows.Forms.ComboBox txtmanhom;
        private System.Windows.Forms.Button btnrp;
    }
}