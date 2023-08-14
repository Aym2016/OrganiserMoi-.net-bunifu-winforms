using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetDeCours
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";
                con.Open();
                for (int i = 700; i < 2000; i++) {
                    
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "insert into parent values (@id,@nom,@prenom,@fonction,@idper,@age,@sexe)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@id", i);
                    cmd.Parameters.AddWithValue("@nom", ("nom"+i.ToString()));
                    cmd.Parameters.AddWithValue("@prenom", ("prenom"+ i.ToString()));
                    cmd.Parameters.AddWithValue("@fonction", ("ingénieur"+i.ToString()));
                    cmd.Parameters.AddWithValue("@idper", (1));
                    cmd.Parameters.AddWithValue("@age", (47));
                    cmd.Parameters.AddWithValue("@sexe", ("Male"));
                    cmd.ExecuteNonQuery(); }
                //this.enfantTableAdapter.Fill(this.organizeMeDataSet.enfant);
               // MessageBox.Show("Enfant Has been added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/







           /* Inscription f1 = new Inscription();
            
            Application.Run(f1);*/
           
            Form7 f2 = new Form7();

           Application.Run(f2);

            /*if (Inscription.success == true)
            {
               f1.Close();
                Application.Run(f2);
            }*/

            /*Form2 f1 = new Form2();
            Application.Run(f1);*/
            /*if (Form7.IsLogged == true)
            {
                f2.Close();
            }*/

            /*Form2 f3 = new Form2();
             Application.Run(f3);*/
            

        }
    }
}

