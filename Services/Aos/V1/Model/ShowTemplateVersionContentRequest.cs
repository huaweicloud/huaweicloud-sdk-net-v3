using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowTemplateVersionContentRequest 
    {

        /// <summary>
        /// 用户指定的，对于此请求的唯一ID，用于定位某个请求，推荐使用UUID
        /// </summary>
        [SDKProperty("Client-Request-Id", IsHeader = true)]
        [JsonProperty("Client-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// 模板（Template）的名字。此名字在domain_id+region下应唯一，可以使用中文、大小写英文、数字、下划线、中划线。首字符需为中文或者英文，区分大小写。
        /// </summary>
        [SDKProperty("template_name", IsPath = true)]
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板版本ID，以大写V开头，每次创建模板版本，模板版本ID数字部分会自增加一
        /// </summary>
        [SDKProperty("version_id", IsPath = true)]
        [JsonProperty("version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionId { get; set; }

        /// <summary>
        /// 模板的ID。当template_id存在时，模板服务会检查template_id是否和template_name匹配，不匹配会返回400
        /// </summary>
        [SDKProperty("template_id", IsQuery = true)]
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 允许访问资源栈模板的source vpc id列表， source vpc id应仅包含小写字母、数字或中划线。
        /// </summary>
        [SDKProperty("access_control_source_vpc_ids", IsQuery = true)]
        [JsonProperty("access_control_source_vpc_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AccessControlSourceVpcIds { get; set; }

        /// <summary>
        /// 允许访问资源栈模板的source ip列表，source ip应是具有CIDR表示法且带有子网掩码的IPv4地址。
        /// </summary>
        [SDKProperty("access_control_source_ips", IsQuery = true)]
        [JsonProperty("access_control_source_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AccessControlSourceIps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTemplateVersionContentRequest {\n");
            sb.Append("  clientRequestId: ").Append(ClientRequestId).Append("\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  versionId: ").Append(VersionId).Append("\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  accessControlSourceVpcIds: ").Append(AccessControlSourceVpcIds).Append("\n");
            sb.Append("  accessControlSourceIps: ").Append(AccessControlSourceIps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTemplateVersionContentRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTemplateVersionContentRequest input)
        {
            if (input == null) return false;
            if (this.ClientRequestId != input.ClientRequestId || (this.ClientRequestId != null && !this.ClientRequestId.Equals(input.ClientRequestId))) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;
            if (this.VersionId != input.VersionId || (this.VersionId != null && !this.VersionId.Equals(input.VersionId))) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.AccessControlSourceVpcIds != input.AccessControlSourceVpcIds || (this.AccessControlSourceVpcIds != null && input.AccessControlSourceVpcIds != null && !this.AccessControlSourceVpcIds.SequenceEqual(input.AccessControlSourceVpcIds))) return false;
            if (this.AccessControlSourceIps != input.AccessControlSourceIps || (this.AccessControlSourceIps != null && input.AccessControlSourceIps != null && !this.AccessControlSourceIps.SequenceEqual(input.AccessControlSourceIps))) return false;

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
                if (this.ClientRequestId != null) hashCode = hashCode * 59 + this.ClientRequestId.GetHashCode();
                if (this.TemplateName != null) hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.VersionId != null) hashCode = hashCode * 59 + this.VersionId.GetHashCode();
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.AccessControlSourceVpcIds != null) hashCode = hashCode * 59 + this.AccessControlSourceVpcIds.GetHashCode();
                if (this.AccessControlSourceIps != null) hashCode = hashCode * 59 + this.AccessControlSourceIps.GetHashCode();
                return hashCode;
            }
        }
    }
}
