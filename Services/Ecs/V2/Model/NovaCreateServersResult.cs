using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    ///  
    /// </summary>
    public class NovaCreateServersResult 
    {
        /// <summary>
        /// diskConfig方式。  - MANUAL，镜像空间不会扩展。 - AUTO，系统盘镜像空间会自动扩展为与flavor大小一致。
        /// </summary>
        /// <value>diskConfig方式。  - MANUAL，镜像空间不会扩展。 - AUTO，系统盘镜像空间会自动扩展为与flavor大小一致。</value>
        [JsonConverter(typeof(EnumClassConverter<OSDCFdiskConfigEnum>))]
        public class OSDCFdiskConfigEnum
        {
            /// <summary>
            /// Enum MANUAL for value: MANUAL
            /// </summary>
            public static readonly OSDCFdiskConfigEnum MANUAL = new OSDCFdiskConfigEnum("MANUAL");

            /// <summary>
            /// Enum AUTO for value: AUTO
            /// </summary>
            public static readonly OSDCFdiskConfigEnum AUTO = new OSDCFdiskConfigEnum("AUTO");

            private static readonly Dictionary<string, OSDCFdiskConfigEnum> StaticFields =
            new Dictionary<string, OSDCFdiskConfigEnum>()
            {
                { "MANUAL", MANUAL },
                { "AUTO", AUTO },
            };

            private string _value;

            public OSDCFdiskConfigEnum()
            {

            }

            public OSDCFdiskConfigEnum(string value)
            {
                _value = value;
            }

            public static OSDCFdiskConfigEnum FromValue(string value)
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

                if (this.Equals(obj as OSDCFdiskConfigEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OSDCFdiskConfigEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OSDCFdiskConfigEnum a, OSDCFdiskConfigEnum b)
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

            public static bool operator !=(OSDCFdiskConfigEnum a, OSDCFdiskConfigEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 弹性云服务器uuid。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 弹性云服务器URI自描述信息。
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<NovaLink> Links { get; set; }

        /// <summary>
        /// 弹性云服务器所在安全组。
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<NovaServerSecurityGroup> SecurityGroups { get; set; }

        /// <summary>
        /// diskConfig方式。  - MANUAL，镜像空间不会扩展。 - AUTO，系统盘镜像空间会自动扩展为与flavor大小一致。
        /// </summary>
        [JsonProperty("OS-DCF:diskConfig", NullValueHandling = NullValueHandling.Ignore)]
        public OSDCFdiskConfigEnum OSDCFdiskConfig { get; set; }
        /// <summary>
        /// 通过返回的reservation_id，可以过滤查询到本次创建的弹性云服务器。  &gt; 说明： &gt;  &gt; 批量创建弹性云服务器时，支持使用该字段。
        /// </summary>
        [JsonProperty("reservation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReservationId { get; set; }

        /// <summary>
        /// Windows弹性云服务器Administrator用户的密码。
        /// </summary>
        [JsonProperty("adminPass", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminPass { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaCreateServersResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  oSDCFdiskConfig: ").Append(OSDCFdiskConfig).Append("\n");
            sb.Append("  reservationId: ").Append(ReservationId).Append("\n");
            sb.Append("  adminPass: ").Append(AdminPass).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaCreateServersResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaCreateServersResult input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Links != input.Links || (this.Links != null && input.Links != null && !this.Links.SequenceEqual(input.Links))) return false;
            if (this.SecurityGroups != input.SecurityGroups || (this.SecurityGroups != null && input.SecurityGroups != null && !this.SecurityGroups.SequenceEqual(input.SecurityGroups))) return false;
            if (this.OSDCFdiskConfig != input.OSDCFdiskConfig) return false;
            if (this.ReservationId != input.ReservationId || (this.ReservationId != null && !this.ReservationId.Equals(input.ReservationId))) return false;
            if (this.AdminPass != input.AdminPass || (this.AdminPass != null && !this.AdminPass.Equals(input.AdminPass))) return false;

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
                if (this.Links != null) hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.SecurityGroups != null) hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                hashCode = hashCode * 59 + this.OSDCFdiskConfig.GetHashCode();
                if (this.ReservationId != null) hashCode = hashCode * 59 + this.ReservationId.GetHashCode();
                if (this.AdminPass != null) hashCode = hashCode * 59 + this.AdminPass.GetHashCode();
                return hashCode;
            }
        }
    }
}
