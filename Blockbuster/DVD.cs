using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    class DVD : Movie
    {
        public int CurrentTime { get; set; } = 0;
        public DVD(string title, int runtime, Genre genre, List<string> Scenes) : base(title, runtime, genre, Scenes)
        {

        }

        public override void Play()
        {
            string scene = Scenes[CurrentTime];
            Console.WriteLine(scene);
            CurrentTime++;
        }
    }
}
