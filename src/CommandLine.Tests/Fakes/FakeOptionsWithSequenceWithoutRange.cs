﻿// Copyright 2005-2015 Giacomo Stelluti Scala & Contributors. All rights reserved. See doc/License.md in the project root for license information.

using System.Collections.Generic;

namespace CommandLine.Tests.Fakes
{
    class FakeOptionsWithSequenceWithoutRange
    {
        [Value(0)]
        public IEnumerable<long> LongSequence { get; set; } 
    }
}
