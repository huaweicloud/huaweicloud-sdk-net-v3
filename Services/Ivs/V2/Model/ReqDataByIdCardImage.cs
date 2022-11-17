using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ivs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ReqDataByIdCardImage 
    {

        /// <summary>
        /// 身份证人像面图像数据，使用base64编码，要求base64编码后大小不超过4M。图像各边的像素大小在300到4000之间，支持JPG格式。
        /// </summary>
        [JsonProperty("idcard_image1", NullValueHandling = NullValueHandling.Ignore)]
        public string IdcardImage1 { get; set; }

        /// <summary>
        /// 身份证国徽面图像数据，使用base64编码，要求base64编码后大小不超过4M。图像各边的像素大小在300到4000之间，支持JPG格式。
        /// </summary>
        [JsonProperty("idcard_image2", NullValueHandling = NullValueHandling.Ignore)]
        public string IdcardImage2 { get; set; }

        /// <summary>
        /// 现场人像图像数据，使用base64编码，要求base64编码后大小不超过4M。图像各边的像素大小在300到4000之间，支持JPG格式。
        /// </summary>
        [JsonProperty("face_image", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceImage { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReqDataByIdCardImage {\n");
            sb.Append("  idcardImage1: ").Append(IdcardImage1).Append("\n");
            sb.Append("  idcardImage2: ").Append(IdcardImage2).Append("\n");
            sb.Append("  faceImage: ").Append(FaceImage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReqDataByIdCardImage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReqDataByIdCardImage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdcardImage1 == input.IdcardImage1 ||
                    (this.IdcardImage1 != null &&
                    this.IdcardImage1.Equals(input.IdcardImage1))
                ) && 
                (
                    this.IdcardImage2 == input.IdcardImage2 ||
                    (this.IdcardImage2 != null &&
                    this.IdcardImage2.Equals(input.IdcardImage2))
                ) && 
                (
                    this.FaceImage == input.FaceImage ||
                    (this.FaceImage != null &&
                    this.FaceImage.Equals(input.FaceImage))
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
                if (this.IdcardImage1 != null)
                    hashCode = hashCode * 59 + this.IdcardImage1.GetHashCode();
                if (this.IdcardImage2 != null)
                    hashCode = hashCode * 59 + this.IdcardImage2.GetHashCode();
                if (this.FaceImage != null)
                    hashCode = hashCode * 59 + this.FaceImage.GetHashCode();
                return hashCode;
            }
        }
    }
}
