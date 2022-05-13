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
    public class UpdateFaceReq 
    {

        /// <summary>
        /// [Json字符串不校验重复性，自定义字段的key值长度范围为[1,36]，string类型的value长度范围为[1,256]，具体参见[自定义字段](https://support.huaweicloud.com/api-face/face_02_0012.html)。 这里是待修改的参数，external_image_id和external_fields至少选一个。](tag:hc) [Json字符串不校验重复性，自定义字段的key值长度范围为[1,36]，string类型的value长度范围为[1,256]，具体参见[自定义字段](https://support.huaweicloud.com/intl/zh-cn/api-face/face_02_0012.html)。 这里是待修改的参数，external_image_id和external_fields至少选一个。](tag:hk)
        /// </summary>
        [JsonProperty("external_fields", NullValueHandling = NullValueHandling.Ignore)]
        public Object ExternalFields { get; set; }

        /// <summary>
        /// 用户指定的图片外部ID，与当前图像绑定。用户没提供，系统会生成一个。该ID长度范围为1～36位，可以包含字母、数字、中划线或者下划线，不包含其他的特殊字符。 这里是待修改的参数，external_image_id和external_fields至少选一个。
        /// </summary>
        [JsonProperty("external_image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalImageId { get; set; }

        /// <summary>
        /// 人脸库ID，由系统内部生成的唯一ID。
        /// </summary>
        [JsonProperty("face_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFaceReq {\n");
            sb.Append("  externalFields: ").Append(ExternalFields).Append("\n");
            sb.Append("  externalImageId: ").Append(ExternalImageId).Append("\n");
            sb.Append("  faceId: ").Append(FaceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateFaceReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateFaceReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalFields == input.ExternalFields ||
                    (this.ExternalFields != null &&
                    this.ExternalFields.Equals(input.ExternalFields))
                ) && 
                (
                    this.ExternalImageId == input.ExternalImageId ||
                    (this.ExternalImageId != null &&
                    this.ExternalImageId.Equals(input.ExternalImageId))
                ) && 
                (
                    this.FaceId == input.FaceId ||
                    (this.FaceId != null &&
                    this.FaceId.Equals(input.FaceId))
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
                if (this.ExternalFields != null)
                    hashCode = hashCode * 59 + this.ExternalFields.GetHashCode();
                if (this.ExternalImageId != null)
                    hashCode = hashCode * 59 + this.ExternalImageId.GetHashCode();
                if (this.FaceId != null)
                    hashCode = hashCode * 59 + this.FaceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
