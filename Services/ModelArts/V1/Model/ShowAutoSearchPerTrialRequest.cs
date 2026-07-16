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
    public class ShowAutoSearchPerTrialRequest 
    {

        /// <summary>
        /// 训练作业ID。获取方法请参见[查询训练作业列表](ListTrainingJobs.xml)。
        /// </summary>
        [SDKProperty("training_job_id", IsPath = true)]
        [JsonProperty("training_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainingJobId { get; set; }

        /// <summary>
        /// 超参搜索的trial_id。
        /// </summary>
        [SDKProperty("trial_id", IsPath = true)]
        [JsonProperty("trial_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrialId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAutoSearchPerTrialRequest {\n");
            sb.Append("  trainingJobId: ").Append(TrainingJobId).Append("\n");
            sb.Append("  trialId: ").Append(TrialId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAutoSearchPerTrialRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAutoSearchPerTrialRequest input)
        {
            if (input == null) return false;
            if (this.TrainingJobId != input.TrainingJobId || (this.TrainingJobId != null && !this.TrainingJobId.Equals(input.TrainingJobId))) return false;
            if (this.TrialId != input.TrialId || (this.TrialId != null && !this.TrialId.Equals(input.TrialId))) return false;

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
                if (this.TrialId != null) hashCode = hashCode * 59 + this.TrialId.GetHashCode();
                return hashCode;
            }
        }
    }
}
