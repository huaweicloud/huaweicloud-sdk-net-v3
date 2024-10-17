using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAutoScalingPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 自动变配策略ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 自动变配开关状态。  取值：  - ON：已开启 - OFF：已关闭
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 监测周期（单位：秒）。 在整个观测窗口期内，若CPU平均使用率大于等于设定值，则在观测窗口结束后，进行扩容。
        /// </summary>
        [JsonProperty("monitor_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public int? MonitorCycle { get; set; }

        /// <summary>
        /// 静默周期（单位：秒）。 两次自动扩容或自动回缩的最小间隔时间。
        /// </summary>
        [JsonProperty("silence_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public int? SilenceCycle { get; set; }

        /// <summary>
        /// 扩容阈值（百分比数值），指CPU平均使用率。
        /// </summary>
        [JsonProperty("enlarge_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? EnlargeThreshold { get; set; }

        /// <summary>
        /// 扩容规格上限。
        /// </summary>
        [JsonProperty("max_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxFlavor { get; set; }

        /// <summary>
        /// 自动回缩开关状态。  取值：  - true：已开启 - false：已关闭
        /// </summary>
        [JsonProperty("reduce_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReduceEnabled { get; set; }

        /// <summary>
        /// 缩容规格下限。
        /// </summary>
        [JsonProperty("min_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string MinFlavor { get; set; }

        /// <summary>
        /// 静默期开始时间（上一次变更结束时间）。  格式为\&quot;yyyy-mm-ddThh:mm:ssZ\&quot;。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [JsonProperty("silence_start_at", NullValueHandling = NullValueHandling.Ignore)]
        public string SilenceStartAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scaling_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingStrategyInfo ScalingStrategy { get; set; }

        /// <summary>
        /// 只读节点数量上限。
        /// </summary>
        [JsonProperty("max_read_only_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxReadOnlyCount { get; set; }

        /// <summary>
        /// 只读节点数量下限。
        /// </summary>
        [JsonProperty("min_read_only_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinReadOnlyCount { get; set; }

        /// <summary>
        /// 只读节点读写分离权重。
        /// </summary>
        [JsonProperty("read_only_weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReadOnlyWeight { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAutoScalingPolicyResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  monitorCycle: ").Append(MonitorCycle).Append("\n");
            sb.Append("  silenceCycle: ").Append(SilenceCycle).Append("\n");
            sb.Append("  enlargeThreshold: ").Append(EnlargeThreshold).Append("\n");
            sb.Append("  maxFlavor: ").Append(MaxFlavor).Append("\n");
            sb.Append("  reduceEnabled: ").Append(ReduceEnabled).Append("\n");
            sb.Append("  minFlavor: ").Append(MinFlavor).Append("\n");
            sb.Append("  silenceStartAt: ").Append(SilenceStartAt).Append("\n");
            sb.Append("  scalingStrategy: ").Append(ScalingStrategy).Append("\n");
            sb.Append("  maxReadOnlyCount: ").Append(MaxReadOnlyCount).Append("\n");
            sb.Append("  minReadOnlyCount: ").Append(MinReadOnlyCount).Append("\n");
            sb.Append("  readOnlyWeight: ").Append(ReadOnlyWeight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAutoScalingPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAutoScalingPolicyResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.MonitorCycle != input.MonitorCycle || (this.MonitorCycle != null && !this.MonitorCycle.Equals(input.MonitorCycle))) return false;
            if (this.SilenceCycle != input.SilenceCycle || (this.SilenceCycle != null && !this.SilenceCycle.Equals(input.SilenceCycle))) return false;
            if (this.EnlargeThreshold != input.EnlargeThreshold || (this.EnlargeThreshold != null && !this.EnlargeThreshold.Equals(input.EnlargeThreshold))) return false;
            if (this.MaxFlavor != input.MaxFlavor || (this.MaxFlavor != null && !this.MaxFlavor.Equals(input.MaxFlavor))) return false;
            if (this.ReduceEnabled != input.ReduceEnabled || (this.ReduceEnabled != null && !this.ReduceEnabled.Equals(input.ReduceEnabled))) return false;
            if (this.MinFlavor != input.MinFlavor || (this.MinFlavor != null && !this.MinFlavor.Equals(input.MinFlavor))) return false;
            if (this.SilenceStartAt != input.SilenceStartAt || (this.SilenceStartAt != null && !this.SilenceStartAt.Equals(input.SilenceStartAt))) return false;
            if (this.ScalingStrategy != input.ScalingStrategy || (this.ScalingStrategy != null && !this.ScalingStrategy.Equals(input.ScalingStrategy))) return false;
            if (this.MaxReadOnlyCount != input.MaxReadOnlyCount || (this.MaxReadOnlyCount != null && !this.MaxReadOnlyCount.Equals(input.MaxReadOnlyCount))) return false;
            if (this.MinReadOnlyCount != input.MinReadOnlyCount || (this.MinReadOnlyCount != null && !this.MinReadOnlyCount.Equals(input.MinReadOnlyCount))) return false;
            if (this.ReadOnlyWeight != input.ReadOnlyWeight || (this.ReadOnlyWeight != null && !this.ReadOnlyWeight.Equals(input.ReadOnlyWeight))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.MonitorCycle != null) hashCode = hashCode * 59 + this.MonitorCycle.GetHashCode();
                if (this.SilenceCycle != null) hashCode = hashCode * 59 + this.SilenceCycle.GetHashCode();
                if (this.EnlargeThreshold != null) hashCode = hashCode * 59 + this.EnlargeThreshold.GetHashCode();
                if (this.MaxFlavor != null) hashCode = hashCode * 59 + this.MaxFlavor.GetHashCode();
                if (this.ReduceEnabled != null) hashCode = hashCode * 59 + this.ReduceEnabled.GetHashCode();
                if (this.MinFlavor != null) hashCode = hashCode * 59 + this.MinFlavor.GetHashCode();
                if (this.SilenceStartAt != null) hashCode = hashCode * 59 + this.SilenceStartAt.GetHashCode();
                if (this.ScalingStrategy != null) hashCode = hashCode * 59 + this.ScalingStrategy.GetHashCode();
                if (this.MaxReadOnlyCount != null) hashCode = hashCode * 59 + this.MaxReadOnlyCount.GetHashCode();
                if (this.MinReadOnlyCount != null) hashCode = hashCode * 59 + this.MinReadOnlyCount.GetHashCode();
                if (this.ReadOnlyWeight != null) hashCode = hashCode * 59 + this.ReadOnlyWeight.GetHashCode();
                return hashCode;
            }
        }
    }
}
