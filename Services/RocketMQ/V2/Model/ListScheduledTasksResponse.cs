using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListScheduledTasksResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 任务总数。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("job_count", NullValueHandling = NullValueHandling.Ignore)]
        public string JobCount { get; set; }

        /// <summary>
        /// **参数解释**： 任务列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScheduledTaskEntity> Jobs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListScheduledTasksResponse {\n");
            sb.Append("  jobCount: ").Append(JobCount).Append("\n");
            sb.Append("  jobs: ").Append(Jobs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListScheduledTasksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScheduledTasksResponse input)
        {
            if (input == null) return false;
            if (this.JobCount != input.JobCount || (this.JobCount != null && !this.JobCount.Equals(input.JobCount))) return false;
            if (this.Jobs != input.Jobs || (this.Jobs != null && input.Jobs != null && !this.Jobs.SequenceEqual(input.Jobs))) return false;

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
                if (this.JobCount != null) hashCode = hashCode * 59 + this.JobCount.GetHashCode();
                if (this.Jobs != null) hashCode = hashCode * 59 + this.Jobs.GetHashCode();
                return hashCode;
            }
        }
    }
}
