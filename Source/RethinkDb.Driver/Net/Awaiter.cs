using RethinkDb.Driver.Utils;
using System.Threading;

namespace RethinkDb.Driver.Net
{
    internal class Awaiter : CancellableTask
    {
        public Awaiter(CancellationToken cancelToken) : base(cancelToken)
        {
        }
    }
}