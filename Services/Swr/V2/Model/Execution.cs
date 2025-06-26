using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Execution 
    {

        /// <summary>
        /// 记录ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 策略ID
        /// </summary>
        [JsonProperty("policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicyId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 状态详情
        /// </summary>
        [JsonProperty("status_text", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusText { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 失败数
        /// </summary>
        [JsonProperty("failed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Failed { get; set; }

        /// <summary>
        /// 成功数
        /// </summary>
        [JsonProperty("succeed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Succeed { get; set; }

        /// <summary>
        /// 进行中的数量
        /// </summary>
        [JsonProperty("in_progress", NullValueHandling = NullValueHandling.Ignore)]
        public int? InProgress { get; set; }

        /// <summary>
        /// 停止数
        /// </summary>
        [JsonProperty("stopped", NullValueHandling = NullValueHandling.Ignore)]
        public int? Stopped { get; set; }

        /// <summary>
        /// 触发类型
        /// </summary>
        [JsonProperty("trigger", NullValueHandling = NullValueHandling.Ignore)]
        public string Trigger { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Execution {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  policyId: ").Append(PolicyId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  statusText: ").Append(StatusText).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  failed: ").Append(Failed).Append("\n");
            sb.Append("  succeed: ").Append(Succeed).Append("\n");
            sb.Append("  inProgress: ").Append(InProgress).Append("\n");
            sb.Append("  stopped: ").Append(Stopped).Append("\n");
            sb.Append("  trigger: ").Append(Trigger).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Execution);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Execution input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.PolicyId != input.PolicyId || (this.PolicyId != null && !this.PolicyId.Equals(input.PolicyId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.StatusText != input.StatusText || (this.StatusText != null && !this.StatusText.Equals(input.StatusText))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Failed != input.Failed || (this.Failed != null && !this.Failed.Equals(input.Failed))) return false;
            if (this.Succeed != input.Succeed || (this.Succeed != null && !this.Succeed.Equals(input.Succeed))) return false;
            if (this.InProgress != input.InProgress || (this.InProgress != null && !this.InProgress.Equals(input.InProgress))) return false;
            if (this.Stopped != input.Stopped || (this.Stopped != null && !this.Stopped.Equals(input.Stopped))) return false;
            if (this.Trigger != input.Trigger || (this.Trigger != null && !this.Trigger.Equals(input.Trigger))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                if (this.PolicyId != null) hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusText != null) hashCode = hashCode * 59 + this.StatusText.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Failed != null) hashCode = hashCode * 59 + this.Failed.GetHashCode();
                if (this.Succeed != null) hashCode = hashCode * 59 + this.Succeed.GetHashCode();
                if (this.InProgress != null) hashCode = hashCode * 59 + this.InProgress.GetHashCode();
                if (this.Stopped != null) hashCode = hashCode * 59 + this.Stopped.GetHashCode();
                if (this.Trigger != null) hashCode = hashCode * 59 + this.Trigger.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
