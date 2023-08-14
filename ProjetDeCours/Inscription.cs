
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetDeCours
{
    

    public partial class Inscription : Form
    {
        public static bool success = false;
        public string enf1;
        public string par1;
        public string gender;
        public string gender1;
        public string genderE;
        public string genderC;

        public Inscription()
        {   
            InitializeComponent();
            //add shadows
            (new Core.DropShaddow()).ApplyShadows(this);
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnToProfile_Click(object sender, EventArgs e)
        {
            bunifuPages9.SetPage("Profile");
        }

        private void btnToLogin_Click(object sender, EventArgs e)
        {
            bunifuPages9.SetPage("Login");
        }

        private void btnNextBilling_Click(object sender, EventArgs e)
        {
            bunifuPages9.SetPage("Billing");
        }

        private void btnPrevToProfile_Click(object sender, EventArgs e)
        {
            bunifuPages9.SetPage("Profile");
        }

        private void btnNextFinish_Click(object sender, EventArgs e)
        {
            //upload info here



            bunifuPages9.SetPage("Finish");
            r6.Checked = r6.Enabled = true;
            l6.ForeColor = Color.Indigo;

        }

        private void BunifuPages9_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update steps
            switch (bunifuPages9.SelectedIndex)
            {
                case 1:
                    r1.Checked = r1.Enabled = true;
                    l1.ForeColor = Color.Indigo;
                    break;
                case 2:
                    r2.Checked = r2.Enabled = true;
                    l2.ForeColor = Color.Indigo;
                    break;
                case 3:
                    r3.Checked = r3.Enabled = true;
                    l3.ForeColor = Color.Indigo;
                    break;
                case 4:
                    r4.Checked = r4.Enabled = true;
                    l4.ForeColor = Color.Indigo;
                    break;
                case 5:
                    r5.Checked = r5.Enabled = true;
                    l5.ForeColor = Color.Indigo;
                    break;

            }

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void l3_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnToProfile_Click_1(object sender, EventArgs e)
        {
            bunifuPages9.SetPage("User Info");
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            bunifuPages9.SetPage("User Info");
        }
        public string situation;
        private void btnNextBilling_Click_1(object sender, EventArgs e)
        {
            if (s1.Checked == true)
            {
                situation = "célibataire";
            }
            else if (s2.Checked == true)
            {
                situation = "divorcé";
            }
            else
            {
                situation = "marié";
            }
            if (g1.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            if (p1.Checked == true)
            {
                par1 = "oui";
            }
            else
            {
                par1 = "non";
            }
            if (e1.Checked == true)
            {
                enf1 = "oui";
            }
            else
            {
                enf1 = "non";
            }

            /*
            ComboBoxItem typeItem = (ComboBoxItem)cmbEnfant.SelectedItem;
            string value1 = typeItem.Content.ToString();
            ComboBoxItem typeItem1 = (ComboBoxItem)cmbParent.SelectedItem;
            string value2 = typeItem1.Content.ToString();
            ComboBoxItem typeItem2 = (ComboBoxItem)cmbSituation.SelectedItem;
            string value3 = typeItem2.Content.ToString();*/
          /*  try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into personne values (@id,@nom,@prenom,@fonction,@dateNaiss,@email,@sexe,@situation,@pass,@numtel,@parent,@NbEnfant,@enfant,@image)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@id", int.Parse(txtIdPer1.Text));
                cmd.Parameters.AddWithValue("@nom", (txtNomPer1.Text));
                cmd.Parameters.AddWithValue("@prenom", (txtPrenomPer1.Text));
                cmd.Parameters.AddWithValue("@fonction", (txtFonctionPer1.Text));
                //cmd.Parameters.AddWithValue("@idper", int.Parse(txtIdPer.Text));
                cmd.Parameters.AddWithValue("@dateNaiss", (DNS.Value));
                cmd.Parameters.AddWithValue("@email", (txtEmail.Text));
                cmd.Parameters.AddWithValue("@sexe", (gender));
                cmd.Parameters.AddWithValue("@situation", (situation));
                cmd.Parameters.AddWithValue("@pass", (txtPassPer1.Text));
                cmd.Parameters.AddWithValue("@numtel", (txtNumTelPer1.Text));
                cmd.Parameters.AddWithValue("@parent", (par1));
                cmd.Parameters.AddWithValue("@NbEnfant", int.Parse(txtNbPer1.Text));
                cmd.Parameters.AddWithValue("@enfant", (enf1));
                Image image = Image.FromFile(imageLocation);
                cmd.Parameters.AddWithValue("@image", (ConvertImageToBinary(image)));*/

                //ConvertImageToBinary(Image img)


                //Image image1 = Image.FromFile(Profile);
                //cmd.Parameters.AddWithValue("@enfant", (value1));

                 //cmd.ExecuteNonQuery();
                //this.playerTableAdapter.Fill(this.sportDBDataSet.Player);
               //MessageBox.Show("Person Has been added");
                if (enf1 == "non" && par1 == "non" && situation == "célibataire")
                {
                    //cmd.ExecuteNonQuery();
                    //MessageBox.Show("Person Has been added");
                    r2.Checked = r2.Enabled = true;
                    l2.ForeColor = Color.Indigo;
                    r3.Checked = r3.Enabled = true;
                    l3.ForeColor = Color.Indigo;
                    r4.Checked = r4.Enabled = true;
                    l4.ForeColor = Color.Indigo;
                    r5.Checked = r5.Enabled = true;
                    l5.ForeColor = Color.Indigo;
                    r6.Checked = r6.Enabled = true;
                    l6.ForeColor = Color.Indigo;
                    // bunifuPages9.SetPage("Parent Info");
                    bunifuPages9.SetPage("Success");

                }
                else if ((enf1 == "non" && situation == "célibataire" && par1 == "oui") || (enf1 == "non" && (situation == "marié" || situation == "divorcé") && par1 == "oui") || (enf1 == "oui" && situation == "célibataire" && par1 == "oui") || (enf1 == "oui" && (situation == "marié" || situation == "divorcé") && par1 == "oui"))
                {
                    //cmd.ExecuteNonQuery();
                    //MessageBox.Show("Person Has been added");
                    bunifuPages9.SetPage("Parent Info");

                }
                else if ((enf1 == "oui" && (situation == "marié" || situation == "divorcé") && par1 == "non") || (enf1 == "oui" && situation == "célibataire" && par1 == "non"))
                {
                    //cmd.ExecuteNonQuery();
                    //MessageBox.Show("Person Has been added");
                    r2.Checked = r2.Enabled = true;
                    l2.ForeColor = Color.Indigo;
                    r3.Checked = r3.Enabled = true;
                    l3.ForeColor = Color.Indigo;
                    bunifuPages9.SetPage("Enfant Info");
                }
                else if (enf1 == "non" && (situation == "marié" || situation == "divorcé") && par1 == "non")
                {
                    //cmd.ExecuteNonQuery();
                   // MessageBox.Show("Person Has been added");
                    r2.Checked = r2.Enabled = true;
                    l2.ForeColor = Color.Indigo;
                    r3.Checked = r3.Enabled = true;
                    l3.ForeColor = Color.Indigo;
                    r4.Checked = r4.Enabled = true;
                    l4.ForeColor = Color.Indigo;
                    bunifuPages9.SetPage("Conjointe Info");
                }

           /* }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

            
            /*else if (enf1 == "oui" && situation == "celibataire" && par1 == "non")
            {
                r3.Checked = r3.Enabled = true;
                l3.ForeColor = Color.Indigo;
                bunifuPages9.SetPage("Enfant Info");
            }*/



        

            /*else if (enf1 == "non" && (situation == "marié" || situation == "célibataire") && par1 == "oui")
            {
                /*r3.Checked = r3.Enabled = true;
                l3.ForeColor = Color.Indigo;
                r4.Checked = r4.Enabled = true;
                l4.ForeColor = Color.Indigo;
                r5.Checked = r5.Enabled = true;
                l5.ForeColor = Color.Indigo;
                r6.Checked = r6.Enabled = true;
                l6.ForeColor = Color.Indigo;*/
                /*bunifuPages9.SetPage("Parent Info");
            }*/
            /*else if (enf1 == "non" && (situation == "marié" || situation == "divorcé") && par1 == "oui")
            {
                r2.Checked = r2.Enabled = true;
                l2.ForeColor = Color.Indigo;
                r3.Checked = r3.Enabled = true;
                l3.ForeColor = Color.Indigo;
                r4.Checked = r4.Enabled = true;
                l4.ForeColor = Color.Indigo;
                bunifuPages9.SetPage("Conjointe Info");
            }*/



        }

        private void btnNextFinish_Click_1(object sender, EventArgs e)
        {
            bunifuPages9.SetPage("Enfant Info");
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            bunifuPages9.SetPage("Conjointe Info");
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuPages9.SetPage("Success");
            r6.Checked = r6.Enabled = true;
            l6.ForeColor = Color.Indigo;
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into enfant values (@id,@nom,@prenom,@fonction,@idper,@age,@sexe)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@id", int.Parse(txtIdE1.Text));
                cmd.Parameters.AddWithValue("@nom", (txtNomE1.Text));
                cmd.Parameters.AddWithValue("@prenom", (txtPrenomE1.Text));
                cmd.Parameters.AddWithValue("@fonction", (txtFonctionE1.Text));
                cmd.Parameters.AddWithValue("@idper", int.Parse(txtIdPer1.Text));
                cmd.Parameters.AddWithValue("@age", int.Parse(txtAgeE1.Text));
                cmd.Parameters.AddWithValue("@sexe", (genderE));
                cmd.ExecuteNonQuery();
                //this.parentTableAdapter.Fill(this.organizeMeDataSet1.parent);
                //this.playerTableAdapter.Fill(this.sportDBDataSet.Player);
                MessageBox.Show("enfant Has been added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAjouterP1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into parent values (@id,@nom,@prenom,@fonction,@idper,@age,@sexe)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@id", int.Parse(txtIdP1.Text));
                cmd.Parameters.AddWithValue("@nom", (txtNomP1.Text));
                cmd.Parameters.AddWithValue("@prenom", (txtPrenomP1.Text));
                cmd.Parameters.AddWithValue("@fonction", (txtFonctionP1.Text));
                cmd.Parameters.AddWithValue("@idper", int.Parse(txtIdPer1.Text));
                cmd.Parameters.AddWithValue("@age", int.Parse(txtAgeP1.Text));
                cmd.Parameters.AddWithValue("@sexe", (gender1));
                cmd.ExecuteNonQuery();
                //this.parentTableAdapter.Fill(this.organizeMeDataSet1.parent);
                //this.playerTableAdapter.Fill(this.sportDBDataSet.Player);
                MessageBox.Show("parent Has been added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAjouterC1_Click(object sender, EventArgs e)
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
                cmd.Parameters.AddWithValue("@id", int.Parse(txtIdC1.Text));
                cmd.Parameters.AddWithValue("@nom", (txtNomC1.Text));
                cmd.Parameters.AddWithValue("@prenom", (txtPrenomC1.Text));
                cmd.Parameters.AddWithValue("@fonction", (txtFonctionC1.Text));
                cmd.Parameters.AddWithValue("@idper", int.Parse(txtIdPer1.Text));
                cmd.Parameters.AddWithValue("@age", int.Parse(txtAgeC1.Text));
                cmd.Parameters.AddWithValue("@sexe", (genderC));


                cmd.ExecuteNonQuery();

                //this.parentTableAdapter.Fill(this.organizeMeDataSet1.parent);
                //this.playerTableAdapter.Fill(this.sportDBDataSet.Player);
                MessageBox.Show("conjointe Has been added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string fileName;

       /* private  void bunifuButton8_Click_1(object sender, EventArgs e)
        {
            
             try
             {
                 SqlConnection con = new SqlConnection();
                 con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

                 con.Open();
                 SqlCommand cmd = new SqlCommand();
                 cmd.CommandText = "insert into md values (@id,@image,@dateNaiss)";
                 cmd.CommandType = CommandType.Text;
                 cmd.Connection = con;
                 cmd.Parameters.AddWithValue("@id", int.Parse(txtIdPer1.Text));
                 Image image = Image.FromFile(imageLocation);
                 cmd.Parameters.AddWithValue("@image", (ConvertImageToBinary(image)));
                 cmd.Parameters.AddWithValue("@dateNaiss", (DNS.Value));
                 cmd.ExecuteNonQuery();
                 //this.playerTableAdapter.Fill(this.sportDBDataSet.Player);
                 MessageBox.Show("Personne Has been added");

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }


        }*/

        private void btnNextFinish_Click_2(object sender, EventArgs e)
        {
            if (enf1 == "non" && situation == "célibataire" && par1 == "oui")
            {
                r3.Checked = r3.Enabled = true;
                l3.ForeColor = Color.Indigo;
                r4.Checked = r4.Enabled = true;
                l4.ForeColor = Color.Indigo;
                r5.Checked = r5.Enabled = true;
                l5.ForeColor = Color.Indigo;
                r6.Checked = r6.Enabled = true;
                l6.ForeColor = Color.Indigo;
                bunifuPages9.SetPage("Success");
            }
            else if ((enf1 == "oui" && (situation == "marié" || situation == "divorcé") && par1 == "oui")|| (enf1 == "oui" && situation == "célibataire" && par1 == "oui"))
            {
                bunifuPages9.SetPage("Enfant Info");
            }
            else if (enf1 == "non" && (situation == "marié" || situation == "divorcé") && par1 == "oui")
            {

                r3.Checked = r3.Enabled = true;
                l3.ForeColor = Color.Indigo;
                r4.Checked = r4.Enabled = true;
                l4.ForeColor = Color.Indigo;
                bunifuPages9.SetPage("Conjointe Info");
            }
            /*else if (enf1 == "oui" && situation == "célibataire" && par1 == "oui")             {
                /*r3.Checked = r3.Enabled = true;
                l3.ForeColor = Color.Indigo;*/
               /* r4.Checked = r4.Enabled = true;
                l4.ForeColor = Color.Indigo;
                r5.Checked = r5.Enabled = true;
                l5.ForeColor = Color.Indigo;
                r6.Checked = r6.Enabled = true;
                l6.ForeColor = Color.Indigo;
                /*r5.Checked = r5.Enabled = true;
                l5.ForeColor = Color.Indigo;*/
                /*bunifuPages9.SetPage("Success");


            }*/

            /*else 
            {
                bunifuPages9.SetPage("Parent Info");

            }*/
        }

            private void bunifuButton7_Click_1(object sender, EventArgs e)
        {   
            
            if(situation == "célibataire")
            {
                r4.Checked = r4.Enabled = true;
                l4.ForeColor = Color.Indigo;
                r5.Checked = r5.Enabled = true;
                l5.ForeColor = Color.Indigo;
                r6.Checked = r6.Enabled = true;
                l6.ForeColor = Color.Indigo;
                bunifuPages9.SetPage("Success");
            }else
            {
                bunifuPages9.SetPage("Conjointe Info");
            }

        }

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {

            r5.Checked = r5.Enabled = true;
            l5.ForeColor = Color.Indigo;
            r6.Checked = r6.Enabled = true;
            l6.ForeColor = Color.Indigo;
            bunifuPages9.SetPage("Success");
        }

        private void m1_Click(object sender, EventArgs e)
        {
            gender1 = "Male";
        }

        private void m2_Click(object sender, EventArgs e)
        {
            gender1 = "Female";
        }
        public string imageLocation = "";
        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
           
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "jpg files (*.jpg|*.jpg|PNG files (*.png|*.png| All Files *.*|*.*";
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dlg.FileName;
                    //Image image = Image.FromFile(fileName);
                    bunifuPictureBox1.ImageLocation = imageLocation;
                }



            }
            catch (Exception)
            {
                MessageBox.Show("An Error ocurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    

            }



        }
        Byte[] ConvertImageToBinary(Image img)
        {  using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }



        }
        Image ConvertBinaryToImage(byte[] data)
        {

            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {   
            success = true;
            /*System.Windows.Forms.Application.
               ExitThread();*/
            this.Close();
            /*Form7 f1 = new Form7();
            f1.Show();*/
            
        }


        private void ge1_Click(object sender, EventArgs e)
        {
            genderE = "Male";
        }

        private void ge2_Click(object sender, EventArgs e)
        {
            genderE = "Female";
        }

        private void gc1_Click(object sender, EventArgs e)
        {
            genderC = "Male";
        }

        private void gc2_Click(object sender, EventArgs e)
        {
            genderC = "Female";
        }

       
    }
    
}
