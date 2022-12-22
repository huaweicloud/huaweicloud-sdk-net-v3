using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowRecyclePolicyResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("recycle_policy", NullValueHandling = NullValueHandling.Ignore)]
        public RecyclePolicy RecyclePolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRecyclePolicyResponse {\n");
            sb.Append("  recyclePolicy: ").Append(RecyclePolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRecyclePolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRecyclePolicyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecyclePolicy == input.RecyclePolicy ||
                    (this.RecyclePolicy != null &&
                    this.RecyclePolicy.Equals(input.RecyclePolicy))
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
                if (this.RecyclePolicy != null)
                    hashCode = hashCode * 59 + this.RecyclePolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
