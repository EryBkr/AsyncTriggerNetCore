using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AsynTraining
{
    public class TestAsyncTrigger : HostedService
    {

        protected override async Task ExecuteAsync(CancellationToken cToken)
        {
            while (!cToken.IsCancellationRequested)
            {
                Console.WriteLine("Time : "+DateTime.Now);
                await Task.Delay(TimeSpan.FromSeconds(10), cToken);
            }
        }
    }
}
