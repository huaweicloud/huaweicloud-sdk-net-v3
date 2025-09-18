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
    public class AdDomain 
    {
        /// <summary>
        /// 域类型。 - LITE_AS：本地认证。 - LOCAL_AD：本地AD。 说明：域类型为“LOCAL_AD”时，请确保所选VPC网络与AD所属网络可连通。
        /// </summary>
        /// <value>域类型。 - LITE_AS：本地认证。 - LOCAL_AD：本地AD。 说明：域类型为“LOCAL_AD”时，请确保所选VPC网络与AD所属网络可连通。</value>
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
        /// 域类型。 - LITE_AS：本地认证。 - LOCAL_AD：本地AD。 说明：域类型为“LOCAL_AD”时，请确保所选VPC网络与AD所属网络可连通。
        /// </summary>
        [JsonProperty("domain_type", NullValueHandling = NullValueHandling.Ignore)]
        public DomainTypeEnum DomainType { get; set; }
        /// <summary>
        /// 域名称。域类型为LOCAL_AD时需要配置。 域名必须为AD服务器上已经存在的域名，且长度不超过55。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 域管理员账号。域类型为LOCAL_AD时需要配置。 必须为AD服务器上已经存在的域管理员账号。
        /// </summary>
        [JsonProperty("domain_admin_account", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainAdminAccount { get; set; }

        /// <summary>
        /// 域管理员账号密码。域类型为LOCAL_AD时需要配置。
        /// </summary>
        [JsonProperty("domain_password", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainPassword { get; set; }

        /// <summary>
        /// 主域控制器IP地址。域类型为LOCAL_AD时需要配置。
        /// </summary>
        [JsonProperty("active_domain_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveDomainIp { get; set; }

        /// <summary>
        /// 主域控制器名称。域类型为LOCAL_AD时需要配置。
        /// </summary>
        [JsonProperty("active_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveDomainName { get; set; }

        /// <summary>
        /// 备域控制器IP地址。域类型为LOCAL_AD时且配置备节点时需要配置。
        /// </summary>
        [JsonProperty("standby_domain_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string StandbyDomainIp { get; set; }

        /// <summary>
        /// 备域控制器名称。域类型为LOCAL_AD时且配置备节点时需要配置。
        /// </summary>
        [JsonProperty("standby_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StandbyDomainName { get; set; }

        /// <summary>
        /// 主DNS IP地址。域类型为LOCAL_AD时需要配置。
        /// </summary>
        [JsonProperty("active_dns_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ActiveDnsIp { get; set; }

        /// <summary>
        /// 备DNS IP地址。域类型为LOCAL_AD时且配置备节点时需要配置。
        /// </summary>
        [JsonProperty("standby_dns_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string StandbyDnsIp { get; set; }

        /// <summary>
        /// 是否在删除桌面的同时删除AD上对应的计算机对象，0代表不删除，1代表删除。
        /// </summary>
        [JsonProperty("delete_computer_object", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeleteComputerObject { get; set; }

        /// <summary>
        /// 是否开启LDAPS。
        /// </summary>
        [JsonProperty("use_ldaps", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseLdaps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tls_config", NullValueHandling = NullValueHandling.Ignore)]
        public TlsConfig TlsConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdDomain {\n");
            sb.Append("  domainType: ").Append(DomainType).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  domainAdminAccount: ").Append(DomainAdminAccount).Append("\n");
            sb.Append("  domainPassword: ").Append(DomainPassword).Append("\n");
            sb.Append("  activeDomainIp: ").Append(ActiveDomainIp).Append("\n");
            sb.Append("  activeDomainName: ").Append(ActiveDomainName).Append("\n");
            sb.Append("  standbyDomainIp: ").Append(StandbyDomainIp).Append("\n");
            sb.Append("  standbyDomainName: ").Append(StandbyDomainName).Append("\n");
            sb.Append("  activeDnsIp: ").Append(ActiveDnsIp).Append("\n");
            sb.Append("  standbyDnsIp: ").Append(StandbyDnsIp).Append("\n");
            sb.Append("  deleteComputerObject: ").Append(DeleteComputerObject).Append("\n");
            sb.Append("  useLdaps: ").Append(UseLdaps).Append("\n");
            sb.Append("  tlsConfig: ").Append(TlsConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdDomain);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AdDomain input)
        {
            if (input == null) return false;
            if (this.DomainType != input.DomainType) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.DomainAdminAccount != input.DomainAdminAccount || (this.DomainAdminAccount != null && !this.DomainAdminAccount.Equals(input.DomainAdminAccount))) return false;
            if (this.DomainPassword != input.DomainPassword || (this.DomainPassword != null && !this.DomainPassword.Equals(input.DomainPassword))) return false;
            if (this.ActiveDomainIp != input.ActiveDomainIp || (this.ActiveDomainIp != null && !this.ActiveDomainIp.Equals(input.ActiveDomainIp))) return false;
            if (this.ActiveDomainName != input.ActiveDomainName || (this.ActiveDomainName != null && !this.ActiveDomainName.Equals(input.ActiveDomainName))) return false;
            if (this.StandbyDomainIp != input.StandbyDomainIp || (this.StandbyDomainIp != null && !this.StandbyDomainIp.Equals(input.StandbyDomainIp))) return false;
            if (this.StandbyDomainName != input.StandbyDomainName || (this.StandbyDomainName != null && !this.StandbyDomainName.Equals(input.StandbyDomainName))) return false;
            if (this.ActiveDnsIp != input.ActiveDnsIp || (this.ActiveDnsIp != null && !this.ActiveDnsIp.Equals(input.ActiveDnsIp))) return false;
            if (this.StandbyDnsIp != input.StandbyDnsIp || (this.StandbyDnsIp != null && !this.StandbyDnsIp.Equals(input.StandbyDnsIp))) return false;
            if (this.DeleteComputerObject != input.DeleteComputerObject || (this.DeleteComputerObject != null && !this.DeleteComputerObject.Equals(input.DeleteComputerObject))) return false;
            if (this.UseLdaps != input.UseLdaps || (this.UseLdaps != null && !this.UseLdaps.Equals(input.UseLdaps))) return false;
            if (this.TlsConfig != input.TlsConfig || (this.TlsConfig != null && !this.TlsConfig.Equals(input.TlsConfig))) return false;

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
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.DomainAdminAccount != null) hashCode = hashCode * 59 + this.DomainAdminAccount.GetHashCode();
                if (this.DomainPassword != null) hashCode = hashCode * 59 + this.DomainPassword.GetHashCode();
                if (this.ActiveDomainIp != null) hashCode = hashCode * 59 + this.ActiveDomainIp.GetHashCode();
                if (this.ActiveDomainName != null) hashCode = hashCode * 59 + this.ActiveDomainName.GetHashCode();
                if (this.StandbyDomainIp != null) hashCode = hashCode * 59 + this.StandbyDomainIp.GetHashCode();
                if (this.StandbyDomainName != null) hashCode = hashCode * 59 + this.StandbyDomainName.GetHashCode();
                if (this.ActiveDnsIp != null) hashCode = hashCode * 59 + this.ActiveDnsIp.GetHashCode();
                if (this.StandbyDnsIp != null) hashCode = hashCode * 59 + this.StandbyDnsIp.GetHashCode();
                if (this.DeleteComputerObject != null) hashCode = hashCode * 59 + this.DeleteComputerObject.GetHashCode();
                if (this.UseLdaps != null) hashCode = hashCode * 59 + this.UseLdaps.GetHashCode();
                if (this.TlsConfig != null) hashCode = hashCode * 59 + this.TlsConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
