//---------------------------------------------------------------------------
//
// Copyright (C) Inter Access B.V..  All rights reserved.
//
//---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schedule.Primitives
{
    /// <summary>
    /// Size of the timespan of each TimeItem
    /// </summary>
    public enum TimeItemSize
    {
        FiveMinutes = 300,
        SixMinutes = 360,
        TenMinutes = 600,
        HalfHour = 1800,
        OneHour = 3600,
        FiveHours = 18000,
        SixHours = 21600,
        Daily = 864000
    }
}
