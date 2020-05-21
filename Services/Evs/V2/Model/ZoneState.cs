using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// 可用分区的状态。
    /// </summary>
    public class ZoneState 
    {

        /// <summary>
        /// 可用分区是否可用。
        /// </summary>
        [JsonProperty("available", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Available { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZoneState {\n");
            sb.Append("  available: ").Append(Available).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ZoneState);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ZoneState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Available == input.Available ||
                    (this.Available != null &&
                    this.Available.Equals(input.Available))
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
                if (this.Available != null)
                    hashCode = hashCode * 59 + this.Available.GetHashCode();
                return hashCode;
            }
        }
    }
}
