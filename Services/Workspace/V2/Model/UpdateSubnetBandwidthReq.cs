using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateSubnetBandwidthReq 
    {

        /// <summary>
        /// 云办公带宽名称。
        /// </summary>
        [JsonProperty("bandwidth_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BandwidthName { get; set; }

        /// <summary>
        /// 云办公带宽大小。
        /// </summary>
        [JsonProperty("bandwidth_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? BandwidthSize { get; set; }

        /// <summary>
        /// 企业项目ID，默认\&quot;0。\&quot;
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 计费模式 - wks_bandwidth：按带宽计费。 - free: 不计费，不支持包周期订购。 - wks_traffic：按流量计费
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSubnetBandwidthReq {\n");
            sb.Append("  bandwidthName: ").Append(BandwidthName).Append("\n");
            sb.Append("  bandwidthSize: ").Append(BandwidthSize).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSubnetBandwidthReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSubnetBandwidthReq input)
        {
            if (input == null) return false;
            if (this.BandwidthName != input.BandwidthName || (this.BandwidthName != null && !this.BandwidthName.Equals(input.BandwidthName))) return false;
            if (this.BandwidthSize != input.BandwidthSize || (this.BandwidthSize != null && !this.BandwidthSize.Equals(input.BandwidthSize))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;

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
                if (this.BandwidthName != null) hashCode = hashCode * 59 + this.BandwidthName.GetHashCode();
                if (this.BandwidthSize != null) hashCode = hashCode * 59 + this.BandwidthSize.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
