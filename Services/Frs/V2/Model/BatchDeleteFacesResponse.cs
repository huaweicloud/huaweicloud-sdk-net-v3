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
    /// Response Object
    /// </summary>
    public class BatchDeleteFacesResponse : SdkResponse
    {

        /// <summary>
        /// 删除的人脸数量。 调用失败时无此字段。
        /// </summary>
        [JsonProperty("face_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? FaceNumber { get; set; }

        /// <summary>
        /// 人脸库ID。 调用失败时无此字段。
        /// </summary>
        [JsonProperty("face_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceSetId { get; set; }

        /// <summary>
        /// 人脸库名称。 调用失败时无此字段。
        /// </summary>
        [JsonProperty("face_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceSetName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteFacesResponse {\n");
            sb.Append("  faceNumber: ").Append(FaceNumber).Append("\n");
            sb.Append("  faceSetId: ").Append(FaceSetId).Append("\n");
            sb.Append("  faceSetName: ").Append(FaceSetName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteFacesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteFacesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FaceNumber == input.FaceNumber ||
                    (this.FaceNumber != null &&
                    this.FaceNumber.Equals(input.FaceNumber))
                ) && 
                (
                    this.FaceSetId == input.FaceSetId ||
                    (this.FaceSetId != null &&
                    this.FaceSetId.Equals(input.FaceSetId))
                ) && 
                (
                    this.FaceSetName == input.FaceSetName ||
                    (this.FaceSetName != null &&
                    this.FaceSetName.Equals(input.FaceSetName))
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
                if (this.FaceNumber != null)
                    hashCode = hashCode * 59 + this.FaceNumber.GetHashCode();
                if (this.FaceSetId != null)
                    hashCode = hashCode * 59 + this.FaceSetId.GetHashCode();
                if (this.FaceSetName != null)
                    hashCode = hashCode * 59 + this.FaceSetName.GetHashCode();
                return hashCode;
            }
        }
    }
}
