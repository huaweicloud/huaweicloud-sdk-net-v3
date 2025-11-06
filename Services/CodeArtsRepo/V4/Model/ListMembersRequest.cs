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
    /// Request Object
    /// </summary>
    public class ListMembersRequest 
    {
        /// <summary>
        /// **参数解释：** 权限点。 **约束限制：** - repository，仓库。 - code，代码。 - member，成员。 - branch，分支。 - tag，Tag。 - mr，MR。 - label，标签。
        /// </summary>
        /// <value>**参数解释：** 权限点。 **约束限制：** - repository，仓库。 - code，代码。 - member，成员。 - branch，分支。 - tag，Tag。 - mr，MR。 - label，标签。</value>
        [JsonConverter(typeof(EnumClassConverter<PermissionEnum>))]
        public class PermissionEnum
        {
            /// <summary>
            /// Enum REPOSITORY for value: repository
            /// </summary>
            public static readonly PermissionEnum REPOSITORY = new PermissionEnum("repository");

            /// <summary>
            /// Enum CODE for value: code
            /// </summary>
            public static readonly PermissionEnum CODE = new PermissionEnum("code");

            /// <summary>
            /// Enum MEMBER for value: member
            /// </summary>
            public static readonly PermissionEnum MEMBER = new PermissionEnum("member");

            /// <summary>
            /// Enum BRANCH for value: branch
            /// </summary>
            public static readonly PermissionEnum BRANCH = new PermissionEnum("branch");

            /// <summary>
            /// Enum TAG for value: tag
            /// </summary>
            public static readonly PermissionEnum TAG = new PermissionEnum("tag");

            /// <summary>
            /// Enum MR for value: mr
            /// </summary>
            public static readonly PermissionEnum MR = new PermissionEnum("mr");

            /// <summary>
            /// Enum LABEL for value: label
            /// </summary>
            public static readonly PermissionEnum LABEL = new PermissionEnum("label");

            private static readonly Dictionary<string, PermissionEnum> StaticFields =
            new Dictionary<string, PermissionEnum>()
            {
                { "repository", REPOSITORY },
                { "code", CODE },
                { "member", MEMBER },
                { "branch", BRANCH },
                { "tag", TAG },
                { "mr", MR },
                { "label", LABEL },
            };

            private string _value;

            public PermissionEnum()
            {

            }

            public PermissionEnum(string value)
            {
                _value = value;
            }

            public static PermissionEnum FromValue(string value)
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

                if (this.Equals(obj as PermissionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PermissionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PermissionEnum a, PermissionEnum b)
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

            public static bool operator !=(PermissionEnum a, PermissionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 权限动作点, 不同权限点有不同的动作。 **约束限制：** - repository：create,fork,delete,setting - code：push,download - member：create,update,delete - branch：create,delete - tag：create,delete - mr：create,update,comment,review,approve,merge,close,reopen - label：create,delete,update
        /// </summary>
        /// <value>**参数解释：** 权限动作点, 不同权限点有不同的动作。 **约束限制：** - repository：create,fork,delete,setting - code：push,download - member：create,update,delete - branch：create,delete - tag：create,delete - mr：create,update,comment,review,approve,merge,close,reopen - label：create,delete,update</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum REPOSITORY_CREATE_FORK_DELETE_SETTING for value: repository：create,fork,delete,setting
            /// </summary>
            public static readonly ActionEnum REPOSITORY_CREATE_FORK_DELETE_SETTING = new ActionEnum("repository：create,fork,delete,setting");

            /// <summary>
            /// Enum CODE_PUSH_DOWNLOAD for value: code：push,download
            /// </summary>
            public static readonly ActionEnum CODE_PUSH_DOWNLOAD = new ActionEnum("code：push,download");

            /// <summary>
            /// Enum MEMBER_CREATE_UPDATE_DELETE for value: member：create,update,delete
            /// </summary>
            public static readonly ActionEnum MEMBER_CREATE_UPDATE_DELETE = new ActionEnum("member：create,update,delete");

            /// <summary>
            /// Enum BRANCH_CREATE_DELETE for value: branch：create,delete
            /// </summary>
            public static readonly ActionEnum BRANCH_CREATE_DELETE = new ActionEnum("branch：create,delete");

            /// <summary>
            /// Enum TAG_CREATE_DELETE for value: tag：create,delete
            /// </summary>
            public static readonly ActionEnum TAG_CREATE_DELETE = new ActionEnum("tag：create,delete");

            /// <summary>
            /// Enum MR_CREATE_UPDATE_COMMENT_REVIEW_APPROVE_MERGE_CLOSE_REOPEN for value: mr：create,update,comment,review,approve,merge,close,reopen
            /// </summary>
            public static readonly ActionEnum MR_CREATE_UPDATE_COMMENT_REVIEW_APPROVE_MERGE_CLOSE_REOPEN = new ActionEnum("mr：create,update,comment,review,approve,merge,close,reopen");

            /// <summary>
            /// Enum LABEL_CREATE_DELETE_UPDATE for value: label：create,delete,update
            /// </summary>
            public static readonly ActionEnum LABEL_CREATE_DELETE_UPDATE = new ActionEnum("label：create,delete,update");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "repository：create,fork,delete,setting", REPOSITORY_CREATE_FORK_DELETE_SETTING },
                { "code：push,download", CODE_PUSH_DOWNLOAD },
                { "member：create,update,delete", MEMBER_CREATE_UPDATE_DELETE },
                { "branch：create,delete", BRANCH_CREATE_DELETE },
                { "tag：create,delete", TAG_CREATE_DELETE },
                { "mr：create,update,comment,review,approve,merge,close,reopen", MR_CREATE_UPDATE_COMMENT_REVIEW_APPROVE_MERGE_CLOSE_REOPEN },
                { "label：create,delete,update", LABEL_CREATE_DELETE_UPDATE },
            };

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(string value)
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

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
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
        /// **参数解释：** 查询关键字，可模糊匹配用户名称、用户昵称、租户名称。
        /// </summary>
        [SDKProperty("search", IsQuery = true)]
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

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
        /// **参数解释：** 权限点。 **约束限制：** - repository，仓库。 - code，代码。 - member，成员。 - branch，分支。 - tag，Tag。 - mr，MR。 - label，标签。
        /// </summary>
        [SDKProperty("permission", IsQuery = true)]
        [JsonProperty("permission", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionEnum Permission { get; set; }
        /// <summary>
        /// **参数解释：** 权限动作点, 不同权限点有不同的动作。 **约束限制：** - repository：create,fork,delete,setting - code：push,download - member：create,update,delete - branch：create,delete - tag：create,delete - mr：create,update,comment,review,approve,merge,close,reopen - label：create,delete,update
        /// </summary>
        [SDKProperty("action", IsQuery = true)]
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMembersRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  search: ").Append(Search).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  permission: ").Append(Permission).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMembersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMembersRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.Search != input.Search || (this.Search != null && !this.Search.Equals(input.Search))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Permission != input.Permission) return false;
            if (this.Action != input.Action) return false;

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
                if (this.Search != null) hashCode = hashCode * 59 + this.Search.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                hashCode = hashCode * 59 + this.Permission.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                return hashCode;
            }
        }
    }
}
