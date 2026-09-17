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
    public class ShowTaskRequest 
    {

        /// <summary>
        /// 用户Token。 通过调用IAM服务获取用户Token接口获取（响应消息头中X-Subject-Token的值）。
        /// </summary>
        [SDKProperty("X-Auth-Token", IsHeader = true)]
        [JsonProperty("X-Auth-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string XAuthToken { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [SDKProperty("project_uuid", IsPath = true)]
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 测试套件uri
        /// </summary>
        [SDKProperty("task_uri", IsPath = true)]
        [JsonProperty("task_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskUri { get; set; }

        /// <summary>
        /// 分支/迭代uri
        /// </summary>
        [SDKProperty("version_uri", IsQuery = true)]
        [JsonProperty("version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionUri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTaskRequest {\n");
            sb.Append("  xAuthToken: ").Append(XAuthToken).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  taskUri: ").Append(TaskUri).Append("\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTaskRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTaskRequest input)
        {
            if (input == null) return false;
            if (this.XAuthToken != input.XAuthToken || (this.XAuthToken != null && !this.XAuthToken.Equals(input.XAuthToken))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.TaskUri != input.TaskUri || (this.TaskUri != null && !this.TaskUri.Equals(input.TaskUri))) return false;
            if (this.VersionUri != input.VersionUri || (this.VersionUri != null && !this.VersionUri.Equals(input.VersionUri))) return false;

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
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.TaskUri != null) hashCode = hashCode * 59 + this.TaskUri.GetHashCode();
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
