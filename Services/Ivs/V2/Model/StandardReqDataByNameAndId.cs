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
    public class StandardReqDataByNameAndId 
    {

        /// <summary>
        /// 被验证人的姓名。
        /// </summary>
        [JsonProperty("verification_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationName { get; set; }

        /// <summary>
        /// 被验证人的身份证号码。
        /// </summary>
        [JsonProperty("verification_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VerificationId { get; set; }

        /// <summary>
        /// 现场人像图像数据，使用base64编码，要求base64编码后大小不超过4M。图像各边的像素大小在300到4000之间，支持JPG格式。
        /// </summary>
        [JsonProperty("face_image", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceImage { get; set; }

        /// <summary>
        /// 响应参数similarity是否详细显示，默认为false。 - true表示响应中的similarity为0~1000的小数。 - false表示响应中的similarity为0~100的整数。
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Detail { get; set; }

        /// <summary>
        /// 是否允许对入参face_image进行人脸检测及图片裁剪，默认为true，表示允许。
        /// </summary>
        [JsonProperty("crop", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Crop { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StandardReqDataByNameAndId {\n");
            sb.Append("  verificationName: ").Append(VerificationName).Append("\n");
            sb.Append("  verificationId: ").Append(VerificationId).Append("\n");
            sb.Append("  faceImage: ").Append(FaceImage).Append("\n");
            sb.Append("  detail: ").Append(Detail).Append("\n");
            sb.Append("  crop: ").Append(Crop).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StandardReqDataByNameAndId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StandardReqDataByNameAndId input)
        {
            if (input == null) return false;
            if (this.VerificationName != input.VerificationName || (this.VerificationName != null && !this.VerificationName.Equals(input.VerificationName))) return false;
            if (this.VerificationId != input.VerificationId || (this.VerificationId != null && !this.VerificationId.Equals(input.VerificationId))) return false;
            if (this.FaceImage != input.FaceImage || (this.FaceImage != null && !this.FaceImage.Equals(input.FaceImage))) return false;
            if (this.Detail != input.Detail || (this.Detail != null && !this.Detail.Equals(input.Detail))) return false;
            if (this.Crop != input.Crop || (this.Crop != null && !this.Crop.Equals(input.Crop))) return false;

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
                if (this.VerificationName != null) hashCode = hashCode * 59 + this.VerificationName.GetHashCode();
                if (this.VerificationId != null) hashCode = hashCode * 59 + this.VerificationId.GetHashCode();
                if (this.FaceImage != null) hashCode = hashCode * 59 + this.FaceImage.GetHashCode();
                if (this.Detail != null) hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.Crop != null) hashCode = hashCode * 59 + this.Crop.GetHashCode();
                return hashCode;
            }
        }
    }
}
