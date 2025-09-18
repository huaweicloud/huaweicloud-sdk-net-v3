using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// NAT映射配置。
    /// </summary>
    public class UpdateNatMappingConfig 
    {
        /// <summary>
        /// NAT映射类型。 - PORT:端口映射. - HOST:地址映射,最多支持配置10个地址.
        /// </summary>
        /// <value>NAT映射类型。 - PORT:端口映射. - HOST:地址映射,最多支持配置10个地址.</value>
        [JsonConverter(typeof(EnumClassConverter<NatMapTypeEnum>))]
        public class NatMapTypeEnum
        {
            /// <summary>
            /// Enum PORT for value: PORT
            /// </summary>
            public static readonly NatMapTypeEnum PORT = new NatMapTypeEnum("PORT");

            /// <summary>
            /// Enum HOST for value: HOST
            /// </summary>
            public static readonly NatMapTypeEnum HOST = new NatMapTypeEnum("HOST");

            private static readonly Dictionary<string, NatMapTypeEnum> StaticFields =
            new Dictionary<string, NatMapTypeEnum>()
            {
                { "PORT", PORT },
                { "HOST", HOST },
            };

            private string _value;

            public NatMapTypeEnum()
            {

            }

            public NatMapTypeEnum(string value)
            {
                _value = value;
            }

            public static NatMapTypeEnum FromValue(string value)
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

                if (this.Equals(obj as NatMapTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NatMapTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NatMapTypeEnum a, NatMapTypeEnum b)
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

            public static bool operator !=(NatMapTypeEnum a, NatMapTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// NAT映射类型。 - PORT:端口映射. - HOST:地址映射,最多支持配置10个地址.
        /// </summary>
        [JsonProperty("nat_map_type", NullValueHandling = NullValueHandling.Ignore)]
        public NatMapTypeEnum NatMapType { get; set; }
        /// <summary>
        /// nat_map_type为PORT时表示端口,取值9443/9445. nat_map_type为HOST时表示接入地址.
        /// </summary>
        [JsonProperty("nat_map_value", NullValueHandling = NullValueHandling.Ignore)]
        public string NatMapValue { get; set; }

        /// <summary>
        /// nat Ip。
        /// </summary>
        [JsonProperty("nat_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string NatIp { get; set; }

        /// <summary>
        /// nat端口,取值范围0-65535。
        /// </summary>
        [JsonProperty("nat_port", NullValueHandling = NullValueHandling.Ignore)]
        public string NatPort { get; set; }

        /// <summary>
        /// vag Ip。
        /// </summary>
        [JsonProperty("vag_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string VagIp { get; set; }

        /// <summary>
        /// 是否支持标签、企业项目管理。0表示不开启，1表示开启。
        /// </summary>
        [JsonProperty("access_filter_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessFilterType { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 标签对象。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNatMappingConfig {\n");
            sb.Append("  natMapType: ").Append(NatMapType).Append("\n");
            sb.Append("  natMapValue: ").Append(NatMapValue).Append("\n");
            sb.Append("  natIp: ").Append(NatIp).Append("\n");
            sb.Append("  natPort: ").Append(NatPort).Append("\n");
            sb.Append("  vagIp: ").Append(VagIp).Append("\n");
            sb.Append("  accessFilterType: ").Append(AccessFilterType).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateNatMappingConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateNatMappingConfig input)
        {
            if (input == null) return false;
            if (this.NatMapType != input.NatMapType) return false;
            if (this.NatMapValue != input.NatMapValue || (this.NatMapValue != null && !this.NatMapValue.Equals(input.NatMapValue))) return false;
            if (this.NatIp != input.NatIp || (this.NatIp != null && !this.NatIp.Equals(input.NatIp))) return false;
            if (this.NatPort != input.NatPort || (this.NatPort != null && !this.NatPort.Equals(input.NatPort))) return false;
            if (this.VagIp != input.VagIp || (this.VagIp != null && !this.VagIp.Equals(input.VagIp))) return false;
            if (this.AccessFilterType != input.AccessFilterType || (this.AccessFilterType != null && !this.AccessFilterType.Equals(input.AccessFilterType))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;

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
                hashCode = hashCode * 59 + this.NatMapType.GetHashCode();
                if (this.NatMapValue != null) hashCode = hashCode * 59 + this.NatMapValue.GetHashCode();
                if (this.NatIp != null) hashCode = hashCode * 59 + this.NatIp.GetHashCode();
                if (this.NatPort != null) hashCode = hashCode * 59 + this.NatPort.GetHashCode();
                if (this.VagIp != null) hashCode = hashCode * 59 + this.VagIp.GetHashCode();
                if (this.AccessFilterType != null) hashCode = hashCode * 59 + this.AccessFilterType.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
