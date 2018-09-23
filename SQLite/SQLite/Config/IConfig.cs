﻿using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLite.Config
{
    public interface IConfig
    {
        string DirectorioDB { get; }
        ISQLitePlatform Plataforma { get; } 
    }
}
