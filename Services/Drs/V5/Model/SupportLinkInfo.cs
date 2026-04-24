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
    /// 支持的链路信息
    /// </summary>
    public class SupportLinkInfo 
    {

        /// <summary>
        /// 引擎类型
        /// </summary>
        [JsonProperty("engine_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineType { get; set; }

        /// <summary>
        /// 网络类型。取值： - eip：公网网络。 - vpc：VPC网络，灾备场景不支持选择VPC网络。 - vpn：VPN、专线网络。
        /// </summary>
        [JsonProperty("net_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NetType { get; set; }

        /// <summary>
        /// 迁移模式。取值： - FULL_TRANS ：全量。 - FULL_INCR_TRANS：全量+增量。 - INCR_TRANS：增量。
        /// </summary>
        [JsonProperty("task_modes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TaskModes { get; set; }

        /// <summary>
        /// 迁移方向。取值： - up：入云 ，灾备场景时对应本云为备。 - down：出云，灾备场景时对应本云为主。 - non-dbs：自建。
        /// </summary>
        [JsonProperty("job_direction", NullValueHandling = NullValueHandling.Ignore)]
        public string JobDirection { get; set; }

        /// <summary>
        /// 云上实例类型。取值： - Single：单机模式。 - Ha：主备模式。 - Cluster：集群模式。 - Sharding：分片模式。 - Independent：GaussDB独立部署模式。
        /// </summary>
        [JsonProperty("cluster_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterMode { get; set; }

        /// <summary>
        /// DRS实例类型。取值： - Single ：单机。 - Ha：主备。
        /// </summary>
        [JsonProperty("job_instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string JobInstanceType { get; set; }

        /// <summary>
        /// 是否支持绑定EIP
        /// </summary>
        [JsonProperty("is_support_bind_eip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportBindEip { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportLinkInfo {\n");
            sb.Append("  engineType: ").Append(EngineType).Append("\n");
            sb.Append("  netType: ").Append(NetType).Append("\n");
            sb.Append("  taskModes: ").Append(TaskModes).Append("\n");
            sb.Append("  jobDirection: ").Append(JobDirection).Append("\n");
            sb.Append("  clusterMode: ").Append(ClusterMode).Append("\n");
            sb.Append("  jobInstanceType: ").Append(JobInstanceType).Append("\n");
            sb.Append("  isSupportBindEip: ").Append(IsSupportBindEip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SupportLinkInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SupportLinkInfo input)
        {
            if (input == null) return false;
            if (this.EngineType != input.EngineType || (this.EngineType != null && !this.EngineType.Equals(input.EngineType))) return false;
            if (this.NetType != input.NetType || (this.NetType != null && !this.NetType.Equals(input.NetType))) return false;
            if (this.TaskModes != input.TaskModes || (this.TaskModes != null && input.TaskModes != null && !this.TaskModes.SequenceEqual(input.TaskModes))) return false;
            if (this.JobDirection != input.JobDirection || (this.JobDirection != null && !this.JobDirection.Equals(input.JobDirection))) return false;
            if (this.ClusterMode != input.ClusterMode || (this.ClusterMode != null && !this.ClusterMode.Equals(input.ClusterMode))) return false;
            if (this.JobInstanceType != input.JobInstanceType || (this.JobInstanceType != null && !this.JobInstanceType.Equals(input.JobInstanceType))) return false;
            if (this.IsSupportBindEip != input.IsSupportBindEip || (this.IsSupportBindEip != null && !this.IsSupportBindEip.Equals(input.IsSupportBindEip))) return false;

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
                if (this.EngineType != null) hashCode = hashCode * 59 + this.EngineType.GetHashCode();
                if (this.NetType != null) hashCode = hashCode * 59 + this.NetType.GetHashCode();
                if (this.TaskModes != null) hashCode = hashCode * 59 + this.TaskModes.GetHashCode();
                if (this.JobDirection != null) hashCode = hashCode * 59 + this.JobDirection.GetHashCode();
                if (this.ClusterMode != null) hashCode = hashCode * 59 + this.ClusterMode.GetHashCode();
                if (this.JobInstanceType != null) hashCode = hashCode * 59 + this.JobInstanceType.GetHashCode();
                if (this.IsSupportBindEip != null) hashCode = hashCode * 59 + this.IsSupportBindEip.GetHashCode();
                return hashCode;
            }
        }
    }
}
