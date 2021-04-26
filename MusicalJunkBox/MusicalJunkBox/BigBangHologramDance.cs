using System;
using System.Collections.Generic;
using System.Text;

namespace MusicalJunkBox
{
    class BigBangHologramDance:MusicalJunkBox, InterfaceMusic
    {
        protected int track;

        public override void AlbumTitle()
        {
            Console.WriteLine("Congratz, you have chosen Big Bang.");
        }
        public BigBangHologramDance()
        {

        }
        public BigBangHologramDance(int track)
        {
            this.track = track;
           
            if (track is 1)
            {
                Console.WriteLine("This is BB Track 1- Haru");
            }
            else if (track is 2)
            {
                Console.WriteLine("This is BB Track 2- Lies");
            }
            else if (track is 3)
            {
                Console.WriteLine("This is BB Track 3- Tonight");
            }
        }
        public int PlayMusic()
        {
            Console.WriteLine("Blablabla");
            return track;
        }
        public void Tempo(int speed)
        {
    
            Console.WriteLine("Dance slower by " + speed + "x");
        }
    }
}
