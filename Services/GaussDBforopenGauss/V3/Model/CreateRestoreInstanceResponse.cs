using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateRestoreInstanceResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("instance", NullValueHandling = NullValueHandling.Ignore)]
        public CreateInstanceRespItem Instance { get; set; }

        /// <summary>
        /// 恢复新实例的任务id。  仅恢复按需实例时会返回该参数。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRestoreInstanceResponse {\n");
            sb.Append("  instance: ").Append(Instance).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRestoreInstanceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRestoreInstanceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Instance == input.Instance ||
                    (this.Instance != null &&
                    this.Instance.Equals(input.Instance))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
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
                if (this.Instance != null)
                    hashCode = hashCode * 59 + this.Instance.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                return hashCode;
            }
        }
    }
}
