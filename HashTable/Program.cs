using System;
using System.Collections.Generic;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashTable = new HashTable();
           // var list = new string[3];
            hashTable.Add("a", "hola");
            hashTable.Add("bcfghfhfgh;klkjlijljlkjlkjlkjlkjkljlbcfghfhfgh;klkjlijljlkjlkjlkjlkjkljl", "adios");
            //hashTable.Add("c", "kevin");
            //hashTable.Add("d", "rivas");
            hashTable.Print();

            //Console.WriteLine(HashFunction("a", list));
            //Console.WriteLine(HashFunction("rivas", list));
            //Console.WriteLine(HashFunction("bcfghfhfgh", list));
            
        }

     
    }
}
