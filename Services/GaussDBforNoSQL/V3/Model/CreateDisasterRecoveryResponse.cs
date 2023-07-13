using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateDisasterRecoveryResponse : SdkResponse
    {

        /// <summary>
        /// 搭建容灾关系的工作ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 容灾ID。
        /// </summary>
        [JsonProperty("disaster_recovery_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DisasterRecoveryId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDisasterRecoveryResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  disasterRecoveryId: ").Append(DisasterRecoveryId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDisasterRecoveryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDisasterRecoveryResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.DisasterRecoveryId == input.DisasterRecoveryId ||
                    (this.DisasterRecoveryId != null &&
                    this.DisasterRecoveryId.Equals(input.DisasterRecoveryId))
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.DisasterRecoveryId != null)
                    hashCode = hashCode * 59 + this.DisasterRecoveryId.GetHashCode();
                return hashCode;
            }
        }
    }
}
