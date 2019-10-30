// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Internal.TypeSystem
{
    partial class MethodDelegator
    {
        public override bool IsIntrinsic
        {
            get
            {
                return _wrappedMethod.IsIntrinsic;
            }
        }

        public override bool IsNoInlining
        {
            get
            {
                return _wrappedMethod.IsNoInlining;
            }
        }

        public override bool IsAggressiveInlining
        {
            get
            {
                return _wrappedMethod.IsAggressiveInlining;
            }
        }

        public override bool IsAggressiveOptimization
        {
            get
            {
                return _wrappedMethod.IsAggressiveOptimization;
            }
        }

        public override bool IsNoOptimization
        {
            get
            {
                return _wrappedMethod.IsNoOptimization;
            }
        }

        public override bool IsRuntimeImplemented
        {
            get
            {
                return _wrappedMethod.IsRuntimeImplemented;
            }
        }

        public override bool IsInternalCall
        {
            get
            {
                return _wrappedMethod.IsInternalCall;
            }
        }

        public override bool IsSynchronized
        {
            get
            {
                return _wrappedMethod.IsSynchronized;
            }
        }

        public override bool IsNativeCallable
        {
            get
            {
                return _wrappedMethod.IsNativeCallable;
            }
        }

        public override bool IsRuntimeExport
        {
            get
            {
                return _wrappedMethod.IsRuntimeExport;
            }
        }

        public override bool IsSpecialName
        {
            get
            {
                return _wrappedMethod.IsSpecialName;
            }
        }
    }
}
