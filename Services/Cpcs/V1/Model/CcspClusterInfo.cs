using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CcspClusterInfo 
    {

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 账号ID
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 任务详情
        /// </summary>
        [JsonProperty("task_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<Object> TaskDetails { get; set; }

        /// <summary>
        /// ccsp集群id
        /// </summary>
        [JsonProperty("ccsp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CcspId { get; set; }

        /// <summary>
        /// 分布类型
        /// </summary>
        [JsonProperty("distributed_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DistributedType { get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("cluster_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterName { get; set; }

        /// <summary>
        /// 集群所属的服务
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// 集群的类型： - **SHARED** : 应用共享； - **EXCLUSIVE** : 应用独享
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 集群中包含的服务实例数量
        /// </summary>
        [JsonProperty("instance_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceNum { get; set; }

        /// <summary>
        /// 集群状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 进度信息
        /// </summary>
        [JsonProperty("progress_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ProgressInfo { get; set; }

        /// <summary>
        /// 集群使用VSM集群的vsm实例数量
        /// </summary>
        [JsonProperty("vsm_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? VsmNum { get; set; }

        /// <summary>
        /// 集群的创建时间，UNIX时间戳，单位毫秒
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 是否共享ccsp
        /// </summary>
        [JsonProperty("shared_ccsp", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SharedCcsp { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// az
        /// </summary>
        [JsonProperty("az", NullValueHandling = NullValueHandling.Ignore)]
        public string Az { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CcspClusterInfo {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  taskDetails: ").Append(TaskDetails).Append("\n");
            sb.Append("  ccspId: ").Append(CcspId).Append("\n");
            sb.Append("  distributedType: ").Append(DistributedType).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  clusterName: ").Append(ClusterName).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  instanceNum: ").Append(InstanceNum).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  progressInfo: ").Append(ProgressInfo).Append("\n");
            sb.Append("  vsmNum: ").Append(VsmNum).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  sharedCcsp: ").Append(SharedCcsp).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  az: ").Append(Az).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CcspClusterInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CcspClusterInfo input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.TaskDetails != input.TaskDetails || (this.TaskDetails != null && input.TaskDetails != null && !this.TaskDetails.SequenceEqual(input.TaskDetails))) return false;
            if (this.CcspId != input.CcspId || (this.CcspId != null && !this.CcspId.Equals(input.CcspId))) return false;
            if (this.DistributedType != input.DistributedType || (this.DistributedType != null && !this.DistributedType.Equals(input.DistributedType))) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.ClusterName != input.ClusterName || (this.ClusterName != null && !this.ClusterName.Equals(input.ClusterName))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.InstanceNum != input.InstanceNum || (this.InstanceNum != null && !this.InstanceNum.Equals(input.InstanceNum))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ProgressInfo != input.ProgressInfo || (this.ProgressInfo != null && !this.ProgressInfo.Equals(input.ProgressInfo))) return false;
            if (this.VsmNum != input.VsmNum || (this.VsmNum != null && !this.VsmNum.Equals(input.VsmNum))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.SharedCcsp != input.SharedCcsp || (this.SharedCcsp != null && !this.SharedCcsp.Equals(input.SharedCcsp))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Az != input.Az || (this.Az != null && !this.Az.Equals(input.Az))) return false;

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
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.TaskDetails != null) hashCode = hashCode * 59 + this.TaskDetails.GetHashCode();
                if (this.CcspId != null) hashCode = hashCode * 59 + this.CcspId.GetHashCode();
                if (this.DistributedType != null) hashCode = hashCode * 59 + this.DistributedType.GetHashCode();
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterName != null) hashCode = hashCode * 59 + this.ClusterName.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.InstanceNum != null) hashCode = hashCode * 59 + this.InstanceNum.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ProgressInfo != null) hashCode = hashCode * 59 + this.ProgressInfo.GetHashCode();
                if (this.VsmNum != null) hashCode = hashCode * 59 + this.VsmNum.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.SharedCcsp != null) hashCode = hashCode * 59 + this.SharedCcsp.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Az != null) hashCode = hashCode * 59 + this.Az.GetHashCode();
                return hashCode;
            }
        }
    }
}
