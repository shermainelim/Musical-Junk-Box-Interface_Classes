using System;
using System.Collections.Generic;
using System.Text;

namespace MusicalJunkBox
{
    class HyunaAlbum : MusicalJunkBox,InterfaceMusic
    {
        protected int track;

        List<Tracks> albumList;
         public override void AlbumTitle()
        {
            Console.WriteLine("We're selecting Hyuna's album now.");
        }
        public HyunaAlbum()
        {
            albumList = new List<Tracks>();
            initializeDataList();
        }
        public HyunaAlbum(int track)
        {
            albumList = new List<Tracks>();
            initializeDataList();
            Tracks tracks = albumList[track - 1];

            Console.WriteLine("This is Hyuna Track {0} - {1}", track, tracks.Name);
            /*
            switch (track)
            {
                case 1:
                    Console.WriteLine("This is Hyuna Track 1- Change");
                    break;
                case 2:
                    Console.WriteLine("This is Hyuna Track 2- Bubble Pop");
                    break;
                case 3:
                    Console.WriteLine("This is Hyuna Track 3- Ice Cream");
                    break;
            }*/

        }

        public void initializeDataList()
        {
            Tracks tracks = new Tracks("Change","Hyuna",3);
            Tracks tracks2 = new Tracks("Bubble Pop", "Hyuna", 2);
            Tracks tracks3 = new Tracks("Ice Cream", "Hyuna", 4);

            albumList.Add(tracks);
            albumList.Add(tracks2);
            albumList.Add(tracks3);
        }
        public int PlayMusic()
        {
            Console.WriteLine("Lalala");
            return track;
        }

        public void Tempo(int speed)
        {

            Console.WriteLine("Dance slower by " + speed + "x");

        }
    }
}
