﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGeneratedSystem.Common.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class JunctionTableAttribute: Attribute
    {
        public string EntityName { get; }
        public string DisplayTextFieldName { get; }
        public string ValueFieldName { get; set; }
        public JunctionTableAttribute(string entityName, string displayTextFieldName, 
            string valueFieldName)
        {
            this.EntityName = entityName;
            this.DisplayTextFieldName = displayTextFieldName;
            this.ValueFieldName = valueFieldName;
        }
    }
}
