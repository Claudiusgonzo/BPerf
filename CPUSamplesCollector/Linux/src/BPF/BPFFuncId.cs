﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace BPerfCPUSamplesCollector
{
    internal enum BPFFuncId
    {
        Unspec,
        MapLookupElem,
        MapUpdateElem,
        MapDeleteElem,
        ProbeRead,
        KtimeGetNs,
        TracePrintk,
        GetPrandomU32,
        GetSmpProcessorId,
        SkbStoreBytes,
        L3CsumReplace,
        L4CsumReplace,
        TailCall,
        CloneRedirect,
        GetCurrentPidTgid,
        GetCurrentUidGid,
        GetCurrentComm,
        GetCgroupClassid,
        SkbVlanPush,
        SkbVlanPop,
        SkbGetTunnelKey,
        SkbSetTunnelKey,
        PerfEventRead,
        Redirect,
        GetRouteRealm,
        PerfEventOutput,
        SkbLoadBytes,
        GetStackid,
        CsumDiff,
        SkbGetTunnelOpt,
        SkbSetTunnelOpt,
        SkbChangeProto,
        SkbChangeType,
        SkbUnderCgroup,
        GetHashRecalc,
        GetCurrentTask,
        ProbeWriteUser,
        CurrentTaskUnderCgroup,
        SkbChangeTail,
        SkbPullData,
        CsumUpdate,
        SetHashInvalid,
        GetNumaNodeId,
        SkbChangeHead,
        XdpAdjustHead,
        ProbeReadStr,
        GetSocketCookie,
        GetSocketUid,
        SetHash,
        Setsockopt,
        SkbAdjustRoom,
        RedirectMap,
        SkRedirectMap,
        SockMapUpdate,
        XdpAdjustMeta,
        PerfEventReadValue,
        PerfProgReadValue,
        Getsockopt,
        OverrideReturn,
        SockOpsCbFlagsSet,
        MsgRedirectMap,
        MsgApplyBytes,
        MsgCorkBytes,
        MsgPullData,
        Bind,
        XdpAdjustTail,
        SkbGetXfrmState,
        GetStack,
        SkbLoadBytesRelative,
        FibLookup,
        SockHashUpdate,
        MsgRedirectHash,
        SkRedirectHash,
        LwtPushEncap,
        LwtSeg6StoreBytes,
        LwtSeg6AdjustSrh,
        LwtSeg6Action,
        RcRepeat,
        RcKeydown,
        SkbCgroupId,
        GetCurrentCgroupId,
        GetLocalStorage,
        SkSelectReuseport,
        SkbAncestorCgroupId,
        SkLookupTcp,
        SkLookupUdp,
        SkRelease,
        MapPushElem,
        MapPopElem,
        MapPeekElem,
        MsgPushData,
        MsgPopData,
        RcPointerRel,
        SpinLock,
        SpinUnlock,
        SkFullsock,
        TcpSock,
        SkbEcnSetCe,
        GetListenerSock,
        SkcLookupTcp,
        TcpCheckSyncookie,
        SysctlGetName,
        SysctlGetCurrentValue,
        SysctlGetNewValue,
        SysctlSetNewValue,
        Strtol,
        Strtoul,
        SkStorageGet,
        SkStorageDelete,
        SendSignal,
        TcpGenSyncookie,
        SkbOutput,
        ProbeReadUser,
        ProbeReadKernel,
        ProbeReadUserStr,
        ProbeReadKernelStr,
        TcpSendAck,
        SendSignalThread,
        Jiffies64,
    }
}