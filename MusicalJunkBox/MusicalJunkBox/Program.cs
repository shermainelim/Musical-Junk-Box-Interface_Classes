using System;

namespace MusicalJunkBox
{
    class Program
    {
        static void _Main(string[] args)
        {
            //Musical JunkBox(superclass abstract class)
            // plays different music(child class albums) (Inheritance)
            //each child class is a album consisting of 3 music
            //(Question, when changinging music in the same method, 
            //is only inheritance concept right? 

            //2 albums of 3 music each =6 music max
            // one coin = 1 music (MainCoinStarter,Main method)
            // 2 coin= 2 music (coins are method to repeat and reuse code)_


            //in summary this program uses inheritance and interface and abstraction(so we dont create another musicaljunkbox class
            //but i dont know where is my polymorphism, i dont know how to create another function that is different. 
            //Help me identify which is the polymorphism if any here?
            //** Impt, i wanted to use the childclass to inherit the abstract superclasss MusicalJunkBox
            //** while also conforming to the interface of InterfaceMusic so i put both superclass and interface in the 
            //** childclass, possible?

            //push tempo as a variable of the album,/ attribute, write a method to control the track of the object, method to set the tempo in the object

            //prawning place
            //4 people,(1 man, 1 woman, 2 child) 200 prawns(50 tiger prawns, 100 longkan prawns, 50 king prawns)
            // people can catch prawns, prawn can fight people to not get catch
            //if person catch prawn, prawn is dead.
            //program terminates when all the prawns are caught/dead. 
            // 1 interface(fighting mechanism, generate random number, resting mechanism)

            //People = super class, healthpoints, name,
            //child class= man(100 hp,name), woman(80hp,name), child(50hp,name)
            //interface 1= method fighting();resting mechanism();
            //Prawn= super class, healthpoints,id
            //child class= tiger prawns, longkan prawns, king prawns
            //share the interface

            //Main Method 
            //create an array of people[4], an array of prawns[200]
            //while loop infinite to initiate fighting until all the prawns are caught. 


             // -- Album Class
                    // Attributes:
                        // Name --> Name of the Album
                        // List<Track> --> List of Track in this Album
                        // CurrentTrackID --> Current playing track

                    //Methods:
                        //PlayMusic(int) -->
        }
    }
}
