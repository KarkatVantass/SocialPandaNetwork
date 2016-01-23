using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialPandaLibrary;
namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            Panda ruski = new Panda("Ruski", "ivan@gmail.com", Gender.male);
            Panda ruski1 = new Panda("One", "ivan@gmail.com", Gender.male);
            Panda ruski2= new Panda("Two", "rusk2@abv.bg", Gender.male);
            Panda ruski3 = new Panda("Three", "rusk3@abv.bg", Gender.male);
            Panda ruski4 = new Panda("foure", "rusk4@abv.bg", Gender.male);
            Panda ruski5 = new Panda("Five", "rusk5@abv.bg", Gender.male);
            PandaSocialNetwork pncc = new PandaSocialNetwork();
            pncc.AddPanda(ruski);
            pncc.AddPanda(ruski1);
            pncc.AddPanda(ruski2);
            pncc.AddPanda(ruski3);
            pncc.AddPanda(ruski4);
            pncc.AddPanda(ruski5);
    
            pncc.MakeFriends(ruski, ruski2);
            pncc.MakeFriends(ruski2, ruski3);
            pncc.MakeFriends(ruski3, ruski4);
            pncc.MakeFriends(ruski4, ruski5);
            Console.WriteLine(pncc.ConnectionLevel(ruski1, ruski5));
            Console.WriteLine(pncc.AreConnected(ruski1,ruski5));
        }
    }
}
