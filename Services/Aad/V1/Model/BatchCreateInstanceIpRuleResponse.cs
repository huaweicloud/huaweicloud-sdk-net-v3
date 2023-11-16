using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchCreateInstanceIpRuleResponse : SdkResponse
    {

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("success_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuccessNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreateInstanceIpRuleResponse {\n");
            sb.Append("  successNum: ").Append(SuccessNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCreateInstanceIpRuleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreateInstanceIpRuleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SuccessNum == input.SuccessNum ||
                    (this.SuccessNum != null &&
                    this.SuccessNum.Equals(input.SuccessNum))
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
                if (this.SuccessNum != null)
                    hashCode = hashCode * 59 + this.SuccessNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
