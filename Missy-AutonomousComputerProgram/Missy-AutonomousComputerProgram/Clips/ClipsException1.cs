using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;

namespace Missy_AutonomousComputerProgram.Clips
{
    [Serializable]
    public class ClipsException : Exception
    {
        public ClipsException() { }
        public ClipsException(string message) { }
        public ClipsException(string message, System.Exception innerException) { }
    }
}
