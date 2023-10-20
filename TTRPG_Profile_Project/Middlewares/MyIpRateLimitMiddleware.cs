using AspNetCoreRateLimit;
using Microsoft.Extensions.Options;
using TTRPG_Project.BL.DTO;

namespace TTRPG_Project.Web.Middlewares
{
    public class MyIpRateLimitMiddleware : IpRateLimitMiddleware
    {
        public MyIpRateLimitMiddleware(RequestDelegate next
            , IOptions<IpRateLimitOptions> options
            , IProcessingStrategy strategy
            , IIpPolicyStore policyStore
            , IRateLimitConfiguration config
            , ILogger<IpRateLimitMiddleware> logger)
                : base(next, strategy, options, policyStore, config, logger)
        {
        }

        public override Task ReturnQuotaExceededResponse(HttpContext httpContext, RateLimitRule rule, string retryAfter)
        {
            //return base.ReturnQuotaExceededResponse(httpContext, rule, retryAfter);
            //var message = new { rule.Limit, rule.Period, retryAfter};

            httpContext.Response.StatusCode = StatusCodes.Status429TooManyRequests;
            httpContext.Response.ContentType = "application/json";
            return httpContext.Response.WriteAsJsonAsync(new ErrorResponse
            {
                Message = "Слишком много запросов. Повторите через: " + rule.Period,
            });
        }
    }
}
