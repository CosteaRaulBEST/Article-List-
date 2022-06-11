using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article_List.Articole
{
    public class Articol
    {

        public string Titlu;
        public List<string> Autori = new List<string>();
        public string Continut;
        public DateTime Published;
        public DateTime Lastmodified;
        public int Likes;
        public int Dislikes;
        public List<string> Tags = new List<string>();

        public Articol(string titlu, List<string> autori, string continut, DateTime published, List<string> tags)
        {
            Titlu = titlu;
            Autori = autori;
            Continut = continut;
            Published = published;
            Tags = tags;
            Likes = 0;
            Dislikes = 0;
        }
        public override string ToString()
        {
            // "Tiltu carti este Romania a fost scrisa de Costea Raul,Costea Paul in anul 2020"
            return $"Titlu cartii {Titlu} a fost scrisa de {string.Join(",", Autori)} pe data de {Published.Day}/{Published.Month}/{Published.Year}";
        }
        public void AddLike()
        {
            Likes++;
        }
        public void AddDislike()
        {
            Dislikes++;
        }
        


    }
}
