using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Drawing;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetDeCours.EntityFramework;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;
using GemBox.Spreadsheet;






using Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;
using iTextSharp.text.pdf;
using PdfDocument = PdfSharp.Pdf.PdfDocument;
using PdfPage = PdfSharp.Pdf.PdfPage;
using Syncfusion.XlsIO;

namespace ProjetDeCours
{
    public partial class Form2 : Form
    {
       // private OrganizeMeEntities database;
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        public Form2()
        {
            InitializeComponent();
            (new Core.DropShaddow()).ApplyShadows(this);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'organizeMeDataSet5.personne' table. You can move, or remove it, as needed.
            this.personneTableAdapter1.Fill(this.organizeMeDataSet5.personne);
            //object database = new EntityFramework.OrganizeMeEntities();
            this.parentTableAdapter.Fill(this.organizeMeDataSet1.parent);

            // TODO: This line of code loads data into the 'organizeMeDataSet3.tache' table. You can move, or remove it, as needed.
            this.tacheTableAdapter1.Fill(this.organizeMeDataSet3.tache);
            // TODO: This line of code loads data into the 'organizeMeDataSet2.tache' table. You can move, or remove it, as needed.
            //this.tacheTableAdapter.Fill(this.organizeMeDataSet2.tache);
            // TODO: This line of code loads data into the 'organizeMeDataSet.personne' table. You can move, or remove it, as needed.
            // this.personneTableAdapter5.Fill(this.organizeMeDataSet5);
            // TODO: This line of code loads data into the 'organizeMeDataSet1.conjointe' table. You can move, or remove it, as needed.
            this.conjointeTableAdapter.Fill(this.organizeMeDataSet1.conjointe);
            // TODO: This line of code loads data into the 'organizeMeDataSet1.parent' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'organizeMeDataSet.enfant' table. You can move, or remove it, as needed.
            this.enfantTableAdapter.Fill(this.organizeMeDataSet.enfant);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage1");
        }

        public void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage2");
        }

