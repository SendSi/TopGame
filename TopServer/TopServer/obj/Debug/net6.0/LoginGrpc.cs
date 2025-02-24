// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: login.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace TopServer {
  public static partial class LoginService
  {
    static readonly string __ServiceName = "login.LoginService";

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
    static readonly grpc::Marshaller<global::TopServer.LoginRequest> __Marshaller_login_LoginRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TopServer.LoginRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::TopServer.LoginResponse> __Marshaller_login_LoginResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TopServer.LoginResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::TopServer.LoginReq> __Marshaller_login_LoginReq = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TopServer.LoginReq.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::TopServer.LoginRsp> __Marshaller_login_LoginRsp = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TopServer.LoginRsp.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::TopServer.LogoutReq> __Marshaller_login_LogoutReq = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TopServer.LogoutReq.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::TopServer.LogoutRsp> __Marshaller_login_LogoutRsp = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::TopServer.LogoutRsp.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::TopServer.LoginRequest, global::TopServer.LoginResponse> __Method_ListenLogin = new grpc::Method<global::TopServer.LoginRequest, global::TopServer.LoginResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ListenLogin",
        __Marshaller_login_LoginRequest,
        __Marshaller_login_LoginResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::TopServer.LoginReq, global::TopServer.LoginRsp> __Method_LoginIn = new grpc::Method<global::TopServer.LoginReq, global::TopServer.LoginRsp>(
        grpc::MethodType.Unary,
        __ServiceName,
        "LoginIn",
        __Marshaller_login_LoginReq,
        __Marshaller_login_LoginRsp);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::TopServer.LogoutReq, global::TopServer.LogoutRsp> __Method_Logout = new grpc::Method<global::TopServer.LogoutReq, global::TopServer.LogoutRsp>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Logout",
        __Marshaller_login_LogoutReq,
        __Marshaller_login_LogoutRsp);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::TopServer.LoginReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of LoginService</summary>
    [grpc::BindServiceMethod(typeof(LoginService), "BindService")]
    public abstract partial class LoginServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task ListenLogin(global::TopServer.LoginRequest request, grpc::IServerStreamWriter<global::TopServer.LoginResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::TopServer.LoginRsp> LoginIn(global::TopServer.LoginReq request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::TopServer.LogoutRsp> Logout(global::TopServer.LogoutReq request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(LoginServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListenLogin, serviceImpl.ListenLogin)
          .AddMethod(__Method_LoginIn, serviceImpl.LoginIn)
          .AddMethod(__Method_Logout, serviceImpl.Logout).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, LoginServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListenLogin, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::TopServer.LoginRequest, global::TopServer.LoginResponse>(serviceImpl.ListenLogin));
      serviceBinder.AddMethod(__Method_LoginIn, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TopServer.LoginReq, global::TopServer.LoginRsp>(serviceImpl.LoginIn));
      serviceBinder.AddMethod(__Method_Logout, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::TopServer.LogoutReq, global::TopServer.LogoutRsp>(serviceImpl.Logout));
    }

  }
}
#endregion
