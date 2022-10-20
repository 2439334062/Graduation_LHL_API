using Emqx.Exhook.V2;
using Grpc.Core;
using Google.Protobuf;
namespace Graduation_LHL_API.Services
{
    public class HookProviderService:HookProvider.HookProviderBase
    {
        private readonly ILogger<HookProviderService> _logger;
        public HookProviderService(ILogger<HookProviderService> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// 用于注册挂载点
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<LoadedResponse> OnProviderLoaded(ProviderLoadedRequest request, ServerCallContext context)
        {

            Console.WriteLine("1``");
            Console.WriteLine(request);
            HookSpec[] specs =
            {
                new HookSpec{Name="client.connect"},  // 处理连接报文 服务端收到客户端的连接报文时
                new HookSpec{Name="client.connack"},  // 下发连接应答 服务端准备下发连接应答报文时
                new HookSpec{Name="client.connected"},   // 成功接入 客户端认证完成并成功接入系统后
                new HookSpec{Name="client.disconnected"}, // 连接断开 客户端连接层在准备关闭时
                new HookSpec{Name="client.authenticate"},  // 连接认证 执行完 client.connect 后
                new HookSpec{Name="client.authorize"},  // 发布订阅鉴权 执行 发布/订阅 操作前
                new HookSpec{Name="client.subscribe"},  // 订阅主题 收到订阅报文后，执行 client.authorize 鉴权前
                new HookSpec{Name="client.unsubscribe"}, // 取消订阅 收到取消订阅报文后


                new HookSpec{Name="session.created"}, // 会话创建  client.connected 执行完成，且创建新的会话后
                new HookSpec{Name="session.subscribed"}, //会话订阅主题 完成订阅操作后
                new HookSpec{Name="session.unsubscribed"},//会话取消订阅  完成取消订阅操作后
                new HookSpec{Name="session.resumed"}, //会话恢复 client.connected 执行完成，且成功恢复旧的会话信息后
                new HookSpec{Name="session.discarded"}, //会话被移除 会话由于被移除而终止后
                new HookSpec{Name="session.takenover"},  // 会话被接管 会话由于被接管而终止后
                new HookSpec{Name="session.terminated"}, //会话终止 会话由于其他原因被终止后

                new HookSpec{Name="message.publish"}, //消息发布 服务端在发布（路由）消息前
                new HookSpec{Name="message.delivered"}, // 消息投递  消息准备投递到客户端前
                new HookSpec{Name="message.acked"},   // 消息回执  服务端在收到客户端发回的消息 ACK 后
                new HookSpec{Name="message.dropped"} // 消息丢弃 发布出的消息被丢弃后

            };
            LoadedResponse response = new LoadedResponse();
            response.Hooks.Add(specs);

            return Task.FromResult(response);
        }

        /// <summary>
        /// 在提供程序已卸载时执行
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<EmptySuccess> OnProviderUnloaded(ProviderUnloadedRequest request, ServerCallContext context)
        {
            EmptySuccess reply = new EmptySuccess();

            return Task.FromResult(reply);
            //return base.OnProviderUnloaded(request, context);
        }

        #region 客户端


        /// <summary>
        /// 处理连接报文 服务端收到客户端的连接报文时
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<EmptySuccess> OnClientConnect(ClientConnectRequest request, ServerCallContext context)
        {

            EmptySuccess reply = new EmptySuccess();
            return Task.FromResult(reply);
        }
        /// <summary>
        /// 下发连接应答
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<EmptySuccess> OnClientConnack(ClientConnackRequest request, ServerCallContext context)
        {
            EmptySuccess reply = new EmptySuccess();

            return Task.FromResult(reply);
        }

        /// <summary>
        ///  成功接入 客户端认证完成并成功接入系统后
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<EmptySuccess> OnClientConnected(ClientConnectedRequest request, ServerCallContext context)
        {
            EmptySuccess reply = new EmptySuccess();

            return Task.FromResult(reply);
        }

        /// <summary>
        /// 连接断开 客户端连接层在准备关闭时
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<EmptySuccess> OnClientDisconnected(ClientDisconnectedRequest request, ServerCallContext context)
        {
            EmptySuccess reply = new EmptySuccess();
            return Task.FromResult(reply);
        }

        /// <summary>
        /// 连接认证 执行完 client.connect 后
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<ValuedResponse> OnClientAuthenticate(ClientAuthenticateRequest request, ServerCallContext context)
        {
            ValuedResponse reply = new ValuedResponse()
            {
                BoolResult = true,
                Type = ValuedResponse.Types.ResponsedType.StopAndReturn
            };
            return Task.FromResult(reply);
        }

        /// <summary>
        /// 发布订阅鉴权 执行 发布/订阅 操作前
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<ValuedResponse> OnClientAuthorize(ClientAuthorizeRequest request, ServerCallContext context)
        {
            ValuedResponse reply = new ValuedResponse()
            {
                BoolResult = true,
                Type = ValuedResponse.Types.ResponsedType.StopAndReturn
            };
            return Task.FromResult(reply);
        }

        /// <summary>
        /// 订阅主题 收到订阅报文后，执行 client.authorize 鉴权前
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<EmptySuccess> OnClientSubscribe(ClientSubscribeRequest request, ServerCallContext context)
        {
            EmptySuccess reply = new EmptySuccess();
            return Task.FromResult(reply);
        }

        /// <summary>
        /// 取消订阅 收到取消订阅报文后
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<EmptySuccess> OnClientUnsubscribe(ClientUnsubscribeRequest request, ServerCallContext context)
        {
            EmptySuccess reply = new EmptySuccess();
            return Task.FromResult(reply);
        }

        #endregion

        #region  会话

        /// <summary>
        /// 会话创建  client.connected 执行完成，且创建新的会话后
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<EmptySuccess> OnSessionCreated(SessionCreatedRequest request, ServerCallContext context)
        {
            EmptySuccess reply = new EmptySuccess();
            return Task.FromResult(reply);
        }

        /// <summary>
        /// 会话订阅主题 完成订阅操作后
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<EmptySuccess> OnSessionSubscribed(SessionSubscribedRequest request, ServerCallContext context)
        {
            EmptySuccess reply = new EmptySuccess();
            return Task.FromResult(reply);
        }

        /// <summary>
        /// 会话取消订阅  完成取消订阅操作后
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<EmptySuccess> OnSessionUnsubscribed(SessionUnsubscribedRequest request, ServerCallContext context)
        {
            EmptySuccess reply = new EmptySuccess();
            return Task.FromResult(reply);
        }

        /// <summary>
        /// 会/会话被移除 会话由于被移除而终止后
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<EmptySuccess> OnSessionDiscarded(SessionDiscardedRequest request, ServerCallContext context)
        {
            EmptySuccess reply = new EmptySuccess();
            return Task.FromResult(reply);
        }

        /// <summary>
        /// 会话恢复 client.connected 执行完成，且成功恢复旧的会话信息后
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<EmptySuccess> OnSessionResumed(SessionResumedRequest request, ServerCallContext context)
        {
            EmptySuccess reply = new EmptySuccess();
            return Task.FromResult(reply);
        }

        /// <summary>
        /// 会话被接管 会话由于被接管而终止后
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<EmptySuccess> OnSessionTakenover(SessionTakenoverRequest request, ServerCallContext context)
        {

            EmptySuccess reply = new EmptySuccess();
            return Task.FromResult(reply);
        }
        /// <summary>
        /// 会话终止 会话由于其他原因被终止后
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<EmptySuccess> OnSessionTerminated(SessionTerminatedRequest request, ServerCallContext context)
        {

            EmptySuccess reply = new EmptySuccess();
            return Task.FromResult(reply);
        }

        #endregion


        /// <summary>
        /// 消息发布 服务端在发布（路由）消息前
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<ValuedResponse> OnMessagePublish(MessagePublishRequest request, ServerCallContext context)
        {
            Console.WriteLine(request);
            string payload = request.Message.Payload.ToStringUtf8();
            Console.WriteLine(payload);
            ByteString bstr = ByteString.CopyFromUtf8("hardcode payload by fitstGrpc");
            Message message = new Message
            {
                Id = request.Message.Id,
                Node = request.Message.Node,
                From = request.Message.From,
                Topic = request.Message.Topic,
                Payload = bstr
            };
            ValuedResponse reply = new ValuedResponse()
            {
                Type = ValuedResponse.Types.ResponsedType.StopAndReturn,
                Message = message
            };
            return Task.FromResult(reply);
        }

        /// <summary>
        /// 消息投递  消息准备投递到客户端前
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<EmptySuccess> OnMessageAcked(MessageAckedRequest request, ServerCallContext context)
        {
            EmptySuccess reply = new EmptySuccess();
            return Task.FromResult(reply);
        }

        /// <summary>
        /// 消息回执  服务端在收到客户端发回的消息 ACK 后
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<EmptySuccess> OnMessageDelivered(MessageDeliveredRequest request, ServerCallContext context)
        {
            EmptySuccess reply = new EmptySuccess();
            return Task.FromResult(reply);
        }
        /// <summary>
        /// 消息丢弃 发布出的消息被丢弃后
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<EmptySuccess> OnMessageDropped(MessageDroppedRequest request, ServerCallContext context)
        {
            EmptySuccess reply = new EmptySuccess();
            return Task.FromResult(reply);
        }
    }
}
