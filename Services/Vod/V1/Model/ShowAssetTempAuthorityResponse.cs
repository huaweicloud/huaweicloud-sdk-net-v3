using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAssetTempAuthorityResponse : SdkResponse
    {

        /// <summary>
        /// 带授权签名字符串的URL。具体调用示例请参见[示例2：媒资分段上传（20M以上）](https://support.huaweicloud.com/api-vod/vod_04_0216.html)。  示例：https://{obs_domain}/{bucket}?AWSAccessKeyId&#x3D;{AccessKeyID}&amp;Expires&#x3D;{ExpiresValue}&amp;Signature&#x3D;{Signature}
        /// </summary>
        [JsonProperty("sign_str", NullValueHandling = NullValueHandling.Ignore)]
        public string SignStr { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAssetTempAuthorityResponse {\n");
            sb.Append("  signStr: ").Append(SignStr).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAssetTempAuthorityResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAssetTempAuthorityResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SignStr == input.SignStr ||
                    (this.SignStr != null &&
                    this.SignStr.Equals(input.SignStr))
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
                if (this.SignStr != null)
                    hashCode = hashCode * 59 + this.SignStr.GetHashCode();
                return hashCode;
            }
        }
    }
}
