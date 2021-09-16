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
    public class SearchFaceByFileResponse : SdkResponse
    {

        /// <summary>
        /// 查找的人脸集合，详见[SearchFace](https://support.huaweicloud.com/api-face/face_02_0019.html)。 调用失败时无此字段。
        /// </summary>
        [JsonProperty("faces", NullValueHandling = NullValueHandling.Ignore)]
        public List<SearchFace> Faces { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchFaceByFileResponse {\n");
            sb.Append("  faces: ").Append(Faces).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchFaceByFileResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchFaceByFileResponse input)
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
