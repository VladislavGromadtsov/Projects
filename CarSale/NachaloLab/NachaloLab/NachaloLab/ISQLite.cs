using System;
using System.Collections.Generic;
using System.Text;

namespace NachaloLab
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
