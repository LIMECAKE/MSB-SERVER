﻿




// Generated by PIDL compiler.
// Do not modify this file, but modify the source .pidl file.

using System;

namespace MSBC2S
{
	internal class Proxy:Nettention.Proud.RmiProxy
	{
public bool OnLoginRequest(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.OnLoginRequest;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, data);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_OnLoginRequest, Common.OnLoginRequest);
}

public bool OnLoginRequest(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.OnLoginRequest;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, data);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_OnLoginRequest, Common.OnLoginRequest);
}
public bool OnStatusRequest(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.OnStatusRequest;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, data);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_OnStatusRequest, Common.OnStatusRequest);
}

public bool OnStatusRequest(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.OnStatusRequest;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, data);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_OnStatusRequest, Common.OnStatusRequest);
}
public bool OnSystemRequest(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.OnSystemRequest;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, data);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_OnSystemRequest, Common.OnSystemRequest);
}

public bool OnSystemRequest(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.OnSystemRequest;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, data);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_OnSystemRequest, Common.OnSystemRequest);
}
public bool OnGameQueueRequest(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.OnGameQueueRequest;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, data);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_OnGameQueueRequest, Common.OnGameQueueRequest);
}

public bool OnGameQueueRequest(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.OnGameQueueRequest;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, data);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_OnGameQueueRequest, Common.OnGameQueueRequest);
}
public bool OnGameInfoRequest(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.OnGameInfoRequest;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, room);
		Nettention.Proud.Marshaler.Write(__msg, data);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_OnGameInfoRequest, Common.OnGameInfoRequest);
}

public bool OnGameInfoRequest(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int room, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.OnGameInfoRequest;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, room);
Nettention.Proud.Marshaler.Write(__msg, data);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_OnGameInfoRequest, Common.OnGameInfoRequest);
}
public bool OnGameActionReady(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.OnGameActionReady;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, room);
		Nettention.Proud.Marshaler.Write(__msg, data);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_OnGameActionReady, Common.OnGameActionReady);
}

public bool OnGameActionReady(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int room, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.OnGameActionReady;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, room);
Nettention.Proud.Marshaler.Write(__msg, data);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_OnGameActionReady, Common.OnGameActionReady);
}
public bool OnGameActionDamage(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.OnGameActionDamage;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, room);
		Nettention.Proud.Marshaler.Write(__msg, data);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_OnGameActionDamage, Common.OnGameActionDamage);
}

public bool OnGameActionDamage(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int room, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.OnGameActionDamage;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, room);
Nettention.Proud.Marshaler.Write(__msg, data);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_OnGameActionDamage, Common.OnGameActionDamage);
}
public bool OnGameActionObject(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.OnGameActionObject;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, room);
		Nettention.Proud.Marshaler.Write(__msg, data);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_OnGameActionObject, Common.OnGameActionObject);
}

public bool OnGameActionObject(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int room, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.OnGameActionObject;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, room);
Nettention.Proud.Marshaler.Write(__msg, data);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_OnGameActionObject, Common.OnGameActionObject);
}
public bool OnGameActionItem(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.OnGameActionItem;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, room);
		Nettention.Proud.Marshaler.Write(__msg, data);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_OnGameActionItem, Common.OnGameActionItem);
}

public bool OnGameActionItem(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int room, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.OnGameActionItem;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, room);
Nettention.Proud.Marshaler.Write(__msg, data);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_OnGameActionItem, Common.OnGameActionItem);
}
public bool OnGameUserMove(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.OnGameUserMove;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, room);
		Nettention.Proud.Marshaler.Write(__msg, data);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_OnGameUserMove, Common.OnGameUserMove);
}

public bool OnGameUserMove(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int room, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.OnGameUserMove;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, room);
Nettention.Proud.Marshaler.Write(__msg, data);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_OnGameUserMove, Common.OnGameUserMove);
}
public bool OnGameUserSync(Nettention.Proud.HostID remote,Nettention.Proud.RmiContext rmiContext, int room, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
		__msg.SimplePacketMode = core.IsSimplePacketMode();
		Nettention.Proud.RmiID __msgid= Common.OnGameUserSync;
		__msg.Write(__msgid);
		Nettention.Proud.Marshaler.Write(__msg, room);
		Nettention.Proud.Marshaler.Write(__msg, data);
		
	Nettention.Proud.HostID[] __list = new Nettention.Proud.HostID[1];
	__list[0] = remote;
		
	return RmiSend(__list,rmiContext,__msg,
		RmiName_OnGameUserSync, Common.OnGameUserSync);
}

public bool OnGameUserSync(Nettention.Proud.HostID[] remotes,Nettention.Proud.RmiContext rmiContext, int room, String data)
{
	Nettention.Proud.Message __msg=new Nettention.Proud.Message();
__msg.SimplePacketMode = core.IsSimplePacketMode();
Nettention.Proud.RmiID __msgid= Common.OnGameUserSync;
__msg.Write(__msgid);
Nettention.Proud.Marshaler.Write(__msg, room);
Nettention.Proud.Marshaler.Write(__msg, data);
		
	return RmiSend(remotes,rmiContext,__msg,
		RmiName_OnGameUserSync, Common.OnGameUserSync);
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
		public override Nettention.Proud.RmiID[] GetRmiIDList() { return Common.RmiIDList; } 
	}
}
