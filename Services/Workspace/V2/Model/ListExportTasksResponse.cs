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
    public class ListExportTasksResponse : SdkResponse
    {

        /// <summary>
        /// 导出任务列表。
        /// </summary>
        [JsonProperty("export_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExportTaskItem> ExportTasks { get; set; }

        /// <summary>
        /// 导出任务总数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListExportTasksResponse {\n");
            sb.Append("  exportTasks: ").Append(ExportTasks).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListExportTasksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListExportTasksResponse input)
        {
            if (input == null) return false;
            if (this.ExportTasks != input.ExportTasks || (this.ExportTasks != null && input.ExportTasks != null && !this.ExportTasks.SequenceEqual(input.ExportTasks))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;

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
                if (this.ExportTasks != null) hashCode = hashCode * 59 + this.ExportTasks.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
