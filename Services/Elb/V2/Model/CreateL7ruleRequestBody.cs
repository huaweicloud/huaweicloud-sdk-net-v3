using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class CreateL7ruleRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("l7rule", NullValueHandling = NullValueHandling.Ignore)]
        public CreateL7ruleV2Req L7rule { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateL7ruleRequestBody {\n");
            sb.Append("  l7rule: ").Append(L7rule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateL7ruleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateL7ruleRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.L7rule == input.L7rule ||
                    (this.L7rule != null &&
                    this.L7rule.Equals(input.L7rule))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.L7rule != null)
                    hashCode = hashCode * 59 + this.L7rule.GetHashCode();
                return hashCode;
            }
        }
    }
}
