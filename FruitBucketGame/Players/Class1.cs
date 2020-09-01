using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players
{
    abstract class Player
    {

        public string Name { get; set; }

        public int niceTry;

        public abstract int Guess();
          
    }

    class UberPlayer : Player
    {
       

        public int counter = 40;
        
            public override int Guess()
        {
            niceTry = counter;
            counter++;
            return niceTry;
        }
    }

    class UberCheater : UberPlayer
    {
       

        public override int Guess()
        {

            return niceTry;
        }
    }

    class SimplePlayer : Player
    {
       
        public override int Guess()
        {
            Random randGuess = new Random();
            niceTry = randGuess.Next(40, 140);
            return niceTry;
        }
    }

    class NotePlayer : SimplePlayer
    {
       
        public override int Guess()
        {
            Random randGuess = new Random();
            niceTry = randGuess.Next(40, 140);
            return niceTry;
        }
    }

    class Cheater : SimplePlayer
    {
        public override int Guess()
        {
            Random randGuess = new Random();
            niceTry = randGuess.Next(40, 140);
            return niceTry;
        }


    }
}
