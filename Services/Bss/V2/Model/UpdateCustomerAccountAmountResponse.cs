using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateCustomerAccountAmountResponse : SdkResponse
    {

        /// <summary>
        /// 事务流水ID，只有成功响应才会返回。
        /// </summary>
        [JsonProperty("transfer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransferId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCustomerAccountAmountResponse {\n");
            sb.Append("  transferId: ").Append(TransferId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateCustomerAccountAmountResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateCustomerAccountAmountResponse input)
        {
            if (input == null) return false;
            if (this.TransferId != input.TransferId || (this.TransferId != null && !this.TransferId.Equals(input.TransferId))) return false;

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
                if (this.TransferId != null) hashCode = hashCode * 59 + this.TransferId.GetHashCode();
                return hashCode;
            }
        }
    }
}
