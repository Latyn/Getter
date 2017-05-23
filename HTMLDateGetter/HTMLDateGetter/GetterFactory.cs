using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HTMLDateGetter.Getter;

namespace HTMLDateGetter
{
    public class GetterFactory
    {
        public AbsValueGetter GetGetter(string function)
        {
            switch (function)
            {
                case "Clean"://Value must be changed for something more specific after finishing
                    return new OpinionDocumentGetter();

                default:
                    Console.WriteLine("Incorrect Function Selected\n");
                    return null;

            }

        }
    }
}
