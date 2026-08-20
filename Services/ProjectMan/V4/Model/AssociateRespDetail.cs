using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AssociateRespDetail 
    {

        /// <summary>
        /// 关联的工作项ID，多个ID使用逗号分割。
        /// </summary>
        [JsonProperty("issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueId { get; set; }

        /// <summary>
        /// 失败原因。
        /// </summary>
        [JsonProperty("fail_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string FailMsg { get; set; }

        /// <summary>
        /// 操作类型标记位。
        /// </summary>
        [JsonProperty("operation_flag", NullValueHandling = NullValueHandling.Ignore)]
        public int? OperationFlag { get; set; }

        /// <summary>
        /// 修改日期。
        /// </summary>
        [JsonProperty("modified_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? ModifiedDate { get; set; }

        /// <summary>
        /// 修改人。
        /// </summary>
        [JsonProperty("modified_by", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedBy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateRespDetail {\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  failMsg: ").Append(FailMsg).Append("\n");
            sb.Append("  operationFlag: ").Append(OperationFlag).Append("\n");
            sb.Append("  modifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  modifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateRespDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateRespDetail input)
        {
            if (input == null) return false;
            if (this.IssueId != input.IssueId || (this.IssueId != null && !this.IssueId.Equals(input.IssueId))) return false;
            if (this.FailMsg != input.FailMsg || (this.FailMsg != null && !this.FailMsg.Equals(input.FailMsg))) return false;
            if (this.OperationFlag != input.OperationFlag || (this.OperationFlag != null && !this.OperationFlag.Equals(input.OperationFlag))) return false;
            if (this.ModifiedDate != input.ModifiedDate || (this.ModifiedDate != null && !this.ModifiedDate.Equals(input.ModifiedDate))) return false;
            if (this.ModifiedBy != input.ModifiedBy || (this.ModifiedBy != null && !this.ModifiedBy.Equals(input.ModifiedBy))) return false;

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
                if (this.IssueId != null) hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.FailMsg != null) hashCode = hashCode * 59 + this.FailMsg.GetHashCode();
                if (this.OperationFlag != null) hashCode = hashCode * 59 + this.OperationFlag.GetHashCode();
                if (this.ModifiedDate != null) hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.ModifiedBy != null) hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                return hashCode;
            }
        }
    }
}
