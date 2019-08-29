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

        public List<string> RemoveDuplicateNames()
        {
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var NewNamesOnly = names.Distinct().ToList();
            foreach (var name in NewNamesOnly)
            {
                Console.WriteLine(name);
                
                
            }
            Console.ReadLine();
            return NewNamesOnly;  

        }

       
        //each list must remove lowest grade, after that add all number and divide for average. do that for each line of list
        public void ClassAverage(List<string> classGrades)
            {
                List<double> gradeAvgs = new List<double>();
                List<int> gradeHolder = new List<int>();
                for (int i = 0; i < classGrades.Count; i++)
                {
                    var Student = classGrades[i];
                    string[] StudentScores = Student.Split(',');
                    foreach (string score in StudentScores)
                    {
                        gradeHolder.Add(int.Parse(score));
                    }
                    gradeHolder.Remove(gradeHolder.Min());
                    gradeAvgs.Add(gradeHolder.Average());
                    gradeHolder.RemoveRange(0, gradeHolder.Count);
                }
                Console.WriteLine(gradeAvgs.Average());
                Console.ReadLine();
        }
            public string LetterFrequancy(string userInput)
            {
                StringBuilder sb = new StringBuilder();
                var input = userInput.OrderBy(c => c);
                char[] stringArray = input.ToArray();
                int charCount = 0;
                for (int i = 0; i < stringArray.Length; i++)
                {
                    for (int j = 0; j < stringArray.Length; j++)
                    {
                        if (stringArray[i] == stringArray[j])
                        {
                            charCount++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    try
                    {
                        if (stringArray[i] == stringArray[i + 1])
                        {
                            charCount = 0;
                            continue;
                        }
                        else
                        {
                            sb.Append($"{stringArray[i]}{charCount}");
                            charCount = 0;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        stringArray[i] = stringArray[i];
                        sb.Append($"{stringArray[i]}{charCount}");
                    }
                }
                Console.WriteLine(sb);
                Console.ReadLine();
                return sb.ToString();
            }
    }



    

}
    





           
        
        

    

