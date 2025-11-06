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
    public class UpdateGroupGeneralPolicyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 是否禁用fork。
        /// </summary>
        [JsonProperty("disable_fork", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableFork { get; set; }

        /// <summary>
        /// **参数解释：** 分支名称正则表达式。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("branch_name_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchNameRegex { get; set; }

        /// <summary>
        /// **参数解释：** 标签名正则表达式。 **取值范围：** 字符串长度不少于1，不超过1000。
        /// </summary>
        [JsonProperty("tag_name_regex", NullValueHandling = NullValueHandling.Ignore)]
        public string TagNameRegex { get; set; }

        /// <summary>
        /// **参数解释：** 生成合并请求预合并。
        /// </summary>
        [JsonProperty("generate_pre_merge_ref", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GeneratePreMergeRef { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateGroupGeneralPolicyResponse {\n");
            sb.Append("  disableFork: ").Append(DisableFork).Append("\n");
            sb.Append("  branchNameRegex: ").Append(BranchNameRegex).Append("\n");
            sb.Append("  tagNameRegex: ").Append(TagNameRegex).Append("\n");
            sb.Append("  generatePreMergeRef: ").Append(GeneratePreMergeRef).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateGroupGeneralPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateGroupGeneralPolicyResponse input)
        {
            if (input == null) return false;
            if (this.DisableFork != input.DisableFork || (this.DisableFork != null && !this.DisableFork.Equals(input.DisableFork))) return false;
            if (this.BranchNameRegex != input.BranchNameRegex || (this.BranchNameRegex != null && !this.BranchNameRegex.Equals(input.BranchNameRegex))) return false;
            if (this.TagNameRegex != input.TagNameRegex || (this.TagNameRegex != null && !this.TagNameRegex.Equals(input.TagNameRegex))) return false;
            if (this.GeneratePreMergeRef != input.GeneratePreMergeRef || (this.GeneratePreMergeRef != null && !this.GeneratePreMergeRef.Equals(input.GeneratePreMergeRef))) return false;

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
                if (this.DisableFork != null) hashCode = hashCode * 59 + this.DisableFork.GetHashCode();
                if (this.BranchNameRegex != null) hashCode = hashCode * 59 + this.BranchNameRegex.GetHashCode();
                if (this.TagNameRegex != null) hashCode = hashCode * 59 + this.TagNameRegex.GetHashCode();
                if (this.GeneratePreMergeRef != null) hashCode = hashCode * 59 + this.GeneratePreMergeRef.GetHashCode();
                return hashCode;
            }
        }
    }
}
