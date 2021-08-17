// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.RTCAudio
{
	/// <summary>
	/// This struct is passed in with a call to <see cref="RTCAudioInterface.AddNotifyAudioBeforeRender" /> registered event.
	/// </summary>
	public class AudioBeforeRenderCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// Client-specified data passed into <see cref="RTCAudioInterface.AddNotifyAudioBeforeRender" />.
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
		/// Audio buffer.
		/// If bUnmixedAudio was set to true when setting the notifications (aka: you get buffers per participant), then you should
		/// not modify this buffer.
		/// </summary>
		public AudioBuffer Buffer { get; private set; }

		/// <summary>
		/// The Product User ID of the participant if bUnmixedAudio was set to true when setting the notifications, or empty if
		/// bUnmixedAudio was set to false and thus the buffer is the mixed audio of all participants
		/// </summary>
		public ProductUserId ParticipantId { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(AudioBeforeRenderCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ClientData = other.Value.ClientData;
				LocalUserId = other.Value.LocalUserId;
				RoomName = other.Value.RoomName;
				Buffer = other.Value.Buffer;
				ParticipantId = other.Value.ParticipantId;
			}
		}

		public void Set(object other)
		{
			Set(other as AudioBeforeRenderCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AudioBeforeRenderCallbackInfoInternal : ICallbackInfoInternal
	{
		private System.IntPtr m_ClientData;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_RoomName;
		private System.IntPtr m_Buffer;
		private System.IntPtr m_ParticipantId;

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

		public AudioBuffer Buffer
		{
			get
			{
				AudioBuffer value;
				Helper.TryMarshalGet<AudioBufferInternal, AudioBuffer>(m_Buffer, out value);
				return value;
			}
		}

		public ProductUserId ParticipantId
		{
			get
			{
				ProductUserId value;
				Helper.TryMarshalGet(m_ParticipantId, out value);
				return value;
			}
		}
	}
}