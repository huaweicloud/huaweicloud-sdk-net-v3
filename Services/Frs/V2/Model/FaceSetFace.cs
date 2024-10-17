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
    /// 
    /// </summary>
    public class FaceSetFace 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bounding_box", NullValueHandling = NullValueHandling.Ignore)]
        public BoundingBox BoundingBox { get; set; }

        /// <summary>
        /// 用户添加的额外字段。
        /// </summary>
        [JsonProperty("external_fields", NullValueHandling = NullValueHandling.Ignore)]
        public Object ExternalFields { get; set; }

        /// <summary>
        /// 人脸所在的外部图片ID。
        /// </summary>
        [JsonProperty("external_image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalImageId { get; set; }

        /// <summary>
        /// 人脸ID，由系统内部生成的唯一ID。
        /// </summary>
        [JsonProperty("face_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FaceSetFace {\n");
            sb.Append("  boundingBox: ").Append(BoundingBox).Append("\n");
            sb.Append("  externalFields: ").Append(ExternalFields).Append("\n");
            sb.Append("  externalImageId: ").Append(ExternalImageId).Append("\n");
            sb.Append("  faceId: ").Append(FaceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FaceSetFace);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FaceSetFace input)
        {
            if (input == null) return false;
            if (this.BoundingBox != input.BoundingBox || (this.BoundingBox != null && !this.BoundingBox.Equals(input.BoundingBox))) return false;
            if (this.ExternalFields != input.ExternalFields || (this.ExternalFields != null && !this.ExternalFields.Equals(input.ExternalFields))) return false;
            if (this.ExternalImageId != input.ExternalImageId || (this.ExternalImageId != null && !this.ExternalImageId.Equals(input.ExternalImageId))) return false;
            if (this.FaceId != input.FaceId || (this.FaceId != null && !this.FaceId.Equals(input.FaceId))) return false;

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
                if (this.BoundingBox != null) hashCode = hashCode * 59 + this.BoundingBox.GetHashCode();
                if (this.ExternalFields != null) hashCode = hashCode * 59 + this.ExternalFields.GetHashCode();
                if (this.ExternalImageId != null) hashCode = hashCode * 59 + this.ExternalImageId.GetHashCode();
                if (this.FaceId != null) hashCode = hashCode * 59 + this.FaceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
