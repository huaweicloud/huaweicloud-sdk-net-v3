using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListShareBandwidthTypesResponse : SdkResponse
    {

        /// <summary>
        /// 功能说明：共享带宽类型对象
        /// </summary>
        [JsonProperty("share_bandwidth_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShareBandwidthTypeShowResp> ShareBandwidthTypes { get; set; }

        /// <summary>
        /// 本次请求的编号
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfoOption PageInfo { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListShareBandwidthTypesResponse {\n");
            sb.Append("  shareBandwidthTypes: ").Append(ShareBandwidthTypes).Append("\n");
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
            return this.Equals(input as ListShareBandwidthTypesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListShareBandwidthTypesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShareBandwidthTypes == input.ShareBandwidthTypes ||
                    this.ShareBandwidthTypes != null &&
                    input.ShareBandwidthTypes != null &&
                    this.ShareBandwidthTypes.SequenceEqual(input.ShareBandwidthTypes)
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
                if (this.ShareBandwidthTypes != null)
                    hashCode = hashCode * 59 + this.ShareBandwidthTypes.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.PageInfo != null)
                    hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
