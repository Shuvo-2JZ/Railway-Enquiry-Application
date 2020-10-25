using RailwayEnquiryRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace RailwayEnquiryApplication
{
    public partial class Ticket_Sell : Form
    {
        private string id;
        private string name;
        private string seat;
        public Ticket_Sell(string i,string n)
        {
            InitializeComponent();
            id = i;
            name = n;

            TrainRepository TrainRepo = new TrainRepository();
            List<Train> tList = TrainRepo.GetAllTrains();
            this.TrainGridView.DataSource = tList;

            PassengerRepository PassRepo = new PassengerRepository();
            List<RPassenger> pList = PassRepo.GetAllPassengers();
            this.PassengerGridView2.DataSource = pList;

            SeatRepository SeatRepo = new SeatRepository();
            List<Seat> sList = SeatRepo.GetAllSeats();
            this.SeatGridView3.DataSource = sList;
        }
        private void BackbtnClicked(object sender, EventArgs e)
        {
            Employee_Panel EP = new Employee_Panel(id,name);
            EP.Show();
            this.Hide();
        }

        private void CellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.TrainGridView.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.Trainidtbox.Text = row.Cells[0].Value.ToString();
                this.TrainNametbox.Text = row.Cells[1].Value.ToString();
                this.Fromtbox.Text = row.Cells[2].Value.ToString();
                this.totbox.Text = row.Cells[3].Value.ToString();
                this.Stimetbox.Text = row.Cells[4].Value.ToString();
                this.RTimetbox.Text = row.Cells[5].Value.ToString();
                seat = row.Cells[6].Value.ToString();
            }
        }

        private void PCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.PassengerGridView2.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.pidtbox.Text = row.Cells[0].Value.ToString();
                this.pnametbox.Text = row.Cells[1].Value.ToString();
                //this.Fromtbox.Text = row.Cells[2].Value.ToString();
               // this.totbox.Text = row.Cells[3].Value.ToString();
                this.pgendertbox.Text = row.Cells[4].Value.ToString();
                this.pnationalitytbox.Text = row.Cells[5].Value.ToString();
                //this.NoStbox.Text = row.Cells[6].Value.ToString();
            }

        }

        private void ScellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.SeatGridView3.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                this.sidtbox.Text = row.Cells[0].Value.ToString();
                this.snametbox.Text = row.Cells[1].Value.ToString();
                string price = row.Cells[2].Value.ToString();
                
                double Seat= Convert.ToDouble(price);
                double prices= Convert.ToDouble(this.Seatstbox.Text);
                this.pricetbox.Text = (Seat * prices).ToString();

            }
        }

        private void ConfirmbtnClicked(object sender, EventArgs e)
        {
            double S = Convert.ToDouble(this.Seatstbox.Text);
            double s = Convert.ToDouble(seat);
            if (S > s)
            { MessageBox.Show("Seat Number Exceeded", "Insert Error"); }
            else
            {
                RTicket t = new RTicket();
                t.Ticketid = this.Ticketidtbox.Text;
                t.Journeydate = this.JourneydateTP.Value.ToLongDateString();
                t.Tranid = this.Trainidtbox.Text;
                t.Passsengerid = this.pidtbox.Text;
                t.SeatClassid = this.sidtbox.Text;
                t.Seatno = this.Seatstbox.Text;
                t.Price = Convert.ToDouble(this.pricetbox.Text);

                TicketRepository TicketRepo = new TicketRepository();
                if (TicketRepo.TicketSell(t))
                {
                    MessageBox.Show("Ticket Sell Information Added", "ADD");
                    this.Printbtn.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Can Not Add Data", "Insert Error");
                }
            }
        }
        private void Print_btn_click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Ticket.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            iTextSharp.text.Rectangle rec2 = new iTextSharp.text.Rectangle(PageSize.A4);
            rec2.BackgroundColor = new BaseColor(Color.LightBlue);
            Document doc = new Document(rec2);
            PdfWriter wri = PdfWriter.GetInstance(doc, fs);
            
            doc.Open();
            iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("logo.png");
            PNG.ScalePercent(40f);
            PNG.SetAbsolutePosition(doc.PageSize.Width -46f-75f,doc.PageSize.Height -36f-105f);
            Paragraph par = new Paragraph("                                                               Railway Enquiry System " );
            Paragraph par1 = new Paragraph("                                                                    Ticket ID : " + Ticketidtbox.Text + "\nTrain Name : " + TrainNametbox.Text + "\nFrom : " + Fromtbox.Text + "                              To : " + totbox.Text + "\nJourney Date : " + JourneydateTP.Text + "                        Starting Time : " + Stimetbox.Text);
            Paragraph par2 = new Paragraph("Passenger Name : " + pnametbox.Text + "                                   Reaching Time : " + RTimetbox.Text + "\nGender : " +pgendertbox.Text + "\nNumber of Seat : " + Seatstbox.Text + "                                                     Seat Type : " + snametbox.Text + "\nGender : " + pgendertbox.Text + "\nPrice : " + pricetbox.Text);
            doc.Add(PNG);
            doc.Add(par);
            doc.Add(par1);
            doc.Add(par2);
            doc.Close();
            MessageBox.Show("Successfully Ticket Printed","Print Info");
            this.Printbtn.Enabled = false;
        }

        private void SearchbtnClicked(object sender, EventArgs e)
        {
            string text = this.Searchtbox.Text;
            TrainRepository TrainRepo = new TrainRepository();
            List<Train> tList = TrainRepo.SearchTrain(text);
            this.TrainGridView.DataSource = tList;
        }

        private void SeatSearchbtnClicked(object sender, EventArgs e)
        {
            string text = this.SeatSearchtbox.Text;
            TicketRepository TicketRepo = new TicketRepository();
            List<Seat> sList = TicketRepo.SearchSeatPrice(text);
            this.SeatGridView3.DataSource = sList;
        }

        private void PassSearchClicked(object sender, EventArgs e)
        {
            string text = this.PassengerTbox.Text;
            PassengerRepository Passrepo = new PassengerRepository();
            List<RPassenger> pList = Passrepo.SearchPassenger(text);
            this.PassengerGridView2.DataSource = pList;
        }

        private void LoadbtnClicked(object sender, EventArgs e)
        {
            TrainRepository TrainRepo = new TrainRepository();
            List<Train> tList = TrainRepo.GetAllTrains();
            this.TrainGridView.DataSource = tList;

            PassengerRepository PassRepo = new PassengerRepository();
            List<RPassenger> pList = PassRepo.GetAllPassengers();
            this.PassengerGridView2.DataSource = pList;

            SeatRepository SeatRepo = new SeatRepository();
            List<Seat> sList = SeatRepo.GetAllSeats();
            this.SeatGridView3.DataSource = sList;
        }
    }
}
