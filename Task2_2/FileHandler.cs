using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Task2_2
{
    public class FileHandler
    {
        public void ProcessFile(string fileName, char ch, bool begin)
        {
            try
            {
                StreamReader sr = new StreamReader(fileName);

                StreamWriter sw = File.CreateText("../../../output.txt");

                string line = sr.ReadLine();
                while (line != null)
                {
                    line = Regex.Replace(line, @"\s+", " ");
                    foreach (var curr in line.Split(" "))
                    {
                        if (IsWordContainRequiredChar(curr, ch, begin))
                        {
                            sw.Write(curr + " ");
                        }   
                    }

                    line = sr.ReadLine();
                }


                sr.Close();
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public bool IsWordContainRequiredChar(string word, char ch, bool begin)
        {
            char[] chars = word.ToCharArray();

            if (begin)
            {
                if (Char.IsLetter(chars[0]))
                {
                    return char.ToUpperInvariant(chars[0]) == char.ToUpperInvariant(ch);
                }
                else
                {
                    return char.ToUpperInvariant(chars[1]) == char.ToUpperInvariant(ch);
                }
            }
            else
            {
                if (Char.IsLetter(chars[^1]))
                {
                    return char.ToUpperInvariant(chars[^1]) == char.ToUpperInvariant(ch);
                }
                else
                {
                    return char.ToUpperInvariant(chars[^2]) == char.ToUpperInvariant(ch);
                }
                
            }

            return false;
        }
    }
}