using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    class BlockbusterVideo
    {
        //create a list of scenes and feed that list into the movies here. NEED TO DO here vvv
        public List<Movie> Movies { get; set; } = new List<Movie>();
        //You may only initialize values, but you may call any methods outside of another method

        //Constructor name must match Class name
        public BlockbusterVideo()
        {
            List<string> shrekScenes = new List<string>() { "1", "2", "3", "4" };
            Movies.Add(new VHS("Shrek", 60, Genre.Drama, shrekScenes));

            List<string> silentHillScenes = new List<string>() { "5", "6", "7", "8" };
            Movies.Add(new DVD("Silent Hill", 110, Genre.Horror, silentHillScenes));

            List<string> theNotebookScenes = new List<string>() { "9", "10", "11", "12" };
            Movies.Add(new DVD("The Notebook", 150, Genre.Romance, theNotebookScenes));

            List<string> pulpFictionScenes = new List<string>() { "13", "14", "15", "16" };
            Movies.Add(new VHS("Pulp Fiction", 70, Genre.Action, pulpFictionScenes));

            List<string> fightClubScenes = new List<string>() { "17", "18", "19", "20" };
            Movies.Add(new VHS("Fight Club", 80, Genre.Action, fightClubScenes));

            List<string> pineappleExpressScenes = new List<string>() { "21", "22", "23", "24" };
            Movies.Add(new VHS("Pineapple Express", 100, Genre.Comedy,pineappleExpressScenes));

        }
            



        public virtual void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];

                Console.WriteLine("Index" + i +  " " + m.Title);

            }
        }

        public Movie Checkout(int index)
        {
            Movie m = Movies[index];
            return m;
        }
    }
}
