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
    /// 批量操作返回体。
    /// </summary>
    public class BatchResultVOIssueWithReasonVO 
    {

        /// <summary>
        /// **参数解释**： 批量操作成功条数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("success_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuccessNum { get; set; }

        /// <summary>
        /// **参数解释**： 批量操作失败条数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("fail_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailNum { get; set; }

        /// <summary>
        /// **参数解释**： 批量操作失败数据及失败原因。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("failed", NullValueHandling = NullValueHandling.Ignore)]
        public List<IssueWithReasonVO> Failed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchResultVOIssueWithReasonVO {\n");
            sb.Append("  successNum: ").Append(SuccessNum).Append("\n");
            sb.Append("  failNum: ").Append(FailNum).Append("\n");
            sb.Append("  failed: ").Append(Failed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchResultVOIssueWithReasonVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchResultVOIssueWithReasonVO input)
        {
            if (input == null) return false;
            if (this.SuccessNum != input.SuccessNum || (this.SuccessNum != null && !this.SuccessNum.Equals(input.SuccessNum))) return false;
            if (this.FailNum != input.FailNum || (this.FailNum != null && !this.FailNum.Equals(input.FailNum))) return false;
            if (this.Failed != input.Failed || (this.Failed != null && input.Failed != null && !this.Failed.SequenceEqual(input.Failed))) return false;

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
                if (this.SuccessNum != null) hashCode = hashCode * 59 + this.SuccessNum.GetHashCode();
                if (this.FailNum != null) hashCode = hashCode * 59 + this.FailNum.GetHashCode();
                if (this.Failed != null) hashCode = hashCode * 59 + this.Failed.GetHashCode();
                return hashCode;
            }
        }
    }
}
