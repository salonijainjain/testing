using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<OurSample> ListPlayers = new List<OurSample>
            {
                new OurSample{Pid=1,Pname="Virat Kohli",Pteam="India"},
                 new OurSample{Pid=2,Pname="M.S.Dhoni",Pteam="India"}
            };
            Console.WriteLine("ID \t Name \t Team\t");
            foreach(OurSample player in ListPlayers )
            {
                Console.WriteLine(player.Pid+"\t"+player.Pname+"\t"+player.Pteam);
            }
        }
    }
}
