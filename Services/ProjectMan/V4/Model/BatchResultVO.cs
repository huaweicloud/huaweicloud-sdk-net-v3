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
    /// **参数解释**： 批量操作结果数据对象，包含成功数量、失败数量及详细结果列表。 **约束限制**： 不涉及。
    /// </summary>
    public class BatchResultVO 
    {

        /// <summary>
        /// **参数解释**： 批量操作成功的数量。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("success_num", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? SuccessNum { get; set; }

        /// <summary>
        /// **参数解释**： 批量操作失败的数量。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("fail_num", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FailNum { get; set; }

        /// <summary>
        /// **参数解释**： 批量操作成功的计划列表。
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchOperateInfo> Success { get; set; }

        /// <summary>
        /// **参数解释**： 批量操作失败的计划列表。
        /// </summary>
        [JsonProperty("failed", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchOperateInfo> Failed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchResultVO {\n");
            sb.Append("  successNum: ").Append(SuccessNum).Append("\n");
            sb.Append("  failNum: ").Append(FailNum).Append("\n");
            sb.Append("  success: ").Append(Success).Append("\n");
            sb.Append("  failed: ").Append(Failed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchResultVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchResultVO input)
        {
            if (input == null) return false;
            if (this.SuccessNum != input.SuccessNum || (this.SuccessNum != null && !this.SuccessNum.Equals(input.SuccessNum))) return false;
            if (this.FailNum != input.FailNum || (this.FailNum != null && !this.FailNum.Equals(input.FailNum))) return false;
            if (this.Success != input.Success || (this.Success != null && input.Success != null && !this.Success.SequenceEqual(input.Success))) return false;
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
                if (this.Success != null) hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Failed != null) hashCode = hashCode * 59 + this.Failed.GetHashCode();
                return hashCode;
            }
        }
    }
}
