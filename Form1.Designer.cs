namespace dubaothoitiet
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnForecast = new System.Windows.Forms.Button();
            this.lvwForecast = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboQuery = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txthanoi = new System.Windows.Forms.TextBox();
            this.ndhanoi = new System.Windows.Forms.TextBox();
            this.textdn = new System.Windows.Forms.TextBox();
            this.textsg = new System.Windows.Forms.TextBox();
            this.nddanang = new System.Windows.Forms.TextBox();
            this.ndsaigon = new System.Windows.Forms.TextBox();
            this.labsg = new System.Windows.Forms.Label();
            this.labdn = new System.Windows.Forms.Label();
            this.labhanoi = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pichn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Dự báo thời tiết:";
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocation.Location = new System.Drawing.Point(421, 83);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(192, 22);
            this.txtLocation.TabIndex = 15;
            this.txtLocation.Text = "Vũng Tàu";
            // 
            // btnForecast
            // 
            this.btnForecast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnForecast.Location = new System.Drawing.Point(402, 122);
            this.btnForecast.Margin = new System.Windows.Forms.Padding(4);
            this.btnForecast.Name = "btnForecast";
            this.btnForecast.Size = new System.Drawing.Size(224, 28);
            this.btnForecast.TabIndex = 16;
            this.btnForecast.Text = "Dự báo thời tiết";
            this.btnForecast.UseVisualStyleBackColor = true;
            this.btnForecast.Click += new System.EventHandler(this.btnForecast_Click);
            // 
            // lvwForecast
            // 
            this.lvwForecast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwForecast.BackgroundImage = global::howto_weather_forecast2.Properties.Resources.seamless_weather_forecast_background_vector_2000781;
            this.lvwForecast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwForecast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwForecast.GridLines = true;
            this.lvwForecast.HideSelection = false;
            this.lvwForecast.Location = new System.Drawing.Point(659, 269);
            this.lvwForecast.Margin = new System.Windows.Forms.Padding(4);
            this.lvwForecast.Name = "lvwForecast";
            this.lvwForecast.Size = new System.Drawing.Size(367, 296);
            this.lvwForecast.TabIndex = 19;
            this.lvwForecast.UseCompatibleStateImageBehavior = false;
            this.lvwForecast.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ngày tháng";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Thời gian";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nhiệt độ";
            this.columnHeader3.Width = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Thành phố:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(659, 193);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(132, 22);
            this.txtCity.TabIndex = 21;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(894, 193);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(4);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(132, 22);
            this.txtCountry.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(824, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quốc gia:";
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(894, 225);
            this.txtLong.Margin = new System.Windows.Forms.Padding(4);
            this.txtLong.Name = "txtLong";
            this.txtLong.ReadOnly = true;
            this.txtLong.Size = new System.Drawing.Size(132, 22);
            this.txtLong.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(832, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Kinh độ:";
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(659, 225);
            this.txtLat.Margin = new System.Windows.Forms.Padding(4);
            this.txtLat.Name = "txtLat";
            this.txtLat.ReadOnly = true;
            this.txtLat.Size = new System.Drawing.Size(132, 22);
            this.txtLat.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(600, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Vĩ độ:";
            // 
            // cboQuery
            // 
            this.cboQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuery.FormattingEnabled = true;
            this.cboQuery.Location = new System.Drawing.Point(316, 82);
            this.cboQuery.Margin = new System.Windows.Forms.Padding(4);
            this.cboQuery.Name = "cboQuery";
            this.cboQuery.Size = new System.Drawing.Size(97, 24);
            this.cboQuery.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Trạng Thái";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Nhiệt độ";
            // 
            // txthanoi
            // 
            this.txthanoi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txthanoi.Location = new System.Drawing.Point(101, 355);
            this.txthanoi.Multiline = true;
            this.txthanoi.Name = "txthanoi";
            this.txthanoi.ReadOnly = true;
            this.txthanoi.Size = new System.Drawing.Size(147, 28);
            this.txthanoi.TabIndex = 37;
            // 
            // ndhanoi
            // 
            this.ndhanoi.Location = new System.Drawing.Point(124, 415);
            this.ndhanoi.Name = "ndhanoi";
            this.ndhanoi.ReadOnly = true;
            this.ndhanoi.Size = new System.Drawing.Size(98, 22);
            this.ndhanoi.TabIndex = 38;
            // 
            // textdn
            // 
            this.textdn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textdn.Location = new System.Drawing.Point(268, 355);
            this.textdn.Multiline = true;
            this.textdn.Name = "textdn";
            this.textdn.ReadOnly = true;
            this.textdn.Size = new System.Drawing.Size(145, 28);
            this.textdn.TabIndex = 39;
            // 
            // textsg
            // 
            this.textsg.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsg.Location = new System.Drawing.Point(431, 355);
            this.textsg.Multiline = true;
            this.textsg.Name = "textsg";
            this.textsg.ReadOnly = true;
            this.textsg.Size = new System.Drawing.Size(145, 28);
            this.textsg.TabIndex = 40;
            // 
            // nddanang
            // 
            this.nddanang.Location = new System.Drawing.Point(287, 413);
            this.nddanang.Name = "nddanang";
            this.nddanang.ReadOnly = true;
            this.nddanang.Size = new System.Drawing.Size(107, 22);
            this.nddanang.TabIndex = 41;
            // 
            // ndsaigon
            // 
            this.ndsaigon.Location = new System.Drawing.Point(445, 413);
            this.ndsaigon.Name = "ndsaigon";
            this.ndsaigon.ReadOnly = true;
            this.ndsaigon.Size = new System.Drawing.Size(102, 22);
            this.ndsaigon.TabIndex = 42;
            // 
            // labsg
            // 
            this.labsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsg.Location = new System.Drawing.Point(440, 190);
            this.labsg.Name = "labsg";
            this.labsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labsg.Size = new System.Drawing.Size(113, 32);
            this.labsg.TabIndex = 33;
            this.labsg.Text = "Ho Chi Minh";
            this.labsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labdn
            // 
            this.labdn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdn.Location = new System.Drawing.Point(297, 188);
            this.labdn.Name = "labdn";
            this.labdn.Size = new System.Drawing.Size(87, 32);
            this.labdn.TabIndex = 32;
            this.labdn.Text = "Đà Nẵng";
            this.labdn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labhanoi
            // 
            this.labhanoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labhanoi.Location = new System.Drawing.Point(140, 187);
            this.labhanoi.Name = "labhanoi";
            this.labhanoi.Size = new System.Drawing.Size(71, 35);
            this.labhanoi.TabIndex = 31;
            this.labhanoi.Text = "Hà Nội";
            this.labhanoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.BackgroundImage = global::howto_weather_forecast2.Properties.Resources._02d_2x1;
            this.pictureBox2.Location = new System.Drawing.Point(287, 237);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImage = global::howto_weather_forecast2.Properties.Resources._04d_2x1;
            this.pictureBox1.Location = new System.Drawing.Point(443, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(620, 50);
            this.label2.TabIndex = 46;
            this.label2.Text = "CHƯƠNG TRÌNH DỰ BÁO THỜI TIẾT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pichn
            // 
            this.pichn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pichn.BackgroundImage = global::howto_weather_forecast2.Properties.Resources._10d_2x3;
            this.pichn.Location = new System.Drawing.Point(124, 237);
            this.pichn.Name = "pichn";
            this.pichn.Size = new System.Drawing.Size(113, 96);
            this.pichn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pichn.TabIndex = 45;
            this.pichn.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnForecast;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::howto_weather_forecast2.Properties.Resources._1tTOV;
            this.ClientSize = new System.Drawing.Size(1058, 578);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pichn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ndsaigon);
            this.Controls.Add(this.nddanang);
            this.Controls.Add(this.textsg);
            this.Controls.Add(this.textdn);
            this.Controls.Add(this.ndhanoi);
            this.Controls.Add(this.txthanoi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labsg);
            this.Controls.Add(this.labdn);
            this.Controls.Add(this.labhanoi);
            this.Controls.Add(this.cboQuery);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvwForecast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnForecast);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Dự báo thời tiết ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnForecast;
        private System.Windows.Forms.ListView lvwForecast;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboQuery;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txthanoi;
        private System.Windows.Forms.TextBox ndhanoi;
        private System.Windows.Forms.TextBox textdn;
        private System.Windows.Forms.TextBox nddanang;
        private System.Windows.Forms.TextBox ndsaigon;
        private System.Windows.Forms.Label labsg;
        private System.Windows.Forms.Label labdn;
        private System.Windows.Forms.Label labhanoi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textsg;
        private System.Windows.Forms.PictureBox pichn;
    }
}

