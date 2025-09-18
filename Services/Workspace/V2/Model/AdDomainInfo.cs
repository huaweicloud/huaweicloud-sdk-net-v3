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
    /// 域信息。
    /// </summary>
    public class AdDomainInfo 
    {
        /// <summary>
        /// 域类型。 - LITE_AS：LiteAS。 - LOCAL_AD：本地AD。 说明：域类型为“LOCAL_AD”时，请确保所选VPC网络与“LOCAL_AD”所属网络可连通。
        /// </summary>
        /// <value>域类型。 - LITE_AS：LiteAS。 - LOCAL_AD：本地AD。 说明：域类型为“LOCAL_AD”时，请确保所选VPC网络与“LOCAL_AD”所属网络可连通。</value>
        [JsonConverter(typeof(EnumClassConverter<DomainTypeEnum>))]
        public class DomainTypeEnum
        {
            /// <summary>
            /// Enum LITE_AS for value: LITE_AS
            /// </summary>
            public static readonly DomainTypeEnum LITE_AS = new DomainTypeEnum("LITE_AS");

            /// <summary>
            /// Enum LOCAL_AD for value: LOCAL_AD
            /// </summary>
            public static readonly DomainTypeEnum LOCAL_AD = new DomainTypeEnum("LOCAL_AD");

            private static readonly Dictionary<string, DomainTypeEnum> StaticFields =
            new Dictionary<string, DomainTypeEnum>()
            {
                { "LITE_AS", LITE_AS },
                { "LOCAL_AD", LOCAL_AD },
            };

            private string _value;

            public DomainTypeEnum()
            {

            }

            public DomainTypeEnum(string value)
            {
                _value = value;
            }

            public static DomainTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DomainTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DomainTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DomainTypeEnum a, DomainTypeEnum b)
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

            public static bool operator !=(DomainTypeEnum a, DomainTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 域类型。 - LITE_AS：LiteAS。 - LOCAL_AD：本地AD。 说明：域类型为“LOCAL_AD”时，请确保所选VPC网络与“LOCAL_AD”所属网络可连通。
        /// </summary>
        [JsonProperty("domain_type", NullValueHandling = NullValueHandling.Ignore)]
        public DomainTypeEnum DomainType { get; set; }
        /// <summary>
        /// 域管理员账号。
        /// </summary>
        [JsonProperty("domain_admin_account", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainAdminAccount { get; set; }

        /// <summary>
        /// 域管理员账号密码。
        /// </summary>
        [JsonProperty("domain_password", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdDomainInfo {\n");
            sb.Append("  domainType: ").Append(DomainType).Append("\n");
            sb.Append("  domainAdminAccount: ").Append(DomainAdminAccount).Append("\n");
            sb.Append("  domainPassword: ").Append(DomainPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdDomainInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AdDomainInfo input)
        {
            if (input == null) return false;
            if (this.DomainType != input.DomainType) return false;
            if (this.DomainAdminAccount != input.DomainAdminAccount || (this.DomainAdminAccount != null && !this.DomainAdminAccount.Equals(input.DomainAdminAccount))) return false;
            if (this.DomainPassword != input.DomainPassword || (this.DomainPassword != null && !this.DomainPassword.Equals(input.DomainPassword))) return false;

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
                hashCode = hashCode * 59 + this.DomainType.GetHashCode();
                if (this.DomainAdminAccount != null) hashCode = hashCode * 59 + this.DomainAdminAccount.GetHashCode();
                if (this.DomainPassword != null) hashCode = hashCode * 59 + this.DomainPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
