using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konst_test_2
{
    internal class Person
    {
        private string namn;
        private string efternamn;

        public Person(string namnr, string efternamnr)
        {
            namn = namnr;
            efternamn = efternamnr;
        }
        public Person()
        {

        }
        public string Namn
        {
            get { return namn; }
            set { namn = value; }
        }
        public string Efternamn
        {
            get { return efternamn; }
            set { efternamn = value; }
        }
    }

}

