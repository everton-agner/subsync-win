﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubSync
{
    public enum SyncStatus
    {
        NOT_RUNNING,
        RUNNING
    }

    public enum SyncAction
    {
        START,
        STOP
    }

    public enum SyncStartStopProgress
    {
        STARTING,
        STOPPING,
        STARTED,
        STOPPED
    }

    public enum NotificationPeriod
    {
        SHORT  = 2  * 1000,
        NORMAL = 5  * 1000,
        LONG   = 15 * 1000
    }
}
