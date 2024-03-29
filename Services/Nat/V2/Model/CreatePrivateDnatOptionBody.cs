using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// 创建DNAT规则的请求体。
    /// </summary>
    public class CreatePrivateDnatOptionBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dnat_rule", NullValueHandling = NullValueHandling.Ignore)]
        public CreatePrivateDnatOption DnatRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePrivateDnatOptionBody {\n");
            sb.Append("  dnatRule: ").Append(DnatRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePrivateDnatOptionBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePrivateDnatOptionBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DnatRule == input.DnatRule ||
                    (this.DnatRule != null &&
                    this.DnatRule.Equals(input.DnatRule))
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
                if (this.DnatRule != null)
                    hashCode = hashCode * 59 + this.DnatRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
