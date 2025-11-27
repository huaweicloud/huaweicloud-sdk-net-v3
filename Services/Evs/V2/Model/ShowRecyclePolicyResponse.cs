using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowRecyclePolicyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释** 回收站开关。 **取值范围** - true：表示回收站已打开。 - false：表示回收站已关闭。
        /// </summary>
        [JsonProperty("switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Switch { get; set; }

        /// <summary>
        /// **参数解释** 回收站的门槛时间，云硬盘创建多少天后删除才会放入回收站。 **取值范围** 1-1000
        /// </summary>
        [JsonProperty("threshold_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? ThresholdTime { get; set; }

        /// <summary>
        /// **参数解释** 回收站的云硬盘保存期限（天），云硬盘进入回收站后多少天才会被彻底删除。 **取值范围** 1-365
        /// </summary>
        [JsonProperty("keep_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRecyclePolicyResponse {\n");
            sb.Append("  Switch: ").Append(Switch).Append("\n");
            sb.Append("  thresholdTime: ").Append(ThresholdTime).Append("\n");
            sb.Append("  keepTime: ").Append(KeepTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRecyclePolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRecyclePolicyResponse input)
        {
            if (input == null) return false;
            if (this.Switch != input.Switch || (this.Switch != null && !this.Switch.Equals(input.Switch))) return false;
            if (this.ThresholdTime != input.ThresholdTime || (this.ThresholdTime != null && !this.ThresholdTime.Equals(input.ThresholdTime))) return false;
            if (this.KeepTime != input.KeepTime || (this.KeepTime != null && !this.KeepTime.Equals(input.KeepTime))) return false;

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
                if (this.Switch != null) hashCode = hashCode * 59 + this.Switch.GetHashCode();
                if (this.ThresholdTime != null) hashCode = hashCode * 59 + this.ThresholdTime.GetHashCode();
                if (this.KeepTime != null) hashCode = hashCode * 59 + this.KeepTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
