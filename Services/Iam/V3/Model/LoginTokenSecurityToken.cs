using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class LoginTokenSecurityToken 
    {

        /// <summary>
        /// AK。
        /// </summary>
        [JsonProperty("access", NullValueHandling = NullValueHandling.Ignore)]
        public string Access { get; set; }

        /// <summary>
        /// SK。
        /// </summary>
        [JsonProperty("secret", NullValueHandling = NullValueHandling.Ignore)]
        public string Secret { get; set; }

        /// <summary>
        /// securitytoken，即临时身份的安全token。    支持使用自定义代理用户或普通用户获取的securitytoken换取logintoken，详情请参见：[通过token获取临时访问密钥和securitytoken](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;IAM&amp;api&#x3D;CreateTemporaryAccessKeyByToken)。    支持委托的方式，但获取securitytoken时，请求体中必须填写session_user.name参数，详情请参见：[通过委托获取临时访问密钥和securitytoken](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;IAM&amp;api&#x3D;CreateTemporaryAccessKeyByAgency)。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 自定义代理登录票据logintoken的有效时间，时间单位为秒。默认10分钟，取值范围10min~12h，且取值不能大于临时安全凭证securitytoken的过期时间。
        /// </summary>
        [JsonProperty("duration_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? DurationSeconds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginTokenSecurityToken {\n");
            sb.Append("  access: ").Append(Access).Append("\n");
            sb.Append("  secret: ").Append(Secret).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  durationSeconds: ").Append(DurationSeconds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoginTokenSecurityToken);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LoginTokenSecurityToken input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Access == input.Access ||
                    (this.Access != null &&
                    this.Access.Equals(input.Access))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DurationSeconds == input.DurationSeconds ||
                    (this.DurationSeconds != null &&
                    this.DurationSeconds.Equals(input.DurationSeconds))
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
                if (this.Access != null)
                    hashCode = hashCode * 59 + this.Access.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DurationSeconds != null)
                    hashCode = hashCode * 59 + this.DurationSeconds.GetHashCode();
                return hashCode;
            }
        }
    }
}
