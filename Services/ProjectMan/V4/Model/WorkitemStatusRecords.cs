using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class WorkitemStatusRecords 
    {

        /// <summary>
        /// 工作项的记录id，一个工作项对应一条记录
        /// </summary>
        [JsonProperty("work_item_record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkItemRecordId { get; set; }

        /// <summary>
        /// 工作项id
        /// </summary>
        [JsonProperty("work_item_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkItemId { get; set; }

        /// <summary>
        /// devcloud项目的32位id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 操作历史
        /// </summary>
        [JsonProperty("work_item_statuses", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkitemStatus> WorkItemStatuses { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkitemStatusRecords {\n");
            sb.Append("  workItemRecordId: ").Append(WorkItemRecordId).Append("\n");
            sb.Append("  workItemId: ").Append(WorkItemId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  workItemStatuses: ").Append(WorkItemStatuses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkitemStatusRecords);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkitemStatusRecords input)
        {
            if (input == null) return false;
            if (this.WorkItemRecordId != input.WorkItemRecordId || (this.WorkItemRecordId != null && !this.WorkItemRecordId.Equals(input.WorkItemRecordId))) return false;
            if (this.WorkItemId != input.WorkItemId || (this.WorkItemId != null && !this.WorkItemId.Equals(input.WorkItemId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.WorkItemStatuses != input.WorkItemStatuses || (this.WorkItemStatuses != null && input.WorkItemStatuses != null && !this.WorkItemStatuses.SequenceEqual(input.WorkItemStatuses))) return false;

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
                if (this.WorkItemRecordId != null) hashCode = hashCode * 59 + this.WorkItemRecordId.GetHashCode();
                if (this.WorkItemId != null) hashCode = hashCode * 59 + this.WorkItemId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.WorkItemStatuses != null) hashCode = hashCode * 59 + this.WorkItemStatuses.GetHashCode();
                return hashCode;
            }
        }
    }
}
