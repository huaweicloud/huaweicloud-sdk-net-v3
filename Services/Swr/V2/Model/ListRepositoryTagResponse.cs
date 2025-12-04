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
    public class ListRepositoryTagResponse : SdkResponse
    {

        /// <summary>
        /// 镜像tag列表.
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowReposTagRespV3> Tags { get; set; }

        /// <summary>
        /// 下次分页查询时的起始位置。
        /// </summary>
        [JsonProperty("nextMarker", NullValueHandling = NullValueHandling.Ignore)]
        public string NextMarker { get; set; }

        /// <summary>
        /// 表示分页查询时是否还有下一页
        /// </summary>
        [JsonProperty("has_more", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMore { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRepositoryTagResponse {\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  nextMarker: ").Append(NextMarker).Append("\n");
            sb.Append("  hasMore: ").Append(HasMore).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRepositoryTagResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRepositoryTagResponse input)
        {
            if (input == null) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.NextMarker != input.NextMarker || (this.NextMarker != null && !this.NextMarker.Equals(input.NextMarker))) return false;
            if (this.HasMore != input.HasMore || (this.HasMore != null && !this.HasMore.Equals(input.HasMore))) return false;

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
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.NextMarker != null) hashCode = hashCode * 59 + this.NextMarker.GetHashCode();
                if (this.HasMore != null) hashCode = hashCode * 59 + this.HasMore.GetHashCode();
                return hashCode;
            }
        }
    }
}
