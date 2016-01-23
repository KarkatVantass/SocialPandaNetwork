﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialPandaLibrary
{
    class PandaAlreadyThereException:Exception
    {
        public PandaAlreadyThereException()
        {

        }
        public PandaAlreadyThereException(string message):base(message)
        {

        }
        public PandaAlreadyThereException(string message,Exception inner) : base(message,inner)
        {

        }
    }
}
