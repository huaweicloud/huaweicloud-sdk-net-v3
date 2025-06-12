using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 自定义直播平台鉴权配置
    /// </summary>
    public class CustomPlatformAuthConfig 
    {

        /// <summary>
        /// 密钥Key。调用自定义直播平台时使用。 使用方式： 调用接口时，增加两个头域：x-hw-mss-time，x-hw-mss-secret * x-hw-mss-time：当前时间戳。Unix时间戳的十六进制结果。1分钟内有效。   示例： 66df9308（即2024.09.10 08:30:00） * x-hw-mss-secret：鉴权串。hmac_sha256(Key, URI（product_query_url,query参数按照Key的字典序排列）+ x-hw-mss-time)  示例： URL  https://api.example.com/v1/products?live_id&#x3D;111&amp;limit&#x3D;10&amp;offset&#x3D;0   Key：GCTbw44s6MPLh4GqgDpnfuFHgy25Enly   hwTime：66df9308   x-hw-mss-secret&#x3D;hmac_sha256(GCTbw44s6MPLh4GqgDpnfuFHgy25Enly,api.example.com/v1/products?limit&#x3D;10&amp;live_id&#x3D;111&amp;offset&#x3D;066df9308)&#x3D;5e7fe8869a12a87ea966d9edbc02e38cd4ce62c73b8b05c638f15835e78902d7   x-hw-mss-secret: 5e7fe8869a12a87ea966d9edbc02e38cd4ce62c73b8b05c638f15835e78902d7
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomPlatformAuthConfig {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomPlatformAuthConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomPlatformAuthConfig input)
        {
            if (input == null) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;

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
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                return hashCode;
            }
        }
    }
}
