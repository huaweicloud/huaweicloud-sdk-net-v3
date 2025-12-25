using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AuditResult 
    {

        /// <summary>
        /// **参数解释**： 审计日志列表。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("auditInfoList", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuditDO> AuditInfoList { get; set; }

        /// <summary>
        /// **参数解释**： 审计日志条数。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditResult {\n");
            sb.Append("  auditInfoList: ").Append(AuditInfoList).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuditResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuditResult input)
        {
            if (input == null) return false;
            if (this.AuditInfoList != input.AuditInfoList || (this.AuditInfoList != null && input.AuditInfoList != null && !this.AuditInfoList.SequenceEqual(input.AuditInfoList))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.AuditInfoList != null) hashCode = hashCode * 59 + this.AuditInfoList.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
