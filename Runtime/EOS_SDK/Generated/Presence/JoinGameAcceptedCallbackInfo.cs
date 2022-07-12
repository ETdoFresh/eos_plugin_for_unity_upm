// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Presence
{
	/// <summary>
	/// Output parameters for the <see cref="OnJoinGameAcceptedCallback" /> Function.
	/// </summary>
	public class JoinGameAcceptedCallbackInfo : ICallbackInfo, ISettable
	{
		/// <summary>
		/// Context that was passed into <see cref="PresenceInterface.AddNotifyJoinGameAccepted" />
		/// </summary>
		public object ClientData { get; private set; }

		/// <summary>
		/// The Join Info custom game-data string to use to join the target user.
		/// Set to a null pointer to delete the value.
		/// </summary>
		public string JoinInfo { get; private set; }

		/// <summary>
		/// The Epic Account ID of the user who accepted the invitation
		/// </summary>
		public EpicAccountId LocalUserId { get; private set; }

		/// <summary>
		/// The Epic Account ID of the user who sent the invitation
		/// </summary>
		public EpicAccountId TargetUserId { get; private set; }

		/// <summary>
		/// If the value is not <see cref="UI.UIInterface.EventidInvalid" /> then it must be passed back to the SDK using <see cref="UI.UIInterface.AcknowledgeEventId" />.
		/// This should be done after attempting to join the game and either succeeding or failing to connect.
		/// This is necessary to allow the Social Overlay UI to manage the `Join` button.
		/// </summary>
		public ulong UiEventId { get; private set; }

		public Result? GetResultCode()
		{
			return null;
		}

		internal void Set(JoinGameAcceptedCallbackInfoInternal? other)
		{
			if (other != null)
			{
				ClientData = other.Value.ClientData;
				JoinInfo = other.Value.JoinInfo;
				LocalUserId = other.Value.LocalUserId;
				TargetUserId = other.Value.TargetUserId;
				UiEventId = other.Value.UiEventId;
			}
		}

		public void Set(object other)
		{
			Set(other as JoinGameAcceptedCallbackInfoInternal?);
		}
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct JoinGameAcceptedCallbackInfoInternal : ICallbackInfoInternal
	{
		private System.IntPtr m_ClientData;
		private System.IntPtr m_JoinInfo;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_TargetUserId;
		private ulong m_UiEventId;

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

		public string JoinInfo
		{
			get
			{
				string value;
				Helper.TryMarshalGet(m_JoinInfo, out value);
				return value;
			}
		}

		public EpicAccountId LocalUserId
		{
			get
			{
				EpicAccountId value;
				Helper.TryMarshalGet(m_LocalUserId, out value);
				return value;
			}
		}

		public EpicAccountId TargetUserId
		{
			get
			{
				EpicAccountId value;
				Helper.TryMarshalGet(m_TargetUserId, out value);
				return value;
			}
		}

		public ulong UiEventId
		{
			get
			{
				return m_UiEventId;
			}
		}
	}
}