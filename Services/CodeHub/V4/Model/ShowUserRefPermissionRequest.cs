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
    public class ShowUserRefPermissionRequest 
    {
        /// <summary>
        /// **参数解释：** 动作类型，可用于查询指定动作的权限 - read，查看 - review，检视 - approval, 审核 - create-change，创建变更请求 - merge，合并变更请求 - create-delete，创建/删除分支 - push, 推送
        /// </summary>
        /// <value>**参数解释：** 动作类型，可用于查询指定动作的权限 - read，查看 - review，检视 - approval, 审核 - create-change，创建变更请求 - merge，合并变更请求 - create-delete，创建/删除分支 - push, 推送</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum READ for value: read
            /// </summary>
            public static readonly ActionEnum READ = new ActionEnum("read");

            /// <summary>
            /// Enum REVIEW for value: review
            /// </summary>
            public static readonly ActionEnum REVIEW = new ActionEnum("review");

            /// <summary>
            /// Enum APPROVAL for value: approval
            /// </summary>
            public static readonly ActionEnum APPROVAL = new ActionEnum("approval");

            /// <summary>
            /// Enum CREATE_CHANGE for value: create-change
            /// </summary>
            public static readonly ActionEnum CREATE_CHANGE = new ActionEnum("create-change");

            /// <summary>
            /// Enum MERGE for value: merge
            /// </summary>
            public static readonly ActionEnum MERGE = new ActionEnum("merge");

            /// <summary>
            /// Enum CREATE_DELETE for value: create-delete
            /// </summary>
            public static readonly ActionEnum CREATE_DELETE = new ActionEnum("create-delete");

            /// <summary>
            /// Enum PUSH for value: push
            /// </summary>
            public static readonly ActionEnum PUSH = new ActionEnum("push");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "read", READ },
                { "review", REVIEW },
                { "approval", APPROVAL },
                { "create-change", CREATE_CHANGE },
                { "merge", MERGE },
                { "create-delete", CREATE_DELETE },
                { "push", PUSH },
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
        /// **参数解释：** 分支或者标签名称。  **约束限制：** 不支持空格 [ \\ &lt; ~ ^ : ? * ! ( ) &#39; \&quot; | 等特殊字符，不支持以. / .lock结尾，分支以refs/head/开头，标签以refs/tag/开头  **取值范围：** 字符串长度不少于1，不超过210。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("target_ref", IsQuery = true)]
        [JsonProperty("target_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetRef { get; set; }

        /// <summary>
        /// **参数解释：** 动作类型，可用于查询指定动作的权限 - read，查看 - review，检视 - approval, 审核 - create-change，创建变更请求 - merge，合并变更请求 - create-delete，创建/删除分支 - push, 推送
        /// </summary>
        [SDKProperty("action", IsQuery = true)]
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// **参数解释：** 变更请求在仓库内部的ID。
        /// </summary>
        [SDKProperty("change_request_iid", IsQuery = true)]
        [JsonProperty("change_request_iid", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChangeRequestIid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUserRefPermissionRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  targetRef: ").Append(TargetRef).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  changeRequestIid: ").Append(ChangeRequestIid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUserRefPermissionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUserRefPermissionRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.TargetRef != input.TargetRef || (this.TargetRef != null && !this.TargetRef.Equals(input.TargetRef))) return false;
            if (this.Action != input.Action) return false;
            if (this.ChangeRequestIid != input.ChangeRequestIid || (this.ChangeRequestIid != null && !this.ChangeRequestIid.Equals(input.ChangeRequestIid))) return false;

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
                if (this.TargetRef != null) hashCode = hashCode * 59 + this.TargetRef.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.ChangeRequestIid != null) hashCode = hashCode * 59 + this.ChangeRequestIid.GetHashCode();
                return hashCode;
            }
        }
    }
}
