namespace RailwayEnquiryApplication
{
    partial class CancelReservation
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
            this.Pricetbox = new System.Windows.Forms.TextBox();
            this.SNotbox = new System.Windows.Forms.TextBox();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.TicketGridView = new System.Windows.Forms.DataGridView();
            this.Passengeridtbox = new System.Windows.Forms.TextBox();
            this.Trainidtbox = new System.Windows.Forms.TextBox();
            this.JDatetbox = new System.Windows.Forms.TextBox();
            this.Ticketidtbox = new System.Windows.Forms.TextBox();
            this.Tnamelbl = new System.Windows.Forms.Label();
            this.tolbl = new System.Windows.Forms.Label();
            this.fromlbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.Startingtimelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TicketGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Pricetbox
            // 
            this.Pricetbox.Enabled = false;
            this.Pricetbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricetbox.Location = new System.Drawing.Point(160, 267);
            this.Pricetbox.Name = "Pricetbox";
            this.Pricetbox.Size = new System.Drawing.Size(159, 29);
            this.Pricetbox.TabIndex = 71;
            // 
            // SNotbox
            // 
            this.SNotbox.Enabled = false;
            this.SNotbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNotbox.Location = new System.Drawing.Point(160, 221);
            this.SNotbox.Name = "SNotbox";
            this.SNotbox.Size = new System.Drawing.Size(159, 29);
            this.SNotbox.TabIndex = 70;
            // 
            // Loadbtn
            // 
            this.Loadbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadbtn.Location = new System.Drawing.Point(633, 324);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(90, 33);
            this.Loadbtn.TabIndex = 69;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.LoadbtnClicked);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(229, 324);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(90, 33);
            this.backbtn.TabIndex = 68;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.BackbtnClicked);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.Location = new System.Drawing.Point(127, 324);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(90, 33);
            this.Updatebtn.TabIndex = 67;
            this.Updatebtn.Text = "Delete";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.DeletebtnClicked);
            // 
            // TicketGridView
            // 
            this.TicketGridView.BackgroundColor = System.Drawing.Color.GreenYellow;
            this.TicketGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketGridView.Location = new System.Drawing.Point(341, 71);
            this.TicketGridView.Name = "TicketGridView";
            this.TicketGridView.Size = new System.Drawing.Size(382, 225);
            this.TicketGridView.TabIndex = 66;
            this.TicketGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClicked);
            // 
            // Passengeridtbox
            // 
            this.Passengeridtbox.Enabled = false;
            this.Passengeridtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passengeridtbox.Location = new System.Drawing.Point(160, 176);
            this.Passengeridtbox.Name = "Passengeridtbox";
            this.Passengeridtbox.Size = new System.Drawing.Size(159, 29);
            this.Passengeridtbox.TabIndex = 65;
            // 
            // Trainidtbox
            // 
            this.Trainidtbox.Enabled = false;
            this.Trainidtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trainidtbox.Location = new System.Drawing.Point(160, 141);
            this.Trainidtbox.Name = "Trainidtbox";
            this.Trainidtbox.Size = new System.Drawing.Size(159, 29);
            this.Trainidtbox.TabIndex = 64;
            // 
            // JDatetbox
            // 
            this.JDatetbox.Enabled = false;
            this.JDatetbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JDatetbox.Location = new System.Drawing.Point(160, 106);
            this.JDatetbox.Name = "JDatetbox";
            this.JDatetbox.Size = new System.Drawing.Size(159, 29);
            this.JDatetbox.TabIndex = 63;
            // 
            // Ticketidtbox
            // 
            this.Ticketidtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ticketidtbox.Location = new System.Drawing.Point(160, 71);
            this.Ticketidtbox.Name = "Ticketidtbox";
            this.Ticketidtbox.Size = new System.Drawing.Size(159, 29);
            this.Ticketidtbox.TabIndex = 62;
            // 
            // Tnamelbl
            // 
            this.Tnamelbl.AutoSize = true;
            this.Tnamelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tnamelbl.Location = new System.Drawing.Point(22, 149);
            this.Tnamelbl.Name = "Tnamelbl";
            this.Tnamelbl.Size = new System.Drawing.Size(63, 21);
            this.Tnamelbl.TabIndex = 60;
            this.Tnamelbl.Text = "Train ID";
            // 
            // tolbl
            // 
            this.tolbl.AutoSize = true;
            this.tolbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tolbl.Location = new System.Drawing.Point(22, 229);
            this.tolbl.Name = "tolbl";
            this.tolbl.Size = new System.Drawing.Size(65, 21);
            this.tolbl.TabIndex = 59;
            this.tolbl.Text = "Seat No";
            // 
            // fromlbl
            // 
            this.fromlbl.AutoSize = true;
            this.fromlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromlbl.Location = new System.Drawing.Point(22, 184);
            this.fromlbl.Name = "fromlbl";
            this.fromlbl.Size = new System.Drawing.Size(99, 21);
            this.fromlbl.TabIndex = 58;
            this.fromlbl.Text = "Passenger ID";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(22, 114);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(101, 21);
            this.Namelbl.TabIndex = 57;
            this.Namelbl.Text = "Journey Date";
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlbl.Location = new System.Drawing.Point(22, 79);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(69, 21);
            this.IDlbl.TabIndex = 56;
            this.IDlbl.Text = "Ticket ID";
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.Location = new System.Drawing.Point(141, 28);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(142, 21);
            this.Titlelbl.TabIndex = 55;
            this.Titlelbl.Text = "Cancel Reservation";
            // 
            // Startingtimelbl
            // 
            this.Startingtimelbl.AutoSize = true;
            this.Startingtimelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startingtimelbl.Location = new System.Drawing.Point(22, 275);
            this.Startingtimelbl.Name = "Startingtimelbl";
            this.Startingtimelbl.Size = new System.Drawing.Size(44, 21);
            this.Startingtimelbl.TabIndex = 73;
            this.Startingtimelbl.Text = "Price";
            // 
            // CancelReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(745, 385);
            this.Controls.Add(this.Startingtimelbl);
            this.Controls.Add(this.Pricetbox);
            this.Controls.Add(this.SNotbox);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.TicketGridView);
            this.Controls.Add(this.Passengeridtbox);
            this.Controls.Add(this.Trainidtbox);
            this.Controls.Add(this.JDatetbox);
            this.Controls.Add(this.Ticketidtbox);
            this.Controls.Add(this.Tnamelbl);
            this.Controls.Add(this.tolbl);
            this.Controls.Add(this.fromlbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.Titlelbl);
            this.Name = "CancelReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelReservation";
            ((System.ComponentModel.ISupportInitialize)(this.TicketGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Pricetbox;
        private System.Windows.Forms.TextBox SNotbox;
        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.DataGridView TicketGridView;
        private System.Windows.Forms.TextBox Passengeridtbox;
        private System.Windows.Forms.TextBox Trainidtbox;
        private System.Windows.Forms.TextBox JDatetbox;
        private System.Windows.Forms.TextBox Ticketidtbox;
        private System.Windows.Forms.Label Tnamelbl;
        private System.Windows.Forms.Label tolbl;
        private System.Windows.Forms.Label fromlbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Label Startingtimelbl;
    }
}