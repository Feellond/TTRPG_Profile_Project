using TTRPG_Project.BL.DTO;
using TTRPG_Project.BL.DTO.Exceptions;
using TTRPG_Project.BL.Services.Real;

namespace TTRPG_Project.Web.Middlewares
{
    public class ExceptionHandling
    {
        //static readonly ITelegramBotClient bot = new TelegramBotClient("6308214976:AAFwBt_fAnGo2J2CQKnxClbKITRcA49aLV4");
        //static readonly ITelegramBotClient bot = new TelegramBotClient("2114961858:AAHXNoeWSw4nMeVJz9ad44LjWt8a5i3RXgY");
        //static readonly long chatId = 415663158;

        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandling> _logger;

        public ExceptionHandling(
            RequestDelegate next,
            ILogger<ExceptionHandling> logger
            )
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext httpContext, LogService logService)
        {
            try
            {
                await _next(httpContext);
            }
            catch (CustomException ex)
            {
                var exMessage = await HandlingException(ex, httpContext, logService);

                httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                httpContext.Response.ContentType = "application/json";
                await httpContext.Response.WriteAsJsonAsync(new ErrorResponse
                {
                    Message = ex.Message,
                    Details = exMessage
                });
            }
            catch (Exception ex)
            {
                var exMessage = await HandlingException(ex, httpContext, logService);

                httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
                httpContext.Response.ContentType = "application/json";
                await httpContext.Response.WriteAsJsonAsync(new ErrorResponse
                {
                    Details = exMessage,
                    Message = "Ошибка сервера! Повторите попытку позже!"
                });
            }
        }

        private async Task<string> HandlingException(Exception ex, HttpContext httpContext, LogService logService)
        {
            var logMessage = "Error = " + ex.Message;

            if (ex.InnerException != null)
                logMessage += "InnerEx: " + ex.InnerException;

            logMessage += $"\nMethod = {httpContext.Request.Method} {httpContext.Request.Path} ";

            _logger.LogError(logMessage);

            await logService.AddError(logMessage);

            return logMessage;
        }
    }
}
