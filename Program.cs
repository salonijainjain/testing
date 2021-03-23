using System;
using System.Collections.Generic;
namespace TestingEx
{
    class Program
    {
        public static List<Player> ListPlayers()
        {
            List<Player> ListPlayers = new List<Player>
            {
                new Player{Pid=1,Pname="Virat Kohli",Pteam="India"},
                 new Player{Pid=2,Pname="M.S.Dhoni",Pteam="India"}
            };
            return ListPlayers;
        }
        static void Main(string[] args)
        { }
    } 
    
}
