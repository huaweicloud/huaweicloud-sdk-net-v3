using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 提交异步任务响应体。
    /// </summary>
    public class AsyncCommitJobResp 
    {

        /// <summary>
        /// 批量异步任务ID。
        /// </summary>
        [JsonProperty("async_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AsyncJobId { get; set; }

        /// <summary>
        /// 批量异步任务状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 提交指定ID批量异步任务结果信息。
        /// </summary>
        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Msg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsyncCommitJobResp {\n");
            sb.Append("  asyncJobId: ").Append(AsyncJobId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  msg: ").Append(Msg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AsyncCommitJobResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AsyncCommitJobResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AsyncJobId == input.AsyncJobId ||
                    (this.AsyncJobId != null &&
                    this.AsyncJobId.Equals(input.AsyncJobId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Msg == input.Msg ||
                    (this.Msg != null &&
                    this.Msg.Equals(input.Msg))
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
                if (this.AsyncJobId != null)
                    hashCode = hashCode * 59 + this.AsyncJobId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Msg != null)
                    hashCode = hashCode * 59 + this.Msg.GetHashCode();
                return hashCode;
            }
        }
    }
}
