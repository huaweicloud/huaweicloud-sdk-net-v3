using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAsyncInvocationsResponse : SdkResponse
    {

        /// <summary>
        /// 异步调用记录列表。
        /// </summary>
        [JsonProperty("invocations", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListFunctionAsyncInvocationsResult> Invocations { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAsyncInvocationsResponse {\n");
            sb.Append("  invocations: ").Append(Invocations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAsyncInvocationsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAsyncInvocationsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Invocations == input.Invocations ||
                    this.Invocations != null &&
                    input.Invocations != null &&
                    this.Invocations.SequenceEqual(input.Invocations)
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
                if (this.Invocations != null)
                    hashCode = hashCode * 59 + this.Invocations.GetHashCode();
                return hashCode;
            }
        }
    }
}
