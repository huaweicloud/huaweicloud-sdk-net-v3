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
    public class AddFacesUrlReq 
    {

        /// <summary>
        /// [图片的URL路径，目前仅支持华为云上OBS的URL，且人脸识别服务有权限读取该OBS桶的数据。开通读取权限的操作请参见[服务授权](https://support.huaweicloud.com/api-face/face_02_0006.html)。](tag:hc) [图片的URL路径，目前仅支持华为云上OBS的URL，且人脸识别服务有权限读取该OBS桶的数据。开通读取权限的操作请参见[服务授权](https://support.huaweicloud.com/intl/zh-cn/api-face/face_02_0006.html)。](tag:hk)
        /// </summary>
        [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 根据用户自定义数据类型，填入相应的数值。 创建faceset时定义该字段，Json字符串不校验重复性，参考[[自定义字段](https://support.huaweicloud.com/api-face/face_02_0012.html)。](tag:hc)[[自定义字段](https://support.huaweicloud.com/intl/zh-cn/api-face/face_02_0012.html)。](tag:hk)
        /// </summary>
        [JsonProperty("external_fields", NullValueHandling = NullValueHandling.Ignore)]
        public Object ExternalFields { get; set; }

        /// <summary>
        /// 用户指定的图片外部ID，与当前图像绑定。用户没提供，系统会生成一个。 该ID长度范围为1～36位，可以包含字母、数字、中划线或者下划线，不包含其他的特殊字符。
        /// </summary>
        [JsonProperty("external_image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalImageId { get; set; }

        /// <summary>
        /// 是否将图片中的最大人脸添加至人脸库。可选值包括: • true: 传入的单张图片中如果包含多张人脸，则只将最大人脸添加到人脸库中。 • false: 默认为false。传入的单张图片中如果包含多张人脸，则将所有人脸添加至人脸库中。
        /// </summary>
        [JsonProperty("single", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Single { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddFacesUrlReq {\n");
            sb.Append("  imageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  externalFields: ").Append(ExternalFields).Append("\n");
            sb.Append("  externalImageId: ").Append(ExternalImageId).Append("\n");
            sb.Append("  single: ").Append(Single).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddFacesUrlReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddFacesUrlReq input)
        {
            if (input == null) return false;
            if (this.ImageUrl != input.ImageUrl || (this.ImageUrl != null && !this.ImageUrl.Equals(input.ImageUrl))) return false;
            if (this.ExternalFields != input.ExternalFields || (this.ExternalFields != null && !this.ExternalFields.Equals(input.ExternalFields))) return false;
            if (this.ExternalImageId != input.ExternalImageId || (this.ExternalImageId != null && !this.ExternalImageId.Equals(input.ExternalImageId))) return false;
            if (this.Single != input.Single || (this.Single != null && !this.Single.Equals(input.Single))) return false;

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
                if (this.ExternalFields != null) hashCode = hashCode * 59 + this.ExternalFields.GetHashCode();
                if (this.ExternalImageId != null) hashCode = hashCode * 59 + this.ExternalImageId.GetHashCode();
                if (this.Single != null) hashCode = hashCode * 59 + this.Single.GetHashCode();
                return hashCode;
            }
        }
    }
}
