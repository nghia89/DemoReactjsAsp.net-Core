using System;
using System.Collections.Generic;
using System.Text;

namespace ReactjsCoreTest.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreate { get; set; }
         DateTime DateModified { get; set; }
    }
}
