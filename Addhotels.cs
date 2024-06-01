using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using horizon_travels_and_tours;

namespace horizon_travels_and_tours
{
    public partial class Addhotels : Form
    {
        private HotelClass hotel = new HotelClass();
        private decimal rating;
        private DataTable dataTable; 

        public Addhotels()
        {
            InitializeComponent();
        }
        private bool Verify()
        {
            return !(string.IsNullOrWhiteSpace(textBox_hname.Text) ||
                     string.IsNullOrWhiteSpace(textBox_location.Text) ||
                     string.IsNullOrWhiteSpace(textBox_hphone.Text) ||
                     string.IsNullOrWhiteSpace(textBox_hprice.Text) ||
                     pictureBox_Hotel.Image == null);
        }
        private void Addhotels_Load(object sender, EventArgs e)
        {
            showTable();
            guna2RatingStar1.Value = 3.5f;
            guna2RatingStar1.ValueChanged += guna2RatingStar1_ValueChanged;
        }

        private void guna2RatingStar1_ValueChanged(object sender, EventArgs e)
        {
            Guna2RatingStar ratingStar = (Guna2RatingStar)sender;
            rating = (decimal)ratingStar.Value;
        }

        private void showTable()
        {
            DataGridView_hotel.DataSource = hotel.getHotelList();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_hotel.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }


        private void button_uploadh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_Hotel.Image = Image.FromFile(opf.FileName);
        }

        private void button_addh_Click(object sender, EventArgs e)
        {

            if (!Verify())
            {
                MessageBox.Show("Please fill in all the required fields and upload an image.");
                return;
            }

            string hname = textBox_hname.Text;
            string location = textBox_location.Text;
            string phone = textBox_hphone.Text;
            int price = Convert.ToInt32(textBox_hprice.Text);
            DateTime checkin = dateTimePicker1h.Value;
            DateTime checkout = dateTimePicker2h.Value;
            decimal ratingValue = rating;
            byte[] imageBytes = ImageToByteArray(pictureBox_Hotel.Image);

            if(hotel.insertHotel(hname, location, phone, price, checkin, checkout, ratingValue, imageBytes))
    {
                MessageBox.Show("Hotel added successfully!", "Add Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                ClearForm();

               
                showTable();
            }
    else
            {
                MessageBox.Show("Failed to add hotel.", "Add Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void ClearForm()
        {
            textBox_hname.Clear();
            textBox_location.Clear();
            textBox_hphone.Clear();
            textBox_hprice.Clear();
            pictureBox_Hotel.Image = null;
        }

        private void button_clearh_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
