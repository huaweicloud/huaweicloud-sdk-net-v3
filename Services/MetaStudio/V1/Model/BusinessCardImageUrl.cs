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
    /// 用于制作数字人名片的图片下载URL。
    /// </summary>
    public class BusinessCardImageUrl 
    {

        /// <summary>
        /// 任务照片下载URL。
        /// </summary>
        [JsonProperty("human_image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string HumanImageUrl { get; set; }

        /// <summary>
        /// Logo图片下载URL。
        /// </summary>
        [JsonProperty("logo_image", NullValueHandling = NullValueHandling.Ignore)]
        public string LogoImage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessCardImageUrl {\n");
            sb.Append("  humanImageUrl: ").Append(HumanImageUrl).Append("\n");
            sb.Append("  logoImage: ").Append(LogoImage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BusinessCardImageUrl);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BusinessCardImageUrl input)
        {
            if (input == null) return false;
            if (this.HumanImageUrl != input.HumanImageUrl || (this.HumanImageUrl != null && !this.HumanImageUrl.Equals(input.HumanImageUrl))) return false;
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
                if (this.HumanImageUrl != null) hashCode = hashCode * 59 + this.HumanImageUrl.GetHashCode();
                if (this.LogoImage != null) hashCode = hashCode * 59 + this.LogoImage.GetHashCode();
                return hashCode;
            }
        }
    }
}
