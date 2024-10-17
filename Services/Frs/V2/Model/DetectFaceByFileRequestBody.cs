using System;
using System.Collections.Generic;
using System.IO;
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
    public class DetectFaceByFileRequestBody : IFormDataBody
    {

        /// <summary>
        /// 本地图片文件，图片不能超过8MB。上传文件时，请求格式为multipart。
        /// </summary>
        [JsonProperty("image_file", NullValueHandling = NullValueHandling.Ignore)]
        public FormDataFilePart ImageFile { get; set; }

        /// <summary>
        /// 是否返回人脸属性，希望获取的属性列表，多个属性间使用逗号（,）隔开。目前支持的属性有： • 1：性别 • 2：年龄 • 4：装束（帽子、眼镜） • 6：口罩 • 7：发型 • 8：胡须 • 11：图片类型 • 12：质量 • 13：表情 • 21：人脸图片旋转角（顺时针偏转角度），支持0°、90°、180°和270°图片旋转
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public string Attributes { get; set; }


        
        public DetectFaceByFileRequestBody WithImageFile(Stream stream, string filename)
        {
            this.ImageFile = new FormDataFilePart(stream, filename);
            return this;
        }

        public DetectFaceByFileRequestBody WithImageFile(Stream stream, string filename, string contentType)
        {
            this.ImageFile = new FormDataFilePart(stream, filename).WithContentType(contentType);
            return this;
        }
        

        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            formData.Add("image_file", ImageFile);
            if (Attributes != null) {
                formData.Add("attributes", new FormDataPart<string>(Attributes));
            }

            return formData;
        }

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
            if (input == null) return false;
            if (this.ImageFile != input.ImageFile || (this.ImageFile != null && !this.ImageFile.Equals(input.ImageFile))) return false;
            if (this.Attributes != input.Attributes || (this.Attributes != null && !this.Attributes.Equals(input.Attributes))) return false;

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
                if (this.ImageFile != null) hashCode = hashCode * 59 + this.ImageFile.GetHashCode();
                if (this.Attributes != null) hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                return hashCode;
            }
        }
    }
}
