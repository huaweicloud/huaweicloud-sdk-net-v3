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
    /// 
    /// </summary>
    public class ScheduleTask 
    {

        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

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
        /// 实例状态。 取值： - 值为“createfail”，表示实例创建失败。 - 值为“creating”，表示实例创建中。 - 值为“normal”，表示实例正常。 - 值为“abnormal”，表示实例异常。 - 值为“deleted”，表示实例已删除。
        /// </summary>
        [JsonProperty("instance_status", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// 租户在某一region下的project ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 任务名称。取值有：    - \&quot;CreateGaussDBforMySQLInstance\&quot;表示创建实例。    - \&quot;RestoreGaussDBforMySQLNewInstance\&quot;表示恢复新实例。    - \&quot;AddGaussDBforMySQLNodes\&quot;表示添加节点。    - \&quot;DeleteGaussDBforMySQLNode\&quot;表示删除节点。    - \&quot;RebootGaussDBforMySQLInstance\&quot;表示重启实例。    - \&quot;ModifyGaussDBforMySQLPort\&quot;表示修改实例端口。    - \&quot;ModifyGaussDBforMySQLSecurityGroup\&quot;表示修改实例安全组。    - \&quot;ResizeGaussDBforMySQLFlavor\&quot;表示实例规格变更。    - \&quot;SwitchoverGaussDBforMySQLMasterNode\&quot;表示只读升主。    - \&quot;GaussDBforMySQLBindEIP\&quot;表示绑定弹性公网IP。    - \&quot;GaussDBforMySQLUnbindEIP\&quot;表示解绑弹性公网IP。    - \&quot;RenameGaussDBforMySQLInstance\&quot;表示修改实例名称。    - \&quot;DeleteGaussDBforMySQLInstance\&quot;表示删除实例集群。    - \&quot;UpgradeGaussDBforMySQLDatabaseVersion\&quot;表示版本升级。    - \&quot;EnlargeGaussDBforMySQLProxy\&quot;表示实例的数据库代理节点扩容。    - \&quot;ReduceGaussDBforMySQLProxy\&quot;表示实例的数据库代理节点缩容。    - \&quot;OpenGaussDBforMySQLProxy\&quot;表示开启实例的数据库代理。    - \&quot;CloseGaussDBforMySQLProxy\&quot;表示关闭实例的数据库代理。    - \&quot;GaussdbforMySQLModifyProxyIp\&quot;表示修改数据库代理ip。    - \&quot;ScaleGaussDBforMySQLProxy\&quot;表示实例的数据库代理节点规格变更。    - \&quot;GaussDBforMySQLModifyInstanceMetricExtend\&quot;表示实例秒级监控。    - \&quot;GaussDBforMySQLModifyInstanceDataVip\&quot;表示修改实例数据Vip。    - \&quot;GaussDBforMySQLSwitchSSL\&quot;表示切换实例SSL开关。    - \&quot;GaussDBforMySQLModifyProxyConsist\&quot;表示修改代理一致性。    - \&quot;GaussDBforMySQLModifyProxyWeight\&quot;表示修改代理权重。
        /// </summary>
        [JsonProperty("job_name", NullValueHandling = NullValueHandling.Ignore)]
        public string JobName { get; set; }

        /// <summary>
        /// 任务创建时间，格式为\&quot;yyyy-mm-ddThh:mm:ssZ\&quot;。 其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。 说明：创建时返回值为空，数据库实例创建成功后该值不为空
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 任务开始时间，格式为\&quot;yyyy-mm-ddThh:mm:ssZ\&quot;。 其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。 说明：创建时返回值为空，数据库实例创建成功后该值不为空
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 任务结束时间，格式为\&quot;yyyy-mm-ddThh:mm:ssZ\&quot;。 其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。 说明：创建时返回值为空，数据库实例创建成功后该值不为空
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 任务执行状态。 取值： - 值为“Pending”，表示延时任务，未执行。 - 值为“Running”，表示任务正在执行。 - 值为“Completed”，表示任务执行成功。 - 值为“Failed”，表示任务执行失败。
        /// </summary>
        [JsonProperty("job_status", NullValueHandling = NullValueHandling.Ignore)]
        public string JobStatus { get; set; }

        /// <summary>
        /// 数据库类型。
        /// </summary>
        [JsonProperty("datastore_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DatastoreType { get; set; }

        /// <summary>
        /// 实例配置相关信息，比如规格等。
        /// </summary>
        [JsonProperty("target_config", NullValueHandling = NullValueHandling.Ignore)]
        public Object TargetConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleTask {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  instanceStatus: ").Append(InstanceStatus).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  jobName: ").Append(JobName).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  jobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  datastoreType: ").Append(DatastoreType).Append("\n");
            sb.Append("  targetConfig: ").Append(TargetConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduleTask);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScheduleTask input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.InstanceStatus != input.InstanceStatus || (this.InstanceStatus != null && !this.InstanceStatus.Equals(input.InstanceStatus))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.JobName != input.JobName || (this.JobName != null && !this.JobName.Equals(input.JobName))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.JobStatus != input.JobStatus || (this.JobStatus != null && !this.JobStatus.Equals(input.JobStatus))) return false;
            if (this.DatastoreType != input.DatastoreType || (this.DatastoreType != null && !this.DatastoreType.Equals(input.DatastoreType))) return false;
            if (this.TargetConfig != input.TargetConfig || (this.TargetConfig != null && !this.TargetConfig.Equals(input.TargetConfig))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.InstanceStatus != null) hashCode = hashCode * 59 + this.InstanceStatus.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.JobName != null) hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.JobStatus != null) hashCode = hashCode * 59 + this.JobStatus.GetHashCode();
                if (this.DatastoreType != null) hashCode = hashCode * 59 + this.DatastoreType.GetHashCode();
                if (this.TargetConfig != null) hashCode = hashCode * 59 + this.TargetConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
