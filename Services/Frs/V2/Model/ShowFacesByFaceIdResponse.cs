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
    public class ShowFacesByFaceIdResponse : SdkResponse
    {

        /// <summary>
        /// 人脸库ID，随机生成的包含八个字符的字符串。 调用失败时无此字段。
        /// </summary>
        [JsonProperty("face_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceSetId { get; set; }

        /// <summary>
        /// 人脸库名称。 调用失败时无此字段。
        /// </summary>
        [JsonProperty("face_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceSetName { get; set; }

        /// <summary>
        /// [人脸库当中的人脸结构，详见[FaceSetFace](https://support.huaweicloud.com/api-face/face_02_0018.html)。调用失败时无此字段。](tag:hc) [人脸库当中的人脸结构，详见[FaceSetFace](https://support.huaweicloud.com/intl/zh-cn/api-face/face_02_0018.html)。调用失败时无此字段。](tag:hk)
        /// </summary>
        [JsonProperty("faces", NullValueHandling = NullValueHandling.Ignore)]
        public List<FaceSetFace> Faces { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowFacesByFaceIdResponse {\n");
            sb.Append("  faceSetId: ").Append(FaceSetId).Append("\n");
            sb.Append("  faceSetName: ").Append(FaceSetName).Append("\n");
            sb.Append("  faces: ").Append(Faces).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowFacesByFaceIdResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowFacesByFaceIdResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FaceSetId == input.FaceSetId ||
                    (this.FaceSetId != null &&
                    this.FaceSetId.Equals(input.FaceSetId))
                ) && 
                (
                    this.FaceSetName == input.FaceSetName ||
                    (this.FaceSetName != null &&
                    this.FaceSetName.Equals(input.FaceSetName))
                ) && 
                (
                    this.Faces == input.Faces ||
                    this.Faces != null &&
                    input.Faces != null &&
                    this.Faces.SequenceEqual(input.Faces)
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
                if (this.FaceSetId != null)
                    hashCode = hashCode * 59 + this.FaceSetId.GetHashCode();
                if (this.FaceSetName != null)
                    hashCode = hashCode * 59 + this.FaceSetName.GetHashCode();
                if (this.Faces != null)
                    hashCode = hashCode * 59 + this.Faces.GetHashCode();
                return hashCode;
            }
        }
    }
}
