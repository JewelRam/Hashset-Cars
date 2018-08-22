
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> Showroom = new HashSet<string>();
        HashSet<string> UsedLot = new HashSet<string>();

        UsedLot.Add("Shitty Truck");
        UsedLot.Add("Crappy Honda");

        Showroom.Add("Toyota");
        Showroom.Add("Subaru");
        Showroom.Add("Honda");
        Showroom.Add("Other Car");
        Showroom.UnionWith(UsedLot);
        

        HashSet<string> JunkYard = new HashSet<string>();

        JunkYard.Add("Some Car Doors");
        JunkYard.Add("5 Mufflers");
        JunkYard.Add("Toyota");
        JunkYard.Add("Crappy Honda");
       Showroom.UnionWith(JunkYard);
Showroom.Remove("5 Mufflers");
        foreach (string i in Showroom)
        {
            Console.WriteLine(i);
        }

    }

}