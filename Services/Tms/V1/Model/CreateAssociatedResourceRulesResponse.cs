using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Tms.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateAssociatedResourceRulesResponse : SdkResponse
    {

        /// <summary>
        /// 本次操作的规则信息
        /// </summary>
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<AssociatedResourceRule> Rules { get; set; }

        /// <summary>
        /// 操作的错误信息
        /// </summary>
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public List<ErrorInfo> Errors { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAssociatedResourceRulesResponse {\n");
            sb.Append("  rules: ").Append(Rules).Append("\n");
            sb.Append("  errors: ").Append(Errors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAssociatedResourceRulesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAssociatedResourceRulesResponse input)
        {
            if (input == null) return false;
            if (this.Rules != input.Rules || (this.Rules != null && input.Rules != null && !this.Rules.SequenceEqual(input.Rules))) return false;
            if (this.Errors != input.Errors || (this.Errors != null && input.Errors != null && !this.Errors.SequenceEqual(input.Errors))) return false;

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
                if (this.Rules != null) hashCode = hashCode * 59 + this.Rules.GetHashCode();
                if (this.Errors != null) hashCode = hashCode * 59 + this.Errors.GetHashCode();
                return hashCode;
            }
        }
    }
}
