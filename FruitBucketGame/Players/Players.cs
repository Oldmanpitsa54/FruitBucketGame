using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    public abstract class Player
    {

        public string Name { get; set; }

        public int niceTry;

        public Player(string name)
        {
            Name = name;
        }

        public List<int> bossShot = new List<int>();

        public abstract void Guess(int rightAnswer);



        public virtual void GuessResult(int niceTry, int rightAnswer)
        {
            if (niceTry == rightAnswer)
            {
                Console.WriteLine($"Congratulations to {Name}! He has made the right answer. ");
                return;
            }
            else
            {
                bossShot.Add(niceTry);
            }
        }
    }

    public class UberPlayer : Player
    {
        public int counter = 40;

        public UberPlayer(string name)
           : base(name)
        { }

        public override void Guess(int rightAnswer)
        {
            niceTry = counter;
            GuessResult(niceTry, rightAnswer);
            counter++;
        }

    }

    public class UberCheater : UberPlayer
    {
        public UberCheater(string name)
     : base(name)
        { }

        public override void Guess(int rightAnswer)
        {


            GuessCheck(niceTry, bossShot, rightAnswer);

        }

        private void GuessCheck(int attempt, List<int> list, int rightAnswer)
        {
            foreach (int value in list)
            {
                if (attempt == value)
                {
                    attempt++;
                    GuessCheck(attempt, list, rightAnswer);
                }
                else
                {
                    GuessResult(niceTry, rightAnswer);
                }
            }
        }

    }

    public class SimplePlayer : Player
    {
        public SimplePlayer(string name)
     : base(name)
        { }

        public override void Guess(int rightAnswer)
        {
            Random randGuess = new Random();
            niceTry = randGuess.Next(40, 140);
            GuessResult(niceTry, rightAnswer);

        }
    }



    public class NotePlayer : SimplePlayer
    {
        public NotePlayer(string name)
     : base(name)
        { }
        public List<int> failNote = new List<int>();

        public override void Guess(int rightAnswer)
        {

            Random randGuess = new Random();
            niceTry = randGuess.Next(40, 140);
            GuessNoteCheck(niceTry, failNote, rightAnswer);

        }

        private void GuessNoteCheck(int attempt, List<int> list, int rightAnswer)
        {

            foreach (int value in list)
            {

                if (attempt == value)
                {
                    attempt = new Random().Next(40, 140);
                    GuessNoteCheck(attempt, list, rightAnswer);
                }
                else
                {
                    GuessResult(niceTry, rightAnswer);
                }
            }
        }

        public override void GuessResult(int niceTry, int rightAnswer)
        {

            if (niceTry == rightAnswer)
            {
                Console.WriteLine($"Congratulations to {Name}! He has made the right answer. ");
                return;
            }
            else
            {
                bossShot.Add(niceTry);
                failNote.Add(niceTry);
            }
        }

    }



    public class Cheater : SimplePlayer
    {
        public Cheater(string name)
    : base(name)
        { }

        public override void Guess(int rightAnswer)
        {
            Random randGuess = new Random();
            niceTry = randGuess.Next(40, 140);

            GuessCheck(niceTry, bossShot, rightAnswer);
            return;
        }

       private void GuessCheck(int attempt, List<int> list, int rightAnswer)
        {
            foreach (int value in list)
            {
                if (attempt == value)
                {
                    attempt = new Random().Next(40, 140);
                    GuessCheck(attempt, list, rightAnswer);
                }else
                {
                    GuessResult(niceTry, rightAnswer);
                }
            }
        }
    }


}
