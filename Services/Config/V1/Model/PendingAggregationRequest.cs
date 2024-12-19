using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// PendingAggregationRequest对象。
    /// </summary>
    public class PendingAggregationRequest 
    {

        /// <summary>
        /// 请求聚合数据的帐号ID。
        /// </summary>
        [JsonProperty("requester_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequesterAccountId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PendingAggregationRequest {\n");
            sb.Append("  requesterAccountId: ").Append(RequesterAccountId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PendingAggregationRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PendingAggregationRequest input)
        {
            if (input == null) return false;
            if (this.RequesterAccountId != input.RequesterAccountId || (this.RequesterAccountId != null && !this.RequesterAccountId.Equals(input.RequesterAccountId))) return false;

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
                if (this.RequesterAccountId != null) hashCode = hashCode * 59 + this.RequesterAccountId.GetHashCode();
                return hashCode;
            }
        }
    }
}
