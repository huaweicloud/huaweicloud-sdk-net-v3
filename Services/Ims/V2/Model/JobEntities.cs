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
    public class JobEntities 
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
        /// 批量任务执行结果
        /// </summary>
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobEntitiesResult> Results { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobEntities {\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  currentTask: ").Append(CurrentTask).Append("\n");
            sb.Append("  imageName: ").Append(ImageName).Append("\n");
            sb.Append("  processPercent: ").Append(ProcessPercent).Append("\n");
            sb.Append("  results: ").Append(Results).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobEntities);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobEntities input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageId == input.ImageId ||
                    (this.ImageId != null &&
                    this.ImageId.Equals(input.ImageId))
                ) && 
                (
                    this.CurrentTask == input.CurrentTask ||
                    (this.CurrentTask != null &&
                    this.CurrentTask.Equals(input.CurrentTask))
                ) && 
                (
                    this.ImageName == input.ImageName ||
                    (this.ImageName != null &&
                    this.ImageName.Equals(input.ImageName))
                ) && 
                (
                    this.ProcessPercent == input.ProcessPercent ||
                    (this.ProcessPercent != null &&
                    this.ProcessPercent.Equals(input.ProcessPercent))
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ImageId != null)
                    hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.CurrentTask != null)
                    hashCode = hashCode * 59 + this.CurrentTask.GetHashCode();
                if (this.ImageName != null)
                    hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                if (this.ProcessPercent != null)
                    hashCode = hashCode * 59 + this.ProcessPercent.GetHashCode();
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
                return hashCode;
            }
        }
    }
}
