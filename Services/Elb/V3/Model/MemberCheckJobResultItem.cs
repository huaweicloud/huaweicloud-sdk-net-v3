using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 参数解释：分组检查项汇总。
    /// </summary>
    public class MemberCheckJobResultItem 
    {

        /// <summary>
        /// 参数解释：检查项名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数解释：异常原因
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// 参数解释：重要级别，分为Major(严重)和Tips(提示)
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public string Severity { get; set; }

        /// <summary>
        /// 参数解释：检查类别，config表示配置检查
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 参数解释：任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 参数解释：异常原因模板
        /// </summary>
        [JsonProperty("reason_template", NullValueHandling = NullValueHandling.Ignore)]
        public string ReasonTemplate { get; set; }

        /// <summary>
        /// 参数解释：异常结果变量参数表，用于结合异常原因模板动态生成异常原因
        /// </summary>
        [JsonProperty("reason_params", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReasonParams { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberCheckJobResultItem {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  reasonTemplate: ").Append(ReasonTemplate).Append("\n");
            sb.Append("  reasonParams: ").Append(ReasonParams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MemberCheckJobResultItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MemberCheckJobResultItem input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;
            if (this.Severity != input.Severity || (this.Severity != null && !this.Severity.Equals(input.Severity))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.ReasonTemplate != input.ReasonTemplate || (this.ReasonTemplate != null && !this.ReasonTemplate.Equals(input.ReasonTemplate))) return false;
            if (this.ReasonParams != input.ReasonParams || (this.ReasonParams != null && input.ReasonParams != null && !this.ReasonParams.SequenceEqual(input.ReasonParams))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Severity != null) hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.ReasonTemplate != null) hashCode = hashCode * 59 + this.ReasonTemplate.GetHashCode();
                if (this.ReasonParams != null) hashCode = hashCode * 59 + this.ReasonParams.GetHashCode();
                return hashCode;
            }
        }
    }
}
