using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Google.Apis.PeopleService.v1;
using Google.Apis.PeopleService.v1.Data;
using Google.Apis.Services;


namespace OAUTH_FINAL_FINAL
{
    public partial class Form1 : Form
    {
        // Scopes needed for accessing user profile and email
        static string[] Scopes = { "https://www.googleapis.com/auth/userinfo.email", "https://www.googleapis.com/auth/userinfo.profile" };
        static string ApplicationName = "Google OAuth WinForms App";
        UserCredential credential;

        //Client ID and Secret
        private const string ClientId = "77798700369-ncovj9o6cai378k4b67ac8melo1mlbbo.apps.googleusercontent.com";
        private const string ClientSecret = "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";
        private const string RedirectUri = "http://localhost";

        public Form1()
        {
            InitializeComponent();
        }

        private async void GoogleSign_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Create the OAuth2 credentials using hardcoded Client ID and Secret
                var clientSecrets = new ClientSecrets
                {
                    ClientId = ClientId,
                    ClientSecret = ClientSecret
                };

                //Step 2: Authorize the request 
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    clientSecrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore("GoogleOAuthCredentials", true) // Store credentials
                );

                GoogleSign_BTN.Visible = false;
                GoogleSign_BTN.Enabled = false;

                // Stpe 3: fetch user data from Google People API
                var service = new PeopleServiceService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName
                });

                // Getting user profile information (name, email, and profile picture)
                var profileRequest = service.People.Get("people/me");
                profileRequest.PersonFields = "names,emailAddresses,photos";
                Person profile = await profileRequest.ExecuteAsync();


                string userName = profile.Names?[0]?.DisplayName ?? "Unknown";
                string userEmail = profile.EmailAddresses?[0]?.Value ?? "Unknown";

                // Trying to get the user profile picture
                try
                {
                    // Try fetching the profile picture URL
                    string userProfilePictureUrl = profile.Photos?[0]?.Url ?? "No profile picture";

                    // Try loading the profile picture into a PictureBox if a URL is available
                    if (!string.IsNullOrEmpty(userProfilePictureUrl) && userProfilePictureUrl != "No profile picture")
                    {
                        UserProfile_PB.Load(userProfilePictureUrl);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading profile picture: {ex.Message}");
                }

                Status_lb.Location = new Point(Status_lb.Location.X - 50, Status_lb.Location.Y);
                Status_lb.Font = new Font("Microsoft Sans Serif", 20);
                Status_lb.Text = $"Welcome {userName}!\nEmail: {userEmail}";
               
                

                SignOut_BTN.Enabled = true;
                SignOut_BTN.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }

        }

        private void SignOut_BTN_Click(object sender, EventArgs e)
        {
            string credentialsFolderPath = Path.Combine(Application.StartupPath, "GoogleOAuthCredentials");

            // Check if the directory exists
            if (Directory.Exists(credentialsFolderPath))
            {
                // Delete all files inside the folder
                var files = Directory.GetFiles(credentialsFolderPath);
                foreach (var file in files)
                {
                    File.Delete(file); // Delete the stored file
                }

                // Optionally, delete the folder if it is empty
                Directory.Delete(credentialsFolderPath);
            }

            credential = null;

            Status_lb.Location = new Point(Status_lb.Location.X + 50, Status_lb.Location.Y);
            Status_lb.Font = new Font("Microsoft Sans Serif", 25);
            Status_lb.Text = "Not Logged In";

            GoogleSign_BTN.Visible = true;
            GoogleSign_BTN.Enabled = true;

            SignOut_BTN.Enabled = false;
            SignOut_BTN.Visible = false;
            UserProfile_PB.Image = null;

            MessageBox.Show("Logged out successfully!");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserProfile_PB_Click(object sender, EventArgs e)
        {

        }
    }
}
