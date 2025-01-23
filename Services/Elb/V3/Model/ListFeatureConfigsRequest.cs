using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListFeatureConfigsRequest 
    {

        /// <summary>
        /// 参数解释：特性名称。
        /// </summary>
        [SDKProperty("feature", IsQuery = true)]
        [JsonProperty("feature", NullValueHandling = NullValueHandling.Ignore)]
        public string Feature { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFeatureConfigsRequest {\n");
            sb.Append("  feature: ").Append(Feature).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFeatureConfigsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFeatureConfigsRequest input)
        {
            if (input == null) return false;
            if (this.Feature != input.Feature || (this.Feature != null && !this.Feature.Equals(input.Feature))) return false;

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
                if (this.Feature != null) hashCode = hashCode * 59 + this.Feature.GetHashCode();
                return hashCode;
            }
        }
    }
}
