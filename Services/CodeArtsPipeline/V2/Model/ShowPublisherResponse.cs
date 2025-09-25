using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowPublisherResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 发布商详情。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("publisher_detail_map", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, PublisherVO> PublisherDetailMap { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPublisherResponse {\n");
            sb.Append("  publisherDetailMap: ").Append(PublisherDetailMap).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPublisherResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPublisherResponse input)
        {
            if (input == null) return false;
            if (this.PublisherDetailMap != input.PublisherDetailMap || (this.PublisherDetailMap != null && input.PublisherDetailMap != null && !this.PublisherDetailMap.SequenceEqual(input.PublisherDetailMap))) return false;

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
                if (this.PublisherDetailMap != null) hashCode = hashCode * 59 + this.PublisherDetailMap.GetHashCode();
                return hashCode;
            }
        }
    }
}
