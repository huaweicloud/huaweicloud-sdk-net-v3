using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rfs.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ParseTemplateVariablesResponse : SdkResponse
    {

        /// <summary>
        /// 解析模板得到的参数列表
        /// </summary>
        [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
        public List<VariableResponse> Variables { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParseTemplateVariablesResponse {\n");
            sb.Append("  variables: ").Append(Variables).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ParseTemplateVariablesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ParseTemplateVariablesResponse input)
        {
            if (input == null) return false;
            if (this.Variables != input.Variables || (this.Variables != null && input.Variables != null && !this.Variables.SequenceEqual(input.Variables))) return false;

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
                if (this.Variables != null) hashCode = hashCode * 59 + this.Variables.GetHashCode();
                return hashCode;
            }
        }
    }
}
