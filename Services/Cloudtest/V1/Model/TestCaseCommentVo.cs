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
    /// 实际的数据类型：单个对象，集合 或 NULL
    /// </summary>
    public class TestCaseCommentVo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("notifier", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Notifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("test_case_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 创建时间时间戳
        /// </summary>
        [JsonProperty("create_time_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTimeTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 更新时间时间戳
        /// </summary>
        [JsonProperty("update_time_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTimeTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCaseCommentVo {\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("  notifier: ").Append(Notifier).Append("\n");
            sb.Append("  testCaseUri: ").Append(TestCaseUri).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  createTimeTimestamp: ").Append(CreateTimeTimestamp).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  updateTimeTimestamp: ").Append(UpdateTimeTimestamp).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestCaseCommentVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestCaseCommentVo input)
        {
            if (input == null) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.Comment != input.Comment || (this.Comment != null && !this.Comment.Equals(input.Comment))) return false;
            if (this.Notifier != input.Notifier || (this.Notifier != null && input.Notifier != null && !this.Notifier.SequenceEqual(input.Notifier))) return false;
            if (this.TestCaseUri != input.TestCaseUri || (this.TestCaseUri != null && !this.TestCaseUri.Equals(input.TestCaseUri))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CreateTimeTimestamp != input.CreateTimeTimestamp || (this.CreateTimeTimestamp != null && !this.CreateTimeTimestamp.Equals(input.CreateTimeTimestamp))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.UpdateTimeTimestamp != input.UpdateTimeTimestamp || (this.UpdateTimeTimestamp != null && !this.UpdateTimeTimestamp.Equals(input.UpdateTimeTimestamp))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.VersionUri != input.VersionUri || (this.VersionUri != null && !this.VersionUri.Equals(input.VersionUri))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;

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
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Comment != null) hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Notifier != null) hashCode = hashCode * 59 + this.Notifier.GetHashCode();
                if (this.TestCaseUri != null) hashCode = hashCode * 59 + this.TestCaseUri.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CreateTimeTimestamp != null) hashCode = hashCode * 59 + this.CreateTimeTimestamp.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.UpdateTimeTimestamp != null) hashCode = hashCode * 59 + this.UpdateTimeTimestamp.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                return hashCode;
            }
        }
    }
}
