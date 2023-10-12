/*
 * Copyright 2020 Huawei Technologies Co.,Ltd.
 *
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HuaweiCloud.SDK.Core.Auth
{
    internal class Project
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    internal class KeystoneListProjectsResponse : SdkResponse
    {
        [JsonProperty("projects", NullValueHandling = NullValueHandling.Ignore)]
        public List<Project> Projects { get; set; }
    }

    internal class Domains
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    internal class KeystoneListAuthDomainsResponse : SdkResponse
    {
        [JsonProperty("domains", NullValueHandling = NullValueHandling.Ignore)]
        public List<Domains> Domains { get; set; }
    }

    public static class IamService
    {
        public const string DefaultIamEndpoint = "https://iam.myhuaweicloud.com";
        private const string KeystoneListProjectsUri = "/v3/projects";
        private const string KeystoneListAuthDomainsUri = "/v3/auth/domains";

        public static HttpRequest GetKeystoneListProjectsRequest(string iamEndpoint, string regionId, HttpConfig httpConfig)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath(KeystoneListProjectsUri, urlParam);
            var sdkRequest = HttpUtils.InitSdkRequest(urlPath);

            var url = iamEndpoint + urlPath + "?name=" + regionId;

            var request = new HttpRequest("GET", sdkRequest.ContentType, new Uri(url))
            {
                Body = "",
                SigningAlgorithm = httpConfig.SigningAlgorithm
            };

            return request;
        }

        public static string KeystoneListProjects(SdkHttpClient client, HttpRequest request)
        {
            var message = client.InitHttpRequest(request, true);
            try
            {
                var response = TaskUtils.RunSync(() => client.DoHttpRequest(message));
                if ((int)response.StatusCode >= 400)
                {
                    throw ExceptionUtils.GetException(response);
                }

                var data = JsonUtils.DeSerialize<KeystoneListProjectsResponse>(response);
                // TODO support create new project id here
                if (data?.Projects == null || data.Projects?.Count == 0)
                {
                    throw new ArgumentException("No project id found, please specify project_id manually when initializing the credentials.");
                }

                if (data.Projects.Count == 1)
                {
                    return data.Projects[0].Id;
                }

                throw new ArgumentException(
                    "Multiple project ids have been returned, please specify one when initializing the credentials.");
            }
            catch (AggregateException aggregateException)
            {
                throw ExceptionUtils.HandleException(aggregateException);
            }
        }

        public static HttpRequest GetKeystoneListAuthDomainsRequest(string iamEndpoint, HttpConfig httpConfig)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath(KeystoneListAuthDomainsUri, urlParam);
            var sdkRequest = HttpUtils.InitSdkRequest(urlPath);

            var url = iamEndpoint + urlPath;
            var request = new HttpRequest("GET", sdkRequest.ContentType, new Uri(url))
            {
                Body = "",
                SigningAlgorithm = httpConfig.SigningAlgorithm
            };

            return request;
        }

        public static string KeystoneListAuthDomains(SdkHttpClient client, HttpRequest request)
        {
            var message = client.InitHttpRequest(request, true);
            try
            {
                var response = TaskUtils.RunSync(() => client.DoHttpRequest(message));
                if ((int)response.StatusCode >= 400)
                {
                    throw ExceptionUtils.GetException(response);
                }

                var data = JsonUtils.DeSerialize<KeystoneListAuthDomainsResponse>(response);
                if (data?.Domains != null && data.Domains.Count > 0)
                {
                    return data.Domains[0].Id;
                }

                throw new ArgumentException("No domain id found, please select one of the following solutions:\n\t" +
                                            "1. Manually specify domain_id when initializing the credentials.\n\t" +
                                            "2. Use the domain account to grant the current account permissions of the IAM service.\n\t" +
                                            "3. Use AK/SK of the domain account.");
            }
            catch (AggregateException aggregateException)
            {
                throw ExceptionUtils.HandleException(aggregateException);
            }
        }
    }
}
