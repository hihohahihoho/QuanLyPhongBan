
namespace QuanLyPhongBan
{
    partial class frmPhongBan
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.txtMaTP = new System.Windows.Forms.TextBox();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.lblNgayNC = new System.Windows.Forms.Label();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.lblMaTP = new System.Windows.Forms.Label();
            this.lblTenPB = new System.Windows.Forms.Label();
            this.lblMaPB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSea = new System.Windows.Forms.Button();
            this.txtSea = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.qLPhongBanDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLPhongBanDataSet = new QuanLyPhongBan.QLPhongBanDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongBanDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongBanDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.txtDiaDiem);
            this.groupBox1.Controls.Add(this.txtMaTP);
            this.groupBox1.Controls.Add(this.txtTenPB);
            this.groupBox1.Controls.Add(this.txtMaPB);
            this.groupBox1.Controls.Add(this.lblNgayNC);
            this.groupBox1.Controls.Add(this.lblDiaDiem);
            this.groupBox1.Controls.Add(this.lblMaTP);
            this.groupBox1.Controls.Add(this.lblTenPB);
            this.groupBox1.Controls.Add(this.lblMaPB);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Phòng Ban";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(4, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(892, 266);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtDate
            // 
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDate.Location = new System.Drawing.Point(391, 172);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(239, 28);
            this.txtDate.TabIndex = 10;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(391, 136);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(239, 28);
            this.txtDiaDiem.TabIndex = 9;
            // 
            // txtMaTP
            // 
            this.txtMaTP.Location = new System.Drawing.Point(391, 100);
            this.txtMaTP.Name = "txtMaTP";
            this.txtMaTP.Size = new System.Drawing.Size(239, 28);
            this.txtMaTP.TabIndex = 8;
            // 
            // txtTenPB
            // 
            this.txtTenPB.Location = new System.Drawing.Point(391, 64);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(239, 28);
            this.txtTenPB.TabIndex = 7;
            this.txtTenPB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtMaPB
            // 
            this.txtMaPB.Location = new System.Drawing.Point(391, 28);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(239, 28);
            this.txtMaPB.TabIndex = 6;
            // 
            // lblNgayNC
            // 
            this.lblNgayNC.AutoSize = true;
            this.lblNgayNC.Location = new System.Drawing.Point(215, 176);
            this.lblNgayNC.Name = "lblNgayNC";
            this.lblNgayNC.Size = new System.Drawing.Size(151, 22);
            this.lblNgayNC.TabIndex = 5;
            this.lblNgayNC.Text = "Ngày Nhận Chức";
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Location = new System.Drawing.Point(215, 139);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(87, 22);
            this.lblDiaDiem.TabIndex = 4;
            this.lblDiaDiem.Text = "Địa Điểm";
            // 
            // lblMaTP
            // 
            this.lblMaTP.AutoSize = true;
            this.lblMaTP.Location = new System.Drawing.Point(215, 102);
            this.lblMaTP.Name = "lblMaTP";
            this.lblMaTP.Size = new System.Drawing.Size(162, 22);
            this.lblMaTP.TabIndex = 3;
            this.lblMaTP.Text = "Mã Trưởng Phòng";
            // 
            // lblTenPB
            // 
            this.lblTenPB.AutoSize = true;
            this.lblTenPB.Location = new System.Drawing.Point(215, 65);
            this.lblTenPB.Name = "lblTenPB";
            this.lblTenPB.Size = new System.Drawing.Size(137, 22);
            this.lblTenPB.TabIndex = 2;
            this.lblTenPB.Text = "Tên Phòng Ban";
            // 
            // lblMaPB
            // 
            this.lblMaPB.AutoSize = true;
            this.lblMaPB.Location = new System.Drawing.Point(215, 28);
            this.lblMaPB.Name = "lblMaPB";
            this.lblMaPB.Size = new System.Drawing.Size(133, 22);
            this.lblMaPB.TabIndex = 1;
            this.lblMaPB.Text = "Mã Phòng Ban";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyPhongBan.Properties.Resources.aaa;
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(697, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 38);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1035, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 38);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(868, 19);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(80, 38);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSea
            // 
            this.btnSea.Location = new System.Drawing.Point(868, 199);
            this.btnSea.Name = "btnSea";
            this.btnSea.Size = new System.Drawing.Size(80, 38);
            this.btnSea.TabIndex = 4;
            this.btnSea.Text = "Search";
            this.btnSea.UseVisualStyleBackColor = true;
            this.btnSea.Click += new System.EventHandler(this.btnSea_Click);
            // 
            // txtSea
            // 
            this.txtSea.Location = new System.Drawing.Point(762, 146);
            this.txtSea.Name = "txtSea";
            this.txtSea.Size = new System.Drawing.Size(292, 22);
            this.txtSea.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.dgvPhongBan);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1204, 272);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng Thông Tin";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.AllowUserToOrderColumns = true;
            this.dgvPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhongBan.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhongBan.Location = new System.Drawing.Point(3, 30);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.RowHeadersWidth = 51;
            this.dgvPhongBan.RowTemplate.Height = 24;
            this.dgvPhongBan.Size = new System.Drawing.Size(1198, 239);
            this.dgvPhongBan.TabIndex = 0;
            this.dgvPhongBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellContentClick);
            // 
            // qLPhongBanDataSetBindingSource
            // 
            this.qLPhongBanDataSetBindingSource.DataSource = this.qLPhongBanDataSet;
            this.qLPhongBanDataSetBindingSource.Position = 0;
            // 
            // qLPhongBanDataSet
            // 
            this.qLPhongBanDataSet.DataSetName = "QLPhongBanDataSet";
            this.qLPhongBanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(776, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập vào đây để tìm kiếm";
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1161, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtSea);
            this.Controls.Add(this.btnSea);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPhongBan";
            this.Text = "frmPhongBan";
            this.Load += new System.EventHandler(this.frmPhongBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongBanDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPhongBanDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.TextBox txtMaTP;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.Label lblNgayNC;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.Label lblMaTP;
        private System.Windows.Forms.Label lblTenPB;
        private System.Windows.Forms.Label lblMaPB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSea;
        private System.Windows.Forms.TextBox txtSea;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource qLPhongBanDataSetBindingSource;
        private QLPhongBanDataSet qLPhongBanDataSet;
        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.Label label1;
    }
}