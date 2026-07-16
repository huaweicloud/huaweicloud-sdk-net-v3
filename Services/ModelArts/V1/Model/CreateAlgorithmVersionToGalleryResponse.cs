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
    /// Response Object
    /// </summary>
    public class CreateAlgorithmVersionToGalleryResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：资产id。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("content_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentId { get; set; }

        /// <summary>
        /// **参数解释**：版本号id。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionId { get; set; }

        /// <summary>
        /// **参数解释**：版本数量。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("version_num", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionNum { get; set; }

        /// <summary>
        /// **参数解释**：资产uri地址。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("content_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentUri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAlgorithmVersionToGalleryResponse {\n");
            sb.Append("  contentId: ").Append(ContentId).Append("\n");
            sb.Append("  versionId: ").Append(VersionId).Append("\n");
            sb.Append("  versionNum: ").Append(VersionNum).Append("\n");
            sb.Append("  contentUri: ").Append(ContentUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAlgorithmVersionToGalleryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAlgorithmVersionToGalleryResponse input)
        {
            if (input == null) return false;
            if (this.ContentId != input.ContentId || (this.ContentId != null && !this.ContentId.Equals(input.ContentId))) return false;
            if (this.VersionId != input.VersionId || (this.VersionId != null && !this.VersionId.Equals(input.VersionId))) return false;
            if (this.VersionNum != input.VersionNum || (this.VersionNum != null && !this.VersionNum.Equals(input.VersionNum))) return false;
            if (this.ContentUri != input.ContentUri || (this.ContentUri != null && !this.ContentUri.Equals(input.ContentUri))) return false;

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
                if (this.VersionId != null) hashCode = hashCode * 59 + this.VersionId.GetHashCode();
                if (this.VersionNum != null) hashCode = hashCode * 59 + this.VersionNum.GetHashCode();
                if (this.ContentUri != null) hashCode = hashCode * 59 + this.ContentUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
