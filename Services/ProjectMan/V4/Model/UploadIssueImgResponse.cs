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
    /// Response Object
    /// </summary>
    public class UploadIssueImgResponse : SdkResponse
    {

        /// <summary>
        /// 图片id
        /// </summary>
        [JsonProperty("img_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImgId { get; set; }

        /// <summary>
        /// 图片url v1改成v3作为下载图片请求
        /// </summary>
        [JsonProperty("img_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImgUrl { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadIssueImgResponse {\n");
            sb.Append("  imgId: ").Append(ImgId).Append("\n");
            sb.Append("  imgUrl: ").Append(ImgUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadIssueImgResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadIssueImgResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImgId == input.ImgId ||
                    (this.ImgId != null &&
                    this.ImgId.Equals(input.ImgId))
                ) && 
                (
                    this.ImgUrl == input.ImgUrl ||
                    (this.ImgUrl != null &&
                    this.ImgUrl.Equals(input.ImgUrl))
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
                if (this.ImgId != null)
                    hashCode = hashCode * 59 + this.ImgId.GetHashCode();
                if (this.ImgUrl != null)
                    hashCode = hashCode * 59 + this.ImgUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
