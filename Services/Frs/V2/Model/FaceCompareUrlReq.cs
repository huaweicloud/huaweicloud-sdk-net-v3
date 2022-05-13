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
    public class FaceCompareUrlReq 
    {

        /// <summary>
        /// [图片的URL路径，目前仅支持华为云上OBS的URL，且人脸识别服务有权限读取该OBS桶的数据。 开通读取权限的操作请参见[服务授权](https://support.huaweicloud.com/api-face/face_02_0006.html)。  与image1_file、image1_base64三选一 ](tag:hc) [图片的URL路径，目前仅支持华为云上OBS的URL，且人脸识别服务有权限读取该OBS桶的数据。 开通读取权限的操作请参见[服务授权](https://support.huaweicloud.com/intl/zh-cn/api-face/face_02_0006.html)。  与image1_file、image1_base64三选一 ](tag:hk)
        /// </summary>
        [JsonProperty("image1_url", NullValueHandling = NullValueHandling.Ignore)]
        public string Image1Url { get; set; }

        /// <summary>
        /// [图片的URL路径，目前仅支持华为云上OBS的URL，且人脸识别服务有权限读取该OBS桶的数据。 开通读取权限的操作请参见[服务授权](https://support.huaweicloud.com/api-face/face_02_0006.html)。  与image2_file、image2_base64三选一](tag:hc) [图片的URL路径，目前仅支持华为云上OBS的URL，且人脸识别服务有权限读取该OBS桶的数据。 开通读取权限的操作请参见[服务授权](https://support.huaweicloud.com/intl/zh-cn/api-face/face_02_0006.html)。  与image2_file、image2_base64三选一](tag:hk)
        /// </summary>
        [JsonProperty("image2_url", NullValueHandling = NullValueHandling.Ignore)]
        public string Image2Url { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FaceCompareUrlReq {\n");
            sb.Append("  image1Url: ").Append(Image1Url).Append("\n");
            sb.Append("  image2Url: ").Append(Image2Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FaceCompareUrlReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FaceCompareUrlReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Image1Url == input.Image1Url ||
                    (this.Image1Url != null &&
                    this.Image1Url.Equals(input.Image1Url))
                ) && 
                (
                    this.Image2Url == input.Image2Url ||
                    (this.Image2Url != null &&
                    this.Image2Url.Equals(input.Image2Url))
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
                if (this.Image1Url != null)
                    hashCode = hashCode * 59 + this.Image1Url.GetHashCode();
                if (this.Image2Url != null)
                    hashCode = hashCode * 59 + this.Image2Url.GetHashCode();
                return hashCode;
            }
        }
    }
}
