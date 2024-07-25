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
using System.Linq;
using System.Net;
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

    internal class IamResponse : SdkResponse
    {
        [SDKProperty(propertyName: "X-IAM-Trace-Id", IsHeader = true)]
        public string TraceId { get; set;}
    }

    internal class KeystoneListProjectsResponse : IamResponse
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

    internal class KeystoneListAuthDomainsResponse : IamResponse
    {
        [JsonProperty("domains", NullValueHandling = NullValueHandling.Ignore)]
        public List<Domains> Domains { get; set; }
    }

    public static class IamService
    {
        public const string DefaultIamEndpoint = "https://iam.myhuaweicloud.com";
        private const string KeystoneListProjectsUri = "/v3/projects";
        private const string KeystoneListAuthDomainsUri = "/v3/auth/domains";

        private const string NoProjectIdFound = @"no project id found, please select one of the following solutions:
  1. Manually specify project_id when initializing the credentials, var credentials = new BasicCredentials(ak, sk, projectId);
  2. Use the domain account to grant IAM read permission to the current account
  3. Replace the ak/sk of the IAM account with the ak/sk of the domain account";

        private const string NoDomainIdFound = @"no domain id found, please select one of the following solutions:
  1. Manually specify domainId when initializing the credentials, var credentials = new GlobalCredentials(ak, sk, domainId);
  2. Use the domain account to grant IAM read permission to the current account
  3. Replace the ak/sk of the IAM account with the ak/sk of the domain account";

        public static HttpRequest GetKeystoneListProjectsRequest(string iamEndpoint, string regionId, HttpConfig httpConfig)
        {
            var urlParam = new Dictionary<string, string>();
            var urlPath = HttpUtils.AddUrlPath(KeystoneListProjectsUri, urlParam);
            var sdkRequest = HttpUtils.InitSdkRequest(urlPath);

            var url = iamEndpoint + urlPath + "?name=" + regionId;

            var request = new HttpRequest("GET", sdkRequest.ContentType, new Uri(url))
            {
                Body = "",
                Headers = new WebHeaderCollection
                {
                    {
                        "User-Agent", "huaweicloud-usdk-net/3.0"
                    }
                },
                SigningAlgorithm = httpConfig.SigningAlgorithm
            };

            return request;
        }
    
        [Obsolete("This method is for internal use only and is deprecated. It will be removed in a future release.")]
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
                if (data?.Projects == null || data.Projects?.Count == 0)
                {
                    throw new ArgumentException(NoProjectIdFound);
                }
                if (data.Projects?.Count > 1)
                {
                    var projectIds = string.Join(",", data.Projects.Select(project => project.Id).ToList());
                    throw new ArgumentException($"Multiple project ids found: {projectIds}, please specify one when initializing the credentials");
                }

                return data.Projects?[0].Id;
            }
            catch (AggregateException aggregateException)
            {
                throw ExceptionUtils.HandleException(aggregateException);
            }
        }
        
        internal static KeystoneListProjectsResponse InternalKeystoneListProjects(SdkHttpClient client, HttpRequest request)
        {
            var message = client.InitHttpRequest(request, true);
            try
            {
                var response = TaskUtils.RunSync(() => client.DoHttpRequest(message));
                if ((int)response.StatusCode >= 400)
                {
                    throw ExceptionUtils.GetException(response);
                }

                return JsonUtils.DeSerialize<KeystoneListProjectsResponse>(response);
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
                Headers = new WebHeaderCollection
                {
                    {
                        "User-Agent", "huaweicloud-usdk-net/3.0"
                    }
                },
                SigningAlgorithm = httpConfig.SigningAlgorithm
            };

            return request;
        }
        
        [Obsolete("This method is for internal use only and is deprecated. It will be removed in a future release.")]
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

                throw new ArgumentException(NoDomainIdFound);
            }
            catch (AggregateException aggregateException)
            {
                throw ExceptionUtils.HandleException(aggregateException);
            }
        }
        
        internal static KeystoneListAuthDomainsResponse InternalKeystoneListAuthDomains(SdkHttpClient client, HttpRequest request)
        {
            var message = client.InitHttpRequest(request, true);
            try
            {
                var response = TaskUtils.RunSync(() => client.DoHttpRequest(message));
                if ((int)response.StatusCode >= 400)
                {
                    throw ExceptionUtils.GetException(response);
                }

                return JsonUtils.DeSerialize<KeystoneListAuthDomainsResponse>(response);
            }
            catch (AggregateException aggregateException)
            {
                throw ExceptionUtils.HandleException(aggregateException);
            }
        }
    }
}
