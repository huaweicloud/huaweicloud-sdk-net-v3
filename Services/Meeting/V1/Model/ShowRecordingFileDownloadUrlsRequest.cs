using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowRecordingFileDownloadUrlsRequest 
    {

        /// <summary>
        /// 会议UUID(通过[[查询录制列表](https://support.huaweicloud.com/api-meeting/meeting_21_0048.html)](tag:hws)[[查询录制列表](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0048.html)](tag:hk)获取)。
        /// </summary>
        [SDKProperty("confUUID", IsQuery = true)]
        [JsonProperty("confUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfUUID { get; set; }

        /// <summary>
        /// 查询偏移量。默认为0。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询数量。默认是20，最大500条。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 标识是否为第三方portal过来的请求。 &gt; 该参数将废弃，请勿使用。 
        /// </summary>
        [SDKProperty("X-Authorization-Type", IsHeader = true)]
        [JsonProperty("X-Authorization-Type", NullValueHandling = NullValueHandling.Ignore)]
        public string XAuthorizationType { get; set; }

        /// <summary>
        /// 用于区分到哪个HCSO站点鉴权。 &gt; 该参数将废弃，请勿使用。 
        /// </summary>
        [SDKProperty("X-Site-Id", IsHeader = true)]
        [JsonProperty("X-Site-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XSiteId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRecordingFileDownloadUrlsRequest {\n");
            sb.Append("  confUUID: ").Append(ConfUUID).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  xAuthorizationType: ").Append(XAuthorizationType).Append("\n");
            sb.Append("  xSiteId: ").Append(XSiteId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRecordingFileDownloadUrlsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRecordingFileDownloadUrlsRequest input)
        {
            if (input == null) return false;
            if (this.ConfUUID != input.ConfUUID || (this.ConfUUID != null && !this.ConfUUID.Equals(input.ConfUUID))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.XAuthorizationType != input.XAuthorizationType || (this.XAuthorizationType != null && !this.XAuthorizationType.Equals(input.XAuthorizationType))) return false;
            if (this.XSiteId != input.XSiteId || (this.XSiteId != null && !this.XSiteId.Equals(input.XSiteId))) return false;

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
                if (this.ConfUUID != null) hashCode = hashCode * 59 + this.ConfUUID.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.XAuthorizationType != null) hashCode = hashCode * 59 + this.XAuthorizationType.GetHashCode();
                if (this.XSiteId != null) hashCode = hashCode * 59 + this.XSiteId.GetHashCode();
                return hashCode;
            }
        }
    }
}
