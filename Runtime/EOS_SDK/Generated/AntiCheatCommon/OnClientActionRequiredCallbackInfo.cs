// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatCommon
{
	/// <summary>
	/// Structure containing details about a required client/peer action
	/// </summary>
	public class OnClientActionRequiredCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// Caller-specified context data
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The identifier of the client/peer that this action applies to. See the RegisterClient and RegisterPeer functions.
		/// </summary>
		public System.IntPtr ClientHandle { get; private set; }

		/// <summary>
		/// The action that must be applied to the specified client/peer
		/// </summary>
		public AntiCheatCommonClientAction ClientAction { get; private set; }

		/// <summary>
		/// Code indicating the reason for the action
		/// </summary>
		public AntiCheatCommonClientActionReason ActionReasonCode { get; private set; }

		/// <summary>
		/// String containing details about the action reason
		/// </summary>
		public string ActionReasonDetailsString { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(OnClientActionRequiredCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ClientData = other.Value.ClientData;
				ClientHandle = other.Value.ClientHandle;
				ClientAction = other.Value.ClientAction;
				ActionReasonCode = other.Value.ActionReasonCode;
				ActionReasonDetailsString = other.Value.ActionReasonDetailsString;
			}
		}

		public void Set(object other)
		{
			Set(other as OnClientActionRequiredCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct OnClientActionRequiredCallbackInfoInternal : ICallbackInfoInternal
	{
		private System.IntPtr m_ClientData;
		private System.IntPtr m_ClientHandle;
		private AntiCheatCommonClientAction m_ClientAction;
		private AntiCheatCommonClientActionReason m_ActionReasonCode;
		private System.IntPtr m_ActionReasonDetailsString;

		public object ClientData
		{
			get
			{
				object value;
				Helper.TryMarshalGet(m_ClientData, out value);
				return value;
			}
		}

		public System.IntPtr ClientDataAddress
		{
			get
			{
				return m_ClientData;
			}
		}

		public System.IntPtr ClientHandle
		{
			get
			{
				return m_ClientHandle;
			}
		}

		public AntiCheatCommonClientAction ClientAction
		{
			get
			{
				return m_ClientAction;
			}
		}

		public AntiCheatCommonClientActionReason ActionReasonCode
		{
			get
			{
				return m_ActionReasonCode;
			}
		}

		public string ActionReasonDetailsString
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_ActionReasonDetailsString, out value);
				return value;
			}
		}
	}
}