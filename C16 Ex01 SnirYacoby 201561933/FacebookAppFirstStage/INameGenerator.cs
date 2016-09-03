using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookAppFirstStage
{
    internal interface INameGenerator
    {
        string GenerateName(string i_FirstName, string i_LastName);
    }
}
