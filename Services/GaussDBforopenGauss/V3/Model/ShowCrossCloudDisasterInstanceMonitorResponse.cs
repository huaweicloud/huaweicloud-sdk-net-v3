using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowCrossCloudDisasterInstanceMonitorResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 实例ID。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 容灾状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 数据恢复点目标。
        /// </summary>
        [JsonProperty("rpo", NullValueHandling = NullValueHandling.Ignore)]
        public string Rpo { get; set; }

        /// <summary>
        /// 数据恢复时间目标。
        /// </summary>
        [JsonProperty("rto", NullValueHandling = NullValueHandling.Ignore)]
        public string Rto { get; set; }

        /// <summary>
        /// rpo阈值。
        /// </summary>
        [JsonProperty("rpo_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string RpoThreshold { get; set; }

        /// <summary>
        /// rto阈值。
        /// </summary>
        [JsonProperty("rto_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public string RtoThreshold { get; set; }

        /// <summary>
        /// 主从切换进度。该值为一个百分数。例如：40%。
        /// </summary>
        [JsonProperty("switchover_progress", NullValueHandling = NullValueHandling.Ignore)]
        public string SwitchoverProgress { get; set; }

        /// <summary>
        /// 容灾升主进度。该值为一个百分数。例如：40%。
        /// </summary>
        [JsonProperty("failover_progress", NullValueHandling = NullValueHandling.Ignore)]
        public string FailoverProgress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCrossCloudDisasterInstanceMonitorResponse {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  rpo: ").Append(Rpo).Append("\n");
            sb.Append("  rto: ").Append(Rto).Append("\n");
            sb.Append("  rpoThreshold: ").Append(RpoThreshold).Append("\n");
            sb.Append("  rtoThreshold: ").Append(RtoThreshold).Append("\n");
            sb.Append("  switchoverProgress: ").Append(SwitchoverProgress).Append("\n");
            sb.Append("  failoverProgress: ").Append(FailoverProgress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCrossCloudDisasterInstanceMonitorResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCrossCloudDisasterInstanceMonitorResponse input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Rpo != input.Rpo || (this.Rpo != null && !this.Rpo.Equals(input.Rpo))) return false;
            if (this.Rto != input.Rto || (this.Rto != null && !this.Rto.Equals(input.Rto))) return false;
            if (this.RpoThreshold != input.RpoThreshold || (this.RpoThreshold != null && !this.RpoThreshold.Equals(input.RpoThreshold))) return false;
            if (this.RtoThreshold != input.RtoThreshold || (this.RtoThreshold != null && !this.RtoThreshold.Equals(input.RtoThreshold))) return false;
            if (this.SwitchoverProgress != input.SwitchoverProgress || (this.SwitchoverProgress != null && !this.SwitchoverProgress.Equals(input.SwitchoverProgress))) return false;
            if (this.FailoverProgress != input.FailoverProgress || (this.FailoverProgress != null && !this.FailoverProgress.Equals(input.FailoverProgress))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Rpo != null) hashCode = hashCode * 59 + this.Rpo.GetHashCode();
                if (this.Rto != null) hashCode = hashCode * 59 + this.Rto.GetHashCode();
                if (this.RpoThreshold != null) hashCode = hashCode * 59 + this.RpoThreshold.GetHashCode();
                if (this.RtoThreshold != null) hashCode = hashCode * 59 + this.RtoThreshold.GetHashCode();
                if (this.SwitchoverProgress != null) hashCode = hashCode * 59 + this.SwitchoverProgress.GetHashCode();
                if (this.FailoverProgress != null) hashCode = hashCode * 59 + this.FailoverProgress.GetHashCode();
                return hashCode;
            }
        }
    }
}
