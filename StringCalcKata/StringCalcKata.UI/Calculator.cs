using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalcKata.UI
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            else
            {
                char []delims;
                if (!numbers.StartsWith("//")) 
                {
                    delims = new char[] { ',', '\n' };
                }
                else
                {
                    string[] parts = numbers.Split('\n');
                    numbers = parts[1];
                    delims = parts[0].Substring(2).ToCharArray();
                }
                    
                string[] indNumbers = numbers.Split(',');


                int result = 0;

                for (int i = 0; i < indNumbers.Length; i++)
                {
                    result = result + int.Parse(indNumbers[i]);
                }
                return result;
            }
            
        }
    }
}
