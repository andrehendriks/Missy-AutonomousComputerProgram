using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prolog;

namespace Missy_AutonomousComputerProgram.CProlog
{
    public interface ISolution
    {
        bool IsLast { get; }
        bool Solved { get; }
        System.Collections.Generic.IEnumerable<Prolog.PrologEngine.IVarValue> VarValuesIterator { get; }
    }
}
