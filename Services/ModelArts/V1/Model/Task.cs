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
    /// 训练作业的任务列表。
    /// </summary>
    public class Task 
    {

        /// <summary>
        /// **参数解释**：任务角色，该功能暂未支持。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public TaskAlgorithm Algorithm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("task_resource", NullValueHandling = NullValueHandling.Ignore)]
        public TaskTaskResource TaskResource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("log_export_path", NullValueHandling = NullValueHandling.Ignore)]
        public TaskLogExportPath LogExportPath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Task {\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  taskResource: ").Append(TaskResource).Append("\n");
            sb.Append("  logExportPath: ").Append(LogExportPath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Task);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Task input)
        {
            if (input == null) return false;
            if (this.Role != input.Role || (this.Role != null && !this.Role.Equals(input.Role))) return false;
            if (this.Algorithm != input.Algorithm || (this.Algorithm != null && !this.Algorithm.Equals(input.Algorithm))) return false;
            if (this.TaskResource != input.TaskResource || (this.TaskResource != null && !this.TaskResource.Equals(input.TaskResource))) return false;
            if (this.LogExportPath != input.LogExportPath || (this.LogExportPath != null && !this.LogExportPath.Equals(input.LogExportPath))) return false;

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
                if (this.Role != null) hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Algorithm != null) hashCode = hashCode * 59 + this.Algorithm.GetHashCode();
                if (this.TaskResource != null) hashCode = hashCode * 59 + this.TaskResource.GetHashCode();
                if (this.LogExportPath != null) hashCode = hashCode * 59 + this.LogExportPath.GetHashCode();
                return hashCode;
            }
        }
    }
}
