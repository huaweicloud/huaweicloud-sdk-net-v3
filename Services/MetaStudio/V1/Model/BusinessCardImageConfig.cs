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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessCardImageConfig {\n");
            sb.Append("  humanImage: ").Append(HumanImage).Append("\n");
            sb.Append("  logoImage: ").Append(LogoImage).Append("\n");
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
                return hashCode;
            }
        }
    }
}
