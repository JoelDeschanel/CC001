using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Ecole
    {

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Identifiant { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Birthday { get; set; }
        public byte[] image { get; set; }

        public Ecole(string nom, string prenom, string identifiant, string email, string contact, DateTime birthday)
        {
            Nom = nom;
            Prenom = prenom;
            Identifiant = identifiant;
            Email = email;
            Contact = contact;
            Birthday = birthday;
        }

        public override bool Equals(object obj)
        {
            return obj is Ecole ecole &&
                   Identifiant == ecole.Identifiant;
        }

        public override int GetHashCode()
        {
            return 574969646 + EqualityComparer<string>.Default.GetHashCode(Identifiant);
        }
    }
}
