using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteFaceByFaceIdRequest 
    {

        /// <summary>
        /// 人脸库名称。
        /// </summary>
        [SDKProperty("face_set_name", IsPath = true)]
        [JsonProperty("face_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceSetName { get; set; }

        /// <summary>
        /// 人脸ID。
        /// </summary>
        [SDKProperty("face_id", IsQuery = true)]
        [JsonProperty("face_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteFaceByFaceIdRequest {\n");
            sb.Append("  faceSetName: ").Append(FaceSetName).Append("\n");
            sb.Append("  faceId: ").Append(FaceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteFaceByFaceIdRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteFaceByFaceIdRequest input)
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
                    this.FaceId == input.FaceId ||
                    (this.FaceId != null &&
                    this.FaceId.Equals(input.FaceId))
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
                if (this.FaceId != null)
                    hashCode = hashCode * 59 + this.FaceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
