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
    /// 素材图片图层配置。
    /// </summary>
    public class ImageLayerConfig 
    {

        /// <summary>
        /// **参数解释**： 图片文件的URL。 **约束限制**： * 仅直播支持外部URL，其他业务通过资产库查询获取，不支持外部URL。 **取值范围**： 字符长度1-2048位。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageLayerConfig {\n");
            sb.Append("  imageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageLayerConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageLayerConfig input)
        {
            if (input == null) return false;
            if (this.ImageUrl != input.ImageUrl || (this.ImageUrl != null && !this.ImageUrl.Equals(input.ImageUrl))) return false;

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
                if (this.ImageUrl != null) hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
