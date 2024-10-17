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
    /// 创建异步任务响应体。
    /// </summary>
    public class AsyncCreateJobResp 
    {

        /// <summary>
        /// 批量异步创建的任务ID。
        /// </summary>
        [JsonProperty("async_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AsyncJobId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsyncCreateJobResp {\n");
            sb.Append("  asyncJobId: ").Append(AsyncJobId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AsyncCreateJobResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AsyncCreateJobResp input)
        {
            if (input == null) return false;
            if (this.AsyncJobId != input.AsyncJobId || (this.AsyncJobId != null && !this.AsyncJobId.Equals(input.AsyncJobId))) return false;

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
                if (this.AsyncJobId != null) hashCode = hashCode * 59 + this.AsyncJobId.GetHashCode();
                return hashCode;
            }
        }
    }
}
