using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Text;

namespace sentence
{
    public class Doo
    {
         
        public static void Main()
        {
            string input=Console.ReadLine();
            //Если вы просмотрите префиксы каждого суффикса строки, вы охватите все подстроки этой строки.
            Console.WriteLine(lrslength(input));
        }

       public static int lrslength(string arg)
       {
            List<string> list= new List<string>();
            var c =new StringBuilder(arg);
            while (c.Length > 0) 
            {
                list.Add(c.ToString());
                c.Remove(0, 1);
            }
            list.Sort();
            int ans = list[0].Length;
            for(int j=0;j<list.Count-1;j++)
            {
                var neww = list[j+1].Length;
                int curr = 0;
                while(curr<Math.Min(list[j].Length, list[j + 1].Length))
                {
                    if (list[j][curr] != list[j + 1][curr]) break;
                    curr++;
                }
                ans+=neww-curr;
            }
            return ans;
        }
    }
}
