using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 查询已绑定EIP记录明细信息。
    /// </summary>
    public class BindedEipResult 
    {

        /// <summary>
        /// 弹性公网ID。
        /// </summary>
        [JsonProperty("public_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpId { get; set; }

        /// <summary>
        /// 弹性公网类型。
        /// </summary>
        [JsonProperty("public_ip_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpType { get; set; }

        /// <summary>
        /// 端口ID。
        /// </summary>
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// 弹性公网IP。
        /// </summary>
        [JsonProperty("public_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpAddress { get; set; }

        /// <summary>
        /// 内网地址。
        /// </summary>
        [JsonProperty("private_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// 带宽ID。
        /// </summary>
        [JsonProperty("bandwidth_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BandwidthId { get; set; }

        /// <summary>
        /// 带宽名称。
        /// </summary>
        [JsonProperty("bandwidth_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BandwidthName { get; set; }

        /// <summary>
        /// 带宽共享类型。
        /// </summary>
        [JsonProperty("bandwidth_share_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BandwidthShareType { get; set; }

        /// <summary>
        /// 带宽大小。
        /// </summary>
        [JsonProperty("bandwidth_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? BandwidthSize { get; set; }

        /// <summary>
        /// 修改时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+08:00。
        /// </summary>
        [JsonProperty("applied_at", NullValueHandling = NullValueHandling.Ignore)]
        public string AppliedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BindedEipResult {\n");
            sb.Append("  publicIpId: ").Append(PublicIpId).Append("\n");
            sb.Append("  publicIpType: ").Append(PublicIpType).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  publicIpAddress: ").Append(PublicIpAddress).Append("\n");
            sb.Append("  privateIpAddress: ").Append(PrivateIpAddress).Append("\n");
            sb.Append("  bandwidthId: ").Append(BandwidthId).Append("\n");
            sb.Append("  bandwidthName: ").Append(BandwidthName).Append("\n");
            sb.Append("  bandwidthShareType: ").Append(BandwidthShareType).Append("\n");
            sb.Append("  bandwidthSize: ").Append(BandwidthSize).Append("\n");
            sb.Append("  appliedAt: ").Append(AppliedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BindedEipResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BindedEipResult input)
        {
            if (input == null) return false;
            if (this.PublicIpId != input.PublicIpId || (this.PublicIpId != null && !this.PublicIpId.Equals(input.PublicIpId))) return false;
            if (this.PublicIpType != input.PublicIpType || (this.PublicIpType != null && !this.PublicIpType.Equals(input.PublicIpType))) return false;
            if (this.PortId != input.PortId || (this.PortId != null && !this.PortId.Equals(input.PortId))) return false;
            if (this.PublicIpAddress != input.PublicIpAddress || (this.PublicIpAddress != null && !this.PublicIpAddress.Equals(input.PublicIpAddress))) return false;
            if (this.PrivateIpAddress != input.PrivateIpAddress || (this.PrivateIpAddress != null && !this.PrivateIpAddress.Equals(input.PrivateIpAddress))) return false;
            if (this.BandwidthId != input.BandwidthId || (this.BandwidthId != null && !this.BandwidthId.Equals(input.BandwidthId))) return false;
            if (this.BandwidthName != input.BandwidthName || (this.BandwidthName != null && !this.BandwidthName.Equals(input.BandwidthName))) return false;
            if (this.BandwidthShareType != input.BandwidthShareType || (this.BandwidthShareType != null && !this.BandwidthShareType.Equals(input.BandwidthShareType))) return false;
            if (this.BandwidthSize != input.BandwidthSize || (this.BandwidthSize != null && !this.BandwidthSize.Equals(input.BandwidthSize))) return false;
            if (this.AppliedAt != input.AppliedAt || (this.AppliedAt != null && !this.AppliedAt.Equals(input.AppliedAt))) return false;

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
                if (this.PublicIpId != null) hashCode = hashCode * 59 + this.PublicIpId.GetHashCode();
                if (this.PublicIpType != null) hashCode = hashCode * 59 + this.PublicIpType.GetHashCode();
                if (this.PortId != null) hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.PublicIpAddress != null) hashCode = hashCode * 59 + this.PublicIpAddress.GetHashCode();
                if (this.PrivateIpAddress != null) hashCode = hashCode * 59 + this.PrivateIpAddress.GetHashCode();
                if (this.BandwidthId != null) hashCode = hashCode * 59 + this.BandwidthId.GetHashCode();
                if (this.BandwidthName != null) hashCode = hashCode * 59 + this.BandwidthName.GetHashCode();
                if (this.BandwidthShareType != null) hashCode = hashCode * 59 + this.BandwidthShareType.GetHashCode();
                if (this.BandwidthSize != null) hashCode = hashCode * 59 + this.BandwidthSize.GetHashCode();
                if (this.AppliedAt != null) hashCode = hashCode * 59 + this.AppliedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
