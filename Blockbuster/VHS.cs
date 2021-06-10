using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    class VHS : Movie
    {
        //Base is a reference to the parent class, if the parent has parameters in its constructor, the child must call base in its own constructor to pass values up to the parent
        //the child constructor needs to use the same constructor as the parent with : base and its properties after as well
        //Outside of Constructors, base functions much like the this. keyword
        //but instead of pointing to itself, it points to its immediate parent
        //We can assign properties initial values. Here we're setting CurrentTime to 0;
        public int CurrentTime { get; set; } = 0;
        public VHS(string title, int runtime, Genre genre, List<string> Scenes) : base (title, runtime, genre, Scenes)
        {

        }

        //fix this method tonight
        public override void Play()
        {
            string scene = Scenes[CurrentTime];
            Console.WriteLine(scene);
            CurrentTime++;
        }
    
         public void Rewind()
        {
            if (true)
            {

                CurrentTime = 0;
            }
            else
            {

            }
        }
    }
}
