using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    internal class VotingPeople
    {
        private string FirstName {  get; set; }
        private string LastName { get; set; }
        private int Age { get; set; }
        private string FingerPrint { get; set; }

        public VotingPeople(string firstname, string lastname, int age, string fingerprint)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            FingerPrint = fingerprint;
        }

        public override string ToString()
        {
            return $"| Firstname: {FirstName}, Lastname: {LastName}, Age: {Age}, Private Fingerprint: {FingerPrint} |";
        }

    }
}
