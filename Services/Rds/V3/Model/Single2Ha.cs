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
    public class Single2Ha 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("single_to_ha", NullValueHandling = NullValueHandling.Ignore)]
        public Single2HaObject SingleToHa { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Single2Ha {\n");
            sb.Append("  singleToHa: ").Append(SingleToHa).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Single2Ha);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Single2Ha input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SingleToHa == input.SingleToHa ||
                    (this.SingleToHa != null &&
                    this.SingleToHa.Equals(input.SingleToHa))
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
                if (this.SingleToHa != null)
                    hashCode = hashCode * 59 + this.SingleToHa.GetHashCode();
                return hashCode;
            }
        }
    }
}
