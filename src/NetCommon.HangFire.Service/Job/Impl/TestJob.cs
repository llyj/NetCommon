using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Jak.HangFire.Service.Job.Impl
{
    public class TestJob : BaseJob<TestJob>
    {
        private readonly ILogger<TestJob> _logger;
        private readonly IServiceProvider _serviceProvider;

        public TestJob(ILogger<TestJob> logger, IServiceProvider serviceProvider) : base(logger, serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        public override string JobDescription => "";

        public override async Task ExecuteAsync(IDictionary<string, object>? data = null)
        {
        }
    }
}