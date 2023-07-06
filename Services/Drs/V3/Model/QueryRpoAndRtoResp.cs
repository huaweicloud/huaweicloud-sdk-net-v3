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
    /// RPO和RTO信息体
    /// </summary>
    public class QueryRpoAndRtoResp 
    {

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rpo_info", NullValueHandling = NullValueHandling.Ignore)]
        public RpoAndRtoInfo RpoInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rto_info", NullValueHandling = NullValueHandling.Ignore)]
        public RpoAndRtoInfo RtoInfo { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryRpoAndRtoResp {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  rpoInfo: ").Append(RpoInfo).Append("\n");
            sb.Append("  rtoInfo: ").Append(RtoInfo).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryRpoAndRtoResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryRpoAndRtoResp input)
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
                    this.RpoInfo == input.RpoInfo ||
                    (this.RpoInfo != null &&
                    this.RpoInfo.Equals(input.RpoInfo))
                ) && 
                (
                    this.RtoInfo == input.RtoInfo ||
                    (this.RtoInfo != null &&
                    this.RtoInfo.Equals(input.RtoInfo))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorMsg == input.ErrorMsg ||
                    (this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(input.ErrorMsg))
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
                if (this.RpoInfo != null)
                    hashCode = hashCode * 59 + this.RpoInfo.GetHashCode();
                if (this.RtoInfo != null)
                    hashCode = hashCode * 59 + this.RtoInfo.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null)
                    hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
