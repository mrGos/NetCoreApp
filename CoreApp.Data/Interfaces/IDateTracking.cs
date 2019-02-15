using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime CreatedDate { set; get; }

        DateTime ModifiedDate { set; get; }
    }
}
