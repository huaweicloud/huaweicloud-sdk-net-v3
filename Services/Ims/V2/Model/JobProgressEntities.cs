using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ims.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class JobProgressEntities 
    {

        /// <summary>
        /// 镜像ID
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 当前任务名称
        /// </summary>
        [JsonProperty("current_task", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentTask { get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("image_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageName { get; set; }

        /// <summary>
        /// 任务执行进度
        /// </summary>
        [JsonProperty("process_percent", NullValueHandling = NullValueHandling.Ignore)]
        public double? ProcessPercent { get; set; }

        /// <summary>
        /// 子任务ID
        /// </summary>
        [JsonProperty("subJobId", NullValueHandling = NullValueHandling.Ignore)]
        public string SubJobId { get; set; }

        /// <summary>
        /// 子任务结果列表
        /// </summary>
        [JsonProperty("sub_jobs_result", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubJobResult> SubJobsResult { get; set; }

        /// <summary>
        /// 子任务ID列表
        /// </summary>
        [JsonProperty("sub_jobs_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubJobsList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobProgressEntities {\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  currentTask: ").Append(CurrentTask).Append("\n");
            sb.Append("  imageName: ").Append(ImageName).Append("\n");
            sb.Append("  processPercent: ").Append(ProcessPercent).Append("\n");
            sb.Append("  subJobId: ").Append(SubJobId).Append("\n");
            sb.Append("  subJobsResult: ").Append(SubJobsResult).Append("\n");
            sb.Append("  subJobsList: ").Append(SubJobsList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobProgressEntities);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobProgressEntities input)
        {
            if (input == null) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.CurrentTask != input.CurrentTask || (this.CurrentTask != null && !this.CurrentTask.Equals(input.CurrentTask))) return false;
            if (this.ImageName != input.ImageName || (this.ImageName != null && !this.ImageName.Equals(input.ImageName))) return false;
            if (this.ProcessPercent != input.ProcessPercent || (this.ProcessPercent != null && !this.ProcessPercent.Equals(input.ProcessPercent))) return false;
            if (this.SubJobId != input.SubJobId || (this.SubJobId != null && !this.SubJobId.Equals(input.SubJobId))) return false;
            if (this.SubJobsResult != input.SubJobsResult || (this.SubJobsResult != null && input.SubJobsResult != null && !this.SubJobsResult.SequenceEqual(input.SubJobsResult))) return false;
            if (this.SubJobsList != input.SubJobsList || (this.SubJobsList != null && input.SubJobsList != null && !this.SubJobsList.SequenceEqual(input.SubJobsList))) return false;

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
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.CurrentTask != null) hashCode = hashCode * 59 + this.CurrentTask.GetHashCode();
                if (this.ImageName != null) hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                if (this.ProcessPercent != null) hashCode = hashCode * 59 + this.ProcessPercent.GetHashCode();
                if (this.SubJobId != null) hashCode = hashCode * 59 + this.SubJobId.GetHashCode();
                if (this.SubJobsResult != null) hashCode = hashCode * 59 + this.SubJobsResult.GetHashCode();
                if (this.SubJobsList != null) hashCode = hashCode * 59 + this.SubJobsList.GetHashCode();
                return hashCode;
            }
        }
    }
}