        public void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage3");
            //tabPage3.Show();
        }

        public void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage4");
            //tabPage4.Show();
        }

        public void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage5");
            //tabPage5.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage5");
            //tabPage5.Show();
        }

        private void AddParent_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage6");
        }

        private void AddEnfant_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage7");
        }

        private void AddConjointe_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage8");
        }

        private void AddPersonne_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage9");
        }

        private void AddTache_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage10");
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
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
                cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                cmd.Parameters.AddWithValue("@nom", (txtNom.Text));
                cmd.Parameters.AddWithValue("@prenom", (txtPrenom.Text));
                cmd.Parameters.AddWithValue("@fonction", (txtFonction.Text));
                cmd.Parameters.AddWithValue("@idper", int.Parse(txtIdPer.Text));
                cmd.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
                cmd.Parameters.AddWithValue("@sexe", (txtSexe.Text));
                cmd.ExecuteNonQuery();
                this.parentTableAdapter.Fill(this.organizeMeDataSet1.parent);
                //this.playerTableAdapter.Fill(this.sportDBDataSet.Player);
                MessageBox.Show("parent Has been added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
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
                cmd.Parameters.AddWithValue("@id", int.Parse(txtIdE.Text));
                cmd.Parameters.AddWithValue("@nom", (txtNomE.Text));
                cmd.Parameters.AddWithValue("@prenom", (txtPrenomE.Text));
                cmd.Parameters.AddWithValue("@fonction", (txtFonctionE.Text));
                cmd.Parameters.AddWithValue("@idper", int.Parse(txtIdPerE.Text));
                cmd.Parameters.AddWithValue("@age", int.Parse(txtAgeE.Text));
                cmd.Parameters.AddWithValue("@sexe", (txtSexeE.Text));
                cmd.ExecuteNonQuery();
                this.enfantTableAdapter.Fill(this.organizeMeDataSet.enfant);
                MessageBox.Show("Enfant Has been added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
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
                cmd.Parameters.AddWithValue("@id", int.Parse(txtIdC.Text));
                cmd.Parameters.AddWithValue("@nom", (txtNomC.Text));
                cmd.Parameters.AddWithValue("@prenom", (txtPrenomC.Text));
                cmd.Parameters.AddWithValue("@fonction", (txtFonctionC.Text));
                cmd.Parameters.AddWithValue("@idper", int.Parse(txtIdPerC.Text));
                cmd.Parameters.AddWithValue("@age", int.Parse(txtAgeC.Text));
                cmd.Parameters.AddWithValue("@sexe", (txtSexeC.Text));
                cmd.ExecuteNonQuery();
                this.conjointeTableAdapter.Fill(this.organizeMeDataSet1.conjointe);
                MessageBox.Show("Conjointe Has been added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();


            con.ConnectionString = @"Data Source =(LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Pooling = False";
            con.Open();


            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "delete from parent where id = @id  ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@id", int.Parse(bunifuTextBox1.Text));
                //cmd.Parameters.AddWithValue("@nom", bunifuTextBox1.Text);
                cmd.ExecuteNonQuery();
                this.parentTableAdapter.Fill(this.organizeMeDataSet1.parent);
                MessageBox.Show("Deleted...");
                //bunifuTextBox1.Clear();
                //bunifuTextBox2.Clear();
                //bunifuTextBox3.Clear();
                //bunifuTextBox4.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Not Deleted" + ex.Message);
            }
            finally
            {

                con.Close();
            }


            //save changes
            /*if (database.ChangeTracker.HasChanges())
            {
                if (database.SaveChanges() > 0)
                {
                    MessageBox.Show("success");//Bunifu.Snackbar.Show(this.FindForm(), "Success.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);
                }
                else
                {
                    MessageBox.Show("failed"); //Bunifu.Snackbar.Show(this.FindForm(), "Failed.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);

                }
            }*/
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();


            con.ConnectionString = @"Data Source =(LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Pooling = False";
            con.Open();


            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = new SqlCommand("delete from enfant where id = @id or  nom=@nom  or prenom=@nom", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", int.Parse(bunifuTextBox2.Text));
                cmd.Parameters.AddWithValue("@nom", bunifuTextBox2.Text);
                cmd.ExecuteNonQuery();
                this.enfantTableAdapter.Fill(this.organizeMeDataSet.enfant);
                MessageBox.Show("Deleted...");
                //bunifuTextBox1.Clear();
                //bunifuTextBox2.Clear();
                //bunifuTextBox3.Clear();
                //bunifuTextBox4.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Not Deleted" + ex.Message);
            }
            finally
            {

                con.Close();
            }
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();


            con.ConnectionString = @"Data Source =(LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Pooling = False";
            con.Open();


            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = new SqlCommand("delete from conjointe where id = @id ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", int.Parse(bunifuTextBox3.Text));
                //cmd.Parameters.AddWithValue("@nom", bunifuTextBox3.Text);
                cmd.ExecuteNonQuery();
                this.conjointeTableAdapter.Fill(this.organizeMeDataSet1.conjointe);
                MessageBox.Show("Deleted...");
                //bunifuTextBox1.Clear();
                //bunifuTextBox2.Clear();
                //bunifuTextBox3.Clear();
                //bunifuTextBox4.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Not Deleted" + ex.Message);
            }
            finally
            {

                con.Close();
            }

        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();


            con.ConnectionString = @"Data Source =(LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Pooling = False";
            con.Open();


            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = new SqlCommand("delete from personne where id = @id or  nom=@nom  or prenom=@nom", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", int.Parse(bunifuTextBox4.Text));
                cmd.Parameters.AddWithValue("@nom", bunifuTextBox4.Text);
                cmd.ExecuteNonQuery();
                this.personneTableAdapter.Fill(this.organizeMeDataSet.personne);
                MessageBox.Show("Deleted...");
                //bunifuTextBox1.Clear();
                //bunifuTextBox2.Clear();
                //bunifuTextBox3.Clear();
                //bunifuTextBox4.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Not Deleted" + ex.Message);
            }
            finally
            {

                con.Close();
            }
        }

        private void btnDelT_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();


            con.ConnectionString = @"Data Source =(LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Pooling = False";
            con.Open();


            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd = new SqlCommand("delete from dbo.tache where id = @id ", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", int.Parse(bunifuTextBox5.Text));
                //  cmd.Parameters.AddWithValue("@nom", bunifuTextBox5.Text);

                cmd.ExecuteNonQuery();
                this.tacheTableAdapter1.Fill(this.organizeMeDataSet3.tache);
                MessageBox.Show("Deleted...");
                //bunifuTextBox1.Clear();
                //bunifuTextBox2.Clear();
                //bunifuTextBox3.Clear();
                //bunifuTextBox4.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Not Deleted" + ex.Message);
            }
            finally
            {

                con.Close();
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

                con.Open();



                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = " insert into tache values (@id,@carac,@type)  ";

                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@id", int.Parse(txtIdT.Text));
                cmd.Parameters.AddWithValue("@carac", (txtCaractT.Text));
                cmd.Parameters.AddWithValue("@type", (txtTypeT.Text));
                //cmd.Parameters.AddWithValue("@fo", (txtFonction.Text));
                //cmd.Parameters.AddWithValue("@idper", int.Parse(txtIdPerT.Text));
                //cmd.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
                //cmd.Parameters.AddWithValue("@sexe", (txtSexe.Text));
                cmd.ExecuteNonQuery();
                cmd.CommandText = null;
                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandText = "insert into dbo.tacherResp(Id,idper) values(@id1,@idper1)";
                cmd2.Parameters.AddWithValue("@id1", int.Parse(txtIdT.Text));
                cmd2.Parameters.AddWithValue("@idper1", int.Parse(txtIdPerT.Text));
                cmd2.CommandType = CommandType.Text;
                cmd2.Connection = con;
                //cmd.Parameters.AddWithValue("@idper", int.Parse(txtIdPerT.Text));
                //cmd2.Parameters.AddWithValue("@id", int.Parse(txtIdT.Text));
                cmd2.ExecuteNonQuery();

                this.tacheTableAdapter1.Fill(this.organizeMeDataSet3.tache);
                //this.playerTableAdapter.Fill(this.sportDBDataSet.Player);
                MessageBox.Show("Tache Has been added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Editer_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update parent set nom=@nom ,prenom=@prenom,fonction=@fonction,idper=@idper,age=@age,sexe=@sexe where id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                cmd.Parameters.AddWithValue("@nom", (txtNom.Text));
                cmd.Parameters.AddWithValue("@prenom", (txtPrenom.Text));
                cmd.Parameters.AddWithValue("@fonction", (txtFonction.Text));
                cmd.Parameters.AddWithValue("@idper", int.Parse(txtIdPer.Text));
                cmd.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
                cmd.Parameters.AddWithValue("@sexe", (txtSexe.Text));
                cmd.ExecuteNonQuery();
                this.parentTableAdapter.Fill(this.organizeMeDataSet1.parent);
                //this.playerTableAdapter.Fill(this.sportDBDataSet.Player);
                MessageBox.Show("parent Has been edited");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update enfant set @nom=nom ,prenom=@prenom,fonction=@fonction,idper=@idper,age=@age,sexe=@sexe where id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@id", int.Parse(txtIdE.Text));
                cmd.Parameters.AddWithValue("@nom", (txtNomE.Text));
                cmd.Parameters.AddWithValue("@prenom", (txtPrenomE.Text));
                cmd.Parameters.AddWithValue("@fonction", (txtFonctionE.Text));
                cmd.Parameters.AddWithValue("@idper", int.Parse(txtIdPerE.Text));
                cmd.Parameters.AddWithValue("@age", int.Parse(txtAgeE.Text));
                cmd.Parameters.AddWithValue("@sexe", (txtSexeE.Text));
                cmd.ExecuteNonQuery();
                this.enfantTableAdapter.Fill(this.organizeMeDataSet.enfant);
                //this.playerTableAdapter.Fill(this.sportDBDataSet.Player);
                MessageBox.Show("enfant Has been edited");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update conjointe set @nom=nom ,prenom=@prenom,fonction=@fonction,idper=@idper,age=@age,sexe=@sexe where id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@id", int.Parse(txtIdC.Text));
                cmd.Parameters.AddWithValue("@nom", (txtNomC.Text));
                cmd.Parameters.AddWithValue("@prenom", (txtPrenomC.Text));
                cmd.Parameters.AddWithValue("@fonction", (txtFonctionC.Text));
                cmd.Parameters.AddWithValue("@idper", int.Parse(txtIdPerC.Text));
                cmd.Parameters.AddWithValue("@age", int.Parse(txtAgeC.Text));
                cmd.Parameters.AddWithValue("@sexe", (txtSexeC.Text));
                cmd.ExecuteNonQuery();
                this.conjointeTableAdapter.Fill(this.organizeMeDataSet1.conjointe);
                //this.playerTableAdapter.Fill(this.sportDBDataSet.Player);
                MessageBox.Show("conjointe Has been edited");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update tache set  caracteristique=@caract,type=@type where id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@id", int.Parse(txtIdT.Text));
                cmd.Parameters.AddWithValue("@caract", (txtCaractT.Text));
                cmd.Parameters.AddWithValue("@type", (txtTypeT.Text));
                /*cmd.Parameters.AddWithValue("@fonction", (txtFonction.Text));
                cmd.Parameters.AddWithValue("@idper", int.Parse(txtIdPer.Text));
                cmd.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
                cmd.Parameters.AddWithValue("@sexe", (txtSexe.Text));*/
                cmd.ExecuteNonQuery();
                this.tacheTableAdapter.Fill(this.organizeMeDataSet2.tache);
                //this.playerTableAdapter.Fill(this.sportDBDataSet.Player);
                MessageBox.Show("enfant Has been edited");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {

            /*ComboBoxItem typeItem = (ComboBoxItem)cmbEnfant.SelectedItem;
            string value1 = typeItem.Content.ToString();
            ComboBoxItem typeItem1 = (ComboBoxItem)cmbParent.SelectedItem;
            string value2 = typeItem1.Content.ToString();
            ComboBoxItem typeItem2 = (ComboBoxItem)cmbSituation.SelectedItem;
            string value3 = typeItem2.Content.ToString();*/
            /*try
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

                cmd.ExecuteNonQuery();
                //this.playerTableAdapter.Fill(this.sportDBDataSet.Player);
                //MessageBox.Show("Enfant Has been added");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update personne set nom=@nom ,prenom=@prenom,fonction=@fonction,idper=@idper,age=@age,sexe=@sexe where id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                cmd.Parameters.AddWithValue("@nom", (txtNom.Text));
                cmd.Parameters.AddWithValue("@prenom", (txtPrenom.Text));
                cmd.Parameters.AddWithValue("@fonction", (txtFonction.Text));
                cmd.Parameters.AddWithValue("@idper", int.Parse(txtIdPer.Text));
                cmd.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
                cmd.Parameters.AddWithValue("@sexe", (txtSexe.Text));
                cmd.ExecuteNonQuery();
                this.personneTableAdapter.Fill(this.organizeMeDataSet.personne);
                //this.playerTableAdapter.Fill(this.sportDBDataSet.Player);
                MessageBox.Show("enfant Has been edited");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage11");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            recEngine.RecognizeAsync(RecognizeMode.Single);
            btnStop.Enabled = true;
             recEngine.SpeechRecognized += recEngine_SpeechRecognized;





        }
        private void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            switch (e.Result.Text)
            {
                case "say hello":
                    MessageBox.Show("hello Aymen,How are you");
                    break;
                case "print my name":
                    richTextBox1.Text = "\nAymen";
                    break;


            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
        }

        private void tabPage11_Click(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "Say hello", "print my name" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);
            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();




        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            string connectionString = null;
            string sql = null;
            string data = null;
            int i = 0;
            int j = 0;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            sql = "SELECT * FROM Parent";
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            DataSet ds = new DataSet();
            dscmd.Fill(ds);

            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                {
                    data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                    xlWorkSheet.Cells[i + 1, j + 1] = data;
                }
            }
            /*Excel.Range chartRange;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);
            Excel.Chart chartPage = myChart.Chart;

            chartRange = xlWorkSheet.get_Range("A1", "d5");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

            //export chart as picture file
            chartPage.Export(@"C:\excel_chart_export.bmp", "BMP", misValue);

            //load picture to picturebox
            pictureBox1.Image = new Bitmap(@"C:\excel_chart_export.bmp");*/
            xlWorkBook.SaveAs("Parent Info.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);

            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file c:\\Parent Info.xls");
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            string connectionString = null;
            string sql = null;
            string data = null;
            int i = 0;
            int j = 0;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            sql = "SELECT * FROM Enfant";
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            DataSet ds = new DataSet();
            dscmd.Fill(ds);

            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                {
                    data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                    xlWorkSheet.Cells[i + 1, j + 1] = data;
                }
            }

            xlWorkBook.SaveAs("Enfant Info.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file c:\\Enfant Info.xls");
        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            string connectionString = null;
            string sql = null;
            string data = null;
            int i = 0;
            int j = 0;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            sql = "SELECT * FROM Conjointe";
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            DataSet ds = new DataSet();
            dscmd.Fill(ds);

            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                {
                    data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                    xlWorkSheet.Cells[i + 1, j + 1] = data;
                }
            }

            xlWorkBook.SaveAs("Conjointe Info.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file c:\\Conjointe Info.xls");
        }

        private void bunifuImageButton17_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            string connectionString = null;
            string sql = null;
            string data = null;
            int i = 0;
            int j = 0;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            sql = "SELECT * FROM Personne";
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            DataSet ds = new DataSet();
            dscmd.Fill(ds);

            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                {
                    data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                    xlWorkSheet.Cells[i + 1, j + 1] = data;
                }
            }

            xlWorkBook.SaveAs("Person Info.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file c:\\Person Info.xls");

        }
        private void bunifuImageButton21_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            string connectionString = null;
            string sql = null;
            string data = null;
            int i = 0;
            int j = 0;

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            sql = "SELECT * FROM Tache";
            SqlDataAdapter dscmd = new SqlDataAdapter(sql, cnn);
            DataSet ds = new DataSet();
            dscmd.Fill(ds);

            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                {
                    data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                    xlWorkSheet.Cells[i + 1, j + 1] = data;
                }
            }
            /*Excel.Range chartRange;

            Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
            Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);
            Excel.Chart chartPage = myChart.Chart;

            chartRange = xlWorkSheet.get_Range("A1", "d5");
            chartPage.SetSourceData(chartRange, misValue);
            chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

            //export chart as picture file
            chartPage.Export(@"C:\excel_chart_export.bmp", "BMP", misValue);

            //load picture to picturebox
            pictureBox5.Image = new Bitmap(@"C:\excel_chart_export.bmp");*/
            xlWorkBook.SaveAs("Tach Info.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkBook.SaveAs("C:\\xxxxx.pdf");
            /*ExcelFile excel = ExcelFile.Load("D:\\xxxxx.xlsx");
            excel.Save("D:\\xxxxx.pdf");*/
            //xlApp.Save("C:\\xxxxx.pdf");


            //If you want to make the excel content fit to pdf page
            //workbook.ConverterSetting.SheetFitToPage = true;


            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            //ExcelFile excel = ExcelFile.Load("C:\\Documents\\Tache Info.xlsx");

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file c:\\Tache Info.xls");

        }


        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString = null;
                SqlConnection connection;
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                int i = 0;
                int j = 0;
                string sql = null;
                int yPoint = 0;

                string data = null;
                connetionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

                sql = "select * from Parent";
                connection = new SqlConnection(connetionString);
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                connection.Close();

                PdfSharp.Pdf.PdfDocument pdf = new PdfSharp.Pdf.PdfDocument();
                pdf.Info.Title = "Database to PDF";
                PdfSharp.Pdf.PdfPage pdfPage = pdf.AddPage();
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XFont font = new XFont("Arial", 7, XFontStyle.Regular);
                int s = 0;
                yPoint = yPoint + 100;

                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    if (i%33==0)
                    {
                        pdfPage = pdf.AddPage();
                        graph=XGraphics.FromPdfPage(pdfPage);
                        yPoint = 100;
                    }
                    s = 40;
                    for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                    {
                        data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                        //xlWorkSheet.Cells[i + 1, j + 1] = data;*/
                        /* pubname = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                         city = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                         state = ds.Tables[0].Rows[i].ItemArray[2].ToString();*/

                        graph.DrawString(data, font, XBrushes.Black, new XRect(s, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                        s += 80;
                    }
                    /*graph.DrawString(city, font, XBrushes.Black, new XRect(280, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(state, font, XBrushes.Black, new XRect(420, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);*/

                    yPoint = yPoint + 40;
                }


                string pdfFilename = "Parent Info.pdf";
                pdf.Save(pdfFilename);
                Process.Start(pdfFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString = null;
                SqlConnection connection;
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                int i = 0;
                int j = 0;
                string sql = null;
                int yPoint = 0;

                string data = null;
                connetionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

                sql = "select * from Enfant";
                connection = new SqlConnection(connetionString);
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                connection.Close();
                //PdfDocument PDFDoc = PdfWriter.Open(@"D:\Test1.pdf", PdfDocumentOpenMode.Import);
                //PdfDocument pd = PdfWriter.PAGE_OPEN;
                PdfSharp.Pdf.PdfDocument pdf = new PdfSharp.Pdf.PdfDocument();
                pdf.Info.Title = "Database to PDF";
                PdfSharp.Pdf.PdfPage pdfPage = pdf.AddPage();
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XFont font = new XFont("Verdana", 10, XFontStyle.Regular);
                int p = 0;
                int oldIndex = 1;
                int newIndex = 2;
                int s = 2;
                yPoint = yPoint + 100;

                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    if (i % 33 == 1 && i > 1)
                    {
                        pdfPage = pdf.AddPage();
                        //pdf = PdfWriter.PAGE_OPEN.;

                        //pdf.Pages.MovePage();
                        //pdf.Pages.MovePage(oldIndex, newIndex);
                        //string name = Path.GetFileNameWithoutExtension("Parent Info.pdf");
                        //pdf.Save(String.Format("{0} - Page {1}Enfant Info.pdf", "Enfant Info", s + 1));

                        s += 1;
                    }
                    s = 40;
                    for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                    {
                        data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                        //xlWorkSheet.Cells[i + 1, j + 1] = data;*/
                        /* pubname = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                         city = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                         state = ds.Tables[0].Rows[i].ItemArray[2].ToString();*/

                        graph.DrawString(data, font, XBrushes.Black, new XRect(s, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                        s += 70;
                    }
                    /*graph.DrawString(city, font, XBrushes.Black, new XRect(280, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(state, font, XBrushes.Black, new XRect(420, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);*/

                    yPoint = yPoint + 40;
                }


                string pdfFilename = " Enfant Info.pdf";
                pdf.Save(pdfFilename);
                Process.Start(pdfFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString = null;
                SqlConnection connection;
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                int i = 0;
                int j = 0;
                string sql = null;
                int yPoint = 0;

                string data = null;
                connetionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

                sql = "select * from Conjointe";
                connection = new SqlConnection(connetionString);
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                connection.Close();

                PdfSharp.Pdf.PdfDocument pdf = new PdfSharp.Pdf.PdfDocument();
                pdf.Info.Title = "Database to PDF";
                PdfSharp.Pdf.PdfPage pdfPage = pdf.AddPage();
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XFont font = new XFont("Verdana", 10, XFontStyle.Regular);
                int s = 0;
                yPoint = yPoint + 100;

                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    s = 40;
                    for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                    {
                        data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                        //xlWorkSheet.Cells[i + 1, j + 1] = data;*/
                        /* pubname = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                         city = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                         state = ds.Tables[0].Rows[i].ItemArray[2].ToString();*/

                        graph.DrawString(data, font, XBrushes.Black, new XRect(s, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                        s += 70;
                    }
                    /*graph.DrawString(city, font, XBrushes.Black, new XRect(280, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(state, font, XBrushes.Black, new XRect(420, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);*/

                    yPoint = yPoint + 40;
                }


                string pdfFilename = "Conjointe Info.pdf";
                pdf.Save(pdfFilename);
                Process.Start(pdfFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bunifuImageButton20_Click(object sender, EventArgs e)
        {
            try
            {
                string connetionString = null;
                SqlConnection connection;
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                int i = 0;
                int j = 0;
                string sql = null;
                int yPoint = 0;

                string data = null;
                connetionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = OrganizeMe; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False;  Pooling = False";

                sql = "select * from Tache";
                connection = new SqlConnection(connetionString);
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                connection.Close();

                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "Database to PDF";
                PdfPage pdfPage = pdf.AddPage();
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XFont font = new XFont("Verdana", 5, XFontStyle.Regular);
                int s = 0;
                yPoint = yPoint + 100;

                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    s = 40;
                    for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                    {
                        data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                        //xlWorkSheet.Cells[i + 1, j + 1] = data;*/
                        /* pubname = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                         city = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                         state = ds.Tables[0].Rows[i].ItemArray[2].ToString();*/

                        graph.DrawString(data, font, XBrushes.Black, new XRect(s, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                        s += 140;
                    }
                    /*graph.DrawString(city, font, XBrushes.Black, new XRect(280, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(state, font, XBrushes.Black, new XRect(420, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);*/

                    yPoint = yPoint + 40;
                }


                string pdfFilename = "Tache Info.pdf";
                pdf.Save(pdfFilename);
                Process.Start(pdfFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bunifuButton8_Click_1(object sender, EventArgs e)
        {
            /* try
             {
                 /*SqlConnection con = new SqlConnection();
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
        }













        /*  private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

              var results = database.parent.Select(r => r);
              foreach (var parent in results)
              {
                  bunifuDataGridView1.Rows.Add(
                             new object[]
                             { parent.Id,
                                parent.nom,
                                parent.prenom,
                                parent.age_,
                                parent.fonction,
                                parent.IdPer
                             }
                            );
                  bunifuDataGridView1.Rows[bunifuDataGridView1.RowCount - 1].Tag = parent;
              }




          }*/


    }  
}