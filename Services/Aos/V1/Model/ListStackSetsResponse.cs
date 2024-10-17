using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListStackSetsResponse : SdkResponse
    {

        /// <summary>
        /// 资源栈集
        /// </summary>
        [JsonProperty("stack_sets", NullValueHandling = NullValueHandling.Ignore)]
        public List<StackSet> StackSets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStackSetsResponse {\n");
            sb.Append("  stackSets: ").Append(StackSets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStackSetsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStackSetsResponse input)
        {
            if (input == null) return false;
            if (this.StackSets != input.StackSets || (this.StackSets != null && input.StackSets != null && !this.StackSets.SequenceEqual(input.StackSets))) return false;

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
                if (this.StackSets != null) hashCode = hashCode * 59 + this.StackSets.GetHashCode();
                return hashCode;
            }
        }
    }
}
