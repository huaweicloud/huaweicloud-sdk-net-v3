using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class UpdateAuditTaskStatusRequest 
    {

        /// <summary>
        /// **参数解释**： 业务类型。 **约束限制**： 区分大小写，以取值范围为准 **取值范围**： - risk：风险  - audit：审计实例 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("busi_type", IsPath = true)]
        [JsonProperty("busi_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BusiType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public AuditSummaryStatusRequest Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAuditTaskStatusRequest {\n");
            sb.Append("  busiType: ").Append(BusiType).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAuditTaskStatusRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAuditTaskStatusRequest input)
        {
            if (input == null) return false;
            if (this.BusiType != input.BusiType || (this.BusiType != null && !this.BusiType.Equals(input.BusiType))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.BusiType != null) hashCode = hashCode * 59 + this.BusiType.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
