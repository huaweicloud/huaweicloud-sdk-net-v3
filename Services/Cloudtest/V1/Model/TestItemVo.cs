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
    public class TestItemVo 
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
        /// 责任人
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// frequence值
        /// </summary>
        [JsonProperty("frequence", NullValueHandling = NullValueHandling.Ignore)]
        public string Frequence { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

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
        /// 是否特性
        /// </summary>
        [JsonProperty("is_feature", NullValueHandling = NullValueHandling.Ignore)]
        public string IsFeature { get; set; }

        /// <summary>
        /// 是否关联特性
        /// </summary>
        [JsonProperty("relate_htsm", NullValueHandling = NullValueHandling.Ignore)]
        public string RelateHtsm { get; set; }

        /// <summary>
        /// aw id
        /// </summary>
        [JsonProperty("aw_unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AwUniqueId { get; set; }

        /// <summary>
        /// 脑图id
        /// </summary>
        [JsonProperty("test_mind_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TestMindId { get; set; }

        /// <summary>
        /// 脑图url
        /// </summary>
        [JsonProperty("test_mind_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TestMindUrl { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 用例总数
        /// </summary>
        [JsonProperty("case_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? CaseTotal { get; set; }

        /// <summary>
        /// 执行总数
        /// </summary>
        [JsonProperty("execd_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecdTotal { get; set; }

        /// <summary>
        /// is_direct_relation
        /// </summary>
        [JsonProperty("is_direct_relation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDirectRelation { get; set; }

        /// <summary>
        /// 是否有子特性
        /// </summary>
        [JsonProperty("has_child", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasChild { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestItemVo {\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  rank: ").Append(Rank).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  frequence: ").Append(Frequence).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
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
            sb.Append("  isFeature: ").Append(IsFeature).Append("\n");
            sb.Append("  relateHtsm: ").Append(RelateHtsm).Append("\n");
            sb.Append("  awUniqueId: ").Append(AwUniqueId).Append("\n");
            sb.Append("  testMindId: ").Append(TestMindId).Append("\n");
            sb.Append("  testMindUrl: ").Append(TestMindUrl).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  caseTotal: ").Append(CaseTotal).Append("\n");
            sb.Append("  execdTotal: ").Append(ExecdTotal).Append("\n");
            sb.Append("  isDirectRelation: ").Append(IsDirectRelation).Append("\n");
            sb.Append("  hasChild: ").Append(HasChild).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestItemVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestItemVo input)
        {
            if (input == null) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Rank != input.Rank || (this.Rank != null && !this.Rank.Equals(input.Rank))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.Frequence != input.Frequence || (this.Frequence != null && !this.Frequence.Equals(input.Frequence))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
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
            if (this.IsFeature != input.IsFeature || (this.IsFeature != null && !this.IsFeature.Equals(input.IsFeature))) return false;
            if (this.RelateHtsm != input.RelateHtsm || (this.RelateHtsm != null && !this.RelateHtsm.Equals(input.RelateHtsm))) return false;
            if (this.AwUniqueId != input.AwUniqueId || (this.AwUniqueId != null && !this.AwUniqueId.Equals(input.AwUniqueId))) return false;
            if (this.TestMindId != input.TestMindId || (this.TestMindId != null && !this.TestMindId.Equals(input.TestMindId))) return false;
            if (this.TestMindUrl != input.TestMindUrl || (this.TestMindUrl != null && !this.TestMindUrl.Equals(input.TestMindUrl))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.CaseTotal != input.CaseTotal || (this.CaseTotal != null && !this.CaseTotal.Equals(input.CaseTotal))) return false;
            if (this.ExecdTotal != input.ExecdTotal || (this.ExecdTotal != null && !this.ExecdTotal.Equals(input.ExecdTotal))) return false;
            if (this.IsDirectRelation != input.IsDirectRelation || (this.IsDirectRelation != null && !this.IsDirectRelation.Equals(input.IsDirectRelation))) return false;
            if (this.HasChild != input.HasChild || (this.HasChild != null && !this.HasChild.Equals(input.HasChild))) return false;

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
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Frequence != null) hashCode = hashCode * 59 + this.Frequence.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
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
                if (this.IsFeature != null) hashCode = hashCode * 59 + this.IsFeature.GetHashCode();
                if (this.RelateHtsm != null) hashCode = hashCode * 59 + this.RelateHtsm.GetHashCode();
                if (this.AwUniqueId != null) hashCode = hashCode * 59 + this.AwUniqueId.GetHashCode();
                if (this.TestMindId != null) hashCode = hashCode * 59 + this.TestMindId.GetHashCode();
                if (this.TestMindUrl != null) hashCode = hashCode * 59 + this.TestMindUrl.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.CaseTotal != null) hashCode = hashCode * 59 + this.CaseTotal.GetHashCode();
                if (this.ExecdTotal != null) hashCode = hashCode * 59 + this.ExecdTotal.GetHashCode();
                if (this.IsDirectRelation != null) hashCode = hashCode * 59 + this.IsDirectRelation.GetHashCode();
                if (this.HasChild != null) hashCode = hashCode * 59 + this.HasChild.GetHashCode();
                return hashCode;
            }
        }
    }
}
