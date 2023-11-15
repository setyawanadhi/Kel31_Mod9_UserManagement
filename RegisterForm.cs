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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form1 loginPage = new Form1();
            loginPage.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e){ }

        private async void SubmitRegistration_Click(object sender, EventArgs e)
        {
            Registration registrationData = new Registration
            {
                Username = UsernameRegister.Text,
                Password = PasswordRegister.Text,
            };

            bool registrationSuccess = await SubmitRegistrationAsync(registrationData);

            if (registrationSuccess)
            {
                Form1 login = new Form1();
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> SubmitRegistrationAsync(Registration registrationData)
        {
            
            string apiEndpoint = "https://localhost:7218/api/UserAPI";

            if (registrationData.Username == "" || registrationData.Password == "")
            {
                return false;
            }
            else
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonConvert.SerializeObject(registrationData);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiEndpoint, content);

                    return response.IsSuccessStatusCode;
                }
            }
        }
    }

    public class Registration
    {
        public int Id = 0;
        public string Username { get; set; }
        public string Password { get; set; }
    }
}