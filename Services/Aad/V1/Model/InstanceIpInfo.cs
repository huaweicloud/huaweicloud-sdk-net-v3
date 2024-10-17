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
    /// 
    /// </summary>
    public class InstanceIpInfo 
    {

        /// <summary>
        /// IP ID
        /// </summary>
        [JsonProperty("ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpId { get; set; }

        /// <summary>
        /// IP
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 保底带宽
        /// </summary>
        [JsonProperty("basic_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? BasicBandwidth { get; set; }

        /// <summary>
        /// 弹性带宽
        /// </summary>
        [JsonProperty("elastic_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? ElasticBandwidth { get; set; }

        /// <summary>
        /// IP状态
        /// </summary>
        [JsonProperty("ip_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceIpInfo {\n");
            sb.Append("  ipId: ").Append(IpId).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  basicBandwidth: ").Append(BasicBandwidth).Append("\n");
            sb.Append("  elasticBandwidth: ").Append(ElasticBandwidth).Append("\n");
            sb.Append("  ipStatus: ").Append(IpStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceIpInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceIpInfo input)
        {
            if (input == null) return false;
            if (this.IpId != input.IpId || (this.IpId != null && !this.IpId.Equals(input.IpId))) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.BasicBandwidth != input.BasicBandwidth || (this.BasicBandwidth != null && !this.BasicBandwidth.Equals(input.BasicBandwidth))) return false;
            if (this.ElasticBandwidth != input.ElasticBandwidth || (this.ElasticBandwidth != null && !this.ElasticBandwidth.Equals(input.ElasticBandwidth))) return false;
            if (this.IpStatus != input.IpStatus || (this.IpStatus != null && !this.IpStatus.Equals(input.IpStatus))) return false;

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
                if (this.IpId != null) hashCode = hashCode * 59 + this.IpId.GetHashCode();
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.BasicBandwidth != null) hashCode = hashCode * 59 + this.BasicBandwidth.GetHashCode();
                if (this.ElasticBandwidth != null) hashCode = hashCode * 59 + this.ElasticBandwidth.GetHashCode();
                if (this.IpStatus != null) hashCode = hashCode * 59 + this.IpStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
