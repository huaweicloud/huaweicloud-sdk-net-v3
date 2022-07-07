using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 更新健康检查请求参数。
    /// </summary>
    public class UpdateHealthMonitorOption 
    {
        /// <summary>
        /// HTTP请求方法，取值：GET、HEAD、POST、PUT、DELETE、TRACE、OPTIONS、CONNECT、PATCH，默认GET。   使用说明：当type为HTTP/HTTPS时生效。   不支持该字段，请勿使用。
        /// </summary>
        /// <value>HTTP请求方法，取值：GET、HEAD、POST、PUT、DELETE、TRACE、OPTIONS、CONNECT、PATCH，默认GET。   使用说明：当type为HTTP/HTTPS时生效。   不支持该字段，请勿使用。</value>
        [JsonConverter(typeof(EnumClassConverter<HttpMethodEnum>))]
        public class HttpMethodEnum
        {
            /// <summary>
            /// Enum GET for value: GET
            /// </summary>
            public static readonly HttpMethodEnum GET = new HttpMethodEnum("GET");

            /// <summary>
            /// Enum HEAD for value: HEAD
            /// </summary>
            public static readonly HttpMethodEnum HEAD = new HttpMethodEnum("HEAD");

            /// <summary>
            /// Enum POST for value: POST
            /// </summary>
            public static readonly HttpMethodEnum POST = new HttpMethodEnum("POST");

            /// <summary>
            /// Enum PUT for value: PUT
            /// </summary>
            public static readonly HttpMethodEnum PUT = new HttpMethodEnum("PUT");

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            public static readonly HttpMethodEnum DELETE = new HttpMethodEnum("DELETE");

            /// <summary>
            /// Enum TRACE for value: TRACE
            /// </summary>
            public static readonly HttpMethodEnum TRACE = new HttpMethodEnum("TRACE");

            /// <summary>
            /// Enum OPTIONS for value: OPTIONS
            /// </summary>
            public static readonly HttpMethodEnum OPTIONS = new HttpMethodEnum("OPTIONS");

            /// <summary>
            /// Enum CONNECT for value: CONNECT
            /// </summary>
            public static readonly HttpMethodEnum CONNECT = new HttpMethodEnum("CONNECT");

            /// <summary>
            /// Enum PATCH for value: PATCH
            /// </summary>
            public static readonly HttpMethodEnum PATCH = new HttpMethodEnum("PATCH");

            private static readonly Dictionary<string, HttpMethodEnum> StaticFields =
            new Dictionary<string, HttpMethodEnum>()
            {
                { "GET", GET },
                { "HEAD", HEAD },
                { "POST", POST },
                { "PUT", PUT },
                { "DELETE", DELETE },
                { "TRACE", TRACE },
                { "OPTIONS", OPTIONS },
                { "CONNECT", CONNECT },
                { "PATCH", PATCH },
            };

            private string Value;

            public HttpMethodEnum(string value)
            {
                Value = value;
            }

            public static HttpMethodEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as HttpMethodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HttpMethodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(HttpMethodEnum a, HttpMethodEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(HttpMethodEnum a, HttpMethodEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 健康检查的管理状态。取值： - true：表示开启健康检查，默认为true。 - false表示关闭健康检查。
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 健康检查间隔。健康检查间隔。取值：1-50s。
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public int? Delay { get; set; }

        /// <summary>
        /// 发送健康检查请求的域名。   取值：以数字或字母开头，只能包含数字、字母、’-’、’.’。不能传空，但可传null或不传，表示使用负载均衡器的vip作为http请求的目的地址。   使用说明：当type为HTTP/HTTPS时生效。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 期望响应状态码。取值：   - 单值：单个返回码，例如200。 - 列表：多个特定返回码，例如200，202。 - 区间：一个返回码区间，例如200-204。    默认值：200。   仅支持HTTP/HTTPS设置该字段，其他协议设置不会生效。
        /// </summary>
        [JsonProperty("expected_codes", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpectedCodes { get; set; }

        /// <summary>
        /// HTTP请求方法，取值：GET、HEAD、POST、PUT、DELETE、TRACE、OPTIONS、CONNECT、PATCH，默认GET。   使用说明：当type为HTTP/HTTPS时生效。   不支持该字段，请勿使用。
        /// </summary>
        [JsonProperty("http_method", NullValueHandling = NullValueHandling.Ignore)]
        public HttpMethodEnum HttpMethod { get; set; }
        /// <summary>
        /// 健康检查连续成功多少次后，将后端服务器的健康检查状态由OFFLINE判定为ONLINE。取值范围：1-10。
        /// </summary>
        [JsonProperty("max_retries", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// 健康检查连续失败多少次后，将后端服务器的健康检查状态由ONLINE判定为OFFLINE。取值范围：1-10。
        /// </summary>
        [JsonProperty("max_retries_down", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxRetriesDown { get; set; }

        /// <summary>
        /// 健康检查端口号。取值：1-65535，不可传入空，但可传入null，表示使用后端云服务器端口号。
        /// </summary>
        [JsonProperty("monitor_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? MonitorPort { get; set; }

        /// <summary>
        /// 健康检查名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 一次健康检查请求的超时时间。  建议该值小于delay的值。
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }

        /// <summary>
        /// 健康检查请求的请求路径。以\&quot;/\&quot;开头，默认为\&quot;/\&quot;。  使用说明：当type为HTTP/HTTPS时生效。
        /// </summary>
        [JsonProperty("url_path", NullValueHandling = NullValueHandling.Ignore)]
        public string UrlPath { get; set; }

        /// <summary>
        /// 健康检查请求协议。  取值：TCP、UDP_CONNECT、HTTP、HTTPS。  使用说明： - 若pool的protocol为QUIC，则type只能是UDP_CONNECT。 - 若pool的protocol为UDP，则type只能UDP_CONNECT。 - 若pool的protocol为TCP，则type可以是TCP、HTTP、HTTPS。 - 若pool的protocol为HTTP，则type可以是TCP、HTTP、HTTPS。 - 若pool的protocol为HTTPS，则type可以是TCP、HTTP、HTTPS。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateHealthMonitorOption {\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  expectedCodes: ").Append(ExpectedCodes).Append("\n");
            sb.Append("  httpMethod: ").Append(HttpMethod).Append("\n");
            sb.Append("  maxRetries: ").Append(MaxRetries).Append("\n");
            sb.Append("  maxRetriesDown: ").Append(MaxRetriesDown).Append("\n");
            sb.Append("  monitorPort: ").Append(MonitorPort).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  urlPath: ").Append(UrlPath).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateHealthMonitorOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateHealthMonitorOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.Delay == input.Delay ||
                    (this.Delay != null &&
                    this.Delay.Equals(input.Delay))
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.ExpectedCodes == input.ExpectedCodes ||
                    (this.ExpectedCodes != null &&
                    this.ExpectedCodes.Equals(input.ExpectedCodes))
                ) && 
                (
                    this.HttpMethod == input.HttpMethod ||
                    (this.HttpMethod != null &&
                    this.HttpMethod.Equals(input.HttpMethod))
                ) && 
                (
                    this.MaxRetries == input.MaxRetries ||
                    (this.MaxRetries != null &&
                    this.MaxRetries.Equals(input.MaxRetries))
                ) && 
                (
                    this.MaxRetriesDown == input.MaxRetriesDown ||
                    (this.MaxRetriesDown != null &&
                    this.MaxRetriesDown.Equals(input.MaxRetriesDown))
                ) && 
                (
                    this.MonitorPort == input.MonitorPort ||
                    (this.MonitorPort != null &&
                    this.MonitorPort.Equals(input.MonitorPort))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.UrlPath == input.UrlPath ||
                    (this.UrlPath != null &&
                    this.UrlPath.Equals(input.UrlPath))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Delay != null)
                    hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.ExpectedCodes != null)
                    hashCode = hashCode * 59 + this.ExpectedCodes.GetHashCode();
                if (this.HttpMethod != null)
                    hashCode = hashCode * 59 + this.HttpMethod.GetHashCode();
                if (this.MaxRetries != null)
                    hashCode = hashCode * 59 + this.MaxRetries.GetHashCode();
                if (this.MaxRetriesDown != null)
                    hashCode = hashCode * 59 + this.MaxRetriesDown.GetHashCode();
                if (this.MonitorPort != null)
                    hashCode = hashCode * 59 + this.MonitorPort.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.UrlPath != null)
                    hashCode = hashCode * 59 + this.UrlPath.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
