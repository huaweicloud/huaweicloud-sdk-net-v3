using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListConfigurationsDiffResponse : SdkResponse
    {

        /// <summary>
        /// 参数组之间的差异集合。
        /// </summary>
        [JsonProperty("differences", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListDiffDetailsResult> Differences { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListConfigurationsDiffResponse {\n");
            sb.Append("  differences: ").Append(Differences).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListConfigurationsDiffResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListConfigurationsDiffResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Differences == input.Differences ||
                    this.Differences != null &&
                    input.Differences != null &&
                    this.Differences.SequenceEqual(input.Differences)
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
                if (this.Differences != null)
                    hashCode = hashCode * 59 + this.Differences.GetHashCode();
                return hashCode;
            }
        }
    }
}
