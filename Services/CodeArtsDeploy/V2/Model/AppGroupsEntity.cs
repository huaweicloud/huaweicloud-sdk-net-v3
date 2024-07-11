using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 分组信息
    /// </summary>
    public class AppGroupsEntity 
    {

        /// <summary>
        /// 分组id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 分组名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 分组路径
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// 父分组id，首层为null
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// 分组排序字段
        /// </summary>
        [JsonProperty("ordinal", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ordinal { get; set; }

        /// <summary>
        /// 分组创建者用户id
        /// </summary>
        [JsonProperty("create_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateUserId { get; set; }

        /// <summary>
        /// 最近一次更新该分组用户id
        /// </summary>
        [JsonProperty("last_update_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateUserId { get; set; }

        /// <summary>
        /// 该分组应用总数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 子分组列表
        /// </summary>
        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public List<AppGroupsEntity> Children { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppGroupsEntity {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  ordinal: ").Append(Ordinal).Append("\n");
            sb.Append("  createUserId: ").Append(CreateUserId).Append("\n");
            sb.Append("  lastUpdateUserId: ").Append(LastUpdateUserId).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  children: ").Append(Children).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppGroupsEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppGroupsEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.Ordinal == input.Ordinal ||
                    (this.Ordinal != null &&
                    this.Ordinal.Equals(input.Ordinal))
                ) && 
                (
                    this.CreateUserId == input.CreateUserId ||
                    (this.CreateUserId != null &&
                    this.CreateUserId.Equals(input.CreateUserId))
                ) && 
                (
                    this.LastUpdateUserId == input.LastUpdateUserId ||
                    (this.LastUpdateUserId != null &&
                    this.LastUpdateUserId.Equals(input.LastUpdateUserId))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    input.Children != null &&
                    this.Children.SequenceEqual(input.Children)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Ordinal != null)
                    hashCode = hashCode * 59 + this.Ordinal.GetHashCode();
                if (this.CreateUserId != null)
                    hashCode = hashCode * 59 + this.CreateUserId.GetHashCode();
                if (this.LastUpdateUserId != null)
                    hashCode = hashCode * 59 + this.LastUpdateUserId.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
                return hashCode;
            }
        }
    }
}
