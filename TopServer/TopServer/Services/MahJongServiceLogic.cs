using Grpc.Core;
using System.Collections.Concurrent;

namespace TopServer.Services
{
    public class MahJongServiceLogic : MahJongService.MahJongServiceBase
    {
        public override async Task ListenMahJong(MahJongRequest request, IServerStreamWriter<MahJongResponse> responseStream, ServerCallContext context)
        {
            while (!context.CancellationToken.IsCancellationRequested)
            {
                while (pushQueue.TryDequeue(out var MahJongListen))
                {
                    await responseStream.WriteAsync(MahJongListen);
                }
            }
            await Task.CompletedTask;
        }

        static ConcurrentQueue<MahJongResponse> pushQueue = new ConcurrentQueue<MahJongResponse>();


        public override Task<MahJongEnterResponse> EnterMahJong(MahJongEnterRequest request, ServerCallContext context)
        {
            return base.EnterMahJong(request, context);
        }

        //public override Task<MahJongEnterResponse> EnterMahJong(MahJongEnterResponse request, ServerCallContext context)
        //{

        //    return Task.FromResult(rsp);
        //}


    }
}
