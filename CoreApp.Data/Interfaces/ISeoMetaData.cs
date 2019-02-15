﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Data.Interfaces
{
    public interface ISeoMetaData
    {
        string SeoPageTitle { set; get; }
        string SeoAlias { set; get; }
        string SeoKeywords { set; get; }
        string SeoDescription { get; set; }
    }
}
