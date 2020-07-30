using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace HuaweiCloud.SDK.Sidecar
{
    public class Startup
    {
        private static string _sdkRequestLog;
        private static string _sdkResponseLog;

        private static void RequestHandler(HttpRequestMessage message, ILogger logger)
        {
            logger.LogDebug(message.ToString());
            _sdkRequestLog = message + " Body: " + message.Content.ReadAsStringAsync().Result;
        }

        private static void ResponseHandler(HttpResponseMessage message, ILogger logger)
        {
            logger.LogDebug(message.ToString());
            _sdkResponseLog = message + " Body: " + message.Content.ReadAsStringAsync().Result;
        }

        private static readonly List<string> KeyMethod = new List<string>()
        {
            "GetType", "ToString", "Equals", "GetHashCode", "NewBuilder"
        };

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints => { endpoints.MapGet("/{name}/{version}", GetOperations); });
            app.UseEndpoints(endpoints => { endpoints.MapPost("/{name}/{version}/{operation}", InvokeSdk); });
        }

        private static async Task GetOperations(HttpContext context)
        {
            var name = (string) context.Request.RouteValues["name"];
            var version = ((string) context.Request.RouteValues["version"]).ToUpper();

            var assembly = Assembly.LoadFrom($"HuaweiCloud.SDK.{name}.dll");
            var clientType = assembly.GetType($"HuaweiCloud.SDK.{name}.{version}.{name}Client") ??
                             throw new ArgumentNullException($"Class: {name}Client\")");
            var methods = clientType.GetMethods();
            var operations = new ArrayList();
            foreach (var methodInfo in methods)
            {
                if (!KeyMethod.Contains(methodInfo.Name))
                {
                    operations.Add(methodInfo.Name);
                }
            }

            await context.Response.WriteAsync(JsonUtils.Serialize(operations));
        }

        private static async Task InvokeSdk(HttpContext context)
        {
            var name = (string) context.Request.RouteValues["name"];
            var version = ((string) context.Request.RouteValues["version"]).ToUpper();
            var operation = (string) context.Request.RouteValues["operation"];
            var endpoint = (string) context.Request.Query["endpoint"];

            var reader = new StreamReader(context.Request.Body);
            var body = await reader.ReadToEndAsync();

            var assembly = Assembly.LoadFrom($"HuaweiCloud.SDK.{name}.dll");
            var clientType = assembly.GetType($"HuaweiCloud.SDK.{name}.{version}.{name}Client") ??
                             throw new ArgumentNullException($"Class: {name}Client");

            var client = GetClient(clientType, endpoint);

            var requestType = assembly.GetType($"HuaweiCloud.SDK.{name}.{version}.Model.{operation}Request");
            var request = JsonConvert.DeserializeObject(body, requestType);

            var operationMethod = clientType.GetMethod(operation) ??
                                  throw new ArgumentNullException($"Method: {operation}");
            var response = new SidecarResponse();
            try
            {
                var sdkResponse = operationMethod.Invoke(client, new object[] {request});
                response.HttpStatusCode =
                    (int) sdkResponse.GetType().GetProperty("HttpStatusCode").GetValue(sdkResponse, null);
                response.Content = (string) sdkResponse.GetType().GetProperty("HttpBody").GetValue(sdkResponse, null);
            }
            catch (TargetInvocationException targetInvocationException)
            {
                GetSidecarException(targetInvocationException, response);
            }

            response.HttpLog = new SdkHttpLog
            {
                Request = _sdkRequestLog,
                Response = _sdkResponseLog
            };

            context.Response.Headers.Add("Content-Type", "application/json");
            await context.Response.WriteAsync(JsonUtils.Serialize(response));
        }

        private static void GetSidecarException(TargetInvocationException targetInvocationException,
            SidecarResponse response)
        {
            var innerException = targetInvocationException.InnerException;
            if (innerException == null)
            {
                var message = targetInvocationException.GetType().GetProperty("Message");
                response.Exception = new SidecarException
                {
                    ErrorMsg = message == null ? "" : (string) message.GetValue(targetInvocationException, null)
                };
                return;
            }

            if (innerException.GetType().IsSubclassOf(typeof(ServiceResponseException)))
            {
                response.HttpStatusCode =
                    (int) innerException.GetType().GetProperty("HttpStatusCode").GetValue(innerException, null);
                response.Exception = new SidecarException
                {
                    ErrorMsg = (string) innerException.GetType().GetProperty("ErrorMsg")
                        .GetValue(innerException, null),
                    ErrorCode = (string) innerException.GetType().GetProperty("ErrorCode")
                        .GetValue(innerException, null)
                };
            }
            else if (innerException.GetType() == typeof(RequestTimeoutException) ||
                     innerException.GetType() == typeof(ConnectionException))
            {
                response.Exception = new SidecarException
                {
                    ErrorMsg = (string) innerException.GetType().GetProperty("ErrorMessage")
                        .GetValue(innerException, null)
                };
            }
            else
            {
                response.Exception = new SidecarException
                {
                    ErrorMsg = (string) innerException.GetType().GetProperty("Message")
                        .GetValue(innerException, null)
                };
            }
        }

        private static object GetClient(Type clientType, string endpoint)
        {
            var builderMethod = clientType.GetMethod("NewBuilder") ??
                                throw new ArgumentNullException("NewBuilder");
            var builder = builderMethod.Invoke(clientType, null) ??
                          throw new ArgumentNullException("builder");
            var withEndPoint = builder.GetType().GetMethod("WithEndPoint") ??
                               throw new ArgumentNullException("WithEndPoint");
            var withHttpConfig = builder.GetType().GetMethod("WithHttpConfig") ??
                                 throw new ArgumentNullException("WithHttpConfig");
            var withLogging = builder.GetType().GetMethod("WithLogging") ??
                              throw new ArgumentNullException("WithLogging");
            var withHttpHandler = builder.GetType().GetMethod("WithHttpHandler") ??
                                  throw new ArgumentNullException("WithHttpHandler");
            var build = builder.GetType().GetMethod("Build") ?? throw new ArgumentNullException("Build");

            builder = withEndPoint.Invoke(builder, new object[]
            {
                endpoint
            });
            builder = withHttpConfig.Invoke(builder, new object[]
            {
                new HttpConfig()
                {
                    IgnoreSslVerification = true
                }
            });
            builder = withLogging.Invoke(builder, new object[]
            {
                LogLevel.Debug
            });
            builder = withHttpHandler.Invoke(builder, new object[]
            {
                new HttpHandler().AddRequestHandler(RequestHandler).AddResponseHandler(ResponseHandler)
            });
            var client = build.Invoke(builder, null);
            return client;
        }
    }
}