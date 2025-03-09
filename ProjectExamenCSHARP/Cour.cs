using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExamenCSHARP
{
    internal class Cour
    {
        public int Id {  get; set; }
        public string Description  { get; set; }
        public DateTime HeureDebut {  get; set; }
        public DateTime HeureFin { get; set; }

        public int SalleId { get; set; }   

        public Salle Salle { get; set; }

        public Cour()
        {
        }
    }
}
