using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// OS属性
    /// </summary>
    public class TemplateOsProfile 
    {

        /// <summary>
        /// 秘钥名称
        /// </summary>
        [JsonProperty("key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyName { get; set; }

        /// <summary>
        /// 注入脚本，会导致请求过大，影响虚拟机表。1. 和密码的使用冲突 2. 超大文本问题。
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

        /// <summary>
        /// 委托名称。实际需要多委托。
        /// </summary>
        [JsonProperty("iam_agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IamAgencyName { get; set; }

        /// <summary>
        /// 开启主机监控服务
        /// </summary>
        [JsonProperty("enable_monitoring_service", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableMonitoringService { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateOsProfile {\n");
            sb.Append("  keyName: ").Append(KeyName).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  iamAgencyName: ").Append(IamAgencyName).Append("\n");
            sb.Append("  enableMonitoringService: ").Append(EnableMonitoringService).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateOsProfile);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateOsProfile input)
        {
            if (input == null) return false;
            if (this.KeyName != input.KeyName || (this.KeyName != null && !this.KeyName.Equals(input.KeyName))) return false;
            if (this.UserData != input.UserData || (this.UserData != null && !this.UserData.Equals(input.UserData))) return false;
            if (this.IamAgencyName != input.IamAgencyName || (this.IamAgencyName != null && !this.IamAgencyName.Equals(input.IamAgencyName))) return false;
            if (this.EnableMonitoringService != input.EnableMonitoringService || (this.EnableMonitoringService != null && !this.EnableMonitoringService.Equals(input.EnableMonitoringService))) return false;

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
                if (this.KeyName != null) hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.UserData != null) hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.IamAgencyName != null) hashCode = hashCode * 59 + this.IamAgencyName.GetHashCode();
                if (this.EnableMonitoringService != null) hashCode = hashCode * 59 + this.EnableMonitoringService.GetHashCode();
                return hashCode;
            }
        }
    }
}
