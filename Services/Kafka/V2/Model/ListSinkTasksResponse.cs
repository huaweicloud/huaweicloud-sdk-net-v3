using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSinkTasksResponse : SdkResponse
    {

        /// <summary>
        /// 转储任务列表。
        /// </summary>
        [JsonProperty("tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListSinkTasksRespTasks> Tasks { get; set; }

        /// <summary>
        /// 转储任务总数。
        /// </summary>
        [JsonProperty("total_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNumber { get; set; }

        /// <summary>
        /// 总的支持任务个数。
        /// </summary>
        [JsonProperty("max_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxTasks { get; set; }

        /// <summary>
        /// 任务总数的配额。
        /// </summary>
        [JsonProperty("quota_tasks", NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotaTasks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSinkTasksResponse {\n");
            sb.Append("  tasks: ").Append(Tasks).Append("\n");
            sb.Append("  totalNumber: ").Append(TotalNumber).Append("\n");
            sb.Append("  maxTasks: ").Append(MaxTasks).Append("\n");
            sb.Append("  quotaTasks: ").Append(QuotaTasks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSinkTasksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSinkTasksResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tasks == input.Tasks ||
                    this.Tasks != null &&
                    input.Tasks != null &&
                    this.Tasks.SequenceEqual(input.Tasks)
                ) && 
                (
                    this.TotalNumber == input.TotalNumber ||
                    (this.TotalNumber != null &&
                    this.TotalNumber.Equals(input.TotalNumber))
                ) && 
                (
                    this.MaxTasks == input.MaxTasks ||
                    (this.MaxTasks != null &&
                    this.MaxTasks.Equals(input.MaxTasks))
                ) && 
                (
                    this.QuotaTasks == input.QuotaTasks ||
                    (this.QuotaTasks != null &&
                    this.QuotaTasks.Equals(input.QuotaTasks))
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
                if (this.Tasks != null)
                    hashCode = hashCode * 59 + this.Tasks.GetHashCode();
                if (this.TotalNumber != null)
                    hashCode = hashCode * 59 + this.TotalNumber.GetHashCode();
                if (this.MaxTasks != null)
                    hashCode = hashCode * 59 + this.MaxTasks.GetHashCode();
                if (this.QuotaTasks != null)
                    hashCode = hashCode * 59 + this.QuotaTasks.GetHashCode();
                return hashCode;
            }
        }
    }
}
