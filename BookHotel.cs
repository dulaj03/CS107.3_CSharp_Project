using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace horizon_travels_and_tours
{
    public partial class BookHotel : Form
    {
        private HotelClass hotel = new HotelClass();
        private DataTable dataTable;
        public BookHotel()
        {
            InitializeComponent();
        }
        private void BookHotel_Load(object sender, EventArgs e)
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
        private void DataGridView_hotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int bookButtonColumnIndex = 9;

            if (e.ColumnIndex == bookButtonColumnIndex && e.RowIndex >= 0)
            {


                int hotelId = Convert.ToInt32(DataGridView_hotel.Rows[e.RowIndex].Cells["HotelId"].Value);



                if (hotel.bookhotel(hotelId))
                {
                    MessageBox.Show("Hotel booked successfully!", "Book Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showTable();

                }
                else
                {
                    MessageBox.Show("Failed to book hotel.", "Book Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button_searchhb_Click(object sender, EventArgs e)
        {
            string searchData = textBox_searchhb.Text.Trim();
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

        private void button_bookh_Click(object sender, EventArgs e)
        {
            
                if (!string.IsNullOrEmpty(textBox_hid.Text))
                {
                    int hotelId;
                    if (!int.TryParse(textBox_hid.Text, out hotelId))
                    {
                        MessageBox.Show("Invalid hotel ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show("Hotel ID: " + hotelId, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (hotel.bookhotel(hotelId))
                    {
                        MessageBox.Show("Hotel booked successfully!", "Book Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showTable();
                    }
                    else
                    {
                        MessageBox.Show("Failed to book hotel.", "Book Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a hotel ID to book.", "Book Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

        }
    }
}
