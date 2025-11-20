using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateDomainConfigRequestBody 
    {
        /// <summary>
        /// 源站类型。 0 - 源站IP， 1 - 源站域名。
        /// </summary>
        /// <value>源站类型。 0 - 源站IP， 1 - 源站域名。</value>
        [JsonConverter(typeof(EnumClassConverter<RealServerTypeEnum>))]
        public class RealServerTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly RealServerTypeEnum NUMBER_1 = new RealServerTypeEnum(1);

            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly RealServerTypeEnum NUMBER_0 = new RealServerTypeEnum(0);

            private static readonly Dictionary<int?, RealServerTypeEnum> StaticFields =
            new Dictionary<int?, RealServerTypeEnum>()
            {
                { 1, NUMBER_1 },
                { 0, NUMBER_0 },
            };

            private int? _value;

            public RealServerTypeEnum()
            {

            }

            public RealServerTypeEnum(int? value)
            {
                _value = value;
            }

            public static RealServerTypeEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as RealServerTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RealServerTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RealServerTypeEnum a, RealServerTypeEnum b)
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

            public static bool operator !=(RealServerTypeEnum a, RealServerTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 源站类型。 0 - 源站IP， 1 - 源站域名。
        /// </summary>
        [JsonProperty("real_server_type", NullValueHandling = NullValueHandling.Ignore)]
        public RealServerTypeEnum RealServerType { get; set; }
        /// <summary>
        /// 源站ip/源站域名
        /// </summary>
        [JsonProperty("real_server", NullValueHandling = NullValueHandling.Ignore)]
        public string RealServer { get; set; }

        /// <summary>
        /// HTTP端口，与port_https不能同时为空。DDoS高防支持的HTTP端口可用ListDomainPort接口查询。
        /// </summary>
        [JsonProperty("port_http", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> PortHttp { get; set; }

        /// <summary>
        /// HTTPS端口，与port_http不能同时为空。DDoS高防支持的HTTPS端口可用ListDomainPort接口查询。
        /// </summary>
        [JsonProperty("port_https", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> PortHttps { get; set; }

        /// <summary>
        /// 防护区域：0-中国大陆、1-中国大陆外
        /// </summary>
        [JsonProperty("overseas_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OverseasType { get; set; }

        /// <summary>
        /// 证书名称
        /// </summary>
        [JsonProperty("cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDomainConfigRequestBody {\n");
            sb.Append("  realServerType: ").Append(RealServerType).Append("\n");
            sb.Append("  realServer: ").Append(RealServer).Append("\n");
            sb.Append("  portHttp: ").Append(PortHttp).Append("\n");
            sb.Append("  portHttps: ").Append(PortHttps).Append("\n");
            sb.Append("  overseasType: ").Append(OverseasType).Append("\n");
            sb.Append("  certName: ").Append(CertName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDomainConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDomainConfigRequestBody input)
        {
            if (input == null) return false;
            if (this.RealServerType != input.RealServerType) return false;
            if (this.RealServer != input.RealServer || (this.RealServer != null && !this.RealServer.Equals(input.RealServer))) return false;
            if (this.PortHttp != input.PortHttp || (this.PortHttp != null && input.PortHttp != null && !this.PortHttp.SequenceEqual(input.PortHttp))) return false;
            if (this.PortHttps != input.PortHttps || (this.PortHttps != null && input.PortHttps != null && !this.PortHttps.SequenceEqual(input.PortHttps))) return false;
            if (this.OverseasType != input.OverseasType || (this.OverseasType != null && !this.OverseasType.Equals(input.OverseasType))) return false;
            if (this.CertName != input.CertName || (this.CertName != null && !this.CertName.Equals(input.CertName))) return false;

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
                hashCode = hashCode * 59 + this.RealServerType.GetHashCode();
                if (this.RealServer != null) hashCode = hashCode * 59 + this.RealServer.GetHashCode();
                if (this.PortHttp != null) hashCode = hashCode * 59 + this.PortHttp.GetHashCode();
                if (this.PortHttps != null) hashCode = hashCode * 59 + this.PortHttps.GetHashCode();
                if (this.OverseasType != null) hashCode = hashCode * 59 + this.OverseasType.GetHashCode();
                if (this.CertName != null) hashCode = hashCode * 59 + this.CertName.GetHashCode();
                return hashCode;
            }
        }
    }
}
