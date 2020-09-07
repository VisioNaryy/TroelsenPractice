using ImTools;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttributedCarLibrary
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
    public sealed class VehicleDescriptionAttribute: System.Attribute
    {
        public string Description { get; set; }
        public VehicleDescriptionAttribute(string venichalDescription)
            => Description = venichalDescription;
        public VehicleDescriptionAttribute() { }
    }
}
