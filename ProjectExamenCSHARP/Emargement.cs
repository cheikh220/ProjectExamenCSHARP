using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExamenCSHARP
{
    internal class Emargement
    {
        public int Id { get; set; } 

        public DateTime Date { get; set; }  

        public string Statut { get; set; }
        public int ProfesseurId { get; set; }
        public User Professeur { get; set; }

        public int CoursId { get; set; }

        public Cour Cours { get; set; }

        public Emargement()
        {
        }
    }
}
