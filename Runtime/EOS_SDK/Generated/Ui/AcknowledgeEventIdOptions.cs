// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.UI
{
	/// <summary>
	/// Input parameters for the <see cref="UIInterface.AcknowledgeEventId" />.
	/// </summary>
	public class AcknowledgeEventIdOptions
	{
		/// <summary>
		/// The ID being acknowledged.
		/// </summary>
		public ulong UiEventId { get; set; }

		/// <summary>
		/// The result to use for the acknowledgment.
		/// When acknowledging <see cref="Presence.JoinGameAcceptedCallbackInfo" /> this should be the
		/// result code from the JoinSession call.
		/// </summary>
		public Result Result { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AcknowledgeEventIdOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private ulong m_UiEventId;
		private Result m_Result;

		public ulong UiEventId
		{
			set
			{
				m_UiEventId = value;
			}
		}

		public Result Result
		{
			set
			{
				m_Result = value;
			}
		}

		public void Set(AcknowledgeEventIdOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = UIInterface.AcknowledgeeventidApiLatest;
				UiEventId = other.UiEventId;
				Result = other.Result;
			}
		}

		public void Set(object other)
		{
			Set(other as AcknowledgeEventIdOptions);
		}

		public void Dispose()
		{
		}
	}
}