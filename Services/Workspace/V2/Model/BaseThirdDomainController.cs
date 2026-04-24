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
    /// 
    /// </summary>
    public class BaseThirdDomainController 
    {

        /// <summary>
        /// 域管理员。
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// 域管理员密码。
        /// </summary>
        [JsonProperty("user_password", NullValueHandling = NullValueHandling.Ignore)]
        public string UserPassword { get; set; }

        /// <summary>
        /// 域管平台地址。
        /// </summary>
        [JsonProperty("main_dc_address", NullValueHandling = NullValueHandling.Ignore)]
        public string MainDcAddress { get; set; }

        /// <summary>
        /// 域管开放接口地址。
        /// </summary>
        [JsonProperty("open_interface_address", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenInterfaceAddress { get; set; }

        /// <summary>
        /// 域管开放接口域名。
        /// </summary>
        [JsonProperty("open_interface_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenInterfaceDomainName { get; set; }

        /// <summary>
        /// 域管内部服务地址。
        /// </summary>
        [JsonProperty("internal_service_address", NullValueHandling = NullValueHandling.Ignore)]
        public string InternalServiceAddress { get; set; }

        /// <summary>
        /// 客户端证书公钥。
        /// </summary>
        [JsonProperty("app_cert", NullValueHandling = NullValueHandling.Ignore)]
        public string AppCert { get; set; }

        /// <summary>
        /// 客户端证书私钥。
        /// </summary>
        [JsonProperty("app_cert_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AppCertKey { get; set; }

        /// <summary>
        /// 服务端CA。
        /// </summary>
        [JsonProperty("openapi_ca_cert", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenapiCaCert { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseThirdDomainController {\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  userPassword: ").Append(UserPassword).Append("\n");
            sb.Append("  mainDcAddress: ").Append(MainDcAddress).Append("\n");
            sb.Append("  openInterfaceAddress: ").Append(OpenInterfaceAddress).Append("\n");
            sb.Append("  openInterfaceDomainName: ").Append(OpenInterfaceDomainName).Append("\n");
            sb.Append("  internalServiceAddress: ").Append(InternalServiceAddress).Append("\n");
            sb.Append("  appCert: ").Append(AppCert).Append("\n");
            sb.Append("  appCertKey: ").Append(AppCertKey).Append("\n");
            sb.Append("  openapiCaCert: ").Append(OpenapiCaCert).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BaseThirdDomainController);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BaseThirdDomainController input)
        {
            if (input == null) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.UserPassword != input.UserPassword || (this.UserPassword != null && !this.UserPassword.Equals(input.UserPassword))) return false;
            if (this.MainDcAddress != input.MainDcAddress || (this.MainDcAddress != null && !this.MainDcAddress.Equals(input.MainDcAddress))) return false;
            if (this.OpenInterfaceAddress != input.OpenInterfaceAddress || (this.OpenInterfaceAddress != null && !this.OpenInterfaceAddress.Equals(input.OpenInterfaceAddress))) return false;
            if (this.OpenInterfaceDomainName != input.OpenInterfaceDomainName || (this.OpenInterfaceDomainName != null && !this.OpenInterfaceDomainName.Equals(input.OpenInterfaceDomainName))) return false;
            if (this.InternalServiceAddress != input.InternalServiceAddress || (this.InternalServiceAddress != null && !this.InternalServiceAddress.Equals(input.InternalServiceAddress))) return false;
            if (this.AppCert != input.AppCert || (this.AppCert != null && !this.AppCert.Equals(input.AppCert))) return false;
            if (this.AppCertKey != input.AppCertKey || (this.AppCertKey != null && !this.AppCertKey.Equals(input.AppCertKey))) return false;
            if (this.OpenapiCaCert != input.OpenapiCaCert || (this.OpenapiCaCert != null && !this.OpenapiCaCert.Equals(input.OpenapiCaCert))) return false;

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
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.UserPassword != null) hashCode = hashCode * 59 + this.UserPassword.GetHashCode();
                if (this.MainDcAddress != null) hashCode = hashCode * 59 + this.MainDcAddress.GetHashCode();
                if (this.OpenInterfaceAddress != null) hashCode = hashCode * 59 + this.OpenInterfaceAddress.GetHashCode();
                if (this.OpenInterfaceDomainName != null) hashCode = hashCode * 59 + this.OpenInterfaceDomainName.GetHashCode();
                if (this.InternalServiceAddress != null) hashCode = hashCode * 59 + this.InternalServiceAddress.GetHashCode();
                if (this.AppCert != null) hashCode = hashCode * 59 + this.AppCert.GetHashCode();
                if (this.AppCertKey != null) hashCode = hashCode * 59 + this.AppCertKey.GetHashCode();
                if (this.OpenapiCaCert != null) hashCode = hashCode * 59 + this.OpenapiCaCert.GetHashCode();
                return hashCode;
            }
        }
    }
}
