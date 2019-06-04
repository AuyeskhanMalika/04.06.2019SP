using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04._06._2019SP
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread MusicThread = new Thread(Music);
            MusicThread.IsBackground = true;
            Text();
            MusicThread.Start();
        }
        
        static void Music()
        {
            SoundPlayer musicPlayer = new SoundPlayer(@"C:\Users\АуесханМ\source\repos\04.06.2019SP\04.06.2019SP\grandson-blood-water.wav");
            musicPlayer.Play();
        }

        static void Text()
        {
            string write = @"C:\Users\АуесханМ\source\repos\04.06.2019SP\04.06.2019SP\grandson-blood-water.txt";
            string text = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(write, false, System.Text.Encoding.Default))
            {
                writer.WriteLine(text);
            }
        }
    }
}
