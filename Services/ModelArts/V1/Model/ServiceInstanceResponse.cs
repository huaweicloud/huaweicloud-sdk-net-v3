using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 服务实例列表。
    /// </summary>
    public class ServiceInstanceResponse 
    {

        /// <summary>
        /// **参数解释：** 服务实例名字。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// **参数解释：** 服务实例状态。 **取值范围：** - RUNNING：运行中 - PENDING：未就绪 - CONCERNING：告警 - FAILED：失败 - UNKNOWN：未知 - DELETED：已删除
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** 服务实例权重。 **取值范围：** [0, 100] 或者为空。
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }

        /// <summary>
        /// **参数解释：** 服务实例pod数量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("pod_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? PodCount { get; set; }

        /// <summary>
        /// **参数解释：** 服务实例运行中pod数量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("running_pod_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? RunningPodCount { get; set; }

        /// <summary>
        /// **参数解释：** 服务实例最近更新时间。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceInstanceResponse {\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("  podCount: ").Append(PodCount).Append("\n");
            sb.Append("  runningPodCount: ").Append(RunningPodCount).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceInstanceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceInstanceResponse input)
        {
            if (input == null) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Weight != input.Weight || (this.Weight != null && !this.Weight.Equals(input.Weight))) return false;
            if (this.PodCount != input.PodCount || (this.PodCount != null && !this.PodCount.Equals(input.PodCount))) return false;
            if (this.RunningPodCount != input.RunningPodCount || (this.RunningPodCount != null && !this.RunningPodCount.Equals(input.RunningPodCount))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;

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
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Weight != null) hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.PodCount != null) hashCode = hashCode * 59 + this.PodCount.GetHashCode();
                if (this.RunningPodCount != null) hashCode = hashCode * 59 + this.RunningPodCount.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
