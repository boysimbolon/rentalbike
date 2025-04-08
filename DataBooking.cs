using System;
using System.Windows.Forms;

namespace RentalBike
{
    public partial class DataBooking : Form
    {
        public string NamaPemesan { get; internal set; }
        public string EmailPemesan { get; internal set; }
        public string NoHpPemesan { get; internal set; }
        public int MotorId { get; internal set; }
        public DateTime RentalDate { get; internal set; }
        public int LamaJam { get; internal set; }
        public string RentalStatus { get; internal set; }

        public DataBooking()
        {
            InitializeComponent();
            InitializeStatusComboBox();
            InitializeListView();
        }

        private void InitializeStatusComboBox()
        {
            status.Items.Clear();
            status.Items.Add("Dipakai");
            status.Items.Add("Selesai");
            status.Items.Add("Dibatalkan");
        }

        private void InitializeListView()
        {
            data_rental.Columns.Clear();
            data_rental.Columns.Add("Nama", 120);
            data_rental.Columns.Add("Email", 120);
            data_rental.Columns.Add("No Telepon", 100);
            data_rental.Columns.Add("Tanggal Rental", 100);
            data_rental.Columns.Add("Lama Jam", 80);
            data_rental.Columns.Add("Status", 100);
            data_rental.FullRowSelect = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nama.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_no_telepon.Text) ||
                string.IsNullOrWhiteSpace(txt_date.Text) ||
                string.IsNullOrWhiteSpace(txt_lama_jam.Text) ||
                status.SelectedItem == null)
            {
                MessageBox.Show("Harap isi semua field!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = new ListViewItem(txt_nama.Text);
            item.SubItems.Add(txt_email.Text);
            item.SubItems.Add(txt_no_telepon.Text);
            item.SubItems.Add(txt_date.Text);
            item.SubItems.Add(txt_lama_jam.Text);
            item.SubItems.Add(status.SelectedItem.ToString());

            data_rental.Items.Add(item);
            ClearForm();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (data_rental.SelectedItems.Count == 0)
            {
                MessageBox.Show("Pilih data yang akan diupdate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedItem = data_rental.SelectedItems[0];
            selectedItem.SubItems[0].Text = txt_nama.Text;
            selectedItem.SubItems[1].Text = txt_email.Text;
            selectedItem.SubItems[2].Text = txt_no_telepon.Text;
            selectedItem.SubItems[3].Text = txt_date.Text;
            selectedItem.SubItems[4].Text = txt_lama_jam.Text;
            selectedItem.SubItems[5].Text = status.SelectedItem?.ToString();

            ClearForm();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (data_rental.SelectedItems.Count > 0)
            {
                data_rental.Items.Remove(data_rental.SelectedItems[0]);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void data_rental_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (data_rental.SelectedItems.Count > 0)
            {
                var selectedItem = data_rental.SelectedItems[0];
                txt_nama.Text = selectedItem.SubItems[0].Text;
                txt_email.Text = selectedItem.SubItems[1].Text;
                txt_no_telepon.Text = selectedItem.SubItems[2].Text;
                txt_date.Text = selectedItem.SubItems[3].Text;
                txt_lama_jam.Text = selectedItem.SubItems[4].Text;
                status.SelectedItem = selectedItem.SubItems[5].Text;
            }
        }

        private void motor_Click(object sender, EventArgs e)
        {
            new Motor().Show();
            this.Close();
        }

        private void ClearForm()
        {
            txt_nama.Clear();
            txt_email.Clear();
            txt_no_telepon.Clear();
            txt_date.Clear();
            txt_lama_jam.Clear();
            status.SelectedIndex = -1;
        }

    }
}
