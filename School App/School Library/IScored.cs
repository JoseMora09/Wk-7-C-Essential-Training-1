using System;
using System.Collections.Generic;
using System.Text;

namespace School_Library
{
    public interface IScored
    {
        float Score { get; set; }
        float MaximumScore { get; set; }
    }
}
