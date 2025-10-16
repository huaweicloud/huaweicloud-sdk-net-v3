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
    public class ShowAuditLogResponseBodyAuditRecords 
    {

        /// <summary>
        /// 日志ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 集群类型
        /// </summary>
        [JsonProperty("cluster_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterType { get; set; }

        /// <summary>
        /// 操作
        /// </summary>
        [JsonProperty("operation", NullValueHandling = NullValueHandling.Ignore)]
        public string Operation { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public long? Time { get; set; }

        /// <summary>
        /// 操作状态
        /// </summary>
        [JsonProperty("operate_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? OperateStatus { get; set; }

        /// <summary>
        /// 操作结果消息
        /// </summary>
        [JsonProperty("operate_message", NullValueHandling = NullValueHandling.Ignore)]
        public string OperateMessage { get; set; }

        /// <summary>
        /// 审计状态
        /// </summary>
        [JsonProperty("audit_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? AuditStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAuditLogResponseBodyAuditRecords {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  clusterType: ").Append(ClusterType).Append("\n");
            sb.Append("  operation: ").Append(Operation).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  operateStatus: ").Append(OperateStatus).Append("\n");
            sb.Append("  operateMessage: ").Append(OperateMessage).Append("\n");
            sb.Append("  auditStatus: ").Append(AuditStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAuditLogResponseBodyAuditRecords);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAuditLogResponseBodyAuditRecords input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.ClusterType != input.ClusterType || (this.ClusterType != null && !this.ClusterType.Equals(input.ClusterType))) return false;
            if (this.Operation != input.Operation || (this.Operation != null && !this.Operation.Equals(input.Operation))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.OperateStatus != input.OperateStatus || (this.OperateStatus != null && !this.OperateStatus.Equals(input.OperateStatus))) return false;
            if (this.OperateMessage != input.OperateMessage || (this.OperateMessage != null && !this.OperateMessage.Equals(input.OperateMessage))) return false;
            if (this.AuditStatus != input.AuditStatus || (this.AuditStatus != null && !this.AuditStatus.Equals(input.AuditStatus))) return false;

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
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ClusterType != null) hashCode = hashCode * 59 + this.ClusterType.GetHashCode();
                if (this.Operation != null) hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.OperateStatus != null) hashCode = hashCode * 59 + this.OperateStatus.GetHashCode();
                if (this.OperateMessage != null) hashCode = hashCode * 59 + this.OperateMessage.GetHashCode();
                if (this.AuditStatus != null) hashCode = hashCode * 59 + this.AuditStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
