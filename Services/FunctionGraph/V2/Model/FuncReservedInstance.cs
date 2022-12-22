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
    /// 
    /// </summary>
    public class FuncReservedInstance 
    {

        /// <summary>
        /// 函数urn
        /// </summary>
        [JsonProperty("func_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string FuncUrn { get; set; }

        /// <summary>
        /// 预留实例数目
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FuncReservedInstance {\n");
            sb.Append("  funcUrn: ").Append(FuncUrn).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FuncReservedInstance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FuncReservedInstance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FuncUrn == input.FuncUrn ||
                    (this.FuncUrn != null &&
                    this.FuncUrn.Equals(input.FuncUrn))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.FuncUrn != null)
                    hashCode = hashCode * 59 + this.FuncUrn.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
