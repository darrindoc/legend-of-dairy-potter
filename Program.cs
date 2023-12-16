using System;

class Program
{
    static void Main()
    {
        Intro();
        int colindorfHealth = 100;
        int dairyHealth = 100;


        while (dairyHealth >= 1)
        {
        Console.WriteLine("------------------");
        Console.WriteLine("COLINDORF has " + colindorfHealth + " life remaining.");
        Console.WriteLine("DAIRY has " + dairyHealth + " life remaining.");
        int colindorfDefense = 10;
        int dairyDefense = 10;

        //create random numbers used in every round of combat
        Random random = new Random();
        int dairySwordAttack = random.Next(8, 14);
        int dairySwordDamage = random.Next(10, 20);
        int dairyBowAttack = random.Next(5, 14);
        int dairyBowDamage = random.Next(20, 40);
        int colindorfSwordAttack = random.Next(8, 12);
        int colindorfSwordDamage = random.Next(12, 20);
        int colindorfMagicAttack = random.Next(7, 12);
        int colindorfMagicDamage = random.Next(25, 35);
        int colindorfAction = random.Next(1, 5);


        if (colindorfHealth >= 1){
            //Dairy's action
            Console.WriteLine("Choose your action! Sword (S) or Light Arrow (L):");
            string playerChoice = Console.ReadLine();
            if (playerChoice == "S" )
            {
                if (dairySwordAttack > colindorfDefense)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("You slash Colindorf for " + dairySwordDamage + " damage.");
                    colindorfHealth -= dairySwordDamage;
                }
                else{
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("You missed Colindorf with your sword!");
                }
            }
            else if (playerChoice == "L")
            {
                if (dairyBowAttack > colindorfDefense)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Your arrow strikes Colindorf for " + dairyBowDamage + " damage.");
                    colindorfHealth -= dairyBowDamage;
                }
                else{
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("You missed Colindorf with your bow!");
                }
            }
            else
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("You must select (S) or (L)!");
            }
        //Colindorf's action
        if (colindorfAction <= 3) //Colindorf uses his sword
            {
                if (colindorfSwordAttack > dairyDefense)
                {
                    Console.WriteLine("---------");
                    Console.WriteLine("Colindorf slashed you for " + colindorfSwordDamage + " damage.");
                    dairyHealth -= colindorfSwordDamage;
                }
                else{
                    Console.WriteLine("--------");
                    Console.WriteLine("Colindorf swings his sword and misses!");
                }
            }
        else if (colindorfAction >= 4) //Colindorf used magic
            {
                if (colindorfMagicAttack > dairyDefense)
                {
                    Console.WriteLine("-------");
                    Console.WriteLine("Colindorf blasts you with magic for " + colindorfMagicDamage + " damage.");
                    dairyHealth -= colindorfMagicDamage;
                }
                else{
                    Console.WriteLine("-------");
                    Console.WriteLine("Colindorf's magic blast misses you!");
                }
            }

        }
        else {
            break;
        }

        }
        if (dairyHealth >= 1)
        {
            Victory();
        }
        else
        {
            GameOver();
        }

    }
    static void Intro()
    {
        Console.WriteLine("You are the brave hero DAIRY POTTER.");
        Console.WriteLine("You have fought through a dozen levels of the castle of the evil lord....");
        Console.WriteLine("COLINDORF!");
        Console.WriteLine();
        Console.WriteLine("You stand outside COLINDORF'S throne room.");
        Console.WriteLine("Prepare yourself for the final battle...");
        Console.WriteLine("The land of NEWFORCIA depends on you!");
    }

    static void GameOver()
    {
        Console.WriteLine("The evil lord COLINDORF laughs at your attempt...");
        Console.WriteLine("He mocks you because he is VICIOUS and EVIL...");
        Console.WriteLine("With ZERO CHILL, he charges forward.");
        Console.WriteLine();
        Console.WriteLine("COLINDORF's sword flashes down on your skull.");
        Console.WriteLine("You are DEAD. NEWFORCIA is doomed.");
        Console.WriteLine("💀💀💀");
    }
    static void Victory()
    {
        Console.WriteLine("COLINDORF gasps! You have the upper hand!");
        Console.WriteLine("With a final slash, you cut COLINDORF'S head clean off!");
        Console.WriteLine("Victory!");
        Console.WriteLine();
        Console.WriteLine("NEWFORCIA is saved.");
        Console.WriteLine("YOU are the GREATEST HERO EVER.");
        Console.WriteLine("The end :)");
    }

    

}

