// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Input parameters for the <see cref="EcomInterface.CopyOfferItemByIndex" /> function.
	/// </summary>
	public class CopyOfferItemByIndexOptions
	{
		/// <summary>
		/// The Epic Online Services Account ID of the local user whose item is being copied
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The ID of the offer to get the items for.
		/// </summary>
		public string OfferId { get; set; }

		/// <summary>
		/// The index of the item to get.
		/// </summary>
		public uint ItemIndex { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct CopyOfferItemByIndexOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_OfferId;
		private uint m_ItemIndex;

		public EpicAccountId LocalUserId
		{
			set
			{
				Helper.TryMarshalSet(ref m_LocalUserId, value);
			}
		}

		public string OfferId
		{
			set
			{
				Helper.TryMarshalSet(ref m_OfferId, value);
			}
		}

		public uint ItemIndex
		{
			set
			{
				m_ItemIndex = value;
			}
		}

		public void Set(CopyOfferItemByIndexOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = EcomInterface.CopyofferitembyindexApiLatest;
				LocalUserId = other.LocalUserId;
				OfferId = other.OfferId;
				ItemIndex = other.ItemIndex;
			}
		}

		public void Set(object other)
		{
			Set(other as CopyOfferItemByIndexOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_OfferId);
		}
	}
}