using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSaleCyclesResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sale_cycles", NullValueHandling = NullValueHandling.Ignore)]
        public List<SaleCycleOption> SaleCycles { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSaleCyclesResponse {\n");
            sb.Append("  saleCycles: ").Append(SaleCycles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSaleCyclesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSaleCyclesResponse input)
        {
            if (input == null) return false;
            if (this.SaleCycles != input.SaleCycles || (this.SaleCycles != null && input.SaleCycles != null && !this.SaleCycles.SequenceEqual(input.SaleCycles))) return false;

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
                if (this.SaleCycles != null) hashCode = hashCode * 59 + this.SaleCycles.GetHashCode();
                return hashCode;
            }
        }
    }
}
