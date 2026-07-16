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
    /// 
    /// </summary>
    public class ServicePodResponse 
    {

        /// <summary>
        /// **参数解释：** od ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("pod_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PodId { get; set; }

        /// <summary>
        /// **参数解释：** pod名字。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("pod_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PodName { get; set; }

        /// <summary>
        /// **参数解释：** pod所在node的IP。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("pod_node_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PodNodeIp { get; set; }

        /// <summary>
        /// **参数解释：** pod所在node的名字。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("pod_node_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PodNodeName { get; set; }

        /// <summary>
        /// **参数解释：** pod角色。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("pod_role", NullValueHandling = NullValueHandling.Ignore)]
        public string PodRole { get; set; }

        /// <summary>
        /// **参数解释：** pod服务状态。 **取值范围：** 有7种状态。RUNNING（运行中）、PENDING（未就绪）、SUCCEEDED（成功）、FAILED（失败）、ABNORMAL（异常）、UNKNOWN（未知）、DELETED（已删除）。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** 最近更新时间。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServicePodResponse {\n");
            sb.Append("  podId: ").Append(PodId).Append("\n");
            sb.Append("  podName: ").Append(PodName).Append("\n");
            sb.Append("  podNodeIp: ").Append(PodNodeIp).Append("\n");
            sb.Append("  podNodeName: ").Append(PodNodeName).Append("\n");
            sb.Append("  podRole: ").Append(PodRole).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServicePodResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServicePodResponse input)
        {
            if (input == null) return false;
            if (this.PodId != input.PodId || (this.PodId != null && !this.PodId.Equals(input.PodId))) return false;
            if (this.PodName != input.PodName || (this.PodName != null && !this.PodName.Equals(input.PodName))) return false;
            if (this.PodNodeIp != input.PodNodeIp || (this.PodNodeIp != null && !this.PodNodeIp.Equals(input.PodNodeIp))) return false;
            if (this.PodNodeName != input.PodNodeName || (this.PodNodeName != null && !this.PodNodeName.Equals(input.PodNodeName))) return false;
            if (this.PodRole != input.PodRole || (this.PodRole != null && !this.PodRole.Equals(input.PodRole))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.PodId != null) hashCode = hashCode * 59 + this.PodId.GetHashCode();
                if (this.PodName != null) hashCode = hashCode * 59 + this.PodName.GetHashCode();
                if (this.PodNodeIp != null) hashCode = hashCode * 59 + this.PodNodeIp.GetHashCode();
                if (this.PodNodeName != null) hashCode = hashCode * 59 + this.PodNodeName.GetHashCode();
                if (this.PodRole != null) hashCode = hashCode * 59 + this.PodRole.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
