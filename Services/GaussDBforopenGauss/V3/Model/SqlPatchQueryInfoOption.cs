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
    /// 
    /// </summary>
    public class SqlPatchQueryInfoOption 
    {

        /// <summary>
        /// **参数解释**: unique_sql_id。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlId { get; set; }

        /// <summary>
        /// **参数解释**: SQL文本。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_text", NullValueHandling = NullValueHandling.Ignore)]
        public string SqlText { get; set; }

        /// <summary>
        /// **参数解释**: SQL Patch名称。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("patch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PatchName { get; set; }

        /// <summary>
        /// **参数解释**: 节点ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// **参数解释**: Patch是否生效。 **取值范围**: - true：生效 - false：不生效
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// **参数解释**: Patch类型。 **取值范围**: - true：Abort Patch - false：非Abort Patch
        /// </summary>
        [JsonProperty("abort_patch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AbortPatch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SqlPatchQueryInfoOption {\n");
            sb.Append("  sqlId: ").Append(SqlId).Append("\n");
            sb.Append("  sqlText: ").Append(SqlText).Append("\n");
            sb.Append("  patchName: ").Append(PatchName).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  abortPatch: ").Append(AbortPatch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SqlPatchQueryInfoOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SqlPatchQueryInfoOption input)
        {
            if (input == null) return false;
            if (this.SqlId != input.SqlId || (this.SqlId != null && !this.SqlId.Equals(input.SqlId))) return false;
            if (this.SqlText != input.SqlText || (this.SqlText != null && !this.SqlText.Equals(input.SqlText))) return false;
            if (this.PatchName != input.PatchName || (this.PatchName != null && !this.PatchName.Equals(input.PatchName))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.AbortPatch != input.AbortPatch || (this.AbortPatch != null && !this.AbortPatch.Equals(input.AbortPatch))) return false;

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
                if (this.SqlId != null) hashCode = hashCode * 59 + this.SqlId.GetHashCode();
                if (this.SqlText != null) hashCode = hashCode * 59 + this.SqlText.GetHashCode();
                if (this.PatchName != null) hashCode = hashCode * 59 + this.PatchName.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.AbortPatch != null) hashCode = hashCode * 59 + this.AbortPatch.GetHashCode();
                return hashCode;
            }
        }
    }
}
