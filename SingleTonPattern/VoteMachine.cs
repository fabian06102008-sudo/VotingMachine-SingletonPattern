using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    internal class VoteMachine
    {
        private static VoteMachine instance;
        private int votes = 0;
        private List<VotingPeople> votingPeoples = new List<VotingPeople>();
        private List<string> Parties = new List<string>();

        private string adminpassword = "AdminPassword123";

        private VoteMachine()
        {
            
        }

        public List<string> PartyListCheck()
        {
            List<string> Parties = new List<string>();
            Parties.Add("Unity Forward Party");
            Parties.Add("People’s Reform Alliance");
            Parties.Add("Liberty & Progress Party");
            Parties.Add("National Future Movement");
            Parties.Add("Civic Responsibility Party");

            return Parties;
        }


        public static VoteMachine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VoteMachine();
                }

                return instance;
            }
        }

        public void AddVote(VotingPeople votingPeople)
        {
            votingPeoples.Add(votingPeople);

            votes++;
        }

        public void ShowVoters(string adminpassw)
        {
            if (adminpassw == adminpassword)
            {
                Console.WriteLine("|| Voterslist ||");

                for (int i = 0; i < votingPeoples.Count; i++)
                {
                    Console.WriteLine("======================================================================");
                    Console.WriteLine(votingPeoples[i].ToString());
                    Console.WriteLine("======================================================================\n");
                }

                Console.ReadKey();

            }
            else
            {
                Console.Clear();
                Console.WriteLine("You have not the rights to do that...!");
                Console.ReadKey();
            }
        }
    }
}

