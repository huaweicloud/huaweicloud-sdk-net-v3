using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RouteTableRoute 
    {

        /// <summary>
        /// 功能说明：路由的类型 取值范围： ecs：弹性云服务器 eni：网卡 vip：虚拟IP nat：NAT网关 peering：对等连接 vpn：虚拟专用网络 dc：云专线 cc：云连接 egw：VPC终端节点
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 功能说明：路由目的网段 约束：合法的CIDR格式
        /// </summary>
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public string Destination { get; set; }

        /// <summary>
        /// 功能说明：路由下一跳对象的ID 取值范围： 当type为ecs时，传入ecs实例ID 当type为eni时，取值为从网卡ID 当type为vip时，取值为vip对应的IP地址 当type为nat时，取值为nat实例对应的ID 当type为peering时，取值为peering对应实例ID 当type为vpn时，取值为vpn实例ID 当type为dc时，取值为dc实例ID 当type为cc时，取值为cc的实例ID
        /// </summary>
        [JsonProperty("nexthop", NullValueHandling = NullValueHandling.Ignore)]
        public string Nexthop { get; set; }

        /// <summary>
        /// 功能说明：路由的描述信息 取值范围：0-255个字符，不能包含“&lt;”和“&gt;”
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RouteTableRoute {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  destination: ").Append(Destination).Append("\n");
            sb.Append("  nexthop: ").Append(Nexthop).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RouteTableRoute);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RouteTableRoute input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Destination != input.Destination || (this.Destination != null && !this.Destination.Equals(input.Destination))) return false;
            if (this.Nexthop != input.Nexthop || (this.Nexthop != null && !this.Nexthop.Equals(input.Nexthop))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Destination != null) hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Nexthop != null) hashCode = hashCode * 59 + this.Nexthop.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
