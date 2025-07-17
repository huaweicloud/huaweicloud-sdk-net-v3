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
    /// 资源聚合器授权请求体。
    /// </summary>
    public class AggregationAuthorizationRequest 
    {

        /// <summary>
        /// 要授权的资源聚合器的帐号ID。
        /// </summary>
        [JsonProperty("authorized_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizedAccountId { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTag> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregationAuthorizationRequest {\n");
            sb.Append("  authorizedAccountId: ").Append(AuthorizedAccountId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AggregationAuthorizationRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AggregationAuthorizationRequest input)
        {
            if (input == null) return false;
            if (this.AuthorizedAccountId != input.AuthorizedAccountId || (this.AuthorizedAccountId != null && !this.AuthorizedAccountId.Equals(input.AuthorizedAccountId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;

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
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
