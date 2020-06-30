using System;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace HuaweiCloud.SDK.Core
{
    public class HttpHandler
    {
        private List<Action<HttpRequestMessage, ILogger>> _requestHandlers =
            new List<Action<HttpRequestMessage, ILogger>>();

        private List<Action<HttpResponseMessage, ILogger>> _responseHandlers =
            new List<Action<HttpResponseMessage, ILogger>>();

        public HttpHandler AddRequestHandler(Action<HttpRequestMessage, ILogger> func)
        {
            _requestHandlers.Add(func);
            return this;
        }

        public HttpHandler AddResponseHandler(Action<HttpResponseMessage, ILogger> func)
        {
            _responseHandlers.Add(func);
            return this;
        }

        public void ProcessRequest(HttpRequestMessage request, ILogger logger)
        {
            foreach (var requestHandler in _requestHandlers)
            {
                requestHandler(request, logger);
            }
        }

        public void ProcessResponse(HttpResponseMessage response, ILogger logger)
        {
            foreach (var responseHandler in _responseHandlers)
            {
                responseHandler(response, logger);
            }
        }
    }
}