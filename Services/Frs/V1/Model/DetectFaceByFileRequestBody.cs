using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DetectFaceByFileRequestBody 
    {

        /// <summary>
        /// 本地图片文件，图片不能超过8MB，建议小于1MB。上传文件时，请求格式为multipart。
        /// </summary>
        [JsonProperty("image_file", NullValueHandling = NullValueHandling.Ignore)]
        public System.IO.Stream ImageFile { get; set; }

        /// <summary>
        /// 是否返回人脸属性，希望获取的属性列表，多个属性间使用逗号（,）隔开。目前支持的属性有： • 0：人脸姿态 • 1：性别 • 2：年龄 • 3：人脸关键点 • 4：装束（帽子、眼镜） • 5：笑脸
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public string Attributes { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetectFaceByFileRequestBody {\n");
            sb.Append("  imageFile: ").Append(ImageFile).Append("\n");
            sb.Append("  attributes: ").Append(Attributes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetectFaceByFileRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetectFaceByFileRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImageFile == input.ImageFile ||
                    (this.ImageFile != null &&
                    this.ImageFile.Equals(input.ImageFile))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
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
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                return hashCode;
            }
        }
    }
}
