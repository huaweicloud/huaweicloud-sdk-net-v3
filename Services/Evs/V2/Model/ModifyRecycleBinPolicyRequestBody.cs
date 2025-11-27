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
    /// 更新回收站策略请求
    /// </summary>
    public class ModifyRecycleBinPolicyRequestBody 
    {

        /// <summary>
        /// **参数解释** 回收站开关。 **约束限制** 不涉及。 **取值范围** - true：表示打开回收站。 - false：表示关闭回收站。 **默认取值** 不涉及。
        /// </summary>
        [JsonProperty("switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Switch { get; set; }

        /// <summary>
        /// **参数解释** 回收站门槛时间，云硬盘创建多少天后删除才会放入回收站。 **约束限制** 不涉及。 **取值范围** 1-1000 **默认取值** 7
        /// </summary>
        [JsonProperty("threshold_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? ThresholdTime { get; set; }

        /// <summary>
        /// **参数解释** 回收站的云硬盘保存期限（天），云硬盘进入回收站后多少天才会被彻底删除。 **约束限制** 不涉及。 **取值范围** 1-365 **默认取值** 7
        /// </summary>
        [JsonProperty("keep_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyRecycleBinPolicyRequestBody {\n");
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
            return this.Equals(input as ModifyRecycleBinPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyRecycleBinPolicyRequestBody input)
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
