using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

using Nemiro.OAuth;

using Nemiro.OAuth.Clients;

namespace ProjetDeCours
{
    public partial class LoginFacebook : Form
    {
        private string v;

        /*private string AppId = "12234567890987654";
private Url _loginUrl;
private const string _ExtendedPermissions = "user_about_me.publsh_stream.offline_access";*/
//FacebookClient fbClient = new FacebookClient();


        public LoginFacebook(string Facebook)
        {
            
            InitializeComponent();
            webBrowser1.Navigate(OAuthWeb.GetAuthorizationUrl(Facebook));
        }

        private void LoginFacebook_Load(object sender, EventArgs e)
        {
               OAuthManager.RegisterClient
                (
                  new FacebookClient
                  (
                    "1435890426686808",
                    "c6057dfae399beee9e8dc46a4182e8fd"
                  )
                  {
                      Parameters = new NameValueCollection { { "display", "popup" } }
                  }
                );

                OAuthManager.RegisterClient
                (
                  new YandexClient
                  (
                    "0ee5f0bf2cd141a1b194a2b71b0332ce",
                    "59d76f7c09b54ad38e6b15f792da7a9a"
                  )
                );
            }

        
        public void login()
        {
            //dynamic parameters = new expandoObject();





        }
         
        private void button1_Click(object sender, EventArgs e)
        {

            //facebookService1.ConnectToFacebook();
            /*txtUserName.Text = facebookService1.Users.GetInfo().first_name + " " + facebookService1.Users.GetInfo().last_name;
            txtGender.Text = facebookService1.Users.GetInfo().sex;*/
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
