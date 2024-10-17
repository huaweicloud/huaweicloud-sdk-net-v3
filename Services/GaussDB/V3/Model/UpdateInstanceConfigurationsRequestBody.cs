using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 参数信息。
    /// </summary>
    public class UpdateInstanceConfigurationsRequestBody 
    {

        /// <summary>
        /// 参数名和参数值映射关系。用户可以基于默认参数模板的参数，自定义的参数值。不传入该参数，则保持原参数信息。
        /// </summary>
        [JsonProperty("parameter_values", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ParameterValues { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInstanceConfigurationsRequestBody {\n");
            sb.Append("  parameterValues: ").Append(ParameterValues).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateInstanceConfigurationsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateInstanceConfigurationsRequestBody input)
        {
            if (input == null) return false;
            if (this.ParameterValues != input.ParameterValues || (this.ParameterValues != null && input.ParameterValues != null && !this.ParameterValues.SequenceEqual(input.ParameterValues))) return false;

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
                if (this.ParameterValues != null) hashCode = hashCode * 59 + this.ParameterValues.GetHashCode();
                return hashCode;
            }
        }
    }
}
