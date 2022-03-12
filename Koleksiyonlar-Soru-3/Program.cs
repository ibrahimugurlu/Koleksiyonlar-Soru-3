using System;
using System.Collections;
using System.Collections.Generic;
namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Cümle Giriniz :.......");
            string sentence;
            sentence = Console.ReadLine();

            string []sequence = sentence.Split(" ");
            sentence = string.Join("", sequence);


            char[] vowel = { 'a', 'A', 'E', 'e', 'I', 'i', 'o', 'O', 'U', 'u', 'Ö', 'ö', 'Ü', 'ü', 'I' };
            List<string> VowelList = new List<string>();

            for (int i = 0; i < sentence.Length; i++)
            {
                for (int k = 0; k < vowel.Length; k++)
                {
                   if(sentence[i]==vowel[k])
                    
                        VowelList.Add(Convert.ToString(sentence[i]));
                    
                }
               
            }

            VowelList.Sort();
            foreach (var item in VowelList)
            {
                Console.Write(item+" ");
            }
           

            
            Console.ReadLine();
        }
    }
}
