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
    /// [活体检测结果，VideoDetectResult结构见[VideoDetectResult](https://support.huaweicloud.com/api-face/face_02_0010.html)。调用失败时无此字段。](tag:hc) [活体检测结果，VideoDetectResult结构见[VideoDetectResult](https://support.huaweicloud.com/intl/zh-cn/api-face/face_02_0010.html)。调用失败时无此字段。](tag:hk)
    /// </summary>
    public class LiveDetectRespVideoresult 
    {

        /// <summary>
        /// 是否是活体。
        /// </summary>
        [JsonProperty("alive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Alive { get; set; }

        /// <summary>
        /// 动作列表。
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ActionsList> Actions { get; set; }

        /// <summary>
        /// 检测出最大人脸的图片base64。
        /// </summary>
        [JsonProperty("picture", NullValueHandling = NullValueHandling.Ignore)]
        public string Picture { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveDetectRespVideoresult {\n");
            sb.Append("  alive: ").Append(Alive).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("  picture: ").Append(Picture).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LiveDetectRespVideoresult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LiveDetectRespVideoresult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Alive == input.Alive ||
                    (this.Alive != null &&
                    this.Alive.Equals(input.Alive))
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.Picture == input.Picture ||
                    (this.Picture != null &&
                    this.Picture.Equals(input.Picture))
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
                if (this.Alive != null)
                    hashCode = hashCode * 59 + this.Alive.GetHashCode();
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.Picture != null)
                    hashCode = hashCode * 59 + this.Picture.GetHashCode();
                return hashCode;
            }
        }
    }
}
