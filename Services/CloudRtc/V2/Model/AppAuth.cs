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
    /// 鉴权配置
    /// </summary>
    public class AppAuth 
    {

        /// <summary>
        /// 开启或关闭URL鉴权
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 接入RTC建链认证时的signature的有效期。单位：秒。默认300秒。signature由app_key生成 
        /// </summary>
        [JsonProperty("expire", NullValueHandling = NullValueHandling.Ignore)]
        public int? Expire { get; set; }

        /// <summary>
        /// app鉴权秘钥
        /// </summary>
        [JsonProperty("app_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AppKey { get; set; }

        /// <summary>
        /// app鉴权的更新时间，形如“2006-01-02T15:04:05.075Z”，时区为：UTC
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppAuth {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  expire: ").Append(Expire).Append("\n");
            sb.Append("  appKey: ").Append(AppKey).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppAuth);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppAuth input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enable == input.Enable ||
                    (this.Enable != null &&
                    this.Enable.Equals(input.Enable))
                ) && 
                (
                    this.Expire == input.Expire ||
                    (this.Expire != null &&
                    this.Expire.Equals(input.Expire))
                ) && 
                (
                    this.AppKey == input.AppKey ||
                    (this.AppKey != null &&
                    this.AppKey.Equals(input.AppKey))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
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
                if (this.Enable != null)
                    hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.Expire != null)
                    hashCode = hashCode * 59 + this.Expire.GetHashCode();
                if (this.AppKey != null)
                    hashCode = hashCode * 59 + this.AppKey.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
