using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    public static class Factory
    {
        public static IJockey CreateJockey()
        {
            return new Jockey();
        }
        public static ISulky CreateSulky()
        {
            return new Sulky();
        }
        public static IHorse CreateHorse()
        {
            return new Horse();
        }
    }
}
