﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;


namespace Missy_AutonomousComputerProgram.Clips
{
    public class Fact 
    {
        public bool Assert() { return (true); }
        public bool AssignSlotDefaults() { return (true); }
        public void Dispose() { }
        public override bool Equals(object obj) { return (true); }
        public override int GetHashCode() { return (1); }
        
        public static CLIPSNet.DataType GetSlot(string slot) { return GetSlot(slot); }
        public void PPFact(string router, bool ignoreDefault) { }
        public bool PutSlot(string slot, CLIPSNet.DataType val) { return (true); }
        public bool Retract() { return (true); }
        public override string ToString() { return ("*"); }
        public CLIPSNet.Deftemplate Deftemplate { get; }
        public bool Exist { get; }
        public long Index { get; }
        public string PPForm { get; }
        public CLIPSNet.DataTypes.Multifield SlotNames { get; }
    }
}
