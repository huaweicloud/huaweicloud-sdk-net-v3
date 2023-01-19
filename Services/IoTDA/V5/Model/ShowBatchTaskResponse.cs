using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBatchTaskResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("batchtask", NullValueHandling = NullValueHandling.Ignore)]
        public Task Batchtask { get; set; }

        /// <summary>
        /// 子任务详情列表。
        /// </summary>
        [JsonProperty("task_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskDetail> TaskDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public Page Page { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBatchTaskResponse {\n");
            sb.Append("  batchtask: ").Append(Batchtask).Append("\n");
            sb.Append("  taskDetails: ").Append(TaskDetails).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBatchTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBatchTaskResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Batchtask == input.Batchtask ||
                    (this.Batchtask != null &&
                    this.Batchtask.Equals(input.Batchtask))
                ) && 
                (
                    this.TaskDetails == input.TaskDetails ||
                    this.TaskDetails != null &&
                    input.TaskDetails != null &&
                    this.TaskDetails.SequenceEqual(input.TaskDetails)
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
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
                if (this.Batchtask != null)
                    hashCode = hashCode * 59 + this.Batchtask.GetHashCode();
                if (this.TaskDetails != null)
                    hashCode = hashCode * 59 + this.TaskDetails.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                return hashCode;
            }
        }
    }
}
