﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {

        // The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.

        // EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
        // rolls could be continous, and the totals and other statistics could be summarised for example.


        //line added for review

        public int diceTotal = 0;

        public Die diceOne = new Die();
        public Die diceTwo = new Die();
        public Die diceThree = new Die();

        //Methods


        public void DieCreation()
        {
            
            
            //CREATES DIE ONE, ROLLS AND DISPLAYS ROLL
            diceOne.diceValue = diceOne.Roll();
            Console.WriteLine("Dice 1: " + diceOne.diceValue);
            diceTotal = diceTotal + diceOne.diceValue;
            Console.WriteLine("Current Total: " + diceTotal);

            //CREATES DIE TWO, ROLLS AND DISPLAYS ROLL
            diceTwo.diceValue = diceTwo.Roll();
            Console.WriteLine("Dice 2: " + diceTwo.diceValue);
            diceTotal = diceTotal + diceTwo.diceValue;
            Console.WriteLine("Current Total: " + diceTotal);

            //CREATES DIE THREE, ROLLS AND DISPLAYS ROLL
            diceThree.diceValue = diceThree.Roll();
            Console.WriteLine("Dice 3: " + diceThree.diceValue);
            diceTotal = diceTotal + diceThree.diceValue;
            Console.WriteLine("Current Total: " + diceTotal);


        }
    }
}
