﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public interface IMoveable
    {
        int TimesMoved { get; }
        string Move();
        string Move(int times);
    }
}
