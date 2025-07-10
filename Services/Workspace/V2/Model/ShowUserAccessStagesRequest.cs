using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowUserAccessStagesRequest 
    {

        /// <summary>
        /// 事务id。
        /// </summary>
        [SDKProperty("transaction_id", IsQuery = true)]
        [JsonProperty("transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUserAccessStagesRequest {\n");
            sb.Append("  transactionId: ").Append(TransactionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUserAccessStagesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUserAccessStagesRequest input)
        {
            if (input == null) return false;
            if (this.TransactionId != input.TransactionId || (this.TransactionId != null && !this.TransactionId.Equals(input.TransactionId))) return false;

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
                if (this.TransactionId != null) hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
