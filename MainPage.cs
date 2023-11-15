using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void MainPage_Load(object sender, EventArgs e)
        {
            List<Acc> users = await LoadUserDataAsync();
            int i = 10;

            foreach (Acc user in users)
            {
                UserControl1 userComponent = new UserControl1();
                userComponent.CustomText = user.Username;
                userComponent.Id = user.Id;
                userComponent.Main = this;
                userComponent.Edit = new EditPage(user.Id);
                userComponent.Location = new System.Drawing.Point(i, 100);
                this.Controls.Add(userComponent);
                i+=200;
            }
        }

        private async Task<List<Acc>> LoadUserDataAsync()
        {
            string apiEndpoint = "https://localhost:7218/api/UserAPI";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiEndpoint);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Acc>>(json);
                }
                else
                {
                    MessageBox.Show("Failed to retrieve user data from the API.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<Acc>();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }

    public class Acc
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
