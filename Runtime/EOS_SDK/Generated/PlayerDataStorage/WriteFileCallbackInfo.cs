// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.PlayerDataStorage
{
	/// <summary>
	/// The result information for a request to write data to a file
	/// </summary>
	public class WriteFileCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// Result code for the operation. <see cref="Result.Success" /> is returned for a successful request, other codes indicate an error
		/// </summary>
		public Result ResultCode { get; private set; }

		/// <summary>
		/// Client-specified data passed into the file write request
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The Product User ID of the local user who initiated this request
		/// </summary>
		public ProductUserId LocalUserId { get; private set; }

		/// <summary>
		/// The file name that is being written to
		/// </summary>
		public string Filename { get; private set; }

		public Result? GetResultCode()
		{
			return ResultCode;
		}

		internal void Set(WriteFileCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ResultCode = other.Value.ResultCode;
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				Filename = other.Value.Filename;
			}
		}

		public void Set(object other)
		{
			Set(other as WriteFileCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct WriteFileCallbackInfoInternal : ICallbackInfoInternal
	{
		private Result m_ResultCode;
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_Filename;

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

		public string Filename
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_Filename, out value);
				return value;
			}
		}
	}
}