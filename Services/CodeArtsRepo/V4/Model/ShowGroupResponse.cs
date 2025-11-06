using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowGroupResponse : SdkResponse
    {
        /// <summary>
        /// 可见性, private public
        /// </summary>
        /// <value>可见性, private public</value>
        [JsonConverter(typeof(EnumClassConverter<VisibilityEnum>))]
        public class VisibilityEnum
        {
            /// <summary>
            /// Enum PUBLIC for value: public
            /// </summary>
            public static readonly VisibilityEnum PUBLIC = new VisibilityEnum("public");

            /// <summary>
            /// Enum PRIVATE for value: private
            /// </summary>
            public static readonly VisibilityEnum PRIVATE = new VisibilityEnum("private");

            private static readonly Dictionary<string, VisibilityEnum> StaticFields =
            new Dictionary<string, VisibilityEnum>()
            {
                { "public", PUBLIC },
                { "private", PRIVATE },
            };

            private string _value;

            public VisibilityEnum()
            {

            }

            public VisibilityEnum(string value)
            {
                _value = value;
            }

            public static VisibilityEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as VisibilityEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VisibilityEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VisibilityEnum a, VisibilityEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(VisibilityEnum a, VisibilityEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 创建者id
        /// </summary>
        [JsonProperty("creator_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatorId { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 代码组全名
        /// </summary>
        [JsonProperty("full_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FullName { get; set; }

        /// <summary>
        /// 代码组层级路径id
        /// </summary>
        [JsonProperty("ancestor_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> AncestorIds { get; set; }

        /// <summary>
        /// 代码组层级路径名称
        /// </summary>
        [JsonProperty("ancestor_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AncestorNames { get; set; }

        /// <summary>
        /// 代码组id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 代码组成员计数
        /// </summary>
        [JsonProperty("members_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MembersCount { get; set; }

        /// <summary>
        /// 代码组名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 仓库计数
        /// </summary>
        [JsonProperty("repository_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryCount { get; set; }

        /// <summary>
        /// 关注计数
        /// </summary>
        [JsonProperty("star_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? StarCount { get; set; }

        /// <summary>
        /// 是否关注
        /// </summary>
        [JsonProperty("starred", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Starred { get; set; }

        /// <summary>
        /// 子组计数
        /// </summary>
        [JsonProperty("subgroup_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubgroupCount { get; set; }

        /// <summary>
        /// 可见性, private public
        /// </summary>
        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public VisibilityEnum Visibility { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sum", NullValueHandling = NullValueHandling.Ignore)]
        public GroupSumDto Sum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGroupResponse {\n");
            sb.Append("  creatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  fullName: ").Append(FullName).Append("\n");
            sb.Append("  ancestorIds: ").Append(AncestorIds).Append("\n");
            sb.Append("  ancestorNames: ").Append(AncestorNames).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  membersCount: ").Append(MembersCount).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  repositoryCount: ").Append(RepositoryCount).Append("\n");
            sb.Append("  starCount: ").Append(StarCount).Append("\n");
            sb.Append("  starred: ").Append(Starred).Append("\n");
            sb.Append("  subgroupCount: ").Append(SubgroupCount).Append("\n");
            sb.Append("  visibility: ").Append(Visibility).Append("\n");
            sb.Append("  sum: ").Append(Sum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGroupResponse input)
        {
            if (input == null) return false;
            if (this.CreatorId != input.CreatorId || (this.CreatorId != null && !this.CreatorId.Equals(input.CreatorId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.FullName != input.FullName || (this.FullName != null && !this.FullName.Equals(input.FullName))) return false;
            if (this.AncestorIds != input.AncestorIds || (this.AncestorIds != null && input.AncestorIds != null && !this.AncestorIds.SequenceEqual(input.AncestorIds))) return false;
            if (this.AncestorNames != input.AncestorNames || (this.AncestorNames != null && input.AncestorNames != null && !this.AncestorNames.SequenceEqual(input.AncestorNames))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.MembersCount != input.MembersCount || (this.MembersCount != null && !this.MembersCount.Equals(input.MembersCount))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.RepositoryCount != input.RepositoryCount || (this.RepositoryCount != null && !this.RepositoryCount.Equals(input.RepositoryCount))) return false;
            if (this.StarCount != input.StarCount || (this.StarCount != null && !this.StarCount.Equals(input.StarCount))) return false;
            if (this.Starred != input.Starred || (this.Starred != null && !this.Starred.Equals(input.Starred))) return false;
            if (this.SubgroupCount != input.SubgroupCount || (this.SubgroupCount != null && !this.SubgroupCount.Equals(input.SubgroupCount))) return false;
            if (this.Visibility != input.Visibility) return false;
            if (this.Sum != input.Sum || (this.Sum != null && !this.Sum.Equals(input.Sum))) return false;

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
                if (this.CreatorId != null) hashCode = hashCode * 59 + this.CreatorId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FullName != null) hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.AncestorIds != null) hashCode = hashCode * 59 + this.AncestorIds.GetHashCode();
                if (this.AncestorNames != null) hashCode = hashCode * 59 + this.AncestorNames.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MembersCount != null) hashCode = hashCode * 59 + this.MembersCount.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RepositoryCount != null) hashCode = hashCode * 59 + this.RepositoryCount.GetHashCode();
                if (this.StarCount != null) hashCode = hashCode * 59 + this.StarCount.GetHashCode();
                if (this.Starred != null) hashCode = hashCode * 59 + this.Starred.GetHashCode();
                if (this.SubgroupCount != null) hashCode = hashCode * 59 + this.SubgroupCount.GetHashCode();
                hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                if (this.Sum != null) hashCode = hashCode * 59 + this.Sum.GetHashCode();
                return hashCode;
            }
        }
    }
}
