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
    public class CompareFaceByBase64Response : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image1_face", NullValueHandling = NullValueHandling.Ignore)]
        public CompareFace Image1Face { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image2_face", NullValueHandling = NullValueHandling.Ignore)]
        public CompareFace Image2Face { get; set; }

        /// <summary>
        /// 人脸相似度，1表示最大，0表示最小，值越大表示越相似。一般情况下超过0.93即可认为是同一个人。 调用失败时无此字段。
        /// </summary>
        [JsonProperty("similarity", NullValueHandling = NullValueHandling.Ignore)]
        public double? Similarity { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompareFaceByBase64Response {\n");
            sb.Append("  image1Face: ").Append(Image1Face).Append("\n");
            sb.Append("  image2Face: ").Append(Image2Face).Append("\n");
            sb.Append("  similarity: ").Append(Similarity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompareFaceByBase64Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CompareFaceByBase64Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Image1Face == input.Image1Face ||
                    (this.Image1Face != null &&
                    this.Image1Face.Equals(input.Image1Face))
                ) && 
                (
                    this.Image2Face == input.Image2Face ||
                    (this.Image2Face != null &&
                    this.Image2Face.Equals(input.Image2Face))
                ) && 
                (
                    this.Similarity == input.Similarity ||
                    (this.Similarity != null &&
                    this.Similarity.Equals(input.Similarity))
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
                if (this.Image1Face != null)
                    hashCode = hashCode * 59 + this.Image1Face.GetHashCode();
                if (this.Image2Face != null)
                    hashCode = hashCode * 59 + this.Image2Face.GetHashCode();
                if (this.Similarity != null)
                    hashCode = hashCode * 59 + this.Similarity.GetHashCode();
                return hashCode;
            }
        }
    }
}
