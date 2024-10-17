using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// 防护ip列表
    /// </summary>
    public class ProtectedIpResponse 
    {
        /// <summary>
        /// 类型。VPN：VPN；NAT：NAT；VIP：VIP；CCI：CCI；EIP：弹性公网IP；ELB：弹性负载均衡；REROUTING_IP：REROUTING_IP；SubEni：SubEni；NetInterFace：NetInterFace；
        /// </summary>
        /// <value>类型。VPN：VPN；NAT：NAT；VIP：VIP；CCI：CCI；EIP：弹性公网IP；ELB：弹性负载均衡；REROUTING_IP：REROUTING_IP；SubEni：SubEni；NetInterFace：NetInterFace；</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum VPN for value: VPN
            /// </summary>
            public static readonly TypeEnum VPN = new TypeEnum("VPN");

            /// <summary>
            /// Enum NAT for value: NAT
            /// </summary>
            public static readonly TypeEnum NAT = new TypeEnum("NAT");

            /// <summary>
            /// Enum VIP for value: VIP
            /// </summary>
            public static readonly TypeEnum VIP = new TypeEnum("VIP");

            /// <summary>
            /// Enum CCI for value: CCI
            /// </summary>
            public static readonly TypeEnum CCI = new TypeEnum("CCI");

            /// <summary>
            /// Enum EIP for value: EIP
            /// </summary>
            public static readonly TypeEnum EIP = new TypeEnum("EIP");

            /// <summary>
            /// Enum ELB for value: ELB
            /// </summary>
            public static readonly TypeEnum ELB = new TypeEnum("ELB");

            /// <summary>
            /// Enum REROUTING_IP for value: REROUTING_IP
            /// </summary>
            public static readonly TypeEnum REROUTING_IP = new TypeEnum("REROUTING_IP");

            /// <summary>
            /// Enum SUBENI for value: SubEni
            /// </summary>
            public static readonly TypeEnum SUBENI = new TypeEnum("SubEni");

            /// <summary>
            /// Enum NETINTERFACE for value: NetInterFace
            /// </summary>
            public static readonly TypeEnum NETINTERFACE = new TypeEnum("NetInterFace");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "VPN", VPN },
                { "NAT", NAT },
                { "VIP", VIP },
                { "CCI", CCI },
                { "EIP", EIP },
                { "ELB", ELB },
                { "REROUTING_IP", REROUTING_IP },
                { "SubEni", SUBENI },
                { "NetInterFace", NETINTERFACE },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// package_version。cnad_pro：专业版；cnad_ip：标准版；cnad_ep：铂金版；cnad_full_high：全力防高级版；cnad_vic：按需版；cnad_intl_ep：国际站铂金版
        /// </summary>
        /// <value>package_version。cnad_pro：专业版；cnad_ip：标准版；cnad_ep：铂金版；cnad_full_high：全力防高级版；cnad_vic：按需版；cnad_intl_ep：国际站铂金版</value>
        [JsonConverter(typeof(EnumClassConverter<PackageVersionEnum>))]
        public class PackageVersionEnum
        {
            /// <summary>
            /// Enum CNAD_PRO for value: cnad_pro
            /// </summary>
            public static readonly PackageVersionEnum CNAD_PRO = new PackageVersionEnum("cnad_pro");

            /// <summary>
            /// Enum CNAD_IP for value: cnad_ip
            /// </summary>
            public static readonly PackageVersionEnum CNAD_IP = new PackageVersionEnum("cnad_ip");

            /// <summary>
            /// Enum CNAD_EP for value: cnad_ep
            /// </summary>
            public static readonly PackageVersionEnum CNAD_EP = new PackageVersionEnum("cnad_ep");

            /// <summary>
            /// Enum CNAD_FULL_HIGH for value: cnad_full_high
            /// </summary>
            public static readonly PackageVersionEnum CNAD_FULL_HIGH = new PackageVersionEnum("cnad_full_high");

            /// <summary>
            /// Enum CNAD_VIC for value: cnad_vic
            /// </summary>
            public static readonly PackageVersionEnum CNAD_VIC = new PackageVersionEnum("cnad_vic");

            /// <summary>
            /// Enum CNAD_INTL_EP for value: cnad_intl_ep
            /// </summary>
            public static readonly PackageVersionEnum CNAD_INTL_EP = new PackageVersionEnum("cnad_intl_ep");

            private static readonly Dictionary<string, PackageVersionEnum> StaticFields =
            new Dictionary<string, PackageVersionEnum>()
            {
                { "cnad_pro", CNAD_PRO },
                { "cnad_ip", CNAD_IP },
                { "cnad_ep", CNAD_EP },
                { "cnad_full_high", CNAD_FULL_HIGH },
                { "cnad_vic", CNAD_VIC },
                { "cnad_intl_ep", CNAD_INTL_EP },
            };

            private string _value;

            public PackageVersionEnum()
            {

            }

            public PackageVersionEnum(string value)
            {
                _value = value;
            }

            public static PackageVersionEnum FromValue(string value)
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

                if (this.Equals(obj as PackageVersionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PackageVersionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PackageVersionEnum a, PackageVersionEnum b)
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

            public static bool operator !=(PackageVersionEnum a, PackageVersionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 防护IP的Id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 防护IP
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 类型。VPN：VPN；NAT：NAT；VIP：VIP；CCI：CCI；EIP：弹性公网IP；ELB：弹性负载均衡；REROUTING_IP：REROUTING_IP；SubEni：SubEni；NetInterFace：NetInterFace；
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 名字
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 状态：0 - 正常， 1 - 清洗中， 2 - 黑洞中
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status_detail", NullValueHandling = NullValueHandling.Ignore)]
        public IpStatusDetail StatusDetail { get; set; }

        /// <summary>
        /// 策略名
        /// </summary>
        [JsonProperty("policy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyName { get; set; }

        /// <summary>
        /// 所属region
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 防护包id
        /// </summary>
        [JsonProperty("package_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageId { get; set; }

        /// <summary>
        /// 防护包名
        /// </summary>
        [JsonProperty("package_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageName { get; set; }

        /// <summary>
        /// TMS标签
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// 本地标签
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// 默认false，表示是否转售版的IP，不需要展示策略和报表
        /// </summary>
        [JsonProperty("is_resale", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsResale { get; set; }

        /// <summary>
        /// package_version。cnad_pro：专业版；cnad_ip：标准版；cnad_ep：铂金版；cnad_full_high：全力防高级版；cnad_vic：按需版；cnad_intl_ep：国际站铂金版
        /// </summary>
        [JsonProperty("package_version", NullValueHandling = NullValueHandling.Ignore)]
        public PackageVersionEnum PackageVersion { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtectedIpResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  statusDetail: ").Append(StatusDetail).Append("\n");
            sb.Append("  policyName: ").Append(PolicyName).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  packageId: ").Append(PackageId).Append("\n");
            sb.Append("  packageName: ").Append(PackageName).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  isResale: ").Append(IsResale).Append("\n");
            sb.Append("  packageVersion: ").Append(PackageVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProtectedIpResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProtectedIpResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.Type != input.Type) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.StatusDetail != input.StatusDetail || (this.StatusDetail != null && !this.StatusDetail.Equals(input.StatusDetail))) return false;
            if (this.PolicyName != input.PolicyName || (this.PolicyName != null && !this.PolicyName.Equals(input.PolicyName))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.PackageId != input.PackageId || (this.PackageId != null && !this.PackageId.Equals(input.PackageId))) return false;
            if (this.PackageName != input.PackageName || (this.PackageName != null && !this.PackageName.Equals(input.PackageName))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && !this.Tags.Equals(input.Tags))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;
            if (this.IsResale != input.IsResale || (this.IsResale != null && !this.IsResale.Equals(input.IsResale))) return false;
            if (this.PackageVersion != input.PackageVersion) return false;

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
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusDetail != null) hashCode = hashCode * 59 + this.StatusDetail.GetHashCode();
                if (this.PolicyName != null) hashCode = hashCode * 59 + this.PolicyName.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.PackageId != null) hashCode = hashCode * 59 + this.PackageId.GetHashCode();
                if (this.PackageName != null) hashCode = hashCode * 59 + this.PackageName.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.IsResale != null) hashCode = hashCode * 59 + this.IsResale.GetHashCode();
                hashCode = hashCode * 59 + this.PackageVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
