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
    /// 升级状态信息
    /// </summary>
    public class UpgradeInfoStatus 
    {

        /// <summary>
        /// 升级任务状态. &gt; Init：初始化 &gt; Running：运行中 &gt; Pause：暂停 &gt; Success：成功 &gt; Failed：失败 
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }

        /// <summary>
        /// 升级任务进度
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public string Progress { get; set; }

        /// <summary>
        /// 升级任务结束时间
        /// </summary>
        [JsonProperty("completionTime", NullValueHandling = NullValueHandling.Ignore)]
        public string CompletionTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeInfoStatus {\n");
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
            return this.Equals(input as UpgradeInfoStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeInfoStatus input)
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
