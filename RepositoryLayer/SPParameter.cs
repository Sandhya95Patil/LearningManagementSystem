﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer
{
    public class SPParameter
    {

        /// <summary>
        /// method for taking name of parameters of stored procedure dynamically
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public SPParameter(string name, dynamic value)
        {
            this.name = name;
            this.value = value;
        }

        public string name { get; set; }
        public dynamic value { get; set; }
    }
}

