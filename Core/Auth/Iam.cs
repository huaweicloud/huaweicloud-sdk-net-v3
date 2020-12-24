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
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HuaweiCloud.SDK.Core.Auth
{
    class Project
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    class KeystoneListProjectsResponse
    {
        [JsonProperty("projects", NullValueHandling = NullValueHandling.Ignore)]
        public List<Project> Projects { get; set; }
    }

    class Domains
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    class KeystoneListAuthDomainsResponse
    {
        [JsonProperty("domains", NullValueHandling = NullValueHandling.Ignore)]
        public List<Domains> Domains { get; set; }
    }

    public class Iam
    {
        public const string DefaultIamEndpoint = "https://iam.myhuaweicloud.com";
        private const string KeystoneListProjectsUri = "/v3/projects";
        private const string KeystoneListAuthDomainsUri = "/v3/auth/domains";

        public static HttpRequest GetKeystoneListProjectsRequest(string iamEndpoint, string regionId)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath(KeystoneListProjectsUri, urlParam);
            SdkRequest sdkRequest = HttpUtils.InitSdkRequest(urlPath);

            var url = iamEndpoint + urlPath + "?name=" + regionId;

            var request = new HttpRequest("GET", sdkRequest.ContentType, new Uri(url))
            {
                Body = ""
            };

            return request;
        }

        public static string KeystoneListProjects(SdkHttpClient client, HttpRequest request)
        {
            var message = client.InitHttpRequest(request);
            try
            {
                HttpResponseMessage response = client.DoHttpRequest(message).Result;
                if ((int) response.StatusCode == 200)
                {
                    KeystoneListProjectsResponse data = JsonUtils.DeSerialize<KeystoneListProjectsResponse>(response);
                    if (data.Projects != null && data.Projects.Count > 0)
                    {
                        return data.Projects[0].Id;
                    }

                    throw new ArgumentException("Failed to get project id.");
                }

                throw new ServiceResponseException((int) response.StatusCode, new SdkError("Failed to get project id."));
            }
            catch (AggregateException aggregateException)
            {
                throw new ConnectionException(aggregateException.Message);
            }
        }

        public static HttpRequest GetKeystoneListAuthDomainsRequest(string iamEndpoint)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath(KeystoneListAuthDomainsUri, urlParam);
            SdkRequest sdkRequest = HttpUtils.InitSdkRequest(urlPath);

            var url = iamEndpoint + urlPath;

            var request = new HttpRequest("GET", sdkRequest.ContentType, new Uri(url))
            {
                Body = ""
            };

            return request;
        }

        public static string KeystoneListAuthDomains(SdkHttpClient client, HttpRequest request)
        {
            var message = client.InitHttpRequest(request);
            try
            {
                HttpResponseMessage response = client.DoHttpRequest(message).Result;
                if ((int) response.StatusCode == 200)
                {
                    KeystoneListAuthDomainsResponse data =
                        JsonUtils.DeSerialize<KeystoneListAuthDomainsResponse>(response);
                    if (data.Domains != null && data.Domains.Count > 0)
                    {
                        return data.Domains[0].Id;
                    }

                    throw new ArgumentException("Failed to get domain id.");
                }

                throw new ServiceResponseException((int) response.StatusCode, new SdkError("Failed to get domain id."));
            }
            catch (AggregateException aggregateException)
            {
                throw new ConnectionException(aggregateException.Message);
            }
        }
    }
}