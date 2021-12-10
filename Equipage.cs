using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTest
{
    public class Equipage
    {
        public IHorse Horse { get; set; }
        public ISulky Sulky { get; set; }
        public IJockey Jockey { get; set; }

        public Equipage(IHorse _horse, ISulky _sulky, IJockey _jockey)
        {
            Horse = _horse;
            Sulky = Sulky;
            Jockey = _jockey;
        }
    }
}
