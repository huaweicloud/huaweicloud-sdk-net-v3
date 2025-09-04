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
    public class DeleteCacheFileRequest 
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
        /// 删除附件路径
        /// </summary>
        [SDKProperty("file_path", IsQuery = true)]
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// 附件Uri
        /// </summary>
        [SDKProperty("uri", IsQuery = true)]
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 附件挂载资源Uri
        /// </summary>
        [SDKProperty("parent_uri", IsQuery = true)]
        [JsonProperty("parent_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentUri { get; set; }

        /// <summary>
        /// 是否备份
        /// </summary>
        [SDKProperty("bak_up", IsQuery = true)]
        [JsonProperty("bak_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BakUp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteCacheFileRequest {\n");
            sb.Append("  xAuthToken: ").Append(XAuthToken).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  parentUri: ").Append(ParentUri).Append("\n");
            sb.Append("  bakUp: ").Append(BakUp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteCacheFileRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteCacheFileRequest input)
        {
            if (input == null) return false;
            if (this.XAuthToken != input.XAuthToken || (this.XAuthToken != null && !this.XAuthToken.Equals(input.XAuthToken))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.ParentUri != input.ParentUri || (this.ParentUri != null && !this.ParentUri.Equals(input.ParentUri))) return false;
            if (this.BakUp != input.BakUp || (this.BakUp != null && !this.BakUp.Equals(input.BakUp))) return false;

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
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.ParentUri != null) hashCode = hashCode * 59 + this.ParentUri.GetHashCode();
                if (this.BakUp != null) hashCode = hashCode * 59 + this.BakUp.GetHashCode();
                return hashCode;
            }
        }
    }
}
