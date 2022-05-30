using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class StringGenerator
    {
        private readonly Random rnd_;
        public StringGenerator(Random random)
        {
            rnd+ = new Random();
        }

        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[rnd_.Next(s.Length)]).ToArray());
        }
    }
}
