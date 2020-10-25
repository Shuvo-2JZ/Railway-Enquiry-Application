namespace RailwayEnquiryApplication
{
    partial class Passenger_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passenger_Panel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.TrainSearchbtn = new System.Windows.Forms.Button();
            this.TrainSchedulebtn = new System.Windows.Forms.Button();
            this.TicketPricebtn = new System.Windows.Forms.Button();
            this.Profilebtn = new System.Windows.Forms.Button();
            this.NoticeBoard = new System.Windows.Forms.Button();
            this.CancelReservationbtn = new System.Windows.Forms.Button();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.Location = new System.Drawing.Point(157, 52);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(74, 21);
            this.Titlelbl.TabIndex = 1;
            this.Titlelbl.Text = "Welcome";
            // 
            // TrainSearchbtn
            // 
            this.TrainSearchbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TrainSearchbtn.BackgroundImage")));
            this.TrainSearchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TrainSearchbtn.Location = new System.Drawing.Point(35, 151);
            this.TrainSearchbtn.Name = "TrainSearchbtn";
            this.TrainSearchbtn.Size = new System.Drawing.Size(102, 91);
            this.TrainSearchbtn.TabIndex = 2;
            this.TrainSearchbtn.UseVisualStyleBackColor = true;
            this.TrainSearchbtn.Click += new System.EventHandler(this.TrainSearchClicked);
            // 
            // TrainSchedulebtn
            // 
            this.TrainSchedulebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TrainSchedulebtn.BackgroundImage")));
            this.TrainSchedulebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TrainSchedulebtn.Location = new System.Drawing.Point(174, 151);
            this.TrainSchedulebtn.Name = "TrainSchedulebtn";
            this.TrainSchedulebtn.Size = new System.Drawing.Size(102, 91);
            this.TrainSchedulebtn.TabIndex = 3;
            this.TrainSchedulebtn.UseVisualStyleBackColor = true;
            this.TrainSchedulebtn.Click += new System.EventHandler(this.TrainSchedule);
            // 
            // TicketPricebtn
            // 
            this.TicketPricebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TicketPricebtn.BackgroundImage")));
            this.TicketPricebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TicketPricebtn.Location = new System.Drawing.Point(301, 151);
            this.TicketPricebtn.Name = "TicketPricebtn";
            this.TicketPricebtn.Size = new System.Drawing.Size(116, 91);
            this.TicketPricebtn.TabIndex = 4;
            this.TicketPricebtn.UseVisualStyleBackColor = true;
            this.TicketPricebtn.Click += new System.EventHandler(this.TicketPriceClicked);
            // 
            // Profilebtn
            // 
            this.Profilebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Profilebtn.BackgroundImage")));
            this.Profilebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Profilebtn.Location = new System.Drawing.Point(35, 285);
            this.Profilebtn.Name = "Profilebtn";
            this.Profilebtn.Size = new System.Drawing.Size(102, 94);
            this.Profilebtn.TabIndex = 5;
            this.Profilebtn.UseVisualStyleBackColor = true;
            this.Profilebtn.Click += new System.EventHandler(this.profilebtnclicked);
            // 
            // NoticeBoard
            // 
            this.NoticeBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NoticeBoard.BackgroundImage")));
            this.NoticeBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NoticeBoard.Location = new System.Drawing.Point(174, 285);
            this.NoticeBoard.Name = "NoticeBoard";
            this.NoticeBoard.Size = new System.Drawing.Size(102, 94);
            this.NoticeBoard.TabIndex = 6;
            this.NoticeBoard.UseVisualStyleBackColor = true;
            this.NoticeBoard.Click += new System.EventHandler(this.NoticeBoardClicked);
            // 
            // CancelReservationbtn
            // 
            this.CancelReservationbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelReservationbtn.BackgroundImage")));
            this.CancelReservationbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelReservationbtn.Location = new System.Drawing.Point(301, 285);
            this.CancelReservationbtn.Name = "CancelReservationbtn";
            this.CancelReservationbtn.Size = new System.Drawing.Size(116, 94);
            this.CancelReservationbtn.TabIndex = 7;
            this.CancelReservationbtn.UseVisualStyleBackColor = true;
            this.CancelReservationbtn.Click += new System.EventHandler(this.CancelReservationClicked);
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logoutbtn.BackgroundImage")));
            this.Logoutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logoutbtn.Location = new System.Drawing.Point(347, 40);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(56, 49);
            this.Logoutbtn.TabIndex = 8;
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.logoutClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Train Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Train Schedule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ticket Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Profile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Notice Board";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cancel Reservation";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(237, 52);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(0, 21);
            this.Namelbl.TabIndex = 15;
            // 
            // Passenger_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(440, 399);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.CancelReservationbtn);
            this.Controls.Add(this.NoticeBoard);
            this.Controls.Add(this.Profilebtn);
            this.Controls.Add(this.TicketPricebtn);
            this.Controls.Add(this.TrainSchedulebtn);
            this.Controls.Add(this.TrainSearchbtn);
            this.Controls.Add(this.Titlelbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Passenger_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passenger_Panel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Button TrainSearchbtn;
        private System.Windows.Forms.Button TrainSchedulebtn;
        private System.Windows.Forms.Button TicketPricebtn;
        private System.Windows.Forms.Button Profilebtn;
        private System.Windows.Forms.Button NoticeBoard;
        private System.Windows.Forms.Button CancelReservationbtn;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Namelbl;
    }
}