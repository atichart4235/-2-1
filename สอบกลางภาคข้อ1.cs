using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
enum Menu
{
    Playgame = 1,
    Exit = 2
}
namespace HangmanMDT
{
    class Program
    {
        static void Main(string[] args)
        {
            Menuscreen();
            InputMenu();
        }
        static void Menuscreen()
        {
            Console.WriteLine("Welcome to Hangman Game");
            Console.WriteLine("----------------------");
            Console.WriteLine("1.Playgame");
            Console.WriteLine("2.Exit");
            
            //หน้าแรก
        }
        static void InputMenu()
        {
            Console.Write("Select Menu:"); 
            Menu menu = (Menu)int.Parse(Console.ReadLine());

            PresentMenu(menu);

            //ตัวเลือกเมนู
        }
        static void PresentMenu(Menu menu)
        {
            if (menu == Menu.Playgame)
            {

            }
            else
            {
                Console.ReadLine();
            }

            Console.Clear();
            Random random = new Random((int)DateTime.Now.Ticks);
            
            //การสุ่ม

            string[] wordBank = { "Tennis", "Football", "Badminton" };

            string wordToGuess = wordBank[random.Next(0, wordBank.Length)];
            string wordToGuessUppercase = wordToGuess.ToUpper();

            StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length);
            for (int i = 0; i < wordToGuess.Length; i++)
                displayToPlayer.Append('_');

            List<char> correctGuesses = new List<char>();
            List<char> incorrectGuesses = new List<char>();

            int lives = 1;
            bool win = false;
            int lettersRevealed = 0;

            string input;
            char guess;

            while (!win && lives != 7)
            {
                Console.WriteLine("Play Game Hangman");
                Console.WriteLine("-----------------");
                Console.Write("Input letter alphabet:");
                
                //Console แสดงผลหน้าเล่นเกม

                input = Console.ReadLine().ToUpper();
                guess = input[0];

                if (correctGuesses.Contains(guess))
                {
                    Console.WriteLine("You've already tried '{0}', and it was correct!", guess);
                    continue;
                }
                else if (incorrectGuesses.Contains(guess))
                {
                    Console.WriteLine("You've already tried '{0}', and it was wrong!", guess);
                    continue;
                }

                if (wordToGuessUppercase.Contains(guess))
                {
                    correctGuesses.Add(guess);

                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuessUppercase[i] == guess)
                        {
                            displayToPlayer[i] = wordToGuess[i];
                            lettersRevealed++;
                        }
                    }

                    if (lettersRevealed == wordToGuess.Length)
                        win = true;
                }
                else
                {
                    incorrectGuesses.Add(guess);
                    Console.Clear(); //เคลียร์เมื่อตอบผิด
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Incorrect Score: {0}", lives);
                    Console.WriteLine("Nope, there's no '{0}' in it!", guess);
                    lives++;
                }
                Console.WriteLine(displayToPlayer.ToString());
            }
            if (win)
                Console.WriteLine("You win!");  //ถ้าตอบถูก
            else
           Console.WriteLine("Game Over IT was:'{0}'", wordToGuess); 
            //ถ้าตอบผิดเกิน6ครั้งจะเกมโอเวอร์และบอกคำตอบ

           Console.Write("Press ENTER to exit..."); //จบเกม
           Console.ReadLine();
        }
    }
}
