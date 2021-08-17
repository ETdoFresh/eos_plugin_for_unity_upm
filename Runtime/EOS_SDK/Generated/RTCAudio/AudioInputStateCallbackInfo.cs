// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.RTCAudio
{
	/// <summary>
	/// This struct is passed in with a call to <see cref="RTCAudioInterface.AddNotifyAudioInputState" /> registered event.
	/// </summary>
	public class AudioInputStateCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// Client-specified data passed into <see cref="RTCAudioInterface.AddNotifyAudioInputState" />.
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The Product User ID of the user who initiated this request.
		/// </summary>
		public ProductUserId LocalUserId { get; private set; }

		/// <summary>
		/// The room associated with this event.
		/// </summary>
		public string RoomName { get; private set; }

		/// <summary>
		/// The status of the audio input.
		/// </summary>
		public RTCAudioInputStatus Status { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(AudioInputStateCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				RoomName = other.Value.RoomName;
				Status = other.Value.Status;
			}
		}

		public void Set(object other)
		{
			Set(other as AudioInputStateCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AudioInputStateCallbackInfoInternal : ICallbackInfoInternal
	{
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_RoomName;
		private RTCAudioInputStatus m_Status;

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

		public string RoomName
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_RoomName, out value);
				return value;
			}
		}

		public RTCAudioInputStatus Status
		{
			get
			{
				return m_Status;
			}
		}
	}
}