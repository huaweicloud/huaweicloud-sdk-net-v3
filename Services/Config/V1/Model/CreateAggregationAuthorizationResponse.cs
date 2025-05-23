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
    /// Response Object
    /// </summary>
    public class CreateAggregationAuthorizationResponse : SdkResponse
    {

        /// <summary>
        /// 资源聚合器授权标识符。
        /// </summary>
        [JsonProperty("aggregation_authorization_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string AggregationAuthorizationUrn { get; set; }

        /// <summary>
        /// 授权的资源聚合器的帐号ID。
        /// </summary>
        [JsonProperty("authorized_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizedAccountId { get; set; }

        /// <summary>
        /// 资源聚合器授权的创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAggregationAuthorizationResponse {\n");
            sb.Append("  aggregationAuthorizationUrn: ").Append(AggregationAuthorizationUrn).Append("\n");
            sb.Append("  authorizedAccountId: ").Append(AuthorizedAccountId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAggregationAuthorizationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAggregationAuthorizationResponse input)
        {
            if (input == null) return false;
            if (this.AggregationAuthorizationUrn != input.AggregationAuthorizationUrn || (this.AggregationAuthorizationUrn != null && !this.AggregationAuthorizationUrn.Equals(input.AggregationAuthorizationUrn))) return false;
            if (this.AuthorizedAccountId != input.AuthorizedAccountId || (this.AuthorizedAccountId != null && !this.AuthorizedAccountId.Equals(input.AuthorizedAccountId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;

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
                if (this.AggregationAuthorizationUrn != null) hashCode = hashCode * 59 + this.AggregationAuthorizationUrn.GetHashCode();
                if (this.AuthorizedAccountId != null) hashCode = hashCode * 59 + this.AuthorizedAccountId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
