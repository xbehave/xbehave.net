﻿// <copyright file="BackgroundStep.cs" company="Adam Ralph">
//  Copyright (c) Adam Ralph. All rights reserved.
// </copyright>

namespace Xbehave.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using Xbehave.Infra;

    internal class BackgroundStep : Step
    {
        public BackgroundStep(string stepType, string text, Action body)
            : base(stepType, text, body)
        {
        }

        public override string Name
        {
            get { return "(Background) " + base.Name; }
        }
    }
}