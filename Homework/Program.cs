using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Homework1
{
    internal class Program
    {
        private const string Logo = @"
   .-'''-.   ___    _ .-------.     .-''-.  .-------.                                  .-------.   ___    _ .-------.     .-''-.  .-------.              .-_'''-.      ____    ,---.    ,---.    .-''-.   
  / _     \.'   |  | |\  _(`)_ \  .'_ _   \ |  _ _   \                                 \  _(`)_ \.'   |  | |\  _(`)_ \  .'_ _   \ |  _ _   \            '_( )_   \   .'  __ `. |    \  /    |  .'_ _   \  
 (`' )/`--'|   .'  | || (_ o._)| / ( ` )   '| ( ' )  |                                 | (_ o._)||   .'  | || (_ o._)| / ( ` )   '| ( ' )  |           |(_ o _)|  ' /   '  \  \|  ,  \/  ,  | / ( ` )   ' 
(_ o _).   .'  '_  | ||  (_,_) /. (_ o _)  ||(_ o _) /             _ _    _ _          |  (_,_) /.'  '_  | ||  (_,_) /. (_ o _)  ||(_ o _) /           . (_,_)/___| |___|  /  ||  |\_   /|  |. (_ o _)  | 
 (_,_). '. '   ( \.-.||   '-.-' |  (_,_)___|| (_,_).' __          ( ' )--( ' )         |   '-.-' '   ( \.-.||   '-.-' |  (_,_)___|| (_,_).' __         |  |  .-----.   _.-`   ||  _( )_/ |  ||  (_,_)___| 
.---.  \  :' (`. _` /||   |     '  \   .---.|  |\ \  |  |        (_{;}_)(_{;}_)        |   |     ' (`. _` /||   |     '  \   .---.|  |\ \  |  |        '  \  '-   .'.'   _    || (_ o _) |  |'  \   .---. 
\    `-'  || (_ (_) _)|   |      \  `-'    /|  | \ `'   /         (_,_)--(_,_)         |   |     | (_ (_) _)|   |      \  `-'    /|  | \ `'   /         \  `-'`   | |  _( )_  ||  (_,_)  |  | \  `-'    / 
 \       /  \ /  . \ //   )       \       / |  |  \    /                               /   )      \ /  . \ //   )       \       / |  |  \    /           \        / \ (_ o _) /|  |      |  |  \       /  
  `-...-'    ``-'`-'' `---'        `'-..-'  ''-'   `'-'                                `---'       ``-'`-'' `---'        `'-..-'  ''-'   `'-'             `'-...-'   '.(_,_).' '--'      '--'   `'-..-'   
             ";

        private const string Weapons = @"
                                                                                                                         %%%/%&&&& %%%          
                                                                                                                       %%%%%**%%%%%***
                      ((                                                 %%%&&&&&&&%%%                       &&&&&     #######(((((***
                   (((((                                  ###&&&&&%%&&&&&&&&     &&###                       &&%%%&&&&&#####//%%%##***
                (((((((((((                               &&&((&&&&&             ###                           &&&&&&&&%%((((((((**%%%
              ((((((((((   &&&                          &&   %%               %%%##&                              &&&&&%%(((##/////%%%
                   (((  &&&   ((                        ((                    ###                              &&&&&&&&##%%%%%(((%%&
                      &&   (((((((((((               &&&##                  %%#&&                            &&&&&%%###%%&&&&&&&&
                   &&&  (((((((((((                  %%%                    ###                           &&&&&%%%##%%%     &&&&&
                &&&        (((((                     &%%                 %%%&&&                         &&&&&%%(((%%&&&       &&&&&
              &&           (((                     &&%%%                 %##                         &&&&&%%%##%%%
           &&&                                     %%&              %%%%%%&&                       &&&&&%%(((&&&&&
        &&&                                        %%          ###########                         &&&&&(#%%%
      &&                                           %%     ######&&&&&                           &&&%%&&&&&&&&
   &&&                                             %%%#########                                 (((&&&
                                                      &&&&&                                     
";

        private const string Races = @"
   _       __  __                                               ___      ____    ___       ___         __      _____                          
 /' \     /\ \/\ \                                            /'___`\   /\  _`\ /\_ \    /'___\      /'__`\   /\  __`\                        
/\_, \    \ \ \_\ \  __  __    ___ ___      __      ___      /\_\ /\ \  \ \ \L\_\//\ \  /\ \__/     /\_\L\ \  \ \ \/\ \     __   _ __    __   
\/_/\ \    \ \  _  \/\ \/\ \ /' __` __`\  /'__`\  /' _ `\    \/_/// /__  \ \  _\L \ \ \ \ \ ,__\    \/_/_\_<_  \ \ \ \ \  /'_ `\/\`'__\/'__`\ 
   \ \ \  __\ \ \ \ \ \ \_\ \/\ \/\ \/\ \/\ \L\.\_/\ \/\ \      // /_\ \__\ \ \L\ \\_\ \_\ \ \_/      /\ \L\ \__\ \ \_\ \/\ \L\ \ \ \//\  __/ 
    \ \_\/\_\\ \_\ \_\ \____/\ \_\ \_\ \_\ \__/.\_\ \_\ \_\    /\______/\_\\ \____//\____\\ \_\       \ \____/\_\\ \_____\ \____ \ \_\\ \____\
     \/_/\/_/ \/_/\/_/\/___/  \/_/\/_/\/_/\/__/\/_/\/_/\/_/    \/_____/\/_/ \/___/ \/____/ \/_/        \/___/\/_/ \/_____/\/___L\ \/_/ \/____/
";

        private const string Genders = @"
  ,-.   .-..-.       .-.          .---.    .---.                    .-.        
.'  :   : `' :       : :          `--. :   : .--'                   : :        
 `: :   : .. : .--.  : :   .--.     ,','   : `;.--. ,-.,-.,-. .--.  : :   .--. 
  : : _ : :; :' .; ; : :_ ' '_.'  .'.'_  _ : :' '_.': ,. ,. :' .; ; : :_ ' '_.'
  :_;:_;:_;:_;`.__,_;`.__;`.__.'  :____;:_;:_;`.__.':_;:_;:_;`.__,_;`.__;`.__.'
";

        private static readonly Array ConsoleColorValues = Enum.GetValues(typeof(ConsoleColor));
        private static readonly Random Random = new Random();

        static void Main(string[] args)
        {
            ProgressBar();
            ClearConsole();
            PrintLogo();
            ClearConsole();
            Hero hero = CreateHero();
            Console.WriteLine(hero);
            Console.WriteLine(GetReplica(hero));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What do you think about your hero? Write bellow");
            Console.ReadLine();
        }

        private static string GetReplica(Hero hero)
        {
            int bitmask = 0;
            bitmask |= Convert.ToInt32(hero.Clazz);
            bitmask |= Convert.ToInt32(hero.Race) << 8;
            bitmask |= Convert.ToInt32(hero.Gender) << 16;

            switch (bitmask)
            {
                case 0b000000010000000100000001: return "You look very weak, brr male human";
                case 0b000000010000000100000010: return "You look weak, but you have great bow";
                case 0b000000010000000100000011: return "You look weak, but can we talk about magic?";
                case 0b000000010000001000000001: return "Hello";
                case 0b000000010000001000000010: return "Hi, Legolas!";
                case 0b000000010000001000000011: return "Hello, male-wizard";
                case 0b000000010000001100000001: return "You look very big, don't touch me";
                case 0b000000010000001100000010: return "Hi, big boy";
                case 0b000000010000001100000011: return "So big boy and have this little staff?";
                case 0b000000100000000100000001: return "You are a strong woman";
                case 0b000000100000000100000010: return "You are like a hawkeye";
                case 0b000000100000000100000011: return "Lux, is it you?";
                case 0b000000100000001000000001: return "Strong and smart!";
                case 0b000000100000001000000010: return "Beautiful woman!";
                case 0b000000100000001000000011: return "Be careful with magic";
                case 0b000000100000001100000001: return "You skin is so green";
                case 0b000000100000001100000010: return "How can you use this little bow?";
                case 0b000000100000001100000011: return "With great power comes great responsability";
                default: throw new Exception("Unhandled hero combination");
            }
        }

        private static Hero CreateHero()
        {
            Console.CursorVisible = true;
            Class clazz = SelectClass();
            ClearConsole();
            Race race = SelectRace();
            ClearConsole();
            Gender gender = SelectGender();
            ClearConsole();

            return new Hero(clazz, race, gender);
        }

        private static Gender SelectGender()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(Genders);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Choose your gender (1 - Male, 2 - Female): ");
                string chosenGender = Console.ReadLine();
                switch (chosenGender)
                {
                    case "1": return Gender.Male;
                    case "2": return Gender.Female;
                }
                ClearConsole();
            }
        }

        private static Race SelectRace()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(Races);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Choose your race (1 - Human, 2 - Elf, 3 - Ogre): ");
                string chosenRace = Console.ReadLine();
                switch (chosenRace)
                {
                    case "1": return Race.Human;
                    case "2": return Race.Elf;
                    case "3": return Race.Ogre;
                }
                ClearConsole();
            }
        }

        private static Class SelectClass()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(Weapons);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Choose your class (1 - Warrior, 2 - Archer, 3 - Wizard): ");
                string chosenClass = Console.ReadLine();
                switch (chosenClass)
                {
                    case "1": return Class.Warrior;
                    case "2": return Class.Archer;
                    case "3": return Class.Wizard;
                }
                ClearConsole();
            }
        }

        private static void ProgressBar()
        {
            Console.Title = "Super - puper game";
            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 1);

            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i + " / 100");
                for (int j = 0; j <= i; j++)
                {
                    string bar = "\u2551";
                    Console.Write(bar);
                }
                Console.SetCursorPosition(1, 1);
                if (i < 90)
                {
                    Thread.Sleep(50);
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
        }

        private static void ClearConsole()
        {
            Console.Clear();
        }

        private static void PrintLogo()
        {
            foreach (var c in Logo)
            {
                Console.ForegroundColor = FromChar(c);
                Console.Write(c);
            }
            Thread.Sleep(3000);
        }

        private static ConsoleColor FromChar(char c) => c switch
        {
            ' ' => ConsoleColor.Black,
            _ => GetRandomConsoleColor(),
        };

        private static ConsoleColor GetRandomConsoleColor()
        {
            return (ConsoleColor)ConsoleColorValues.GetValue(Random.Next(ConsoleColorValues.Length));
        }
    }

    public class Hero
    {
        public Class Clazz { get; }
        public Race Race { get; }
        public Gender Gender { get; }

        public Hero(Class clazz, Race race, Gender gender)
        {
            Clazz = clazz;
            Race = race;
            Gender = gender;
        }

        public override string ToString()
        {
            return $@"
                Hero {{
                    ""class"": {Clazz},
                    ""race"": {Race},
                    ""gender"": {Gender} 
                }}
                ";
        }
    }

    public enum Class
    {
        Warrior = 1,
        Archer,
        Wizard,
    }

    public enum Race
    {
        Human = 1,
        Elf,
        Ogre,
    }

    public enum Gender
    {
        Male = 1,
        Female,
    }
}