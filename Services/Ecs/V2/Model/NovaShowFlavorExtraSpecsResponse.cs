using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class NovaShowFlavorExtraSpecsResponse : SdkResponse
    {

        /// <summary>
        /// 描述弹性云服务器规格的键值对。
        /// </summary>
        [JsonProperty("extra_specs", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ExtraSpecs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaShowFlavorExtraSpecsResponse {\n");
            sb.Append("  extraSpecs: ").Append(ExtraSpecs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaShowFlavorExtraSpecsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaShowFlavorExtraSpecsResponse input)
        {
            if (input == null) return false;
            if (this.ExtraSpecs != input.ExtraSpecs || (this.ExtraSpecs != null && input.ExtraSpecs != null && !this.ExtraSpecs.SequenceEqual(input.ExtraSpecs))) return false;

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
                if (this.ExtraSpecs != null) hashCode = hashCode * 59 + this.ExtraSpecs.GetHashCode();
                return hashCode;
            }
        }
    }
}
