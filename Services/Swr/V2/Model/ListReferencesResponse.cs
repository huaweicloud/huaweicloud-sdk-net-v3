using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListReferencesResponse : SdkResponse
    {

        /// <summary>
        /// 下一次分页查询的起始ID。如果未返回该值，则表示数据已查询完毕
        /// </summary>
        [JsonProperty("next_marker", NullValueHandling = NullValueHandling.Ignore)]
        public string NextMarker { get; set; }

        /// <summary>
        /// 分页查询时表示是否还有下一页的数据
        /// </summary>
        [JsonProperty("has_more", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 镜像版本列表
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListReferencesResponse {\n");
            sb.Append("  nextMarker: ").Append(NextMarker).Append("\n");
            sb.Append("  hasMore: ").Append(HasMore).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListReferencesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListReferencesResponse input)
        {
            if (input == null) return false;
            if (this.NextMarker != input.NextMarker || (this.NextMarker != null && !this.NextMarker.Equals(input.NextMarker))) return false;
            if (this.HasMore != input.HasMore || (this.HasMore != null && !this.HasMore.Equals(input.HasMore))) return false;
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
                if (this.NextMarker != null) hashCode = hashCode * 59 + this.NextMarker.GetHashCode();
                if (this.HasMore != null) hashCode = hashCode * 59 + this.HasMore.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
