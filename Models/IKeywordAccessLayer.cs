﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace musicList2.Models
{
    public interface IKeywordAccessLayer
    {
        bool ValidateLogin(string kw);
    }
}