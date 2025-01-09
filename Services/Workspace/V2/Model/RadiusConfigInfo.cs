using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Radius配置信息
    /// </summary>
    public class RadiusConfigInfo 
    {

        /// <summary>
        /// Radius主机信息
        /// </summary>
        [JsonProperty("radius_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<RadiusHost> RadiusConfigs { get; set; }

        /// <summary>
        /// Radius密码
        /// </summary>
        [JsonProperty("radius_secret", NullValueHandling = NullValueHandling.Ignore)]
        public string RadiusSecret { get; set; }

        /// <summary>
        /// 超时
        /// </summary>
        [JsonProperty("radius_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? RadiusTimeout { get; set; }

        /// <summary>
        /// 尝试次数
        /// </summary>
        [JsonProperty("radius_attempt_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? RadiusAttemptTime { get; set; }

        /// <summary>
        /// 用户前缀中的域，0代表禁用，1代表开启域前缀，2代表开启域后缀，默认值为0。
        /// </summary>
        [JsonProperty("domain_in_user_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainInUserPrefix { get; set; }

        /// <summary>
        /// 认证类型，STATIC代表静态密码，DYNAMIC代表动态口令。
        /// </summary>
        [JsonProperty("radius_auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RadiusAuthType { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 认证协议，pap或chap，选择短信验证码时才可用。
        /// </summary>
        [JsonProperty("auth_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthProtocol { get; set; }

        /// <summary>
        /// 验证码开关，默认开启
        /// </summary>
        [JsonProperty("verification_code_display_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VerificationCodeDisplayEnable { get; set; }

        /// <summary>
        /// 验证码失败次数
        /// </summary>
        [JsonProperty("verification_code_conditions", NullValueHandling = NullValueHandling.Ignore)]
        public int? VerificationCodeConditions { get; set; }

        /// <summary>
        /// 过滤短信拓展字段
        /// </summary>
        [JsonProperty("obtain_code_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Object ObtainCodeAttributes { get; set; }

        /// <summary>
        /// 过滤短信拓展字段
        /// </summary>
        [JsonProperty("check_code_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Object CheckCodeAttributes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RadiusConfigInfo {\n");
            sb.Append("  radiusConfigs: ").Append(RadiusConfigs).Append("\n");
            sb.Append("  radiusSecret: ").Append(RadiusSecret).Append("\n");
            sb.Append("  radiusTimeout: ").Append(RadiusTimeout).Append("\n");
            sb.Append("  radiusAttemptTime: ").Append(RadiusAttemptTime).Append("\n");
            sb.Append("  domainInUserPrefix: ").Append(DomainInUserPrefix).Append("\n");
            sb.Append("  radiusAuthType: ").Append(RadiusAuthType).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  authProtocol: ").Append(AuthProtocol).Append("\n");
            sb.Append("  verificationCodeDisplayEnable: ").Append(VerificationCodeDisplayEnable).Append("\n");
            sb.Append("  verificationCodeConditions: ").Append(VerificationCodeConditions).Append("\n");
            sb.Append("  obtainCodeAttributes: ").Append(ObtainCodeAttributes).Append("\n");
            sb.Append("  checkCodeAttributes: ").Append(CheckCodeAttributes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RadiusConfigInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RadiusConfigInfo input)
        {
            if (input == null) return false;
            if (this.RadiusConfigs != input.RadiusConfigs || (this.RadiusConfigs != null && input.RadiusConfigs != null && !this.RadiusConfigs.SequenceEqual(input.RadiusConfigs))) return false;
            if (this.RadiusSecret != input.RadiusSecret || (this.RadiusSecret != null && !this.RadiusSecret.Equals(input.RadiusSecret))) return false;
            if (this.RadiusTimeout != input.RadiusTimeout || (this.RadiusTimeout != null && !this.RadiusTimeout.Equals(input.RadiusTimeout))) return false;
            if (this.RadiusAttemptTime != input.RadiusAttemptTime || (this.RadiusAttemptTime != null && !this.RadiusAttemptTime.Equals(input.RadiusAttemptTime))) return false;
            if (this.DomainInUserPrefix != input.DomainInUserPrefix || (this.DomainInUserPrefix != null && !this.DomainInUserPrefix.Equals(input.DomainInUserPrefix))) return false;
            if (this.RadiusAuthType != input.RadiusAuthType || (this.RadiusAuthType != null && !this.RadiusAuthType.Equals(input.RadiusAuthType))) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.AuthProtocol != input.AuthProtocol || (this.AuthProtocol != null && !this.AuthProtocol.Equals(input.AuthProtocol))) return false;
            if (this.VerificationCodeDisplayEnable != input.VerificationCodeDisplayEnable || (this.VerificationCodeDisplayEnable != null && !this.VerificationCodeDisplayEnable.Equals(input.VerificationCodeDisplayEnable))) return false;
            if (this.VerificationCodeConditions != input.VerificationCodeConditions || (this.VerificationCodeConditions != null && !this.VerificationCodeConditions.Equals(input.VerificationCodeConditions))) return false;
            if (this.ObtainCodeAttributes != input.ObtainCodeAttributes || (this.ObtainCodeAttributes != null && !this.ObtainCodeAttributes.Equals(input.ObtainCodeAttributes))) return false;
            if (this.CheckCodeAttributes != input.CheckCodeAttributes || (this.CheckCodeAttributes != null && !this.CheckCodeAttributes.Equals(input.CheckCodeAttributes))) return false;

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
                if (this.RadiusConfigs != null) hashCode = hashCode * 59 + this.RadiusConfigs.GetHashCode();
                if (this.RadiusSecret != null) hashCode = hashCode * 59 + this.RadiusSecret.GetHashCode();
                if (this.RadiusTimeout != null) hashCode = hashCode * 59 + this.RadiusTimeout.GetHashCode();
                if (this.RadiusAttemptTime != null) hashCode = hashCode * 59 + this.RadiusAttemptTime.GetHashCode();
                if (this.DomainInUserPrefix != null) hashCode = hashCode * 59 + this.DomainInUserPrefix.GetHashCode();
                if (this.RadiusAuthType != null) hashCode = hashCode * 59 + this.RadiusAuthType.GetHashCode();
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.AuthProtocol != null) hashCode = hashCode * 59 + this.AuthProtocol.GetHashCode();
                if (this.VerificationCodeDisplayEnable != null) hashCode = hashCode * 59 + this.VerificationCodeDisplayEnable.GetHashCode();
                if (this.VerificationCodeConditions != null) hashCode = hashCode * 59 + this.VerificationCodeConditions.GetHashCode();
                if (this.ObtainCodeAttributes != null) hashCode = hashCode * 59 + this.ObtainCodeAttributes.GetHashCode();
                if (this.CheckCodeAttributes != null) hashCode = hashCode * 59 + this.CheckCodeAttributes.GetHashCode();
                return hashCode;
            }
        }
    }
}
