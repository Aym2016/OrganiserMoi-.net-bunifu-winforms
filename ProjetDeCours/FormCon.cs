using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetDeCours
{
    public partial class FormCon : Form
    {
        public FormCon()
        {
            InitializeComponent();
        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 f1 = new Form5();
            f1.Show();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into conjointe values (@id,@nom,@prenom,@fonction,@idper,@age,@sexe)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@id", int.Parse(txtIdPer.Text));
                cmd.Parameters.AddWithValue("@nom", (txtNom.Text));
                cmd.Parameters.AddWithValue("@prenom", (txtPrenom.Text));
                cmd.Parameters.AddWithValue("@fonction", (txtFonction.Text));
                cmd.Parameters.AddWithValue("@idper", int.Parse(txtIdPer.Text));
                cmd.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
                cmd.Parameters.AddWithValue("@sexe", (txtSexe.Text));
                cmd.ExecuteNonQuery();
                //this.playerTableAdapter.Fill(this.sportDBDataSet.Player);
                MessageBox.Show("Conjointe Has been added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }/*finally
            {
                if (con.CurrentState == ConnectionState.Open)
                {
                    con.Close();
                }
                    

            }*/

        }
    }
}
