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
            Panda ruski = new Panda("Ruski", "ruski@abv.bg", Gender.male);
            Console.WriteLine(ruski.ToString());
        }
    }
}
