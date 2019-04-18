﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity
{
    public interface IPlugin:IDisposable
    {
        Task BeginInit();

        Task EndInit();

        Task Shutdown();
    }
}