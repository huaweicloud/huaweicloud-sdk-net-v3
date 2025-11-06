using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ApproverParamDto 
    {

        /// <summary>
        /// 审核人id
        /// </summary>
        [JsonProperty("approver_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ApproverId { get; set; }

        /// <summary>
        /// 代码所有者
        /// </summary>
        [JsonProperty("code_owner", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CodeOwner { get; set; }

        /// <summary>
        /// 是否接纳
        /// </summary>
        [JsonProperty("accept", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Accept { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApproverParamDto {\n");
            sb.Append("  approverId: ").Append(ApproverId).Append("\n");
            sb.Append("  codeOwner: ").Append(CodeOwner).Append("\n");
            sb.Append("  accept: ").Append(Accept).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApproverParamDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApproverParamDto input)
        {
            if (input == null) return false;
            if (this.ApproverId != input.ApproverId || (this.ApproverId != null && !this.ApproverId.Equals(input.ApproverId))) return false;
            if (this.CodeOwner != input.CodeOwner || (this.CodeOwner != null && !this.CodeOwner.Equals(input.CodeOwner))) return false;
            if (this.Accept != input.Accept || (this.Accept != null && !this.Accept.Equals(input.Accept))) return false;

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
                if (this.ApproverId != null) hashCode = hashCode * 59 + this.ApproverId.GetHashCode();
                if (this.CodeOwner != null) hashCode = hashCode * 59 + this.CodeOwner.GetHashCode();
                if (this.Accept != null) hashCode = hashCode * 59 + this.Accept.GetHashCode();
                return hashCode;
            }
        }
    }
}
