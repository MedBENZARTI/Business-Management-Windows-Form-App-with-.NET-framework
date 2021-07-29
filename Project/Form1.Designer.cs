namespace Project
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fin = new System.Windows.Forms.DateTimePicker();
            this.deb = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RechercheClientinput = new System.Windows.Forms.TextBox();
            this.RechercheRef = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Quiterbtn = new System.Windows.Forms.Button();
            this.Supprimerbtn = new System.Windows.Forms.Button();
            this.Modifierbtn = new System.Windows.Forms.Button();
            this.Ajouterbtn = new System.Windows.Forms.Button();
            this.ListeCommandedgv = new System.Windows.Forms.DataGridView();
            this.RéférenceCmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.InfoTel = new System.Windows.Forms.TextBox();
            this.InfoCP = new System.Windows.Forms.TextBox();
            this.InfoVille = new System.Windows.Forms.TextBox();
            this.InfoAdrs = new System.Windows.Forms.TextBox();
            this.InfoClient = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ListeLigneCmddgv = new System.Windows.Forms.DataGridView();
            this.idproduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeCommandedgv)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeLigneCmddgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fin);
            this.groupBox1.Controls.Add(this.deb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RechercheClientinput);
            this.groupBox1.Controls.Add(this.RechercheRef);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(300, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // fin
            // 
            this.fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fin.Location = new System.Drawing.Point(119, 263);
            this.fin.Margin = new System.Windows.Forms.Padding(4);
            this.fin.Name = "fin";
            this.fin.Size = new System.Drawing.Size(157, 22);
            this.fin.TabIndex = 9;
            this.fin.ValueChanged += new System.EventHandler(this.fin_ValueChanged);
            // 
            // deb
            // 
            this.deb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.deb.Location = new System.Drawing.Point(119, 231);
            this.deb.Margin = new System.Windows.Forms.Padding(4);
            this.deb.Name = "deb";
            this.deb.Size = new System.Drawing.Size(157, 22);
            this.deb.TabIndex = 8;
            this.deb.ValueChanged += new System.EventHandler(this.deb_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 268);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Début";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date commande";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Référence commande";
            // 
            // RechercheClientinput
            // 
            this.RechercheClientinput.Location = new System.Drawing.Point(77, 135);
            this.RechercheClientinput.Margin = new System.Windows.Forms.Padding(4);
            this.RechercheClientinput.Name = "RechercheClientinput";
            this.RechercheClientinput.Size = new System.Drawing.Size(199, 22);
            this.RechercheClientinput.TabIndex = 2;
            this.RechercheClientinput.TextChanged += new System.EventHandler(this.RechercheClientinput_TextChanged);
            // 
            // RechercheRef
            // 
            this.RechercheRef.Location = new System.Drawing.Point(153, 103);
            this.RechercheRef.Margin = new System.Windows.Forms.Padding(4);
            this.RechercheRef.Name = "RechercheRef";
            this.RechercheRef.Size = new System.Drawing.Size(123, 22);
            this.RechercheRef.TabIndex = 1;
            this.RechercheRef.TextChanged += new System.EventHandler(this.RechercheRef_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherche de commande";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Quiterbtn);
            this.groupBox2.Controls.Add(this.Supprimerbtn);
            this.groupBox2.Controls.Add(this.Modifierbtn);
            this.groupBox2.Controls.Add(this.Ajouterbtn);
            this.groupBox2.Controls.Add(this.ListeCommandedgv);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(324, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1035, 322);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // Quiterbtn
            // 
            this.Quiterbtn.ForeColor = System.Drawing.Color.Red;
            this.Quiterbtn.Location = new System.Drawing.Point(897, 239);
            this.Quiterbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Quiterbtn.Name = "Quiterbtn";
            this.Quiterbtn.Size = new System.Drawing.Size(137, 39);
            this.Quiterbtn.TabIndex = 5;
            this.Quiterbtn.Text = "Quitter";
            this.Quiterbtn.UseVisualStyleBackColor = true;
            this.Quiterbtn.Click += new System.EventHandler(this.Quiterbtn_Click);
            // 
            // Supprimerbtn
            // 
            this.Supprimerbtn.Location = new System.Drawing.Point(897, 160);
            this.Supprimerbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Supprimerbtn.Name = "Supprimerbtn";
            this.Supprimerbtn.Size = new System.Drawing.Size(137, 39);
            this.Supprimerbtn.TabIndex = 4;
            this.Supprimerbtn.Text = "Supprimer";
            this.Supprimerbtn.UseVisualStyleBackColor = true;
            this.Supprimerbtn.Click += new System.EventHandler(this.Supprimerbtn_Click);
            // 
            // Modifierbtn
            // 
            this.Modifierbtn.Location = new System.Drawing.Point(897, 117);
            this.Modifierbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Modifierbtn.Name = "Modifierbtn";
            this.Modifierbtn.Size = new System.Drawing.Size(137, 39);
            this.Modifierbtn.TabIndex = 3;
            this.Modifierbtn.Text = "Modifier";
            this.Modifierbtn.UseVisualStyleBackColor = true;
            this.Modifierbtn.Click += new System.EventHandler(this.Modifierbtn_Click);
            // 
            // Ajouterbtn
            // 
            this.Ajouterbtn.Location = new System.Drawing.Point(897, 73);
            this.Ajouterbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Ajouterbtn.Name = "Ajouterbtn";
            this.Ajouterbtn.Size = new System.Drawing.Size(137, 39);
            this.Ajouterbtn.TabIndex = 2;
            this.Ajouterbtn.Text = "Ajouter";
            this.Ajouterbtn.UseVisualStyleBackColor = true;
            this.Ajouterbtn.Click += new System.EventHandler(this.Ajouterbtn_Click);
            // 
            // ListeCommandedgv
            // 
            this.ListeCommandedgv.AllowUserToAddRows = false;
            this.ListeCommandedgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            this.ListeCommandedgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListeCommandedgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListeCommandedgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeCommandedgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RéférenceCmd,
            this.Date,
            this.Client,
            this.idclient});
            this.ListeCommandedgv.GridColor = System.Drawing.Color.CornflowerBlue;
            this.ListeCommandedgv.Location = new System.Drawing.Point(8, 70);
            this.ListeCommandedgv.Margin = new System.Windows.Forms.Padding(4);
            this.ListeCommandedgv.Name = "ListeCommandedgv";
            this.ListeCommandedgv.ReadOnly = true;
            this.ListeCommandedgv.RowHeadersWidth = 51;
            this.ListeCommandedgv.Size = new System.Drawing.Size(867, 244);
            this.ListeCommandedgv.TabIndex = 1;
            this.ListeCommandedgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListeCommandedgv_CellClick);
            this.ListeCommandedgv.SelectionChanged += new System.EventHandler(this.ListeCommandedgv_SelectionChanged);
            // 
            // RéférenceCmd
            // 
            this.RéférenceCmd.HeaderText = "Référence commande";
            this.RéférenceCmd.MinimumWidth = 6;
            this.RéférenceCmd.Name = "RéférenceCmd";
            this.RéférenceCmd.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.MinimumWidth = 6;
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // idclient
            // 
            this.idclient.HeaderText = "idclient";
            this.idclient.MinimumWidth = 6;
            this.idclient.Name = "idclient";
            this.idclient.ReadOnly = true;
            this.idclient.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(866, 46);
            this.label7.TabIndex = 0;
            this.label7.Text = "Liste des commandes";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.InfoTel);
            this.groupBox3.Controls.Add(this.InfoCP);
            this.groupBox3.Controls.Add(this.InfoVille);
            this.groupBox3.Controls.Add(this.InfoAdrs);
            this.groupBox3.Controls.Add(this.InfoClient);
            this.groupBox3.Location = new System.Drawing.Point(16, 336);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(300, 351);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 230);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "Tél";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 197);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "CP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 164);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Ville";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 130);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Adresse";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Client";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 46);
            this.label9.TabIndex = 5;
            this.label9.Text = "Infos client";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoTel
            // 
            this.InfoTel.Location = new System.Drawing.Point(103, 225);
            this.InfoTel.Margin = new System.Windows.Forms.Padding(4);
            this.InfoTel.Name = "InfoTel";
            this.InfoTel.Size = new System.Drawing.Size(173, 22);
            this.InfoTel.TabIndex = 4;
            // 
            // InfoCP
            // 
            this.InfoCP.Location = new System.Drawing.Point(103, 192);
            this.InfoCP.Margin = new System.Windows.Forms.Padding(4);
            this.InfoCP.Name = "InfoCP";
            this.InfoCP.Size = new System.Drawing.Size(173, 22);
            this.InfoCP.TabIndex = 3;
            // 
            // InfoVille
            // 
            this.InfoVille.Location = new System.Drawing.Point(103, 159);
            this.InfoVille.Margin = new System.Windows.Forms.Padding(4);
            this.InfoVille.Name = "InfoVille";
            this.InfoVille.Size = new System.Drawing.Size(173, 22);
            this.InfoVille.TabIndex = 2;
            // 
            // InfoAdrs
            // 
            this.InfoAdrs.Location = new System.Drawing.Point(103, 126);
            this.InfoAdrs.Margin = new System.Windows.Forms.Padding(4);
            this.InfoAdrs.Name = "InfoAdrs";
            this.InfoAdrs.Size = new System.Drawing.Size(173, 22);
            this.InfoAdrs.TabIndex = 1;
            // 
            // InfoClient
            // 
            this.InfoClient.Location = new System.Drawing.Point(103, 94);
            this.InfoClient.Margin = new System.Windows.Forms.Padding(4);
            this.InfoClient.Name = "InfoClient";
            this.InfoClient.Size = new System.Drawing.Size(173, 22);
            this.InfoClient.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.ListeLigneCmddgv);
            this.groupBox4.Location = new System.Drawing.Point(324, 336);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1035, 351);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(866, 46);
            this.label8.TabIndex = 1;
            this.label8.Text = "Lignes Commande";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListeLigneCmddgv
            // 
            this.ListeLigneCmddgv.AllowUserToAddRows = false;
            this.ListeLigneCmddgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Thistle;
            this.ListeLigneCmddgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ListeLigneCmddgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListeLigneCmddgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeLigneCmddgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproduit,
            this.Produit,
            this.Quantité,
            this.Prix});
            this.ListeLigneCmddgv.Location = new System.Drawing.Point(8, 70);
            this.ListeLigneCmddgv.Margin = new System.Windows.Forms.Padding(4);
            this.ListeLigneCmddgv.Name = "ListeLigneCmddgv";
            this.ListeLigneCmddgv.ReadOnly = true;
            this.ListeLigneCmddgv.RowHeadersWidth = 51;
            this.ListeLigneCmddgv.Size = new System.Drawing.Size(867, 239);
            this.ListeLigneCmddgv.TabIndex = 0;
            this.ListeLigneCmddgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idproduit
            // 
            this.idproduit.HeaderText = "idproduit";
            this.idproduit.MinimumWidth = 6;
            this.idproduit.Name = "idproduit";
            this.idproduit.ReadOnly = true;
            this.idproduit.Visible = false;
            // 
            // Produit
            // 
            this.Produit.HeaderText = "Produit";
            this.Produit.MinimumWidth = 6;
            this.Produit.Name = "Produit";
            this.Produit.ReadOnly = true;
            // 
            // Quantité
            // 
            this.Quantité.HeaderText = "Quantité";
            this.Quantité.MinimumWidth = 6;
            this.Quantité.Name = "Quantité";
            this.Quantité.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.MinimumWidth = 6;
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1375, 667);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListeCommandedgv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListeLigneCmddgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RechercheClientinput;
        private System.Windows.Forms.TextBox RechercheRef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Quiterbtn;
        private System.Windows.Forms.Button Supprimerbtn;
        private System.Windows.Forms.Button Modifierbtn;
        private System.Windows.Forms.Button Ajouterbtn;
        private System.Windows.Forms.DataGridView ListeCommandedgv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox InfoTel;
        private System.Windows.Forms.TextBox InfoCP;
        private System.Windows.Forms.TextBox InfoVille;
        private System.Windows.Forms.TextBox InfoAdrs;
        private System.Windows.Forms.TextBox InfoClient;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView ListeLigneCmddgv;
        private System.Windows.Forms.DateTimePicker fin;
        private System.Windows.Forms.DateTimePicker deb;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn RéférenceCmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclient;
    }
}

