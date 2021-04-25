namespace CSDLNC_TH
{
    partial class LichSuMua
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
            this.dtgv_donMua = new System.Windows.Forms.DataGridView();
            this.billDetailBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_donMua)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_donMua
            // 
            this.dtgv_donMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_donMua.Location = new System.Drawing.Point(12, 12);
            this.dtgv_donMua.Name = "dtgv_donMua";
            this.dtgv_donMua.RowTemplate.Height = 24;
            this.dtgv_donMua.Size = new System.Drawing.Size(691, 339);
            this.dtgv_donMua.TabIndex = 0;
            this.dtgv_donMua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_donMua_CellClick);
            // 
            // billDetailBtn
            // 
            this.billDetailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billDetailBtn.Location = new System.Drawing.Point(504, 362);
            this.billDetailBtn.Name = "billDetailBtn";
            this.billDetailBtn.Size = new System.Drawing.Size(199, 47);
            this.billDetailBtn.TabIndex = 22;
            this.billDetailBtn.Text = "Xác nhận đơn hàng";
            this.billDetailBtn.UseVisualStyleBackColor = true;
            this.billDetailBtn.Click += new System.EventHandler(this.billDetailBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(284, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 47);
            this.button1.TabIndex = 23;
            this.button1.Text = "Chi tiết đơn hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 47);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LichSuMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 421);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.billDetailBtn);
            this.Controls.Add(this.dtgv_donMua);
            this.Name = "LichSuMua";
            this.Text = "LichSuMua";
            this.Load += new System.EventHandler(this.LichSuMua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_donMua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_donMua;
        private System.Windows.Forms.Button billDetailBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}