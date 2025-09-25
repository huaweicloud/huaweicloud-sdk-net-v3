using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListMergeRequestReviewersResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 必选检视人列表。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("required_reviewers_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserBasicDto> RequiredReviewersList { get; set; }

        /// <summary>
        /// **参数解释：** 可选检视人列表。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("optional_reviewers_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserBasicDto> OptionalReviewersList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Total", IsHeader = true)]
        [JsonProperty("X-Total", NullValueHandling = NullValueHandling.Ignore)]
        public string XTotal { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMergeRequestReviewersResponse {\n");
            sb.Append("  requiredReviewersList: ").Append(RequiredReviewersList).Append("\n");
            sb.Append("  optionalReviewersList: ").Append(OptionalReviewersList).Append("\n");
            sb.Append("  xTotal: ").Append(XTotal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMergeRequestReviewersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMergeRequestReviewersResponse input)
        {
            if (input == null) return false;
            if (this.RequiredReviewersList != input.RequiredReviewersList || (this.RequiredReviewersList != null && input.RequiredReviewersList != null && !this.RequiredReviewersList.SequenceEqual(input.RequiredReviewersList))) return false;
            if (this.OptionalReviewersList != input.OptionalReviewersList || (this.OptionalReviewersList != null && input.OptionalReviewersList != null && !this.OptionalReviewersList.SequenceEqual(input.OptionalReviewersList))) return false;
            if (this.XTotal != input.XTotal || (this.XTotal != null && !this.XTotal.Equals(input.XTotal))) return false;

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
                if (this.RequiredReviewersList != null) hashCode = hashCode * 59 + this.RequiredReviewersList.GetHashCode();
                if (this.OptionalReviewersList != null) hashCode = hashCode * 59 + this.OptionalReviewersList.GetHashCode();
                if (this.XTotal != null) hashCode = hashCode * 59 + this.XTotal.GetHashCode();
                return hashCode;
            }
        }
    }
}
