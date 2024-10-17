using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpgradeInstanceData 
    {

        /// <summary>
        /// 保底带宽(G)
        /// </summary>
        [JsonProperty("basic_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public string BasicBandwidth { get; set; }

        /// <summary>
        /// 弹性带宽(G)
        /// </summary>
        [JsonProperty("elastic_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public string ElasticBandwidth { get; set; }

        /// <summary>
        /// 业务带宽
        /// </summary>
        [JsonProperty("service_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceBandwidth { get; set; }

        /// <summary>
        /// 端口数
        /// </summary>
        [JsonProperty("port_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PortNum { get; set; }

        /// <summary>
        /// 域名数
        /// </summary>
        [JsonProperty("bind_domain_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? BindDomainNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeInstanceData {\n");
            sb.Append("  basicBandwidth: ").Append(BasicBandwidth).Append("\n");
            sb.Append("  elasticBandwidth: ").Append(ElasticBandwidth).Append("\n");
            sb.Append("  serviceBandwidth: ").Append(ServiceBandwidth).Append("\n");
            sb.Append("  portNum: ").Append(PortNum).Append("\n");
            sb.Append("  bindDomainNum: ").Append(BindDomainNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeInstanceData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeInstanceData input)
        {
            if (input == null) return false;
            if (this.BasicBandwidth != input.BasicBandwidth || (this.BasicBandwidth != null && !this.BasicBandwidth.Equals(input.BasicBandwidth))) return false;
            if (this.ElasticBandwidth != input.ElasticBandwidth || (this.ElasticBandwidth != null && !this.ElasticBandwidth.Equals(input.ElasticBandwidth))) return false;
            if (this.ServiceBandwidth != input.ServiceBandwidth || (this.ServiceBandwidth != null && !this.ServiceBandwidth.Equals(input.ServiceBandwidth))) return false;
            if (this.PortNum != input.PortNum || (this.PortNum != null && !this.PortNum.Equals(input.PortNum))) return false;
            if (this.BindDomainNum != input.BindDomainNum || (this.BindDomainNum != null && !this.BindDomainNum.Equals(input.BindDomainNum))) return false;

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
                if (this.BasicBandwidth != null) hashCode = hashCode * 59 + this.BasicBandwidth.GetHashCode();
                if (this.ElasticBandwidth != null) hashCode = hashCode * 59 + this.ElasticBandwidth.GetHashCode();
                if (this.ServiceBandwidth != null) hashCode = hashCode * 59 + this.ServiceBandwidth.GetHashCode();
                if (this.PortNum != null) hashCode = hashCode * 59 + this.PortNum.GetHashCode();
                if (this.BindDomainNum != null) hashCode = hashCode * 59 + this.BindDomainNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
