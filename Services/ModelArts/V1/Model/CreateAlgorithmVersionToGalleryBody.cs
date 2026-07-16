using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 创建发布算法资产请求
    /// </summary>
    public class CreateAlgorithmVersionToGalleryBody 
    {

        /// <summary>
        /// **参数解释**：资产id。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("content_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("content_info", NullValueHandling = NullValueHandling.Ignore)]
        public ContentInfo ContentInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public AlgorithmInfo Algorithm { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAlgorithmVersionToGalleryBody {\n");
            sb.Append("  contentId: ").Append(ContentId).Append("\n");
            sb.Append("  contentInfo: ").Append(ContentInfo).Append("\n");
            sb.Append("  algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAlgorithmVersionToGalleryBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAlgorithmVersionToGalleryBody input)
        {
            if (input == null) return false;
            if (this.ContentId != input.ContentId || (this.ContentId != null && !this.ContentId.Equals(input.ContentId))) return false;
            if (this.ContentInfo != input.ContentInfo || (this.ContentInfo != null && !this.ContentInfo.Equals(input.ContentInfo))) return false;
            if (this.Algorithm != input.Algorithm || (this.Algorithm != null && !this.Algorithm.Equals(input.Algorithm))) return false;

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
                if (this.ContentId != null) hashCode = hashCode * 59 + this.ContentId.GetHashCode();
                if (this.ContentInfo != null) hashCode = hashCode * 59 + this.ContentInfo.GetHashCode();
                if (this.Algorithm != null) hashCode = hashCode * 59 + this.Algorithm.GetHashCode();
                return hashCode;
            }
        }
    }
}
