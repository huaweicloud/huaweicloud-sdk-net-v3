using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Geip.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GlobalConnectionBandwidthInfo 
    {

        /// <summary>
        /// 骨干带宽id
        /// </summary>
        [JsonProperty("gcb_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GcbId { get; set; }

        /// <summary>
        /// 骨干带宽大小
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 骨干带宽类型（城域、区域和大区）
        /// </summary>
        [JsonProperty("gcb_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GcbType { get; set; }

        /// <summary>
        /// 骨干带宽状态，取值：NORMAL 正常、FREEZED 冻结
        /// </summary>
        [JsonProperty("admin_state", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminState { get; set; }

        /// <summary>
        /// 网络服务等级。Pt - 铂金，Au - 金牌，Ag - 银牌，Cu - 铜牌
        /// </summary>
        [JsonProperty("sla_level", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaLevel { get; set; }

        /// <summary>
        /// 线路质量金银铜对应的DSCP值
        /// </summary>
        [JsonProperty("dscp", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dscp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlobalConnectionBandwidthInfo {\n");
            sb.Append("  gcbId: ").Append(GcbId).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  gcbType: ").Append(GcbType).Append("\n");
            sb.Append("  adminState: ").Append(AdminState).Append("\n");
            sb.Append("  slaLevel: ").Append(SlaLevel).Append("\n");
            sb.Append("  dscp: ").Append(Dscp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GlobalConnectionBandwidthInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GlobalConnectionBandwidthInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GcbId == input.GcbId ||
                    (this.GcbId != null &&
                    this.GcbId.Equals(input.GcbId))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.GcbType == input.GcbType ||
                    (this.GcbType != null &&
                    this.GcbType.Equals(input.GcbType))
                ) && 
                (
                    this.AdminState == input.AdminState ||
                    (this.AdminState != null &&
                    this.AdminState.Equals(input.AdminState))
                ) && 
                (
                    this.SlaLevel == input.SlaLevel ||
                    (this.SlaLevel != null &&
                    this.SlaLevel.Equals(input.SlaLevel))
                ) && 
                (
                    this.Dscp == input.Dscp ||
                    (this.Dscp != null &&
                    this.Dscp.Equals(input.Dscp))
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
                if (this.GcbId != null)
                    hashCode = hashCode * 59 + this.GcbId.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.GcbType != null)
                    hashCode = hashCode * 59 + this.GcbType.GetHashCode();
                if (this.AdminState != null)
                    hashCode = hashCode * 59 + this.AdminState.GetHashCode();
                if (this.SlaLevel != null)
                    hashCode = hashCode * 59 + this.SlaLevel.GetHashCode();
                if (this.Dscp != null)
                    hashCode = hashCode * 59 + this.Dscp.GetHashCode();
                return hashCode;
            }
        }
    }
}
