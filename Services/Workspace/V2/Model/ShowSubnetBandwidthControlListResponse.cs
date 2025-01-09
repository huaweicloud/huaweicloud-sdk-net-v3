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
    /// Response Object
    /// </summary>
    public class ShowSubnetBandwidthControlListResponse : SdkResponse
    {

        /// <summary>
        /// 控制模式 - BLACK：黑名单控制。 - WHITE：白名单控制。
        /// </summary>
        [JsonProperty("control_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ControlMode { get; set; }

        /// <summary>
        /// 控制的桌面列表。
        /// </summary>
        [JsonProperty("control_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ControlItem> ControlList { get; set; }

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSubnetBandwidthControlListResponse {\n");
            sb.Append("  controlMode: ").Append(ControlMode).Append("\n");
            sb.Append("  controlList: ").Append(ControlList).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSubnetBandwidthControlListResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSubnetBandwidthControlListResponse input)
        {
            if (input == null) return false;
            if (this.ControlMode != input.ControlMode || (this.ControlMode != null && !this.ControlMode.Equals(input.ControlMode))) return false;
            if (this.ControlList != input.ControlList || (this.ControlList != null && input.ControlList != null && !this.ControlList.SequenceEqual(input.ControlList))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.ControlMode != null) hashCode = hashCode * 59 + this.ControlMode.GetHashCode();
                if (this.ControlList != null) hashCode = hashCode * 59 + this.ControlList.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
