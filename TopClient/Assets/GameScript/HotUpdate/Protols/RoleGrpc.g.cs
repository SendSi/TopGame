// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: role.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace TopServer {
  public static partial class RoleService
  {
    static readonly string __ServiceName = "role.RoleService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::TopServer.RoleRequest> __Marshaller_role_RoleRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TopServer.RoleRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::TopServer.RoleResponse> __Marshaller_role_RoleResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TopServer.RoleResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::TopServer.RoleInfoRequest> __Marshaller_role_RoleInfoRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TopServer.RoleInfoRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::TopServer.RoleInfoResponse> __Marshaller_role_RoleInfoResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TopServer.RoleInfoResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::TopServer.RoleUpLvRequest> __Marshaller_role_RoleUpLvRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TopServer.RoleUpLvRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::TopServer.RoleUpLvResponse> __Marshaller_role_RoleUpLvResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TopServer.RoleUpLvResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::TopServer.RoleAddVipRequest> __Marshaller_role_RoleAddVipRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TopServer.RoleAddVipRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::TopServer.RoleAddVipResponse> __Marshaller_role_RoleAddVipResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TopServer.RoleAddVipResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::TopServer.RoleRequest, global::TopServer.RoleResponse> __Method_ListenRole = new grpc::Method<global::TopServer.RoleRequest, global::TopServer.RoleResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ListenRole",
        __Marshaller_role_RoleRequest,
        __Marshaller_role_RoleResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::TopServer.RoleInfoRequest, global::TopServer.RoleInfoResponse> __Method_RoleInfo = new grpc::Method<global::TopServer.RoleInfoRequest, global::TopServer.RoleInfoResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RoleInfo",
        __Marshaller_role_RoleInfoRequest,
        __Marshaller_role_RoleInfoResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::TopServer.RoleUpLvRequest, global::TopServer.RoleUpLvResponse> __Method_RoleUpLv = new grpc::Method<global::TopServer.RoleUpLvRequest, global::TopServer.RoleUpLvResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RoleUpLv",
        __Marshaller_role_RoleUpLvRequest,
        __Marshaller_role_RoleUpLvResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::TopServer.RoleAddVipRequest, global::TopServer.RoleAddVipResponse> __Method_RoleAddVip = new grpc::Method<global::TopServer.RoleAddVipRequest, global::TopServer.RoleAddVipResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RoleAddVip",
        __Marshaller_role_RoleAddVipRequest,
        __Marshaller_role_RoleAddVipResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::TopServer.RoleReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RoleService</summary>
    [grpc::BindServiceMethod(typeof(RoleService), "BindService")]
    public abstract partial class RoleServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task ListenRole(global::TopServer.RoleRequest request, grpc::IServerStreamWriter<global::TopServer.RoleResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::TopServer.RoleInfoResponse> RoleInfo(global::TopServer.RoleInfoRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::TopServer.RoleUpLvResponse> RoleUpLv(global::TopServer.RoleUpLvRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::TopServer.RoleAddVipResponse> RoleAddVip(global::TopServer.RoleAddVipRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for RoleService</summary>
    public partial class RoleServiceClient : grpc::ClientBase<RoleServiceClient>
    {
      /// <summary>Creates a new client for RoleService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public RoleServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RoleService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public RoleServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected RoleServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected RoleServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::TopServer.RoleResponse> ListenRole(global::TopServer.RoleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListenRole(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::TopServer.RoleResponse> ListenRole(global::TopServer.RoleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ListenRole, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::TopServer.RoleInfoResponse RoleInfo(global::TopServer.RoleInfoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RoleInfo(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::TopServer.RoleInfoResponse RoleInfo(global::TopServer.RoleInfoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RoleInfo, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::TopServer.RoleInfoResponse> RoleInfoAsync(global::TopServer.RoleInfoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RoleInfoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::TopServer.RoleInfoResponse> RoleInfoAsync(global::TopServer.RoleInfoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RoleInfo, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::TopServer.RoleUpLvResponse RoleUpLv(global::TopServer.RoleUpLvRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RoleUpLv(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::TopServer.RoleUpLvResponse RoleUpLv(global::TopServer.RoleUpLvRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RoleUpLv, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::TopServer.RoleUpLvResponse> RoleUpLvAsync(global::TopServer.RoleUpLvRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RoleUpLvAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::TopServer.RoleUpLvResponse> RoleUpLvAsync(global::TopServer.RoleUpLvRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RoleUpLv, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::TopServer.RoleAddVipResponse RoleAddVip(global::TopServer.RoleAddVipRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RoleAddVip(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::TopServer.RoleAddVipResponse RoleAddVip(global::TopServer.RoleAddVipRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RoleAddVip, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::TopServer.RoleAddVipResponse> RoleAddVipAsync(global::TopServer.RoleAddVipRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RoleAddVipAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::TopServer.RoleAddVipResponse> RoleAddVipAsync(global::TopServer.RoleAddVipRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RoleAddVip, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override RoleServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RoleServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(RoleServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListenRole, serviceImpl.ListenRole)
          .AddMethod(__Method_RoleInfo, serviceImpl.RoleInfo)
          .AddMethod(__Method_RoleUpLv, serviceImpl.RoleUpLv)
          .AddMethod(__Method_RoleAddVip, serviceImpl.RoleAddVip).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, RoleServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListenRole, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::TopServer.RoleRequest, global::TopServer.RoleResponse>(serviceImpl.ListenRole));
      serviceBinder.AddMethod(__Method_RoleInfo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TopServer.RoleInfoRequest, global::TopServer.RoleInfoResponse>(serviceImpl.RoleInfo));
      serviceBinder.AddMethod(__Method_RoleUpLv, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TopServer.RoleUpLvRequest, global::TopServer.RoleUpLvResponse>(serviceImpl.RoleUpLv));
      serviceBinder.AddMethod(__Method_RoleAddVip, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TopServer.RoleAddVipRequest, global::TopServer.RoleAddVipResponse>(serviceImpl.RoleAddVip));
    }

  }
}
#endregion
