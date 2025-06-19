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
    public class TestCaseReviewVo 
    {

        /// <summary>
        /// 评审URI
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 用例名称
        /// </summary>
        [JsonProperty("testcase_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TestcaseName { get; set; }

        /// <summary>
        /// 用例编号
        /// </summary>
        [JsonProperty("testcase_number", NullValueHandling = NullValueHandling.Ignore)]
        public string TestcaseNumber { get; set; }

        /// <summary>
        /// 用例阶段
        /// </summary>
        [JsonProperty("testcase_stage", NullValueHandling = NullValueHandling.Ignore)]
        public string TestcaseStage { get; set; }

        /// <summary>
        /// 用例修改时间
        /// </summary>
        [JsonProperty("testcase_last_modified", NullValueHandling = NullValueHandling.Ignore)]
        public string TestcaseLastModified { get; set; }

        /// <summary>
        /// 用例修改时间时间戳
        /// </summary>
        [JsonProperty("testcase_last_modified_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? TestcaseLastModifiedTimestamp { get; set; }

        /// <summary>
        /// 分支用例URI
        /// </summary>
        [JsonProperty("testcase_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TestcaseUri { get; set; }

        /// <summary>
        /// 版本URI
        /// </summary>
        [JsonProperty("version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionUri { get; set; }

        /// <summary>
        /// 版本名称
        /// </summary>
        [JsonProperty("version_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionName { get; set; }

        /// <summary>
        /// 评审意见
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// 闭环意见
        /// </summary>
        [JsonProperty("close_comment", NullValueHandling = NullValueHandling.Ignore)]
        public string CloseComment { get; set; }

        /// <summary>
        /// 评审人
        /// </summary>
        [JsonProperty("reviewer", NullValueHandling = NullValueHandling.Ignore)]
        public string Reviewer { get; set; }

        /// <summary>
        /// 评审创建时间
        /// </summary>
        [JsonProperty("creation_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationDate { get; set; }

        /// <summary>
        /// 评审创建时间时间戳
        /// </summary>
        [JsonProperty("creation_date_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreationDateTimestamp { get; set; }

        /// <summary>
        /// 指定的闭环人列表
        /// </summary>
        [JsonProperty("close_user_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<NameAndIdVo> CloseUserIds { get; set; }

        /// <summary>
        /// 实际闭环人
        /// </summary>
        [JsonProperty("actual_close_person", NullValueHandling = NullValueHandling.Ignore)]
        public string ActualClosePerson { get; set; }

        /// <summary>
        /// 评审状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 评审闭环时间
        /// </summary>
        [JsonProperty("close_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CloseDate { get; set; }

        /// <summary>
        /// 评审闭环时间时间戳
        /// </summary>
        [JsonProperty("close_date_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? CloseDateTimestamp { get; set; }

        /// <summary>
        /// 期望闭环时间
        /// </summary>
        [JsonProperty("expect_close_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpectCloseDate { get; set; }

        /// <summary>
        /// 期望闭环时间时间戳
        /// </summary>
        [JsonProperty("expect_close_date_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpectCloseDateTimestamp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCaseReviewVo {\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  testcaseName: ").Append(TestcaseName).Append("\n");
            sb.Append("  testcaseNumber: ").Append(TestcaseNumber).Append("\n");
            sb.Append("  testcaseStage: ").Append(TestcaseStage).Append("\n");
            sb.Append("  testcaseLastModified: ").Append(TestcaseLastModified).Append("\n");
            sb.Append("  testcaseLastModifiedTimestamp: ").Append(TestcaseLastModifiedTimestamp).Append("\n");
            sb.Append("  testcaseUri: ").Append(TestcaseUri).Append("\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("  versionName: ").Append(VersionName).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("  closeComment: ").Append(CloseComment).Append("\n");
            sb.Append("  reviewer: ").Append(Reviewer).Append("\n");
            sb.Append("  creationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  creationDateTimestamp: ").Append(CreationDateTimestamp).Append("\n");
            sb.Append("  closeUserIds: ").Append(CloseUserIds).Append("\n");
            sb.Append("  actualClosePerson: ").Append(ActualClosePerson).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  closeDate: ").Append(CloseDate).Append("\n");
            sb.Append("  closeDateTimestamp: ").Append(CloseDateTimestamp).Append("\n");
            sb.Append("  expectCloseDate: ").Append(ExpectCloseDate).Append("\n");
            sb.Append("  expectCloseDateTimestamp: ").Append(ExpectCloseDateTimestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestCaseReviewVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestCaseReviewVo input)
        {
            if (input == null) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.TestcaseName != input.TestcaseName || (this.TestcaseName != null && !this.TestcaseName.Equals(input.TestcaseName))) return false;
            if (this.TestcaseNumber != input.TestcaseNumber || (this.TestcaseNumber != null && !this.TestcaseNumber.Equals(input.TestcaseNumber))) return false;
            if (this.TestcaseStage != input.TestcaseStage || (this.TestcaseStage != null && !this.TestcaseStage.Equals(input.TestcaseStage))) return false;
            if (this.TestcaseLastModified != input.TestcaseLastModified || (this.TestcaseLastModified != null && !this.TestcaseLastModified.Equals(input.TestcaseLastModified))) return false;
            if (this.TestcaseLastModifiedTimestamp != input.TestcaseLastModifiedTimestamp || (this.TestcaseLastModifiedTimestamp != null && !this.TestcaseLastModifiedTimestamp.Equals(input.TestcaseLastModifiedTimestamp))) return false;
            if (this.TestcaseUri != input.TestcaseUri || (this.TestcaseUri != null && !this.TestcaseUri.Equals(input.TestcaseUri))) return false;
            if (this.VersionUri != input.VersionUri || (this.VersionUri != null && !this.VersionUri.Equals(input.VersionUri))) return false;
            if (this.VersionName != input.VersionName || (this.VersionName != null && !this.VersionName.Equals(input.VersionName))) return false;
            if (this.Comment != input.Comment || (this.Comment != null && !this.Comment.Equals(input.Comment))) return false;
            if (this.CloseComment != input.CloseComment || (this.CloseComment != null && !this.CloseComment.Equals(input.CloseComment))) return false;
            if (this.Reviewer != input.Reviewer || (this.Reviewer != null && !this.Reviewer.Equals(input.Reviewer))) return false;
            if (this.CreationDate != input.CreationDate || (this.CreationDate != null && !this.CreationDate.Equals(input.CreationDate))) return false;
            if (this.CreationDateTimestamp != input.CreationDateTimestamp || (this.CreationDateTimestamp != null && !this.CreationDateTimestamp.Equals(input.CreationDateTimestamp))) return false;
            if (this.CloseUserIds != input.CloseUserIds || (this.CloseUserIds != null && input.CloseUserIds != null && !this.CloseUserIds.SequenceEqual(input.CloseUserIds))) return false;
            if (this.ActualClosePerson != input.ActualClosePerson || (this.ActualClosePerson != null && !this.ActualClosePerson.Equals(input.ActualClosePerson))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CloseDate != input.CloseDate || (this.CloseDate != null && !this.CloseDate.Equals(input.CloseDate))) return false;
            if (this.CloseDateTimestamp != input.CloseDateTimestamp || (this.CloseDateTimestamp != null && !this.CloseDateTimestamp.Equals(input.CloseDateTimestamp))) return false;
            if (this.ExpectCloseDate != input.ExpectCloseDate || (this.ExpectCloseDate != null && !this.ExpectCloseDate.Equals(input.ExpectCloseDate))) return false;
            if (this.ExpectCloseDateTimestamp != input.ExpectCloseDateTimestamp || (this.ExpectCloseDateTimestamp != null && !this.ExpectCloseDateTimestamp.Equals(input.ExpectCloseDateTimestamp))) return false;

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
                if (this.TestcaseName != null) hashCode = hashCode * 59 + this.TestcaseName.GetHashCode();
                if (this.TestcaseNumber != null) hashCode = hashCode * 59 + this.TestcaseNumber.GetHashCode();
                if (this.TestcaseStage != null) hashCode = hashCode * 59 + this.TestcaseStage.GetHashCode();
                if (this.TestcaseLastModified != null) hashCode = hashCode * 59 + this.TestcaseLastModified.GetHashCode();
                if (this.TestcaseLastModifiedTimestamp != null) hashCode = hashCode * 59 + this.TestcaseLastModifiedTimestamp.GetHashCode();
                if (this.TestcaseUri != null) hashCode = hashCode * 59 + this.TestcaseUri.GetHashCode();
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                if (this.VersionName != null) hashCode = hashCode * 59 + this.VersionName.GetHashCode();
                if (this.Comment != null) hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.CloseComment != null) hashCode = hashCode * 59 + this.CloseComment.GetHashCode();
                if (this.Reviewer != null) hashCode = hashCode * 59 + this.Reviewer.GetHashCode();
                if (this.CreationDate != null) hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.CreationDateTimestamp != null) hashCode = hashCode * 59 + this.CreationDateTimestamp.GetHashCode();
                if (this.CloseUserIds != null) hashCode = hashCode * 59 + this.CloseUserIds.GetHashCode();
                if (this.ActualClosePerson != null) hashCode = hashCode * 59 + this.ActualClosePerson.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CloseDate != null) hashCode = hashCode * 59 + this.CloseDate.GetHashCode();
                if (this.CloseDateTimestamp != null) hashCode = hashCode * 59 + this.CloseDateTimestamp.GetHashCode();
                if (this.ExpectCloseDate != null) hashCode = hashCode * 59 + this.ExpectCloseDate.GetHashCode();
                if (this.ExpectCloseDateTimestamp != null) hashCode = hashCode * 59 + this.ExpectCloseDateTimestamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
