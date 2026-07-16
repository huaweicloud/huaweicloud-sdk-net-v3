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
    /// Gallery 订阅信息。
    /// </summary>
    public class WorkflowGallerySubscription 
    {

        /// <summary>
        /// 资产ID。
        /// </summary>
        [JsonProperty("content_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentId { get; set; }

        /// <summary>
        /// 版本ID。
        /// </summary>
        [JsonProperty("version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionId { get; set; }

        /// <summary>
        /// 超期时间。
        /// </summary>
        [JsonProperty("expired_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiredAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowGallerySubscription {\n");
            sb.Append("  contentId: ").Append(ContentId).Append("\n");
            sb.Append("  versionId: ").Append(VersionId).Append("\n");
            sb.Append("  expiredAt: ").Append(ExpiredAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowGallerySubscription);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowGallerySubscription input)
        {
            if (input == null) return false;
            if (this.ContentId != input.ContentId || (this.ContentId != null && !this.ContentId.Equals(input.ContentId))) return false;
            if (this.VersionId != input.VersionId || (this.VersionId != null && !this.VersionId.Equals(input.VersionId))) return false;
            if (this.ExpiredAt != input.ExpiredAt || (this.ExpiredAt != null && !this.ExpiredAt.Equals(input.ExpiredAt))) return false;

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
                if (this.ExpiredAt != null) hashCode = hashCode * 59 + this.ExpiredAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
