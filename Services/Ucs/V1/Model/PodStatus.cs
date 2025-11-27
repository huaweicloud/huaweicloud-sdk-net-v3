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
    /// 用于表示 Pod 状态信息
    /// </summary>
    public class PodStatus 
    {

        /// <summary>
        /// 表示Pod的生命周期状态，有 5 种取值： - Pending：Pod 已被接受但尚未完全就绪 - Running：Pod 已绑定到节点且至少有一个容器在运行 - Succeeded：Pod 中所有容器都已成功终止，且不会被重启 - Failed：Pod 中至少一个容器失败终止 - Unknown：无法获取 Pod 状态
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }

        /// <summary>
        /// Pod所在主机的IP地址
        /// </summary>
        [JsonProperty("hostIP", NullValueHandling = NullValueHandling.Ignore)]
        public string HostIP { get; set; }

        /// <summary>
        /// 记录Pod被Kubelet认可的时间
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 容器的状态列表
        /// </summary>
        [JsonProperty("containerStatuses", NullValueHandling = NullValueHandling.Ignore)]
        public List<ContainerStatus> ContainerStatuses { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PodStatus {\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  hostIP: ").Append(HostIP).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  containerStatuses: ").Append(ContainerStatuses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PodStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PodStatus input)
        {
            if (input == null) return false;
            if (this.Phase != input.Phase || (this.Phase != null && !this.Phase.Equals(input.Phase))) return false;
            if (this.HostIP != input.HostIP || (this.HostIP != null && !this.HostIP.Equals(input.HostIP))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.ContainerStatuses != input.ContainerStatuses || (this.ContainerStatuses != null && input.ContainerStatuses != null && !this.ContainerStatuses.SequenceEqual(input.ContainerStatuses))) return false;

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
                if (this.Phase != null) hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.HostIP != null) hashCode = hashCode * 59 + this.HostIP.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.ContainerStatuses != null) hashCode = hashCode * 59 + this.ContainerStatuses.GetHashCode();
                return hashCode;
            }
        }
    }
}
