﻿using OGL.Common;
using OGL.Features;
using System.IO;

namespace CB_5e.ViewModels
{
    public class HP: IXML
    {
        public int Value { get; set; }

        public string Name => Value.ToString();

        public string Source => "";

        public string ToXML()
        {
            return new Feature(Name, Name).ToXML();
        }

        public MemoryStream ToXMLStream()
        {
            return new Feature(Name, Name).ToXMLStream();
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
