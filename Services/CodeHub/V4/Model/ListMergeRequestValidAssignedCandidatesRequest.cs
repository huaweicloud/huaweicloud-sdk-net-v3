using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListMergeRequestValidAssignedCandidatesRequest 
    {
        /// <summary>
        /// **参数解释：** The type of assignee, merge user or approver
        /// </summary>
        /// <value>**参数解释：** The type of assignee, merge user or approver</value>
        [JsonConverter(typeof(EnumClassConverter<ViewEnum>))]
        public class ViewEnum
        {
            /// <summary>
            /// Enum APPROVER for value: approver
            /// </summary>
            public static readonly ViewEnum APPROVER = new ViewEnum("approver");

            /// <summary>
            /// Enum ASSIGNEE for value: assignee
            /// </summary>
            public static readonly ViewEnum ASSIGNEE = new ViewEnum("assignee");

            private static readonly Dictionary<string, ViewEnum> StaticFields =
            new Dictionary<string, ViewEnum>()
            {
                { "approver", APPROVER },
                { "assignee", ASSIGNEE },
            };

            private string _value;

            public ViewEnum()
            {

            }

            public ViewEnum(string value)
            {
                _value = value;
            }

            public static ViewEnum FromValue(string value)
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

                if (this.Equals(obj as ViewEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ViewEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ViewEnum a, ViewEnum b)
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

            public static bool operator !=(ViewEnum a, ViewEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** The type of assignee, merge user or approver
        /// </summary>
        /// <value>**参数解释：** The type of assignee, merge user or approver</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum APPROVER for value: approver
            /// </summary>
            public static readonly ModeEnum APPROVER = new ModeEnum("approver");

            /// <summary>
            /// Enum ASSIGNEE for value: assignee
            /// </summary>
            public static readonly ModeEnum ASSIGNEE = new ModeEnum("assignee");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "approver", APPROVER },
                { "assignee", ASSIGNEE },
            };

            private string _value;

            public ModeEnum()
            {

            }

            public ModeEnum(string value)
            {
                _value = value;
            }

            public static ModeEnum FromValue(string value)
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 仓库的ID，通过[[查询用户所有仓库](https://support.huaweicloud.com/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws)[[查询用户所有仓库](https://support.huaweicloud.com/intl/en-us/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm)接口查询项目列表获取。 **约束限制：** 不涉及。
        /// </summary>
        [SDKProperty("repository_id", IsPath = true)]
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// **参数解释：** 目标分支。创建MR时，代码将要合入的分支。
        /// </summary>
        [SDKProperty("target_branch", IsQuery = true)]
        [JsonProperty("target_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetBranch { get; set; }

        /// <summary>
        /// **参数解释：**  合并请求 iid。
        /// </summary>
        [SDKProperty("merge_request_iid", IsQuery = true)]
        [JsonProperty("merge_request_iid", NullValueHandling = NullValueHandling.Ignore)]
        public int? MergeRequestIid { get; set; }

        /// <summary>
        /// **参数解释：** 偏移量，从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释：** 返回数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释：** 查询关键字，可模糊匹配用户名称、用户昵称、租户名称。
        /// </summary>
        [SDKProperty("search", IsQuery = true)]
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// **参数解释：** Search user list by name list。
        /// </summary>
        [SDKProperty("search_by_name_list", IsQuery = true)]
        [JsonProperty("search_by_name_list", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchByNameList { get; set; }

        /// <summary>
        /// **参数解释：** 项目的32位uuid，项目唯一标识，通过[[查询项目列表](https://support.huaweicloud.com/api-projectman/ListProjectsV4.html)](tag:hws)[[查询项目列表](https://support.huaweicloud.com/intl/en-us/api-projectman/ListProjectsV4.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm)接口查询项目列表获取。 **取值范围：** 字符串长度32。
        /// </summary>
        [SDKProperty("target_project_id", IsQuery = true)]
        [JsonProperty("target_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetProjectId { get; set; }

        /// <summary>
        /// **参数解释：** The type of assignee, merge user or approver
        /// </summary>
        [SDKProperty("view", IsQuery = true)]
        [JsonProperty("view", NullValueHandling = NullValueHandling.Ignore)]
        public ViewEnum View { get; set; }
        /// <summary>
        /// **参数解释：** The type of assignee, merge user or approver
        /// </summary>
        [SDKProperty("mode", IsQuery = true)]
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// **参数解释：** The type of memeber, developer
        /// </summary>
        [SDKProperty("only_developers", IsQuery = true)]
        [JsonProperty("only_developers", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyDevelopers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMergeRequestValidAssignedCandidatesRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  targetBranch: ").Append(TargetBranch).Append("\n");
            sb.Append("  mergeRequestIid: ").Append(MergeRequestIid).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  search: ").Append(Search).Append("\n");
            sb.Append("  searchByNameList: ").Append(SearchByNameList).Append("\n");
            sb.Append("  targetProjectId: ").Append(TargetProjectId).Append("\n");
            sb.Append("  view: ").Append(View).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  onlyDevelopers: ").Append(OnlyDevelopers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMergeRequestValidAssignedCandidatesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMergeRequestValidAssignedCandidatesRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.TargetBranch != input.TargetBranch || (this.TargetBranch != null && !this.TargetBranch.Equals(input.TargetBranch))) return false;
            if (this.MergeRequestIid != input.MergeRequestIid || (this.MergeRequestIid != null && !this.MergeRequestIid.Equals(input.MergeRequestIid))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Search != input.Search || (this.Search != null && !this.Search.Equals(input.Search))) return false;
            if (this.SearchByNameList != input.SearchByNameList || (this.SearchByNameList != null && !this.SearchByNameList.Equals(input.SearchByNameList))) return false;
            if (this.TargetProjectId != input.TargetProjectId || (this.TargetProjectId != null && !this.TargetProjectId.Equals(input.TargetProjectId))) return false;
            if (this.View != input.View) return false;
            if (this.Mode != input.Mode) return false;
            if (this.OnlyDevelopers != input.OnlyDevelopers || (this.OnlyDevelopers != null && !this.OnlyDevelopers.Equals(input.OnlyDevelopers))) return false;

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
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.TargetBranch != null) hashCode = hashCode * 59 + this.TargetBranch.GetHashCode();
                if (this.MergeRequestIid != null) hashCode = hashCode * 59 + this.MergeRequestIid.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Search != null) hashCode = hashCode * 59 + this.Search.GetHashCode();
                if (this.SearchByNameList != null) hashCode = hashCode * 59 + this.SearchByNameList.GetHashCode();
                if (this.TargetProjectId != null) hashCode = hashCode * 59 + this.TargetProjectId.GetHashCode();
                hashCode = hashCode * 59 + this.View.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.OnlyDevelopers != null) hashCode = hashCode * 59 + this.OnlyDevelopers.GetHashCode();
                return hashCode;
            }
        }
    }
}
