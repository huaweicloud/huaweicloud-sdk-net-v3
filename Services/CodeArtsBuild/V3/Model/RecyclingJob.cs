using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RecyclingJob 
    {

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("job_name", NullValueHandling = NullValueHandling.Ignore)]
        public string JobName { get; set; }

        /// <summary>
        /// CodeArts项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 删除时间
        /// </summary>
        [JsonProperty("delete_time", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteTime { get; set; }

        /// <summary>
        /// 创建时间戳
        /// </summary>
        [JsonProperty("create_time_stamp", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTimeStamp { get; set; }

        /// <summary>
        /// 删除时间戳
        /// </summary>
        [JsonProperty("delete_time_stamp", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteTimeStamp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecyclingJob {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  jobName: ").Append(JobName).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  creatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  deleteTime: ").Append(DeleteTime).Append("\n");
            sb.Append("  createTimeStamp: ").Append(CreateTimeStamp).Append("\n");
            sb.Append("  deleteTimeStamp: ").Append(DeleteTimeStamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecyclingJob);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecyclingJob input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.JobName != input.JobName || (this.JobName != null && !this.JobName.Equals(input.JobName))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.CreatorName != input.CreatorName || (this.CreatorName != null && !this.CreatorName.Equals(input.CreatorName))) return false;
            if (this.CreatorId != input.CreatorId || (this.CreatorId != null && !this.CreatorId.Equals(input.CreatorId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.DeleteTime != input.DeleteTime || (this.DeleteTime != null && !this.DeleteTime.Equals(input.DeleteTime))) return false;
            if (this.CreateTimeStamp != input.CreateTimeStamp || (this.CreateTimeStamp != null && !this.CreateTimeStamp.Equals(input.CreateTimeStamp))) return false;
            if (this.DeleteTimeStamp != input.DeleteTimeStamp || (this.DeleteTimeStamp != null && !this.DeleteTimeStamp.Equals(input.DeleteTimeStamp))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobName != null) hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.CreatorName != null) hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.CreatorId != null) hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.DeleteTime != null) hashCode = hashCode * 59 + this.DeleteTime.GetHashCode();
                if (this.CreateTimeStamp != null) hashCode = hashCode * 59 + this.CreateTimeStamp.GetHashCode();
                if (this.DeleteTimeStamp != null) hashCode = hashCode * 59 + this.DeleteTimeStamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
