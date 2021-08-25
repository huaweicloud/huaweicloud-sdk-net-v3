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
    /// Response Object
    /// </summary>
    public class DetectFaceByBase64Response : SdkResponse
    {

        /// <summary>
        /// 检测到的人脸。 调用失败时无此字段。
        /// </summary>
        [JsonProperty("faces", NullValueHandling = NullValueHandling.Ignore)]
        public List<DetectFace> Faces { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectFaceByBase64Response {\n");
            sb.Append("  faces: ").Append(Faces).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetectFaceByBase64Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetectFaceByBase64Response input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.Faces != null)
                    hashCode = hashCode * 59 + this.Faces.GetHashCode();
                return hashCode;
            }
        }
    }
}
