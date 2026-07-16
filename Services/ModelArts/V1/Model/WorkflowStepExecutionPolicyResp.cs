using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// workflow step execution 策略。
    /// </summary>
    public class WorkflowStepExecutionPolicyResp 
    {

        /// <summary>
        /// **参数解释**：执行策略， **取值范围**：可选值如下： - retry：重试 - stop：停止 - continue：继续运行
        /// </summary>
        [JsonProperty("execution_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionPolicy { get; set; }

        /// <summary>
        /// **参数解释**：是否使用的是缓存。 **取值范围**： - true：是缓存 - false：不是缓存
        /// </summary>
        [JsonProperty("use_cache", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseCache { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowStepExecutionPolicyResp {\n");
            sb.Append("  executionPolicy: ").Append(ExecutionPolicy).Append("\n");
            sb.Append("  useCache: ").Append(UseCache).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowStepExecutionPolicyResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowStepExecutionPolicyResp input)
        {
            if (input == null) return false;
            if (this.ExecutionPolicy != input.ExecutionPolicy || (this.ExecutionPolicy != null && !this.ExecutionPolicy.Equals(input.ExecutionPolicy))) return false;
            if (this.UseCache != input.UseCache || (this.UseCache != null && !this.UseCache.Equals(input.UseCache))) return false;

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
                if (this.ExecutionPolicy != null) hashCode = hashCode * 59 + this.ExecutionPolicy.GetHashCode();
                if (this.UseCache != null) hashCode = hashCode * 59 + this.UseCache.GetHashCode();
                return hashCode;
            }
        }
    }
}
