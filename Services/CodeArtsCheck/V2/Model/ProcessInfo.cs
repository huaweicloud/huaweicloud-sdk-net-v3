using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// **参数解释：** 执行记录信息。
    /// </summary>
    public class ProcessInfo 
    {

        /// <summary>
        /// **参数解释：** 执行时间，单位为秒。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("exeTime", NullValueHandling = NullValueHandling.Ignore)]
        public string ExeTime { get; set; }

        /// <summary>
        /// **参数解释：** 执行时间，格式为%dm%ds，例如\&quot;6m6s\&quot;。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("executeTime", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteTime { get; set; }

        /// <summary>
        /// **参数解释：** 执行过程。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// **参数解释：** 任务执行的进度百分比。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("process", NullValueHandling = NullValueHandling.Ignore)]
        public string Process { get; set; }

        /// <summary>
        /// **参数解释:** 任务执行状态。 **取值范围:** - quering：初始状态。 - running：执行中。 - success：检查成功。 - failed：检查失败。 - aborted：任务中止。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessInfo {\n");
            sb.Append("  exeTime: ").Append(ExeTime).Append("\n");
            sb.Append("  executeTime: ").Append(ExecuteTime).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  process: ").Append(Process).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProcessInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProcessInfo input)
        {
            if (input == null) return false;
            if (this.ExeTime != input.ExeTime || (this.ExeTime != null && !this.ExeTime.Equals(input.ExeTime))) return false;
            if (this.ExecuteTime != input.ExecuteTime || (this.ExecuteTime != null && !this.ExecuteTime.Equals(input.ExecuteTime))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.Process != input.Process || (this.Process != null && !this.Process.Equals(input.Process))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.ExeTime != null) hashCode = hashCode * 59 + this.ExeTime.GetHashCode();
                if (this.ExecuteTime != null) hashCode = hashCode * 59 + this.ExecuteTime.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Process != null) hashCode = hashCode * 59 + this.Process.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
