﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class GameManager
    {
        public string playerName = "";
        public string shipName = "";
        public string playerInput = "";
        public string weaponUsed = "";

        public int rollDelay = 3000;

        public void GameLoop()
        {
            Setup();
            Combat();
            End();
        }

        public void Setup()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("|SLOWER THAN LIGHT|");
            Console.WriteLine("-------------------");
            Console.WriteLine("");
            Console.WriteLine("What is your name?");

            playerName = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("And what is the name of your ship, " + playerName + "?");

            shipName = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Welcome " + playerName + ", captain of the " + shipName + ".");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");

            Console.ReadLine();
            Console.Clear();
        }

        public void Combat()
        {
            Console.WriteLine("While out on a scouting mission, " + playerName + " recieves a transmission from nearby ship.");
            Console.WriteLine("");
            Console.WriteLine("'Attention captain of the " + shipName + "! Prepared to be fired upon because I think you suck.'");
            Console.WriteLine("");
            Console.WriteLine("What weapon will you choose to fire?");
            Console.WriteLine("");
            Console.WriteLine("D6 - Laser // D10 - Missle // D12 - Torpedo // D20 - Nuke");

            playerInput = Console.ReadLine().ToLower();

            if (playerInput == "d6" || playerInput == "6" || playerInput == "laser")
            {
                weaponUsed = "laser";
                DieRoller pScore = new DieRoller();
                DieRoller cScore = new DieRoller();

                pScore.Roll(6);
                Task.Delay(rollDelay);
                cScore.Roll(6);

                Console.WriteLine("");
                Console.WriteLine("You fire your ships" + weaponUsed + " for " + pScore + "damage");
                Console.WriteLine("The enemy ship also fires its" + weaponUsed + " at you for " + cScore + "damage");
                Console.WriteLine("");

            } else if (playerInput == "d10" || playerInput == "10" || playerInput == "missle")
            {
                weaponUsed = "missle";
                DieRoller pScore = new DieRoller();
                DieRoller cScore = new DieRoller();

                pScore.Roll(10);
                Task.Delay(rollDelay);
                cScore.Roll(10);

                Console.WriteLine("");
                Console.WriteLine("You fire your ships" + weaponUsed + " for " + pScore + "damage");
                Console.WriteLine("The enemy ship also fires its" + weaponUsed + " at you for " + cScore + "damage");
                Console.WriteLine("");

            } else if (playerInput == "d12" || playerInput == "12" || playerInput == "torpedo")
            {
                weaponUsed = "torpedo";
                DieRoller pScore = new DieRoller();
                DieRoller cScore = new DieRoller();

                pScore.Roll(12);
                Task.Delay(rollDelay);
                cScore.Roll(12);

                Console.WriteLine("");
                Console.WriteLine("You fire your ships" + weaponUsed + " for " + pScore + "damage");
                Console.WriteLine("The enemy ship also fires its" + weaponUsed + " at you for " + cScore + "damage");
                Console.WriteLine("");

            } else if (playerInput == "d20" || playerInput == "20" || playerInput == "nuke")
            {
                weaponUsed = "nuke";
                DieRoller pScore = new DieRoller();
                DieRoller cScore = new DieRoller();

                pScore.Roll(20);
                Task.Delay(rollDelay);
                cScore.Roll(20);

                Console.WriteLine("");
                Console.WriteLine("You fire your ships" + weaponUsed + " for " + pScore + "damage");
                Console.WriteLine("The enemy ship also fires its" + weaponUsed + " at you for " + cScore + "damage");
                Console.WriteLine("");

            } else
            {
                DieRoller pScore = new DieRoller();
                DieRoller cScore = new DieRoller();

                pScore.Roll(0);
                Task.Delay(rollDelay);
                cScore.Roll(20);

                Console.WriteLine("");
                Console.WriteLine("The " + shipName + "s computer informs you your weapons systems have locked up.");
                Console.WriteLine("Unfortunately, your opponents systems seem to work just fine");
            }


        }

        public void End()
        {

            if (pScore > cScore)
            {
                Console.WriteLine("You dodge the attack, but your opponent isn't so lucky as they're blasted into space dust.");
                Console.WriteLine("");
                Console.WriteLine("You win!");

            } else if (pScore < cScore)
            {
                Console.WriteLine("Your enemy dodges you attack, but you aren't so fast as you're blasted into space dust.");
                Console.WriteLine("");
                Console.WriteLine("You lose!");

            } else
            {
                Console.WriteLine("Both " + weaponUsed + "s collide mid air, cancelling each other out.");
                Console.WriteLine("This is awkward for the both of you.");
                Console.WriteLine("");
                Console.WriteLine("It's a tie!");
            }

            Console.ReadLine();
        }
        
    }
}
