using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 调优参数。
    /// </summary>
    public class TuningParameter 
    {

        /// <summary>
        /// 参数名称。
        /// </summary>
        [JsonProperty("param_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamName { get; set; }

        /// <summary>
        /// 参数取值。
        /// </summary>
        [JsonProperty("param_value", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamValue { get; set; }

        /// <summary>
        /// 是否可用。
        /// </summary>
        [JsonProperty("availability", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Availability { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TuningParameter {\n");
            sb.Append("  paramName: ").Append(ParamName).Append("\n");
            sb.Append("  paramValue: ").Append(ParamValue).Append("\n");
            sb.Append("  availability: ").Append(Availability).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TuningParameter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TuningParameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParamName == input.ParamName ||
                    (this.ParamName != null &&
                    this.ParamName.Equals(input.ParamName))
                ) && 
                (
                    this.ParamValue == input.ParamValue ||
                    (this.ParamValue != null &&
                    this.ParamValue.Equals(input.ParamValue))
                ) && 
                (
                    this.Availability == input.Availability ||
                    (this.Availability != null &&
                    this.Availability.Equals(input.Availability))
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
                if (this.ParamName != null)
                    hashCode = hashCode * 59 + this.ParamName.GetHashCode();
                if (this.ParamValue != null)
                    hashCode = hashCode * 59 + this.ParamValue.GetHashCode();
                if (this.Availability != null)
                    hashCode = hashCode * 59 + this.Availability.GetHashCode();
                return hashCode;
            }
        }
    }
}
