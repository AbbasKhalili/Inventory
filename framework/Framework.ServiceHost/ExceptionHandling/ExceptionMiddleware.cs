using System;
using System.Net;
using System.Resources;
using System.Threading.Tasks;
using Framework.Core;
using Framework.Core.Exceptions;
using Microsoft.AspNetCore.Http;

namespace Framework.ServiceHost.ExceptionHandling
{
    public class ExceptionMiddleware
    {
        public static ResourceManager ResourceManager;
        private readonly RequestDelegate _next;
        private readonly ILoggerService _logger;

        public ExceptionMiddleware(RequestDelegate next, ILoggerService logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            if (exception?.InnerException is BusinessException coreException)
            {
                return GenerateResponse(coreException.Code, GetExceptionMessage(coreException), context);
            }
            if (exception is BusinessException businessException)
            {
                return GenerateResponse(businessException.Code, GetExceptionMessage(businessException), context);
            }
            _logger.Error(exception);

            return GenerateResponse((int)HttpStatusCode.InternalServerError, "InternalServerError", context);
        }

        private Task GenerateResponse(int code, string message, HttpContext context)
        {
            return context.Response.WriteAsync(new ErrorDetails()
            {
                Code = code,
                ErrorMessage = message
            }.ToString());
        }

        private string GetExceptionMessage(BusinessException businessException)
        {
            if (!string.IsNullOrEmpty(businessException.ExceptionMessage))
                return businessException.ExceptionMessage;
            return ResourceManager.GetString("_" + businessException.Code);
        }
    }
}
