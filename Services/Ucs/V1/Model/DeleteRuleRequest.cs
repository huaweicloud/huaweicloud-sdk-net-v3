using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteRuleRequest 
    {

        /// <summary>
        /// 权限策略id
        /// </summary>
        [SDKProperty("ruleid", IsPath = true)]
        [JsonProperty("ruleid", NullValueHandling = NullValueHandling.Ignore)]
        public string Ruleid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteRuleRequest {\n");
            sb.Append("  ruleid: ").Append(Ruleid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteRuleRequest input)
        {
            if (input == null) return false;
            if (this.Ruleid != input.Ruleid || (this.Ruleid != null && !this.Ruleid.Equals(input.Ruleid))) return false;

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
                if (this.Ruleid != null) hashCode = hashCode * 59 + this.Ruleid.GetHashCode();
                return hashCode;
            }
        }
    }
}
