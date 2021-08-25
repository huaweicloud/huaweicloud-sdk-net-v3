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
    public class AddFacesByFileRequestBody 
    {

        /// <summary>
        /// 本地图片文件，图片不能超过8MB，建议小于1MB。上传文件时，请求格式为multipart。
        /// </summary>
        [JsonProperty("image_file", NullValueHandling = NullValueHandling.Ignore)]
        public System.IO.Stream ImageFile { get; set; }

        /// <summary>
        /// 用户指定的图片外部ID，与当前图像绑定。用户没提供，系统会生成一个。 该ID长度范围为1～36位，可以包含字母、数字、中划线或者下划线，不包含其他的特殊字符。
        /// </summary>
        [JsonProperty("external_image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalImageId { get; set; }

        /// <summary>
        /// 根据用户自定义数据类型，填入相应的数值。 创建faceset时定义该字段，Json字符串不校验重复性，参考[自定义字段](zh-cn_topic_0130807044.xml)。
        /// </summary>
        [JsonProperty("external_fields", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalFields { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddFacesByFileRequestBody {\n");
            sb.Append("  imageFile: ").Append(ImageFile).Append("\n");
            sb.Append("  externalImageId: ").Append(ExternalImageId).Append("\n");
            sb.Append("  externalFields: ").Append(ExternalFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddFacesByFileRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddFacesByFileRequestBody input)
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
                    this.ExternalImageId == input.ExternalImageId ||
                    (this.ExternalImageId != null &&
                    this.ExternalImageId.Equals(input.ExternalImageId))
                ) && 
                (
                    this.ExternalFields == input.ExternalFields ||
                    (this.ExternalFields != null &&
                    this.ExternalFields.Equals(input.ExternalFields))
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
                if (this.ExternalImageId != null)
                    hashCode = hashCode * 59 + this.ExternalImageId.GetHashCode();
                if (this.ExternalFields != null)
                    hashCode = hashCode * 59 + this.ExternalFields.GetHashCode();
                return hashCode;
            }
        }
    }
}
