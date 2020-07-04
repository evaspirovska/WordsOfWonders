using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt
{
    public class Game
    {
        Words words;
        public HashSet<String> GuessWords { get; set; }

        public Game(int category)
        {
            words = new Words(category);
            GuessWords = new HashSet<string>();
        }

        public string show()
        {
            string[] temp = words.pick();
            for (int i = 1; i < temp.Length; i++)
                GuessWords.Add(temp[i]);
            return temp[0];
        }
        
        public bool guessW(string word)
        {
            if (GuessWords.Contains(word))
            {
                GuessWords.Remove(word);
                return true;
            }
            else
                return false;
        }
    }
}
