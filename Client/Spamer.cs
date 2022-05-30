using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Spamer
    {
        private readonly Logger logger_;
        private readonly StringGenerator generator_;
        public Spamer(Logger logger, StringGenerator generator)
        {
            this.logger_ = logger;
            this.generator_ = generator;
        }

        public void Spam()
        {
            logger_.Log(generator_.RandomString(10));
        }
    }
}
