﻿using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace EFCore.Scaffolding.Extension.Models
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public class Property
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string DefaultValueSql { get; set; }

        [XmlAttribute]
        public string ValueGenerated { get; set; }

        [XmlAttribute]
        public string Column { get; set; }

        [XmlAttribute]
        public string Converter { get; set; }

        [XmlAttribute]
        public string Type { get; set; }

        [XmlAttribute]
        public string MapType { get; set; }

        [XmlAttribute]
        public string PrincipalTableName { get; set; }

        [XmlAttribute]
        public string Summary { get; set; }

        [XmlAttribute]
        public string FKPrincipalColumn { get; set; }

        [XmlAttribute]
        public string PrincipalColumnName { get; set; }

        [XmlIgnore]
        public ValueConverterEnum ConverterEnum => string.IsNullOrEmpty(this.Converter) ? default : (ValueConverterEnum)Enum.Parse(typeof(ValueConverterEnum), this.Converter);

        [XmlAttribute]
        public string TableName { get; set; }
    }
}