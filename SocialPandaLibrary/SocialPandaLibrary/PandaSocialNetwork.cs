using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialPandaLibrary
{
    public class PandaSocialNetwork
    {
        private List<Panda> pandas;
        private int connectionLevel;
        private List<Panda> cheked;
        public PandaSocialNetwork()
        {
            connectionLevel = 0;
            pandas = new List<Panda>();
            cheked = new List<Panda>();
        }
        public void AddPanda(Panda newpanda)
        {
            if (pandas.Contains(newpanda))
            {
                throw new PandaAlreadyThereException();
            }
            else
            {
                pandas.Add(newpanda);
            }
        }
        public bool HasPanda(Panda panda)
        {
            return pandas.Contains(panda);
        }
        public void MakeFriends(Panda one, Panda two)
        {
            one.Befriend(two);
            two.Befriend(one);
        }
        public bool AreFriends(Panda one, Panda two)
        {
            return one.ListP.Contains(two);
        }
        public List<Panda> FriendsOf(Panda panda)
        {
            if (pandas.Contains(panda))
            {
                throw new Exception();//TO DO CUSTOM EXC NOTINTHENEWTROK
            }
            else
            {
                return panda.ListP;
            }
        }
        public void ConnectionLevel(Panda one, Panda two)
        {
            cheked.Add(one);
            connectionLevel++;
            foreach (var friend in one.ListP)
            {
                if (cheked.Contains(friend))
                {
                    continue;
                }
                else if (friend.Equals(two))
                {
                    Console.WriteLine(connectionLevel);
                }
                else
                {
                    cheked.Add(friend);
                    ConnectionLevel(friend, two);
                }
                
            }
        }
    }

}
