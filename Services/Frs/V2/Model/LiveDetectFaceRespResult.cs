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
    /// 静默活体检测结果，LivelessDetectResult结构见表[结构格式说明表](https://support.huaweicloud.com/api-face/face_02_0102.html#face_02_0102__table112325301714)。 调用失败时无此字段。
    /// </summary>
    public class LiveDetectFaceRespResult 
    {

        /// <summary>
        /// 是否是活体。
        /// </summary>
        [JsonProperty("alive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Alive { get; set; }

        /// <summary>
        /// 置信度，取值范围0～1。
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public double? Confidence { get; set; }

        /// <summary>
        /// 检测出最大人脸的图片base64字符串。
        /// </summary>
        [JsonProperty("picture", NullValueHandling = NullValueHandling.Ignore)]
        public string Picture { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveDetectFaceRespResult {\n");
            sb.Append("  alive: ").Append(Alive).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("  picture: ").Append(Picture).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LiveDetectFaceRespResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LiveDetectFaceRespResult input)
        {
            if (input == null) return false;
            if (this.Alive != input.Alive || (this.Alive != null && !this.Alive.Equals(input.Alive))) return false;
            if (this.Confidence != input.Confidence || (this.Confidence != null && !this.Confidence.Equals(input.Confidence))) return false;
            if (this.Picture != input.Picture || (this.Picture != null && !this.Picture.Equals(input.Picture))) return false;

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
                if (this.Alive != null) hashCode = hashCode * 59 + this.Alive.GetHashCode();
                if (this.Confidence != null) hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.Picture != null) hashCode = hashCode * 59 + this.Picture.GetHashCode();
                return hashCode;
            }
        }
    }
}
