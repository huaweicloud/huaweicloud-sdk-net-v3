using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DetectFaceByFileIntlRequestBody 
    {

        /// <summary>
        /// 本地图片文件，图片不能超过8MB。上传文件时，请求格式为multipart。
        /// </summary>
        [JsonProperty("image_file", NullValueHandling = NullValueHandling.Ignore)]
        public System.IO.Stream ImageFile { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectFaceByFileIntlRequestBody {\n");
            sb.Append("  imageFile: ").Append(ImageFile).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetectFaceByFileIntlRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetectFaceByFileIntlRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageFile == input.ImageFile ||
                    (this.ImageFile != null &&
                    this.ImageFile.Equals(input.ImageFile))
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
                if (this.ImageFile != null)
                    hashCode = hashCode * 59 + this.ImageFile.GetHashCode();
                return hashCode;
            }
        }
    }
}
