﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Km.Toi.Definition
{
    public class ParameterDefinition
    {
        public ParameterDefinition()
        {
        }

        public string Name { get; set; }

        public object Value { get; set; }

        public string DbType { get; set; }

        public byte Precision { get; set; }

        public byte Scale { get; set; }

        public int Size { get; set; }

        public bool IsNullable { get; set; }


    }
}