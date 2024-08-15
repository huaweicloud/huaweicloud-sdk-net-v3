using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListL7PoliciesResponse : SdkResponse
    {

        /// <summary>
        /// 参数解释：请求ID。  注：自动生成 。
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }

        /// <summary>
        /// 参数解释：转发策略对象列表。
        /// </summary>
        [JsonProperty("l7policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<L7Policy> L7policies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListL7PoliciesResponse {\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("  l7policies: ").Append(L7policies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListL7PoliciesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListL7PoliciesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.PageInfo == input.PageInfo ||
                    (this.PageInfo != null &&
                    this.PageInfo.Equals(input.PageInfo))
                ) && 
                (
                    this.L7policies == input.L7policies ||
                    this.L7policies != null &&
                    input.L7policies != null &&
                    this.L7policies.SequenceEqual(input.L7policies)
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.PageInfo != null)
                    hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                if (this.L7policies != null)
                    hashCode = hashCode * 59 + this.L7policies.GetHashCode();
                return hashCode;
            }
        }
    }
}
