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
    /// Request Object
    /// </summary>
    public class CreateTrainJobTagsRequest 
    {

        /// <summary>
        /// 训练作业ID。获取方法请参见[查询训练作业列表](ListTrainingJobs.xml)。
        /// </summary>
        [SDKProperty("training_job_id", IsPath = true)]
        [JsonProperty("training_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainingJobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public CreateTmsTagsRequest Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTrainJobTagsRequest {\n");
            sb.Append("  trainingJobId: ").Append(TrainingJobId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTrainJobTagsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTrainJobTagsRequest input)
        {
            if (input == null) return false;
            if (this.TrainingJobId != input.TrainingJobId || (this.TrainingJobId != null && !this.TrainingJobId.Equals(input.TrainingJobId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.TrainingJobId != null) hashCode = hashCode * 59 + this.TrainingJobId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
