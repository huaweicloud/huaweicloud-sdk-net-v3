using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class LimitSpeedReq 
    {

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 限速信息请求体
        /// </summary>
        [JsonProperty("speed_limit", NullValueHandling = NullValueHandling.Ignore)]
        public List<SpeedLimitInfo> SpeedLimit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LimitSpeedReq {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  speedLimit: ").Append(SpeedLimit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LimitSpeedReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LimitSpeedReq input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.SpeedLimit != input.SpeedLimit || (this.SpeedLimit != null && input.SpeedLimit != null && !this.SpeedLimit.SequenceEqual(input.SpeedLimit))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.SpeedLimit != null) hashCode = hashCode * 59 + this.SpeedLimit.GetHashCode();
                return hashCode;
            }
        }
    }
}
