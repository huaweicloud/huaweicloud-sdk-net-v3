using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowClusterAccessInfoRequest 
    {

        /// <summary>
        /// 集群ID
        /// </summary>
        [SDKProperty("clusterid", IsPath = true)]
        [JsonProperty("clusterid", NullValueHandling = NullValueHandling.Ignore)]
        public string Clusterid { get; set; }

        /// <summary>
        /// VPC终端节点的IP地址。私网接入的集群必填，且必须是打通线下集群的VPC终端节点。  创建VPC终端节点及查询IP地址的方法请参见[创建终端节点](https://support.huaweicloud.com/usermanual-ucs/ucs_01_0336.html#section2)。
        /// </summary>
        [SDKProperty("vpcendpoint", IsQuery = true)]
        [JsonProperty("vpcendpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Vpcendpoint { get; set; }

        /// <summary>
        /// 接入region，私网接入的集群必填
        /// </summary>
        [SDKProperty("region", IsQuery = true)]
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowClusterAccessInfoRequest {\n");
            sb.Append("  clusterid: ").Append(Clusterid).Append("\n");
            sb.Append("  vpcendpoint: ").Append(Vpcendpoint).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowClusterAccessInfoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowClusterAccessInfoRequest input)
        {
            if (input == null) return false;
            if (this.Clusterid != input.Clusterid || (this.Clusterid != null && !this.Clusterid.Equals(input.Clusterid))) return false;
            if (this.Vpcendpoint != input.Vpcendpoint || (this.Vpcendpoint != null && !this.Vpcendpoint.Equals(input.Vpcendpoint))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;

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
                if (this.Clusterid != null) hashCode = hashCode * 59 + this.Clusterid.GetHashCode();
                if (this.Vpcendpoint != null) hashCode = hashCode * 59 + this.Vpcendpoint.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                return hashCode;
            }
        }
    }
}
