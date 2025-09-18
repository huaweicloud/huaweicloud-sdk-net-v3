using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ValidateServerGroupResponse : SdkResponse
    {

        /// <summary>
        /// 校验结果。
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("validate_rule", NullValueHandling = NullValueHandling.Ignore)]
        public ValidateRuleEnum? ValidateRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateServerGroupResponse {\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  validateRule: ").Append(ValidateRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ValidateServerGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ValidateServerGroupResponse input)
        {
            if (input == null) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.ValidateRule != input.ValidateRule || (this.ValidateRule != null && !this.ValidateRule.Equals(input.ValidateRule))) return false;

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
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.ValidateRule != null) hashCode = hashCode * 59 + this.ValidateRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
