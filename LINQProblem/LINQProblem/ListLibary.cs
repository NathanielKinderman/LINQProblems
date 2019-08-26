using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblem
{
    public class ListLibary
    {

        public void FilterString()
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordwithTHinit = words.Where(w => w.Contains("th"));
            foreach (var THwords in wordwithTHinit)
            {
                Console.WriteLine(THwords);
            }
            Console.ReadLine();


        }
        
    }
    





           
        
        

    
}
