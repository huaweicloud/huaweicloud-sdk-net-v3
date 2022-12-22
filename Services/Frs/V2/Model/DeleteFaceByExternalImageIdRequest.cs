using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteFaceByExternalImageIdRequest 
    {

        /// <summary>
        /// 人脸库名称。
        /// </summary>
        [SDKProperty("face_set_name", IsPath = true)]
        [JsonProperty("face_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceSetName { get; set; }

        /// <summary>
        /// external_image_id。
        /// </summary>
        [SDKProperty("external_image_id", IsQuery = true)]
        [JsonProperty("external_image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalImageId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteFaceByExternalImageIdRequest {\n");
            sb.Append("  faceSetName: ").Append(FaceSetName).Append("\n");
            sb.Append("  externalImageId: ").Append(ExternalImageId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteFaceByExternalImageIdRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteFaceByExternalImageIdRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FaceSetName == input.FaceSetName ||
                    (this.FaceSetName != null &&
                    this.FaceSetName.Equals(input.FaceSetName))
                ) && 
                (
                    this.ExternalImageId == input.ExternalImageId ||
                    (this.ExternalImageId != null &&
                    this.ExternalImageId.Equals(input.ExternalImageId))
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
                if (this.FaceSetName != null)
                    hashCode = hashCode * 59 + this.FaceSetName.GetHashCode();
                if (this.ExternalImageId != null)
                    hashCode = hashCode * 59 + this.ExternalImageId.GetHashCode();
                return hashCode;
            }
        }
    }
}
