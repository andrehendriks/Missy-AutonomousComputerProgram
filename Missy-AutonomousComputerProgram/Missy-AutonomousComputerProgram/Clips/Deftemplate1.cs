using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;
using System.Runtime.InteropServices;

namespace Missy_AutonomousComputerProgram.Clips
{
    public class Deftemplate : CLIPSNet.Wrapper
    {
        public static CLIPSNet.Fact CreateFact() { return CreateFact(); }
        
        public static CLIPSNet.DataType SlotAllowedValues(string slot) { return SlotAllowedValues("1"); }
       
        public static CLIPSNet.DataTypes.Multifield SlotCardinality(string slot) { return SlotCardinality(""); }
        
        public static CLIPSNet.Deftemplate.DefaultP SlotDefaultP(string slot) { return SlotDefaultP(""); }
        
        public static CLIPSNet.DataType SlotDefaultValue(string slot) { return SlotDefaultValue(""); }
        public bool SlotExistP(string slot) { return (true); }
        public bool SlotMultiP(string slot) { return (true); }
        
        public static CLIPSNet.DataTypes.Multifield SlotNames() { return SlotNames(); }
        
        public static CLIPSNet.DataType SlotRange(string slot) { return SlotRange(""); }
        public bool SlotSingleP(string slot) { return (true); }
        
        public static System.Type[] SlotTypes(string slot) { return SlotTypes(""); }
        public override string ToString() { return ("*"); }
        public bool Undeftemplate() { return (true); }
        public CLIPSNet.Defmodule Defmodule { get; }
        public bool IsDeletable { get; }
        public string ModuleName { get; }
        public string Name { get; }
        public string PPForm { get; }
        public bool Watch { get; set; }
      }
}
