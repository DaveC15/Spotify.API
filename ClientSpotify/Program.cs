using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Utility.Read;

namespace ClientSpotify
{
    class Program
    {
        static void Main()
        {

            UserInterface.SourceSelectionInterface();
            UserInterface.Router("h");
            Console.ReadLine();
        }



    }
}
