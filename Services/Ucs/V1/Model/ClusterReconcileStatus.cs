using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 针对单个特定集群的综合状态概览
    /// </summary>
    public class ClusterReconcileStatus 
    {

        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("clusterID", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterID { get; set; }

        /// <summary>
        /// 集群中配置集合的总数
        /// </summary>
        [JsonProperty("configSetTotalNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConfigSetTotalNum { get; set; }

        /// <summary>
        /// 健康状态的配置集合数量
        /// </summary>
        [JsonProperty("healthStatusNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? HealthStatusNum { get; set; }

        /// <summary>
        /// 失败状态的配置集合数量
        /// </summary>
        [JsonProperty("failedStatusNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedStatusNum { get; set; }

        /// <summary>
        /// 未知状态的配置集合数量
        /// </summary>
        [JsonProperty("unknownStatusNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnknownStatusNum { get; set; }

        /// <summary>
        /// 正在处理中的配置集合数量
        /// </summary>
        [JsonProperty("progressingStatusNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProgressingStatusNum { get; set; }

        /// <summary>
        /// 与集群关联的Kubernetes资源数量
        /// </summary>
        [JsonProperty("k8sResourceNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? K8sResourceNum { get; set; }

        /// <summary>
        /// 与集群关联的源代码仓库数量
        /// </summary>
        [JsonProperty("sourceRepoNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceRepoNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterReconcileStatus {\n");
            sb.Append("  clusterID: ").Append(ClusterID).Append("\n");
            sb.Append("  configSetTotalNum: ").Append(ConfigSetTotalNum).Append("\n");
            sb.Append("  healthStatusNum: ").Append(HealthStatusNum).Append("\n");
            sb.Append("  failedStatusNum: ").Append(FailedStatusNum).Append("\n");
            sb.Append("  unknownStatusNum: ").Append(UnknownStatusNum).Append("\n");
            sb.Append("  progressingStatusNum: ").Append(ProgressingStatusNum).Append("\n");
            sb.Append("  k8sResourceNum: ").Append(K8sResourceNum).Append("\n");
            sb.Append("  sourceRepoNum: ").Append(SourceRepoNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterReconcileStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterReconcileStatus input)
        {
            if (input == null) return false;
            if (this.ClusterID != input.ClusterID || (this.ClusterID != null && !this.ClusterID.Equals(input.ClusterID))) return false;
            if (this.ConfigSetTotalNum != input.ConfigSetTotalNum || (this.ConfigSetTotalNum != null && !this.ConfigSetTotalNum.Equals(input.ConfigSetTotalNum))) return false;
            if (this.HealthStatusNum != input.HealthStatusNum || (this.HealthStatusNum != null && !this.HealthStatusNum.Equals(input.HealthStatusNum))) return false;
            if (this.FailedStatusNum != input.FailedStatusNum || (this.FailedStatusNum != null && !this.FailedStatusNum.Equals(input.FailedStatusNum))) return false;
            if (this.UnknownStatusNum != input.UnknownStatusNum || (this.UnknownStatusNum != null && !this.UnknownStatusNum.Equals(input.UnknownStatusNum))) return false;
            if (this.ProgressingStatusNum != input.ProgressingStatusNum || (this.ProgressingStatusNum != null && !this.ProgressingStatusNum.Equals(input.ProgressingStatusNum))) return false;
            if (this.K8sResourceNum != input.K8sResourceNum || (this.K8sResourceNum != null && !this.K8sResourceNum.Equals(input.K8sResourceNum))) return false;
            if (this.SourceRepoNum != input.SourceRepoNum || (this.SourceRepoNum != null && !this.SourceRepoNum.Equals(input.SourceRepoNum))) return false;

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
                if (this.ClusterID != null) hashCode = hashCode * 59 + this.ClusterID.GetHashCode();
                if (this.ConfigSetTotalNum != null) hashCode = hashCode * 59 + this.ConfigSetTotalNum.GetHashCode();
                if (this.HealthStatusNum != null) hashCode = hashCode * 59 + this.HealthStatusNum.GetHashCode();
                if (this.FailedStatusNum != null) hashCode = hashCode * 59 + this.FailedStatusNum.GetHashCode();
                if (this.UnknownStatusNum != null) hashCode = hashCode * 59 + this.UnknownStatusNum.GetHashCode();
                if (this.ProgressingStatusNum != null) hashCode = hashCode * 59 + this.ProgressingStatusNum.GetHashCode();
                if (this.K8sResourceNum != null) hashCode = hashCode * 59 + this.K8sResourceNum.GetHashCode();
                if (this.SourceRepoNum != null) hashCode = hashCode * 59 + this.SourceRepoNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
