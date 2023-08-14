using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Image = System.Windows.Controls.Image;

namespace ProjetDeCours
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            /*
            ComboBoxItem typeItem = (ComboBoxItem)cmbEnfant.SelectedItem;
            string value1 = typeItem.Content.ToString();
            ComboBoxItem typeItem1 = (ComboBoxItem)cmbParent.SelectedItem;
            string value2 = typeItem1.Content.ToString();
            ComboBoxItem typeItem2 = (ComboBoxItem)cmbSituation.SelectedItem;
            string value3 = typeItem2.Content.ToString();*/
            /* try
             {
                 SqlConnection con = new SqlConnection();
                 con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

                 con.Open();
                 SqlCommand cmd = new SqlCommand();
                 cmd.CommandText = "insert into personne values (@id,@nom,@prenom,@fonction,@dateNaiss,@sexe,@situation,@pass,@numtel,@parent,@NbEnfant,@enfant,@image)";
                 cmd.CommandType = CommandType.Text;
                 cmd.Connection = con;
                 cmd.Parameters.AddWithValue("@id", int.Parse(txtIdPer.Text));
                 cmd.Parameters.AddWithValue("@nom", (txtNom.Text));
                 cmd.Parameters.AddWithValue("@prenom", (txtPrenom.Text));
                 cmd.Parameters.AddWithValue("@fonction", (txtFonction.Text));
                 //cmd.Parameters.AddWithValue("@idper", int.Parse(txtIdPer.Text));
                 cmd.Parameters.AddWithValue("@dateNaiss",(DNS.Text));
                 cmd.Parameters.AddWithValue("@sexe", (txtSexe.Text));
                 cmd.Parameters.AddWithValue("@situation", (value3));
                 cmd.Parameters.AddWithValue("@pass", (txtMdp.Text));
                 cmd.Parameters.AddWithValue("@numtel", (txtNumTel.Text));
                 cmd.Parameters.AddWithValue("@parent", (value3));
                 cmd.Parameters.AddWithValue("@NbEnfant",int.Parse(txtNbEnfant.Text));
                 cmd.Parameters.AddWithValue("@enfant", (value1));
                 //Image image1 = Image.FromFile(Profile);
                 cmd.Parameters.AddWithValue("@enfant", (value1));

                 cmd.ExecuteNonQuery();*/
            //this.playerTableAdapter.Fill(this.sportDBDataSet.Player);
            //MessageBox.Show("Enfant Has been added");
            /*
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }*/







            this.Hide();
            Form4 f2 = new Form4(); 
            f2.Show();
         



        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void a_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
