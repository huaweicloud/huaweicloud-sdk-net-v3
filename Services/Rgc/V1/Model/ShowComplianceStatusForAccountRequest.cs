using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowComplianceStatusForAccountRequest 
    {

        /// <summary>
        /// 纳管账号ID。
        /// </summary>
        [SDKProperty("managed_account_id", IsPath = true)]
        [JsonProperty("managed_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedAccountId { get; set; }

        /// <summary>
        /// 控制策略ID。
        /// </summary>
        [SDKProperty("control_id", IsQuery = true)]
        [JsonProperty("control_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ControlId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowComplianceStatusForAccountRequest {\n");
            sb.Append("  managedAccountId: ").Append(ManagedAccountId).Append("\n");
            sb.Append("  controlId: ").Append(ControlId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowComplianceStatusForAccountRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowComplianceStatusForAccountRequest input)
        {
            if (input == null) return false;
            if (this.ManagedAccountId != input.ManagedAccountId || (this.ManagedAccountId != null && !this.ManagedAccountId.Equals(input.ManagedAccountId))) return false;
            if (this.ControlId != input.ControlId || (this.ControlId != null && !this.ControlId.Equals(input.ControlId))) return false;

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
                if (this.ManagedAccountId != null) hashCode = hashCode * 59 + this.ManagedAccountId.GetHashCode();
                if (this.ControlId != null) hashCode = hashCode * 59 + this.ControlId.GetHashCode();
                return hashCode;
            }
        }
    }
}
