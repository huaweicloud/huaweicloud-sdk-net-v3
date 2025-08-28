using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 操作日志附加信息
    /// </summary>
    public class OpExternalInfo 
    {

        /// <summary>
        /// 审核详情id列表
        /// </summary>
        [JsonProperty("review_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ReviewIdList { get; set; }

        /// <summary>
        /// 算法侧失败原因
        /// </summary>
        [JsonProperty("algorithm_failure_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string AlgorithmFailureReason { get; set; }

        /// <summary>
        /// 管理员驳回的原因
        /// </summary>
        [JsonProperty("admin_audit_failure_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminAuditFailureReason { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpExternalInfo {\n");
            sb.Append("  reviewIdList: ").Append(ReviewIdList).Append("\n");
            sb.Append("  algorithmFailureReason: ").Append(AlgorithmFailureReason).Append("\n");
            sb.Append("  adminAuditFailureReason: ").Append(AdminAuditFailureReason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpExternalInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpExternalInfo input)
        {
            if (input == null) return false;
            if (this.ReviewIdList != input.ReviewIdList || (this.ReviewIdList != null && input.ReviewIdList != null && !this.ReviewIdList.SequenceEqual(input.ReviewIdList))) return false;
            if (this.AlgorithmFailureReason != input.AlgorithmFailureReason || (this.AlgorithmFailureReason != null && !this.AlgorithmFailureReason.Equals(input.AlgorithmFailureReason))) return false;
            if (this.AdminAuditFailureReason != input.AdminAuditFailureReason || (this.AdminAuditFailureReason != null && !this.AdminAuditFailureReason.Equals(input.AdminAuditFailureReason))) return false;

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
                if (this.ReviewIdList != null) hashCode = hashCode * 59 + this.ReviewIdList.GetHashCode();
                if (this.AlgorithmFailureReason != null) hashCode = hashCode * 59 + this.AlgorithmFailureReason.GetHashCode();
                if (this.AdminAuditFailureReason != null) hashCode = hashCode * 59 + this.AdminAuditFailureReason.GetHashCode();
                return hashCode;
            }
        }
    }
}
