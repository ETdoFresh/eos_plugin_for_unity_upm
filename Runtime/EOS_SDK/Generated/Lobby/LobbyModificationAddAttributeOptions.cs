// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Input parameters for the <see cref="LobbyModification.AddAttribute" /> function.
	/// </summary>
	public class LobbyModificationAddAttributeOptions
	{
		/// <summary>
		/// Key/Value pair describing the attribute to add to the lobby
		/// </summary>
		public AttributeData Attribute { get; set; }

		/// <summary>
		/// Is this attribute public or private to the lobby and its members
		/// </summary>
		public LobbyAttributeVisibility Visibility { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct LobbyModificationAddAttributeOptionsInternal : ISettable, System.IDisposable
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

		public void Set(LobbyModificationAddAttributeOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = LobbyModification.LobbymodificationAddattributeApiLatest;
				Attribute = other.Attribute;
				Visibility = other.Visibility;
			}
		}

		public void Set(object other)
		{
			Set(other as LobbyModificationAddAttributeOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_Attribute);
		}
	}
}