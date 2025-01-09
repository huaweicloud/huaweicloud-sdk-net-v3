using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 规则信息。
    /// </summary>
    public class Rule 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public RuleScope Scope { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("product_rule", NullValueHandling = NullValueHandling.Ignore)]
        public ProductRule ProductRule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("path_rule", NullValueHandling = NullValueHandling.Ignore)]
        public PathRule PathRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rule {\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  productRule: ").Append(ProductRule).Append("\n");
            sb.Append("  pathRule: ").Append(PathRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Rule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Rule input)
        {
            if (input == null) return false;
            if (this.Scope != input.Scope) return false;
            if (this.ProductRule != input.ProductRule || (this.ProductRule != null && !this.ProductRule.Equals(input.ProductRule))) return false;
            if (this.PathRule != input.PathRule || (this.PathRule != null && !this.PathRule.Equals(input.PathRule))) return false;

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
                hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.ProductRule != null) hashCode = hashCode * 59 + this.ProductRule.GetHashCode();
                if (this.PathRule != null) hashCode = hashCode * 59 + this.PathRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
