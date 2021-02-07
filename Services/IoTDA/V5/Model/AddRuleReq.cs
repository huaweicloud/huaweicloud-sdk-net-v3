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
    /// 规则触发条件请求结构体
    /// </summary>
    public class AddRuleReq 
    {

        /// <summary>
        /// 用户自定义的规则名称。
        /// </summary>
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        /// <summary>
        /// 用户自定义的规则描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public RoutingRuleSubject Subject { get; set; }

        /// <summary>
        /// 租户规则的生效范围，默认GLOBAL，取值如下： - GLOBAL：生效范围为租户级 - APP：生效范围为资源空间级。如果类型为APP，创建的规则生效范围为携带的app_id指定的资源空间，不携带app_id则创建规则生效范围为[默认资源空间](https://support.huaweicloud.com/usermanual-iothub/iot_01_0006.html#section0)。 
        /// </summary>
        [JsonProperty("app_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AppType { get; set; }

        /// <summary>
        /// 资源空间ID。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 用户自定义sql select语句，最大长度500，该参数仅供标准版和企业版用户使用。
        /// </summary>
        [JsonProperty("select", NullValueHandling = NullValueHandling.Ignore)]
        public string Select { get; set; }

        /// <summary>
        /// 用户自定义sql where语句，最大长度500，该参数仅供标准版和企业版用户使用。
        /// </summary>
        [JsonProperty("where", NullValueHandling = NullValueHandling.Ignore)]
        public string Where { get; set; }

        /// <summary>
        /// 规则推送消息的消息格式版本，租户无需设置，仅供内部兼容历史推送消息使用，iocsa的历史推送消息版本为V5.0.1
        /// </summary>
        [JsonProperty("data_version", NullValueHandling = NullValueHandling.Ignore)]
        public string DataVersion { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddRuleReq {\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  appType: ").Append(AppType).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  select: ").Append(Select).Append("\n");
            sb.Append("  where: ").Append(Where).Append("\n");
            sb.Append("  dataVersion: ").Append(DataVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddRuleReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddRuleReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RuleName == input.RuleName ||
                    (this.RuleName != null &&
                    this.RuleName.Equals(input.RuleName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.AppType == input.AppType ||
                    (this.AppType != null &&
                    this.AppType.Equals(input.AppType))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.Select == input.Select ||
                    (this.Select != null &&
                    this.Select.Equals(input.Select))
                ) && 
                (
                    this.Where == input.Where ||
                    (this.Where != null &&
                    this.Where.Equals(input.Where))
                ) && 
                (
                    this.DataVersion == input.DataVersion ||
                    (this.DataVersion != null &&
                    this.DataVersion.Equals(input.DataVersion))
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
                if (this.RuleName != null)
                    hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.AppType != null)
                    hashCode = hashCode * 59 + this.AppType.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.Select != null)
                    hashCode = hashCode * 59 + this.Select.GetHashCode();
                if (this.Where != null)
                    hashCode = hashCode * 59 + this.Where.GetHashCode();
                if (this.DataVersion != null)
                    hashCode = hashCode * 59 + this.DataVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
