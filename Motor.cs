using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalBike
{
    public partial class Motor : Form
    {
        private string apiUrl = "http://localhost:5222/api/";

        public object Id { get; internal set; }
        public string NamaMotor { get; internal set; }
        public decimal HargaSewa { get; internal set; }
        public string PlatMotor { get; internal set; }
        public string? GambarMotor { get; internal set; }

        public Motor()
        {
            InitializeComponent();
        }

        private async void Motor_Load(object sender, EventArgs e)
        {
            await LoadMotorData();
        }

        private async Task LoadMotorData()
        {
            data_motor.Items.Clear();
            data_motor.Columns.Clear();

            data_motor.Columns.Add("Nama Motor", 200);
            data_motor.Columns.Add("Plat Motor", 150);
            data_motor.Columns.Add("Harga Sewa", 150);
            data_motor.Columns.Add("Gambar Motor", 200);
            data_motor.Columns.Add("ID", 0); // Hidden

            var motors = await GetMotorsAsync();
            if (motors != null)
            {
                foreach (var m in motors)
                {
                    var item = new ListViewItem(m.nama_motor);
                    item.SubItems.Add(m.plat_motor);
                    item.SubItems.Add(m.harga_sewa);
                    item.SubItems.Add(m.gambar_motor);
                    item.SubItems.Add(m.id.ToString());
                    data_motor.Items.Add(item);
                }
            }
        }

        private async Task<List<MotorModel>> GetMotorsAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(apiUrl + "Motor");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<List<MotorModel>>(json);
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengambil data motor.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                return null;
            }
        }

        private async Task SendRequest(string method)
        {
            var selected = data_motor.SelectedItems.Count > 0 ? data_motor.SelectedItems[0] : null;
            var idText = selected?.SubItems[4].Text;

            if (string.IsNullOrWhiteSpace(txt_nama_motor.Text) ||
                string.IsNullOrWhiteSpace(txt_plat_motor.Text) ||
                string.IsNullOrWhiteSpace(txt_harga_sewa.Text) ||
                string.IsNullOrWhiteSpace(txt_gambar_motor.Text))
            {
                MessageBox.Show("Semua field harus diisi.");
                return;
            }

            var motor = new MotorModel
            {
                nama_motor = txt_nama_motor.Text,
                plat_motor = txt_plat_motor.Text,
                harga_sewa = txt_harga_sewa.Text,
                gambar_motor = txt_gambar_motor.Text
            };

            string url = apiUrl + "Motor";
            string json = JsonConvert.SerializeObject(motor);

            if (method == "PUT" && selected != null)
            {
                motor.id = int.Parse(idText);
                url += "/" + motor.id;
                json = JsonConvert.SerializeObject(motor);
            }
            else if (method == "DELETE" && selected != null)
            {
                url += "/" + idText;
                json = null;
            }

            using (HttpClient client = new HttpClient())
            {
                var content = json != null ? new StringContent(json, Encoding.UTF8, "application/json") : null;
                var request = new HttpRequestMessage(new HttpMethod(method), url)
                {
                    Content = content
                };

                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"{method} berhasil!");
                    await LoadMotorData();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show($"Gagal melakukan {method}.");
                }
            }
        }

        private void ResetForm()
        {
            txt_nama_motor.Text = "";
            txt_plat_motor.Text = "";
            txt_harga_sewa.Text = "";
            txt_gambar_motor.Text = "";
            save_btn.Enabled = true;
            update_btn.Enabled = false;
            delete_btn.Enabled = false;
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            await SendRequest("POST");
        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
            await SendRequest("PUT");
        }

        private async void delete_btn_Click(object sender, EventArgs e)
        {
            await SendRequest("DELETE");
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void data_motor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (data_motor.SelectedItems.Count > 0)
            {
                var item = data_motor.SelectedItems[0];
                txt_nama_motor.Text = item.SubItems[0].Text;
                txt_plat_motor.Text = item.SubItems[1].Text;
                txt_harga_sewa.Text = item.SubItems[2].Text;
                txt_gambar_motor.Text = item.SubItems[3].Text;

                save_btn.Enabled = false;
                update_btn.Enabled = true;
                delete_btn.Enabled = true;
            }
        }

        private void DataBooking_Click(object sender, EventArgs e)
        {
            new DataBooking().Show();
            this.Close();
        }
    }

    public class MotorModel
    {
        public int id { get; set; }
        public string nama_motor { get; set; }
        public string plat_motor { get; set; }
        public string harga_sewa { get; set; }
        public string gambar_motor { get; set; }
    }
}
