namespace ProjectExamenCSHARP
{
    partial class FormInscriptionUser
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNomInscription = new System.Windows.Forms.TextBox();
            this.txtPrenomInscription = new System.Windows.Forms.TextBox();
            this.txtEmailInscription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnregistrerInscription = new System.Windows.Forms.Button();
            this.rdProfesseurInscription = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rdGestionnaireInscription = new System.Windows.Forms.RadioButton();
            this.dgvInscriptionUser = new System.Windows.Forms.DataGridView();
            this.btnModifierInscription = new System.Windows.Forms.Button();
            this.btnSupprimerInscription = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscriptionUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomInscription
            // 
            this.txtNomInscription.Location = new System.Drawing.Point(29, 69);
            this.txtNomInscription.Multiline = true;
            this.txtNomInscription.Name = "txtNomInscription";
            this.txtNomInscription.Size = new System.Drawing.Size(198, 42);
            this.txtNomInscription.TabIndex = 0;
            this.txtNomInscription.TextChanged += new System.EventHandler(this.txtNomInscription_TextChanged);
            this.txtNomInscription.Leave += new System.EventHandler(this.txtNomInscription_Leave);
            this.txtNomInscription.Validating += new System.ComponentModel.CancelEventHandler(this.txtNomInscription_Validating);
            // 
            // txtPrenomInscription
            // 
            this.txtPrenomInscription.Location = new System.Drawing.Point(29, 194);
            this.txtPrenomInscription.Multiline = true;
            this.txtPrenomInscription.Name = "txtPrenomInscription";
            this.txtPrenomInscription.Size = new System.Drawing.Size(198, 42);
            this.txtPrenomInscription.TabIndex = 1;
            this.txtPrenomInscription.TextChanged += new System.EventHandler(this.txtPrenomInscription_TextChanged);
            this.txtPrenomInscription.Leave += new System.EventHandler(this.txtPrenomInscription_Leave);
            this.txtPrenomInscription.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrenomInscription_Validating);
            // 
            // txtEmailInscription
            // 
            this.txtEmailInscription.Location = new System.Drawing.Point(29, 319);
            this.txtEmailInscription.Multiline = true;
            this.txtEmailInscription.Name = "txtEmailInscription";
            this.txtEmailInscription.Size = new System.Drawing.Size(198, 42);
            this.txtEmailInscription.TabIndex = 2;
            this.txtEmailInscription.TextChanged += new System.EventHandler(this.txtEmailInscription_TextChanged);
            this.txtEmailInscription.Leave += new System.EventHandler(this.txtEmailInscription_Leave);
            this.txtEmailInscription.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmailInscription_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // btnEnregistrerInscription
            // 
            this.btnEnregistrerInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrerInscription.Location = new System.Drawing.Point(29, 579);
            this.btnEnregistrerInscription.Name = "btnEnregistrerInscription";
            this.btnEnregistrerInscription.Size = new System.Drawing.Size(142, 37);
            this.btnEnregistrerInscription.TabIndex = 8;
            this.btnEnregistrerInscription.Text = "Enregistrer";
            this.btnEnregistrerInscription.UseVisualStyleBackColor = true;
            this.btnEnregistrerInscription.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdProfesseurInscription
            // 
            this.rdProfesseurInscription.AutoSize = true;
            this.rdProfesseurInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdProfesseurInscription.Location = new System.Drawing.Point(12, 463);
            this.rdProfesseurInscription.Name = "rdProfesseurInscription";
            this.rdProfesseurInscription.Size = new System.Drawing.Size(124, 29);
            this.rdProfesseurInscription.TabIndex = 9;
            this.rdProfesseurInscription.TabStop = true;
            this.rdProfesseurInscription.Text = "Professeur";
            this.rdProfesseurInscription.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Role";
            // 
            // rdGestionnaireInscription
            // 
            this.rdGestionnaireInscription.AutoSize = true;
            this.rdGestionnaireInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGestionnaireInscription.Location = new System.Drawing.Point(146, 463);
            this.rdGestionnaireInscription.Name = "rdGestionnaireInscription";
            this.rdGestionnaireInscription.Size = new System.Drawing.Size(140, 29);
            this.rdGestionnaireInscription.TabIndex = 11;
            this.rdGestionnaireInscription.TabStop = true;
            this.rdGestionnaireInscription.Text = "Gestionnaire";
            this.rdGestionnaireInscription.UseVisualStyleBackColor = true;
            // 
            // dgvInscriptionUser
            // 
            this.dgvInscriptionUser.AllowUserToAddRows = false;
            this.dgvInscriptionUser.AllowUserToDeleteRows = false;
            this.dgvInscriptionUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscriptionUser.Location = new System.Drawing.Point(292, 24);
            this.dgvInscriptionUser.Name = "dgvInscriptionUser";
            this.dgvInscriptionUser.ReadOnly = true;
            this.dgvInscriptionUser.Size = new System.Drawing.Size(596, 520);
            this.dgvInscriptionUser.TabIndex = 12;
            this.dgvInscriptionUser.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInscriptionUser_CellMouseDoubleClick);
            // 
            // btnModifierInscription
            // 
            this.btnModifierInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierInscription.Location = new System.Drawing.Point(320, 579);
            this.btnModifierInscription.Name = "btnModifierInscription";
            this.btnModifierInscription.Size = new System.Drawing.Size(158, 37);
            this.btnModifierInscription.TabIndex = 13;
            this.btnModifierInscription.Text = "Modifier";
            this.btnModifierInscription.UseVisualStyleBackColor = true;
            this.btnModifierInscription.Click += new System.EventHandler(this.btnModifierInscription_Click);
            // 
            // btnSupprimerInscription
            // 
            this.btnSupprimerInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerInscription.Location = new System.Drawing.Point(656, 579);
            this.btnSupprimerInscription.Name = "btnSupprimerInscription";
            this.btnSupprimerInscription.Size = new System.Drawing.Size(158, 37);
            this.btnSupprimerInscription.TabIndex = 14;
            this.btnSupprimerInscription.Text = "Supprimer";
            this.btnSupprimerInscription.UseVisualStyleBackColor = true;
            this.btnSupprimerInscription.Click += new System.EventHandler(this.btnSupprimerInscription_Click);
            // 
            // FormInscriptionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 664);
            this.Controls.Add(this.btnSupprimerInscription);
            this.Controls.Add(this.btnModifierInscription);
            this.Controls.Add(this.dgvInscriptionUser);
            this.Controls.Add(this.rdGestionnaireInscription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdProfesseurInscription);
            this.Controls.Add(this.btnEnregistrerInscription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmailInscription);
            this.Controls.Add(this.txtPrenomInscription);
            this.Controls.Add(this.txtNomInscription);
            this.Name = "FormInscriptionUser";
            this.Text = "Inscription";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInscriptionUser_FormClosing);
            this.Load += new System.EventHandler(this.FormInscriptionUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscriptionUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomInscription;
        private System.Windows.Forms.TextBox txtPrenomInscription;
        private System.Windows.Forms.TextBox txtEmailInscription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnregistrerInscription;
        private System.Windows.Forms.RadioButton rdProfesseurInscription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdGestionnaireInscription;
        private System.Windows.Forms.DataGridView dgvInscriptionUser;
        private System.Windows.Forms.Button btnModifierInscription;
        private System.Windows.Forms.Button btnSupprimerInscription;
    }
}

