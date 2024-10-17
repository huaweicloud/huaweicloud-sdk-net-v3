using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class JobEntities 
    {

        /// <summary>
        /// 云服务器相关操作显示server_id。
        /// </summary>
        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        /// <summary>
        /// 网卡相关操作显示nic_id。
        /// </summary>
        [JsonProperty("nic_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NicId { get; set; }

        /// <summary>
        /// 每个子任务的执行信息。
        /// </summary>
        [JsonProperty("sub_jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubJob> SubJobs { get; set; }

        /// <summary>
        /// 子任务数量。
        /// </summary>
        [JsonProperty("sub_jobs_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubJobsTotal { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobEntities {\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  nicId: ").Append(NicId).Append("\n");
            sb.Append("  subJobs: ").Append(SubJobs).Append("\n");
            sb.Append("  subJobsTotal: ").Append(SubJobsTotal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobEntities);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobEntities input)
        {
            if (input == null) return false;
            if (this.ServerId != input.ServerId || (this.ServerId != null && !this.ServerId.Equals(input.ServerId))) return false;
            if (this.NicId != input.NicId || (this.NicId != null && !this.NicId.Equals(input.NicId))) return false;
            if (this.SubJobs != input.SubJobs || (this.SubJobs != null && input.SubJobs != null && !this.SubJobs.SequenceEqual(input.SubJobs))) return false;
            if (this.SubJobsTotal != input.SubJobsTotal || (this.SubJobsTotal != null && !this.SubJobsTotal.Equals(input.SubJobsTotal))) return false;

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
                if (this.ServerId != null) hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.NicId != null) hashCode = hashCode * 59 + this.NicId.GetHashCode();
                if (this.SubJobs != null) hashCode = hashCode * 59 + this.SubJobs.GetHashCode();
                if (this.SubJobsTotal != null) hashCode = hashCode * 59 + this.SubJobsTotal.GetHashCode();
                return hashCode;
            }
        }
    }
}
