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
    /// 
    /// </summary>
    public class ClusterStatus 
    {

        /// <summary>
        /// kubernetes版本
        /// </summary>
        [JsonProperty("kubernetesVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// conditions信息
        /// </summary>
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConditionStatus> Conditions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodeSummary", NullValueHandling = NullValueHandling.Ignore)]
        public NodeSummary NodeSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resourceSummary", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceSummary ResourceSummary { get; set; }

        /// <summary>
        /// 端点
        /// </summary>
        [JsonProperty("endpoints", NullValueHandling = NullValueHandling.Ignore)]
        public Object Endpoints { get; set; }

        /// <summary>
        /// 阶段状态信息
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }

        /// <summary>
        /// 表述上次状况变化的原因
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// 上次状态转换的详细信息
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 欠费冻结
        /// </summary>
        [JsonProperty("arrearFreeze", NullValueHandling = NullValueHandling.Ignore)]
        public string ArrearFreeze { get; set; }

        /// <summary>
        /// 公安冻结
        /// </summary>
        [JsonProperty("policeFreeze", NullValueHandling = NullValueHandling.Ignore)]
        public string PoliceFreeze { get; set; }

        /// <summary>
        /// 开启的资源列表
        /// </summary>
        [JsonProperty("apiEnablements", NullValueHandling = NullValueHandling.Ignore)]
        public List<APIEnablement> ApiEnablements { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterStatus {\n");
            sb.Append("  kubernetesVersion: ").Append(KubernetesVersion).Append("\n");
            sb.Append("  conditions: ").Append(Conditions).Append("\n");
            sb.Append("  nodeSummary: ").Append(NodeSummary).Append("\n");
            sb.Append("  resourceSummary: ").Append(ResourceSummary).Append("\n");
            sb.Append("  endpoints: ").Append(Endpoints).Append("\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  arrearFreeze: ").Append(ArrearFreeze).Append("\n");
            sb.Append("  policeFreeze: ").Append(PoliceFreeze).Append("\n");
            sb.Append("  apiEnablements: ").Append(ApiEnablements).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterStatus input)
        {
            if (input == null) return false;
            if (this.KubernetesVersion != input.KubernetesVersion || (this.KubernetesVersion != null && !this.KubernetesVersion.Equals(input.KubernetesVersion))) return false;
            if (this.Conditions != input.Conditions || (this.Conditions != null && input.Conditions != null && !this.Conditions.SequenceEqual(input.Conditions))) return false;
            if (this.NodeSummary != input.NodeSummary || (this.NodeSummary != null && !this.NodeSummary.Equals(input.NodeSummary))) return false;
            if (this.ResourceSummary != input.ResourceSummary || (this.ResourceSummary != null && !this.ResourceSummary.Equals(input.ResourceSummary))) return false;
            if (this.Endpoints != input.Endpoints || (this.Endpoints != null && !this.Endpoints.Equals(input.Endpoints))) return false;
            if (this.Phase != input.Phase || (this.Phase != null && !this.Phase.Equals(input.Phase))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.ArrearFreeze != input.ArrearFreeze || (this.ArrearFreeze != null && !this.ArrearFreeze.Equals(input.ArrearFreeze))) return false;
            if (this.PoliceFreeze != input.PoliceFreeze || (this.PoliceFreeze != null && !this.PoliceFreeze.Equals(input.PoliceFreeze))) return false;
            if (this.ApiEnablements != input.ApiEnablements || (this.ApiEnablements != null && input.ApiEnablements != null && !this.ApiEnablements.SequenceEqual(input.ApiEnablements))) return false;

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
                if (this.KubernetesVersion != null) hashCode = hashCode * 59 + this.KubernetesVersion.GetHashCode();
                if (this.Conditions != null) hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.NodeSummary != null) hashCode = hashCode * 59 + this.NodeSummary.GetHashCode();
                if (this.ResourceSummary != null) hashCode = hashCode * 59 + this.ResourceSummary.GetHashCode();
                if (this.Endpoints != null) hashCode = hashCode * 59 + this.Endpoints.GetHashCode();
                if (this.Phase != null) hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.ArrearFreeze != null) hashCode = hashCode * 59 + this.ArrearFreeze.GetHashCode();
                if (this.PoliceFreeze != null) hashCode = hashCode * 59 + this.PoliceFreeze.GetHashCode();
                if (this.ApiEnablements != null) hashCode = hashCode * 59 + this.ApiEnablements.GetHashCode();
                return hashCode;
            }
        }
    }
}
