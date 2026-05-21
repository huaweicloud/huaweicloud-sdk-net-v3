using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchDeleteLoadbalancersResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：请求ID。  **取值范围**：由数字、小写字母和中划线（-）组成的字符串，自动生成。
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 批量删除任务id
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 待删除的负载均衡器id列表。
        /// </summary>
        [JsonProperty("loadbalancer_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LoadbalancerIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteLoadbalancersResponse {\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  loadbalancerIds: ").Append(LoadbalancerIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteLoadbalancersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteLoadbalancersResponse input)
        {
            if (input == null) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.LoadbalancerIds != input.LoadbalancerIds || (this.LoadbalancerIds != null && input.LoadbalancerIds != null && !this.LoadbalancerIds.SequenceEqual(input.LoadbalancerIds))) return false;

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
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.LoadbalancerIds != null) hashCode = hashCode * 59 + this.LoadbalancerIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
