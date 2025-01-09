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
    public class ShowDesktopPoolsScriptExecTasksResponse : SdkResponse
    {

        /// <summary>
        /// 脚本执行任务列表。
        /// </summary>
        [JsonProperty("script_execution_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScriptExecutionTask> ScriptExecutionTasks { get; set; }

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
            sb.Append("class ShowDesktopPoolsScriptExecTasksResponse {\n");
            sb.Append("  scriptExecutionTasks: ").Append(ScriptExecutionTasks).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDesktopPoolsScriptExecTasksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDesktopPoolsScriptExecTasksResponse input)
        {
            if (input == null) return false;
            if (this.ScriptExecutionTasks != input.ScriptExecutionTasks || (this.ScriptExecutionTasks != null && input.ScriptExecutionTasks != null && !this.ScriptExecutionTasks.SequenceEqual(input.ScriptExecutionTasks))) return false;
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
                if (this.ScriptExecutionTasks != null) hashCode = hashCode * 59 + this.ScriptExecutionTasks.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
