﻿namespace Qualm.Rmq.DependancyInjection
{
    public class RmqQueueingOptions
    {
        public RmqConnectionDetails ConnectionDetails { get; set; } = new RmqConnectionDetails();
    }
}
