﻿// ------------------------------------------------------------------------------
//  <copyright company="Microsoft Corporation">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
//  </copyright>
// ------------------------------------------------------------------------------

namespace Ycs
{
    public interface IEncoder<T>
    {
        void Write(T value);
        byte[] ToArray();
    }
}
