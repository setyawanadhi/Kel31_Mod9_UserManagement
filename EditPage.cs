using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement
{
    public partial class EditPage : Form
    {
        private int Id;
        public EditPage(int userId)
        {
            InitializeComponent();
            this.Id = userId;
            this.Load += EditPage_LoadAsync;
        }

        private async void EditPage_LoadAsync(object sender, EventArgs e)
        {
            Account user = await LoadUserDataAsync(Id);

            EditUsername.Text = user.Username;
            EditPassword.Text = user.Password;
        }

        private async Task<Account> LoadUserDataAsync(int userId)
        {
            string userApiEndpoint = $"https://localhost:7218/api/UserAPI/{userId}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(userApiEndpoint);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Account>(json);
                }
                else
                {
                    MessageBox.Show($"Failed to retrieve user data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private async Task UpdateUserDataAsync(string apiEndpoint, Account updatedUser)
        {
            using (HttpClient client = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(updatedUser);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync(apiEndpoint, content);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Failed to update user data. Status code: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Hide();
        }

        private async void SubmitEdit_Click(object sender, EventArgs e)
        {
            if (EditUsername.Text == "" || EditPassword.Text == "")
            {
                MessageBox.Show("Please fill the text boxs.", "Bruh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MainPage main = new MainPage();
                string userApiEndpoint = $"https://localhost:7218/api/UserAPI/{Id}";
                Account updatedUser = new Account
                {
                    Id = Id,
                    Username = EditUsername.Text,
                    Password = EditPassword.Text,
                };
                await UpdateUserDataAsync(userApiEndpoint, updatedUser);
                MessageBox.Show("User data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.Show();
                this.Hide();
            }
        }
    }
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
