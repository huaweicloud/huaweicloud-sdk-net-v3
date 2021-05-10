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
    /// ENI网络配置，创建集群指定使用云原生网络2.0网络模式时必填。
    /// </summary>
    public class EniNetwork 
    {

        /// <summary>
        /// 用于创建控制节点的subnet的IPv4网络ID(暂不支持IPv6)。获取方法如下：- 方法1：登录虚拟私有云服务的控制台界面，单击VPC下的子网，进入子网详情页面，查找IPv4网络ID。- 方法2：通过虚拟私有云服务的API接口查询，具体操作可参考[[查询子网列表](https://support.huaweicloud.com/api-vpc/vpc_subnet01_0003.html)](tag:hws)[[查询子网列表](https://support.huaweicloud.com/intl/zh-cn/api-vpc/vpc_subnet01_0003.html)](tag:hws_hk)
        /// </summary>
        [JsonProperty("eniSubnetId", NullValueHandling = NullValueHandling.Ignore)]
        public string EniSubnetId { get; set; }

        /// <summary>
        /// ENI子网CIDR
        /// </summary>
        [JsonProperty("eniSubnetCIDR", NullValueHandling = NullValueHandling.Ignore)]
        public string EniSubnetCIDR { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EniNetwork {\n");
            sb.Append("  eniSubnetId: ").Append(EniSubnetId).Append("\n");
            sb.Append("  eniSubnetCIDR: ").Append(EniSubnetCIDR).Append("\n");
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
                return hashCode;
            }
        }
    }
}
