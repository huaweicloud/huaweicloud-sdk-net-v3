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
    /// 域名信息。
    /// </summary>
    public class SourceWithPort 
    {
        /// <summary>
        /// 源站类型，ipaddr：源站IP、 domain：源站域名、obs_bucket：OBS桶域名。
        /// </summary>
        /// <value>源站类型，ipaddr：源站IP、 domain：源站域名、obs_bucket：OBS桶域名。</value>
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
        /// **参数解释：** 加速域名id。 **约束限制：** 不涉及 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释：** 源站IP（非内网IP）或者域名。 **约束限制：** 不涉及 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("ip_or_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string IpOrDomain { get; set; }

        /// <summary>
        /// 源站类型，ipaddr：源站IP、 domain：源站域名、obs_bucket：OBS桶域名。
        /// </summary>
        [JsonProperty("origin_type", NullValueHandling = NullValueHandling.Ignore)]
        public OriginTypeEnum OriginType { get; set; }
        /// <summary>
        /// OBS桶类型。   - private: 私有桶（除桶ACL授权外的其他用户无桶的访问权限）。   - public: 公有桶（任何用户都可以对桶内对象进行读操作）。
        /// </summary>
        [JsonProperty("obs_bucket_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketType { get; set; }

        /// <summary>
        /// 主备状态（1代表主源站；0代表备源站）。
        /// </summary>
        [JsonProperty("active_standby", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActiveStandby { get; set; }

        /// <summary>
        /// **参数解释：** 是否开启静态网站托管功能，如果您的源站是OBS桶域名且配置了静态网站托管，开启该功能后，客户端即可访问静态网站托管页面 &gt; 开启该功能后将自动给桶源站地址加上website字段，如果地址中已有website字段，该参数不生效 **约束限制：** - 源站类型为obs_bucket时需要传该参数 - 只有当源站OBS桶已经开启静态网站托管时，才可开启，否则将导致业务异常  **取值范围：** - 0: 关闭 - 1: 开启  **默认取值：** 0: 关闭
        /// </summary>
        [JsonProperty("enable_obs_web_hosting", NullValueHandling = NullValueHandling.Ignore)]
        public int? EnableObsWebHosting { get; set; }

        /// <summary>
        /// **参数解释：** HTTP端口，默认80 **约束限制：** 不涉及 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("http_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpPort { get; set; }

        /// <summary>
        /// **参数解释：** HTTPS端口，默认443 **约束限制：** 不涉及 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("https_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? HttpsPort { get; set; }

        /// <summary>
        /// **参数解释：** 权重，值越大回源到该源站的次数越多。多个优先级相同的源站，由权重决定回源到各个源站的比例 **约束限制：** 不涉及 **取值范围：** 1-100 **默认取值：** 50
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SourceWithPort {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  ipOrDomain: ").Append(IpOrDomain).Append("\n");
            sb.Append("  originType: ").Append(OriginType).Append("\n");
            sb.Append("  obsBucketType: ").Append(ObsBucketType).Append("\n");
            sb.Append("  activeStandby: ").Append(ActiveStandby).Append("\n");
            sb.Append("  enableObsWebHosting: ").Append(EnableObsWebHosting).Append("\n");
            sb.Append("  httpPort: ").Append(HttpPort).Append("\n");
            sb.Append("  httpsPort: ").Append(HttpsPort).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SourceWithPort);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SourceWithPort input)
        {
            if (input == null) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.IpOrDomain != input.IpOrDomain || (this.IpOrDomain != null && !this.IpOrDomain.Equals(input.IpOrDomain))) return false;
            if (this.OriginType != input.OriginType) return false;
            if (this.ObsBucketType != input.ObsBucketType || (this.ObsBucketType != null && !this.ObsBucketType.Equals(input.ObsBucketType))) return false;
            if (this.ActiveStandby != input.ActiveStandby || (this.ActiveStandby != null && !this.ActiveStandby.Equals(input.ActiveStandby))) return false;
            if (this.EnableObsWebHosting != input.EnableObsWebHosting || (this.EnableObsWebHosting != null && !this.EnableObsWebHosting.Equals(input.EnableObsWebHosting))) return false;
            if (this.HttpPort != input.HttpPort || (this.HttpPort != null && !this.HttpPort.Equals(input.HttpPort))) return false;
            if (this.HttpsPort != input.HttpsPort || (this.HttpsPort != null && !this.HttpsPort.Equals(input.HttpsPort))) return false;
            if (this.Weight != input.Weight || (this.Weight != null && !this.Weight.Equals(input.Weight))) return false;

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
                if (this.EnableObsWebHosting != null) hashCode = hashCode * 59 + this.EnableObsWebHosting.GetHashCode();
                if (this.HttpPort != null) hashCode = hashCode * 59 + this.HttpPort.GetHashCode();
                if (this.HttpsPort != null) hashCode = hashCode * 59 + this.HttpsPort.GetHashCode();
                if (this.Weight != null) hashCode = hashCode * 59 + this.Weight.GetHashCode();
                return hashCode;
            }
        }
    }
}
