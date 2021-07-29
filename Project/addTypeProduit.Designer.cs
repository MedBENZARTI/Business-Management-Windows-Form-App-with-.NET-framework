namespace Project
{
    partial class addTypeProduit
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
            this.cancel = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.typename = new System.Windows.Forms.TextBox();
            this.newType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(232, 111);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(96, 31);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Annuler";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(121, 111);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(96, 31);
            this.add.TabIndex = 1;
            this.add.Text = "Ajouter";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // typename
            // 
            this.typename.Location = new System.Drawing.Point(150, 34);
            this.typename.Multiline = true;
            this.typename.Name = "typename";
            this.typename.Size = new System.Drawing.Size(178, 47);
            this.typename.TabIndex = 3;
            // 
            // newType
            // 
            this.newType.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.newType.Location = new System.Drawing.Point(12, 34);
            this.newType.Name = "newType";
            this.newType.Size = new System.Drawing.Size(108, 44);
            this.newType.TabIndex = 5;
            this.newType.Text = "Nouveau Type";
            this.newType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addTypeProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 176);
            this.Controls.Add(this.newType);
            this.Controls.Add(this.typename);
            this.Controls.Add(this.add);
            this.Controls.Add(this.cancel);
            this.Name = "addTypeProduit";
            this.Text = "addTypeProduit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox typename;
        private System.Windows.Forms.Label newType;
    }
}