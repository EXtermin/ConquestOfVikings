using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QonquestOfVikings
{
    class Intro
    {
        Sound snd = new Sound();

        public void loadIntro()
        {
            Console.Clear();
            snd.DeadChicken();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(3500);
            Console.Clear();
            Console.WriteLine("\n \n");
            Console.WriteLine(@"  _____                         _    ");
            Thread.Sleep(100);
            Console.WriteLine(@" |  __ \                       | |    ");
            Thread.Sleep(100);
            Console.WriteLine(@" | |__) _ __ ___ ___  ___ _ __ | |_ ___ ");
            Thread.Sleep(100);
            Console.WriteLine(@" |  ___| '__/ _ / __|/ _ | '_ \| __/ __| ");
            Thread.Sleep(100);
            Console.WriteLine(@" | |   | | |  __\__ |  __| | | | |_\__ \ ");
            Thread.Sleep(100);
            Console.WriteLine(@" |_|   |_|  \___|___/\___|_| |_|\__|___/ ");
            Thread.Sleep(3500);
            Console.Clear();
            //SwitchIntro();
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("         ▄████▄   ▒█████   ███▄    █   █████   █    ██ ▓█████   ██████ ▄▄▄█████▓    ▒█████    █████▒    ██▒   █▓ ██▓ ██ ▄█▀ ██▓ ███▄    █   ▄████   ██████  ");
            Thread.Sleep(250);
            Console.WriteLine("        ▒██▀ ▀█  ▒██▒  ██▒ ██ ▀█   █ ▒██▓  ██▒ ██  ▓██▒▓█   ▀ ▒██    ▒ ▓  ██▒ ▓▒   ▒██▒  ██▒▓██   ▒    ▓██░   █▒▓██▒ ██▄█▒ ▓██▒ ██ ▀█   █  ██▒ ▀█▒▒██    ▒  ");
            Thread.Sleep(250);
            Console.WriteLine("        ▒▓█    ▄ ▒██░  ██▒▓██  ▀█ ██▒▒██▒  ██░▓██  ▒██░▒███   ░ ▓██▄   ▒ ▓██░ ▒░   ▒██░  ██▒▒████ ░     ▓██  █▒░▒██▒▓███▄░ ▒██▒▓██  ▀█ ██▒▒██░▄▄▄░░ ▓██▄    ");
            Thread.Sleep(250);
            Console.WriteLine("        ▒▓▓▄ ▄██▒▒██   ██░▓██▒  ▐▌██▒░██  █▀ ░▓▓█  ░██░▒▓█  ▄   ▒   ██▒░ ▓██▓ ░    ▒██   ██░░▓█▒  ░      ▒██ █░░░██░▓██ █▄ ░██░▓██▒  ▐▌██▒░▓█  ██▓  ▒   ██▒ ");
            Thread.Sleep(250);
            Console.WriteLine("        ▒ ▓███▀ ░░ ████▓▒░▒██░   ▓██░░▒███▒█▄ ▒▒█████▓ ░▒████▒▒██████▒▒  ▒██▒ ░    ░ ████▓▒░░▒█░          ▒▀█░  ░██░▒██▒ █▄░██░▒██░   ▓██░░▒▓███▀▒▒██████▒▒ ");
            Thread.Sleep(250);
            Console.WriteLine("        ░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░   ▒ ▒ ░░ ▒▒░ ▒ ░▒▓▒ ▒ ▒ ░░ ▒░ ░▒ ▒▓▒ ▒ ░  ▒ ░░      ░ ▒░▒░▒░  ▒ ░          ░ ▐░  ░▓  ▒ ▒▒ ▓▒░▓  ░ ▒░   ▒ ▒  ░▒   ▒ ▒ ▒▓▒ ▒ ░ ");
            Thread.Sleep(250);
            Console.WriteLine("        ░  ▒     ░ ▒ ▒░ ░ ░░   ░ ▒░ ░ ▒░  ░ ░░▒░ ░ ░  ░ ░  ░░ ░▒  ░ ░    ░         ░ ▒ ▒░  ░            ░ ░░   ▒ ░░ ░▒ ▒░ ▒ ░░ ░░   ░ ▒░  ░   ░ ░ ░▒  ░ ░   ");
            Thread.Sleep(250);
            Console.WriteLine("        ░        ░ ░ ░ ▒     ░   ░ ░    ░   ░  ░░░ ░ ░    ░   ░  ░  ░    ░         ░ ░ ░ ▒   ░ ░            ░░   ▒ ░░ ░░ ░  ▒ ░   ░   ░ ░ ░ ░   ░ ░  ░  ░   ");
            Thread.Sleep(250);
            Console.WriteLine("        ░ ░          ░ ░           ░     ░       ░        ░  ░      ░                  ░ ░                   ░   ░  ░  ░    ░           ░       ░       ░   ");
            Thread.Sleep(250);
            Console.WriteLine("        ░                                                                                                   ░                                               ");
            Console.WriteLine("\n \n");
            Thread.Sleep(3000);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;



        }
        public void SwitchIntro()
        {
            int counter = 0;
            do
            {
                Console.Clear();
                Console.ResetColor();
                counter++;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("         ▄████▄   ▒█████   ███▄    █   █████   █    ██ ▓█████   ██████ ▄▄▄█████▓    ▒█████    █████▒    ██▒   █▓ ██▓ ██ ▄█▀ ██▓ ███▄    █   ▄████   ██████  ");
                Console.WriteLine("        ▒██▀ ▀█  ▒██▒  ██▒ ██ ▀█   █ ▒██▓  ██▒ ██  ▓██▒▓█   ▀ ▒██    ▒ ▓  ██▒ ▓▒   ▒██▒  ██▒▓██   ▒    ▓██░   █▒▓██▒ ██▄█▒ ▓██▒ ██ ▀█   █  ██▒ ▀█▒▒██    ▒  ");
                Console.WriteLine("        ▒▓█    ▄ ▒██░  ██▒▓██  ▀█ ██▒▒██▒  ██░▓██  ▒██░▒███   ░ ▓██▄   ▒ ▓██░ ▒░   ▒██░  ██▒▒████ ░     ▓██  █▒░▒██▒▓███▄░ ▒██▒▓██  ▀█ ██▒▒██░▄▄▄░░ ▓██▄    ");
                Console.WriteLine("        ▒▓▓▄ ▄██▒▒██   ██░▓██▒  ▐▌██▒░██  █▀ ░▓▓█  ░██░▒▓█  ▄   ▒   ██▒░ ▓██▓ ░    ▒██   ██░░▓█▒  ░      ▒██ █░░░██░▓██ █▄ ░██░▓██▒  ▐▌██▒░▓█  ██▓  ▒   ██▒ ");
                Console.WriteLine("        ▒ ▓███▀ ░░ ████▓▒░▒██░   ▓██░░▒███▒█▄ ▒▒█████▓ ░▒████▒▒██████▒▒  ▒██▒ ░    ░ ████▓▒░░▒█░          ▒▀█░  ░██░▒██▒ █▄░██░▒██░   ▓██░░▒▓███▀▒▒██████▒▒ ");
                Console.WriteLine("        ░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░   ▒ ▒ ░░ ▒▒░ ▒ ░▒▓▒ ▒ ▒ ░░ ▒░ ░▒ ▒▓▒ ▒ ░  ▒ ░░      ░ ▒░▒░▒░  ▒ ░          ░ ▐░  ░▓  ▒ ▒▒ ▓▒░▓  ░ ▒░   ▒ ▒  ░▒   ▒ ▒ ▒▓▒ ▒ ░ ");
                Console.WriteLine("        ░  ▒     ░ ▒ ▒░ ░ ░░   ░ ▒░ ░ ▒░  ░ ░░▒░ ░ ░  ░ ░  ░░ ░▒  ░ ░    ░         ░ ▒ ▒░  ░            ░ ░░   ▒ ░░ ░▒ ▒░ ▒ ░░ ░░   ░ ▒░  ░   ░ ░ ░▒  ░ ░   ");
                Console.WriteLine("        ░        ░ ░ ░ ▒     ░   ░ ░    ░   ░  ░░░ ░ ░    ░   ░  ░  ░    ░         ░ ░ ░ ▒   ░ ░            ░░   ▒ ░░ ░░ ░  ▒ ░   ░   ░ ░ ░ ░   ░ ░  ░  ░   ");
                Console.WriteLine("        ░ ░          ░ ░           ░     ░       ░        ░  ░      ░                  ░ ░                   ░   ░  ░  ░    ░           ░       ░       ░   ");
                Console.WriteLine("        ░                                                                                                   ░                                               ");
                Console.WriteLine("\n \n");
                Thread.Sleep(250);
                Console.Clear();
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("         ▄████▄   ▒█████   ███▄    █   █████   █    ██ ▓█████   ██████ ▄▄▄█████▓    ▒█████    █████▒    ██▒   █▓ ██▓ ██ ▄█▀ ██▓ ███▄    █   ▄████   ██████  ");
                Console.WriteLine("        ▒██▀ ▀█  ▒██▒  ██▒ ██ ▀█   █ ▒██▓  ██▒ ██  ▓██▒▓█   ▀ ▒██    ▒ ▓  ██▒ ▓▒   ▒██▒  ██▒▓██   ▒    ▓██░   █▒▓██▒ ██▄█▒ ▓██▒ ██ ▀█   █  ██▒ ▀█▒▒██    ▒  ");
                Console.WriteLine("        ▒▓█    ▄ ▒██░  ██▒▓██  ▀█ ██▒▒██▒  ██░▓██  ▒██░▒███   ░ ▓██▄   ▒ ▓██░ ▒░   ▒██░  ██▒▒████ ░     ▓██  █▒░▒██▒▓███▄░ ▒██▒▓██  ▀█ ██▒▒██░▄▄▄░░ ▓██▄    ");
                Console.WriteLine("        ▒▓▓▄ ▄██▒▒██   ██░▓██▒  ▐▌██▒░██  █▀ ░▓▓█  ░██░▒▓█  ▄   ▒   ██▒░ ▓██▓ ░    ▒██   ██░░▓█▒  ░      ▒██ █░░░██░▓██ █▄ ░██░▓██▒  ▐▌██▒░▓█  ██▓  ▒   ██▒ ");
                Console.WriteLine("        ▒ ▓███▀ ░░ ████▓▒░▒██░   ▓██░░▒███▒█▄ ▒▒█████▓ ░▒████▒▒██████▒▒  ▒██▒ ░    ░ ████▓▒░░▒█░          ▒▀█░  ░██░▒██▒ █▄░██░▒██░   ▓██░░▒▓███▀▒▒██████▒▒ ");
                Console.WriteLine("        ░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒░   ▒ ▒ ░░ ▒▒░ ▒ ░▒▓▒ ▒ ▒ ░░ ▒░ ░▒ ▒▓▒ ▒ ░  ▒ ░░      ░ ▒░▒░▒░  ▒ ░          ░ ▐░  ░▓  ▒ ▒▒ ▓▒░▓  ░ ▒░   ▒ ▒  ░▒   ▒ ▒ ▒▓▒ ▒ ░ ");
                Console.WriteLine("        ░  ▒     ░ ▒ ▒░ ░ ░░   ░ ▒░ ░ ▒░  ░ ░░▒░ ░ ░  ░ ░  ░░ ░▒  ░ ░    ░         ░ ▒ ▒░  ░            ░ ░░   ▒ ░░ ░▒ ▒░ ▒ ░░ ░░   ░ ▒░  ░   ░ ░ ░▒  ░ ░   ");
                Console.WriteLine("        ░        ░ ░ ░ ▒     ░   ░ ░    ░   ░  ░░░ ░ ░    ░   ░  ░  ░    ░         ░ ░ ░ ▒   ░ ░            ░░   ▒ ░░ ░░ ░  ▒ ░   ░   ░ ░ ░ ░   ░ ░  ░  ░   ");
                Console.WriteLine("        ░ ░          ░ ░           ░     ░       ░        ░  ░      ░                  ░ ░                   ░   ░  ░  ░    ░           ░       ░       ░   ");
                Console.WriteLine("        ░                                                                                                   ░                                               ");
                Console.WriteLine("\n \n");
                Thread.Sleep(250);

            } while (counter != 5);
            Console.Clear();
            Console.ResetColor();
        }
        public void Exit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(@"            ▄▄▄█████▓ ██░ ██ ▓█████    ▓█████ ███▄    █ ▓█████▄  ");
            Thread.Sleep(500);
            Console.WriteLine(@"            ▓  ██▒ ▓▒▓██░ ██▒▓█   ▀    ▓█   ▀ ██ ▀█   █ ▒██▀ ██▌ ");
            Thread.Sleep(500);
            Console.WriteLine(@"            ▒ ▓██░ ▒░▒██▀▀██░▒███      ▒███  ▓██  ▀█ ██▒░██   █▌ ");
            Thread.Sleep(500);
            Console.WriteLine(@"            ░ ▓██▓ ░ ░▓█ ░██ ▒▓█  ▄    ▒▓█  ▄▓██▒  ▐▌██▒░▓█▄   ▌ ");
            Thread.Sleep(500);
            Console.WriteLine(@"              ▒██▒ ░ ░▓█▒░██▓░▒████▒   ░▒████▒██░   ▓██░░▒████▓  ");
            Thread.Sleep(500);
            Console.WriteLine(@"              ▒ ░░    ▒ ░░▒░▒░░ ▒░ ░   ░░ ▒░ ░ ▒░   ▒ ▒  ▒▒▓  ▒  ");
            Thread.Sleep(500);
            Console.WriteLine(@"                ░     ▒ ░▒░ ░ ░ ░  ░    ░ ░  ░ ░░   ░ ▒░ ░ ▒  ▒  ");
            Thread.Sleep(500);
            Console.WriteLine(@"                ░       ░  ░░ ░   ░         ░     ░   ░ ░  ░ ░  ░  ");
            Thread.Sleep(500);
            Console.WriteLine(@"                      ░  ░  ░   ░  ░      ░  ░        ░    ░     ");
            Thread.Sleep(500);
            Console.WriteLine(@"                                                         ░       ");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("\n \n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n This has been Conquest Of Vikings");
            Thread.Sleep(2000);
            Console.WriteLine("\n We hope you enjoyed playing it!");
            Thread.Sleep(2000);
            Console.WriteLine("\n If you have any feedback just let us know!");
            Thread.Sleep(2000);
            Console.WriteLine("\n Thats all for now... bai! C;");
            Console.WriteLine("\n \n");
            Thread.Sleep(2000);
            Console.WriteLine(" Kind regards");
            Thread.Sleep(2000);
            Console.WriteLine(" EXtermin, RealKayle");

        }
    }

    

}