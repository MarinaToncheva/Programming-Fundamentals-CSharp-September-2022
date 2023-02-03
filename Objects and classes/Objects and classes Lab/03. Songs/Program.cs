namespace _03._Songs
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//3

            List <Song> songs = new List<Song>();
            //{Song("", name, 1), Song("", name, 1), Song("", name, 1)}

            for (int i = 0; i < n; i++)
            {
                string[] currentInput = Console.ReadLine()
                    .Split('_');
                string typeList = currentInput[0];
                string name = currentInput[1];
                string time= currentInput[2];

                Song song = new Song(typeList, name, time);
                songs.Add(song);
            }

            string list = Console.ReadLine();

            for (int i = 0; i < songs.Count; i++)
            {
                Song currentSong = songs[i];

                if (list=="all")
                {
                    Console.WriteLine(currentSong.Name);
                }
                else if (list==currentSong.TypeList)
                {
                    Console.WriteLine(currentSong.Name);
                }
            }  
        }
    }
    public class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
}
