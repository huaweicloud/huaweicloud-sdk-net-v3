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
    /// 工作流包订阅信息。
    /// </summary>
    public class WorkflowServicePackage 
    {

        /// <summary>
        /// 服务包状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 资源池ID。
        /// </summary>
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// 在线服务ID。
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Workflow工作流ID。
        /// </summary>
        [JsonProperty("workflow_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public WorkflowPoolOrder Order { get; set; }

        /// <summary>
        /// 消费限制。
        /// </summary>
        [JsonProperty("consume_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConsumeLimit { get; set; }

        /// <summary>
        /// 当前消费。
        /// </summary>
        [JsonProperty("current_consume", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentConsume { get; set; }

        /// <summary>
        /// 当前时间。
        /// </summary>
        [JsonProperty("current_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentDate { get; set; }

        /// <summary>
        /// 限制开关。
        /// </summary>
        [JsonProperty("limit_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LimitEnable { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 订阅包的UUID。创建时不需要填，由后台自动生成。
        /// </summary>
        [JsonProperty("package_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowServicePackage {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  workflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  consumeLimit: ").Append(ConsumeLimit).Append("\n");
            sb.Append("  currentConsume: ").Append(CurrentConsume).Append("\n");
            sb.Append("  currentDate: ").Append(CurrentDate).Append("\n");
            sb.Append("  limitEnable: ").Append(LimitEnable).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  packageId: ").Append(PackageId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowServicePackage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowServicePackage input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.ServiceId != input.ServiceId || (this.ServiceId != null && !this.ServiceId.Equals(input.ServiceId))) return false;
            if (this.WorkflowId != input.WorkflowId || (this.WorkflowId != null && !this.WorkflowId.Equals(input.WorkflowId))) return false;
            if (this.Order != input.Order || (this.Order != null && !this.Order.Equals(input.Order))) return false;
            if (this.ConsumeLimit != input.ConsumeLimit || (this.ConsumeLimit != null && !this.ConsumeLimit.Equals(input.ConsumeLimit))) return false;
            if (this.CurrentConsume != input.CurrentConsume || (this.CurrentConsume != null && !this.CurrentConsume.Equals(input.CurrentConsume))) return false;
            if (this.CurrentDate != input.CurrentDate || (this.CurrentDate != null && !this.CurrentDate.Equals(input.CurrentDate))) return false;
            if (this.LimitEnable != input.LimitEnable || (this.LimitEnable != null && !this.LimitEnable.Equals(input.LimitEnable))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.PackageId != input.PackageId || (this.PackageId != null && !this.PackageId.Equals(input.PackageId))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.ServiceId != null) hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.WorkflowId != null) hashCode = hashCode * 59 + this.WorkflowId.GetHashCode();
                if (this.Order != null) hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.ConsumeLimit != null) hashCode = hashCode * 59 + this.ConsumeLimit.GetHashCode();
                if (this.CurrentConsume != null) hashCode = hashCode * 59 + this.CurrentConsume.GetHashCode();
                if (this.CurrentDate != null) hashCode = hashCode * 59 + this.CurrentDate.GetHashCode();
                if (this.LimitEnable != null) hashCode = hashCode * 59 + this.LimitEnable.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.PackageId != null) hashCode = hashCode * 59 + this.PackageId.GetHashCode();
                return hashCode;
            }
        }
    }
}
