// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Output parameters for the <see cref="SessionsInterface.QueryInvites" /> function.
	/// </summary>
	public class QueryInvitesCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// The <see cref="Result" /> code for the operation. <see cref="Result.Success" /> indicates that the operation succeeded; other codes indicate errors.
		/// </summary>
		public Result ResultCode { get; private set; }

		/// <summary>
		/// Context that was passed into <see cref="SessionsInterface.QueryInvites" />
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The Product User of the local user who made the request
		/// </summary>
		public ProductUserId LocalUserId { get; private set; }

		public Result? GetResultCode()
		{
			return ResultCode;
		}

		internal void Set(QueryInvitesCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ResultCode = other.Value.ResultCode;
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
			}
		}

		public void Set(object other)
		{
			Set(other as QueryInvitesCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct QueryInvitesCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;

		public Result ResultCode
		{
			get
			{
				return m_ResultCode;
			}
		}

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

		public ProductUserId LocalUserId
		{
			get
			{
				ProductUserId value;
				Helper.TryMarshalGet(m_LocalUserId, out value);
				return value;
			}
		}
	}
}