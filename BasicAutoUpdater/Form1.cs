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

namespace BasicAutoUpdater
{
    public partial class autoUpdateForm : Form
    {
        string serverVersion; //Create serverVersion variable
        string clientVersion = "1.0"; //Create clientVersion variable and define the version of this client
        string serverLink = "https://danthedev.co.uk/api/autoUpdate/test/"; //Link of raw text containing server (updated client) version.
        WebClient client = new WebClient(); //Define webclient object

        public autoUpdateForm()
        {
            InitializeComponent();
        }

        private void updateClient()
        {
            clientVersionLabel.Text = "Client Version: " + clientVersion; //Updates the label with the version
            serverVersion = client.DownloadString(serverLink); //Downloads the server-side client version
            serverVersionLabel.Text = "Server Version: " + serverVersion; //Updates the label with the version

            if (serverVersion != clientVersion) //If the server version isn't equal to the client version
            {
                DialogResult messageBox = MessageBox.Show("A new version is available. Download?", "Update", MessageBoxButtons.YesNo); //Displays a message box with the title "Update" and two buttons (Yes/No)

                if (messageBox == DialogResult.Yes) //If user presses the "Yes" button on the messagebox
                {
                    client.DownloadFile("File link", "File name"); //Function will download the new client via the link and save it as the name provided
                }
            }
        }

        private void autoUpdateForm_Load(object sender, EventArgs e) //Fires when the form is loaded
        {
            updateClient(); //Calls the updateclient function as defined above
        }
    }
}
