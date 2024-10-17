using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RecyclePolicyRequestBody 
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
            sb.Append("class RecyclePolicyRequestBody {\n");
            sb.Append("  recyclePolicy: ").Append(RecyclePolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecyclePolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecyclePolicyRequestBody input)
        {
            if (input == null) return false;
            if (this.RecyclePolicy != input.RecyclePolicy || (this.RecyclePolicy != null && !this.RecyclePolicy.Equals(input.RecyclePolicy))) return false;

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
                if (this.RecyclePolicy != null) hashCode = hashCode * 59 + this.RecyclePolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
