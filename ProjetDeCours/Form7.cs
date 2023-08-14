using Google.Apis.Auth.OAuth2;
using Google.Apis.Oauth2.v2;
using Google.Apis.Services;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetDeCours
{
    public partial class Form7 : Form
    {
        public static bool IsLogged=false;
       // public string ch= "<meta name="google-Site-verification" content="sRyBLXt6kMFTPWPtfeI2kLPJyUF5rEDt8pdOaePZJ4Q" />"

        public Form7()
        {
            InitializeComponent();
            (new Core.DropShaddow()).ApplyShadows(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       /* private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";
                string returnValue = "";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select email ,pass   from personne where email=@email and pass=@password ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@email", (txtEmail.Text));
                cmd.Parameters.AddWithValue("@password", (txtPass.Text));
                returnValue = (string)cmd.ExecuteScalar();
                /*cmd.Parameters.AddWithValue("@prenom", (txtPrenom.Text));
                cmd.Parameters.AddWithValue("@fonction", (txtFonction.Text));
                cmd.Parameters.AddWithValue("@idper", int.Parse(txtIdPer.Text));
                cmd.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
                cmd.Parameters.AddWithValue("@sexe", (txtSexe.Text));*/
                //cmd.ExecuteReader();
                //this.playerTableAdapter.Fill(this.sportDBDataSet.Player);
                //MessageBox.Show("Player Has been added");
                /*if (String.IsNullOrEmpty(returnValue))
                {
                    MessageBox.Show("Incorrect username or password");
                    return;
                }else
                {
                    this.Close();
                    Form2 f1 = new Form2();
                    f1.Show();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/















            
        //}

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";
                string returnValue = "";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select email ,pass   from personne where email=@email and pass=@password ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@email", (txtEmail.Text));
                cmd.Parameters.AddWithValue("@password", (txtPass.Text));
                returnValue = (string)cmd.ExecuteScalar();
                /*cmd.Parameters.AddWithValue("@prenom", (txtPrenom.Text));
                cmd.Parameters.AddWithValue("@fonction", (txtFonction.Text));
                cmd.Parameters.AddWithValue("@idper", int.Parse(txtIdPer.Text));
                cmd.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
                cmd.Parameters.AddWithValue("@sexe", (txtSexe.Text));*/
//cmd.ExecuteReader();
//this.playerTableAdapter.Fill(this.sportDBDataSet.Player);
//MessageBox.Show("Player Has been added");
if (String.IsNullOrEmpty(returnValue))
{
    MessageBox.Show("Incorrect username or password");
    return;
}else
{
    IsLogged = true;
                    this.Hide();
                   
                    Form2 f1 = new Form2();
                    f1.Show();

}

}
catch (Exception ex)
{
MessageBox.Show(ex.Message);
}

}

        private  async void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Logindf();
         
        }
        private async void  Logindf()
        {

            UserCredential credential;
            using (var stream = new FileStream("code_secret_client_1051770946836-tj1e7jhc11p9uskgqdpc68qpunathbmq.apps.googleusercontent.com.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { Google.Apis.Oauth2.v2.Oauth2Service.Scope.UserinfoProfile, Google.Apis.Oauth2.v2.Oauth2Service.Scope.UserinfoEmail },
                    "user", CancellationToken.None);
            }

            // Create the service.
            var service = new Oauth2Service(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Organize-Me",
            });
            var userinfo = await service.Userinfo.Get().ExecuteAsync();
            Console.WriteLine(userinfo.Email);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            LoginFacebook frm = new LoginFacebook(((Button)sender).Tag.ToString());
            frm.ShowDialog();
        }

    }
    
}
