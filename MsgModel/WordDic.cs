﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsgModel
{
    public class WordDic : ModelBase
    {
        public string Word { get; set; }

        public Word[] Lan { get; set; }
    }
}
