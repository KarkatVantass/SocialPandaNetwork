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
        public PandaSocialNetwork()
        {
            pandas = new List<Panda>();
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
        public int ConnectionLevel(Panda one, Panda two)
        {
            if (!(HasPanda(one) && HasPanda(two)))
            {
                return -1;
            }
            List<Panda> visited = new List<Panda>();
            Queue<Panda> pandaQ = new Queue<Panda>();
            Queue<int> levelQ = new Queue<int>();
            pandaQ.Enqueue(one);
            levelQ.Enqueue(0);
            visited.Add(one);
            while (pandaQ.Count>0)
            {
                Panda current = pandaQ.Dequeue();
                int level = levelQ.Dequeue();
                if (current.Equals(two))
                {
                    return level;
                }
                foreach (var friend in current.ListP)
                {
                    if (!visited.Contains(friend))
                    {
                        pandaQ.Enqueue(friend);
                        levelQ.Enqueue(level + 1);
                    }
                }
            }
            return -1;
                }
        public bool AreConnected(Panda one,Panda two)
        {
            if (ConnectionLevel(one,two) != -1)
                {
                return true;
            }
            return false;
        }

        public int HowManyGenderInNetwork(int level, Panda PandaForFriends, Gender gender)
        {
            int genderInLevel = 0;
            if (PandaForFriends.Gender == gender)
            {
                genderInLevel++;
            }
            foreach (var pnd in PandaForFriends.ListP)
            {
                if (ConnectionLevel(PandaForFriends, pnd) >= level)
                {
                    break;
                }
                if (pnd.Gender == gender)
                {
                    genderInLevel++;
                }
            }
            return genderInLevel;
        }
    }

}
