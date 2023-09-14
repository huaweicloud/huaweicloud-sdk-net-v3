using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// nics字段数据结构说明
    /// </summary>
    public class Nics 
    {

        /// <summary>
        /// 裸金属服务器网卡所在的子网信息。需要指定vpcid对应VPC下已创建的子网（subnet）的网络ID（network_id），UUID格式。子网（subnet）的网络ID（network_id）可以从虚拟私有云控制台或者参考《虚拟私有云API参考》的“查询子网列表”章节获取。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SubnetId { get; set; }

        /// <summary>
        /// 创建裸金属服务器网卡的IP地址，IPv4格式,约束：不填或空字符串，默认在网络（network）对应的子网中自动分配一个未使用的IP作网卡的IP地址。若指定IP地址，该IP地址必须在网络（network）对应的子网的网段内，且未被使用。
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// IP/Mac对列表， 约束：IP地址不允许为 “0.0.0.0/0” 如果allowed_address_pairs配置地址池较大的CIDR（掩码小于24位），建议为该port配置一个单独的安全组 如果allowed_address_pairs为“1.1.1.1/0”，表示关闭源目地址检查开关 被绑定的云服务器网卡allowed_address_pairs填“1.1.1.1/0”
        /// </summary>
        [JsonProperty("allowed_address_pairs", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateServerNicAllowedAddressPairs> AllowedAddressPairs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Nics {\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  allowedAddressPairs: ").Append(AllowedAddressPairs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Nics);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Nics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.AllowedAddressPairs == input.AllowedAddressPairs ||
                    this.AllowedAddressPairs != null &&
                    input.AllowedAddressPairs != null &&
                    this.AllowedAddressPairs.SequenceEqual(input.AllowedAddressPairs)
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
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.AllowedAddressPairs != null)
                    hashCode = hashCode * 59 + this.AllowedAddressPairs.GetHashCode();
                return hashCode;
            }
        }
    }
}
