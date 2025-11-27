using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ga.V1.Model
{
    /// <summary>
    /// 自带IP地址池。
    /// </summary>
    public class ByoipPool 
    {
        /// <summary>
        /// IP地址类型。 取值范围：IPV4、IPV6
        /// </summary>
        /// <value>IP地址类型。 取值范围：IPV4、IPV6</value>
        [JsonConverter(typeof(EnumClassConverter<IpTypeEnum>))]
        public class IpTypeEnum
        {
            /// <summary>
            /// Enum IPV4 for value: IPV4
            /// </summary>
            public static readonly IpTypeEnum IPV4 = new IpTypeEnum("IPV4");

            /// <summary>
            /// Enum IPV6 for value: IPV6
            /// </summary>
            public static readonly IpTypeEnum IPV6 = new IpTypeEnum("IPV6");

            private static readonly Dictionary<string, IpTypeEnum> StaticFields =
            new Dictionary<string, IpTypeEnum>()
            {
                { "IPV4", IPV4 },
                { "IPV6", IPV6 },
            };

            private string _value;

            public IpTypeEnum()
            {

            }

            public IpTypeEnum(string value)
            {
                _value = value;
            }

            public static IpTypeEnum FromValue(string value)
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

                if (this.Equals(obj as IpTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IpTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IpTypeEnum a, IpTypeEnum b)
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

            public static bool operator !=(IpTypeEnum a, IpTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 自带IP地址池ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 自带IP地址池的IP网段。
        /// </summary>
        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string Cidr { get; set; }

        /// <summary>
        /// IP地址类型。 取值范围：IPV4、IPV6
        /// </summary>
        [JsonProperty("ip_type", NullValueHandling = NullValueHandling.Ignore)]
        public IpTypeEnum IpType { get; set; }
        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("area", NullValueHandling = NullValueHandling.Ignore)]
        public Area? Area { get; set; }

        /// <summary>
        /// 租户ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ByoipPool {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  ipType: ").Append(IpType).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  area: ").Append(Area).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ByoipPool);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ByoipPool input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Cidr != input.Cidr || (this.Cidr != null && !this.Cidr.Equals(input.Cidr))) return false;
            if (this.IpType != input.IpType) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.Area != input.Area || (this.Area != null && !this.Area.Equals(input.Area))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Cidr != null) hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                hashCode = hashCode * 59 + this.IpType.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Area != null) hashCode = hashCode * 59 + this.Area.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                return hashCode;
            }
        }
    }
}
