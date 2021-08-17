// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Sanctions
{
	/// <summary>
	/// Input parameters for the <see cref="SanctionsInterface.CopyPlayerSanctionByIndex" /> function
	/// </summary>
	public class CopyPlayerSanctionByIndexOptions
	{
		/// <summary>
		/// Product User ID of the user whose active sanctions are to be copied
		/// </summary>
		public ProductUserId TargetUserId { get; set; }

		/// <summary>
		/// Index of the sanction to retrieve from the cache
		/// </summary>
		public uint SanctionIndex { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct CopyPlayerSanctionByIndexOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_TargetUserId;
		private uint m_SanctionIndex;

		public ProductUserId TargetUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_TargetUserId, value);
			}
		}

		public uint SanctionIndex
		{
			set
			{
				m_SanctionIndex = value;
			}
		}

		public void Set(CopyPlayerSanctionByIndexOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = SanctionsInterface.CopyplayersanctionbyindexApiLatest;
				TargetUserId = other.TargetUserId;
				SanctionIndex = other.SanctionIndex;
			}
		}

		public void Set(object other)
		{
			Set(other as CopyPlayerSanctionByIndexOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_TargetUserId);
		}
	}
}