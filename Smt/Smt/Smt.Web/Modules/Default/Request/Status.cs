using Serenity.ComponentModel;
using System.ComponentModel;

namespace Smt.Default
{
    public enum Status
    {
        [Description("In Process")]
        InProcess = 1,
        [Description("Solved")]
        Solved = 2,
        [Description("Completed")]
        Completed = 3,
        [Description("Rejected")]
        Rejected = 4
    }
}
