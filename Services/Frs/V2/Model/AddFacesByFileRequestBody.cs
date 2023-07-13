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
    public class AddFacesByFileRequestBody : IFormDataBody
    {

        /// <summary>
        /// 本地图片文件，图片不能超过8MB，建议小于1MB。上传文件时，请求格式为multipart。
        /// </summary>
        [JsonProperty("image_file", NullValueHandling = NullValueHandling.Ignore)]
        public FormDataFilePart ImageFile { get; set; }

        /// <summary>
        /// 用户指定的图片外部ID，与当前图像绑定。用户没提供，系统会生成一个。 该ID长度范围为1～36位，可以包含字母、数字、中划线或者下划线，不包含其他的特殊字符。
        /// </summary>
        [JsonProperty("external_image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalImageId { get; set; }

        /// <summary>
        /// [根据用户自定义数据类型，填入相应的数值。创建faceset时定义该字段，Json字符串不校验重复性，参考[自定义字段](https://support.huaweicloud.com/api-face/face_02_0012.html)。](tag:hc) [根据用户自定义数据类型，填入相应的数值。创建faceset时定义该字段，Json字符串不校验重复性，参考[自定义字段](https://support.huaweicloud.com/intl/zh-cn/api-face/face_02_0012.html)。](tag:hk)
        /// </summary>
        [JsonProperty("external_fields", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalFields { get; set; }

        /// <summary>
        /// 是否将图片中的最大人脸添加至人脸库。可选值包括: • true: 传入的单张图片中如果包含多张人脸，则只将最大人脸添加到人脸库中。 • false: 默认为false。传入的单张图片中如果包含多张人脸，则将所有人脸添加至人脸库中。
        /// </summary>
        [JsonProperty("single", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Single { get; set; }


        
        public AddFacesByFileRequestBody WithImageFile(Stream stream, string filename)
        {
            this.ImageFile = new FormDataFilePart(stream, filename);
            return this;
        }

        public AddFacesByFileRequestBody WithImageFile(Stream stream, string filename, string contentType)
        {
            this.ImageFile = new FormDataFilePart(stream, filename).WithContentType(contentType);
            return this;
        }
        

        public Dictionary<string, object> BuildFormData()
        {
            var formData = new Dictionary<string, object>();

            formData.Add("image_file", ImageFile);
            if (ExternalImageId != null) {
                formData.Add("external_image_id", new FormDataPart<string>(ExternalImageId));
            }
            if (ExternalFields != null) {
                formData.Add("external_fields", new FormDataPart<string>(ExternalFields));
            }
            if (Single != null) {
                formData.Add("single", new FormDataPart<bool?>(Single));
            }

            return formData;
        }

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
            sb.Append("  single: ").Append(Single).Append("\n");
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
                ) && 
                (
                    this.Single == input.Single ||
                    (this.Single != null &&
                    this.Single.Equals(input.Single))
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
                if (this.Single != null)
                    hashCode = hashCode * 59 + this.Single.GetHashCode();
                return hashCode;
            }
        }
    }
}
