using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V2.Model
{
    /// <summary>
    /// 修改app回调请求
    /// </summary>
    public class AppCallbackUrlReq 
    {

        /// <summary>
        /// 回调通知url地址，url必须以http://或https://开头，需要支持POST调用。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 回调秘钥，主要用于鉴权
        /// </summary>
        [JsonProperty("auth_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppCallbackUrlReq {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  authKey: ").Append(AuthKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppCallbackUrlReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppCallbackUrlReq input)
        {
            if (input == null) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.AuthKey != input.AuthKey || (this.AuthKey != null && !this.AuthKey.Equals(input.AuthKey))) return false;

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
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.AuthKey != null) hashCode = hashCode * 59 + this.AuthKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
