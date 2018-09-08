// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gamelibrary.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Gamelibrary {
  /// <summary>
  /// Interface exported by the server.
  /// </summary>
  public static partial class GameLibrary
  {
    static readonly string __ServiceName = "gamelibrary.GameLibrary";

    static readonly grpc::Marshaller<global::Gamelibrary.GamesSearchRequest> __Marshaller_gamelibrary_GamesSearchRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Gamelibrary.GamesSearchRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Gamelibrary.GameRecord> __Marshaller_gamelibrary_GameRecord = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Gamelibrary.GameRecord.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Gamelibrary.GameResult> __Marshaller_gamelibrary_GameResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Gamelibrary.GameResult.Parser.ParseFrom);

    static readonly grpc::Method<global::Gamelibrary.GamesSearchRequest, global::Gamelibrary.GameRecord> __Method_SearchGames = new grpc::Method<global::Gamelibrary.GamesSearchRequest, global::Gamelibrary.GameRecord>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "SearchGames",
        __Marshaller_gamelibrary_GamesSearchRequest,
        __Marshaller_gamelibrary_GameRecord);

    static readonly grpc::Method<global::Gamelibrary.GameRecord, global::Gamelibrary.GameResult> __Method_AddGame = new grpc::Method<global::Gamelibrary.GameRecord, global::Gamelibrary.GameResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddGame",
        __Marshaller_gamelibrary_GameRecord,
        __Marshaller_gamelibrary_GameResult);

    static readonly grpc::Method<global::Gamelibrary.GameRecord, global::Gamelibrary.GameResult> __Method_EditGame = new grpc::Method<global::Gamelibrary.GameRecord, global::Gamelibrary.GameResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "EditGame",
        __Marshaller_gamelibrary_GameRecord,
        __Marshaller_gamelibrary_GameResult);

    static readonly grpc::Method<global::Gamelibrary.GameRecord, global::Gamelibrary.GameResult> __Method_DeleteGame = new grpc::Method<global::Gamelibrary.GameRecord, global::Gamelibrary.GameResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteGame",
        __Marshaller_gamelibrary_GameRecord,
        __Marshaller_gamelibrary_GameResult);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Gamelibrary.GamelibraryReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GameLibrary</summary>
    public abstract partial class GameLibraryBase
    {
      /// <summary>
      /// Obtains a list of games that match the request parameters.
      /// Streamed rather than returned at once (e.g. in a response message with a repeated field)
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task SearchGames(global::Gamelibrary.GamesSearchRequest request, grpc::IServerStreamWriter<global::Gamelibrary.GameRecord> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Add a new game record
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Gamelibrary.GameResult> AddGame(global::Gamelibrary.GameRecord request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Edit a game record
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Gamelibrary.GameResult> EditGame(global::Gamelibrary.GameRecord request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Delete a game record
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Gamelibrary.GameResult> DeleteGame(global::Gamelibrary.GameRecord request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GameLibrary</summary>
    public partial class GameLibraryClient : grpc::ClientBase<GameLibraryClient>
    {
      /// <summary>Creates a new client for GameLibrary</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GameLibraryClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GameLibrary that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GameLibraryClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GameLibraryClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GameLibraryClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Obtains a list of games that match the request parameters.
      /// Streamed rather than returned at once (e.g. in a response message with a repeated field)
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Gamelibrary.GameRecord> SearchGames(global::Gamelibrary.GamesSearchRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchGames(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Obtains a list of games that match the request parameters.
      /// Streamed rather than returned at once (e.g. in a response message with a repeated field)
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::Gamelibrary.GameRecord> SearchGames(global::Gamelibrary.GamesSearchRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_SearchGames, null, options, request);
      }
      /// <summary>
      /// Add a new game record
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Gamelibrary.GameResult AddGame(global::Gamelibrary.GameRecord request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddGame(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Add a new game record
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Gamelibrary.GameResult AddGame(global::Gamelibrary.GameRecord request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddGame, null, options, request);
      }
      /// <summary>
      /// Add a new game record
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Gamelibrary.GameResult> AddGameAsync(global::Gamelibrary.GameRecord request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddGameAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Add a new game record
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Gamelibrary.GameResult> AddGameAsync(global::Gamelibrary.GameRecord request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddGame, null, options, request);
      }
      /// <summary>
      /// Edit a game record
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Gamelibrary.GameResult EditGame(global::Gamelibrary.GameRecord request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return EditGame(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Edit a game record
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Gamelibrary.GameResult EditGame(global::Gamelibrary.GameRecord request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_EditGame, null, options, request);
      }
      /// <summary>
      /// Edit a game record
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Gamelibrary.GameResult> EditGameAsync(global::Gamelibrary.GameRecord request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return EditGameAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Edit a game record
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Gamelibrary.GameResult> EditGameAsync(global::Gamelibrary.GameRecord request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_EditGame, null, options, request);
      }
      /// <summary>
      /// Delete a game record
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Gamelibrary.GameResult DeleteGame(global::Gamelibrary.GameRecord request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteGame(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete a game record
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Gamelibrary.GameResult DeleteGame(global::Gamelibrary.GameRecord request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteGame, null, options, request);
      }
      /// <summary>
      /// Delete a game record
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Gamelibrary.GameResult> DeleteGameAsync(global::Gamelibrary.GameRecord request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteGameAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete a game record
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Gamelibrary.GameResult> DeleteGameAsync(global::Gamelibrary.GameRecord request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteGame, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GameLibraryClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GameLibraryClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GameLibraryBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SearchGames, serviceImpl.SearchGames)
          .AddMethod(__Method_AddGame, serviceImpl.AddGame)
          .AddMethod(__Method_EditGame, serviceImpl.EditGame)
          .AddMethod(__Method_DeleteGame, serviceImpl.DeleteGame).Build();
    }

  }
}
#endregion
