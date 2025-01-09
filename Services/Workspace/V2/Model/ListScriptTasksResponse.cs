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
    public class ListScriptTasksResponse : SdkResponse
    {

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 脚本任务列表。
        /// </summary>
        [JsonProperty("script_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScriptTaskInfo> ScriptTasks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListScriptTasksResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  scriptTasks: ").Append(ScriptTasks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListScriptTasksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScriptTasksResponse input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.ScriptTasks != input.ScriptTasks || (this.ScriptTasks != null && input.ScriptTasks != null && !this.ScriptTasks.SequenceEqual(input.ScriptTasks))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.ScriptTasks != null) hashCode = hashCode * 59 + this.ScriptTasks.GetHashCode();
                return hashCode;
            }
        }
    }
}