using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// tracker选择器
    /// </summary>
    public class SelectorConfigBody 
    {

        /// <summary>
        /// 是否选择所有支持的资源
        /// </summary>
        [JsonProperty("all_supported", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllSupported { get; set; }

        /// <summary>
        /// 资源类型列表
        /// </summary>
        [JsonProperty("resource_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceTypes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SelectorConfigBody {\n");
            sb.Append("  allSupported: ").Append(AllSupported).Append("\n");
            sb.Append("  resourceTypes: ").Append(ResourceTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SelectorConfigBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SelectorConfigBody input)
        {
            if (input == null) return false;
            if (this.AllSupported != input.AllSupported || (this.AllSupported != null && !this.AllSupported.Equals(input.AllSupported))) return false;
            if (this.ResourceTypes != input.ResourceTypes || (this.ResourceTypes != null && input.ResourceTypes != null && !this.ResourceTypes.SequenceEqual(input.ResourceTypes))) return false;

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
                if (this.AllSupported != null) hashCode = hashCode * 59 + this.AllSupported.GetHashCode();
                if (this.ResourceTypes != null) hashCode = hashCode * 59 + this.ResourceTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
