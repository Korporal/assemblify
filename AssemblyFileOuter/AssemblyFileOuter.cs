﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyFileOuter
{
    public class AssemblyFileOuter
    {
        private AssemblyFileInner.AssemblyFileInner blob;
        public AssemblyFileOuter()
        {
            blob = new AssemblyFileInner.AssemblyFileInner();
        }
    }
}