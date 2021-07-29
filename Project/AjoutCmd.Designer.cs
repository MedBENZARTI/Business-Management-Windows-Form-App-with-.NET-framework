namespace Project
{
    partial class AjoutCmd
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
            this.RefCmdTextBoxAjoutCmd = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LignesCmdGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupprimerLigneCmd = new System.Windows.Forms.Button();
            this.ModifierLigneCmd = new System.Windows.Forms.Button();
            this.AjouterLigneCmd = new System.Windows.Forms.Button();
            this.LignesCmd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labrue = new System.Windows.Forms.Label();
            this.ClientAjoutCmd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RefCom = new System.Windows.Forms.Label();
            this.TelTextBoxAjoutCmd = new System.Windows.Forms.TextBox();
            this.CodePostalTextBoxAjoutCmd = new System.Windows.Forms.TextBox();
            this.VilleTextBoxAjoutCmd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AnnulerLigneCmd = new System.Windows.Forms.Button();
            this.ValiderLigneCmd = new System.Windows.Forms.Button();
            this.DateAjoutCmd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idclient = new System.Windows.Forms.TextBox();
            this.clientInput = new System.Windows.Forms.TextBox();
            this.RueTextBoxAjoutCmd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LignesCmdGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefCmdTextBoxAjoutCmd
            // 
            this.RefCmdTextBoxAjoutCmd.Location = new System.Drawing.Point(292, 27);
            this.RefCmdTextBoxAjoutCmd.Margin = new System.Windows.Forms.Padding(4);
            this.RefCmdTextBoxAjoutCmd.Name = "RefCmdTextBoxAjoutCmd";
            this.RefCmdTextBoxAjoutCmd.Size = new System.Drawing.Size(244, 22);
            this.RefCmdTextBoxAjoutCmd.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LignesCmdGrid);
            this.groupBox4.Controls.Add(this.SupprimerLigneCmd);
            this.groupBox4.Controls.Add(this.ModifierLigneCmd);
            this.groupBox4.Controls.Add(this.AjouterLigneCmd);
            this.groupBox4.Controls.Add(this.LignesCmd);
            this.groupBox4.Location = new System.Drawing.Point(33, 222);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(957, 207);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // LignesCmdGrid
            // 
            this.LignesCmdGrid.AllowUserToAddRows = false;
            this.LignesCmdGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LignesCmdGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LignesCmdGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LignesCmdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LignesCmdGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Produit,
            this.Quantité,
            this.Prix});
            this.LignesCmdGrid.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LignesCmdGrid.Location = new System.Drawing.Point(8, 70);
            this.LignesCmdGrid.Margin = new System.Windows.Forms.Padding(4);
            this.LignesCmdGrid.Name = "LignesCmdGrid";
            this.LignesCmdGrid.ReadOnly = true;
            this.LignesCmdGrid.RowHeadersWidth = 51;
            this.LignesCmdGrid.Size = new System.Drawing.Size(796, 129);
            this.LignesCmdGrid.TabIndex = 4;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
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
            this.Quantité.HeaderText = "Quantté";
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
            // SupprimerLigneCmd
            // 
            this.SupprimerLigneCmd.Location = new System.Drawing.Point(836, 162);
            this.SupprimerLigneCmd.Margin = new System.Windows.Forms.Padding(4);
            this.SupprimerLigneCmd.Name = "SupprimerLigneCmd";
            this.SupprimerLigneCmd.Size = new System.Drawing.Size(100, 37);
            this.SupprimerLigneCmd.TabIndex = 3;
            this.SupprimerLigneCmd.Text = "Supprimer";
            this.SupprimerLigneCmd.UseVisualStyleBackColor = true;
            this.SupprimerLigneCmd.Click += new System.EventHandler(this.SupprimerLigneCmd_Click);
            // 
            // ModifierLigneCmd
            // 
            this.ModifierLigneCmd.Location = new System.Drawing.Point(836, 118);
            this.ModifierLigneCmd.Margin = new System.Windows.Forms.Padding(4);
            this.ModifierLigneCmd.Name = "ModifierLigneCmd";
            this.ModifierLigneCmd.Size = new System.Drawing.Size(100, 37);
            this.ModifierLigneCmd.TabIndex = 2;
            this.ModifierLigneCmd.Text = "Modifier";
            this.ModifierLigneCmd.UseVisualStyleBackColor = true;
            this.ModifierLigneCmd.Click += new System.EventHandler(this.ModifierLigneCmd_Click);
            // 
            // AjouterLigneCmd
            // 
            this.AjouterLigneCmd.Location = new System.Drawing.Point(836, 70);
            this.AjouterLigneCmd.Margin = new System.Windows.Forms.Padding(4);
            this.AjouterLigneCmd.Name = "AjouterLigneCmd";
            this.AjouterLigneCmd.Size = new System.Drawing.Size(100, 41);
            this.AjouterLigneCmd.TabIndex = 1;
            this.AjouterLigneCmd.Text = "Ajouter";
            this.AjouterLigneCmd.UseVisualStyleBackColor = true;
            this.AjouterLigneCmd.Click += new System.EventHandler(this.AjouterLigneCmd_Click);
            // 
            // LignesCmd
            // 
            this.LignesCmd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LignesCmd.Location = new System.Drawing.Point(8, 20);
            this.LignesCmd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LignesCmd.Name = "LignesCmd";
            this.LignesCmd.Size = new System.Drawing.Size(927, 38);
            this.LignesCmd.TabIndex = 0;
            this.LignesCmd.Text = "Lignes Commande";
            this.LignesCmd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ville";
            // 
            // labrue
            // 
            this.labrue.AutoSize = true;
            this.labrue.Location = new System.Drawing.Point(152, 91);
            this.labrue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labrue.Name = "labrue";
            this.labrue.Size = new System.Drawing.Size(33, 16);
            this.labrue.TabIndex = 10;
            this.labrue.Text = "Rue";
            // 
            // ClientAjoutCmd
            // 
            this.ClientAjoutCmd.AutoSize = true;
            this.ClientAjoutCmd.Location = new System.Drawing.Point(144, 63);
            this.ClientAjoutCmd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientAjoutCmd.Name = "ClientAjoutCmd";
            this.ClientAjoutCmd.Size = new System.Drawing.Size(41, 16);
            this.ClientAjoutCmd.TabIndex = 9;
            this.ClientAjoutCmd.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date";
            // 
            // RefCom
            // 
            this.RefCom.AutoSize = true;
            this.RefCom.Location = new System.Drawing.Point(119, 31);
            this.RefCom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RefCom.Name = "RefCom";
            this.RefCom.Size = new System.Drawing.Size(145, 16);
            this.RefCom.TabIndex = 7;
            this.RefCom.Text = "Référence commande ";
            // 
            // TelTextBoxAjoutCmd
            // 
            this.TelTextBoxAjoutCmd.Location = new System.Drawing.Point(695, 123);
            this.TelTextBoxAjoutCmd.Margin = new System.Windows.Forms.Padding(4);
            this.TelTextBoxAjoutCmd.Name = "TelTextBoxAjoutCmd";
            this.TelTextBoxAjoutCmd.ReadOnly = true;
            this.TelTextBoxAjoutCmd.Size = new System.Drawing.Size(184, 22);
            this.TelTextBoxAjoutCmd.TabIndex = 5;
            // 
            // CodePostalTextBoxAjoutCmd
            // 
            this.CodePostalTextBoxAjoutCmd.Location = new System.Drawing.Point(488, 123);
            this.CodePostalTextBoxAjoutCmd.Margin = new System.Windows.Forms.Padding(4);
            this.CodePostalTextBoxAjoutCmd.Name = "CodePostalTextBoxAjoutCmd";
            this.CodePostalTextBoxAjoutCmd.ReadOnly = true;
            this.CodePostalTextBoxAjoutCmd.Size = new System.Drawing.Size(132, 22);
            this.CodePostalTextBoxAjoutCmd.TabIndex = 4;
            // 
            // VilleTextBoxAjoutCmd
            // 
            this.VilleTextBoxAjoutCmd.Location = new System.Drawing.Point(196, 123);
            this.VilleTextBoxAjoutCmd.Margin = new System.Windows.Forms.Padding(4);
            this.VilleTextBoxAjoutCmd.Name = "VilleTextBoxAjoutCmd";
            this.VilleTextBoxAjoutCmd.ReadOnly = true;
            this.VilleTextBoxAjoutCmd.Size = new System.Drawing.Size(168, 22);
            this.VilleTextBoxAjoutCmd.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AnnulerLigneCmd);
            this.groupBox3.Controls.Add(this.ValiderLigneCmd);
            this.groupBox3.Location = new System.Drawing.Point(42, 437);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(957, 66);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // AnnulerLigneCmd
            // 
            this.AnnulerLigneCmd.Location = new System.Drawing.Point(836, 17);
            this.AnnulerLigneCmd.Margin = new System.Windows.Forms.Padding(4);
            this.AnnulerLigneCmd.Name = "AnnulerLigneCmd";
            this.AnnulerLigneCmd.Size = new System.Drawing.Size(100, 42);
            this.AnnulerLigneCmd.TabIndex = 1;
            this.AnnulerLigneCmd.Text = "Annuler";
            this.AnnulerLigneCmd.UseVisualStyleBackColor = true;
            this.AnnulerLigneCmd.Click += new System.EventHandler(this.AnnulerLigneCmd_Click);
            // 
            // ValiderLigneCmd
            // 
            this.ValiderLigneCmd.Location = new System.Drawing.Point(728, 17);
            this.ValiderLigneCmd.Margin = new System.Windows.Forms.Padding(4);
            this.ValiderLigneCmd.Name = "ValiderLigneCmd";
            this.ValiderLigneCmd.Size = new System.Drawing.Size(100, 42);
            this.ValiderLigneCmd.TabIndex = 0;
            this.ValiderLigneCmd.Text = "Valider";
            this.ValiderLigneCmd.UseVisualStyleBackColor = true;
            this.ValiderLigneCmd.Click += new System.EventHandler(this.ValiderLigneCmd_Click);
            // 
            // DateAjoutCmd
            // 
            this.DateAjoutCmd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateAjoutCmd.Location = new System.Drawing.Point(613, 26);
            this.DateAjoutCmd.Margin = new System.Windows.Forms.Padding(4);
            this.DateAjoutCmd.Name = "DateAjoutCmd";
            this.DateAjoutCmd.Size = new System.Drawing.Size(265, 22);
            this.DateAjoutCmd.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(657, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tel";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(395, 127);
            this.lab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(82, 16);
            this.lab.TabIndex = 12;
            this.lab.Text = "Code Postal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.idclient);
            this.groupBox2.Controls.Add(this.clientInput);
            this.groupBox2.Controls.Add(this.DateAjoutCmd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lab);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labrue);
            this.groupBox2.Controls.Add(this.ClientAjoutCmd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.RefCom);
            this.groupBox2.Controls.Add(this.TelTextBoxAjoutCmd);
            this.groupBox2.Controls.Add(this.CodePostalTextBoxAjoutCmd);
            this.groupBox2.Controls.Add(this.VilleTextBoxAjoutCmd);
            this.groupBox2.Controls.Add(this.RueTextBoxAjoutCmd);
            this.groupBox2.Controls.Add(this.RefCmdTextBoxAjoutCmd);
            this.groupBox2.Location = new System.Drawing.Point(33, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(957, 191);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // idclient
            // 
            this.idclient.Location = new System.Drawing.Point(40, 63);
            this.idclient.Margin = new System.Windows.Forms.Padding(4);
            this.idclient.Name = "idclient";
            this.idclient.Size = new System.Drawing.Size(69, 22);
            this.idclient.TabIndex = 16;
            this.idclient.Visible = false;
            // 
            // clientInput
            // 
            this.clientInput.Location = new System.Drawing.Point(196, 62);
            this.clientInput.Margin = new System.Windows.Forms.Padding(4);
            this.clientInput.Name = "clientInput";
            this.clientInput.ReadOnly = true;
            this.clientInput.Size = new System.Drawing.Size(683, 22);
            this.clientInput.TabIndex = 15;
            this.clientInput.TextChanged += new System.EventHandler(this.clientInput_TextChanged);
            this.clientInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // RueTextBoxAjoutCmd
            // 
            this.RueTextBoxAjoutCmd.Location = new System.Drawing.Point(196, 91);
            this.RueTextBoxAjoutCmd.Margin = new System.Windows.Forms.Padding(4);
            this.RueTextBoxAjoutCmd.Name = "RueTextBoxAjoutCmd";
            this.RueTextBoxAjoutCmd.ReadOnly = true;
            this.RueTextBoxAjoutCmd.Size = new System.Drawing.Size(683, 22);
            this.RueTextBoxAjoutCmd.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(11, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1016, 529);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pour choisir un client il faut mettre le curseur sur le champ Client, ensuite app" +
    "uyer sur ENTREE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AjoutCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 557);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AjoutCmd";
            this.Text = "AjoutCmd";
            this.Load += new System.EventHandler(this.AjoutCmd_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LignesCmdGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox RefCmdTextBoxAjoutCmd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView LignesCmdGrid;
        private System.Windows.Forms.Button SupprimerLigneCmd;
        private System.Windows.Forms.Button ModifierLigneCmd;
        private System.Windows.Forms.Button AjouterLigneCmd;
        private System.Windows.Forms.Label LignesCmd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labrue;
        private System.Windows.Forms.Label ClientAjoutCmd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RefCom;
        private System.Windows.Forms.TextBox TelTextBoxAjoutCmd;
        private System.Windows.Forms.TextBox CodePostalTextBoxAjoutCmd;
        private System.Windows.Forms.TextBox VilleTextBoxAjoutCmd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AnnulerLigneCmd;
        private System.Windows.Forms.Button ValiderLigneCmd;
        private System.Windows.Forms.DateTimePicker DateAjoutCmd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox RueTextBoxAjoutCmd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox clientInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantité;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.TextBox idclient;
        private System.Windows.Forms.Label label1;
    }
}