﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    public interface IModel
    {
        int ID { get; set; }
        string Name { get; set; }
    }
}
