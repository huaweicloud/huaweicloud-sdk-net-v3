using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Image.V2.Model
{
    /// <summary>
    /// 图像合成视频服务推理参数
    /// </summary>
    public class ImageToVideoInference 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image_config", NullValueHandling = NullValueHandling.Ignore)]
        public ImageToVideoInfo ImageConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageToVideoInference {\n");
            sb.Append("  imageConfig: ").Append(ImageConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageToVideoInference);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageToVideoInference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageConfig == input.ImageConfig ||
                    (this.ImageConfig != null &&
                    this.ImageConfig.Equals(input.ImageConfig))
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
                if (this.ImageConfig != null)
                    hashCode = hashCode * 59 + this.ImageConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
