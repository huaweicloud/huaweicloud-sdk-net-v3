using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListPrivateNatsResponse : SdkResponse
    {

        /// <summary>
        /// 查询私网NAT网关实例列表的响应体。 详见PrivateNat字段说明。
        /// </summary>
        [JsonProperty("gateways", NullValueHandling = NullValueHandling.Ignore)]
        public List<PrivateNat> Gateways { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPrivateNatsResponse {\n");
            sb.Append("  gateways: ").Append(Gateways).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPrivateNatsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPrivateNatsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Gateways == input.Gateways ||
                    this.Gateways != null &&
                    input.Gateways != null &&
                    this.Gateways.SequenceEqual(input.Gateways)
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.PageInfo == input.PageInfo ||
                    (this.PageInfo != null &&
                    this.PageInfo.Equals(input.PageInfo))
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
                if (this.Gateways != null)
                    hashCode = hashCode * 59 + this.Gateways.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.PageInfo != null)
                    hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
