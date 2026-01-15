using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class JobBean 
    {

        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 任务状态 - SUCCESS：成功 - RUNNING：运行中 - FAIL：失败 - INIT：初始化 - READY：就绪
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 类型[废弃，未使用]
        /// </summary>
        [JsonProperty("job_type", NullValueHandling = NullValueHandling.Ignore)]
        public string JobType { get; set; }

        /// <summary>
        /// 虚拟机ID
        /// </summary>
        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        /// <summary>
        /// 虚拟机名称
        /// </summary>
        [JsonProperty("server_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerName { get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 计费模式 - Period：包周期计费 - Demand：按需计费
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [JsonProperty("fail_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailReason { get; set; }

        /// <summary>
        /// 防护实例ID,该字段已废弃
        /// </summary>
        [JsonProperty("ha_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HaId { get; set; }

        /// <summary>
        /// 防护实例名称，该字段已废弃
        /// </summary>
        [JsonProperty("ha_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HaName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobBean {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  jobType: ").Append(JobType).Append("\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  serverName: ").Append(ServerName).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  failReason: ").Append(FailReason).Append("\n");
            sb.Append("  haId: ").Append(HaId).Append("\n");
            sb.Append("  haName: ").Append(HaName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobBean);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobBean input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.JobType != input.JobType || (this.JobType != null && !this.JobType.Equals(input.JobType))) return false;
            if (this.ServerId != input.ServerId || (this.ServerId != null && !this.ServerId.Equals(input.ServerId))) return false;
            if (this.ServerName != input.ServerName || (this.ServerName != null && !this.ServerName.Equals(input.ServerName))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.FailReason != input.FailReason || (this.FailReason != null && !this.FailReason.Equals(input.FailReason))) return false;
            if (this.HaId != input.HaId || (this.HaId != null && !this.HaId.Equals(input.HaId))) return false;
            if (this.HaName != input.HaName || (this.HaName != null && !this.HaName.Equals(input.HaName))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.JobType != null) hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.ServerId != null) hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.ServerName != null) hashCode = hashCode * 59 + this.ServerName.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.FailReason != null) hashCode = hashCode * 59 + this.FailReason.GetHashCode();
                if (this.HaId != null) hashCode = hashCode * 59 + this.HaId.GetHashCode();
                if (this.HaName != null) hashCode = hashCode * 59 + this.HaName.GetHashCode();
                return hashCode;
            }
        }
    }
}
