using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListPublicipsRequest 
    {
        /// <summary>
        /// IP地址版本信息  4：IPv4  6：IPv6
        /// </summary>
        /// <value>IP地址版本信息  4：IPv4  6：IPv6</value>
        [JsonConverter(typeof(EnumClassConverter<IpVersionEnum>))]
        public class IpVersionEnum
        {
            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            public static readonly IpVersionEnum NUMBER_4 = new IpVersionEnum(4);

            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            public static readonly IpVersionEnum NUMBER_6 = new IpVersionEnum(6);

            private static readonly Dictionary<int?, IpVersionEnum> StaticFields =
            new Dictionary<int?, IpVersionEnum>()
            {
                { 4, NUMBER_4 },
                { 6, NUMBER_6 },
            };

            private int? Value;

            public IpVersionEnum(int? value)
            {
                Value = value;
            }

            public static IpVersionEnum FromValue(int? value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as IpVersionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IpVersionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(IpVersionEnum a, IpVersionEnum b)
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

            public static bool operator !=(IpVersionEnum a, IpVersionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 取值为上一页数据的最后一条记录的id，为空时为查询第一页
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 功能说明：每页返回的个数  取值范围：0~intmax
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// IP地址版本信息  4：IPv4  6：IPv6
        /// </summary>
        [SDKProperty("ip_version", IsQuery = true)]
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public IpVersionEnum IpVersion { get; set; }
        /// <summary>
        /// 功能说明：企业项目ID。可以使用该字段过滤某个企业项目下的弹性IP弹性公网IP。  取值范围：最大长度36字节，带“-”连字符的UUID格式，或者是字符串“0”。“0”表示默认企业项目。若需要查询当前用户所有企业项目绑定的弹性公网IP，请传参all_granted_eps。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 绑定弹性公网IP的端口id
        /// </summary>
        [SDKProperty("port_id", IsQuery = true)]
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PortId { get; set; }

        /// <summary>
        /// IPv4时是申请到的弹性公网IP地址，IPv6时是IPv6地址对应的IPv4地址
        /// </summary>
        [SDKProperty("public_ip_address", IsQuery = true)]
        [JsonProperty("public_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PublicIpAddress { get; set; }

        /// <summary>
        /// 关联端口的私有IP地址
        /// </summary>
        [SDKProperty("private_ip_address", IsQuery = true)]
        [JsonProperty("private_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PrivateIpAddress { get; set; }

        /// <summary>
        /// 弹性公网IP唯一标识
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 共享带宽类型，根据任一共享带宽类型过滤EIP列表。 可以指定多个带宽类型，不同的带宽类型间用逗号分隔。
        /// </summary>
        [SDKProperty("allow_share_bandwidth_type_any", IsQuery = true)]
        [JsonProperty("allow_share_bandwidth_type_any", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllowShareBandwidthTypeAny { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPublicipsRequest {\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  publicIpAddress: ").Append(PublicIpAddress).Append("\n");
            sb.Append("  privateIpAddress: ").Append(PrivateIpAddress).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  allowShareBandwidthTypeAny: ").Append(AllowShareBandwidthTypeAny).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPublicipsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPublicipsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.IpVersion == input.IpVersion ||
                    (this.IpVersion != null &&
                    this.IpVersion.Equals(input.IpVersion))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.PortId == input.PortId ||
                    this.PortId != null &&
                    input.PortId != null &&
                    this.PortId.SequenceEqual(input.PortId)
                ) && 
                (
                    this.PublicIpAddress == input.PublicIpAddress ||
                    this.PublicIpAddress != null &&
                    input.PublicIpAddress != null &&
                    this.PublicIpAddress.SequenceEqual(input.PublicIpAddress)
                ) && 
                (
                    this.PrivateIpAddress == input.PrivateIpAddress ||
                    this.PrivateIpAddress != null &&
                    input.PrivateIpAddress != null &&
                    this.PrivateIpAddress.SequenceEqual(input.PrivateIpAddress)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id != null &&
                    input.Id != null &&
                    this.Id.SequenceEqual(input.Id)
                ) && 
                (
                    this.AllowShareBandwidthTypeAny == input.AllowShareBandwidthTypeAny ||
                    this.AllowShareBandwidthTypeAny != null &&
                    input.AllowShareBandwidthTypeAny != null &&
                    this.AllowShareBandwidthTypeAny.SequenceEqual(input.AllowShareBandwidthTypeAny)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.IpVersion != null)
                    hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.PortId != null)
                    hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.PublicIpAddress != null)
                    hashCode = hashCode * 59 + this.PublicIpAddress.GetHashCode();
                if (this.PrivateIpAddress != null)
                    hashCode = hashCode * 59 + this.PrivateIpAddress.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AllowShareBandwidthTypeAny != null)
                    hashCode = hashCode * 59 + this.AllowShareBandwidthTypeAny.GetHashCode();
                return hashCode;
            }
        }
    }
}
