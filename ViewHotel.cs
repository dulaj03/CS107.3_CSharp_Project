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
    public partial class ViewHotel : Form
    {
        private HotelClass hotel = new HotelClass();
        private DataTable dataTable;
        public ViewHotel()
        {
            InitializeComponent();
        }

        private void ViewHotel_Load(object sender, EventArgs e)
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

        private void button_searchv_Click(object sender, EventArgs e)
        {
            string searchData = textBox_searchhv.Text.Trim();
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
    }
}
