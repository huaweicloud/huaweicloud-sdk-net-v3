using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListLiveStreamsOnlineResponse : SdkResponse
    {

        /// <summary>
        /// 总条页数
        /// </summary>
        [JsonProperty("total_page", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalPage { get; set; }

        /// <summary>
        /// 总条目数
        /// </summary>
        [JsonProperty("total_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalNum { get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? Offset { get; set; }

        /// <summary>
        /// 每页条目数
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public long? Limit { get; set; }

        /// <summary>
        /// 请求唯一标识
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 推流统计
        /// </summary>
        [JsonProperty("streams", NullValueHandling = NullValueHandling.Ignore)]
        public List<OnlineInfo> Streams { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLiveStreamsOnlineResponse {\n");
            sb.Append("  totalPage: ").Append(TotalPage).Append("\n");
            sb.Append("  totalNum: ").Append(TotalNum).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  streams: ").Append(Streams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListLiveStreamsOnlineResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLiveStreamsOnlineResponse input)
        {
            if (input == null) return false;
            if (this.TotalPage != input.TotalPage || (this.TotalPage != null && !this.TotalPage.Equals(input.TotalPage))) return false;
            if (this.TotalNum != input.TotalNum || (this.TotalNum != null && !this.TotalNum.Equals(input.TotalNum))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;
            if (this.Streams != input.Streams || (this.Streams != null && input.Streams != null && !this.Streams.SequenceEqual(input.Streams))) return false;

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
                if (this.TotalPage != null) hashCode = hashCode * 59 + this.TotalPage.GetHashCode();
                if (this.TotalNum != null) hashCode = hashCode * 59 + this.TotalNum.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.Streams != null) hashCode = hashCode * 59 + this.Streams.GetHashCode();
                return hashCode;
            }
        }
    }
}
