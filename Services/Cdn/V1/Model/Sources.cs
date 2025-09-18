using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 源站信息。
    /// </summary>
    public class Sources 
    {
        /// <summary>
        /// 源站类型取值：ipaddr：源站IP、 domain：源站域名、obs_bucket：OBS桶域名。源站为ipaddr时，仅支持IPv4，如需传入多个源站IP，以多个源站对象传入，除IP其他参数请保持一致，主源站最多支持50个源站IP对象，备源站最多支持50个源站IP对象；源站为domain时，仅支持1个源站对象。不支持IP源站和域名源站混用。
        /// </summary>
        /// <value>源站类型取值：ipaddr：源站IP、 domain：源站域名、obs_bucket：OBS桶域名。源站为ipaddr时，仅支持IPv4，如需传入多个源站IP，以多个源站对象传入，除IP其他参数请保持一致，主源站最多支持50个源站IP对象，备源站最多支持50个源站IP对象；源站为domain时，仅支持1个源站对象。不支持IP源站和域名源站混用。</value>
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
        /// 加速域名id。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 源站类型取值：ipaddr：源站IP、 domain：源站域名、obs_bucket：OBS桶域名。源站为ipaddr时，仅支持IPv4，如需传入多个源站IP，以多个源站对象传入，除IP其他参数请保持一致，主源站最多支持50个源站IP对象，备源站最多支持50个源站IP对象；源站为domain时，仅支持1个源站对象。不支持IP源站和域名源站混用。
        /// </summary>
        [JsonProperty("origin_type", NullValueHandling = NullValueHandling.Ignore)]
        public OriginTypeEnum OriginType { get; set; }
        /// <summary>
        /// 源站IP（非内网IP）或者域名。
        /// </summary>
        [JsonProperty("ip_or_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string IpOrDomain { get; set; }

        /// <summary>
        /// 主备状态，1代表主源站，0代表备源站。
        /// </summary>
        [JsonProperty("active_standby", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActiveStandby { get; set; }

        /// <summary>
        /// 是否开启Obs静态网站托管(0表示关闭,1表示则为开启)，源站类型为obs_bucket时传递。
        /// </summary>
        [JsonProperty("enable_obs_web_hosting", NullValueHandling = NullValueHandling.Ignore)]
        public int? EnableObsWebHosting { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Sources {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  originType: ").Append(OriginType).Append("\n");
            sb.Append("  ipOrDomain: ").Append(IpOrDomain).Append("\n");
            sb.Append("  activeStandby: ").Append(ActiveStandby).Append("\n");
            sb.Append("  enableObsWebHosting: ").Append(EnableObsWebHosting).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Sources);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Sources input)
        {
            if (input == null) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.OriginType != input.OriginType) return false;
            if (this.IpOrDomain != input.IpOrDomain || (this.IpOrDomain != null && !this.IpOrDomain.Equals(input.IpOrDomain))) return false;
            if (this.ActiveStandby != input.ActiveStandby || (this.ActiveStandby != null && !this.ActiveStandby.Equals(input.ActiveStandby))) return false;
            if (this.EnableObsWebHosting != input.EnableObsWebHosting || (this.EnableObsWebHosting != null && !this.EnableObsWebHosting.Equals(input.EnableObsWebHosting))) return false;

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
                hashCode = hashCode * 59 + this.OriginType.GetHashCode();
                if (this.IpOrDomain != null) hashCode = hashCode * 59 + this.IpOrDomain.GetHashCode();
                if (this.ActiveStandby != null) hashCode = hashCode * 59 + this.ActiveStandby.GetHashCode();
                if (this.EnableObsWebHosting != null) hashCode = hashCode * 59 + this.EnableObsWebHosting.GetHashCode();
                return hashCode;
            }
        }
    }
}
