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
    /// Request Object
    /// </summary>
    public class ShowScriptDetailRequest 
    {

        /// <summary>
        /// 脚本ID。
        /// </summary>
        [SDKProperty("script_id", IsPath = true)]
        [JsonProperty("script_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptId { get; set; }

        /// <summary>
        /// 执行脚本的任务ID。
        /// </summary>
        [SDKProperty("script_task_id", IsQuery = true)]
        [JsonProperty("script_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptTaskId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowScriptDetailRequest {\n");
            sb.Append("  scriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  scriptTaskId: ").Append(ScriptTaskId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowScriptDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowScriptDetailRequest input)
        {
            if (input == null) return false;
            if (this.ScriptId != input.ScriptId || (this.ScriptId != null && !this.ScriptId.Equals(input.ScriptId))) return false;
            if (this.ScriptTaskId != input.ScriptTaskId || (this.ScriptTaskId != null && !this.ScriptTaskId.Equals(input.ScriptTaskId))) return false;

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
                if (this.ScriptId != null) hashCode = hashCode * 59 + this.ScriptId.GetHashCode();
                if (this.ScriptTaskId != null) hashCode = hashCode * 59 + this.ScriptTaskId.GetHashCode();
                return hashCode;
            }
        }
    }
}
