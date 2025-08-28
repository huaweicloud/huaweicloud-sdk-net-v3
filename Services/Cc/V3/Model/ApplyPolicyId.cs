using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplyPolicyId 
    {

        /// <summary>
        /// 应用策略ID。
        /// </summary>
        [JsonProperty("apply_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _ApplyPolicyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyPolicyId {\n");
            sb.Append("  _applyPolicyId: ").Append(_ApplyPolicyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplyPolicyId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplyPolicyId input)
        {
            if (input == null) return false;
            if (this._ApplyPolicyId != input._ApplyPolicyId || (this._ApplyPolicyId != null && !this._ApplyPolicyId.Equals(input._ApplyPolicyId))) return false;

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
                if (this._ApplyPolicyId != null) hashCode = hashCode * 59 + this._ApplyPolicyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
