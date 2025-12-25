using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 用户上传的用于制作数字人名片的图片。
    /// </summary>
    public class BusinessCardImageConfig 
    {

        /// <summary>
        /// 人物照片，需要Base64编码。
        /// </summary>
        [JsonProperty("human_image", NullValueHandling = NullValueHandling.Ignore)]
        public string HumanImage { get; set; }

        /// <summary>
        /// Logo图片，需要Base64编码。
        /// </summary>
        [JsonProperty("logo_image", NullValueHandling = NullValueHandling.Ignore)]
        public string LogoImage { get; set; }

        /// <summary>
        /// 身份证国徽面照片，需要Base64编码。
        /// </summary>
        [JsonProperty("id_card_image1", NullValueHandling = NullValueHandling.Ignore)]
        public string IdCardImage1 { get; set; }

        /// <summary>
        /// 身份证人像面照片，需要Base64编码。
        /// </summary>
        [JsonProperty("id_card_image2", NullValueHandling = NullValueHandling.Ignore)]
        public string IdCardImage2 { get; set; }

        /// <summary>
        /// 授权使用照片
        /// </summary>
        [JsonProperty("authorize_use_human_image", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AuthorizeUseHumanImage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessCardImageConfig {\n");
            sb.Append("  humanImage: ").Append(HumanImage).Append("\n");
            sb.Append("  logoImage: ").Append(LogoImage).Append("\n");
            sb.Append("  idCardImage1: ").Append(IdCardImage1).Append("\n");
            sb.Append("  idCardImage2: ").Append(IdCardImage2).Append("\n");
            sb.Append("  authorizeUseHumanImage: ").Append(AuthorizeUseHumanImage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BusinessCardImageConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BusinessCardImageConfig input)
        {
            if (input == null) return false;
            if (this.HumanImage != input.HumanImage || (this.HumanImage != null && !this.HumanImage.Equals(input.HumanImage))) return false;
            if (this.LogoImage != input.LogoImage || (this.LogoImage != null && !this.LogoImage.Equals(input.LogoImage))) return false;
            if (this.IdCardImage1 != input.IdCardImage1 || (this.IdCardImage1 != null && !this.IdCardImage1.Equals(input.IdCardImage1))) return false;
            if (this.IdCardImage2 != input.IdCardImage2 || (this.IdCardImage2 != null && !this.IdCardImage2.Equals(input.IdCardImage2))) return false;
            if (this.AuthorizeUseHumanImage != input.AuthorizeUseHumanImage || (this.AuthorizeUseHumanImage != null && !this.AuthorizeUseHumanImage.Equals(input.AuthorizeUseHumanImage))) return false;

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
                if (this.HumanImage != null) hashCode = hashCode * 59 + this.HumanImage.GetHashCode();
                if (this.LogoImage != null) hashCode = hashCode * 59 + this.LogoImage.GetHashCode();
                if (this.IdCardImage1 != null) hashCode = hashCode * 59 + this.IdCardImage1.GetHashCode();
                if (this.IdCardImage2 != null) hashCode = hashCode * 59 + this.IdCardImage2.GetHashCode();
                if (this.AuthorizeUseHumanImage != null) hashCode = hashCode * 59 + this.AuthorizeUseHumanImage.GetHashCode();
                return hashCode;
            }
        }
    }
}
