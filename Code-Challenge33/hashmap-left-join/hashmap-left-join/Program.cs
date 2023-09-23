using hashmap_left_join;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        HashTable synonyms = new HashTable();
        HashTable antonyms = new HashTable();

        synonyms.Insert("happy", "joyful");
        synonyms.Insert("sad", "unhappy");
        synonyms.Insert("angry", "furious");

        antonyms.Insert("happy", "sad");
        antonyms.Insert("sad", "happy");

        List<string> result = LeftJoin.Perform(synonyms, antonyms);

        foreach (string entry in result)
        {
            Console.WriteLine(entry);
        }
    }
}
