namespace Project
{
    partial class ListeProduit
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ProduitInexbtn = new System.Windows.Forms.Button();
            this.AnnulerProduitsbtn = new System.Windows.Forms.Button();
            this.ValiderProduitsbtn = new System.Windows.Forms.Button();
            this.listeProduitdgv = new System.Windows.Forms.DataGridView();
            this.CodeProduitDataView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProduitDataView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeProduitDataView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxInput = new System.Windows.Forms.TextBox();
            this.minInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RechClient = new System.Windows.Forms.Label();
            this.RechProduitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listeProduitdgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProduitInexbtn);
            this.groupBox2.Controls.Add(this.AnnulerProduitsbtn);
            this.groupBox2.Controls.Add(this.ValiderProduitsbtn);
            this.groupBox2.Location = new System.Drawing.Point(957, 132);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(117, 190);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // ProduitInexbtn
            // 
            this.ProduitInexbtn.Location = new System.Drawing.Point(8, 124);
            this.ProduitInexbtn.Margin = new System.Windows.Forms.Padding(4);
            this.ProduitInexbtn.Name = "ProduitInexbtn";
            this.ProduitInexbtn.Size = new System.Drawing.Size(100, 44);
            this.ProduitInexbtn.TabIndex = 2;
            this.ProduitInexbtn.Text = "Produit inexistant";
            this.ProduitInexbtn.UseVisualStyleBackColor = true;
            this.ProduitInexbtn.Click += new System.EventHandler(this.ProduitInexbtn_Click);
            // 
            // AnnulerProduitsbtn
            // 
            this.AnnulerProduitsbtn.Location = new System.Drawing.Point(8, 74);
            this.AnnulerProduitsbtn.Margin = new System.Windows.Forms.Padding(4);
            this.AnnulerProduitsbtn.Name = "AnnulerProduitsbtn";
            this.AnnulerProduitsbtn.Size = new System.Drawing.Size(100, 43);
            this.AnnulerProduitsbtn.TabIndex = 1;
            this.AnnulerProduitsbtn.Text = "Annuler";
            this.AnnulerProduitsbtn.UseVisualStyleBackColor = true;
            this.AnnulerProduitsbtn.Click += new System.EventHandler(this.AnnulerProduitsbtn_Click);
            // 
            // ValiderProduitsbtn
            // 
            this.ValiderProduitsbtn.Location = new System.Drawing.Point(8, 23);
            this.ValiderProduitsbtn.Margin = new System.Windows.Forms.Padding(4);
            this.ValiderProduitsbtn.Name = "ValiderProduitsbtn";
            this.ValiderProduitsbtn.Size = new System.Drawing.Size(100, 43);
            this.ValiderProduitsbtn.TabIndex = 0;
            this.ValiderProduitsbtn.Text = "Valider";
            this.ValiderProduitsbtn.UseVisualStyleBackColor = true;
            this.ValiderProduitsbtn.Click += new System.EventHandler(this.ValiderProduitsbtn_Click);
            // 
            // listeProduitdgv
            // 
            this.listeProduitdgv.AllowUserToAddRows = false;
            this.listeProduitdgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.listeProduitdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listeProduitdgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listeProduitdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeProduitdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeProduitDataView,
            this.ProduitDataView,
            this.prix,
            this.TypeProduitDataView});
            this.listeProduitdgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.listeProduitdgv.Location = new System.Drawing.Point(265, 30);
            this.listeProduitdgv.Margin = new System.Windows.Forms.Padding(4);
            this.listeProduitdgv.Name = "listeProduitdgv";
            this.listeProduitdgv.ReadOnly = true;
            this.listeProduitdgv.RowHeadersWidth = 51;
            this.listeProduitdgv.Size = new System.Drawing.Size(692, 396);
            this.listeProduitdgv.TabIndex = 4;
            // 
            // CodeProduitDataView
            // 
            this.CodeProduitDataView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodeProduitDataView.HeaderText = "Code Produit";
            this.CodeProduitDataView.MinimumWidth = 6;
            this.CodeProduitDataView.Name = "CodeProduitDataView";
            this.CodeProduitDataView.ReadOnly = true;
            // 
            // ProduitDataView
            // 
            this.ProduitDataView.HeaderText = "Produit";
            this.ProduitDataView.MinimumWidth = 6;
            this.ProduitDataView.Name = "ProduitDataView";
            this.ProduitDataView.ReadOnly = true;
            this.ProduitDataView.Width = 125;
            // 
            // prix
            // 
            this.prix.HeaderText = "Prix";
            this.prix.MinimumWidth = 6;
            this.prix.Name = "prix";
            this.prix.ReadOnly = true;
            this.prix.Width = 125;
            // 
            // TypeProduitDataView
            // 
            this.TypeProduitDataView.HeaderText = "Type Produit";
            this.TypeProduitDataView.MinimumWidth = 6;
            this.TypeProduitDataView.Name = "TypeProduitDataView";
            this.TypeProduitDataView.ReadOnly = true;
            this.TypeProduitDataView.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxInput);
            this.groupBox1.Controls.Add(this.minInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RechClient);
            this.groupBox1.Controls.Add(this.RechProduitTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(244, 240);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // maxInput
            // 
            this.maxInput.Location = new System.Drawing.Point(36, 193);
            this.maxInput.Margin = new System.Windows.Forms.Padding(4);
            this.maxInput.Name = "maxInput";
            this.maxInput.Size = new System.Drawing.Size(161, 22);
            this.maxInput.TabIndex = 30;
            this.maxInput.TextChanged += new System.EventHandler(this.maxInput_TextChanged);
            // 
            // minInput
            // 
            this.minInput.Location = new System.Drawing.Point(36, 145);
            this.minInput.Margin = new System.Windows.Forms.Padding(4);
            this.minInput.Name = "minInput";
            this.minInput.Size = new System.Drawing.Size(161, 22);
            this.minInput.TabIndex = 29;
            this.minInput.TextChanged += new System.EventHandler(this.minInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "et";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Prix entre";
            // 
            // RechClient
            // 
            this.RechClient.AutoSize = true;
            this.RechClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechClient.Location = new System.Drawing.Point(8, 20);
            this.RechClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RechClient.Name = "RechClient";
            this.RechClient.Size = new System.Drawing.Size(143, 17);
            this.RechClient.TabIndex = 26;
            this.RechClient.Text = "Recherche Produit";
            // 
            // RechProduitTextBox
            // 
            this.RechProduitTextBox.Location = new System.Drawing.Point(100, 68);
            this.RechProduitTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RechProduitTextBox.Name = "RechProduitTextBox";
            this.RechProduitTextBox.Size = new System.Drawing.Size(132, 22);
            this.RechProduitTextBox.TabIndex = 1;
            this.RechProduitTextBox.TextChanged += new System.EventHandler(this.RechProduitTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Designation";
            // 
            // ListeProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listeProduitdgv);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListeProduit";
            this.Text = "ListeProduit";
            this.Load += new System.EventHandler(this.ListeProduit_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listeProduitdgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ProduitInexbtn;
        private System.Windows.Forms.Button AnnulerProduitsbtn;
        private System.Windows.Forms.Button ValiderProduitsbtn;
        private System.Windows.Forms.DataGridView listeProduitdgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RechProduitTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeProduitDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduitDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeProduitDataView;
        private System.Windows.Forms.Label RechClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maxInput;
        private System.Windows.Forms.TextBox minInput;
    }
}