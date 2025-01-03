using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Image.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RecaptureDetectReq 
    {

        /// <summary>
        /// 与url二选一  图像数据，base64编码，要求base64编码后大小不超过10MB，最短边至少15px，最长边最大4096px，支持JPG、PNG、BMP格式。 
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// 与image二选一  图片的URL路径，目前支持：  - 公网HTTP/HTTPS URL  - 华为云OBS提供的URL，使用OBS数据需要进行授权。包括对服务授权、临时授权、匿名公开授权。详请参见[配置OBS服务的访问权限](https://support.huaweicloud.com/api-image/image_03_0037.html)。  &gt; - 接口响应时间依赖于图片的下载时间，如果图片下载时间过长，会返回接口调用失败。 &gt; - 请保证被检测图片所在的存储服务稳定可靠，建议您使用华为云OBS存储。 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 判断图片真实或虚假的阈值，默认值为0.95，取值范围（0~1），输入非该范围内值算法即取默认值。
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public float? Threshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecaptureDetectReq {\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecaptureDetectReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecaptureDetectReq input)
        {
            if (input == null) return false;
            if (this.Image != input.Image || (this.Image != null && !this.Image.Equals(input.Image))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.Threshold != input.Threshold || (this.Threshold != null && !this.Threshold.Equals(input.Threshold))) return false;

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
                if (this.Image != null) hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Threshold != null) hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
