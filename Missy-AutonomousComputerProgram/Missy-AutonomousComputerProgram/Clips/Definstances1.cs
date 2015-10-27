using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;

namespace Missy_AutonomousComputerProgram.Clips
{
    public class Definstances : CLIPSNet.Wrapper
    {
        public bool Undefinstances() { return (false); }
        public CLIPSNet.Defmodule Defmodule { get; }
        public bool IsDeletable { get; }
        public string ModuleName { get; }
        public string Name { get; }
        public string PPForm { get; }
    }
}
