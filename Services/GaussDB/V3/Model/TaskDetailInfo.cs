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
    public class TaskDetailInfo 
    {

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
        /// 任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 订单ID。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 任务名称。取值有：    - \&quot;CreateGaussDBforMySQLInstance\&quot;表示创建实例。    - \&quot;RestoreGaussDBforMySQLNewInstance\&quot;表示恢复新实例。    - \&quot;AddGaussDBforMySQLNodes\&quot;表示添加节点。    - \&quot;DeleteGaussDBforMySQLNode\&quot;表示删除节点。    - \&quot;RebootGaussDBforMySQLInstance\&quot;表示重启实例。    - \&quot;ModifyGaussDBforMySQLPort\&quot;表示修改实例端口。    - \&quot;ModifyGaussDBforMySQLSecurityGroup\&quot;表示修改实例安全组。    - \&quot;ResizeGaussDBforMySQLFlavor\&quot;表示实例规格变更。    - \&quot;SwitchoverGaussDBforMySQLMasterNode\&quot;表示只读升主。    - \&quot;GaussDBforMySQLBindEIP\&quot;表示绑定弹性公网IP。    - \&quot;GaussDBforMySQLUnbindEIP\&quot;表示解绑弹性公网IP。    - \&quot;RenameGaussDBforMySQLInstance\&quot;表示修改实例名称。    - \&quot;DeleteGaussDBforMySQLInstance\&quot;表示删除实例集群。    - \&quot;UpgradeGaussDBforMySQLDatabaseVersion\&quot;表示版本升级。    - \&quot;EnlargeGaussDBforMySQLProxy\&quot;表示实例的数据库代理节点扩容。    - \&quot;OpenGaussDBforMySQLProxy\&quot;表示开启实例的数据库代理。    - \&quot;CloseGaussDBforMySQLProxy\&quot;表示关闭实例的数据库代理。    - \&quot;GaussdbforMySQLModifyProxyIp\&quot;表示修改数据库代理ip。    - \&quot;ScaleGaussDBforMySQLProxy\&quot;表示实例的数据库代理节点规格变更。    - \&quot;GaussDBforMySQLModifyInstanceMetricExtend\&quot;表示实例秒级监控。    - \&quot;GaussDBforMySQLModifyInstanceDataVip\&quot;表示修改实例数据Vip。    - \&quot;GaussDBforMySQLSwitchSSL\&quot;表示切换实例SSL开关。    - \&quot;GaussDBforMySQLModifyProxyConsist\&quot;表示修改代理一致性。    - \&quot;GaussDBforMySQLModifyProxyWeight\&quot;表示修改代理权重。
        /// </summary>
        [JsonProperty("job_name", NullValueHandling = NullValueHandling.Ignore)]
        public string JobName { get; set; }

        /// <summary>
        /// 任务执行状态。 取值： - 值为“Pending”，表示延时任务，未执行。 - 值为“Running”，表示任务正在执行。 - 值为“Completed”，表示任务执行成功。 - 值为“Failed”，表示任务执行失败。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 任务进度。
        /// </summary>
        [JsonProperty("process", NullValueHandling = NullValueHandling.Ignore)]
        public string Process { get; set; }

        /// <summary>
        /// 任务创建时间。格式为\&quot;yyyy-mm-ddThh:mm:ssZ\&quot;。 其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// 任务结束时间。格式为\&quot;yyyy-mm-ddThh:mm:ssZ\&quot;。 其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。
        /// </summary>
        [JsonProperty("ended_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndedTime { get; set; }

        /// <summary>
        /// 任务失败原因。
        /// </summary>
        [JsonProperty("fail_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailReason { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskDetailInfo {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  instanceStatus: ").Append(InstanceStatus).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  jobName: ").Append(JobName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  process: ").Append(Process).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  endedTime: ").Append(EndedTime).Append("\n");
            sb.Append("  failReason: ").Append(FailReason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskDetailInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskDetailInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.InstanceName == input.InstanceName ||
                    (this.InstanceName != null &&
                    this.InstanceName.Equals(input.InstanceName))
                ) && 
                (
                    this.InstanceStatus == input.InstanceStatus ||
                    (this.InstanceStatus != null &&
                    this.InstanceStatus.Equals(input.InstanceStatus))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.JobName == input.JobName ||
                    (this.JobName != null &&
                    this.JobName.Equals(input.JobName))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Process == input.Process ||
                    (this.Process != null &&
                    this.Process.Equals(input.Process))
                ) && 
                (
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.EndedTime == input.EndedTime ||
                    (this.EndedTime != null &&
                    this.EndedTime.Equals(input.EndedTime))
                ) && 
                (
                    this.FailReason == input.FailReason ||
                    (this.FailReason != null &&
                    this.FailReason.Equals(input.FailReason))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceName != null)
                    hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.InstanceStatus != null)
                    hashCode = hashCode * 59 + this.InstanceStatus.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.JobName != null)
                    hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Process != null)
                    hashCode = hashCode * 59 + this.Process.GetHashCode();
                if (this.CreatedTime != null)
                    hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.EndedTime != null)
                    hashCode = hashCode * 59 + this.EndedTime.GetHashCode();
                if (this.FailReason != null)
                    hashCode = hashCode * 59 + this.FailReason.GetHashCode();
                return hashCode;
            }
        }
    }
}
