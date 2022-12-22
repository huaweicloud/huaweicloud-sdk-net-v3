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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StandardReqDataByNameAndId {\n");
            sb.Append("  verificationName: ").Append(VerificationName).Append("\n");
            sb.Append("  verificationId: ").Append(VerificationId).Append("\n");
            sb.Append("  faceImage: ").Append(FaceImage).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.VerificationName == input.VerificationName ||
                    (this.VerificationName != null &&
                    this.VerificationName.Equals(input.VerificationName))
                ) && 
                (
                    this.VerificationId == input.VerificationId ||
                    (this.VerificationId != null &&
                    this.VerificationId.Equals(input.VerificationId))
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
                if (this.VerificationName != null)
                    hashCode = hashCode * 59 + this.VerificationName.GetHashCode();
                if (this.VerificationId != null)
                    hashCode = hashCode * 59 + this.VerificationId.GetHashCode();
                if (this.FaceImage != null)
                    hashCode = hashCode * 59 + this.FaceImage.GetHashCode();
                return hashCode;
            }
        }
    }
}
