﻿




// Generated by PIDL compiler.
// Do not modify this file, but modify the source .pidl file.

using System;

namespace MSBC2S
{
	internal class Stub:Nettention.Proud.RmiStub
	{
public AfterRmiInvocationDelegate AfterRmiInvocation = delegate(Nettention.Proud.AfterRmiSummary summary) {};
public BeforeRmiInvocationDelegate BeforeRmiInvocation = delegate(Nettention.Proud.BeforeRmiSummary summary) {};

		public delegate bool OnLoginRequestDelegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, String data);  
		public OnLoginRequestDelegate OnLoginRequest = delegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, String data)
		{ 
			return false;
		};
		public delegate bool OnStatusRequestDelegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, String data);  
		public OnStatusRequestDelegate OnStatusRequest = delegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, String data)
		{ 
			return false;
		};
		public delegate bool OnSystemRequestDelegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, String data);  
		public OnSystemRequestDelegate OnSystemRequest = delegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, String data)
		{ 
			return false;
		};
		public delegate bool OnGameQueueRequestDelegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, String data);  
		public OnGameQueueRequestDelegate OnGameQueueRequest = delegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, String data)
		{ 
			return false;
		};
		public delegate bool OnGameInfoRequestDelegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data);  
		public OnGameInfoRequestDelegate OnGameInfoRequest = delegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data)
		{ 
			return false;
		};
		public delegate bool OnGameActionReadyDelegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data);  
		public OnGameActionReadyDelegate OnGameActionReady = delegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data)
		{ 
			return false;
		};
		public delegate bool OnGameActionDamageDelegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data);  
		public OnGameActionDamageDelegate OnGameActionDamage = delegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data)
		{ 
			return false;
		};
		public delegate bool OnGameActionObjectDelegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data);  
		public OnGameActionObjectDelegate OnGameActionObject = delegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data)
		{ 
			return false;
		};
		public delegate bool OnGameActionItemDelegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data);  
		public OnGameActionItemDelegate OnGameActionItem = delegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data)
		{ 
			return false;
		};
		public delegate bool OnGameUserMoveDelegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data);  
		public OnGameUserMoveDelegate OnGameUserMove = delegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data)
		{ 
			return false;
		};
		public delegate bool OnGameUserSyncDelegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data);  
		public OnGameUserSyncDelegate OnGameUserSync = delegate(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data)
		{ 
			return false;
		};
	public override bool ProcessReceivedMessage(Nettention.Proud.ReceivedMessage pa, Object hostTag) 
	{
		Nettention.Proud.HostID remote=pa.RemoteHostID;
		if(remote==Nettention.Proud.HostID.HostID_None)
		{
			ShowUnknownHostIDWarning(remote);
		}

		Nettention.Proud.Message __msg=pa.ReadOnlyMessage;
		int orgReadOffset = __msg.ReadOffset;
        Nettention.Proud.RmiID __rmiID = Nettention.Proud.RmiID.RmiID_None;
        if (!__msg.Read( out __rmiID))
            goto __fail;
					
		switch(__rmiID)
		{
        case Common.OnLoginRequest:
            ProcessReceivedMessage_OnLoginRequest(__msg, pa, hostTag, remote);
            break;
        case Common.OnStatusRequest:
            ProcessReceivedMessage_OnStatusRequest(__msg, pa, hostTag, remote);
            break;
        case Common.OnSystemRequest:
            ProcessReceivedMessage_OnSystemRequest(__msg, pa, hostTag, remote);
            break;
        case Common.OnGameQueueRequest:
            ProcessReceivedMessage_OnGameQueueRequest(__msg, pa, hostTag, remote);
            break;
        case Common.OnGameInfoRequest:
            ProcessReceivedMessage_OnGameInfoRequest(__msg, pa, hostTag, remote);
            break;
        case Common.OnGameActionReady:
            ProcessReceivedMessage_OnGameActionReady(__msg, pa, hostTag, remote);
            break;
        case Common.OnGameActionDamage:
            ProcessReceivedMessage_OnGameActionDamage(__msg, pa, hostTag, remote);
            break;
        case Common.OnGameActionObject:
            ProcessReceivedMessage_OnGameActionObject(__msg, pa, hostTag, remote);
            break;
        case Common.OnGameActionItem:
            ProcessReceivedMessage_OnGameActionItem(__msg, pa, hostTag, remote);
            break;
        case Common.OnGameUserMove:
            ProcessReceivedMessage_OnGameUserMove(__msg, pa, hostTag, remote);
            break;
        case Common.OnGameUserSync:
            ProcessReceivedMessage_OnGameUserSync(__msg, pa, hostTag, remote);
            break;
		default:
			 goto __fail;
		}
		return true;
__fail:
	  {
			__msg.ReadOffset = orgReadOffset;
			return false;
	  }
	}
    void ProcessReceivedMessage_OnLoginRequest(Nettention.Proud.Message __msg, Nettention.Proud.ReceivedMessage pa, Object hostTag, Nettention.Proud.HostID remote)
    {
        Nettention.Proud.RmiContext ctx = new Nettention.Proud.RmiContext();
        ctx.sentFrom=pa.RemoteHostID;
        ctx.relayed=pa.IsRelayed;
        ctx.hostTag=hostTag;
        ctx.encryptMode = pa.EncryptMode;
        ctx.compressMode = pa.CompressMode;

        String data; Nettention.Proud.Marshaler.Read(__msg,out data);	
core.PostCheckReadMessage(__msg, RmiName_OnLoginRequest);
        if(enableNotifyCallFromStub==true)
        {
        string parameterString = "";
        parameterString+=data.ToString()+",";
        NotifyCallFromStub(Common.OnLoginRequest, RmiName_OnLoginRequest,parameterString);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.BeforeRmiSummary summary = new Nettention.Proud.BeforeRmiSummary();
        summary.rmiID = Common.OnLoginRequest;
        summary.rmiName = RmiName_OnLoginRequest;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        BeforeRmiInvocation(summary);
        }

        long t0 = Nettention.Proud.PreciseCurrentTime.GetTimeMs();

        // Call this method.
        bool __ret =OnLoginRequest (remote,ctx , data );

        if(__ret==false)
        {
        // Error: RMI function that a user did not create has been called. 
        core.ShowNotImplementedRmiWarning(RmiName_OnLoginRequest);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.AfterRmiSummary summary = new Nettention.Proud.AfterRmiSummary();
        summary.rmiID = Common.OnLoginRequest;
        summary.rmiName = RmiName_OnLoginRequest;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        summary.elapsedTime = Nettention.Proud.PreciseCurrentTime.GetTimeMs()-t0;
        AfterRmiInvocation(summary);
        }
    }
    void ProcessReceivedMessage_OnStatusRequest(Nettention.Proud.Message __msg, Nettention.Proud.ReceivedMessage pa, Object hostTag, Nettention.Proud.HostID remote)
    {
        Nettention.Proud.RmiContext ctx = new Nettention.Proud.RmiContext();
        ctx.sentFrom=pa.RemoteHostID;
        ctx.relayed=pa.IsRelayed;
        ctx.hostTag=hostTag;
        ctx.encryptMode = pa.EncryptMode;
        ctx.compressMode = pa.CompressMode;

        String data; Nettention.Proud.Marshaler.Read(__msg,out data);	
core.PostCheckReadMessage(__msg, RmiName_OnStatusRequest);
        if(enableNotifyCallFromStub==true)
        {
        string parameterString = "";
        parameterString+=data.ToString()+",";
        NotifyCallFromStub(Common.OnStatusRequest, RmiName_OnStatusRequest,parameterString);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.BeforeRmiSummary summary = new Nettention.Proud.BeforeRmiSummary();
        summary.rmiID = Common.OnStatusRequest;
        summary.rmiName = RmiName_OnStatusRequest;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        BeforeRmiInvocation(summary);
        }

        long t0 = Nettention.Proud.PreciseCurrentTime.GetTimeMs();

        // Call this method.
        bool __ret =OnStatusRequest (remote,ctx , data );

        if(__ret==false)
        {
        // Error: RMI function that a user did not create has been called. 
        core.ShowNotImplementedRmiWarning(RmiName_OnStatusRequest);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.AfterRmiSummary summary = new Nettention.Proud.AfterRmiSummary();
        summary.rmiID = Common.OnStatusRequest;
        summary.rmiName = RmiName_OnStatusRequest;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        summary.elapsedTime = Nettention.Proud.PreciseCurrentTime.GetTimeMs()-t0;
        AfterRmiInvocation(summary);
        }
    }
    void ProcessReceivedMessage_OnSystemRequest(Nettention.Proud.Message __msg, Nettention.Proud.ReceivedMessage pa, Object hostTag, Nettention.Proud.HostID remote)
    {
        Nettention.Proud.RmiContext ctx = new Nettention.Proud.RmiContext();
        ctx.sentFrom=pa.RemoteHostID;
        ctx.relayed=pa.IsRelayed;
        ctx.hostTag=hostTag;
        ctx.encryptMode = pa.EncryptMode;
        ctx.compressMode = pa.CompressMode;

        String data; Nettention.Proud.Marshaler.Read(__msg,out data);	
core.PostCheckReadMessage(__msg, RmiName_OnSystemRequest);
        if(enableNotifyCallFromStub==true)
        {
        string parameterString = "";
        parameterString+=data.ToString()+",";
        NotifyCallFromStub(Common.OnSystemRequest, RmiName_OnSystemRequest,parameterString);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.BeforeRmiSummary summary = new Nettention.Proud.BeforeRmiSummary();
        summary.rmiID = Common.OnSystemRequest;
        summary.rmiName = RmiName_OnSystemRequest;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        BeforeRmiInvocation(summary);
        }

        long t0 = Nettention.Proud.PreciseCurrentTime.GetTimeMs();

        // Call this method.
        bool __ret =OnSystemRequest (remote,ctx , data );

        if(__ret==false)
        {
        // Error: RMI function that a user did not create has been called. 
        core.ShowNotImplementedRmiWarning(RmiName_OnSystemRequest);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.AfterRmiSummary summary = new Nettention.Proud.AfterRmiSummary();
        summary.rmiID = Common.OnSystemRequest;
        summary.rmiName = RmiName_OnSystemRequest;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        summary.elapsedTime = Nettention.Proud.PreciseCurrentTime.GetTimeMs()-t0;
        AfterRmiInvocation(summary);
        }
    }
    void ProcessReceivedMessage_OnGameQueueRequest(Nettention.Proud.Message __msg, Nettention.Proud.ReceivedMessage pa, Object hostTag, Nettention.Proud.HostID remote)
    {
        Nettention.Proud.RmiContext ctx = new Nettention.Proud.RmiContext();
        ctx.sentFrom=pa.RemoteHostID;
        ctx.relayed=pa.IsRelayed;
        ctx.hostTag=hostTag;
        ctx.encryptMode = pa.EncryptMode;
        ctx.compressMode = pa.CompressMode;

        String data; Nettention.Proud.Marshaler.Read(__msg,out data);	
core.PostCheckReadMessage(__msg, RmiName_OnGameQueueRequest);
        if(enableNotifyCallFromStub==true)
        {
        string parameterString = "";
        parameterString+=data.ToString()+",";
        NotifyCallFromStub(Common.OnGameQueueRequest, RmiName_OnGameQueueRequest,parameterString);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.BeforeRmiSummary summary = new Nettention.Proud.BeforeRmiSummary();
        summary.rmiID = Common.OnGameQueueRequest;
        summary.rmiName = RmiName_OnGameQueueRequest;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        BeforeRmiInvocation(summary);
        }

        long t0 = Nettention.Proud.PreciseCurrentTime.GetTimeMs();

        // Call this method.
        bool __ret =OnGameQueueRequest (remote,ctx , data );

        if(__ret==false)
        {
        // Error: RMI function that a user did not create has been called. 
        core.ShowNotImplementedRmiWarning(RmiName_OnGameQueueRequest);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.AfterRmiSummary summary = new Nettention.Proud.AfterRmiSummary();
        summary.rmiID = Common.OnGameQueueRequest;
        summary.rmiName = RmiName_OnGameQueueRequest;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        summary.elapsedTime = Nettention.Proud.PreciseCurrentTime.GetTimeMs()-t0;
        AfterRmiInvocation(summary);
        }
    }
    void ProcessReceivedMessage_OnGameInfoRequest(Nettention.Proud.Message __msg, Nettention.Proud.ReceivedMessage pa, Object hostTag, Nettention.Proud.HostID remote)
    {
        Nettention.Proud.RmiContext ctx = new Nettention.Proud.RmiContext();
        ctx.sentFrom=pa.RemoteHostID;
        ctx.relayed=pa.IsRelayed;
        ctx.hostTag=hostTag;
        ctx.encryptMode = pa.EncryptMode;
        ctx.compressMode = pa.CompressMode;

        int room; Nettention.Proud.Marshaler.Read(__msg,out room);	
String data; Nettention.Proud.Marshaler.Read(__msg,out data);	
core.PostCheckReadMessage(__msg, RmiName_OnGameInfoRequest);
        if(enableNotifyCallFromStub==true)
        {
        string parameterString = "";
        parameterString+=room.ToString()+",";
parameterString+=data.ToString()+",";
        NotifyCallFromStub(Common.OnGameInfoRequest, RmiName_OnGameInfoRequest,parameterString);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.BeforeRmiSummary summary = new Nettention.Proud.BeforeRmiSummary();
        summary.rmiID = Common.OnGameInfoRequest;
        summary.rmiName = RmiName_OnGameInfoRequest;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        BeforeRmiInvocation(summary);
        }

        long t0 = Nettention.Proud.PreciseCurrentTime.GetTimeMs();

        // Call this method.
        bool __ret =OnGameInfoRequest (remote,ctx , room, data );

        if(__ret==false)
        {
        // Error: RMI function that a user did not create has been called. 
        core.ShowNotImplementedRmiWarning(RmiName_OnGameInfoRequest);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.AfterRmiSummary summary = new Nettention.Proud.AfterRmiSummary();
        summary.rmiID = Common.OnGameInfoRequest;
        summary.rmiName = RmiName_OnGameInfoRequest;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        summary.elapsedTime = Nettention.Proud.PreciseCurrentTime.GetTimeMs()-t0;
        AfterRmiInvocation(summary);
        }
    }
    void ProcessReceivedMessage_OnGameActionReady(Nettention.Proud.Message __msg, Nettention.Proud.ReceivedMessage pa, Object hostTag, Nettention.Proud.HostID remote)
    {
        Nettention.Proud.RmiContext ctx = new Nettention.Proud.RmiContext();
        ctx.sentFrom=pa.RemoteHostID;
        ctx.relayed=pa.IsRelayed;
        ctx.hostTag=hostTag;
        ctx.encryptMode = pa.EncryptMode;
        ctx.compressMode = pa.CompressMode;

        int room; Nettention.Proud.Marshaler.Read(__msg,out room);	
String data; Nettention.Proud.Marshaler.Read(__msg,out data);	
core.PostCheckReadMessage(__msg, RmiName_OnGameActionReady);
        if(enableNotifyCallFromStub==true)
        {
        string parameterString = "";
        parameterString+=room.ToString()+",";
parameterString+=data.ToString()+",";
        NotifyCallFromStub(Common.OnGameActionReady, RmiName_OnGameActionReady,parameterString);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.BeforeRmiSummary summary = new Nettention.Proud.BeforeRmiSummary();
        summary.rmiID = Common.OnGameActionReady;
        summary.rmiName = RmiName_OnGameActionReady;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        BeforeRmiInvocation(summary);
        }

        long t0 = Nettention.Proud.PreciseCurrentTime.GetTimeMs();

        // Call this method.
        bool __ret =OnGameActionReady (remote,ctx , room, data );

        if(__ret==false)
        {
        // Error: RMI function that a user did not create has been called. 
        core.ShowNotImplementedRmiWarning(RmiName_OnGameActionReady);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.AfterRmiSummary summary = new Nettention.Proud.AfterRmiSummary();
        summary.rmiID = Common.OnGameActionReady;
        summary.rmiName = RmiName_OnGameActionReady;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        summary.elapsedTime = Nettention.Proud.PreciseCurrentTime.GetTimeMs()-t0;
        AfterRmiInvocation(summary);
        }
    }
    void ProcessReceivedMessage_OnGameActionDamage(Nettention.Proud.Message __msg, Nettention.Proud.ReceivedMessage pa, Object hostTag, Nettention.Proud.HostID remote)
    {
        Nettention.Proud.RmiContext ctx = new Nettention.Proud.RmiContext();
        ctx.sentFrom=pa.RemoteHostID;
        ctx.relayed=pa.IsRelayed;
        ctx.hostTag=hostTag;
        ctx.encryptMode = pa.EncryptMode;
        ctx.compressMode = pa.CompressMode;

        int room; Nettention.Proud.Marshaler.Read(__msg,out room);	
String data; Nettention.Proud.Marshaler.Read(__msg,out data);	
core.PostCheckReadMessage(__msg, RmiName_OnGameActionDamage);
        if(enableNotifyCallFromStub==true)
        {
        string parameterString = "";
        parameterString+=room.ToString()+",";
parameterString+=data.ToString()+",";
        NotifyCallFromStub(Common.OnGameActionDamage, RmiName_OnGameActionDamage,parameterString);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.BeforeRmiSummary summary = new Nettention.Proud.BeforeRmiSummary();
        summary.rmiID = Common.OnGameActionDamage;
        summary.rmiName = RmiName_OnGameActionDamage;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        BeforeRmiInvocation(summary);
        }

        long t0 = Nettention.Proud.PreciseCurrentTime.GetTimeMs();

        // Call this method.
        bool __ret =OnGameActionDamage (remote,ctx , room, data );

        if(__ret==false)
        {
        // Error: RMI function that a user did not create has been called. 
        core.ShowNotImplementedRmiWarning(RmiName_OnGameActionDamage);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.AfterRmiSummary summary = new Nettention.Proud.AfterRmiSummary();
        summary.rmiID = Common.OnGameActionDamage;
        summary.rmiName = RmiName_OnGameActionDamage;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        summary.elapsedTime = Nettention.Proud.PreciseCurrentTime.GetTimeMs()-t0;
        AfterRmiInvocation(summary);
        }
    }
    void ProcessReceivedMessage_OnGameActionObject(Nettention.Proud.Message __msg, Nettention.Proud.ReceivedMessage pa, Object hostTag, Nettention.Proud.HostID remote)
    {
        Nettention.Proud.RmiContext ctx = new Nettention.Proud.RmiContext();
        ctx.sentFrom=pa.RemoteHostID;
        ctx.relayed=pa.IsRelayed;
        ctx.hostTag=hostTag;
        ctx.encryptMode = pa.EncryptMode;
        ctx.compressMode = pa.CompressMode;

        int room; Nettention.Proud.Marshaler.Read(__msg,out room);	
String data; Nettention.Proud.Marshaler.Read(__msg,out data);	
core.PostCheckReadMessage(__msg, RmiName_OnGameActionObject);
        if(enableNotifyCallFromStub==true)
        {
        string parameterString = "";
        parameterString+=room.ToString()+",";
parameterString+=data.ToString()+",";
        NotifyCallFromStub(Common.OnGameActionObject, RmiName_OnGameActionObject,parameterString);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.BeforeRmiSummary summary = new Nettention.Proud.BeforeRmiSummary();
        summary.rmiID = Common.OnGameActionObject;
        summary.rmiName = RmiName_OnGameActionObject;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        BeforeRmiInvocation(summary);
        }

        long t0 = Nettention.Proud.PreciseCurrentTime.GetTimeMs();

        // Call this method.
        bool __ret =OnGameActionObject (remote,ctx , room, data );

        if(__ret==false)
        {
        // Error: RMI function that a user did not create has been called. 
        core.ShowNotImplementedRmiWarning(RmiName_OnGameActionObject);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.AfterRmiSummary summary = new Nettention.Proud.AfterRmiSummary();
        summary.rmiID = Common.OnGameActionObject;
        summary.rmiName = RmiName_OnGameActionObject;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        summary.elapsedTime = Nettention.Proud.PreciseCurrentTime.GetTimeMs()-t0;
        AfterRmiInvocation(summary);
        }
    }
    void ProcessReceivedMessage_OnGameActionItem(Nettention.Proud.Message __msg, Nettention.Proud.ReceivedMessage pa, Object hostTag, Nettention.Proud.HostID remote)
    {
        Nettention.Proud.RmiContext ctx = new Nettention.Proud.RmiContext();
        ctx.sentFrom=pa.RemoteHostID;
        ctx.relayed=pa.IsRelayed;
        ctx.hostTag=hostTag;
        ctx.encryptMode = pa.EncryptMode;
        ctx.compressMode = pa.CompressMode;

        int room; Nettention.Proud.Marshaler.Read(__msg,out room);	
String data; Nettention.Proud.Marshaler.Read(__msg,out data);	
core.PostCheckReadMessage(__msg, RmiName_OnGameActionItem);
        if(enableNotifyCallFromStub==true)
        {
        string parameterString = "";
        parameterString+=room.ToString()+",";
parameterString+=data.ToString()+",";
        NotifyCallFromStub(Common.OnGameActionItem, RmiName_OnGameActionItem,parameterString);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.BeforeRmiSummary summary = new Nettention.Proud.BeforeRmiSummary();
        summary.rmiID = Common.OnGameActionItem;
        summary.rmiName = RmiName_OnGameActionItem;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        BeforeRmiInvocation(summary);
        }

        long t0 = Nettention.Proud.PreciseCurrentTime.GetTimeMs();

        // Call this method.
        bool __ret =OnGameActionItem (remote,ctx , room, data );

        if(__ret==false)
        {
        // Error: RMI function that a user did not create has been called. 
        core.ShowNotImplementedRmiWarning(RmiName_OnGameActionItem);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.AfterRmiSummary summary = new Nettention.Proud.AfterRmiSummary();
        summary.rmiID = Common.OnGameActionItem;
        summary.rmiName = RmiName_OnGameActionItem;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        summary.elapsedTime = Nettention.Proud.PreciseCurrentTime.GetTimeMs()-t0;
        AfterRmiInvocation(summary);
        }
    }
    void ProcessReceivedMessage_OnGameUserMove(Nettention.Proud.Message __msg, Nettention.Proud.ReceivedMessage pa, Object hostTag, Nettention.Proud.HostID remote)
    {
        Nettention.Proud.RmiContext ctx = new Nettention.Proud.RmiContext();
        ctx.sentFrom=pa.RemoteHostID;
        ctx.relayed=pa.IsRelayed;
        ctx.hostTag=hostTag;
        ctx.encryptMode = pa.EncryptMode;
        ctx.compressMode = pa.CompressMode;

        int room; Nettention.Proud.Marshaler.Read(__msg,out room);	
String data; Nettention.Proud.Marshaler.Read(__msg,out data);	
core.PostCheckReadMessage(__msg, RmiName_OnGameUserMove);
        if(enableNotifyCallFromStub==true)
        {
        string parameterString = "";
        parameterString+=room.ToString()+",";
parameterString+=data.ToString()+",";
        NotifyCallFromStub(Common.OnGameUserMove, RmiName_OnGameUserMove,parameterString);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.BeforeRmiSummary summary = new Nettention.Proud.BeforeRmiSummary();
        summary.rmiID = Common.OnGameUserMove;
        summary.rmiName = RmiName_OnGameUserMove;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        BeforeRmiInvocation(summary);
        }

        long t0 = Nettention.Proud.PreciseCurrentTime.GetTimeMs();

        // Call this method.
        bool __ret =OnGameUserMove (remote,ctx , room, data );

        if(__ret==false)
        {
        // Error: RMI function that a user did not create has been called. 
        core.ShowNotImplementedRmiWarning(RmiName_OnGameUserMove);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.AfterRmiSummary summary = new Nettention.Proud.AfterRmiSummary();
        summary.rmiID = Common.OnGameUserMove;
        summary.rmiName = RmiName_OnGameUserMove;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        summary.elapsedTime = Nettention.Proud.PreciseCurrentTime.GetTimeMs()-t0;
        AfterRmiInvocation(summary);
        }
    }
    void ProcessReceivedMessage_OnGameUserSync(Nettention.Proud.Message __msg, Nettention.Proud.ReceivedMessage pa, Object hostTag, Nettention.Proud.HostID remote)
    {
        Nettention.Proud.RmiContext ctx = new Nettention.Proud.RmiContext();
        ctx.sentFrom=pa.RemoteHostID;
        ctx.relayed=pa.IsRelayed;
        ctx.hostTag=hostTag;
        ctx.encryptMode = pa.EncryptMode;
        ctx.compressMode = pa.CompressMode;

        int room; Nettention.Proud.Marshaler.Read(__msg,out room);	
String data; Nettention.Proud.Marshaler.Read(__msg,out data);	
core.PostCheckReadMessage(__msg, RmiName_OnGameUserSync);
        if(enableNotifyCallFromStub==true)
        {
        string parameterString = "";
        parameterString+=room.ToString()+",";
parameterString+=data.ToString()+",";
        NotifyCallFromStub(Common.OnGameUserSync, RmiName_OnGameUserSync,parameterString);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.BeforeRmiSummary summary = new Nettention.Proud.BeforeRmiSummary();
        summary.rmiID = Common.OnGameUserSync;
        summary.rmiName = RmiName_OnGameUserSync;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        BeforeRmiInvocation(summary);
        }

        long t0 = Nettention.Proud.PreciseCurrentTime.GetTimeMs();

        // Call this method.
        bool __ret =OnGameUserSync (remote,ctx , room, data );

        if(__ret==false)
        {
        // Error: RMI function that a user did not create has been called. 
        core.ShowNotImplementedRmiWarning(RmiName_OnGameUserSync);
        }

        if(enableStubProfiling)
        {
        Nettention.Proud.AfterRmiSummary summary = new Nettention.Proud.AfterRmiSummary();
        summary.rmiID = Common.OnGameUserSync;
        summary.rmiName = RmiName_OnGameUserSync;
        summary.hostID = remote;
        summary.hostTag = hostTag;
        summary.elapsedTime = Nettention.Proud.PreciseCurrentTime.GetTimeMs()-t0;
        AfterRmiInvocation(summary);
        }
    }
