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
    /// 
    /// </summary>
    public class UpdateHealthMonitorOption 
    {
        /// <summary>
        /// **参数解释**：HTTP请求方法。  **约束限制**：当type为HTTP/HTTPS时生效。  **取值范围**：GET、HEAD、POST  **默认取值**：不涉及
        /// </summary>
        /// <value>**参数解释**：HTTP请求方法。  **约束限制**：当type为HTTP/HTTPS时生效。  **取值范围**：GET、HEAD、POST  **默认取值**：不涉及</value>
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

            private static readonly Dictionary<string, HttpMethodEnum> StaticFields =
            new Dictionary<string, HttpMethodEnum>()
            {
                { "GET", GET },
                { "HEAD", HEAD },
                { "POST", POST },
            };

            private string _value;

            public HttpMethodEnum()
            {

            }

            public HttpMethodEnum(string value)
            {
                _value = value;
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HttpMethodEnum a, HttpMethodEnum b)
            {
                if (ReferenceEquals(a, b))
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
        /// **参数解释**：健康检查的管理状态。  **约束限制**：不涉及  **取值范围**： - true：表示开启健康检查。 - false：表示关闭健康检查。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// **参数解释**：健康检查间隔。健康检查间隔。  **约束限制**：不涉及  **取值范围**：1-50，单位：秒。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public int? Delay { get; set; }

        /// <summary>
        /// **参数解释**：发送健康检查请求的域名。  **约束限制**：当type为HTTP/HTTPS时生效。  **取值范围**：以数字或字母开头，只能包含数字、字母、’-’、’.’。 不能传空，但可传null或不传，表示使用负载均衡器的vip作为http请求的目的地址。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// **参数解释**：期望响应状态码。  **约束限制**：该字段仅在HTTP/HTTPS/GRPC协议下有效，其他协议可以设置但不会生效。  **取值范围**： - 单值：单个返回码，例如200。 - 列表：多个特定返回码，例如200，202。 - 区间：一个返回码区间，例如200-204。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("expected_codes", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpectedCodes { get; set; }

        /// <summary>
        /// **参数解释**：HTTP请求方法。  **约束限制**：当type为HTTP/HTTPS时生效。  **取值范围**：GET、HEAD、POST  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("http_method", NullValueHandling = NullValueHandling.Ignore)]
        public HttpMethodEnum HttpMethod { get; set; }
        /// <summary>
        /// **参数解释**：健康检查连续成功多少次后，将后端服务器的健康检查状态由OFFLINE判定为ONLINE。  **约束限制**：不涉及  **取值范围**：1-10  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("max_retries", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// **参数解释**：健康检查连续失败多少次后，将后端服务器的健康检查状态由ONLINE判定为OFFLINE。  **约束限制**：不涉及  **取值范围**：1-10  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("max_retries_down", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxRetriesDown { get; set; }

        /// <summary>
        /// **参数解释**：健康检查端口号。  [**约束限制**：不涉及](tag:hws,hws_hk,hws_eu_wb,hws_test,fcs,dt,hcso_dt,ctc,cmcc,tm,sbc,hk_sbc,hk_tm,hk_vdf,srg,g42,hk_g42) [**约束限制**：当pool协议为IP时，monitor_port必须指定为非0值。](tag:hws_eu)  **取值范围**：1-65535和null，传null表示使用后端服务器端口号。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("monitor_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? MonitorPort { get; set; }

        /// <summary>
        /// **参数解释**：健康检查名称。  **约束限制**：不涉及  **取值范围**：不涉及  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：一次健康检查请求的超时时间。  **约束限制**：不涉及  **取值范围**：建议该值小于delay的值。  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }

        /// <summary>
        /// **参数解释**：健康检查请求的请求路径。以\&quot;/\&quot;开头，默认为\&quot;/\&quot;。  **约束限制**：当type为HTTP/HTTPS时生效。  **取值范围**：支持使用字母、数字和短划线（-）、正斜线（/）、半角句号（.）、百分号（%）、半角问号（?）、井号（#）和and（&amp;）以及扩展字符集_;~!()*[]@$^:&#39;,+  **默认取值**：不涉及
        /// </summary>
        [JsonProperty("url_path", NullValueHandling = NullValueHandling.Ignore)]
        public string UrlPath { get; set; }

        /// <summary>
        /// **参数解释**：健康检查请求协议。  **约束限制**： - 若pool的protocol为QUIC，则type只能是UDP_CONNECT。 - 若pool的protocol为UDP，则type只能UDP_CONNECT。 - 若pool的protocol为TCP，则type可以是TCP、HTTP、HTTPS。 [- 若pool的protocol为IP，则type可以是TCP、HTTP、HTTPS。](tag:hws_eu) - 若pool的protocol为HTTP，则type可以是TCP、HTTP、HTTPS、TLS、GRPC。 - 若pool的protocol为HTTPS，则type可以是TCP、HTTP、HTTPS、TLS、GRPC。 - 若pool的protocol为GRPC，则type可以是TCP、HTTP、HTTPS、TLS、GRPC。 - 若pool的protocol为TLS，则type可以是TCP、HTTP、HTTPS、TLS、GRPC。 [- 不支持QUIC。](tag:tm,hws_eu,g42,hk_g42,hcso_dt) [- 荷兰region不支持QUIC。](tag:dt)  **取值范围**：TCP、UDP_CONNECT、HTTP、HTTPS、TLS和GRPC。  **默认取值**：不涉及
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
            if (input == null) return false;
            if (this.AdminStateUp != input.AdminStateUp || (this.AdminStateUp != null && !this.AdminStateUp.Equals(input.AdminStateUp))) return false;
            if (this.Delay != input.Delay || (this.Delay != null && !this.Delay.Equals(input.Delay))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.ExpectedCodes != input.ExpectedCodes || (this.ExpectedCodes != null && !this.ExpectedCodes.Equals(input.ExpectedCodes))) return false;
            if (this.HttpMethod != input.HttpMethod) return false;
            if (this.MaxRetries != input.MaxRetries || (this.MaxRetries != null && !this.MaxRetries.Equals(input.MaxRetries))) return false;
            if (this.MaxRetriesDown != input.MaxRetriesDown || (this.MaxRetriesDown != null && !this.MaxRetriesDown.Equals(input.MaxRetriesDown))) return false;
            if (this.MonitorPort != input.MonitorPort || (this.MonitorPort != null && !this.MonitorPort.Equals(input.MonitorPort))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Timeout != input.Timeout || (this.Timeout != null && !this.Timeout.Equals(input.Timeout))) return false;
            if (this.UrlPath != input.UrlPath || (this.UrlPath != null && !this.UrlPath.Equals(input.UrlPath))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.AdminStateUp != null) hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Delay != null) hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.ExpectedCodes != null) hashCode = hashCode * 59 + this.ExpectedCodes.GetHashCode();
                hashCode = hashCode * 59 + this.HttpMethod.GetHashCode();
                if (this.MaxRetries != null) hashCode = hashCode * 59 + this.MaxRetries.GetHashCode();
                if (this.MaxRetriesDown != null) hashCode = hashCode * 59 + this.MaxRetriesDown.GetHashCode();
                if (this.MonitorPort != null) hashCode = hashCode * 59 + this.MonitorPort.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Timeout != null) hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.UrlPath != null) hashCode = hashCode * 59 + this.UrlPath.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
