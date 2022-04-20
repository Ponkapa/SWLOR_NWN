﻿using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security;

namespace SWLOR.Game.Server.Core
{
    public static partial class NWNCore
    {
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr GetFunctionPointerDelegate(string name);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void RegisterHandlersDelegate(IntPtr handlers, uint size);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void CallBuiltInDelegate(int id);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void StackPushIntegerDelegate(int value);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void StackPushFloatDelegate(float value);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void StackPushStringDelegate(string value);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void StackPushStringUTF8Delegate(string value);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void StackPushObjectDelegate(uint value);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void StackPushVectorDelegate(Vector3 value);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void StackPushGameDefinedStructureDelegate(int type, IntPtr str);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int StackPopIntegerDelegate();

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float StackPopFloatDelegate();

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate string StackPopStringDelegate();

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate string StackPopStringUTF8Delegate();

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint StackPopObjectDelegate();

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate Vector3 StackPopVectorDelegate();

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr StackPopGameDefinedStructureDelegate(int type);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FreeEffectDelegate(IntPtr ptr);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FreeEventDelegate(IntPtr ptr);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FreeLocationDelegate(IntPtr ptr);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FreeTalentDelegate(IntPtr ptr);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void FreeItemPropertyDelegate(IntPtr ptr);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr FreeGameDefinedStructureDelegate(int type, IntPtr str);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ClosureAssignCommandDelegate(uint oid, ulong eventId);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ClosureDelayCommandDelegate(uint oid, float duration, ulong eventId);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int ClosureActionDoCommandDelegate(uint oid, ulong eventId);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void nwnxSetFunctionDelegate(string plugin, string function);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void nwnxPushIntDelegate(int n);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void nwnxPushFloatDelegate(float f);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void nwnxPushObjectDelegate(uint o);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void nwnxPushStringDelegate(string s);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void nwnxPushStringUTF8Delegate(string s);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void nwnxPushEffectDelegate(IntPtr e);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void nwnxPushItemPropertyDelegate(IntPtr ip);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate int nwnxPopIntDelegate();

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate float nwnxPopFloatDelegate();

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate uint nwnxPopObjectDelegate();

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate string nwnxPopStringDelegate();

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate string nwnxPopStringUTF8Delegate();

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr nwnxPopEffectDelegate();

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr nwnxPopItemPropertyDelegate();

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void nwnxCallFunctionDelegate();

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr RequestHookDelegate(IntPtr address, IntPtr managedFuncPtr, int priority);

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ReturnHookDelegate(IntPtr hook);

        [StructLayout(LayoutKind.Sequential)]
        public readonly struct NativeHandles
        {
            public readonly GetFunctionPointerDelegate GetFunctionPointer;
            public readonly RegisterHandlersDelegate RegisterHandlers;
            public readonly CallBuiltInDelegate CallBuiltIn;
            public readonly StackPushIntegerDelegate StackPushInteger;
            public readonly StackPushFloatDelegate StackPushFloat;
            public readonly StackPushStringDelegate StackPushString;
            public readonly StackPushStringUTF8Delegate StackPushStringUTF8;
            public readonly StackPushObjectDelegate StackPushObject;
            public readonly StackPushVectorDelegate StackPushVector;
            public readonly StackPushGameDefinedStructureDelegate StackPushGameDefinedStructure;
            public readonly StackPopIntegerDelegate StackPopInteger;
            public readonly StackPopFloatDelegate StackPopFloat;
            public readonly StackPopStringDelegate StackPopString;
            public readonly StackPopStringUTF8Delegate StackPopStringUTF8;
            public readonly StackPopObjectDelegate StackPopObject;
            public readonly StackPopVectorDelegate StackPopVector;
            public readonly StackPopGameDefinedStructureDelegate StackPopGameDefinedStructure;
            public readonly FreeGameDefinedStructureDelegate FreeGameDefinedStructure;
            public readonly ClosureAssignCommandDelegate ClosureAssignCommand;
            public readonly ClosureDelayCommandDelegate ClosureDelayCommand;
            public readonly ClosureActionDoCommandDelegate ClosureActionDoCommand;
            public readonly nwnxSetFunctionDelegate nwnxSetFunction;
            public readonly nwnxPushIntDelegate nwnxPushInt;
            public readonly nwnxPushFloatDelegate nwnxPushFloat;
            public readonly nwnxPushObjectDelegate nwnxPushObject;
            public readonly nwnxPushStringDelegate nwnxPushString;
            public readonly nwnxPushStringUTF8Delegate nwnxPushStringUTF8;
            public readonly nwnxPushEffectDelegate nwnxPushEffect;
            public readonly nwnxPushItemPropertyDelegate nwnxPushItemProperty;
            public readonly nwnxPopIntDelegate nwnxPopInt;
            public readonly nwnxPopFloatDelegate nwnxPopFloat;
            public readonly nwnxPopObjectDelegate nwnxPopObject;
            public readonly nwnxPopStringDelegate nwnxPopString;
            public readonly nwnxPopStringUTF8Delegate nwnxPopStringUTF8;
            public readonly nwnxPopEffectDelegate nwnxPopEffect;
            public readonly nwnxPopItemPropertyDelegate nwnxPopItemProperty;
            public readonly nwnxCallFunctionDelegate nwnxCallFunction;
            public readonly GetNWNXExportedGlobalsDelegate GetNWNXExportedGlobals;
            public readonly RequestHookDelegate RequestHook;
            public readonly ReturnHookDelegate ReturnHook;
        }
    }
}
