using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowAudienceCountInfo 
    {

        /// <summary>
        /// 观众显示策略。 * 0：不显示 * 1：倍增显示与会人数。基于实时与会人数或累计与会人次（假设为N），可以再进行倍增设置。支持设置倍增倍数X和基础人数Y，设置后，显示的人数为：N*X+Y 
        /// </summary>
        [JsonProperty("showAudienceMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShowAudienceMode { get; set; }

        /// <summary>
        /// 基础人数。范围是0~10000。
        /// </summary>
        [JsonProperty("baseAudienceCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? BaseAudienceCount { get; set; }

        /// <summary>
        /// 倍增倍数。范围是1~10, 支持设置到小数点后1位。
        /// </summary>
        [JsonProperty("multiple", NullValueHandling = NullValueHandling.Ignore)]
        public double? Multiple { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAudienceCountInfo {\n");
            sb.Append("  showAudienceMode: ").Append(ShowAudienceMode).Append("\n");
            sb.Append("  baseAudienceCount: ").Append(BaseAudienceCount).Append("\n");
            sb.Append("  multiple: ").Append(Multiple).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAudienceCountInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAudienceCountInfo input)
        {
            if (input == null) return false;
            if (this.ShowAudienceMode != input.ShowAudienceMode || (this.ShowAudienceMode != null && !this.ShowAudienceMode.Equals(input.ShowAudienceMode))) return false;
            if (this.BaseAudienceCount != input.BaseAudienceCount || (this.BaseAudienceCount != null && !this.BaseAudienceCount.Equals(input.BaseAudienceCount))) return false;
            if (this.Multiple != input.Multiple || (this.Multiple != null && !this.Multiple.Equals(input.Multiple))) return false;

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
                if (this.ShowAudienceMode != null) hashCode = hashCode * 59 + this.ShowAudienceMode.GetHashCode();
                if (this.BaseAudienceCount != null) hashCode = hashCode * 59 + this.BaseAudienceCount.GetHashCode();
                if (this.Multiple != null) hashCode = hashCode * 59 + this.Multiple.GetHashCode();
                return hashCode;
            }
        }
    }
}
