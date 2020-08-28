using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProtectPolicyOption 
    {

        /// <summary>
        /// 是否开启操作保护，开启为\&quot;true\&quot;，未开启为\&quot;false\&quot;。
        /// </summary>
        [JsonProperty("operation_protection", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OperationProtection { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtectPolicyOption {\n");
            sb.Append("  operationProtection: ").Append(OperationProtection).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProtectPolicyOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProtectPolicyOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OperationProtection == input.OperationProtection ||
                    (this.OperationProtection != null &&
                    this.OperationProtection.Equals(input.OperationProtection))
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
                if (this.OperationProtection != null)
                    hashCode = hashCode * 59 + this.OperationProtection.GetHashCode();
                return hashCode;
            }
        }
    }
}
