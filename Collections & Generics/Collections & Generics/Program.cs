//using System;

//namespace Collections_and_Generics
//{
//    class Program
//    {
//        static void Main()
//        {
//            List<String> Fruits = new List<string>();
//            Fruits.Add("Apple");
//            Fruits.Add("Banana");
//            Fruits.Add("Orange");

//            Fruits.Insert(1, "Mango");
//            Fruits.Remove("Banana");



//            foreach (var fruit in Fruits)
//            {
//                Console.WriteLine(fruit);
//            }
//            Console.WriteLine(" 1st Fruit : " + Fruits[0]);
//            Console.WriteLine("Total fruits: " + Fruits.Count);


//        }
//    }
//}

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Dictionary<string, string> Students = new Dictionary<string, string>();

//        Console.WriteLine("How Many Contacts you want to add?");
//        int count = Convert.ToInt32(Console.ReadLine());

//        for (int i = 0; i < count; i++)
//        {
//            Console.Write("Enter Contact Number: ");
//            string phone = Console.ReadLine();

//            Console.Write("Enter Contact Name: ");
//            string name = Console.ReadLine();

//            Students[phone] = name; 
//        }

//        Console.WriteLine("\n========== Phone Book ==========");
//        foreach (var student in Students)
//        {
//            Console.WriteLine("PhoneNumber: " + student.Key + ", Name: " + student.Value);
//        }

//        Console.Write("\nEnter Phone Number to search: ");
//        string searchPhone = Console.ReadLine();

//        if (Students.ContainsKey(searchPhone))
//        {
//            Console.WriteLine($"Phone Number Found: {searchPhone}, Name: {Students[searchPhone]}");
//        }
//        else
//        {
//            Console.WriteLine("Phone Number Not Found");
//        }
//    }
//}



using System;
using System.Collections.Generic;

public class PlaylistManager
{
    
    private HashSet<string> uniqueSongs = new HashSet<string>();

    
    private Queue<string> playQueue = new Queue<string>();

   
    private Stack<string> history = new Stack<string>();

    
    public void AddSong(string song)
    {
        if (uniqueSongs.Add(song)) 
        {
            playQueue.Enqueue(song); 
            Console.WriteLine($"{song} added to playlist.");
        }
        else
        {
            Console.WriteLine($"{song} already exists in playlist.");
        }
    }

    
    public void PlayNext()
    {
        if (playQueue.Count > 0)
        {
            string song = playQueue.Dequeue(); 
            history.Push(song); 
            Console.WriteLine($"🎵 Now playing: {song}");
        }
        else
        {
            Console.WriteLine("⚠️ No songs left in queue.");
        }
    }

   
    public void PreviousSong()
    {
        if (history.Count > 1) 
        {
            history.Pop(); 
            Console.WriteLine($"⏪ Back to: {history.Peek()}"); 
        }
        else
        {
            Console.WriteLine("⚠️ No previous song.");
        }
    }
}

class Program
{
    static void Main()
    {
        PlaylistManager manager = new PlaylistManager();

        
        manager.AddSong("Song A");
        manager.AddSong("Song B");
        manager.AddSong("Song A");

        
        manager.PlayNext();
        manager.PlayNext(); 
        manager.PreviousSong(); 
    }
}
