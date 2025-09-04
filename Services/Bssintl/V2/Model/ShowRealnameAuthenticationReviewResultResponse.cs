using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowRealnameAuthenticationReviewResultResponse : SdkResponse
    {

        /// <summary>
        /// 实名认证审核结果，只有状态码为200并且已经提交过实名认证请求才返回： 0：审核中1：不通过2：通过
        /// </summary>
        [JsonProperty("review_result", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReviewResult { get; set; }

        /// <summary>
        /// 审批意见，只有状态码为200并且审核不通过才返回。
        /// </summary>
        [JsonProperty("opinion", NullValueHandling = NullValueHandling.Ignore)]
        public string Opinion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRealnameAuthenticationReviewResultResponse {\n");
            sb.Append("  reviewResult: ").Append(ReviewResult).Append("\n");
            sb.Append("  opinion: ").Append(Opinion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRealnameAuthenticationReviewResultResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRealnameAuthenticationReviewResultResponse input)
        {
            if (input == null) return false;
            if (this.ReviewResult != input.ReviewResult || (this.ReviewResult != null && !this.ReviewResult.Equals(input.ReviewResult))) return false;
            if (this.Opinion != input.Opinion || (this.Opinion != null && !this.Opinion.Equals(input.Opinion))) return false;

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
                if (this.ReviewResult != null) hashCode = hashCode * 59 + this.ReviewResult.GetHashCode();
                if (this.Opinion != null) hashCode = hashCode * 59 + this.Opinion.GetHashCode();
                return hashCode;
            }
        }
    }
}
