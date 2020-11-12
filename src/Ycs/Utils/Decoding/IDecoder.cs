﻿// ------------------------------------------------------------------------------
//  <copyright company="Microsoft Corporation">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
// ------------------------------------------------------------------------------

using System;

namespace Ycs
{
    public interface IDecoder<T> : IDisposable
    {
        T Read();
    }
}
