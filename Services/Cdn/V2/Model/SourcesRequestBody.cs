using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// 源站信息
    /// </summary>
    public class SourcesRequestBody 
    {
        /// <summary>
        /// **参数解释：** 源站类型 **约束限制：** 不涉及 **取值范围：** - ipaddr: 源站IP - domain: 源站域名 - obs_bucket: OBS桶域名  **默认取值：** 不涉及
        /// </summary>
        /// <value>**参数解释：** 源站类型 **约束限制：** 不涉及 **取值范围：** - ipaddr: 源站IP - domain: 源站域名 - obs_bucket: OBS桶域名  **默认取值：** 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<OriginTypeEnum>))]
        public class OriginTypeEnum
        {
            /// <summary>
            /// Enum IPADDR for value: ipaddr
            /// </summary>
            public static readonly OriginTypeEnum IPADDR = new OriginTypeEnum("ipaddr");

            /// <summary>
            /// Enum DOMAIN for value: domain
            /// </summary>
            public static readonly OriginTypeEnum DOMAIN = new OriginTypeEnum("domain");

            /// <summary>
            /// Enum OBS_BUCKET for value: obs_bucket
            /// </summary>
            public static readonly OriginTypeEnum OBS_BUCKET = new OriginTypeEnum("obs_bucket");

            private static readonly Dictionary<string, OriginTypeEnum> StaticFields =
            new Dictionary<string, OriginTypeEnum>()
            {
                { "ipaddr", IPADDR },
                { "domain", DOMAIN },
                { "obs_bucket", OBS_BUCKET },
            };

            private string _value;

            public OriginTypeEnum()
            {

            }

            public OriginTypeEnum(string value)
            {
                _value = value;
            }

            public static OriginTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OriginTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OriginTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OriginTypeEnum a, OriginTypeEnum b)
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

            public static bool operator !=(OriginTypeEnum a, OriginTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 加速域名ID，系统自动生成，创建域名时无需传入此参数 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释：** 源站IP或者域名 **约束限制：** 不能配置内网IP **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("ip_or_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string IpOrDomain { get; set; }

        /// <summary>
        /// **参数解释：** 源站类型 **约束限制：** 不涉及 **取值范围：** - ipaddr: 源站IP - domain: 源站域名 - obs_bucket: OBS桶域名  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("origin_type", NullValueHandling = NullValueHandling.Ignore)]
        public OriginTypeEnum OriginType { get; set; }
        /// <summary>
        /// **参数解释：** OBS回源鉴权开关，适用于OBS桶源站场景，如果桶需要带鉴权访问，则需要打开OBS回源鉴权开关。如此，CDN节点回源时会携带鉴权信息，鉴权信息与OBS桶不匹配时，回源失败，避免非授权的请求盗刷流量 **约束限制：** 源站类型是“OBS桶域名”时需要传该参数 **取值范围：** - private: 开启回源鉴权开关 - public: 关闭回源鉴权开关  **默认取值：** public: 关闭回源鉴权开关
        /// </summary>
        [JsonProperty("obs_bucket_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketType { get; set; }

        /// <summary>
        /// **参数解释：** 设置主/备源站，主源站优先级高于备源站，CDN节点回源时优先回到主源站 &gt;- 主源站优先级默认为70，备源站优先级默认为30。  **约束限制：** 与priority二者至少传一个，同时存在时以priority为准 **取值范围：** - 1: 主源站 - 0: 备源站  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("active_standby", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActiveStandby { get; set; }

        /// <summary>
        /// **参数解释：** 源站优先级，数值越大优先级越高，创建域名时可用于替代active_standby指定源站优先级 **约束限制：** - 与active_standby二者至少传一个，同时存在时以priority为准 - 不同优先级数量不超过6个  **取值范围：** 1-1000 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// **参数解释：** 权重，值越大回源到该源站的次数越多。多个优先级相同的源站，由权重决定回源到各个源站的比例 **约束限制：** 不涉及 **取值范围：** 1-100 **默认取值：** 50
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }

        /// <summary>
        /// **参数解释：** 回源HOST **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 加速域名
        /// </summary>
        [JsonProperty("host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostName { get; set; }

        /// <summary>
        /// **参数解释：** 是否开启静态网站托管功能，如果您的源站是OBS桶域名且配置了静态网站托管，开启该功能后，客户端即可访问静态网站托管页面 &gt; 开启该功能后将自动给桶源站地址加上website字段，如果地址中已有website字段，该参数不生效 **约束限制：** - 源站类型为obs_bucket时需要传该参数 - 只有当源站OBS桶已经开启静态网站托管时，才可开启，否则将导致业务异常  **取值范围：** - 0: 关闭 - 1: 开启  **默认取值：** 0: 关闭
        /// </summary>
        [JsonProperty("enable_obs_web_hosting", NullValueHandling = NullValueHandling.Ignore)]
        public int? EnableObsWebHosting { get; set; }

        /// <summary>
        /// **参数解释：** HTTP端口 **约束限制：** 不涉及 **取值范围：** 1-65535 **默认取值：** 80
        /// </summary>
        [JsonProperty("http_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpPort { get; set; }

        /// <summary>
        /// **参数解释：** HTTPS端口 **约束限制：** 不涉及 **取值范围：** 1-65535 **默认取值：** 443
        /// </summary>
        [JsonProperty("https_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpsPort { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SourcesRequestBody {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  ipOrDomain: ").Append(IpOrDomain).Append("\n");
            sb.Append("  originType: ").Append(OriginType).Append("\n");
            sb.Append("  obsBucketType: ").Append(ObsBucketType).Append("\n");
            sb.Append("  activeStandby: ").Append(ActiveStandby).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("  hostName: ").Append(HostName).Append("\n");
            sb.Append("  enableObsWebHosting: ").Append(EnableObsWebHosting).Append("\n");
            sb.Append("  httpPort: ").Append(HttpPort).Append("\n");
            sb.Append("  httpsPort: ").Append(HttpsPort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SourcesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SourcesRequestBody input)
        {
            if (input == null) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.IpOrDomain != input.IpOrDomain || (this.IpOrDomain != null && !this.IpOrDomain.Equals(input.IpOrDomain))) return false;
            if (this.OriginType != input.OriginType) return false;
            if (this.ObsBucketType != input.ObsBucketType || (this.ObsBucketType != null && !this.ObsBucketType.Equals(input.ObsBucketType))) return false;
            if (this.ActiveStandby != input.ActiveStandby || (this.ActiveStandby != null && !this.ActiveStandby.Equals(input.ActiveStandby))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.Weight != input.Weight || (this.Weight != null && !this.Weight.Equals(input.Weight))) return false;
            if (this.HostName != input.HostName || (this.HostName != null && !this.HostName.Equals(input.HostName))) return false;
            if (this.EnableObsWebHosting != input.EnableObsWebHosting || (this.EnableObsWebHosting != null && !this.EnableObsWebHosting.Equals(input.EnableObsWebHosting))) return false;
            if (this.HttpPort != input.HttpPort || (this.HttpPort != null && !this.HttpPort.Equals(input.HttpPort))) return false;
            if (this.HttpsPort != input.HttpsPort || (this.HttpsPort != null && !this.HttpsPort.Equals(input.HttpsPort))) return false;

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
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.IpOrDomain != null) hashCode = hashCode * 59 + this.IpOrDomain.GetHashCode();
                hashCode = hashCode * 59 + this.OriginType.GetHashCode();
                if (this.ObsBucketType != null) hashCode = hashCode * 59 + this.ObsBucketType.GetHashCode();
                if (this.ActiveStandby != null) hashCode = hashCode * 59 + this.ActiveStandby.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Weight != null) hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.HostName != null) hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.EnableObsWebHosting != null) hashCode = hashCode * 59 + this.EnableObsWebHosting.GetHashCode();
                if (this.HttpPort != null) hashCode = hashCode * 59 + this.HttpPort.GetHashCode();
                if (this.HttpsPort != null) hashCode = hashCode * 59 + this.HttpsPort.GetHashCode();
                return hashCode;
            }
        }
    }
}
