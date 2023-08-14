namespace ProjetDeCours
{
    partial class Form10
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSituation = new System.Windows.Forms.ComboBox();
            this.cmbEnfant = new System.Windows.Forms.ComboBox();
            this.txtNbEnfant = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cmbParent = new System.Windows.Forms.ComboBox();
            this.parent = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox21 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMdp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox17 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNumTel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DNS = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuMaterialTextbox18 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox19 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox20 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuButton7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.cmbSituation);
            this.panel1.Controls.Add(this.cmbEnfant);
            this.panel1.Controls.Add(this.txtNbEnfant);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 377);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbSituation
            // 
            this.cmbSituation.FormattingEnabled = true;
            this.cmbSituation.Items.AddRange(new object[] {
            "marié",
            "divorcer",
            "célibataire"});
            this.cmbSituation.Location = new System.Drawing.Point(74, 430);
            this.cmbSituation.Name = "cmbSituation";
            this.cmbSituation.Size = new System.Drawing.Size(379, 21);
            this.cmbSituation.TabIndex = 149;
            // 
            // cmbEnfant
            // 
            this.cmbEnfant.FormattingEnabled = true;
            this.cmbEnfant.Items.AddRange(new object[] {
            "oui",
            "non"});
            this.cmbEnfant.Location = new System.Drawing.Point(74, 383);
            this.cmbEnfant.Name = "cmbEnfant";
            this.cmbEnfant.Size = new System.Drawing.Size(379, 21);
            this.cmbEnfant.TabIndex = 148;
            // 
            // txtNbEnfant
            // 
            this.txtNbEnfant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNbEnfant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNbEnfant.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNbEnfant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNbEnfant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNbEnfant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNbEnfant.HintForeColor = System.Drawing.Color.Empty;
            this.txtNbEnfant.HintText = "";
            this.txtNbEnfant.isPassword = false;
            this.txtNbEnfant.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNbEnfant.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNbEnfant.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNbEnfant.LineThickness = 3;
            this.txtNbEnfant.Location = new System.Drawing.Point(75, 464);
            this.txtNbEnfant.Margin = new System.Windows.Forms.Padding(4);
            this.txtNbEnfant.MaxLength = 32767;
            this.txtNbEnfant.Name = "txtNbEnfant";
            this.txtNbEnfant.Size = new System.Drawing.Size(379, 33);
            this.txtNbEnfant.TabIndex = 145;
            this.txtNbEnfant.Text = "NbEnfant";
            this.txtNbEnfant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.comboBox1);
            this.panel11.Controls.Add(this.bunifuMaterialTextbox1);
            this.panel11.Controls.Add(this.comboBox2);
            this.panel11.Controls.Add(this.cmbParent);
            this.panel11.Controls.Add(this.parent);
            this.panel11.Controls.Add(this.bunifuMaterialTextbox21);
            this.panel11.Controls.Add(this.txtMdp);
            this.panel11.Controls.Add(this.txtEmail);
            this.panel11.Controls.Add(this.bunifuMaterialTextbox17);
            this.panel11.Controls.Add(this.txtNumTel);
            this.panel11.Controls.Add(this.DNS);
            this.panel11.Controls.Add(this.bunifuMaterialTextbox18);
            this.panel11.Controls.Add(this.bunifuMaterialTextbox19);
            this.panel11.Controls.Add(this.bunifuMaterialTextbox20);
            this.panel11.Controls.Add(this.bunifuButton7);
            this.panel11.Controls.Add(this.bunifuButton8);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(723, 377);
            this.panel11.TabIndex = 150;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "marié",
            "divorcer",
            "célibataire"});
            this.comboBox1.Location = new System.Drawing.Point(420, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(379, 21);
            this.comboBox1.TabIndex = 150;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(420, 192);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.MaxLength = 32767;
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(379, 33);
            this.bunifuMaterialTextbox1.TabIndex = 149;
            this.bunifuMaterialTextbox1.Text = "NbEnfant";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "oui",
            "non"});
            this.comboBox2.Location = new System.Drawing.Point(420, 112);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(379, 21);
            this.comboBox2.TabIndex = 148;
            // 
            // cmbParent
            // 
            this.cmbParent.FormattingEnabled = true;
            this.cmbParent.Items.AddRange(new object[] {
            "oui",
            "non"});
            this.cmbParent.Location = new System.Drawing.Point(420, 71);
            this.cmbParent.Name = "cmbParent";
            this.cmbParent.Size = new System.Drawing.Size(379, 21);
            this.cmbParent.TabIndex = 147;
            // 
            // parent
            // 
            this.parent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.parent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.parent.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.parent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.parent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.parent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parent.HintForeColor = System.Drawing.Color.Empty;
            this.parent.HintText = "";
            this.parent.isPassword = false;
            this.parent.LineFocusedColor = System.Drawing.Color.Blue;
            this.parent.LineIdleColor = System.Drawing.Color.Gray;
            this.parent.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.parent.LineThickness = 3;
            this.parent.Location = new System.Drawing.Point(21, 371);
            this.parent.Margin = new System.Windows.Forms.Padding(4);
            this.parent.MaxLength = 32767;
            this.parent.Name = "parent";
            this.parent.Size = new System.Drawing.Size(379, 33);
            this.parent.TabIndex = 146;
            this.parent.Text = "parent";
            this.parent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox21
            // 
            this.bunifuMaterialTextbox21.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox21.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox21.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox21.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox21.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox21.HintText = "";
            this.bunifuMaterialTextbox21.isPassword = false;
            this.bunifuMaterialTextbox21.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox21.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox21.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox21.LineThickness = 3;
            this.bunifuMaterialTextbox21.Location = new System.Drawing.Point(420, 25);
            this.bunifuMaterialTextbox21.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox21.MaxLength = 32767;
            this.bunifuMaterialTextbox21.Name = "bunifuMaterialTextbox21";
            this.bunifuMaterialTextbox21.Size = new System.Drawing.Size(379, 33);
            this.bunifuMaterialTextbox21.TabIndex = 145;
            this.bunifuMaterialTextbox21.Text = "sexe";
            this.bunifuMaterialTextbox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMdp
            // 
            this.txtMdp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMdp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMdp.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMdp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMdp.HintForeColor = System.Drawing.Color.Empty;
            this.txtMdp.HintText = "";
            this.txtMdp.isPassword = false;
            this.txtMdp.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMdp.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMdp.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMdp.LineThickness = 3;
            this.txtMdp.Location = new System.Drawing.Point(21, 330);
            this.txtMdp.Margin = new System.Windows.Forms.Padding(4);
            this.txtMdp.MaxLength = 32767;
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(379, 33);
            this.txtMdp.TabIndex = 144;
            this.txtMdp.Text = "mot de passe";
            this.txtMdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(21, 289);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(379, 33);
            this.txtEmail.TabIndex = 143;
            this.txtEmail.Text = "Email";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox17
            // 
            this.bunifuMaterialTextbox17.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox17.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox17.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox17.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox17.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox17.HintText = "";
            this.bunifuMaterialTextbox17.isPassword = false;
            this.bunifuMaterialTextbox17.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox17.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox17.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox17.LineThickness = 3;
            this.bunifuMaterialTextbox17.Location = new System.Drawing.Point(20, 25);
            this.bunifuMaterialTextbox17.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox17.MaxLength = 32767;
            this.bunifuMaterialTextbox17.Name = "bunifuMaterialTextbox17";
            this.bunifuMaterialTextbox17.Size = new System.Drawing.Size(378, 33);
            this.bunifuMaterialTextbox17.TabIndex = 142;
            this.bunifuMaterialTextbox17.Text = "IdPer";
            this.bunifuMaterialTextbox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNumTel
            // 
            this.txtNumTel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNumTel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNumTel.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNumTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtNumTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumTel.HintForeColor = System.Drawing.Color.Empty;
            this.txtNumTel.HintText = "";
            this.txtNumTel.isPassword = false;
            this.txtNumTel.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNumTel.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNumTel.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNumTel.LineThickness = 3;
            this.txtNumTel.Location = new System.Drawing.Point(20, 59);
            this.txtNumTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumTel.MaxLength = 32767;
            this.txtNumTel.Name = "txtNumTel";
            this.txtNumTel.Size = new System.Drawing.Size(378, 33);
            this.txtNumTel.TabIndex = 141;
            this.txtNumTel.Text = "numTel";
            this.txtNumTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DNS
            // 
            this.DNS.BackColor = System.Drawing.Color.SeaGreen;
            this.DNS.BorderRadius = 0;
            this.DNS.ForeColor = System.Drawing.Color.White;
            this.DNS.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DNS.FormatCustom = null;
            this.DNS.Location = new System.Drawing.Point(21, 244);
            this.DNS.Name = "DNS";
            this.DNS.Size = new System.Drawing.Size(303, 36);
            this.DNS.TabIndex = 140;
            this.DNS.Value = new System.DateTime(2020, 5, 14, 11, 13, 59, 723);
            // 
            // bunifuMaterialTextbox18
            // 
            this.bunifuMaterialTextbox18.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox18.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox18.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox18.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox18.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox18.HintText = "";
            this.bunifuMaterialTextbox18.isPassword = false;
            this.bunifuMaterialTextbox18.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox18.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox18.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox18.LineThickness = 3;
            this.bunifuMaterialTextbox18.Location = new System.Drawing.Point(21, 192);
            this.bunifuMaterialTextbox18.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox18.MaxLength = 32767;
            this.bunifuMaterialTextbox18.Name = "bunifuMaterialTextbox18";
            this.bunifuMaterialTextbox18.Size = new System.Drawing.Size(379, 33);
            this.bunifuMaterialTextbox18.TabIndex = 139;
            this.bunifuMaterialTextbox18.Text = "fonction";
            this.bunifuMaterialTextbox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox19
            // 
            this.bunifuMaterialTextbox19.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox19.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox19.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox19.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox19.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox19.HintText = "";
            this.bunifuMaterialTextbox19.isPassword = false;
            this.bunifuMaterialTextbox19.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox19.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox19.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox19.LineThickness = 3;
            this.bunifuMaterialTextbox19.Location = new System.Drawing.Point(21, 139);
            this.bunifuMaterialTextbox19.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox19.MaxLength = 32767;
            this.bunifuMaterialTextbox19.Name = "bunifuMaterialTextbox19";
            this.bunifuMaterialTextbox19.Size = new System.Drawing.Size(379, 33);
            this.bunifuMaterialTextbox19.TabIndex = 138;
            this.bunifuMaterialTextbox19.Text = "prenom";
            this.bunifuMaterialTextbox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox20
            // 
            this.bunifuMaterialTextbox20.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuMaterialTextbox20.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuMaterialTextbox20.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuMaterialTextbox20.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox20.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox20.HintText = "";
            this.bunifuMaterialTextbox20.isPassword = false;
            this.bunifuMaterialTextbox20.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox20.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox20.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox20.LineThickness = 3;
            this.bunifuMaterialTextbox20.Location = new System.Drawing.Point(21, 100);
            this.bunifuMaterialTextbox20.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox20.MaxLength = 32767;
            this.bunifuMaterialTextbox20.Name = "bunifuMaterialTextbox20";
            this.bunifuMaterialTextbox20.Size = new System.Drawing.Size(379, 33);
            this.bunifuMaterialTextbox20.TabIndex = 137;
            this.bunifuMaterialTextbox20.Text = "nom";
            this.bunifuMaterialTextbox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuButton7
            // 
            this.bunifuButton7.AllowToggling = false;
            this.bunifuButton7.AnimationSpeed = 200;
            this.bunifuButton7.AutoGenerateColors = false;
            this.bunifuButton7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton7.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton7.BackgroundImage")));
            this.bunifuButton7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton7.ButtonText = "Editer";
            this.bunifuButton7.ButtonTextMarginLeft = 0;
            this.bunifuButton7.ColorContrastOnClick = 45;
            this.bunifuButton7.ColorContrastOnHover = 45;
            this.bunifuButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton7.CustomizableEdges = borderEdges1;
            this.bunifuButton7.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton7.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton7.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton7.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton7.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bunifuButton7.ForeColor = System.Drawing.Color.White;
            this.bunifuButton7.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton7.IconMarginLeft = 11;
            this.bunifuButton7.IconPadding = 10;
            this.bunifuButton7.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton7.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton7.IdleBorderRadius = 3;
            this.bunifuButton7.IdleBorderThickness = 1;
            this.bunifuButton7.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton7.IdleIconLeftImage = null;
            this.bunifuButton7.IdleIconRightImage = null;
            this.bunifuButton7.IndicateFocus = false;
            this.bunifuButton7.Location = new System.Drawing.Point(420, 440);
            this.bunifuButton7.Name = "bunifuButton7";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButton7.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton7.OnPressedState = stateProperties2;
            this.bunifuButton7.Size = new System.Drawing.Size(365, 45);
            this.bunifuButton7.TabIndex = 136;
            this.bunifuButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton7.TextMarginLeft = 0;
            this.bunifuButton7.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuButton8
            // 
            this.bunifuButton8.AllowToggling = false;
            this.bunifuButton8.AnimationSpeed = 200;
            this.bunifuButton8.AutoGenerateColors = false;
            this.bunifuButton8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton8.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton8.BackgroundImage")));
            this.bunifuButton8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton8.ButtonText = "ajouter";
            this.bunifuButton8.ButtonTextMarginLeft = 0;
            this.bunifuButton8.ColorContrastOnClick = 45;
            this.bunifuButton8.ColorContrastOnHover = 45;
            this.bunifuButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButton8.CustomizableEdges = borderEdges2;
            this.bunifuButton8.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton8.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton8.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton8.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton8.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bunifuButton8.ForeColor = System.Drawing.Color.White;
            this.bunifuButton8.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton8.IconMarginLeft = 11;
            this.bunifuButton8.IconPadding = 10;
            this.bunifuButton8.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton8.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton8.IdleBorderRadius = 3;
            this.bunifuButton8.IdleBorderThickness = 1;
            this.bunifuButton8.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton8.IdleIconLeftImage = null;
            this.bunifuButton8.IdleIconRightImage = null;
            this.bunifuButton8.IndicateFocus = false;
            this.bunifuButton8.Location = new System.Drawing.Point(20, 440);
            this.bunifuButton8.Name = "bunifuButton8";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.bunifuButton8.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.bunifuButton8.OnPressedState = stateProperties4;
            this.bunifuButton8.Size = new System.Drawing.Size(380, 45);
            this.bunifuButton8.TabIndex = 133;
            this.bunifuButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton8.TextMarginLeft = 0;
            this.bunifuButton8.UseDefaultRadiusAndThickness = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSituation;
        private System.Windows.Forms.ComboBox cmbEnfant;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNbEnfant;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cmbParent;
        private Bunifu.Framework.UI.BunifuMaterialTextbox parent;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox21;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMdp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox17;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNumTel;
        private Bunifu.Framework.UI.BunifuDatepicker DNS;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox18;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox19;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox20;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton8;
    }
}