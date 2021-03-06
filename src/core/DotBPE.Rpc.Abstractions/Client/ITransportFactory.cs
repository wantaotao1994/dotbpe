using System;
using System.Net;
using System.Threading.Tasks;
using DotBPE.Rpc.Codes;

namespace DotBPE.Rpc {
    public interface ITransportFactory<in TMessage> : IDisposable where TMessage : InvokeMessage {
        ITransport<TMessage> CreateTransport (EndPoint endpoint);

        Task CloseTransportAsync (EndPoint serverAddress);
    }
}