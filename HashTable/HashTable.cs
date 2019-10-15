using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public class HashTable
    {
        private LinkedList<string>[]   Table { get; set; }
        public int Length { get; set; }

        private List<string> Keys { get; set; }
        public HashTable()
        {
            Table = new LinkedList<string>[3];
            for (int i = 0; i < Table.Length; i++)
                Table[i] = new LinkedList<string>();
            Keys = new List<string>();
        }
        public void Add(string key, string value)
        {
            
            var index=HashFunction(key, Table);
            Table[index].AddLast(value);
            Length = Length + 1;
            Keys.Add(key);
        }

        public void Print()
        {
            var elementsWithValues= new List<int>();
            foreach (var key in Keys)
            {
                var index=HashFunction(key, Table);
                if (!elementsWithValues.Contains(index))
                    elementsWithValues.Add(index);

            }

            foreach (var index in elementsWithValues)
            {
                Console.Write("{0} :", index);
                foreach (var item in Table[index])
                    Console.Write("{0} ",item);

                Console.WriteLine();
            }
            
                
            
        }

        public void CopyHashMap()
        {

        }

        static int HashFunction(string s, LinkedList<string>[] array)
        {
            int total = 0;
            char[] c;
            c = s.ToCharArray();

            // Summing up all the ASCII values  
            // of each alphabet in the string 
            for (int k = 0; k <= c.GetUpperBound(0); k++)
                total += (int)c[k];

            return total % array.GetUpperBound(0);
        }
      
    }
}
