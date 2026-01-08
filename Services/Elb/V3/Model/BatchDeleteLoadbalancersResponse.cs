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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.LoadbalancerIds != null) hashCode = hashCode * 59 + this.LoadbalancerIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
