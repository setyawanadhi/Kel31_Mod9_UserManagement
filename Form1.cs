using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;

namespace UserManagement
{
    public partial class Form1 : Form
    {
        private List<User> users;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            PasswordLogin.PasswordChar = '*';
            users = await LoadUserDataAsync();
        }

        private async Task<List<User>> LoadUserDataAsync()
        {
            string apiEndpoint = "https://localhost:7218/api/UserAPI";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiEndpoint);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<User>>(json);
                }
                else
                {
                    MessageBox.Show("Failed to retrieve user data from the API.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<User>();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string enteredUsername = UsernameLogin.Text;
            string enteredPassword = PasswordLogin.Text;

            if (string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Please enter both username and password.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User authenticatedUser = users.Find(u => u.Username == enteredUsername && u.Password == enteredPassword);

            if (authenticatedUser != null)
            {
                MainPage main = new MainPage();
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.Show();
            this.Hide();
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}