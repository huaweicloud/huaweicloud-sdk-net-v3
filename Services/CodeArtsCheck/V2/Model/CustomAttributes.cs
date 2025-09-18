using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomAttributes 
    {

        /// <summary>
        /// 配置项属性，severity：为问题级别
        /// </summary>
        [JsonProperty("attribute", NullValueHandling = NullValueHandling.Ignore)]
        public string Attribute { get; set; }

        /// <summary>
        /// 规则详细
        /// </summary>
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomAttributesRule> Rules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomAttributes {\n");
            sb.Append("  attribute: ").Append(Attribute).Append("\n");
            sb.Append("  rules: ").Append(Rules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomAttributes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomAttributes input)
        {
            if (input == null) return false;
            if (this.Attribute != input.Attribute || (this.Attribute != null && !this.Attribute.Equals(input.Attribute))) return false;
            if (this.Rules != input.Rules || (this.Rules != null && input.Rules != null && !this.Rules.SequenceEqual(input.Rules))) return false;

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
                if (this.Attribute != null) hashCode = hashCode * 59 + this.Attribute.GetHashCode();
                if (this.Rules != null) hashCode = hashCode * 59 + this.Rules.GetHashCode();
                return hashCode;
            }
        }
    }
}
