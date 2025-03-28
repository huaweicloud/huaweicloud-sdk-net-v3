using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Msgsms.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SmsAppUpdateReq 
    {

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 是否创建测试签名和模板。只有地域为国内时，该字段有效 1. true：是 2. false：否
        /// </summary>
        [JsonProperty("create_sign_and_template", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreateSignAndTemplate { get; set; }

        /// <summary>
        /// 企业项目ID，默认为0
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 企业项目名称，默认为default
        /// </summary>
        [JsonProperty("enterprise_project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectName { get; set; }

        /// <summary>
        /// 地域 1. cn：国内 2. intl：国际
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 上行回调地址。只有地域为国内时，该字段有效
        /// </summary>
        [JsonProperty("up_link_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string UpLinkAddr { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsAppUpdateReq {\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  createSignAndTemplate: ").Append(CreateSignAndTemplate).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  enterpriseProjectName: ").Append(EnterpriseProjectName).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  upLinkAddr: ").Append(UpLinkAddr).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmsAppUpdateReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmsAppUpdateReq input)
        {
            if (input == null) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.CreateSignAndTemplate != input.CreateSignAndTemplate || (this.CreateSignAndTemplate != null && !this.CreateSignAndTemplate.Equals(input.CreateSignAndTemplate))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.EnterpriseProjectName != input.EnterpriseProjectName || (this.EnterpriseProjectName != null && !this.EnterpriseProjectName.Equals(input.EnterpriseProjectName))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.UpLinkAddr != input.UpLinkAddr || (this.UpLinkAddr != null && !this.UpLinkAddr.Equals(input.UpLinkAddr))) return false;

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
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.CreateSignAndTemplate != null) hashCode = hashCode * 59 + this.CreateSignAndTemplate.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.EnterpriseProjectName != null) hashCode = hashCode * 59 + this.EnterpriseProjectName.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.UpLinkAddr != null) hashCode = hashCode * 59 + this.UpLinkAddr.GetHashCode();
                return hashCode;
            }
        }
    }
}
