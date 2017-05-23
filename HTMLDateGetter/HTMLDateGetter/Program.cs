using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTMLDateGetter.Getter;

namespace HTMLDateGetter
{
    class Program
    {
        static void Main(string[] args)
        {
            AbsValueGetter valueGetter = null;
            do
            {
                Console.Write("Type a state name: ");
                GetterFactory factory = new GetterFactory();
                valueGetter = factory.GetGetter(Console.ReadLine());
                if (valueGetter != null)
                {
                    Console.WriteLine("Starting process, please wait..");
                    valueGetter.workWithElements();
                }
            } while (valueGetter == null);
        }
    }
}
