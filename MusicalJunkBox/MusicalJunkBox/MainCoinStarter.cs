using System;
using System.Collections.Generic;
using System.Text;

namespace MusicalJunkBox
{
    class MainCoinStarter
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Welcome to Musical Junk Box");
                    Console.WriteLine("Please insert either 1 or 2 coins");
                    int coinAmt = Int32.Parse(Console.ReadLine());

                    if (coinAmt == 1)
                    {
                        Coins();
                    }
                    else if (coinAmt == 2)
                    {
                        Coins();
                        Coins();
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount of coins");
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("'Invalid input");
                }
            }
        }
        public static void Coins()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Please choose album: 1-Hyuna or 2-Big Bang.");
                    int albumChoice = Int32.Parse(Console.ReadLine());
                    if (albumChoice == 1)
                    {
                        HyunaAlbum hyuna0 = new HyunaAlbum();
                        hyuna0.AlbumTitle();
                        //loop
                        Console.WriteLine("Please select from track 1 to 3");
                        var hyunaTune = Int32.Parse(Console.ReadLine());
                        HyunaAlbum hyuna = new HyunaAlbum(hyunaTune);

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Increase Tempo? If yes, press 1.If no, press 0.");
                                int TempoChoice = Int32.Parse(Console.ReadLine());
                                if (TempoChoice == 0)
                                {
                                    hyuna.PlayMusic();
                                    break;
                                }
                                
                                hyuna.Tempo(TempoChoice);
                                hyuna.PlayMusic();
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid option, try again");
                            }
                        }
                       
                    }
                    else if (albumChoice == 2)
                    {
                        BigBangHologramDance bb0 = new BigBangHologramDance();
                        bb0.AlbumTitle();
                        Console.WriteLine("Please select from track 1 to 3");
                        var bbTune = Int32.Parse(Console.ReadLine());
                        BigBangHologramDance bb = new BigBangHologramDance(bbTune);
                        bb.AlbumTitle();

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Increase Tempo? If yes, press speed of tempo.If no, press 0.");
                                int TempoChoice = Int32.Parse(Console.ReadLine());
                                if (TempoChoice == 0)
                                {
                                    bb.PlayMusic();
                                    break;
                                }
                                
                                bb.Tempo(TempoChoice);
                                bb.PlayMusic();
                                break;

                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid option, try again");
                            }
                        }   
                    }
                    else
                    {
                        Console.WriteLine("Please choose music album again");
                    }
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid, try again");
            }
        }
    }
}
