using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class UpdateTestReportCustomDetailByUriRequest 
    {

        /// <summary>
        /// 用户Token。  通过调用IAM服务获取用户Token接口获取（响应消息头中X-Subject-Token的值）。
        /// </summary>
        [SDKProperty("X-Auth-Token", IsHeader = true)]
        [JsonProperty("X-Auth-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string XAuthToken { get; set; }

        /// <summary>
        /// 项目ID，固定长度32位字符（字母和数字）。
        /// </summary>
        [SDKProperty("project_id", IsPath = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 计划uri
        /// </summary>
        [SDKProperty("version_uri", IsPath = true)]
        [JsonProperty("version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionUri { get; set; }

        /// <summary>
        /// 测试报告Uri
        /// </summary>
        [SDKProperty("report_uri", IsPath = true)]
        [JsonProperty("report_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportUri { get; set; }

        /// <summary>
        /// 测试报告自定义模块Uri
        /// </summary>
        [SDKProperty("custom_info_uri", IsPath = true)]
        [JsonProperty("custom_info_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomInfoUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public TestReportCustomDetailInfo Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTestReportCustomDetailByUriRequest {\n");
            sb.Append("  xAuthToken: ").Append(XAuthToken).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("  reportUri: ").Append(ReportUri).Append("\n");
            sb.Append("  customInfoUri: ").Append(CustomInfoUri).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTestReportCustomDetailByUriRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTestReportCustomDetailByUriRequest input)
        {
            if (input == null) return false;
            if (this.XAuthToken != input.XAuthToken || (this.XAuthToken != null && !this.XAuthToken.Equals(input.XAuthToken))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.VersionUri != input.VersionUri || (this.VersionUri != null && !this.VersionUri.Equals(input.VersionUri))) return false;
            if (this.ReportUri != input.ReportUri || (this.ReportUri != null && !this.ReportUri.Equals(input.ReportUri))) return false;
            if (this.CustomInfoUri != input.CustomInfoUri || (this.CustomInfoUri != null && !this.CustomInfoUri.Equals(input.CustomInfoUri))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.XAuthToken != null) hashCode = hashCode * 59 + this.XAuthToken.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                if (this.ReportUri != null) hashCode = hashCode * 59 + this.ReportUri.GetHashCode();
                if (this.CustomInfoUri != null) hashCode = hashCode * 59 + this.CustomInfoUri.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
