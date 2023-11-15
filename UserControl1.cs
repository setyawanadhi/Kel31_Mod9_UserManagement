using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private string _customText;
        public string CustomText
        {
            get { return _customText; }
            set
            {
                _customText = value;
                UpdateLabelText();
            }
        }

        public MainPage Main { get; set; }
        public EditPage Edit { get; set; }

        public int Id { get; set; }

        private void UpdateLabelText()
        {
            UsernameComponent.Text = _customText;
        }

        private void DeleteButtonUser_Click(object sender, EventArgs e)
        {
            DeleteUserData(Id);
            this.Dispose();
        }

        private async void DeleteUserData(int userId)
        {
            string apiEndpoint = $"https://localhost:7218/api/UserAPI/{userId}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.DeleteAsync(apiEndpoint);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EditButtonUser_Click(object sender, EventArgs e)
        {
            Edit.Show();
            Main.Hide();
        }
    }
}
