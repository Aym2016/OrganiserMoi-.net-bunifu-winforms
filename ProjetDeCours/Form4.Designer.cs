using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetDeCours
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
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
                //this.playerTableAdapter.Fill(this.sportDBDataSet.Player);
                MessageBox.Show("Player Has been added");

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

        /*private void btn_suivant_Click(object sender, EventArgs e)
        {


        }*/

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.retour = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_suivant = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_ajouter = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtAge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtSexe = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtFonction = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPrenom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtNom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtIdPer = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // retour
            // 
            this.retour.AllowToggling = false;
            this.retour.AnimationSpeed = 200;
            this.retour.AutoGenerateColors = false;
            this.retour.BackColor = System.Drawing.Color.Transparent;
            this.retour.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.retour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("retour.BackgroundImage")));
            this.retour.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.retour.ButtonText = "retour";
            this.retour.ButtonTextMarginLeft = 0;
            this.retour.ColorContrastOnClick = 45;
            this.retour.ColorContrastOnHover = 45;
            this.retour.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.retour.CustomizableEdges = borderEdges1;
            this.retour.DialogResult = System.Windows.Forms.DialogResult.None;
            this.retour.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.retour.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.retour.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.retour.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.retour.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.retour.ForeColor = System.Drawing.Color.White;
            this.retour.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.retour.IconMarginLeft = 11;
            this.retour.IconPadding = 10;
            this.retour.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.retour.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.retour.IdleBorderRadius = 3;
            this.retour.IdleBorderThickness = 1;
            this.retour.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.retour.IdleIconLeftImage = null;
            this.retour.IdleIconRightImage = null;
            this.retour.IndicateFocus = false;
            this.retour.Location = new System.Drawing.Point(12, 432);
            this.retour.Name = "retour";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.retour.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.retour.OnPressedState = stateProperties2;
            this.retour.Size = new System.Drawing.Size(210, 45);
            this.retour.TabIndex = 75;
            this.retour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.retour.TextMarginLeft = 0;
            this.retour.UseDefaultRadiusAndThickness = true;
            // 
            // btn_suivant
            // 
            this.btn_suivant.AllowToggling = false;
            this.btn_suivant.AnimationSpeed = 200;
            this.btn_suivant.AutoGenerateColors = false;
            this.btn_suivant.BackColor = System.Drawing.Color.Transparent;
            this.btn_suivant.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_suivant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_suivant.BackgroundImage")));
            this.btn_suivant.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_suivant.ButtonText = "suivant";
            this.btn_suivant.ButtonTextMarginLeft = 0;
            this.btn_suivant.ColorContrastOnClick = 45;
            this.btn_suivant.ColorContrastOnHover = 45;
            this.btn_suivant.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_suivant.CustomizableEdges = borderEdges2;
            this.btn_suivant.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_suivant.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_suivant.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_suivant.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_suivant.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_suivant.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btn_suivant.ForeColor = System.Drawing.Color.White;
            this.btn_suivant.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_suivant.IconMarginLeft = 11;
            this.btn_suivant.IconPadding = 10;
            this.btn_suivant.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_suivant.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_suivant.IdleBorderRadius = 3;
            this.btn_suivant.IdleBorderThickness = 1;
            this.btn_suivant.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_suivant.IdleIconLeftImage = null;
            this.btn_suivant.IdleIconRightImage = null;
            this.btn_suivant.IndicateFocus = false;
            this.btn_suivant.Location = new System.Drawing.Point(578, 432);
            this.btn_suivant.Name = "btn_suivant";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btn_suivant.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btn_suivant.OnPressedState = stateProperties4;
            this.btn_suivant.Size = new System.Drawing.Size(210, 45);
            this.btn_suivant.TabIndex = 74;
            this.btn_suivant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_suivant.TextMarginLeft = 0;
            this.btn_suivant.UseDefaultRadiusAndThickness = true;
            this.btn_suivant.Click += new System.EventHandler(this.btn_suivant_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.AllowToggling = false;
            this.btn_ajouter.AnimationSpeed = 200;
            this.btn_ajouter.AutoGenerateColors = false;
            this.btn_ajouter.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajouter.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btn_ajouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ajouter.BackgroundImage")));
            this.btn_ajouter.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_ajouter.ButtonText = "ajouter";
            this.btn_ajouter.ButtonTextMarginLeft = 0;
            this.btn_ajouter.ColorContrastOnClick = 45;
            this.btn_ajouter.ColorContrastOnHover = 45;
            this.btn_ajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_ajouter.CustomizableEdges = borderEdges3;
            this.btn_ajouter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ajouter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_ajouter.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_ajouter.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_ajouter.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_ajouter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btn_ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajouter.IconMarginLeft = 11;
            this.btn_ajouter.IconPadding = 10;
            this.btn_ajouter.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajouter.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_ajouter.IdleBorderRadius = 3;
            this.btn_ajouter.IdleBorderThickness = 1;
            this.btn_ajouter.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btn_ajouter.IdleIconLeftImage = null;
            this.btn_ajouter.IdleIconRightImage = null;
            this.btn_ajouter.IndicateFocus = false;
            this.btn_ajouter.Location = new System.Drawing.Point(286, 432);
            this.btn_ajouter.Name = "btn_ajouter";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.BorderRadius = 3;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.btn_ajouter.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 3;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.btn_ajouter.OnPressedState = stateProperties6;
            this.btn_ajouter.Size = new System.Drawing.Size(210, 45);
            this.btn_ajouter.TabIndex = 73;
            this.btn_ajouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ajouter.TextMarginLeft = 0;
            this.btn_ajouter.UseDefaultRadiusAndThickness = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.CursorType = null;
            this.bunifuLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel8.Location = new System.Drawing.Point(227, 24);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(269, 40);
            this.bunifuLabel8.TabIndex = 90;
            this.bunifuLabel8.Text = "Information Parent";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtAge
            // 
            this.txtAge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAge.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAge.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAge.HintForeColor = System.Drawing.Color.Empty;
            this.txtAge.HintText = "";
            this.txtAge.isPassword = false;
            this.txtAge.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtAge.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAge.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtAge.LineThickness = 3;
            this.txtAge.Location = new System.Drawing.Point(383, 281);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.MaxLength = 32767;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(379, 40);
            this.txtAge.TabIndex = 116;
            this.txtAge.Text = "age";
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.Location = new System.Drawing.Point(40, 275);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(57, 40);
            this.bunifuLabel4.TabIndex = 115;
            this.bunifuLabel4.Text = "age";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtSexe
            // 
            this.txtSexe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSexe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSexe.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSexe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSexe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSexe.HintForeColor = System.Drawing.Color.Empty;
            this.txtSexe.HintText = "";
            this.txtSexe.isPassword = false;
            this.txtSexe.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSexe.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSexe.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSexe.LineThickness = 3;
            this.txtSexe.Location = new System.Drawing.Point(383, 329);
            this.txtSexe.Margin = new System.Windows.Forms.Padding(4);
            this.txtSexe.MaxLength = 32767;
            this.txtSexe.Name = "txtSexe";
            this.txtSexe.Size = new System.Drawing.Size(379, 33);
            this.txtSexe.TabIndex = 114;
            this.txtSexe.Text = "sexe";
            this.txtSexe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel7.Location = new System.Drawing.Point(39, 321);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(78, 40);
            this.bunifuLabel7.TabIndex = 113;
            this.bunifuLabel7.Text = "Sexe";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(39, 240);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(117, 40);
            this.bunifuLabel3.TabIndex = 112;
            this.bunifuLabel3.Text = "fonction";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtFonction
            // 
            this.txtFonction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFonction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFonction.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFonction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFonction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtFonction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFonction.HintForeColor = System.Drawing.Color.Empty;
            this.txtFonction.HintText = "";
            this.txtFonction.isPassword = false;
            this.txtFonction.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtFonction.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFonction.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtFonction.LineThickness = 3;
            this.txtFonction.Location = new System.Drawing.Point(383, 240);
            this.txtFonction.Margin = new System.Windows.Forms.Padding(4);
            this.txtFonction.MaxLength = 32767;
            this.txtFonction.Name = "txtFonction";
            this.txtFonction.Size = new System.Drawing.Size(379, 33);
            this.txtFonction.TabIndex = 111;
            this.txtFonction.Text = "fonction";
            this.txtFonction.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPrenom
            // 
            this.txtPrenom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPrenom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPrenom.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrenom.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrenom.HintText = "";
            this.txtPrenom.isPassword = false;
            this.txtPrenom.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrenom.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrenom.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrenom.LineThickness = 3;
            this.txtPrenom.Location = new System.Drawing.Point(383, 199);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenom.MaxLength = 32767;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(379, 33);
            this.txtPrenom.TabIndex = 110;
            this.txtPrenom.Text = "prenom";
            this.txtPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(39, 199);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(113, 40);
            this.bunifuLabel2.TabIndex = 109;
            this.bunifuLabel2.Text = "prenom";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(39, 158);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(66, 40);
            this.bunifuLabel1.TabIndex = 108;
            this.bunifuLabel1.Text = "nom";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtNom
            // 
            this.txtNom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNom.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNom.HintForeColor = System.Drawing.Color.Empty;
            this.txtNom.HintText = "";
            this.txtNom.isPassword = false;
            this.txtNom.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNom.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNom.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNom.LineThickness = 3;
            this.txtNom.Location = new System.Drawing.Point(383, 158);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.MaxLength = 32767;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(379, 33);
            this.txtNom.TabIndex = 107;
            this.txtNom.Text = "nom";
            this.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtId
            // 
            this.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtId.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtId.HintForeColor = System.Drawing.Color.Empty;
            this.txtId.HintText = "";
            this.txtId.isPassword = false;
            this.txtId.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtId.LineIdleColor = System.Drawing.Color.Gray;
            this.txtId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtId.LineThickness = 3;
            this.txtId.Location = new System.Drawing.Point(382, 119);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(379, 33);
            this.txtId.TabIndex = 123;
            this.txtId.Text = "Id";
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.Location = new System.Drawing.Point(39, 112);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(29, 40);
            this.bunifuLabel5.TabIndex = 122;
            this.bunifuLabel5.Text = "Id";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.Location = new System.Drawing.Point(38, 78);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(76, 40);
            this.bunifuLabel6.TabIndex = 126;
            this.bunifuLabel6.Text = "Idper";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtIdPer
            // 
            this.txtIdPer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtIdPer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtIdPer.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdPer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtIdPer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdPer.HintForeColor = System.Drawing.Color.Empty;
            this.txtIdPer.HintText = "";
            this.txtIdPer.isPassword = false;
            this.txtIdPer.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtIdPer.LineIdleColor = System.Drawing.Color.Gray;
            this.txtIdPer.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtIdPer.LineThickness = 3;
            this.txtIdPer.Location = new System.Drawing.Point(382, 78);
            this.txtIdPer.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPer.MaxLength = 32767;
            this.txtIdPer.Name = "txtIdPer";
            this.txtIdPer.Size = new System.Drawing.Size(379, 33);
            this.txtIdPer.TabIndex = 125;
            this.txtIdPer.Text = "IdPer";
            this.txtIdPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.bunifuLabel6);
            this.Controls.Add(this.txtIdPer);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.txtSexe);
            this.Controls.Add(this.bunifuLabel7);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.txtFonction);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.bunifuLabel8);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.btn_suivant);
            this.Controls.Add(this.btn_ajouter);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton retour;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_suivant;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_ajouter;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAge;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSexe;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFonction;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrenom;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtId;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIdPer;
    }
}