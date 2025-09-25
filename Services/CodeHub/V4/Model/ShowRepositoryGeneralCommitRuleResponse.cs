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
    public class ShowRepositoryGeneralCommitRuleResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 是否拒绝未Signed-off-by签名的提交。 **约束限制：** 不涉及。 **取值范围：** - true，拒绝未Signed-off-by签名的提交。 - false，允许未Signed-off-by签名的提交。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("reject_unsigned_commits", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RejectUnsignedCommits { get; set; }

        /// <summary>
        /// **参数解释：** 是否拒绝未GPG签名的提交。 **约束限制：** 不涉及。 **取值范围：** - true，拒绝未GPG签名的提交。 - false，允许未GPG签名的提交。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("reject_not_signed_by_gpg", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RejectNotSignedByGpg { get; set; }

        /// <summary>
        /// **参数解释：** 是否不允许删除Tags。 **约束限制：** 不涉及。 **取值范围：** - true，不允许删除Tags。 - false，允许删除Tags。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("deny_delete_tag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DenyDeleteTag { get; set; }

        /// <summary>
        /// **参数解释：** 是否阻止包含涉密文件的提交。 **约束限制：** 不涉及。 **取值范围：** - true，阻止包含涉密文件的提交。 - false，允许包含涉密文件的提交。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("prevent_secrets", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PreventSecrets { get; set; }

        /// <summary>
        /// **参数解释：** 是否禁止强制推送。 **约束限制：** 不涉及。 **取值范围：** - true，禁止强制推送。 - false，允许强制推送。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("deny_force_push", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DenyForcePush { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRepositoryGeneralCommitRuleResponse {\n");
            sb.Append("  rejectUnsignedCommits: ").Append(RejectUnsignedCommits).Append("\n");
            sb.Append("  rejectNotSignedByGpg: ").Append(RejectNotSignedByGpg).Append("\n");
            sb.Append("  denyDeleteTag: ").Append(DenyDeleteTag).Append("\n");
            sb.Append("  preventSecrets: ").Append(PreventSecrets).Append("\n");
            sb.Append("  denyForcePush: ").Append(DenyForcePush).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRepositoryGeneralCommitRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRepositoryGeneralCommitRuleResponse input)
        {
            if (input == null) return false;
            if (this.RejectUnsignedCommits != input.RejectUnsignedCommits || (this.RejectUnsignedCommits != null && !this.RejectUnsignedCommits.Equals(input.RejectUnsignedCommits))) return false;
            if (this.RejectNotSignedByGpg != input.RejectNotSignedByGpg || (this.RejectNotSignedByGpg != null && !this.RejectNotSignedByGpg.Equals(input.RejectNotSignedByGpg))) return false;
            if (this.DenyDeleteTag != input.DenyDeleteTag || (this.DenyDeleteTag != null && !this.DenyDeleteTag.Equals(input.DenyDeleteTag))) return false;
            if (this.PreventSecrets != input.PreventSecrets || (this.PreventSecrets != null && !this.PreventSecrets.Equals(input.PreventSecrets))) return false;
            if (this.DenyForcePush != input.DenyForcePush || (this.DenyForcePush != null && !this.DenyForcePush.Equals(input.DenyForcePush))) return false;

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
                if (this.RejectUnsignedCommits != null) hashCode = hashCode * 59 + this.RejectUnsignedCommits.GetHashCode();
                if (this.RejectNotSignedByGpg != null) hashCode = hashCode * 59 + this.RejectNotSignedByGpg.GetHashCode();
                if (this.DenyDeleteTag != null) hashCode = hashCode * 59 + this.DenyDeleteTag.GetHashCode();
                if (this.PreventSecrets != null) hashCode = hashCode * 59 + this.PreventSecrets.GetHashCode();
                if (this.DenyForcePush != null) hashCode = hashCode * 59 + this.DenyForcePush.GetHashCode();
                return hashCode;
            }
        }
    }
}
