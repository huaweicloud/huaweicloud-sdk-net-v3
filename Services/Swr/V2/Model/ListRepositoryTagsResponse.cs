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
    public class ListRepositoryTagsResponse : SdkResponse
    {

        /// <summary>
        /// 镜像tag列表
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowReposTagResp> Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("Content-Range", IsHeader = true)]
        [JsonProperty("Content-Range", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentRange { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRepositoryTagsResponse {\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("  contentRange: ").Append(ContentRange).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRepositoryTagsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRepositoryTagsResponse input)
        {
            if (input == null) return false;
            if (this.Body != input.Body || (this.Body != null && input.Body != null && !this.Body.SequenceEqual(input.Body))) return false;
            if (this.ContentRange != input.ContentRange || (this.ContentRange != null && !this.ContentRange.Equals(input.ContentRange))) return false;

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
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.ContentRange != null) hashCode = hashCode * 59 + this.ContentRange.GetHashCode();
                return hashCode;
            }
        }
    }
}
