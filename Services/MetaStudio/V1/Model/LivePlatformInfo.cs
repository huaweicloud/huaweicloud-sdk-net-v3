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
    /// 直播平台信息
    /// </summary>
    public class LivePlatformInfo 
    {

        /// <summary>
        /// 平台ID
        /// </summary>
        [JsonProperty("platform_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlatformId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("access_type", NullValueHandling = NullValueHandling.Ignore)]
        public AccessTypeEnum AccessType { get; set; }
        /// <summary>
        /// 直播平台名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("authorization_info", NullValueHandling = NullValueHandling.Ignore)]
        public PlatformAuthorizationInfo AuthorizationInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auth_config", NullValueHandling = NullValueHandling.Ignore)]
        public CustomPlatformAuthConfig AuthConfig { get; set; }

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
            sb.Append("class LivePlatformInfo {\n");
            sb.Append("  platformId: ").Append(PlatformId).Append("\n");
            sb.Append("  accessType: ").Append(AccessType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  authorizationInfo: ").Append(AuthorizationInfo).Append("\n");
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
            return this.Equals(input as LivePlatformInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LivePlatformInfo input)
        {
            if (input == null) return false;
            if (this.PlatformId != input.PlatformId || (this.PlatformId != null && !this.PlatformId.Equals(input.PlatformId))) return false;
            if (this.AccessType != input.AccessType) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AuthorizationInfo != input.AuthorizationInfo || (this.AuthorizationInfo != null && !this.AuthorizationInfo.Equals(input.AuthorizationInfo))) return false;
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
                if (this.PlatformId != null) hashCode = hashCode * 59 + this.PlatformId.GetHashCode();
                hashCode = hashCode * 59 + this.AccessType.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AuthorizationInfo != null) hashCode = hashCode * 59 + this.AuthorizationInfo.GetHashCode();
                if (this.AuthConfig != null) hashCode = hashCode * 59 + this.AuthConfig.GetHashCode();
                if (this.CallbackConfig != null) hashCode = hashCode * 59 + this.CallbackConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
