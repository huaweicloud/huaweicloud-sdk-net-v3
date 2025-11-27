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
    /// 
    /// </summary>
    public class OverrideSpec 
    {

        /// <summary>
        /// 资源选择器，限制该覆盖策略适用的资源类型
        /// </summary>
        [JsonProperty("resourceSelectors", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceSelector> ResourceSelectors { get; set; }

        /// <summary>
        /// 将应用于资源的覆盖规则
        /// </summary>
        [JsonProperty("overriders", NullValueHandling = NullValueHandling.Ignore)]
        public Object Overriders { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OverrideSpec {\n");
            sb.Append("  resourceSelectors: ").Append(ResourceSelectors).Append("\n");
            sb.Append("  overriders: ").Append(Overriders).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OverrideSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OverrideSpec input)
        {
            if (input == null) return false;
            if (this.ResourceSelectors != input.ResourceSelectors || (this.ResourceSelectors != null && input.ResourceSelectors != null && !this.ResourceSelectors.SequenceEqual(input.ResourceSelectors))) return false;
            if (this.Overriders != input.Overriders || (this.Overriders != null && !this.Overriders.Equals(input.Overriders))) return false;

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
                if (this.ResourceSelectors != null) hashCode = hashCode * 59 + this.ResourceSelectors.GetHashCode();
                if (this.Overriders != null) hashCode = hashCode * 59 + this.Overriders.GetHashCode();
                return hashCode;
            }
        }
    }
}
