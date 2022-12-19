using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// 更新健康检查请求
    /// </summary>
    public class UpdateHealthmonitorReq 
    {

        /// <summary>
        /// 健康检查名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 健康检查的管理状态；该字段虽然支持创建、更新，但实际取值决定于后端云服务器对应的弹性云服务器是否存在。若存在，该值为true，否则，该值为false。
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 健康检查端口号。默认为空，表示使用后端云服务器组的端口。
        /// </summary>
        [JsonProperty("monitor_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? MonitorPort { get; set; }

        /// <summary>
        /// 健康检查的超时时间。建议该值小于delay的值。
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }

        /// <summary>
        /// 期望HTTP响应状态码，指定下列值：单值，例如200；列表，例如200，202；区间，例如200-204。仅当type为HTTP时生效。该字段为预留字段，暂未启用。
        /// </summary>
        [JsonProperty("expected_codes", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpectedCodes { get; set; }

        /// <summary>
        /// 功能说明：健康检查测试member健康状态时，发送的http请求的域名。仅当type为HTTP时生效。使用说明：默认为空，表示使用负载均衡器的vip作为http请求的目的地址。以数字或字母开头，只能包含数字、字母、’-’、’.’。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// HTTP方法，可以为GET、HEAD、POST、PUT、DELETE、TRACE、OPTIONS、CONNECT、PATCH。仅当type为HTTP时生效。该字段为预留字段，暂未启用。
        /// </summary>
        [JsonProperty("url_path", NullValueHandling = NullValueHandling.Ignore)]
        public string UrlPath { get; set; }

        /// <summary>
        /// HTTP方法，可以为GET、HEAD、POST、PUT、DELETE、TRACE、OPTIONS、CONNECT、PATCH。仅当type为HTTP时生效。该字段为预留字段，暂未启用。
        /// </summary>
        [JsonProperty("http_method", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpMethod { get; set; }

        /// <summary>
        /// 健康检查间隔
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public int? Delay { get; set; }

        /// <summary>
        /// 最大重试次数
        /// </summary>
        [JsonProperty("max_retries", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// 健康检查的类型。  取值范围：TCP、UDP_CONNECT、HTTP。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateHealthmonitorReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  monitorPort: ").Append(MonitorPort).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  expectedCodes: ").Append(ExpectedCodes).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  urlPath: ").Append(UrlPath).Append("\n");
            sb.Append("  httpMethod: ").Append(HttpMethod).Append("\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("  maxRetries: ").Append(MaxRetries).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateHealthmonitorReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateHealthmonitorReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.MonitorPort == input.MonitorPort ||
                    (this.MonitorPort != null &&
                    this.MonitorPort.Equals(input.MonitorPort))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.ExpectedCodes == input.ExpectedCodes ||
                    (this.ExpectedCodes != null &&
                    this.ExpectedCodes.Equals(input.ExpectedCodes))
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.UrlPath == input.UrlPath ||
                    (this.UrlPath != null &&
                    this.UrlPath.Equals(input.UrlPath))
                ) && 
                (
                    this.HttpMethod == input.HttpMethod ||
                    (this.HttpMethod != null &&
                    this.HttpMethod.Equals(input.HttpMethod))
                ) && 
                (
                    this.Delay == input.Delay ||
                    (this.Delay != null &&
                    this.Delay.Equals(input.Delay))
                ) && 
                (
                    this.MaxRetries == input.MaxRetries ||
                    (this.MaxRetries != null &&
                    this.MaxRetries.Equals(input.MaxRetries))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.MonitorPort != null)
                    hashCode = hashCode * 59 + this.MonitorPort.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.ExpectedCodes != null)
                    hashCode = hashCode * 59 + this.ExpectedCodes.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.UrlPath != null)
                    hashCode = hashCode * 59 + this.UrlPath.GetHashCode();
                if (this.HttpMethod != null)
                    hashCode = hashCode * 59 + this.HttpMethod.GetHashCode();
                if (this.Delay != null)
                    hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.MaxRetries != null)
                    hashCode = hashCode * 59 + this.MaxRetries.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
