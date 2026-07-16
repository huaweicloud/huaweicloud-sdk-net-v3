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
    public class ChangeTrainingExperimentRequest 
    {

        /// <summary>
        /// 训练实验ID。在训练作业创建时获取实验ID。
        /// </summary>
        [SDKProperty("experiment_id", IsPath = true)]
        [JsonProperty("experiment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExperimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public ChangeTrainingExperimentRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeTrainingExperimentRequest {\n");
            sb.Append("  experimentId: ").Append(ExperimentId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeTrainingExperimentRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeTrainingExperimentRequest input)
        {
            if (input == null) return false;
            if (this.ExperimentId != input.ExperimentId || (this.ExperimentId != null && !this.ExperimentId.Equals(input.ExperimentId))) return false;
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
                if (this.ExperimentId != null) hashCode = hashCode * 59 + this.ExperimentId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
