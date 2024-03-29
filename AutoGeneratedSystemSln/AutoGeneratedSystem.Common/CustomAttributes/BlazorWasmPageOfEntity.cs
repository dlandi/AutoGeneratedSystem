﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGeneratedSystem.Common.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class BlazorWasmPageOfEntityAttribute : Attribute
    {
        public string EntityName { get; private set; }
        public BlazorPageType PageType { get; private set; }
        public Type PrimaryKeyType { get; private set; }
        public BlazorWasmPageOfEntityAttribute(string entityName, 
            BlazorPageType blazorPageType, Type primaryKeyType)
        {
            this.EntityName = entityName;
            this.PageType = blazorPageType;
            this.PrimaryKeyType = primaryKeyType;
        }

        public enum BlazorPageType
        {
            Create=0,
            Index=1
        }
    }
}
