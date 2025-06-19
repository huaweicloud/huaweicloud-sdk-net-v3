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
    public class DeleteTestCaseCommentRequest 
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
        /// 用例uri
        /// </summary>
        [SDKProperty("testcase_id", IsPath = true)]
        [JsonProperty("testcase_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TestcaseId { get; set; }

        /// <summary>
        /// 评论uri
        /// </summary>
        [SDKProperty("comment_id", IsPath = true)]
        [JsonProperty("comment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommentId { get; set; }

        /// <summary>
        /// 分支或者测试计划uri
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
            sb.Append("class DeleteTestCaseCommentRequest {\n");
            sb.Append("  xAuthToken: ").Append(XAuthToken).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  testcaseId: ").Append(TestcaseId).Append("\n");
            sb.Append("  commentId: ").Append(CommentId).Append("\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTestCaseCommentRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTestCaseCommentRequest input)
        {
            if (input == null) return false;
            if (this.XAuthToken != input.XAuthToken || (this.XAuthToken != null && !this.XAuthToken.Equals(input.XAuthToken))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.TestcaseId != input.TestcaseId || (this.TestcaseId != null && !this.TestcaseId.Equals(input.TestcaseId))) return false;
            if (this.CommentId != input.CommentId || (this.CommentId != null && !this.CommentId.Equals(input.CommentId))) return false;
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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.TestcaseId != null) hashCode = hashCode * 59 + this.TestcaseId.GetHashCode();
                if (this.CommentId != null) hashCode = hashCode * 59 + this.CommentId.GetHashCode();
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
