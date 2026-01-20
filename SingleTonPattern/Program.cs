
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    internal class Program
    {
        static void AddVoter()
        {
            Console.Clear();

            string firstname;
            string lastname;
            int age;
            string fingerprint;

            Random rnd = new Random();

            fingerprint = rnd.Next(1, 222222222).ToString();

            Console.Write("Please enter your First Name: ");
            firstname = Console.ReadLine();

            Console.Write("\nPlease enter your Last Name: ");
            lastname = Console.ReadLine();

            Console.Write("\nPlease enter your age: ");
            try
            {

                Console.Clear();
                age = Convert.ToInt16(Console.ReadLine());

                if (age >= 18)
                {
                    VotingPeople votedguy = new VotingPeople(firstname, lastname, age, fingerprint);
                    VoteMachine vm = VoteMachine.Instance;
                    vm.AddVote(votedguy);
                    Console.WriteLine($"Hello, {firstname + " " + lastname} you succsessfully voted");
                }
                else
                {
                    Console.WriteLine($"Hey, {firstname + " " + lastname} sorry... you cannot vote with your age. (You have to be 18+)");
                }

            }
            catch (Exception exmsg)
            {
                Console.Clear();
                Console.WriteLine("Please enter a number for the age...!");
            }

            Console.ReadKey();

        }


        static void Menu()
        {
            Console.WriteLine("1.) Vote");
            Console.WriteLine("2.) Show Voters");
            Console.WriteLine("3.) End program.");
        }

        static void Main(string[] args)
        {
            bool ProgrammRunning = true;
            bool firststartup = true;

            while (ProgrammRunning)
            {
                if (!firststartup)
                {
                    Console.Clear();
                }

                firststartup = false;

                Menu();

                string entry = Console.ReadLine();

                switch (entry)
                {
                    case "1":

                        Console.Clear();

                        AddVoter();

                        break;

                    case "3":
                        ProgrammRunning = false;
                        break;

                    case "2":


                        Console.Write("Please enter the admin password: ");
                        string admpwd = Console.ReadLine();

                        Console.Clear() ;

                        VoteMachine vm_seevoters = VoteMachine.Instance;


                        vm_seevoters.ShowVoters(admpwd);

                        break;


                    default:
                        Console.Clear();
                        Console.WriteLine("Please give a valid entry...!");
                        Console.ReadKey();
                        break;

                }
            }
        }
    }
}
