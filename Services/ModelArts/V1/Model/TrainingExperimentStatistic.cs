using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 训练实验的统计数据。
    /// </summary>
    public class TrainingExperimentStatistic 
    {

        /// <summary>
        /// **参数解释**：当前实验下的训练作业总个数。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("job_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? JobCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrainingExperimentStatistic {\n");
            sb.Append("  jobCount: ").Append(JobCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrainingExperimentStatistic);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TrainingExperimentStatistic input)
        {
            if (input == null) return false;
            if (this.JobCount != input.JobCount || (this.JobCount != null && !this.JobCount.Equals(input.JobCount))) return false;

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
                return hashCode;
            }
        }
    }
}
