using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListCentralNetworkErRouteTableAttachmentsResponse : SdkResponse
    {

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
        /// 创建路由表附件的返回体
        /// </summary>
        [JsonProperty("central_network_er_route_table_attachments", NullValueHandling = NullValueHandling.Ignore)]
        public List<CentralNetworkErRouteTableAttachment> CentralNetworkErRouteTableAttachments { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCentralNetworkErRouteTableAttachmentsResponse {\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("  centralNetworkErRouteTableAttachments: ").Append(CentralNetworkErRouteTableAttachments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCentralNetworkErRouteTableAttachmentsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCentralNetworkErRouteTableAttachmentsResponse input)
        {
            if (input == null) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;
            if (this.CentralNetworkErRouteTableAttachments != input.CentralNetworkErRouteTableAttachments || (this.CentralNetworkErRouteTableAttachments != null && input.CentralNetworkErRouteTableAttachments != null && !this.CentralNetworkErRouteTableAttachments.SequenceEqual(input.CentralNetworkErRouteTableAttachments))) return false;

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
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                if (this.CentralNetworkErRouteTableAttachments != null) hashCode = hashCode * 59 + this.CentralNetworkErRouteTableAttachments.GetHashCode();
                return hashCode;
            }
        }
    }
}
