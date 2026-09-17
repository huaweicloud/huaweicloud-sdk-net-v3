using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// **参数解释：** 升级任务状态信息 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及 
    /// </summary>
    public class UpgradeTaskStatus 
    {

        /// <summary>
        /// **参数解释：** 升级任务状态 **约束限制：** 不涉及 **取值范围：** - Init：初始化 - Queuing：等待 - Running：运行中 - Pause：暂停 - Success：成功 - Failed：失败  **默认取值：** 不涉及 
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }

        /// <summary>
        /// **参数解释：** 升级任务进度 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及 
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public string Progress { get; set; }

        /// <summary>
        /// **参数解释：** 升级任务结束时间 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及 
        /// </summary>
        [JsonProperty("completionTime", NullValueHandling = NullValueHandling.Ignore)]
        public string CompletionTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeTaskStatus {\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  completionTime: ").Append(CompletionTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeTaskStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeTaskStatus input)
        {
            if (input == null) return false;
            if (this.Phase != input.Phase || (this.Phase != null && !this.Phase.Equals(input.Phase))) return false;
            if (this.Progress != input.Progress || (this.Progress != null && !this.Progress.Equals(input.Progress))) return false;
            if (this.CompletionTime != input.CompletionTime || (this.CompletionTime != null && !this.CompletionTime.Equals(input.CompletionTime))) return false;

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
                if (this.Phase != null) hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.Progress != null) hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.CompletionTime != null) hashCode = hashCode * 59 + this.CompletionTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
