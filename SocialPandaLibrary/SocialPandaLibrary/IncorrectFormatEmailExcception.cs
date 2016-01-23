using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialPandaLibrary
{
    public class IncorrectFormatEmailExcception:Exception
    {
        public IncorrectFormatEmailExcception()
        {

        }
        public IncorrectFormatEmailExcception(string mesagge):base(mesagge)
        {

        }
        public IncorrectFormatEmailExcception(string mesagge,Exception inner) : base(mesagge,inner)
        {

        }
    }
}
