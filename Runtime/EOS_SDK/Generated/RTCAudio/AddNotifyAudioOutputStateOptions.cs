// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.RTCAudio
{
	/// <summary>
	/// This struct is used to call <see cref="RTCAudioInterface.AddNotifyAudioOutputState" />.
	/// </summary>
	public class AddNotifyAudioOutputStateOptions
	{
		/// <summary>
		/// The Product User ID of the user trying to request this operation.
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The room this event is registered on.
		/// </summary>
		public string RoomName { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AddNotifyAudioOutputStateOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_RoomName;

		public ProductUserId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public string RoomName
		{
			set
			{
				Helper.TryMarshalSet(ref m_RoomName, value);
			}
		}

		public void Set(AddNotifyAudioOutputStateOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = RTCAudioInterface.AddnotifyaudiooutputstateApiLatest;
				LocalUserId = other.LocalUserId;
				RoomName = other.RoomName;
			}
		}

		public void Set(object other)
		{
			Set(other as AddNotifyAudioOutputStateOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_RoomName);
		}
	}
}