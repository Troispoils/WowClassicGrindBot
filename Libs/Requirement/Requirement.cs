﻿using System;

namespace Libs
{
    public class Requirement
    {
        public Func<bool> HasRequirement { get; set; } = () => false;
        public Func<string> LogMessage { get; set; } = () => "Unknown requirement";
        public bool VisibleIfHasRequirement = true;
    }
}