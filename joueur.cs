using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble
{
    class Joueur
    {
        private string nom;
        private int score;
        private List<string> mots;
        public Joueur(string nom)
        {
            this.nom = nom;
            this.score = 0;
            this.mots = null;
        }
        public void Add_Mot(string mot)
        {
            this.mots.Capacity++; // Ajoute une place pour le nouveau mot trouvé
            this.mots.Add(mot); // Ajoute le nouveau mot à la fin de la liste
        }
        public override string ToString() //?
        {
            string retour = null;
            if (this.nom!=null)
            {
                string listenoms = null;
                for (int i=0; i<this.mots.Capacity; i++)
                {
                    listenoms = listenoms + mots[i]+ '\n';
                }
                retour = this.nom +" a un score de : " + Convert.ToInt32(score) + '\n'
                    + "Ses mots placés sont : " +'\n'+ listenoms;
            }
            else
            {
                retour = "Un nom est nécessaire à la création d'un joueur";
            }
            return retour;
        }
        public void Add_Score(int val)
        {
            this.score = this.score + val;
        }
        public void Remove_Main_Courante(Jeton monjeton)
        {

        }
    }
}
