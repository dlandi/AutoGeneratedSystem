﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGeneratedSystem.Common.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class)]
    public class ControllerOfEntityAttribute : Attribute
    {
        public string EntityName { get; private set; }
        public Type PrimaryKeyType { get; private set; }

        public ControllerOfEntityAttribute(string entityName, Type primaryKeyType)
        {
            this.EntityName = entityName;
            this.PrimaryKeyType = primaryKeyType;
        }
    }
}
