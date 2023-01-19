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
    public class CreateFaceSetReq 
    {

        /// <summary>
        /// 用户自定义数据，自定义字段不能以系统保留字段vector、bounding_box、external_image_id、face_id、create_time、_id、_all、_source等字段命名。Json字符串不校验重复性，自定义字段的key值长度范围为[1,36]，string类型的value长度范围为[1,256]，具体参见[[自定义字段](https://support.huaweicloud.com/api-face/face_02_0012.html)。](tag:hc) [[自定义字段](https://support.huaweicloud.com/intl/zh-cn/api-face/face_02_0012.html)。](tag:hk)
        /// </summary>
        [JsonProperty("external_fields", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, TypeInfo> ExternalFields { get; set; }

        /// <summary>
        /// 人脸库名称。 建议人脸库的名称不要以下划线（_）开头，否则云监控服务会无法采集人脸数量。
        /// </summary>
        [JsonProperty("face_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FaceSetName { get; set; }

        /// <summary>
        /// 人脸库最大的容量，填写1万整数倍的数字，例如：30000。 默认为100000，最大值为100000，可通过创建新的人脸库进行扩容，每个用户可免费默认使用10个人脸库，每个人脸库容量为10万个人脸特征。如需扩容单个人脸库规模，请联系华为云客服确认扩容规模与价格。
        /// </summary>
        [JsonProperty("face_set_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public int? FaceSetCapacity { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFaceSetReq {\n");
            sb.Append("  externalFields: ").Append(ExternalFields).Append("\n");
            sb.Append("  faceSetName: ").Append(FaceSetName).Append("\n");
            sb.Append("  faceSetCapacity: ").Append(FaceSetCapacity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFaceSetReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateFaceSetReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalFields == input.ExternalFields ||
                    this.ExternalFields != null &&
                    input.ExternalFields != null &&
                    this.ExternalFields.SequenceEqual(input.ExternalFields)
                ) && 
                (
                    this.FaceSetName == input.FaceSetName ||
                    (this.FaceSetName != null &&
                    this.FaceSetName.Equals(input.FaceSetName))
                ) && 
                (
                    this.FaceSetCapacity == input.FaceSetCapacity ||
                    (this.FaceSetCapacity != null &&
                    this.FaceSetCapacity.Equals(input.FaceSetCapacity))
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
                if (this.FaceSetName != null)
                    hashCode = hashCode * 59 + this.FaceSetName.GetHashCode();
                if (this.FaceSetCapacity != null)
                    hashCode = hashCode * 59 + this.FaceSetCapacity.GetHashCode();
                return hashCode;
            }
        }
    }
}
