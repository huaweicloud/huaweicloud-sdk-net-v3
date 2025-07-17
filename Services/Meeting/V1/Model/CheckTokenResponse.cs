using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CheckTokenResponse : SdkResponse
    {

        /// <summary>
        /// Access Token字符串。
        /// </summary>
        [JsonProperty("accessToken", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessToken { get; set; }

        /// <summary>
        /// 用户IP。
        /// </summary>
        [JsonProperty("tokenIp", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenIp { get; set; }

        /// <summary>
        /// Access Token有效时长，单位：秒。
        /// </summary>
        [JsonProperty("validPeriod", NullValueHandling = NullValueHandling.Ignore)]
        public long? ValidPeriod { get; set; }

        /// <summary>
        /// Access Token的失效时间戳，单位：秒。
        /// </summary>
        [JsonProperty("expireTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// Access Token的创建时间戳，单位：毫秒。
        /// </summary>
        [JsonProperty("createTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public UserInfo User { get; set; }

        /// <summary>
        /// 登录帐号类型。 * 72：API调用类型 
        /// </summary>
        [JsonProperty("clientType", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientType { get; set; }

        /// <summary>
        /// 抢占登录标识。 * 0： 非抢占 * 1： 抢占 
        /// </summary>
        [JsonProperty("forceLoginInd", NullValueHandling = NullValueHandling.Ignore)]
        public int? ForceLoginInd { get; set; }

        /// <summary>
        /// 是否首次登录。 &gt; 首次登录表示尚未修改过密码。首次登录时，系统会提醒用户需要修改密码。 默认值：false。 
        /// </summary>
        [JsonProperty("firstLogin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FirstLogin { get; set; }

        /// <summary>
        /// 密码是否过期，默认值：false。
        /// </summary>
        [JsonProperty("pwdExpired", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PwdExpired { get; set; }

        /// <summary>
        /// 密码有效天数。
        /// </summary>
        [JsonProperty("daysPwdAvailable", NullValueHandling = NullValueHandling.Ignore)]
        public int? DaysPwdAvailable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("proxyToken", NullValueHandling = NullValueHandling.Ignore)]
        public ProxyTokenDTO ProxyToken { get; set; }

        /// <summary>
        /// 是否延时删除状态。
        /// </summary>
        [JsonProperty("delayDelete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DelayDelete { get; set; }

        /// <summary>
        /// Token类型。 * 0：用户Access Token * 1：会控TOKEN * 2：一次性TOKEN 
        /// </summary>
        [JsonProperty("tokenType", NullValueHandling = NullValueHandling.Ignore)]
        public int? TokenType { get; set; }

        /// <summary>
        /// Refresh Token字符串。
        /// </summary>
        [JsonProperty("refreshToken", NullValueHandling = NullValueHandling.Ignore)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Refresh Token有效时长，单位：秒。
        /// </summary>
        [JsonProperty("refreshValidPeriod", NullValueHandling = NullValueHandling.Ignore)]
        public long? RefreshValidPeriod { get; set; }

        /// <summary>
        /// Refresh Token的失效时间戳，单位：秒。
        /// </summary>
        [JsonProperty("refreshExpireTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? RefreshExpireTime { get; set; }

        /// <summary>
        /// Refresh Token的创建时间戳，单位：毫秒。
        /// </summary>
        [JsonProperty("refreshCreateTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? RefreshCreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckTokenResponse {\n");
            sb.Append("  accessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  tokenIp: ").Append(TokenIp).Append("\n");
            sb.Append("  validPeriod: ").Append(ValidPeriod).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  clientType: ").Append(ClientType).Append("\n");
            sb.Append("  forceLoginInd: ").Append(ForceLoginInd).Append("\n");
            sb.Append("  firstLogin: ").Append(FirstLogin).Append("\n");
            sb.Append("  pwdExpired: ").Append(PwdExpired).Append("\n");
            sb.Append("  daysPwdAvailable: ").Append(DaysPwdAvailable).Append("\n");
            sb.Append("  proxyToken: ").Append(ProxyToken).Append("\n");
            sb.Append("  delayDelete: ").Append(DelayDelete).Append("\n");
            sb.Append("  tokenType: ").Append(TokenType).Append("\n");
            sb.Append("  refreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  refreshValidPeriod: ").Append(RefreshValidPeriod).Append("\n");
            sb.Append("  refreshExpireTime: ").Append(RefreshExpireTime).Append("\n");
            sb.Append("  refreshCreateTime: ").Append(RefreshCreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckTokenResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckTokenResponse input)
        {
            if (input == null) return false;
            if (this.AccessToken != input.AccessToken || (this.AccessToken != null && !this.AccessToken.Equals(input.AccessToken))) return false;
            if (this.TokenIp != input.TokenIp || (this.TokenIp != null && !this.TokenIp.Equals(input.TokenIp))) return false;
            if (this.ValidPeriod != input.ValidPeriod || (this.ValidPeriod != null && !this.ValidPeriod.Equals(input.ValidPeriod))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.User != input.User || (this.User != null && !this.User.Equals(input.User))) return false;
            if (this.ClientType != input.ClientType || (this.ClientType != null && !this.ClientType.Equals(input.ClientType))) return false;
            if (this.ForceLoginInd != input.ForceLoginInd || (this.ForceLoginInd != null && !this.ForceLoginInd.Equals(input.ForceLoginInd))) return false;
            if (this.FirstLogin != input.FirstLogin || (this.FirstLogin != null && !this.FirstLogin.Equals(input.FirstLogin))) return false;
            if (this.PwdExpired != input.PwdExpired || (this.PwdExpired != null && !this.PwdExpired.Equals(input.PwdExpired))) return false;
            if (this.DaysPwdAvailable != input.DaysPwdAvailable || (this.DaysPwdAvailable != null && !this.DaysPwdAvailable.Equals(input.DaysPwdAvailable))) return false;
            if (this.ProxyToken != input.ProxyToken || (this.ProxyToken != null && !this.ProxyToken.Equals(input.ProxyToken))) return false;
            if (this.DelayDelete != input.DelayDelete || (this.DelayDelete != null && !this.DelayDelete.Equals(input.DelayDelete))) return false;
            if (this.TokenType != input.TokenType || (this.TokenType != null && !this.TokenType.Equals(input.TokenType))) return false;
            if (this.RefreshToken != input.RefreshToken || (this.RefreshToken != null && !this.RefreshToken.Equals(input.RefreshToken))) return false;
            if (this.RefreshValidPeriod != input.RefreshValidPeriod || (this.RefreshValidPeriod != null && !this.RefreshValidPeriod.Equals(input.RefreshValidPeriod))) return false;
            if (this.RefreshExpireTime != input.RefreshExpireTime || (this.RefreshExpireTime != null && !this.RefreshExpireTime.Equals(input.RefreshExpireTime))) return false;
            if (this.RefreshCreateTime != input.RefreshCreateTime || (this.RefreshCreateTime != null && !this.RefreshCreateTime.Equals(input.RefreshCreateTime))) return false;

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
                if (this.AccessToken != null) hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.TokenIp != null) hashCode = hashCode * 59 + this.TokenIp.GetHashCode();
                if (this.ValidPeriod != null) hashCode = hashCode * 59 + this.ValidPeriod.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.User != null) hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.ClientType != null) hashCode = hashCode * 59 + this.ClientType.GetHashCode();
                if (this.ForceLoginInd != null) hashCode = hashCode * 59 + this.ForceLoginInd.GetHashCode();
                if (this.FirstLogin != null) hashCode = hashCode * 59 + this.FirstLogin.GetHashCode();
                if (this.PwdExpired != null) hashCode = hashCode * 59 + this.PwdExpired.GetHashCode();
                if (this.DaysPwdAvailable != null) hashCode = hashCode * 59 + this.DaysPwdAvailable.GetHashCode();
                if (this.ProxyToken != null) hashCode = hashCode * 59 + this.ProxyToken.GetHashCode();
                if (this.DelayDelete != null) hashCode = hashCode * 59 + this.DelayDelete.GetHashCode();
                if (this.TokenType != null) hashCode = hashCode * 59 + this.TokenType.GetHashCode();
                if (this.RefreshToken != null) hashCode = hashCode * 59 + this.RefreshToken.GetHashCode();
                if (this.RefreshValidPeriod != null) hashCode = hashCode * 59 + this.RefreshValidPeriod.GetHashCode();
                if (this.RefreshExpireTime != null) hashCode = hashCode * 59 + this.RefreshExpireTime.GetHashCode();
                if (this.RefreshCreateTime != null) hashCode = hashCode * 59 + this.RefreshCreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
