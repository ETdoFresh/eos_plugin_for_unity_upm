// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatClient
{
	public sealed partial class AntiCheatClientInterface : Handle
	{
		public AntiCheatClientInterface()
		{
		}

		public AntiCheatClientInterface(System.IntPtr innerHandle) : base(innerHandle)
		{
		}

		public const int AddexternalintegritycatalogApiLatest = 1;

		public const int AddnotifymessagetopeerApiLatest = 1;

		public const int AddnotifymessagetoserverApiLatest = 1;

		public const int AddnotifypeeractionrequiredApiLatest = 1;

		public const int AddnotifypeerauthstatuschangedApiLatest = 1;

		public const int BeginsessionApiLatest = 3;

		public const int EndsessionApiLatest = 1;

		public const int GetprotectmessageoutputlengthApiLatest = 1;

		/// <summary>
		/// A special peer handle that represents the client itself.
		/// It does not need to be registered or unregistered and is
		/// used in OnPeerActionRequiredCallback to quickly signal to the user
		/// that they will not be able to join online play.
		/// </summary>
		public const int PeerSelf = (-1);

		public const int PollstatusApiLatest = 1;

		public const int ProtectmessageApiLatest = 1;

		public const int ReceivemessagefrompeerApiLatest = 1;

		public const int ReceivemessagefromserverApiLatest = 1;

		public const int RegisterpeerApiLatest = 1;

		public const int UnprotectmessageApiLatest = 1;

		public const int UnregisterpeerApiLatest = 1;

		/// <summary>
		/// Optional. Adds an integrity catalog and certificate pair from outside the game directory,
		/// for example to support mods that load from elsewhere.
		/// Mode: All
		/// </summary>
		/// <param name="options">Structure containing input data.</param>
		/// <returns>
		/// <see cref="Result.Success" /> - If the integrity catalog was added successfully
		/// <see cref="Result.InvalidParameters" /> - If input data was invalid
		/// </returns>
		public Result AddExternalIntegrityCatalog(AddExternalIntegrityCatalogOptions options)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<AddExternalIntegrityCatalogOptionsInternal, AddExternalIntegrityCatalogOptions>(ref optionsAddress, options);

			var funcResult = Bindings.EOS_AntiCheatClient_AddExternalIntegrityCatalog(InnerHandle, optionsAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			return funcResult;
		}

		/// <summary>
		/// Add a callback issued when a new message must be dispatched to a connected peer. The bound function will only be called
		/// between a successful call to <see cref="BeginSession" /> and the matching <see cref="EndSession" /> call in mode <see cref="AntiCheatClientMode.PeerToPeer" />.
		/// Mode: <see cref="AntiCheatClientMode.PeerToPeer" />.
		/// </summary>
		/// <param name="options">Structure containing input data</param>
		/// <param name="clientData">This value is returned to the caller when NotificationFn is invoked</param>
		/// <param name="notificationFn">The callback to be fired</param>
		/// <returns>
		/// A valid notification ID if successfully bound, or <see cref="Common.InvalidNotificationid" /> otherwise
		/// </returns>
		public ulong AddNotifyMessageToPeer(AddNotifyMessageToPeerOptions options, object clientData, OnMessageToPeerCallback notificationFn)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<AddNotifyMessageToPeerOptionsInternal, AddNotifyMessageToPeerOptions>(ref optionsAddress, options);

			var clientDataAddress = System.IntPtr.Zero;

			var notificationFnInternal = new OnMessageToPeerCallbackInternal(OnMessageToPeerCallbackInternalImplementation);
			Helper.AddCallback(ref clientDataAddress, clientData, notificationFn, notificationFnInternal);

			var funcResult = Bindings.EOS_AntiCheatClient_AddNotifyMessageToPeer(InnerHandle, optionsAddress, clientDataAddress, notificationFnInternal);

			Helper.TryMarshalDispose(ref optionsAddress);

			Helper.TryAssignNotificationIdToCallback(clientDataAddress, funcResult);

			return funcResult;
		}

		/// <summary>
		/// Add a callback issued when a new message must be dispatched to the game server. The bound function will only be called
		/// between a successful call to <see cref="BeginSession" /> and the matching <see cref="EndSession" /> call in mode <see cref="AntiCheatClientMode.ClientServer" />.
		/// Mode: <see cref="AntiCheatClientMode.ClientServer" />.
		/// </summary>
		/// <param name="options">Structure containing input data</param>
		/// <param name="clientData">This value is returned to the caller when NotificationFn is invoked</param>
		/// <param name="notificationFn">The callback to be fired</param>
		/// <returns>
		/// A valid notification ID if successfully bound, or <see cref="Common.InvalidNotificationid" /> otherwise
		/// </returns>
		public ulong AddNotifyMessageToServer(AddNotifyMessageToServerOptions options, object clientData, OnMessageToServerCallback notificationFn)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<AddNotifyMessageToServerOptionsInternal, AddNotifyMessageToServerOptions>(ref optionsAddress, options);

			var clientDataAddress = System.IntPtr.Zero;

			var notificationFnInternal = new OnMessageToServerCallbackInternal(OnMessageToServerCallbackInternalImplementation);
			Helper.AddCallback(ref clientDataAddress, clientData, notificationFn, notificationFnInternal);

			var funcResult = Bindings.EOS_AntiCheatClient_AddNotifyMessageToServer(InnerHandle, optionsAddress, clientDataAddress, notificationFnInternal);

			Helper.TryMarshalDispose(ref optionsAddress);

			Helper.TryAssignNotificationIdToCallback(clientDataAddress, funcResult);

			return funcResult;
		}

		/// <summary>
		/// Add a callback issued when an action must be applied to a connected client. The bound function will only be called
		/// between a successful call to <see cref="BeginSession" /> and the matching <see cref="EndSession" /> call in mode <see cref="AntiCheatClientMode.PeerToPeer" />.
		/// Mode: <see cref="AntiCheatClientMode.PeerToPeer" />.
		/// </summary>
		/// <param name="options">Structure containing input data</param>
		/// <param name="clientData">This value is returned to the caller when NotificationFn is invoked</param>
		/// <param name="notificationFn">The callback to be fired</param>
		/// <returns>
		/// A valid notification ID if successfully bound, or <see cref="Common.InvalidNotificationid" /> otherwise
		/// </returns>
		public ulong AddNotifyPeerActionRequired(AddNotifyPeerActionRequiredOptions options, object clientData, OnPeerActionRequiredCallback notificationFn)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<AddNotifyPeerActionRequiredOptionsInternal, AddNotifyPeerActionRequiredOptions>(ref optionsAddress, options);

			var clientDataAddress = System.IntPtr.Zero;

			var notificationFnInternal = new OnPeerActionRequiredCallbackInternal(OnPeerActionRequiredCallbackInternalImplementation);
			Helper.AddCallback(ref clientDataAddress, clientData, notificationFn, notificationFnInternal);

			var funcResult = Bindings.EOS_AntiCheatClient_AddNotifyPeerActionRequired(InnerHandle, optionsAddress, clientDataAddress, notificationFnInternal);

			Helper.TryMarshalDispose(ref optionsAddress);

			Helper.TryAssignNotificationIdToCallback(clientDataAddress, funcResult);

			return funcResult;
		}

		/// <summary>
		/// Add an optional callback issued when a connected peer's authentication status changes. The bound function will only be called
		/// between a successful call to <see cref="BeginSession" /> and the matching <see cref="EndSession" /> call in mode <see cref="AntiCheatClientMode.PeerToPeer" />.
		/// Mode: <see cref="AntiCheatClientMode.PeerToPeer" />.
		/// </summary>
		/// <param name="options">Structure containing input data</param>
		/// <param name="clientData">This value is returned to the caller when NotificationFn is invoked</param>
		/// <param name="notificationFn">The callback to be fired</param>
		/// <returns>
		/// A valid notification ID if successfully bound, or <see cref="Common.InvalidNotificationid" /> otherwise
		/// </returns>
		public ulong AddNotifyPeerAuthStatusChanged(AddNotifyPeerAuthStatusChangedOptions options, object clientData, OnPeerAuthStatusChangedCallback notificationFn)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<AddNotifyPeerAuthStatusChangedOptionsInternal, AddNotifyPeerAuthStatusChangedOptions>(ref optionsAddress, options);

			var clientDataAddress = System.IntPtr.Zero;

			var notificationFnInternal = new OnPeerAuthStatusChangedCallbackInternal(OnPeerAuthStatusChangedCallbackInternalImplementation);
			Helper.AddCallback(ref clientDataAddress, clientData, notificationFn, notificationFnInternal);

			var funcResult = Bindings.EOS_AntiCheatClient_AddNotifyPeerAuthStatusChanged(InnerHandle, optionsAddress, clientDataAddress, notificationFnInternal);

			Helper.TryMarshalDispose(ref optionsAddress);

			Helper.TryAssignNotificationIdToCallback(clientDataAddress, funcResult);

			return funcResult;
		}

		/// <summary>
		/// Begins a multiplayer game session. After this call returns successfully, the client is ready to exchange
		/// anti-cheat messages with a game server or peer(s). When leaving one game session and connecting to a
		/// different one, a new anti-cheat session must be created by calling <see cref="EndSession" /> and <see cref="BeginSession" /> again.
		/// Mode: All
		/// </summary>
		/// <param name="options">Structure containing input data.</param>
		/// <returns>
		/// <see cref="Result.Success" /> - If the session was started successfully
		/// <see cref="Result.InvalidParameters" /> - If input data was invalid
		/// <see cref="Result.AntiCheatInvalidMode" /> - If the current mode does not support this function
		/// </returns>
		public Result BeginSession(BeginSessionOptions options)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<BeginSessionOptionsInternal, BeginSessionOptions>(ref optionsAddress, options);

			var funcResult = Bindings.EOS_AntiCheatClient_BeginSession(InnerHandle, optionsAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			return funcResult;
		}

		/// <summary>
		/// Ends a multiplayer game session, either by leaving an ongoing session or shutting it down entirely.
		/// Mode: All
		/// 
		/// Must be called when the multiplayer session ends, or when the local user leaves a session in progress.
		/// </summary>
		/// <param name="options">Structure containing input data.</param>
		/// <returns>
		/// <see cref="Result.Success" /> - If the session was ended normally
		/// <see cref="Result.InvalidParameters" /> - If input data was invalid
		/// <see cref="Result.AntiCheatInvalidMode" /> - If the current mode does not support this function
		/// </returns>
		public Result EndSession(EndSessionOptions options)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<EndSessionOptionsInternal, EndSessionOptions>(ref optionsAddress, options);

			var funcResult = Bindings.EOS_AntiCheatClient_EndSession(InnerHandle, optionsAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			return funcResult;
		}

		/// <summary>
		/// Optional NetProtect feature for game message encryption.
		/// Calculates the required decrypted buffer size for a given input data length.
		/// This will not change for a given SDK version, and allows one time allocation of reusable buffers.
		/// Mode: <see cref="AntiCheatClientMode.ClientServer" />.
		/// </summary>
		/// <param name="options">Structure containing input data.</param>
		/// <param name="outBufferLengthBytes">The length in bytes that is required to call ProtectMessage on the given input size.</param>
		/// <returns>
		/// <see cref="Result.Success" /> - If the output length was calculated successfully
		/// <see cref="Result.InvalidParameters" /> - If input data was invalid
		/// <see cref="Result.AntiCheatInvalidMode" /> - If the current mode does not support this function
		/// </returns>
		public Result GetProtectMessageOutputLength(GetProtectMessageOutputLengthOptions options, out uint outBufferLengthBytes)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<GetProtectMessageOutputLengthOptionsInternal, GetProtectMessageOutputLengthOptions>(ref optionsAddress, options);

			outBufferLengthBytes = Helper.GetDefault<uint>();

			var funcResult = Bindings.EOS_AntiCheatClient_GetProtectMessageOutputLength(InnerHandle, optionsAddress, ref outBufferLengthBytes);

			Helper.TryMarshalDispose(ref optionsAddress);

			return funcResult;
		}

		/// <summary>
		/// Polls for changes in client integrity status.
		/// Mode: All
		/// 
		/// The purpose of this function is to allow the game to display information
		/// about anti-cheat integrity problems to the user. These are often the result of a
		/// corrupt game installation rather than cheating attempts. This function does not
		/// check for violations, it only provides information about violations which have
		/// automatically been discovered by the anti-cheat client. Such a violation may occur
		/// at any time and afterwards the user will be unable to join any protected multiplayer
		/// session until after restarting the game.
		/// </summary>
		/// <param name="options">Structure containing input data.</param>
		/// <param name="violationType">On success, receives a code describing the violation that occurred.</param>
		/// <param name="outMessage">On success, receives a string describing the violation which should be displayed to the user.</param>
		/// <returns>
		/// <see cref="Result.Success" /> - If violation information was returned successfully
		/// <see cref="Result.LimitExceeded" /> - If OutMessage is too small to receive the message string. Call again with a larger OutMessage.
		/// <see cref="Result.NotFound" /> - If no violation has occurred since the last call
		/// </returns>
		public Result PollStatus(PollStatusOptions options, AntiCheatClientViolationType violationType, out string outMessage)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<PollStatusOptionsInternal, PollStatusOptions>(ref optionsAddress, options);

			System.IntPtr outMessageAddress = System.IntPtr.Zero;
			uint OutMessageLength = options.OutMessageLength;
			Helper.TryMarshalAllocate(ref outMessageAddress, OutMessageLength);

			var funcResult = Bindings.EOS_AntiCheatClient_PollStatus(InnerHandle, optionsAddress, violationType, outMessageAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			Helper.TryMarshalGet(outMessageAddress, out outMessage);
			Helper.TryMarshalDispose(ref outMessageAddress);

			return funcResult;
		}

		/// <summary>
		/// Optional NetProtect feature for game message encryption.
		/// Encrypts an arbitrary message that will be sent to the game server and decrypted on the other side.
		/// Mode: <see cref="AntiCheatClientMode.ClientServer" />.
		/// 
		/// Options.Data and OutBuffer may refer to the same buffer to encrypt in place.
		/// </summary>
		/// <param name="options">Structure containing input data.</param>
		/// <param name="outBuffer">On success, buffer where encrypted message data will be written.</param>
		/// <param name="outBufferLengthBytes">Number of bytes that were written to OutBuffer.</param>
		/// <returns>
		/// <see cref="Result.Success" /> - If the message was protected successfully
		/// <see cref="Result.InvalidParameters" /> - If input data was invalid
		/// <see cref="Result.AntiCheatInvalidMode" /> - If the current mode does not support this function
		/// </returns>
		public Result ProtectMessage(ProtectMessageOptions options, out byte[] outBuffer)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<ProtectMessageOptionsInternal, ProtectMessageOptions>(ref optionsAddress, options);

			System.IntPtr outBufferAddress = System.IntPtr.Zero;
			uint outBufferLengthBytes = options.OutBufferSizeBytes;
			Helper.TryMarshalAllocate(ref outBufferAddress, outBufferLengthBytes);

			var funcResult = Bindings.EOS_AntiCheatClient_ProtectMessage(InnerHandle, optionsAddress, outBufferAddress, ref outBufferLengthBytes);

			Helper.TryMarshalDispose(ref optionsAddress);

			Helper.TryMarshalGet(outBufferAddress, out outBuffer, outBufferLengthBytes);
			Helper.TryMarshalDispose(ref outBufferAddress);

			return funcResult;
		}

		/// <summary>
		/// Call when an anti-cheat message is received from a peer.
		/// Mode: <see cref="AntiCheatClientMode.PeerToPeer" />.
		/// </summary>
		/// <param name="options">Structure containing input data.</param>
		/// <returns>
		/// <see cref="Result.Success" /> - If the message was processed successfully
		/// <see cref="Result.InvalidParameters" /> - If input data was invalid
		/// <see cref="Result.AntiCheatInvalidMode" /> - If the current mode does not support this function
		/// </returns>
		public Result ReceiveMessageFromPeer(ReceiveMessageFromPeerOptions options)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<ReceiveMessageFromPeerOptionsInternal, ReceiveMessageFromPeerOptions>(ref optionsAddress, options);

			var funcResult = Bindings.EOS_AntiCheatClient_ReceiveMessageFromPeer(InnerHandle, optionsAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			return funcResult;
		}

		/// <summary>
		/// Call when an anti-cheat message is received from the game server.
		/// Mode: <see cref="AntiCheatClientMode.ClientServer" />.
		/// </summary>
		/// <param name="options">Structure containing input data.</param>
		/// <returns>
		/// <see cref="Result.Success" /> - If the message was processed successfully
		/// <see cref="Result.InvalidParameters" /> - If input data was invalid
		/// <see cref="Result.AntiCheatInvalidMode" /> - If the current mode does not support this function
		/// </returns>
		public Result ReceiveMessageFromServer(ReceiveMessageFromServerOptions options)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<ReceiveMessageFromServerOptionsInternal, ReceiveMessageFromServerOptions>(ref optionsAddress, options);

			var funcResult = Bindings.EOS_AntiCheatClient_ReceiveMessageFromServer(InnerHandle, optionsAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			return funcResult;
		}

		/// <summary>
		/// Registers a connected peer-to-peer client.
		/// Mode: <see cref="AntiCheatClientMode.PeerToPeer" />.
		/// 
		/// Must be paired with a call to <see cref="UnregisterPeer" /> if this user leaves the session
		/// in progress, or <see cref="EndSession" /> if the entire session is ending.
		/// </summary>
		/// <param name="options">Structure containing input data.</param>
		/// <returns>
		/// <see cref="Result.Success" /> - If the player was registered successfully
		/// <see cref="Result.InvalidParameters" /> - If input data was invalid
		/// <see cref="Result.AntiCheatInvalidMode" /> - If the current mode does not support this function
		/// </returns>
		public Result RegisterPeer(RegisterPeerOptions options)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<RegisterPeerOptionsInternal, RegisterPeerOptions>(ref optionsAddress, options);

			var funcResult = Bindings.EOS_AntiCheatClient_RegisterPeer(InnerHandle, optionsAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			return funcResult;
		}

		/// <summary>
		/// Remove a previously bound <see cref="AddNotifyMessageToPeer" /> handler.
		/// Mode: Any.
		/// </summary>
		/// <param name="notificationId">The previously bound notification ID</param>
		public void RemoveNotifyMessageToPeer(ulong notificationId)
		{
			Helper.TryRemoveCallbackByNotificationId(notificationId);

			Bindings.EOS_AntiCheatClient_RemoveNotifyMessageToPeer(InnerHandle, notificationId);
		}

		/// <summary>
		/// Remove a previously bound <see cref="AddNotifyMessageToServer" /> handler.
		/// Mode: Any.
		/// </summary>
		/// <param name="notificationId">The previously bound notification ID</param>
		public void RemoveNotifyMessageToServer(ulong notificationId)
		{
			Helper.TryRemoveCallbackByNotificationId(notificationId);

			Bindings.EOS_AntiCheatClient_RemoveNotifyMessageToServer(InnerHandle, notificationId);
		}

		/// <summary>
		/// Remove a previously bound <see cref="AddNotifyPeerActionRequired" /> handler.
		/// Mode: Any.
		/// </summary>
		/// <param name="notificationId">The previously bound notification ID</param>
		public void RemoveNotifyPeerActionRequired(ulong notificationId)
		{
			Helper.TryRemoveCallbackByNotificationId(notificationId);

			Bindings.EOS_AntiCheatClient_RemoveNotifyPeerActionRequired(InnerHandle, notificationId);
		}

		/// <summary>
		/// Remove a previously bound <see cref="AddNotifyPeerAuthStatusChanged" /> handler.
		/// Mode: Any.
		/// </summary>
		/// <param name="notificationId">The previously bound notification ID</param>
		public void RemoveNotifyPeerAuthStatusChanged(ulong notificationId)
		{
			Helper.TryRemoveCallbackByNotificationId(notificationId);

			Bindings.EOS_AntiCheatClient_RemoveNotifyPeerAuthStatusChanged(InnerHandle, notificationId);
		}

		/// <summary>
		/// Optional NetProtect feature for game message encryption.
		/// Decrypts an encrypted message received from the game server.
		/// Mode: <see cref="AntiCheatClientMode.ClientServer" />.
		/// 
		/// Options.Data and OutBuffer may refer to the same buffer to decrypt in place.
		/// </summary>
		/// <param name="options">Structure containing input data.</param>
		/// <param name="outBuffer">On success, buffer where encrypted message data will be written.</param>
		/// <param name="outBufferLengthBytes">Number of bytes that were written to OutBuffer.</param>
		/// <returns>
		/// <see cref="Result.Success" /> - If the message was unprotected successfully
		/// <see cref="Result.InvalidParameters" /> - If input data was invalid
		/// <see cref="Result.AntiCheatInvalidMode" /> - If the current mode does not support this function
		/// </returns>
		public Result UnprotectMessage(UnprotectMessageOptions options, out byte[] outBuffer)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<UnprotectMessageOptionsInternal, UnprotectMessageOptions>(ref optionsAddress, options);

			System.IntPtr outBufferAddress = System.IntPtr.Zero;
			uint outBufferLengthBytes = options.OutBufferSizeBytes;
			Helper.TryMarshalAllocate(ref outBufferAddress, outBufferLengthBytes);

			var funcResult = Bindings.EOS_AntiCheatClient_UnprotectMessage(InnerHandle, optionsAddress, outBufferAddress, ref outBufferLengthBytes);

			Helper.TryMarshalDispose(ref optionsAddress);

			Helper.TryMarshalGet(outBufferAddress, out outBuffer, outBufferLengthBytes);
			Helper.TryMarshalDispose(ref outBufferAddress);

			return funcResult;
		}

		/// <summary>
		/// Unregisters a disconnected peer-to-peer client.
		/// Mode: <see cref="AntiCheatClientMode.PeerToPeer" />.
		/// 
		/// Must be called when a user leaves a session in progress.
		/// </summary>
		/// <param name="options">Structure containing input data.</param>
		/// <returns>
		/// <see cref="Result.Success" /> - If the player was unregistered successfully
		/// <see cref="Result.InvalidParameters" /> - If input data was invalid
		/// <see cref="Result.AntiCheatInvalidMode" /> - If the current mode does not support this function
		/// </returns>
		public Result UnregisterPeer(UnregisterPeerOptions options)
		{
			var optionsAddress = System.IntPtr.Zero;
			Helper.TryMarshalSet<UnregisterPeerOptionsInternal, UnregisterPeerOptions>(ref optionsAddress, options);

			var funcResult = Bindings.EOS_AntiCheatClient_UnregisterPeer(InnerHandle, optionsAddress);

			Helper.TryMarshalDispose(ref optionsAddress);

			return funcResult;
		}

		[MonoPInvokeCallback(typeof(OnMessageToPeerCallbackInternal))]
		internal static void OnMessageToPeerCallbackInternalImplementation(System.IntPtr data)
		{
			OnMessageToPeerCallback callback;
			AntiCheatCommon.OnMessageToClientCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback<OnMessageToPeerCallback, AntiCheatCommon.OnMessageToClientCallbackInfoInternal, AntiCheatCommon.OnMessageToClientCallbackInfo>(data, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[MonoPInvokeCallback(typeof(OnMessageToServerCallbackInternal))]
		internal static void OnMessageToServerCallbackInternalImplementation(System.IntPtr data)
		{
			OnMessageToServerCallback callback;
			OnMessageToServerCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback<OnMessageToServerCallback, OnMessageToServerCallbackInfoInternal, OnMessageToServerCallbackInfo>(data, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[MonoPInvokeCallback(typeof(OnPeerActionRequiredCallbackInternal))]
		internal static void OnPeerActionRequiredCallbackInternalImplementation(System.IntPtr data)
		{
			OnPeerActionRequiredCallback callback;
			AntiCheatCommon.OnClientActionRequiredCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback<OnPeerActionRequiredCallback, AntiCheatCommon.OnClientActionRequiredCallbackInfoInternal, AntiCheatCommon.OnClientActionRequiredCallbackInfo>(data, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[MonoPInvokeCallback(typeof(OnPeerAuthStatusChangedCallbackInternal))]
		internal static void OnPeerAuthStatusChangedCallbackInternalImplementation(System.IntPtr data)
		{
			OnPeerAuthStatusChangedCallback callback;
			AntiCheatCommon.OnClientAuthStatusChangedCallbackInfo callbackInfo;
			if (Helper.TryGetAndRemoveCallback<OnPeerAuthStatusChangedCallback, AntiCheatCommon.OnClientAuthStatusChangedCallbackInfoInternal, AntiCheatCommon.OnClientAuthStatusChangedCallbackInfo>(data, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}
	}
}