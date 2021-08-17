// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Input parameters for the <see cref="LobbyModification.AddMemberAttribute" /> function.
	/// </summary>
	public class LobbyModificationAddMemberAttributeOptions
	{
		/// <summary>
		/// Key/Value pair describing the attribute to add to the lobby member
		/// </summary>
		public AttributeData Attribute { get; set; }

		/// <summary>
		/// Is this attribute public or private to the rest of the lobby members
		/// </summary>
		public LobbyAttributeVisibility Visibility { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct LobbyModificationAddMemberAttributeOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_Attribute;
		private LobbyAttributeVisibility m_Visibility;

		public AttributeData Attribute
		{
			set
			{
				Helper.TryMarshalSet<AttributeDataInternal, AttributeData>(ref m_Attribute, value);
			}
		}

		public LobbyAttributeVisibility Visibility
		{
			set
			{
				m_Visibility = value;
			}
		}

		public void Set(LobbyModificationAddMemberAttributeOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = LobbyModification.LobbymodificationAddmemberattributeApiLatest;
				Attribute = other.Attribute;
				Visibility = other.Visibility;
			}
		}

		public void Set(object other)
		{
			Set(other as LobbyModificationAddMemberAttributeOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_Attribute);
		}
	}
}