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
    public class UpdateInstanceConfigurationResponse : SdkResponse
    {

        /// <summary>
        /// 修改实例参数的异步任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 实例是否需要重启。 - “true”需要重启。 - “false”不需要重启。
        /// </summary>
        [JsonProperty("restart_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RestartRequired { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInstanceConfigurationResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  restartRequired: ").Append(RestartRequired).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateInstanceConfigurationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateInstanceConfigurationResponse input)
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
                    this.RestartRequired == input.RestartRequired ||
                    (this.RestartRequired != null &&
                    this.RestartRequired.Equals(input.RestartRequired))
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
                if (this.RestartRequired != null)
                    hashCode = hashCode * 59 + this.RestartRequired.GetHashCode();
                return hashCode;
            }
        }
    }
}
