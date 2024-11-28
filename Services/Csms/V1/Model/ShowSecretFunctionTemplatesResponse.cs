using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSecretFunctionTemplatesResponse : SdkResponse
    {

        /// <summary>
        /// 凭据轮转函数模板。
        /// </summary>
        [JsonProperty("function_templates", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionTemplates { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSecretFunctionTemplatesResponse {\n");
            sb.Append("  functionTemplates: ").Append(FunctionTemplates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSecretFunctionTemplatesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSecretFunctionTemplatesResponse input)
        {
            if (input == null) return false;
            if (this.FunctionTemplates != input.FunctionTemplates || (this.FunctionTemplates != null && !this.FunctionTemplates.Equals(input.FunctionTemplates))) return false;

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
                if (this.FunctionTemplates != null) hashCode = hashCode * 59 + this.FunctionTemplates.GetHashCode();
                return hashCode;
            }
        }
    }
}
