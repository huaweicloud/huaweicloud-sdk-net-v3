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
    /// Response Object
    /// </summary>
    public class ListMergeRequestApproversResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 必选审核人列表。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("required_approvers_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserBasicDto> RequiredApproversList { get; set; }

        /// <summary>
        /// **参数解释：** 可选审核人列表。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("optional_approvers_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserBasicDto> OptionalApproversList { get; set; }

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
            sb.Append("class ListMergeRequestApproversResponse {\n");
            sb.Append("  requiredApproversList: ").Append(RequiredApproversList).Append("\n");
            sb.Append("  optionalApproversList: ").Append(OptionalApproversList).Append("\n");
            sb.Append("  xTotal: ").Append(XTotal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMergeRequestApproversResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMergeRequestApproversResponse input)
        {
            if (input == null) return false;
            if (this.RequiredApproversList != input.RequiredApproversList || (this.RequiredApproversList != null && input.RequiredApproversList != null && !this.RequiredApproversList.SequenceEqual(input.RequiredApproversList))) return false;
            if (this.OptionalApproversList != input.OptionalApproversList || (this.OptionalApproversList != null && input.OptionalApproversList != null && !this.OptionalApproversList.SequenceEqual(input.OptionalApproversList))) return false;
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
                if (this.RequiredApproversList != null) hashCode = hashCode * 59 + this.RequiredApproversList.GetHashCode();
                if (this.OptionalApproversList != null) hashCode = hashCode * 59 + this.OptionalApproversList.GetHashCode();
                if (this.XTotal != null) hashCode = hashCode * 59 + this.XTotal.GetHashCode();
                return hashCode;
            }
        }
    }
}
