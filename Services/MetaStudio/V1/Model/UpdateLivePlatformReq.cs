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
    /// 自定义直播平台创建请求
    /// </summary>
    public class UpdateLivePlatformReq 
    {

        /// <summary>
        /// 直播平台名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auth_config", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateCustomPlatformAuthConfig AuthConfig { get; set; }

        /// <summary>
        /// 自定义直播平台回调配置。同一种类型仅保留一个配置，如果配置多个会随机保存一个。
        /// </summary>
        [JsonProperty("callback_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<StandardPlatformApiConfig> CallbackConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLivePlatformReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  authConfig: ").Append(AuthConfig).Append("\n");
            sb.Append("  callbackConfig: ").Append(CallbackConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLivePlatformReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLivePlatformReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AuthConfig != input.AuthConfig || (this.AuthConfig != null && !this.AuthConfig.Equals(input.AuthConfig))) return false;
            if (this.CallbackConfig != input.CallbackConfig || (this.CallbackConfig != null && input.CallbackConfig != null && !this.CallbackConfig.SequenceEqual(input.CallbackConfig))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AuthConfig != null) hashCode = hashCode * 59 + this.AuthConfig.GetHashCode();
                if (this.CallbackConfig != null) hashCode = hashCode * 59 + this.CallbackConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
