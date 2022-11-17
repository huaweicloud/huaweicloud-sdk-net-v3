using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// ENI网络配置，创建集群指定使用云原生网络2.0网络模式时必填subnets和eniSubnetId其中一个字段(eniSubnetCIDR可选，若填写了会校验是否合法)，1.19.10及新版本集群使用subnets字段，1.19.8及老版本若使用subnets字段，则取值subnets数组中的第一个子网ID作为容器地址使用的子网ID。
    /// </summary>
    public class EniNetwork 
    {

        /// <summary>
        /// ENI所在子网的IPv4网络ID(暂不支持IPv6,废弃中)。获取方法如下：  - 方法1：登录虚拟私有云服务的控制台界面，单击VPC下的子网，进入子网详情页面，查找IPv4子网ID。 - 方法2：通过虚拟私有云服务的查询子网列表接口查询。   [链接请参见[查询子网列表](https://support.huaweicloud.com/api-vpc/vpc_subnet01_0003.html)](tag:hws)   [链接请参见[查询子网列表](https://support.huaweicloud.com/intl/zh-cn/api-vpc/vpc_subnet01_0003.html)](tag:hws_hk)
        /// </summary>
        [JsonProperty("eniSubnetId", NullValueHandling = NullValueHandling.Ignore)]
        public string EniSubnetId { get; set; }

        /// <summary>
        /// ENI子网CIDR(废弃中)
        /// </summary>
        [JsonProperty("eniSubnetCIDR", NullValueHandling = NullValueHandling.Ignore)]
        public string EniSubnetCIDR { get; set; }

        /// <summary>
        /// IPv4子网ID列表
        /// </summary>
        [JsonProperty("subnets", NullValueHandling = NullValueHandling.Ignore)]
        public List<NetworkSubnet> Subnets { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EniNetwork {\n");
            sb.Append("  eniSubnetId: ").Append(EniSubnetId).Append("\n");
            sb.Append("  eniSubnetCIDR: ").Append(EniSubnetCIDR).Append("\n");
            sb.Append("  subnets: ").Append(Subnets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EniNetwork);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EniNetwork input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EniSubnetId == input.EniSubnetId ||
                    (this.EniSubnetId != null &&
                    this.EniSubnetId.Equals(input.EniSubnetId))
                ) && 
                (
                    this.EniSubnetCIDR == input.EniSubnetCIDR ||
                    (this.EniSubnetCIDR != null &&
                    this.EniSubnetCIDR.Equals(input.EniSubnetCIDR))
                ) && 
                (
                    this.Subnets == input.Subnets ||
                    this.Subnets != null &&
                    input.Subnets != null &&
                    this.Subnets.SequenceEqual(input.Subnets)
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
                if (this.EniSubnetId != null)
                    hashCode = hashCode * 59 + this.EniSubnetId.GetHashCode();
                if (this.EniSubnetCIDR != null)
                    hashCode = hashCode * 59 + this.EniSubnetCIDR.GetHashCode();
                if (this.Subnets != null)
                    hashCode = hashCode * 59 + this.Subnets.GetHashCode();
                return hashCode;
            }
        }
    }
}
