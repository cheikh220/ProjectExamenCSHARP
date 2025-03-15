using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ProjectExamenCSHARP
{
    public partial class FormInscriptionUser : Form
    {
        private bool validePrenom = false;
        private bool valideNom = false;
        private bool valideEmail = false;
        private bool fermetureForcee = false;
        private int userSelectionne  = 0;   
        public FormInscriptionUser()
        {
            InitializeComponent();
           
        }
        private bool nomValide(string name)
        {
            return Regex.IsMatch(name, @"^[A-Za-zÀ-ÖØ-öø-ÿ\s]+$");
        }
        // permet l'enregistrement d'un utilisateur dans la base de donnee tout en verifiant qu'il n'as pas un autre email identique dans la base de donnee
        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new DBGestion())
            {
                string email = txtEmailInscription.Text.Trim();

                var emailExiste = db.Users.Any(u => u.Email == email);

                if (emailExiste)
                {
                    MessageBox.Show("Cet email est déjà enregistré. Veuillez en choisir un autre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string password = "passer";
                User user = new User
                {
                    Nom = txtNomInscription.Text,
                    Prenom = txtPrenomInscription.Text,
                    Email = email,
                    Password = BCrypt.Net.BCrypt.HashPassword(password),
                    Role = (rdProfesseurInscription.Checked) ? "Professeur" : "Gestionnaire"
                };

                db.Users.Add(user);
                db.SaveChanges();
                EnvoyerEmail(email, password);

                effacer();
                MessageBox.Show("L'utilisateur a été enregistré.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualiser();
            }
        }

        private void EnvoyerEmail(string destinataire, string mdp)
        {
            try
            {
                // Définir l'expéditeur et le destinataire
                MailMessage message = new MailMessage();
                message.From = new MailAddress("cheickhtidianendiaye@gmail.com");
                message.To.Add(destinataire);
                message.Subject = "Sujet de l'email";
                message.Body = "Bonjour "+mdp +" est ton mot de passe par default il faudra le changer .";
                message.IsBodyHtml = false; // Mettre true si le corps est en HTML

                // Configurer le client SMTP
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("cheickhtidianendiaye@gmail.com", "lzfm hsaw ogob jejy");
                smtp.EnableSsl = true;

                // Envoyer l'email
                smtp.Send(message);

                MessageBox.Show("Email envoyé avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        //pour le chargement des information des users dans le data grid view
        private void actualiser()
        {
            using(var db = new DBGestion())
            {
                dgvInscriptionUser.DataSource = db.Users.Select(u => new{u.Id,u.Nom,u.Prenom,u.Email,u.Role }).ToList();
            }
        }
        // pour effacer ltous les champs 
        private void effacer()
        {
            txtNomInscription.Text = string.Empty;
            txtPrenomInscription.Text= string.Empty;
            txtEmailInscription.Text = string.Empty;
            rdProfesseurInscription.Checked = true;
            validePrenom = false;
            valideNom = false;
            valideEmail = false;
            champValide();
        }

        private void txtEmailInscription_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtEmailInscription_Leave(object sender, EventArgs e)
        {
           
        }
        // permet lors du chargement du formulaire d'avoir acced au data gride view, aux bouton modifier suprimer sans que la validation des champs nous ne l'empeche
        // et aussi d'actualiser le chargement des donne dans le data grid view egalement de mettre en place la fonction chsmpvalide
        private void FormInscriptionUser_Load(object sender, EventArgs e)
        {
            dgvInscriptionUser.CausesValidation = false;
            btnModifierInscription.CausesValidation = false;
            btnSupprimerInscription.CausesValidation = false;
            rdProfesseurInscription.Checked = true;
            champValide();
            actualiser();
        }

        private void txtNomInscription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomInscription_Leave(object sender, EventArgs e)
        {

        }

        private void txtPrenomInscription_TextChanged(object sender, EventArgs e)
        {

        }
        //cette fonction permet de descativer le bouton enregistrer tant que tous les champs ne soit pas valide
        private void champValide()
        {
            if(valideEmail == true && valideNom == true && validePrenom == true)
            {
                btnEnregistrerInscription.Enabled = true;
            }
            else
            {
                btnEnregistrerInscription.Enabled = false;
            }
        }
        private void txtPrenomInscription_Leave(object sender, EventArgs e)
        {
            
        }
        // permet de verifier la validiter du champs nom
        private void txtNomInscription_Validating(object sender, CancelEventArgs e)
        {
            if (fermetureForcee) return;
            if (!nomValide(txtNomInscription.Text))
            {
                MessageBox.Show("Le nom est invalide. Il doit contenir uniquement des lettres.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;

            }
            else
            {
                valideNom = true;
            }
            champValide();
        }
        // permet de verifier la validiter du champs prenom
        private void txtPrenomInscription_Validating(object sender, CancelEventArgs e)
        {
            if (fermetureForcee) return;
            if (!nomValide(txtPrenomInscription.Text))
            {
                MessageBox.Show("Le prénom est invalide. Il doit contenir uniquement des lettres.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel= true;

            }
            else
            {
                validePrenom = true;
            }
            champValide();
        }
        // permet de verifier la validiter du champs email
        private void txtEmailInscription_Validating(object sender, CancelEventArgs e)
        {
            if (fermetureForcee) return;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txtEmailInscription.Text, pattern))
            {
                MessageBox.Show("Adresse email invalide. Veuillez saisir un email valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
            else
            {
                valideEmail = true;
            }
            champValide();
        }
        //permet de fermer le formulaire sans etre obliger de valider tous les champs
        private void FormInscriptionUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            fermetureForcee = true;
            this.AutoValidate = AutoValidate.Disable;
            e.Cancel = false;

        }
        //permet de charger les information de la ligne double cliquer sur le data grid view dans les differents champ corespondant 
        //et aussi de recupere l'id de la ligne double ciquer et la mettre dans une variable global  
        private void dgvInscriptionUser_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idUsers = Convert.ToInt32(dgvInscriptionUser.Rows[e.RowIndex].Cells["Id"].Value);
            userSelectionne = idUsers;
            using (var db = new DBGestion())
            {
                var user = db.Users.SingleOrDefault(x => x.Id == idUsers);
                if (user != null)
                {
                    txtPrenomInscription.Text = user.Prenom;
                    txtNomInscription.Text = user.Nom;
                    txtEmailInscription.Text = user.Email;


                    if (user.Role == "Professeur")
                    {
                        rdProfesseurInscription.Checked = true;
                    }
                    else
                    {
                        rdGestionnaireInscription.Checked= true;
                    }
                }
                else
                {
                    MessageBox.Show("Utilisateur introuvable !");
                }
            }
        }
        //fonction qui permet de modifier un utilisateur tout en verifiant qu'il n'as pas un autre email identique dans la base de donnee 
        private void ModifierUser(int idUser)
        {
            using (var db = new DBGestion())
            {
                var user = db.Users.SingleOrDefault(e => e.Id == idUser);

                if (user != null)
                {
                    string email = txtEmailInscription.Text.Trim();

                    bool emailExiste = db.Users.Any(u => u.Email == email && u.Id != idUser);
                    if (emailExiste)
                    {
                        MessageBox.Show("Cet email est déjà utilisé par un autre utilisateur. Veuillez en choisir un autre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }
                    user.Prenom = txtPrenomInscription.Text;
                    user.Nom = txtNomInscription.Text;
                    user.Email = email;
                    user.Role = rdGestionnaireInscription.Checked ? "Gestionnaire" : "Professeur";

                    db.SaveChanges();

                    MessageBox.Show("L'utilisateur a été modifié avec succès.", "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    actualiser();
                }
                else
                {
                    MessageBox.Show("Utilisateur introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //action realiser lorqu'on clique sur le bouton modifier
        private void btnModifierInscription_Click(object sender, EventArgs e)
        {
            
            if (dgvInscriptionUser.SelectedRows.Count > 0)
            {
                ModifierUser(userSelectionne);
                effacer();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à modifier.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //fonction permetant de supprimer un utilisateur
        private void SupprimerUser(int idUser)
        {
            using (var db = new DBGestion())
            {
                var User = db.Users.SingleOrDefault(e => e.Id == idUser);

                if (User != null)
                {

                    var confirmation = MessageBox.Show("Voulez-vous vraiment supprimer l'utilisateur ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmation == DialogResult.Yes)
                    {

                        db.Users.Remove(User);
                        db.SaveChanges();

                        MessageBox.Show("L'utilisateur a été supprimé avec succès.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        actualiser();
                    }
                }
                else
                {
                    MessageBox.Show("utilisateur introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            }
        //action realiser lorsqu'on clique sur le boton supprimer
        private void btnSupprimerInscription_Click(object sender, EventArgs e)
        {
            
            if (dgvInscriptionUser.SelectedRows.Count > 0)
            {
                SupprimerUser(userSelectionne);
                effacer();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
