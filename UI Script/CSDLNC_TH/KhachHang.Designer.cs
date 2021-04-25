namespace CSDLNC_TH
{
    partial class KhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.dtgv_kh = new System.Windows.Forms.DataGridView();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.shopBtn = new System.Windows.Forms.Button();
            this.cartBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.addCartBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.danhMucComBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_kh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtBox.Location = new System.Drawing.Point(310, 37);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(221, 26);
            this.searchTxtBox.TabIndex = 1;
            // 
            // dtgv_kh
            // 
            this.dtgv_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_kh.Location = new System.Drawing.Point(160, 103);
            this.dtgv_kh.Name = "dtgv_kh";
            this.dtgv_kh.RowTemplate.Height = 24;
            this.dtgv_kh.Size = new System.Drawing.Size(796, 346);
            this.dtgv_kh.TabIndex = 2;
            this.dtgv_kh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_kh_CellClick);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(27, 395);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(100, 54);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "Đăng xuất";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // historyBtn
            // 
            this.historyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyBtn.Location = new System.Drawing.Point(27, 289);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(100, 54);
            this.historyBtn.TabIndex = 6;
            this.historyBtn.Text = "Lịch sử mua hàng";
            this.historyBtn.UseVisualStyleBackColor = true;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // shopBtn
            // 
            this.shopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopBtn.Location = new System.Drawing.Point(27, 199);
            this.shopBtn.Name = "shopBtn";
            this.shopBtn.Size = new System.Drawing.Size(100, 54);
            this.shopBtn.TabIndex = 5;
            this.shopBtn.Text = "Cửa hàng";
            this.shopBtn.UseVisualStyleBackColor = true;
            this.shopBtn.Click += new System.EventHandler(this.shopBtn_Click);
            // 
            // cartBtn
            // 
            this.cartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartBtn.Location = new System.Drawing.Point(27, 103);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(100, 54);
            this.cartBtn.TabIndex = 4;
            this.cartBtn.Text = "Giỏ hàng";
            this.cartBtn.UseVisualStyleBackColor = true;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(551, 37);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(119, 32);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Username:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(97, 19);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(41, 15);
            this.usernameLabel.TabIndex = 14;
            this.usernameLabel.Text = "label4";
            // 
            // addCartBtn
            // 
            this.addCartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCartBtn.Location = new System.Drawing.Point(751, 455);
            this.addCartBtn.Name = "addCartBtn";
            this.addCartBtn.Size = new System.Drawing.Size(205, 43);
            this.addCartBtn.TabIndex = 15;
            this.addCartBtn.Text = "Thêm vào giỏ hàng";
            this.addCartBtn.UseVisualStyleBackColor = true;
            this.addCartBtn.Click += new System.EventHandler(this.addCartBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Danh Mục:";
            // 
            // danhMucComBox
            // 
            this.danhMucComBox.FormattingEnabled = true;
            this.danhMucComBox.Items.AddRange(new object[] {
            "Điện Thoại",
            "Đồ Gia Dụng",
            "Quần Áo",
            "Giày Dép",
            " "});
            this.danhMucComBox.Location = new System.Drawing.Point(410, 66);
            this.danhMucComBox.Name = "danhMucComBox";
            this.danhMucComBox.Size = new System.Drawing.Size(121, 24);
            this.danhMucComBox.TabIndex = 18;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 519);
            this.Controls.Add(this.danhMucComBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addCartBtn);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.cartBtn);
            this.Controls.Add(this.shopBtn);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.dtgv_kh);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_kh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.DataGridView dtgv_kh;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Button shopBtn;
        private System.Windows.Forms.Button cartBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button addCartBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox danhMucComBox;
    }
}