using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    //always make classes, properties public unless you mean to do otherwise
    public enum Genre
    {
        //This looks like a class
        //However, the only thing that can go in enums is constants 
        //Enums are indexed starting at 0, just like arrays 
        //If you create a new  class then just label it public enum before the Class name it turns into an enum then you just put your enumerations in below within brackets
        Drama,
        Comedy,
        Horror,
        Romance,
        Action
    }
    abstract class Movie
    {
        //Recipe for creating a class
        //1. Properties / variables
        //2. Constructor(s)
        //3. set your properties equal to the variables passed through your constructor
        //4. Create Method(s)

        //What do Concrete classes pass to their children? Properties, variables, constructors and methods.
        //Options for passing methods:
        //1. Regular Method - as is
        //2. Virtual Method - the child has the option to override
        //Add onto a Virtual Method = override the method, call base in the child, and write in the child's own code
        public string Title { get; set; }
        public int Runtime { get; set; }
        public Genre Genre { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string title, int runtime, Genre genre, List<string> scenes)
        {//proper way to set variables to their property is by using the this. prefix when setting equal to
            this.Title = title;
            this.Runtime = runtime;
            this.Genre = genre;
            this.Scenes = scenes;
        }
        //since we're not returning anything here our return type is voidvv
        public void PrintInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Category: " + Genre);
            Console.WriteLine("Run Time: " + Runtime);
        }

        public void PrintScenes()
        {
            Console.WriteLine("Scenes: ");
            foreach (string scene in Scenes)
            {
                Console.WriteLine(scene);
            }

        }
        //Virtual == the child has the option to override the method
        public abstract void Play();
    }
}