using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateDeviceAuthorizerResponse : SdkResponse
    {

        /// <summary>
        /// **参数说明**：自定义鉴权ID。
        /// </summary>
        [JsonProperty("authorizer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizerId { get; set; }

        /// <summary>
        /// **参数说明**：自定义鉴权器名称，同一租户下的自定义鉴权器名称不能重复。 **取值范围**：长度不超过128，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [JsonProperty("authorizer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizerName { get; set; }

        /// <summary>
        /// **参数说明**：函数名称。
        /// </summary>
        [JsonProperty("func_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FuncName { get; set; }

        /// <summary>
        /// **参数说明**：函数的URN（Uniform Resource Name），唯一标识函数，即自定义鉴权器对应的处理函数地址。
        /// </summary>
        [JsonProperty("func_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string FuncUrn { get; set; }

        /// <summary>
        /// **参数说明**：是否启动签名校验，启动签名校验后不满足签名要求的鉴权信息将被拒绝，以减少无效的函数调用。推荐用户进行安全的签名校验，默认开启。
        /// </summary>
        [JsonProperty("signing_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SigningEnable { get; set; }

        /// <summary>
        /// **参数说明**：签名校验的Key值，开启签名校验时使用。 **取值范围**：长度不超过128，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [JsonProperty("signing_token", NullValueHandling = NullValueHandling.Ignore)]
        public string SigningToken { get; set; }

        /// <summary>
        /// **参数说明**：签名校验的公钥，开启签名校验时使用。用于认证设备携带的签名信息是否正确。
        /// </summary>
        [JsonProperty("signing_public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SigningPublicKey { get; set; }

        /// <summary>
        /// **参数说明**：是否为默认的鉴权方式，默认为false。
        /// </summary>
        [JsonProperty("default_authorizer", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultAuthorizer { get; set; }

        /// <summary>
        /// **参数说明**：是否激活该鉴权方式 - ACTIVE：该鉴权为激活状态。 - INACTIVE：该鉴权为停用状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数说明**：是否开启缓存，默认为false，设备为true时，当设备入参（username，clientId，password，以及证书信息，函数urn）不变时，当缓存结果存在时，将直接使用缓存结果，建议在调试时设置为false，生产时设置为true，避免频繁调用函数。
        /// </summary>
        [JsonProperty("cache_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CacheEnable { get; set; }

        /// <summary>
        /// 在物联网平台进行自定义鉴权相关操作的时间。格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;，如：20151212T121212Z。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 在物联网平台更新自定义鉴权相关操作的时间。格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;，如：20151212T121212Z。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDeviceAuthorizerResponse {\n");
            sb.Append("  authorizerId: ").Append(AuthorizerId).Append("\n");
            sb.Append("  authorizerName: ").Append(AuthorizerName).Append("\n");
            sb.Append("  funcName: ").Append(FuncName).Append("\n");
            sb.Append("  funcUrn: ").Append(FuncUrn).Append("\n");
            sb.Append("  signingEnable: ").Append(SigningEnable).Append("\n");
            sb.Append("  signingToken: ").Append(SigningToken).Append("\n");
            sb.Append("  signingPublicKey: ").Append(SigningPublicKey).Append("\n");
            sb.Append("  defaultAuthorizer: ").Append(DefaultAuthorizer).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  cacheEnable: ").Append(CacheEnable).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDeviceAuthorizerResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDeviceAuthorizerResponse input)
        {
            if (input == null) return false;
            if (this.AuthorizerId != input.AuthorizerId || (this.AuthorizerId != null && !this.AuthorizerId.Equals(input.AuthorizerId))) return false;
            if (this.AuthorizerName != input.AuthorizerName || (this.AuthorizerName != null && !this.AuthorizerName.Equals(input.AuthorizerName))) return false;
            if (this.FuncName != input.FuncName || (this.FuncName != null && !this.FuncName.Equals(input.FuncName))) return false;
            if (this.FuncUrn != input.FuncUrn || (this.FuncUrn != null && !this.FuncUrn.Equals(input.FuncUrn))) return false;
            if (this.SigningEnable != input.SigningEnable || (this.SigningEnable != null && !this.SigningEnable.Equals(input.SigningEnable))) return false;
            if (this.SigningToken != input.SigningToken || (this.SigningToken != null && !this.SigningToken.Equals(input.SigningToken))) return false;
            if (this.SigningPublicKey != input.SigningPublicKey || (this.SigningPublicKey != null && !this.SigningPublicKey.Equals(input.SigningPublicKey))) return false;
            if (this.DefaultAuthorizer != input.DefaultAuthorizer || (this.DefaultAuthorizer != null && !this.DefaultAuthorizer.Equals(input.DefaultAuthorizer))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CacheEnable != input.CacheEnable || (this.CacheEnable != null && !this.CacheEnable.Equals(input.CacheEnable))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.AuthorizerId != null) hashCode = hashCode * 59 + this.AuthorizerId.GetHashCode();
                if (this.AuthorizerName != null) hashCode = hashCode * 59 + this.AuthorizerName.GetHashCode();
                if (this.FuncName != null) hashCode = hashCode * 59 + this.FuncName.GetHashCode();
                if (this.FuncUrn != null) hashCode = hashCode * 59 + this.FuncUrn.GetHashCode();
                if (this.SigningEnable != null) hashCode = hashCode * 59 + this.SigningEnable.GetHashCode();
                if (this.SigningToken != null) hashCode = hashCode * 59 + this.SigningToken.GetHashCode();
                if (this.SigningPublicKey != null) hashCode = hashCode * 59 + this.SigningPublicKey.GetHashCode();
                if (this.DefaultAuthorizer != null) hashCode = hashCode * 59 + this.DefaultAuthorizer.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CacheEnable != null) hashCode = hashCode * 59 + this.CacheEnable.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
