﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.EventArgs
{
    public class GameMessageEventArgs
    {
        public string Message { get; set; }

        public GameMessageEventArgs(string message)
        {
            Message = message;
        }
    }
}
