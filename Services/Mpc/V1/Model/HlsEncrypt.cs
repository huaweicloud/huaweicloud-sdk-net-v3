using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class HlsEncrypt 
    {

        /// <summary>
        /// 内容加密秘钥 
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 秘钥获取服务的地址 
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 初始向量，base64binary，随机数 
        /// </summary>
        [JsonProperty("iv", NullValueHandling = NullValueHandling.Ignore)]
        public string Iv { get; set; }

        /// <summary>
        /// 加密算法。 - AES-128-CTR - AES-128-CBC - SM4CBC  默认值：AES-128-CTR 
        /// </summary>
        [JsonProperty("algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string Algorithm { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HlsEncrypt {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  iv: ").Append(Iv).Append("\n");
            sb.Append("  algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HlsEncrypt);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HlsEncrypt input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Iv == input.Iv ||
                    (this.Iv != null &&
                    this.Iv.Equals(input.Iv))
                ) && 
                (
                    this.Algorithm == input.Algorithm ||
                    (this.Algorithm != null &&
                    this.Algorithm.Equals(input.Algorithm))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Iv != null)
                    hashCode = hashCode * 59 + this.Iv.GetHashCode();
                if (this.Algorithm != null)
                    hashCode = hashCode * 59 + this.Algorithm.GetHashCode();
                return hashCode;
            }
        }
    }
}
