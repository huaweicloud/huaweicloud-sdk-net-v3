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
    /// ENI网络配置，创建集群指定subnets字段使用时必填。
    /// </summary>
    public class NetworkSubnet 
    {

        /// <summary>
        /// 用于创建控制节点的subnet的IPv4子网ID(暂不支持IPv6)。获取方法如下：  - 方法1：登录虚拟私有云服务的控制台界面，单击VPC下的子网，进入子网详情页面，查找IPv4子网ID。 - 方法2：通过虚拟私有云服务的查询子网列表接口查询。   [链接请参见[查询子网列表](https://support.huaweicloud.com/api-vpc/vpc_subnet01_0003.html)](tag:hws)   [链接请参见[查询子网列表](https://support.huaweicloud.com/intl/zh-cn/api-vpc/vpc_subnet01_0003.html)](tag:hws_hk)
        /// </summary>
        [JsonProperty("subnetID", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkSubnet {\n");
            sb.Append("  subnetID: ").Append(SubnetID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NetworkSubnet);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NetworkSubnet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubnetID == input.SubnetID ||
                    (this.SubnetID != null &&
                    this.SubnetID.Equals(input.SubnetID))
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
                if (this.SubnetID != null)
                    hashCode = hashCode * 59 + this.SubnetID.GetHashCode();
                return hashCode;
            }
        }
    }
}
