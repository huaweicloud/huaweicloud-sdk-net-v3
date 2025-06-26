using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 授权描述。
    /// </summary>
    public class Assignment 
    {

        /// <summary>
        /// 策略ID。
        /// </summary>
        [JsonProperty("policy_statement_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyStatementId { get; set; }

        /// <summary>
        /// 目标。
        /// </summary>
        [JsonProperty("attach", NullValueHandling = NullValueHandling.Ignore)]
        public string Attach { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("attach_type", NullValueHandling = NullValueHandling.Ignore)]
        public AttachType AttachType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Assignment {\n");
            sb.Append("  policyStatementId: ").Append(PolicyStatementId).Append("\n");
            sb.Append("  attach: ").Append(Attach).Append("\n");
            sb.Append("  attachType: ").Append(AttachType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Assignment);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Assignment input)
        {
            if (input == null) return false;
            if (this.PolicyStatementId != input.PolicyStatementId || (this.PolicyStatementId != null && !this.PolicyStatementId.Equals(input.PolicyStatementId))) return false;
            if (this.Attach != input.Attach || (this.Attach != null && !this.Attach.Equals(input.Attach))) return false;
            if (this.AttachType != input.AttachType) return false;

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
                if (this.PolicyStatementId != null) hashCode = hashCode * 59 + this.PolicyStatementId.GetHashCode();
                if (this.Attach != null) hashCode = hashCode * 59 + this.Attach.GetHashCode();
                hashCode = hashCode * 59 + this.AttachType.GetHashCode();
                return hashCode;
            }
        }
    }
}
