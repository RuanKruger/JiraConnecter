using System;
using System.Collections.Generic;
using System.Text;

namespace JiraConnecter.Programmability.Interfaces
{
    interface IFunctionType
    {
        bool Create();
        bool Update();
        List<T> FilteredList<T>(string v);
    }
}
