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
    /// 查询域控的配置信息响应。
    /// </summary>
    public class UosDomainInfo 
    {

        /// <summary>
        /// 认证配置id。
        /// </summary>
        [JsonProperty("auth_config_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthConfigId { get; set; }

        /// <summary>
        /// 域控id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public DomainType? Type { get; set; }

        /// <summary>
        /// 统信域控名称。
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 域管理员。
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

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
        /// 客户端证书公钥id。
        /// </summary>
        [JsonProperty("app_cert_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppCertId { get; set; }

        /// <summary>
        /// 客户端证书公钥有效期起始时间。
        /// </summary>
        [JsonProperty("app_cert_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AppCertStartTime { get; set; }

        /// <summary>
        /// 客户端证书公钥有效期结束时间。
        /// </summary>
        [JsonProperty("app_cert_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AppCertEndTime { get; set; }

        /// <summary>
        /// 服务端CA id。
        /// </summary>
        [JsonProperty("openapi_ca_cert_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenapiCaCertId { get; set; }

        /// <summary>
        /// 服务端CA有效期起始时间。
        /// </summary>
        [JsonProperty("openapi_ca_cert_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenapiCaCertStartTime { get; set; }

        /// <summary>
        /// 服务端CA有效期结束时间。
        /// </summary>
        [JsonProperty("openapi_ca_cert_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string OpenapiCaCertEndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UosDomainInfo {\n");
            sb.Append("  authConfigId: ").Append(AuthConfigId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  mainDcAddress: ").Append(MainDcAddress).Append("\n");
            sb.Append("  openInterfaceAddress: ").Append(OpenInterfaceAddress).Append("\n");
            sb.Append("  openInterfaceDomainName: ").Append(OpenInterfaceDomainName).Append("\n");
            sb.Append("  internalServiceAddress: ").Append(InternalServiceAddress).Append("\n");
            sb.Append("  appCertId: ").Append(AppCertId).Append("\n");
            sb.Append("  appCertStartTime: ").Append(AppCertStartTime).Append("\n");
            sb.Append("  appCertEndTime: ").Append(AppCertEndTime).Append("\n");
            sb.Append("  openapiCaCertId: ").Append(OpenapiCaCertId).Append("\n");
            sb.Append("  openapiCaCertStartTime: ").Append(OpenapiCaCertStartTime).Append("\n");
            sb.Append("  openapiCaCertEndTime: ").Append(OpenapiCaCertEndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UosDomainInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UosDomainInfo input)
        {
            if (input == null) return false;
            if (this.AuthConfigId != input.AuthConfigId || (this.AuthConfigId != null && !this.AuthConfigId.Equals(input.AuthConfigId))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.MainDcAddress != input.MainDcAddress || (this.MainDcAddress != null && !this.MainDcAddress.Equals(input.MainDcAddress))) return false;
            if (this.OpenInterfaceAddress != input.OpenInterfaceAddress || (this.OpenInterfaceAddress != null && !this.OpenInterfaceAddress.Equals(input.OpenInterfaceAddress))) return false;
            if (this.OpenInterfaceDomainName != input.OpenInterfaceDomainName || (this.OpenInterfaceDomainName != null && !this.OpenInterfaceDomainName.Equals(input.OpenInterfaceDomainName))) return false;
            if (this.InternalServiceAddress != input.InternalServiceAddress || (this.InternalServiceAddress != null && !this.InternalServiceAddress.Equals(input.InternalServiceAddress))) return false;
            if (this.AppCertId != input.AppCertId || (this.AppCertId != null && !this.AppCertId.Equals(input.AppCertId))) return false;
            if (this.AppCertStartTime != input.AppCertStartTime || (this.AppCertStartTime != null && !this.AppCertStartTime.Equals(input.AppCertStartTime))) return false;
            if (this.AppCertEndTime != input.AppCertEndTime || (this.AppCertEndTime != null && !this.AppCertEndTime.Equals(input.AppCertEndTime))) return false;
            if (this.OpenapiCaCertId != input.OpenapiCaCertId || (this.OpenapiCaCertId != null && !this.OpenapiCaCertId.Equals(input.OpenapiCaCertId))) return false;
            if (this.OpenapiCaCertStartTime != input.OpenapiCaCertStartTime || (this.OpenapiCaCertStartTime != null && !this.OpenapiCaCertStartTime.Equals(input.OpenapiCaCertStartTime))) return false;
            if (this.OpenapiCaCertEndTime != input.OpenapiCaCertEndTime || (this.OpenapiCaCertEndTime != null && !this.OpenapiCaCertEndTime.Equals(input.OpenapiCaCertEndTime))) return false;

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
                if (this.AuthConfigId != null) hashCode = hashCode * 59 + this.AuthConfigId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.MainDcAddress != null) hashCode = hashCode * 59 + this.MainDcAddress.GetHashCode();
                if (this.OpenInterfaceAddress != null) hashCode = hashCode * 59 + this.OpenInterfaceAddress.GetHashCode();
                if (this.OpenInterfaceDomainName != null) hashCode = hashCode * 59 + this.OpenInterfaceDomainName.GetHashCode();
                if (this.InternalServiceAddress != null) hashCode = hashCode * 59 + this.InternalServiceAddress.GetHashCode();
                if (this.AppCertId != null) hashCode = hashCode * 59 + this.AppCertId.GetHashCode();
                if (this.AppCertStartTime != null) hashCode = hashCode * 59 + this.AppCertStartTime.GetHashCode();
                if (this.AppCertEndTime != null) hashCode = hashCode * 59 + this.AppCertEndTime.GetHashCode();
                if (this.OpenapiCaCertId != null) hashCode = hashCode * 59 + this.OpenapiCaCertId.GetHashCode();
                if (this.OpenapiCaCertStartTime != null) hashCode = hashCode * 59 + this.OpenapiCaCertStartTime.GetHashCode();
                if (this.OpenapiCaCertEndTime != null) hashCode = hashCode * 59 + this.OpenapiCaCertEndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
