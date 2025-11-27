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
    /// PodSpec 是 Kubernetes 中描述 Pod 的核心数据结构
    /// </summary>
    public class PodSpec 
    {

        /// <summary>
        /// 定义 Pod 可以挂载的存储卷列表
        /// </summary>
        [JsonProperty("volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Object> Volumes { get; set; }

        /// <summary>
        /// Pod中的主要容器列表
        /// </summary>
        [JsonProperty("containers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Object> Containers { get; set; }

        /// <summary>
        /// 容器失败后的重启策略
        /// </summary>
        [JsonProperty("restartPolicy", NullValueHandling = NullValueHandling.Ignore)]
        public string RestartPolicy { get; set; }

        /// <summary>
        /// 容器终止前的优雅退出时间
        /// </summary>
        [JsonProperty("terminationGracePeriodSeconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? TerminationGracePeriodSeconds { get; set; }

        /// <summary>
        /// Pod在节点上的最大存活时间
        /// </summary>
        [JsonProperty("activeDeadlineSeconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActiveDeadlineSeconds { get; set; }

        /// <summary>
        /// DNS策略
        /// </summary>
        [JsonProperty("dnsPolicy", NullValueHandling = NullValueHandling.Ignore)]
        public string DnsPolicy { get; set; }

        /// <summary>
        /// 节点选择器，用于指定Pod可以调度到哪些节点
        /// </summary>
        [JsonProperty("nodeSelector", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> NodeSelector { get; set; }

        /// <summary>
        /// 运行此Pod所使用的ServiceAccount名称
        /// </summary>
        [JsonProperty("serviceAccountName", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceAccountName { get; set; }

        /// <summary>
        /// 提供向后兼容的旧版ServiceAccount字段
        /// </summary>
        [JsonProperty("serviceAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceAccount { get; set; }

        /// <summary>
        /// 是否自动挂载ServiceAccount的令牌
        /// </summary>
        [JsonProperty("automountServiceAccountToken", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutomountServiceAccountToken { get; set; }

        /// <summary>
        /// 指定Pod应该调度到的节点
        /// </summary>
        [JsonProperty("nodeName", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeName { get; set; }

        /// <summary>
        /// Pod级别的安全上下文
        /// </summary>
        [JsonProperty("securityContext", NullValueHandling = NullValueHandling.Ignore)]
        public Object SecurityContext { get; set; }

        /// <summary>
        /// 指定使用的调度器
        /// </summary>
        [JsonProperty("schedulerName", NullValueHandling = NullValueHandling.Ignore)]
        public string SchedulerName { get; set; }

        /// <summary>
        /// 容器容忍的污点列表
        /// </summary>
        [JsonProperty("tolerations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Toleration> Tolerations { get; set; }

        /// <summary>
        /// Pod 的优先级
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 服务信息是否注入到Pod的环境变量中
        /// </summary>
        [JsonProperty("enableServiceLinks", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableServiceLinks { get; set; }

        /// <summary>
        /// 抢占优先级策略
        /// </summary>
        [JsonProperty("preemptionPolicy", NullValueHandling = NullValueHandling.Ignore)]
        public string PreemptionPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PodSpec {\n");
            sb.Append("  volumes: ").Append(Volumes).Append("\n");
            sb.Append("  containers: ").Append(Containers).Append("\n");
            sb.Append("  restartPolicy: ").Append(RestartPolicy).Append("\n");
            sb.Append("  terminationGracePeriodSeconds: ").Append(TerminationGracePeriodSeconds).Append("\n");
            sb.Append("  activeDeadlineSeconds: ").Append(ActiveDeadlineSeconds).Append("\n");
            sb.Append("  dnsPolicy: ").Append(DnsPolicy).Append("\n");
            sb.Append("  nodeSelector: ").Append(NodeSelector).Append("\n");
            sb.Append("  serviceAccountName: ").Append(ServiceAccountName).Append("\n");
            sb.Append("  serviceAccount: ").Append(ServiceAccount).Append("\n");
            sb.Append("  automountServiceAccountToken: ").Append(AutomountServiceAccountToken).Append("\n");
            sb.Append("  nodeName: ").Append(NodeName).Append("\n");
            sb.Append("  securityContext: ").Append(SecurityContext).Append("\n");
            sb.Append("  schedulerName: ").Append(SchedulerName).Append("\n");
            sb.Append("  tolerations: ").Append(Tolerations).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  enableServiceLinks: ").Append(EnableServiceLinks).Append("\n");
            sb.Append("  preemptionPolicy: ").Append(PreemptionPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PodSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PodSpec input)
        {
            if (input == null) return false;
            if (this.Volumes != input.Volumes || (this.Volumes != null && input.Volumes != null && !this.Volumes.SequenceEqual(input.Volumes))) return false;
            if (this.Containers != input.Containers || (this.Containers != null && input.Containers != null && !this.Containers.SequenceEqual(input.Containers))) return false;
            if (this.RestartPolicy != input.RestartPolicy || (this.RestartPolicy != null && !this.RestartPolicy.Equals(input.RestartPolicy))) return false;
            if (this.TerminationGracePeriodSeconds != input.TerminationGracePeriodSeconds || (this.TerminationGracePeriodSeconds != null && !this.TerminationGracePeriodSeconds.Equals(input.TerminationGracePeriodSeconds))) return false;
            if (this.ActiveDeadlineSeconds != input.ActiveDeadlineSeconds || (this.ActiveDeadlineSeconds != null && !this.ActiveDeadlineSeconds.Equals(input.ActiveDeadlineSeconds))) return false;
            if (this.DnsPolicy != input.DnsPolicy || (this.DnsPolicy != null && !this.DnsPolicy.Equals(input.DnsPolicy))) return false;
            if (this.NodeSelector != input.NodeSelector || (this.NodeSelector != null && input.NodeSelector != null && !this.NodeSelector.SequenceEqual(input.NodeSelector))) return false;
            if (this.ServiceAccountName != input.ServiceAccountName || (this.ServiceAccountName != null && !this.ServiceAccountName.Equals(input.ServiceAccountName))) return false;
            if (this.ServiceAccount != input.ServiceAccount || (this.ServiceAccount != null && !this.ServiceAccount.Equals(input.ServiceAccount))) return false;
            if (this.AutomountServiceAccountToken != input.AutomountServiceAccountToken || (this.AutomountServiceAccountToken != null && !this.AutomountServiceAccountToken.Equals(input.AutomountServiceAccountToken))) return false;
            if (this.NodeName != input.NodeName || (this.NodeName != null && !this.NodeName.Equals(input.NodeName))) return false;
            if (this.SecurityContext != input.SecurityContext || (this.SecurityContext != null && !this.SecurityContext.Equals(input.SecurityContext))) return false;
            if (this.SchedulerName != input.SchedulerName || (this.SchedulerName != null && !this.SchedulerName.Equals(input.SchedulerName))) return false;
            if (this.Tolerations != input.Tolerations || (this.Tolerations != null && input.Tolerations != null && !this.Tolerations.SequenceEqual(input.Tolerations))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.EnableServiceLinks != input.EnableServiceLinks || (this.EnableServiceLinks != null && !this.EnableServiceLinks.Equals(input.EnableServiceLinks))) return false;
            if (this.PreemptionPolicy != input.PreemptionPolicy || (this.PreemptionPolicy != null && !this.PreemptionPolicy.Equals(input.PreemptionPolicy))) return false;

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
                if (this.Volumes != null) hashCode = hashCode * 59 + this.Volumes.GetHashCode();
                if (this.Containers != null) hashCode = hashCode * 59 + this.Containers.GetHashCode();
                if (this.RestartPolicy != null) hashCode = hashCode * 59 + this.RestartPolicy.GetHashCode();
                if (this.TerminationGracePeriodSeconds != null) hashCode = hashCode * 59 + this.TerminationGracePeriodSeconds.GetHashCode();
                if (this.ActiveDeadlineSeconds != null) hashCode = hashCode * 59 + this.ActiveDeadlineSeconds.GetHashCode();
                if (this.DnsPolicy != null) hashCode = hashCode * 59 + this.DnsPolicy.GetHashCode();
                if (this.NodeSelector != null) hashCode = hashCode * 59 + this.NodeSelector.GetHashCode();
                if (this.ServiceAccountName != null) hashCode = hashCode * 59 + this.ServiceAccountName.GetHashCode();
                if (this.ServiceAccount != null) hashCode = hashCode * 59 + this.ServiceAccount.GetHashCode();
                if (this.AutomountServiceAccountToken != null) hashCode = hashCode * 59 + this.AutomountServiceAccountToken.GetHashCode();
                if (this.NodeName != null) hashCode = hashCode * 59 + this.NodeName.GetHashCode();
                if (this.SecurityContext != null) hashCode = hashCode * 59 + this.SecurityContext.GetHashCode();
                if (this.SchedulerName != null) hashCode = hashCode * 59 + this.SchedulerName.GetHashCode();
                if (this.Tolerations != null) hashCode = hashCode * 59 + this.Tolerations.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.EnableServiceLinks != null) hashCode = hashCode * 59 + this.EnableServiceLinks.GetHashCode();
                if (this.PreemptionPolicy != null) hashCode = hashCode * 59 + this.PreemptionPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
