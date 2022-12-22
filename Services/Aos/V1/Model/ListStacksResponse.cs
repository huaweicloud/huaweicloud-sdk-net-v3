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
    public class ListStacksResponse : SdkResponse
    {

        /// <summary>
        /// 资源栈列表。默认按照生成时间排序，最早生成的在最前
        /// </summary>
        [JsonProperty("stacks", NullValueHandling = NullValueHandling.Ignore)]
        public List<Stack> Stacks { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStacksResponse {\n");
            sb.Append("  stacks: ").Append(Stacks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStacksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStacksResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Stacks == input.Stacks ||
                    this.Stacks != null &&
                    input.Stacks != null &&
                    this.Stacks.SequenceEqual(input.Stacks)
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
                if (this.Stacks != null)
                    hashCode = hashCode * 59 + this.Stacks.GetHashCode();
                return hashCode;
            }
        }
    }
}
