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
    public class UpdateVpcOption 
    {

        /// <summary>
        /// 功能说明：虚拟私有云名称  取值范围：0-64个字符，支持数字、字母、中文、_(下划线)、-（中划线）、.（点）  约束：如果名称不为空，则同一个租户下的VPC不允许重名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：虚拟私有云的描述  取值范围：0-255个字符，不能包含“&lt;”和“&gt;”。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：虚拟私有云下可用子网的范围  取值范围：  - 10.0.0.0/8 ~ 10.255.255.240/28 - 172.16.0.0/12 ~ 172.31.255.240/28 - 192.168.0.0/16 ~ 192.168.255.240/28  约束：必须是ipv4 cidr格式，例如：192.168.0.0/16
        /// </summary>
        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string Cidr { get; set; }

        /// <summary>
        /// 功能说明：路由信息列表，详情参见route对象
        /// </summary>
        [JsonProperty("routes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Route> Routes { get; set; }

        /// <summary>
        /// 功能说明：是否开启VPC内所有子网的IPv4地址使用量指标监控。 取值范围： true：开启 false：不开启
        /// </summary>
        [JsonProperty("enable_network_address_usage_metrics", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableNetworkAddressUsageMetrics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateVpcOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  routes: ").Append(Routes).Append("\n");
            sb.Append("  enableNetworkAddressUsageMetrics: ").Append(EnableNetworkAddressUsageMetrics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateVpcOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateVpcOption input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Cidr != input.Cidr || (this.Cidr != null && !this.Cidr.Equals(input.Cidr))) return false;
            if (this.Routes != input.Routes || (this.Routes != null && input.Routes != null && !this.Routes.SequenceEqual(input.Routes))) return false;
            if (this.EnableNetworkAddressUsageMetrics != input.EnableNetworkAddressUsageMetrics || (this.EnableNetworkAddressUsageMetrics != null && !this.EnableNetworkAddressUsageMetrics.Equals(input.EnableNetworkAddressUsageMetrics))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Cidr != null) hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.Routes != null) hashCode = hashCode * 59 + this.Routes.GetHashCode();
                if (this.EnableNetworkAddressUsageMetrics != null) hashCode = hashCode * 59 + this.EnableNetworkAddressUsageMetrics.GetHashCode();
                return hashCode;
            }
        }
    }
}
