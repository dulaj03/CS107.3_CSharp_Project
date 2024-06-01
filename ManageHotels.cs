using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace horizon_travels_and_tours
{
    public partial class ManageHotels : Form
    {
        private HotelClass hotel = new HotelClass();
        private DataTable dataTable;

        public ManageHotels()
        {
            InitializeComponent();
        }

        private void ManageHotels_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void showTable()
        {
            DataGridView_hotel.DataSource = hotel.getHotelList();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_hotel.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void DataGridView_hotel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_hotelId.Text = DataGridView_hotel.CurrentRow.Cells[0].Value.ToString();
            textBox_hname.Text = DataGridView_hotel.CurrentRow.Cells[1].Value.ToString();
            textBox_location.Text = DataGridView_hotel.CurrentRow.Cells[2].Value.ToString();
            textBox_hphone.Text = DataGridView_hotel.CurrentRow.Cells[3].Value.ToString();
            textBox_hprice.Text = DataGridView_hotel.CurrentRow.Cells[4].Value.ToString();

            dateTimePicker1h.Value = (DateTime)DataGridView_hotel.CurrentRow.Cells[5].Value;
            dateTimePicker2h.Value = (DateTime)DataGridView_hotel.CurrentRow.Cells[6].Value;

            if (DataGridView_hotel.CurrentRow.Cells[7].Value != null)
            {
                decimal rating = Convert.ToDecimal(DataGridView_hotel.CurrentRow.Cells[7].Value);
                guna2RatingStar1.Value = (float)rating;


            }
            else
            {
                guna2RatingStar1.Value = 0;
            }

            if (DataGridView_hotel.CurrentRow.Cells[8].Value != null)
            {
                if (DataGridView_hotel.CurrentRow.Cells[8].Value is Image)
                {
                    pictureBox_Hotel.Image = (Image)DataGridView_hotel.CurrentRow.Cells[8].Value;
                }
                else if (DataGridView_hotel.CurrentRow.Cells[8].Value is byte[])
                {
                    byte[] himg = (byte[])DataGridView_hotel.CurrentRow.Cells[8].Value;
                    MemoryStream ms = new MemoryStream(himg);
                    pictureBox_Hotel.Image = Image.FromStream(ms);
                }
            }
        }

        private void button_clearhm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void button_searchm_Click(object sender, EventArgs e)
        {
            string searchData = textBox_searchhm.Text.Trim();
            if (!string.IsNullOrEmpty(searchData))
            {
                DataTable searchResult = hotel.searchHotels(searchData);
                if (searchResult.Rows.Count > 0)
                {
                    DataGridView_hotel.DataSource = searchResult;
                    DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)DataGridView_hotel.Columns["Image"];
                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
                else
                {
                    MessageBox.Show("No hotels found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                showTable();
            }
        }

        /*private void button_upload_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Verify())
                {
                    MessageBox.Show("Please fill in all the fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg, *.png, *.jpeg, *.gif, *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_Hotel.Image = new Bitmap(openFileDialog.FileName);
                }
                else
                {
                    MessageBox.Show("No image selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */
        private void button_updatehm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Verify())
                {
                    MessageBox.Show("Please fill in all the fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(textBox_hotelId.Text, out int hid))
                {
                    MessageBox.Show("Invalid hotel ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string hname = textBox_hname.Text;
                string location = textBox_location.Text;
                string phone = textBox_hphone.Text;

                if (!int.TryParse(textBox_hprice.Text, out int price))
                {
                    MessageBox.Show("Invalid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime checkin = dateTimePicker1h.Value;
                DateTime checkout = dateTimePicker2h.Value;

                if (checkin < DateTime.Now || checkout < DateTime.Now)
                {
                    MessageBox.Show("Check-in and Check-out dates must be in the future.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal rating = Convert.ToDecimal(guna2RatingStar1.Value);

                byte[] himg = null;
                if (pictureBox_Hotel.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox_Hotel.Image.Save(ms, pictureBox_Hotel.Image.RawFormat);
                        himg = ms.ToArray();
                    }
                }

                if (hotel.updateHotel(hid, hname, location, phone, price, checkin, checkout, rating, himg))
                {
                    MessageBox.Show("Hotel details updated successfully!", "Update Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showTable();
                }
                else
                {
                    MessageBox.Show("Failed to update hotel.", "Update Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_deletehm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_hotelId.Text))
            {
                int hid;
                if (!int.TryParse(textBox_hotelId.Text, out hid))
                {
                    MessageBox.Show("Invalid hotel ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (hotel.deleteHotel(hid))
                {
                    MessageBox.Show("Hotel deleted successfully!", "Delete Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showTable();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to delete hotel.", "Delete Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a hotel to delete.", "Delete Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Verify()
        {
            return !(string.IsNullOrWhiteSpace(textBox_hname.Text) ||
                     string.IsNullOrWhiteSpace(textBox_location.Text) ||
                     string.IsNullOrWhiteSpace(textBox_hphone.Text) ||
                     string.IsNullOrWhiteSpace(textBox_hprice.Text) ||
                     pictureBox_Hotel.Image == null);
        }

        private void ClearForm()
        {
            textBox_hotelId.Clear();
            textBox_hname.Clear();
            textBox_location.Clear();
            textBox_hphone.Clear();
            textBox_hprice.Clear();
            dateTimePicker1h.Value = DateTime.Now;
            dateTimePicker2h.Value = DateTime.Now;
            guna2RatingStar1.Value = 0;
            pictureBox_Hotel.Image = null;
        }

        private byte[] ImageToByteArray(Image himg)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                himg.Save(ms, himg.RawFormat);
                return ms.ToArray();
            }
        }

        private void button_uploadh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_Hotel.Image = Image.FromFile(opf.FileName);
        }
    }
}





