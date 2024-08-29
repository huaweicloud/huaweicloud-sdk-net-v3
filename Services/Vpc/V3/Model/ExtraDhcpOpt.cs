using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ExtraDhcpOpt 
    {

        /// <summary>
        /// Option名称。
        /// </summary>
        [JsonProperty("opt_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OptName { get; set; }

        /// <summary>
        /// Option值。
        /// </summary>
        [JsonProperty("opt_value", NullValueHandling = NullValueHandling.Ignore)]
        public string OptValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtraDhcpOpt {\n");
            sb.Append("  optName: ").Append(OptName).Append("\n");
            sb.Append("  optValue: ").Append(OptValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtraDhcpOpt);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtraDhcpOpt input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OptName == input.OptName ||
                    (this.OptName != null &&
                    this.OptName.Equals(input.OptName))
                ) && 
                (
                    this.OptValue == input.OptValue ||
                    (this.OptValue != null &&
                    this.OptValue.Equals(input.OptValue))
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
                if (this.OptName != null)
                    hashCode = hashCode * 59 + this.OptName.GetHashCode();
                if (this.OptValue != null)
                    hashCode = hashCode * 59 + this.OptValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
