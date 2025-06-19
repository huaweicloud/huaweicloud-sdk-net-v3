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
    /// 
    /// </summary>
    public class MindmapPageParamV3 
    {

        /// <summary>
        /// 目录ID集合
        /// </summary>
        [JsonProperty("folder_id_collection", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FolderIdCollection { get; set; }

        /// <summary>
        /// 创建者ID集合
        /// </summary>
        [JsonProperty("creator_num_collection", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CreatorNumCollection { get; set; }

        /// <summary>
        /// 更新人ID集合
        /// </summary>
        [JsonProperty("updater_num_collection", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UpdaterNumCollection { get; set; }

        /// <summary>
        /// 根目录ID
        /// </summary>
        [JsonProperty("folder_root_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FolderRootId { get; set; }

        /// <summary>
        /// 主键ID集合
        /// </summary>
        [JsonProperty("id_collection", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IdCollection { get; set; }

        /// <summary>
        /// 起始偏移量，表示从此偏移量开始查询，offset大于等于0，小于等于100000
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页显示的条目数量，最大支持200条
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 脑图名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 分支uri
        /// </summary>
        [JsonProperty("branch_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchUri { get; set; }

        /// <summary>
        /// 是否基线
        /// </summary>
        [JsonProperty("is_master", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsMaster { get; set; }

        /// <summary>
        /// 计划uri
        /// </summary>
        [JsonProperty("iterator_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string IteratorUri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MindmapPageParamV3 {\n");
            sb.Append("  folderIdCollection: ").Append(FolderIdCollection).Append("\n");
            sb.Append("  creatorNumCollection: ").Append(CreatorNumCollection).Append("\n");
            sb.Append("  updaterNumCollection: ").Append(UpdaterNumCollection).Append("\n");
            sb.Append("  folderRootId: ").Append(FolderRootId).Append("\n");
            sb.Append("  idCollection: ").Append(IdCollection).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  branchUri: ").Append(BranchUri).Append("\n");
            sb.Append("  isMaster: ").Append(IsMaster).Append("\n");
            sb.Append("  iteratorUri: ").Append(IteratorUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MindmapPageParamV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MindmapPageParamV3 input)
        {
            if (input == null) return false;
            if (this.FolderIdCollection != input.FolderIdCollection || (this.FolderIdCollection != null && input.FolderIdCollection != null && !this.FolderIdCollection.SequenceEqual(input.FolderIdCollection))) return false;
            if (this.CreatorNumCollection != input.CreatorNumCollection || (this.CreatorNumCollection != null && input.CreatorNumCollection != null && !this.CreatorNumCollection.SequenceEqual(input.CreatorNumCollection))) return false;
            if (this.UpdaterNumCollection != input.UpdaterNumCollection || (this.UpdaterNumCollection != null && input.UpdaterNumCollection != null && !this.UpdaterNumCollection.SequenceEqual(input.UpdaterNumCollection))) return false;
            if (this.FolderRootId != input.FolderRootId || (this.FolderRootId != null && !this.FolderRootId.Equals(input.FolderRootId))) return false;
            if (this.IdCollection != input.IdCollection || (this.IdCollection != null && input.IdCollection != null && !this.IdCollection.SequenceEqual(input.IdCollection))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.BranchUri != input.BranchUri || (this.BranchUri != null && !this.BranchUri.Equals(input.BranchUri))) return false;
            if (this.IsMaster != input.IsMaster || (this.IsMaster != null && !this.IsMaster.Equals(input.IsMaster))) return false;
            if (this.IteratorUri != input.IteratorUri || (this.IteratorUri != null && !this.IteratorUri.Equals(input.IteratorUri))) return false;

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
                if (this.FolderIdCollection != null) hashCode = hashCode * 59 + this.FolderIdCollection.GetHashCode();
                if (this.CreatorNumCollection != null) hashCode = hashCode * 59 + this.CreatorNumCollection.GetHashCode();
                if (this.UpdaterNumCollection != null) hashCode = hashCode * 59 + this.UpdaterNumCollection.GetHashCode();
                if (this.FolderRootId != null) hashCode = hashCode * 59 + this.FolderRootId.GetHashCode();
                if (this.IdCollection != null) hashCode = hashCode * 59 + this.IdCollection.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.BranchUri != null) hashCode = hashCode * 59 + this.BranchUri.GetHashCode();
                if (this.IsMaster != null) hashCode = hashCode * 59 + this.IsMaster.GetHashCode();
                if (this.IteratorUri != null) hashCode = hashCode * 59 + this.IteratorUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
