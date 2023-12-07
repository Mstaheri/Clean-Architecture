using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace NovinBar.WebSite
{
    public class SqlHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(HealthCheckResult.Healthy("is ok"));
        }
    }
}
