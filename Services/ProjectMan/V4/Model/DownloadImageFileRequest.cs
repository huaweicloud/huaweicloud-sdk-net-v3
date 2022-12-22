using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DownloadImageFileRequest 
    {

        /// <summary>
        /// devcloud项目的32位id
        /// </summary>
        [SDKProperty("project_id", IsPath = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 图片URI
        /// </summary>
        [SDKProperty("image_uri", IsQuery = true)]
        [JsonProperty("image_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUri { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadImageFileRequest {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  imageUri: ").Append(ImageUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DownloadImageFileRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownloadImageFileRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ImageUri == input.ImageUri ||
                    (this.ImageUri != null &&
                    this.ImageUri.Equals(input.ImageUri))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ImageUri != null)
                    hashCode = hashCode * 59 + this.ImageUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
