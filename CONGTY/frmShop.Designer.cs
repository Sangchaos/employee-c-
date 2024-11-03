namespace CONGTY
{
    partial class frmShop
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
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnoplist = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cbiphone = new System.Windows.Forms.ComboBox();
            this.cbsamsung = new System.Windows.Forms.ComboBox();
            this.cblg = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGoStore = new System.Windows.Forms.Button();
            this.btnRedu = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(73, 38);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(66, 16);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "nhập type";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(195, 35);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 22);
            this.txtType.TabIndex = 1;
            // 
            // btnoplist
            // 
            this.btnoplist.Location = new System.Drawing.Point(318, 30);
            this.btnoplist.Name = "btnoplist";
            this.btnoplist.Size = new System.Drawing.Size(151, 33);
            this.btnoplist.TabIndex = 2;
            this.btnoplist.Text = "output devices";
            this.btnoplist.UseVisualStyleBackColor = true;
            this.btnoplist.Click += new System.EventHandler(this.btnoplist_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Location = new System.Drawing.Point(206, 130);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(287, 297);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // cbiphone
            // 
            this.cbiphone.FormattingEnabled = true;
            this.cbiphone.Location = new System.Drawing.Point(35, 160);
            this.cbiphone.Name = "cbiphone";
            this.cbiphone.Size = new System.Drawing.Size(121, 24);
            this.cbiphone.TabIndex = 7;
            this.cbiphone.SelectedIndexChanged += new System.EventHandler(this.cbiphone_SelectedIndexChanged);
            // 
            // cbsamsung
            // 
            this.cbsamsung.FormattingEnabled = true;
            this.cbsamsung.Location = new System.Drawing.Point(35, 282);
            this.cbsamsung.Name = "cbsamsung";
            this.cbsamsung.Size = new System.Drawing.Size(121, 24);
            this.cbsamsung.TabIndex = 8;
            this.cbsamsung.SelectedIndexChanged += new System.EventHandler(this.cbsamsung_SelectedIndexChanged);
            // 
            // cblg
            // 
            this.cblg.FormattingEnabled = true;
            this.cblg.Location = new System.Drawing.Point(35, 403);
            this.cblg.Name = "cblg";
            this.cblg.Size = new System.Drawing.Size(121, 24);
            this.cblg.TabIndex = 9;
            this.cblg.SelectedIndexChanged += new System.EventHandler(this.cblg_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "iPhone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Samsung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "LG";
            // 
            // btnGoStore
            // 
            this.btnGoStore.Location = new System.Drawing.Point(646, 484);
            this.btnGoStore.Name = "btnGoStore";
            this.btnGoStore.Size = new System.Drawing.Size(112, 46);
            this.btnGoStore.TabIndex = 13;
            this.btnGoStore.Text = "Go To Store";
            this.btnGoStore.UseVisualStyleBackColor = true;
            this.btnGoStore.Click += new System.EventHandler(this.btnGoStore_Click);
            // 
            // btnRedu
            // 
            this.btnRedu.Location = new System.Drawing.Point(12, 484);
            this.btnRedu.Name = "btnRedu";
            this.btnRedu.Size = new System.Drawing.Size(112, 46);
            this.btnRedu.TabIndex = 14;
            this.btnRedu.Text = "Return ";
            this.btnRedu.UseVisualStyleBackColor = true;
            this.btnRedu.Click += new System.EventHandler(this.btnRedu_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(418, 433);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 46);
            this.btnBuy.TabIndex = 15;
            this.btnBuy.Text = "BUY";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(511, 130);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(72, 16);
            this.lblInfo.TabIndex = 16;
            this.lblInfo.Text = "Information";
            // 
            // frmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 542);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnRedu);
            this.Controls.Add(this.btnGoStore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cblg);
            this.Controls.Add(this.cbsamsung);
            this.Controls.Add(this.cbiphone);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnoplist);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblType);
            this.Name = "frmShop";
            this.Text = "frmShop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmShop_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnoplist;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cbiphone;
        private System.Windows.Forms.ComboBox cbsamsung;
        private System.Windows.Forms.ComboBox cblg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGoStore;
        private System.Windows.Forms.Button btnRedu;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblInfo;
    }
}