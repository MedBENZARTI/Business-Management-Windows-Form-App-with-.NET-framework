namespace Project
{
    partial class rechercheClient
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
            this.RechClient = new System.Windows.Forms.Label();
            this.dataRechClient = new System.Windows.Forms.DataGridView();
            this.od = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValiderRechClientbtn = new System.Windows.Forms.Button();
            this.AnnulerRechClientbtn = new System.Windows.Forms.Button();
            this.ClientExbtn = new System.Windows.Forms.Button();
            this.CodePostalTextBoxRechClient = new System.Windows.Forms.TextBox();
            this.VilleTextBoxRechClient = new System.Windows.Forms.TextBox();
            this.RueTextBoxRechClient = new System.Windows.Forms.TextBox();
            this.ClientTextBoxRechClient = new System.Windows.Forms.TextBox();
            this.CodePostalRechClient = new System.Windows.Forms.Label();
            this.VilleRechClient = new System.Windows.Forms.Label();
            this.RueRechClient = new System.Windows.Forms.Label();
            this.ClientRechClient = new System.Windows.Forms.Label();
            this.telephoneTextBoxRechClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataRechClient)).BeginInit();
            this.SuspendLayout();
            // 
            // RechClient
            // 
            this.RechClient.AutoSize = true;
            this.RechClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechClient.Location = new System.Drawing.Point(33, 85);
            this.RechClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RechClient.Name = "RechClient";
            this.RechClient.Size = new System.Drawing.Size(132, 17);
            this.RechClient.TabIndex = 25;
            this.RechClient.Text = "Recherche Client";
            // 
            // dataRechClient
            // 
            this.dataRechClient.AllowUserToAddRows = false;
            this.dataRechClient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSalmon;
            this.dataRechClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataRechClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRechClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.od,
            this.Client,
            this.Rue,
            this.Ville,
            this.CodePostal,
            this.Telephone});
            this.dataRechClient.Location = new System.Drawing.Point(257, 36);
            this.dataRechClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataRechClient.Name = "dataRechClient";
            this.dataRechClient.ReadOnly = true;
            this.dataRechClient.Size = new System.Drawing.Size(737, 484);
            this.dataRechClient.TabIndex = 24;
            // 
            // od
            // 
            this.od.HeaderText = "ID";
            this.od.Name = "od";
            this.od.ReadOnly = true;
            this.od.Width = 40;
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // Rue
            // 
            this.Rue.HeaderText = "Rue";
            this.Rue.Name = "Rue";
            this.Rue.ReadOnly = true;
            this.Rue.Width = 150;
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            this.Ville.ReadOnly = true;
            this.Ville.Width = 80;
            // 
            // CodePostal
            // 
            this.CodePostal.HeaderText = "Code Postal";
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.ReadOnly = true;
            this.CodePostal.Width = 40;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Télléphone";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            // 
            // ValiderRechClientbtn
            // 
            this.ValiderRechClientbtn.Location = new System.Drawing.Point(1016, 85);
            this.ValiderRechClientbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ValiderRechClientbtn.Name = "ValiderRechClientbtn";
            this.ValiderRechClientbtn.Size = new System.Drawing.Size(100, 57);
            this.ValiderRechClientbtn.TabIndex = 23;
            this.ValiderRechClientbtn.Text = "Valider\r\n";
            this.ValiderRechClientbtn.UseVisualStyleBackColor = true;
            this.ValiderRechClientbtn.Click += new System.EventHandler(this.ValiderRechClientbtn_Click);
            // 
            // AnnulerRechClientbtn
            // 
            this.AnnulerRechClientbtn.Location = new System.Drawing.Point(1016, 149);
            this.AnnulerRechClientbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AnnulerRechClientbtn.Name = "AnnulerRechClientbtn";
            this.AnnulerRechClientbtn.Size = new System.Drawing.Size(100, 57);
            this.AnnulerRechClientbtn.TabIndex = 22;
            this.AnnulerRechClientbtn.Text = "Annuler";
            this.AnnulerRechClientbtn.UseVisualStyleBackColor = true;
            this.AnnulerRechClientbtn.Click += new System.EventHandler(this.AnnulerRechClientbtn_Click);
            // 
            // ClientExbtn
            // 
            this.ClientExbtn.Location = new System.Drawing.Point(1016, 217);
            this.ClientExbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientExbtn.Name = "ClientExbtn";
            this.ClientExbtn.Size = new System.Drawing.Size(100, 57);
            this.ClientExbtn.TabIndex = 21;
            this.ClientExbtn.Tag = "Client in";
            this.ClientExbtn.Text = "Client inexistant";
            this.ClientExbtn.UseVisualStyleBackColor = true;
            this.ClientExbtn.Click += new System.EventHandler(this.ClientExbtn_Click);
            // 
            // CodePostalTextBoxRechClient
            // 
            this.CodePostalTextBoxRechClient.Location = new System.Drawing.Point(97, 272);
            this.CodePostalTextBoxRechClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CodePostalTextBoxRechClient.Name = "CodePostalTextBoxRechClient";
            this.CodePostalTextBoxRechClient.Size = new System.Drawing.Size(132, 22);
            this.CodePostalTextBoxRechClient.TabIndex = 20;
            this.CodePostalTextBoxRechClient.TextChanged += new System.EventHandler(this.CodePostalTextBoxRechClient_TextChanged);
            // 
            // VilleTextBoxRechClient
            // 
            this.VilleTextBoxRechClient.Location = new System.Drawing.Point(97, 234);
            this.VilleTextBoxRechClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VilleTextBoxRechClient.Name = "VilleTextBoxRechClient";
            this.VilleTextBoxRechClient.Size = new System.Drawing.Size(132, 22);
            this.VilleTextBoxRechClient.TabIndex = 19;
            this.VilleTextBoxRechClient.TextChanged += new System.EventHandler(this.VilleTextBoxRechClient_TextChanged);
            // 
            // RueTextBoxRechClient
            // 
            this.RueTextBoxRechClient.Location = new System.Drawing.Point(97, 190);
            this.RueTextBoxRechClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RueTextBoxRechClient.Name = "RueTextBoxRechClient";
            this.RueTextBoxRechClient.Size = new System.Drawing.Size(132, 22);
            this.RueTextBoxRechClient.TabIndex = 18;
            this.RueTextBoxRechClient.TextChanged += new System.EventHandler(this.RueTextBoxRechClient_TextChanged);
            // 
            // ClientTextBoxRechClient
            // 
            this.ClientTextBoxRechClient.Location = new System.Drawing.Point(97, 144);
            this.ClientTextBoxRechClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientTextBoxRechClient.Name = "ClientTextBoxRechClient";
            this.ClientTextBoxRechClient.Size = new System.Drawing.Size(132, 22);
            this.ClientTextBoxRechClient.TabIndex = 17;
            this.ClientTextBoxRechClient.TextChanged += new System.EventHandler(this.ClientTextBoxRechClient_TextChanged);
            // 
            // CodePostalRechClient
            // 
            this.CodePostalRechClient.AutoSize = true;
            this.CodePostalRechClient.Location = new System.Drawing.Point(4, 276);
            this.CodePostalRechClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CodePostalRechClient.Name = "CodePostalRechClient";
            this.CodePostalRechClient.Size = new System.Drawing.Size(82, 16);
            this.CodePostalRechClient.TabIndex = 16;
            this.CodePostalRechClient.Text = "Code Postal";
            // 
            // VilleRechClient
            // 
            this.VilleRechClient.AutoSize = true;
            this.VilleRechClient.Location = new System.Drawing.Point(55, 238);
            this.VilleRechClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VilleRechClient.Name = "VilleRechClient";
            this.VilleRechClient.Size = new System.Drawing.Size(34, 16);
            this.VilleRechClient.TabIndex = 15;
            this.VilleRechClient.Text = "Ville";
            // 
            // RueRechClient
            // 
            this.RueRechClient.AutoSize = true;
            this.RueRechClient.Location = new System.Drawing.Point(53, 193);
            this.RueRechClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RueRechClient.Name = "RueRechClient";
            this.RueRechClient.Size = new System.Drawing.Size(33, 16);
            this.RueRechClient.TabIndex = 14;
            this.RueRechClient.Text = "Rue";
            // 
            // ClientRechClient
            // 
            this.ClientRechClient.AutoSize = true;
            this.ClientRechClient.Location = new System.Drawing.Point(45, 149);
            this.ClientRechClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientRechClient.Name = "ClientRechClient";
            this.ClientRechClient.Size = new System.Drawing.Size(41, 16);
            this.ClientRechClient.TabIndex = 13;
            this.ClientRechClient.Text = "Client";
            // 
            // telephoneTextBoxRechClient
            // 
            this.telephoneTextBoxRechClient.Location = new System.Drawing.Point(97, 310);
            this.telephoneTextBoxRechClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telephoneTextBoxRechClient.Name = "telephoneTextBoxRechClient";
            this.telephoneTextBoxRechClient.Size = new System.Drawing.Size(132, 22);
            this.telephoneTextBoxRechClient.TabIndex = 26;
            this.telephoneTextBoxRechClient.TextChanged += new System.EventHandler(this.telephoneTextBoxRechClient_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 314);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Télephone";
            // 
            // rechercheClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telephoneTextBoxRechClient);
            this.Controls.Add(this.RechClient);
            this.Controls.Add(this.dataRechClient);
            this.Controls.Add(this.ValiderRechClientbtn);
            this.Controls.Add(this.AnnulerRechClientbtn);
            this.Controls.Add(this.ClientExbtn);
            this.Controls.Add(this.CodePostalTextBoxRechClient);
            this.Controls.Add(this.VilleTextBoxRechClient);
            this.Controls.Add(this.RueTextBoxRechClient);
            this.Controls.Add(this.ClientTextBoxRechClient);
            this.Controls.Add(this.CodePostalRechClient);
            this.Controls.Add(this.VilleRechClient);
            this.Controls.Add(this.RueRechClient);
            this.Controls.Add(this.ClientRechClient);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "rechercheClient";
            this.Text = "rechercheClient";
            this.Load += new System.EventHandler(this.rechercheClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRechClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RechClient;
        private System.Windows.Forms.DataGridView dataRechClient;
        private System.Windows.Forms.Button ValiderRechClientbtn;
        private System.Windows.Forms.Button AnnulerRechClientbtn;
        private System.Windows.Forms.Button ClientExbtn;
        private System.Windows.Forms.TextBox CodePostalTextBoxRechClient;
        private System.Windows.Forms.TextBox VilleTextBoxRechClient;
        private System.Windows.Forms.TextBox RueTextBoxRechClient;
        public System.Windows.Forms.TextBox ClientTextBoxRechClient;
        private System.Windows.Forms.Label CodePostalRechClient;
        private System.Windows.Forms.Label VilleRechClient;
        private System.Windows.Forms.Label RueRechClient;
        private System.Windows.Forms.Label ClientRechClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn od;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.TextBox telephoneTextBoxRechClient;
        private System.Windows.Forms.Label label1;
    }
}