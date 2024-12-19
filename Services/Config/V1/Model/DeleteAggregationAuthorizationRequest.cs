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
    /// Request Object
    /// </summary>
    public class DeleteAggregationAuthorizationRequest 
    {

        /// <summary>
        /// 授权的资源聚合器的帐号ID。
        /// </summary>
        [SDKProperty("authorized_account_id", IsPath = true)]
        [JsonProperty("authorized_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizedAccountId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAggregationAuthorizationRequest {\n");
            sb.Append("  authorizedAccountId: ").Append(AuthorizedAccountId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAggregationAuthorizationRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAggregationAuthorizationRequest input)
        {
            if (input == null) return false;
            if (this.AuthorizedAccountId != input.AuthorizedAccountId || (this.AuthorizedAccountId != null && !this.AuthorizedAccountId.Equals(input.AuthorizedAccountId))) return false;

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
                if (this.AuthorizedAccountId != null) hashCode = hashCode * 59 + this.AuthorizedAccountId.GetHashCode();
                return hashCode;
            }
        }
    }
}
