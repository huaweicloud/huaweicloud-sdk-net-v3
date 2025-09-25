using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSqlPatchResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: PATCH名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("patch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PatchName { get; set; }

        /// <summary>
        /// **参数解释**: PATCH内容（Hint文本）。对于abort 类型的SQL PATCH此字段为空。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("hint", NullValueHandling = NullValueHandling.Ignore)]
        public string Hint { get; set; }

        /// <summary>
        /// **参数解释**: PATCH状态。 **取值范围**: - enabled：表示SQL PATCH生效。 - disabled：表示SQL PATCH失效。
        /// </summary>
        [JsonProperty("patch_status", NullValueHandling = NullValueHandling.Ignore)]
        public string PatchStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSqlPatchResponse {\n");
            sb.Append("  patchName: ").Append(PatchName).Append("\n");
            sb.Append("  hint: ").Append(Hint).Append("\n");
            sb.Append("  patchStatus: ").Append(PatchStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSqlPatchResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSqlPatchResponse input)
        {
            if (input == null) return false;
            if (this.PatchName != input.PatchName || (this.PatchName != null && !this.PatchName.Equals(input.PatchName))) return false;
            if (this.Hint != input.Hint || (this.Hint != null && !this.Hint.Equals(input.Hint))) return false;
            if (this.PatchStatus != input.PatchStatus || (this.PatchStatus != null && !this.PatchStatus.Equals(input.PatchStatus))) return false;

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
                if (this.PatchName != null) hashCode = hashCode * 59 + this.PatchName.GetHashCode();
                if (this.Hint != null) hashCode = hashCode * 59 + this.Hint.GetHashCode();
                if (this.PatchStatus != null) hashCode = hashCode * 59 + this.PatchStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
