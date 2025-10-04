using System;
using System.Windows.Forms;

namespace Example06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnToFavorite.Click += BtnToFavorite_Click;
            btnToList.Click += BtnToList_Click;
            lstSongs.Items.AddRange(new object[] {
                "Đôi Mắt Pleiku",
                "Em Muốn Sống Bên Anh Trọn Đời",
                "H'Zen Lên Rẫy",
                "Còn Thương Nhau Thì Về Buôn Mê Thuột",
                "Ly Cà Phê Ban Mê",
                "Đi tìm lời ru mặt trời"
            });
            lstFavorite.Items.Add("53418 - Giấc mơ Chapi - Trần Tiến");
        }

        private void BtnToFavorite_Click(object sender, EventArgs e)
        {
            if (lstSongs.SelectedItem != null)
            {
                lstFavorite.Items.Add(lstSongs.SelectedItem);
                lstSongs.Items.Remove(lstSongs.SelectedItem);
            }
        }

        private void BtnToList_Click(object sender, EventArgs e)
        {
            if (lstFavorite.SelectedItem != null)
            {
                lstSongs.Items.Add(lstFavorite.SelectedItem);
                lstFavorite.Items.Remove(lstFavorite.SelectedItem);
            }
        }
    }
}
