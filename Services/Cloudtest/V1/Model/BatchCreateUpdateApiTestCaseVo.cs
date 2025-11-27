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
    public class BatchCreateUpdateApiTestCaseVo 
    {

        /// <summary>
        /// 资源URI
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 级别
        /// </summary>
        [JsonProperty("rank", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        /// <summary>
        /// 最后修改人
        /// </summary>
        [JsonProperty("last_modifier", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModifier { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonProperty("last_modified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// 修改时间时间戳
        /// </summary>
        [JsonProperty("last_modified_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastModifiedTimestamp { get; set; }

        /// <summary>
        /// 最后变更时间
        /// </summary>
        [JsonProperty("last_change_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastChangeTime { get; set; }

        /// <summary>
        /// 版本URI
        /// </summary>
        [JsonProperty("version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionUri { get; set; }

        /// <summary>
        /// 源资源URI
        /// </summary>
        [JsonProperty("origin_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginUri { get; set; }

        /// <summary>
        /// 父资源URI
        /// </summary>
        [JsonProperty("parent_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentUri { get; set; }

        /// <summary>
        /// 父资源路径
        /// </summary>
        [JsonProperty("parent_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentPath { get; set; }

        /// <summary>
        /// 创建版本URI
        /// </summary>
        [JsonProperty("creation_version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationVersionUri { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("creation_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// 创建时间时间戳
        /// </summary>
        [JsonProperty("creation_date_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreationDateTimestamp { get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        [JsonProperty("author_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 创建成功的用例列表
        /// </summary>
        [JsonProperty("success_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TestCaseVo> SuccessList { get; set; }

        /// <summary>
        /// 创建失败的用例列表
        /// </summary>
        [JsonProperty("failed_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<TestCaseInfo> FailedList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreateUpdateApiTestCaseVo {\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  rank: ").Append(Rank).Append("\n");
            sb.Append("  lastModifier: ").Append(LastModifier).Append("\n");
            sb.Append("  lastModified: ").Append(LastModified).Append("\n");
            sb.Append("  lastModifiedTimestamp: ").Append(LastModifiedTimestamp).Append("\n");
            sb.Append("  lastChangeTime: ").Append(LastChangeTime).Append("\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("  originUri: ").Append(OriginUri).Append("\n");
            sb.Append("  parentUri: ").Append(ParentUri).Append("\n");
            sb.Append("  parentPath: ").Append(ParentPath).Append("\n");
            sb.Append("  creationVersionUri: ").Append(CreationVersionUri).Append("\n");
            sb.Append("  creationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  creationDateTimestamp: ").Append(CreationDateTimestamp).Append("\n");
            sb.Append("  authorName: ").Append(AuthorName).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  successList: ").Append(SuccessList).Append("\n");
            sb.Append("  failedList: ").Append(FailedList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCreateUpdateApiTestCaseVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreateUpdateApiTestCaseVo input)
        {
            if (input == null) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Rank != input.Rank || (this.Rank != null && !this.Rank.Equals(input.Rank))) return false;
            if (this.LastModifier != input.LastModifier || (this.LastModifier != null && !this.LastModifier.Equals(input.LastModifier))) return false;
            if (this.LastModified != input.LastModified || (this.LastModified != null && !this.LastModified.Equals(input.LastModified))) return false;
            if (this.LastModifiedTimestamp != input.LastModifiedTimestamp || (this.LastModifiedTimestamp != null && !this.LastModifiedTimestamp.Equals(input.LastModifiedTimestamp))) return false;
            if (this.LastChangeTime != input.LastChangeTime || (this.LastChangeTime != null && !this.LastChangeTime.Equals(input.LastChangeTime))) return false;
            if (this.VersionUri != input.VersionUri || (this.VersionUri != null && !this.VersionUri.Equals(input.VersionUri))) return false;
            if (this.OriginUri != input.OriginUri || (this.OriginUri != null && !this.OriginUri.Equals(input.OriginUri))) return false;
            if (this.ParentUri != input.ParentUri || (this.ParentUri != null && !this.ParentUri.Equals(input.ParentUri))) return false;
            if (this.ParentPath != input.ParentPath || (this.ParentPath != null && !this.ParentPath.Equals(input.ParentPath))) return false;
            if (this.CreationVersionUri != input.CreationVersionUri || (this.CreationVersionUri != null && !this.CreationVersionUri.Equals(input.CreationVersionUri))) return false;
            if (this.CreationDate != input.CreationDate || (this.CreationDate != null && !this.CreationDate.Equals(input.CreationDate))) return false;
            if (this.CreationDateTimestamp != input.CreationDateTimestamp || (this.CreationDateTimestamp != null && !this.CreationDateTimestamp.Equals(input.CreationDateTimestamp))) return false;
            if (this.AuthorName != input.AuthorName || (this.AuthorName != null && !this.AuthorName.Equals(input.AuthorName))) return false;
            if (this.Comment != input.Comment || (this.Comment != null && !this.Comment.Equals(input.Comment))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.SuccessList != input.SuccessList || (this.SuccessList != null && input.SuccessList != null && !this.SuccessList.SequenceEqual(input.SuccessList))) return false;
            if (this.FailedList != input.FailedList || (this.FailedList != null && input.FailedList != null && !this.FailedList.SequenceEqual(input.FailedList))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Rank != null) hashCode = hashCode * 59 + this.Rank.GetHashCode();
                if (this.LastModifier != null) hashCode = hashCode * 59 + this.LastModifier.GetHashCode();
                if (this.LastModified != null) hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.LastModifiedTimestamp != null) hashCode = hashCode * 59 + this.LastModifiedTimestamp.GetHashCode();
                if (this.LastChangeTime != null) hashCode = hashCode * 59 + this.LastChangeTime.GetHashCode();
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                if (this.OriginUri != null) hashCode = hashCode * 59 + this.OriginUri.GetHashCode();
                if (this.ParentUri != null) hashCode = hashCode * 59 + this.ParentUri.GetHashCode();
                if (this.ParentPath != null) hashCode = hashCode * 59 + this.ParentPath.GetHashCode();
                if (this.CreationVersionUri != null) hashCode = hashCode * 59 + this.CreationVersionUri.GetHashCode();
                if (this.CreationDate != null) hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.CreationDateTimestamp != null) hashCode = hashCode * 59 + this.CreationDateTimestamp.GetHashCode();
                if (this.AuthorName != null) hashCode = hashCode * 59 + this.AuthorName.GetHashCode();
                if (this.Comment != null) hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.SuccessList != null) hashCode = hashCode * 59 + this.SuccessList.GetHashCode();
                if (this.FailedList != null) hashCode = hashCode * 59 + this.FailedList.GetHashCode();
                return hashCode;
            }
        }
    }
}