#if USE_RMI_NAME_STRING
// RMI name declaration.
// It is the unique pointer that indicates RMI name such as RMI profiler.
public const string RmiName_OnLoginRequest="OnLoginRequest";
public const string RmiName_OnStatusRequest="OnStatusRequest";
public const string RmiName_OnSystemRequest="OnSystemRequest";
public const string RmiName_OnGameQueueRequest="OnGameQueueRequest";
public const string RmiName_OnGameInfoRequest="OnGameInfoRequest";
public const string RmiName_OnGameActionReady="OnGameActionReady";
public const string RmiName_OnGameActionDamage="OnGameActionDamage";
public const string RmiName_OnGameActionObject="OnGameActionObject";
public const string RmiName_OnGameActionItem="OnGameActionItem";
public const string RmiName_OnGameUserMove="OnGameUserMove";
public const string RmiName_OnGameUserSync="OnGameUserSync";
       
public const string RmiName_First = RmiName_OnLoginRequest;
#else
// RMI name declaration.
// It is the unique pointer that indicates RMI name such as RMI profiler.
public const string RmiName_OnLoginRequest="";
public const string RmiName_OnStatusRequest="";
public const string RmiName_OnSystemRequest="";
public const string RmiName_OnGameQueueRequest="";
public const string RmiName_OnGameInfoRequest="";
public const string RmiName_OnGameActionReady="";
public const string RmiName_OnGameActionDamage="";
public const string RmiName_OnGameActionObject="";
public const string RmiName_OnGameActionItem="";
public const string RmiName_OnGameUserMove="";
public const string RmiName_OnGameUserSync="";
       
public const string RmiName_First = "";
#endif
		public override Nettention.Proud.RmiID[] GetRmiIDList { get{return Common.RmiIDList;} }
		
	}
}

