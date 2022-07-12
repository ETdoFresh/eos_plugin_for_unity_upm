// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Input parameters for the <see cref="EcomInterface.GetOfferItemCount" /> function.
	/// </summary>
	public class GetOfferItemCountOptions
	{
		/// <summary>
		/// The Epic Account ID of the local user who made the initial request for the Catalog Offer through <see cref="EcomInterface.QueryOffers" />
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// An ID that corresponds to a cached Catalog Offer (retrieved by <see cref="EcomInterface.CopyOfferByIndex" />)
		/// </summary>
		public string OfferId { get; set; }
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct GetOfferItemCountOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;
		private System.IntPtr m_LocalUserId;
		private System.IntPtr m_OfferId;

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

		public void Set(GetOfferItemCountOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = EcomInterface.GetofferitemcountApiLatest;
				LocalUserId = other.LocalUserId;
				OfferId = other.OfferId;
			}
		}

		public void Set(object other)
		{
			Set(other as GetOfferItemCountOptions);
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_LocalUserId);
			Helper.TryMarshalDispose(ref m_OfferId);
		}
	}
}