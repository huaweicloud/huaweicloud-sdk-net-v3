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
    /// 作业详细信息。
    /// </summary>
    public class Workload 
    {

        /// <summary>
        /// **参数解释**：资源的API版本。 **取值范围**：可选值如下： - v1：当前资源版本为v1
        /// </summary>
        [JsonProperty("apiVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// **参数解释**：资源的类型。 **取值范围**：可选值如下： - Workload：资源池作业
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// **参数解释**：资源池中作业的业务类型。 **取值范围**：可选值如下： - train：训练作业 - infer：推理服务 - notebook：Notebook作业 - x-infer：新版推理作业
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**：集群中作业所属的命名空间。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// **参数解释**：作业的名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：作业的归属的上层业务的名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("jobName", NullValueHandling = NullValueHandling.Ignore)]
        public string JobName { get; set; }

        /// <summary>
        /// **参数解释**：作业的ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// **参数解释**：作业的归属的上层业务的ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("jobUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string JobUUID { get; set; }

        /// <summary>
        /// **参数解释**：作业的资源规格。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// **参数解释**：作业状态。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resourceRequirement", NullValueHandling = NullValueHandling.Ignore)]
        public WorkloadResourceRequirement ResourceRequirement { get; set; }

        /// <summary>
        /// **参数解释**：作业的优先级。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public string Priority { get; set; }

        /// <summary>
        /// **参数解释**：作业的运行时长，以秒为单位。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("runningDuration", NullValueHandling = NullValueHandling.Ignore)]
        public int? RunningDuration { get; set; }

        /// <summary>
        /// **参数解释**：作业的排队时长，以秒为单位。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("pendingDuration", NullValueHandling = NullValueHandling.Ignore)]
        public int? PendingDuration { get; set; }

        /// <summary>
        /// **参数解释**：作业当前的排队位置。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("pendingPosition", NullValueHandling = NullValueHandling.Ignore)]
        public int? PendingPosition { get; set; }

        /// <summary>
        /// **参数解释**：作业的Unix创建时间戳，以毫秒为单位。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("createTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreateTime { get; set; }

        /// <summary>
        /// **参数解释**：作业的k8s资源类型、分组和版本。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("gvk", NullValueHandling = NullValueHandling.Ignore)]
        public string Gvk { get; set; }

        /// <summary>
        /// **参数解释**：作业运行的节点IP列表，以“,”分隔。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("hostIps", NullValueHandling = NullValueHandling.Ignore)]
        public string HostIps { get; set; }

        /// <summary>
        /// **参数解释**：作业运行时占用的节点资源信息。
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkloadNodeVO> Nodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Workload {\n");
            sb.Append("  apiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  kind: ").Append(Kind).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  jobName: ").Append(JobName).Append("\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  jobUUID: ").Append(JobUUID).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  resourceRequirement: ").Append(ResourceRequirement).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  runningDuration: ").Append(RunningDuration).Append("\n");
            sb.Append("  pendingDuration: ").Append(PendingDuration).Append("\n");
            sb.Append("  pendingPosition: ").Append(PendingPosition).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  gvk: ").Append(Gvk).Append("\n");
            sb.Append("  hostIps: ").Append(HostIps).Append("\n");
            sb.Append("  nodes: ").Append(Nodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Workload);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Workload input)
        {
            if (input == null) return false;
            if (this.ApiVersion != input.ApiVersion || (this.ApiVersion != null && !this.ApiVersion.Equals(input.ApiVersion))) return false;
            if (this.Kind != input.Kind || (this.Kind != null && !this.Kind.Equals(input.Kind))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.JobName != input.JobName || (this.JobName != null && !this.JobName.Equals(input.JobName))) return false;
            if (this.Uid != input.Uid || (this.Uid != null && !this.Uid.Equals(input.Uid))) return false;
            if (this.JobUUID != input.JobUUID || (this.JobUUID != null && !this.JobUUID.Equals(input.JobUUID))) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ResourceRequirement != input.ResourceRequirement || (this.ResourceRequirement != null && !this.ResourceRequirement.Equals(input.ResourceRequirement))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.RunningDuration != input.RunningDuration || (this.RunningDuration != null && !this.RunningDuration.Equals(input.RunningDuration))) return false;
            if (this.PendingDuration != input.PendingDuration || (this.PendingDuration != null && !this.PendingDuration.Equals(input.PendingDuration))) return false;
            if (this.PendingPosition != input.PendingPosition || (this.PendingPosition != null && !this.PendingPosition.Equals(input.PendingPosition))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.Gvk != input.Gvk || (this.Gvk != null && !this.Gvk.Equals(input.Gvk))) return false;
            if (this.HostIps != input.HostIps || (this.HostIps != null && !this.HostIps.Equals(input.HostIps))) return false;
            if (this.Nodes != input.Nodes || (this.Nodes != null && input.Nodes != null && !this.Nodes.SequenceEqual(input.Nodes))) return false;

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
                if (this.ApiVersion != null) hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Kind != null) hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.JobName != null) hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.Uid != null) hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.JobUUID != null) hashCode = hashCode * 59 + this.JobUUID.GetHashCode();
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ResourceRequirement != null) hashCode = hashCode * 59 + this.ResourceRequirement.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.RunningDuration != null) hashCode = hashCode * 59 + this.RunningDuration.GetHashCode();
                if (this.PendingDuration != null) hashCode = hashCode * 59 + this.PendingDuration.GetHashCode();
                if (this.PendingPosition != null) hashCode = hashCode * 59 + this.PendingPosition.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Gvk != null) hashCode = hashCode * 59 + this.Gvk.GetHashCode();
                if (this.HostIps != null) hashCode = hashCode * 59 + this.HostIps.GetHashCode();
                if (this.Nodes != null) hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
