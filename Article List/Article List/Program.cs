using System;
using Article_List.Articole;
using System.Collections.Generic;

namespace Article_List
{
    // parcurc fiecare autor si pt fiecare autor trebuie sa parcurgi fiecare articol si sa numeri si sal bag inr-un vector de frecventa
    internal class Program
    {
        //Afisari
        #region afisare articol
        static void afisare(Articol[] carti )
        {
            for ( int i = 0; i < carti.Length; i++ )
            {
                Console.WriteLine(carti[i]);
            }
        }
        #endregion

        //Filtre
        #region filtru autor
        static Articol[] filtruautor(Articol[] carti , string autor)
        {
            int index = 0;
            Articol[] rezultat = new Articol[carti.Length];
            for ( int i = 0; i < carti.Length; i++)
            {
                if (carti[i].Autori.Contains(autor))
                {
                    rezultat[index] = carti[i]; 
                    index++;
                }
            }
            return rezultat;
        }
        #endregion
        #region filtru tags
        static Articol[] filtrutags(Articol[] carti, string tags)
        {
            int index = 0;
            Articol[] rezultat = new Articol[carti.Length];
            for (int i = 0; i < carti.Length; i++)
            {
                if (carti[i].Tags.Contains(tags))
                {
                    rezultat[index] = carti[i];
                    index++;
                }
            }
            return rezultat;
        }
        #endregion
        #region filtru continut
        static Articol[] filtrucontinut(Articol[] carti, string continut)
        {
            int index = 0;
            Articol[] rezultat = new Articol[carti.Length];
            for (int i = 0; i < carti.Length; i++)
            {
                if (carti[i].Continut.Contains(continut))
                {
                    rezultat[index] = carti[i];
                    index++;
                }
            }         
            return rezultat;
        }
        #endregion
        #region filtru data
        static Articol[] filtrudata(Articol[] carti, DateTime Start , DateTime End)
        {
            int index = 0;
            Articol[] rezultat = new Articol[carti.Length];
            for (int i = 0; i < carti.Length; i++)
            {
                if (carti[i].Published > Start && carti[i].Published < End)
                {
                    rezultat[index] = carti[i];
                    index++;
                }
            }
            return rezultat;
        }
        #endregion 
        #region filtru weekend
        static Articol[] filtruweekend(Articol[] carti )
        {
            int index = 0;
            Articol[] rezultat = new Articol[carti.Length];
            for (int i = 0; i < carti.Length; i++)
            {
                if (carti[i].Published.DayOfWeek == DayOfWeek.Saturday || carti[i].Published.DayOfWeek == DayOfWeek.Sunday)
                {
                    rezultat[index] = carti[i];
                    index++;
                }
            }
            return rezultat;
        }
        #endregion

        //Sortari
        #region Sortare Likes Crescator
        static public void sortareLikesCrescator(Articol[] carti )
        {
            for (int i = 0; i < carti.Length - 1 ; i++)
            {
                for ( int j = i + 1; j < carti.Length; j++)
                {
                    if(carti[i].Likes  > carti[i].Likes)
                    {
                        Articol aux = carti[i];
                        carti[i] = carti[j];
                        carti[j] = aux;
                    }
                }
            }
        }
        #endregion
        #region Sortare Dislikes Crescator
        static public void sortareDisLikesCrescator(Articol[] carti )
        {
            for ( int i  = 0; i < carti.Length - 1 ; i++)
            {
                for ( int j = i + 1; j < carti.Length; j++)
                {
                    if (carti[i].Dislikes > carti[i].Dislikes)
                    {
                        Articol aux = carti[i];
                        carti[i] = carti[j];
                        carti[j] = aux;
                    }
                }
            }
        }
        #endregion      
        #region Sortare Likes Descrescator
       static public void sortareLikesDescrescator(Articol[] carti)
        {
            for (int i = 0; i < carti.Length - 1; i++)
            {
                for (int j = i + 1; j < carti.Length; j++)
                {
                    if (carti[i].Likes < carti[i].Likes)
                    {
                        Articol aux = carti[i];
                        carti[i] = carti[j];
                        carti[j] = aux;
                    }
                }
            }
        }

        #endregion
        #region sortare Dislike Descrescator
        static public void sortareDisLikesDescrescator(Articol[] carti)
        {
            for (int i = 0; i < carti.Length - 1; i++)
            {
                for (int j = i + 1; j < carti.Length; j++)
                {
                    if (carti[i].Dislikes < carti[i].Dislikes)
                    {
                        Articol aux = carti[i];
                        carti[i] = carti[j];
                        carti[j] = aux;
                    }
                }
            }
        }
        #endregion
        #region Sortare Data Cronologic
        static public void sortareDateTimeCronologic(Articol[] carti)
        {
            for (int i = 0; i < carti.Length - 1; i++)
            {
                for(int j = i + 1; j < carti.Length; j++)
                {
                    if (carti[i].Published > carti[j].Published)
                    {
                        Articol aux = carti[i];
                        carti[i] = carti[j];
                        carti[j] = aux;

                    }                
                }
            }
        }
        #endregion
        static void Main(string[] args)
        {
            List<string> autori = new List<string> { "Costea Raul", "Jhon Doe", "Jordan Peterson" };
            List<string> tags = new List<string>() { "Mancare", "Sport", "Educatie", "Mister", "Dezvoltare Personala" };

            Articol[] carti = new Articol[3];
            carti[0] = new Articol("Carte0", new List<string> { autori[0] }, "Random", new DateTime(2002, 8, 9), new List<string> { tags[0], tags[1] });
            carti[1] = new Articol("Carte1", new List<string> { autori[1] }, "Random", new DateTime(2000, 10, 12), new List<string> { tags[3] });
            carti[2] = new Articol("Carte2", new List<string> { autori[1], autori[2] }, "Scoala", new DateTime(2012, 9, 7), new List<string> { tags[3], tags[2] });
            carti[1].AddLike();
            carti[0].AddLike();
            carti[0].AddLike();
            carti[1].AddLike();
            carti[2].AddDislike();
            afisare(filtruautor(carti ,autori[1]));
            afisare(filtrutags(carti , tags[3]));
            afisare(filtrucontinut(carti, "Random"));
            afisare(filtrudata(carti, new DateTime (2000,4,3) , new DateTime (2014,5,2)));
            afisare(filtruweekend(carti));
            sortareDateTimeCronologic(carti);
            afisare(carti);
        }
    }
}
