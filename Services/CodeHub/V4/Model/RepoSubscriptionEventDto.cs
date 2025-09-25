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
    /// 
    /// </summary>
    public class RepoSubscriptionEventDto 
    {
        /// <summary>
        /// **参数解释：** 资源类型。 - repo，仓库。 - mr，合并请求。  - member，成员。 - note，检视意见。
        /// </summary>
        /// <value>**参数解释：** 资源类型。 - repo，仓库。 - mr，合并请求。  - member，成员。 - note，检视意见。</value>
        [JsonConverter(typeof(EnumClassConverter<ResourceTypeEnum>))]
        public class ResourceTypeEnum
        {
            /// <summary>
            /// Enum REPO for value: repo
            /// </summary>
            public static readonly ResourceTypeEnum REPO = new ResourceTypeEnum("repo");

            /// <summary>
            /// Enum MR for value: mr
            /// </summary>
            public static readonly ResourceTypeEnum MR = new ResourceTypeEnum("mr");

            /// <summary>
            /// Enum MEMBER for value: member
            /// </summary>
            public static readonly ResourceTypeEnum MEMBER = new ResourceTypeEnum("member");

            /// <summary>
            /// Enum NOTE for value: note
            /// </summary>
            public static readonly ResourceTypeEnum NOTE = new ResourceTypeEnum("note");

            private static readonly Dictionary<string, ResourceTypeEnum> StaticFields =
            new Dictionary<string, ResourceTypeEnum>()
            {
                { "repo", REPO },
                { "mr", MR },
                { "member", MEMBER },
                { "note", NOTE },
            };

            private string _value;

            public ResourceTypeEnum()
            {

            }

            public ResourceTypeEnum(string value)
            {
                _value = value;
            }

            public static ResourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ResourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResourceTypeEnum a, ResourceTypeEnum b)
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

            public static bool operator !=(ResourceTypeEnum a, ResourceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 事件名。 - create，创建。 - open，开启。 - update，更新。  - delete，删除。 - merge，合并。 - review，检视。  - approve，审核。 - create_note，新建评审意见。 - resolve_note，解决评审意见。 - mention，被提及。
        /// </summary>
        /// <value>**参数解释：** 事件名。 - create，创建。 - open，开启。 - update，更新。  - delete，删除。 - merge，合并。 - review，检视。  - approve，审核。 - create_note，新建评审意见。 - resolve_note，解决评审意见。 - mention，被提及。</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum CREATE for value: create
            /// </summary>
            public static readonly ActionEnum CREATE = new ActionEnum("create");

            /// <summary>
            /// Enum OPEN for value: open
            /// </summary>
            public static readonly ActionEnum OPEN = new ActionEnum("open");

            /// <summary>
            /// Enum UPDATE for value: update
            /// </summary>
            public static readonly ActionEnum UPDATE = new ActionEnum("update");

            /// <summary>
            /// Enum DELETE for value: delete
            /// </summary>
            public static readonly ActionEnum DELETE = new ActionEnum("delete");

            /// <summary>
            /// Enum MERGE for value: merge
            /// </summary>
            public static readonly ActionEnum MERGE = new ActionEnum("merge");

            /// <summary>
            /// Enum REVIEW for value: review
            /// </summary>
            public static readonly ActionEnum REVIEW = new ActionEnum("review");

            /// <summary>
            /// Enum APPROVE for value: approve
            /// </summary>
            public static readonly ActionEnum APPROVE = new ActionEnum("approve");

            /// <summary>
            /// Enum CREATE_NOTE for value: create_note
            /// </summary>
            public static readonly ActionEnum CREATE_NOTE = new ActionEnum("create_note");

            /// <summary>
            /// Enum RESOLVE_NOTE for value: resolve_note
            /// </summary>
            public static readonly ActionEnum RESOLVE_NOTE = new ActionEnum("resolve_note");

            /// <summary>
            /// Enum CAPACITY_WARNING for value: capacity_warning
            /// </summary>
            public static readonly ActionEnum CAPACITY_WARNING = new ActionEnum("capacity_warning");

            /// <summary>
            /// Enum MENTION for value: mention
            /// </summary>
            public static readonly ActionEnum MENTION = new ActionEnum("mention");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "create", CREATE },
                { "open", OPEN },
                { "update", UPDATE },
                { "delete", DELETE },
                { "merge", MERGE },
                { "review", REVIEW },
                { "approve", APPROVE },
                { "create_note", CREATE_NOTE },
                { "resolve_note", RESOLVE_NOTE },
                { "capacity_warning", CAPACITY_WARNING },
                { "mention", MENTION },
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
        /// Defines roleNames
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<RoleNamesEnum>))]
        public class RoleNamesEnum
        {
            /// <summary>
            /// Enum CREATOR for value: creator
            /// </summary>
            public static readonly RoleNamesEnum CREATOR = new RoleNamesEnum("creator");

            /// <summary>
            /// Enum ASSIGNEE for value: assignee
            /// </summary>
            public static readonly RoleNamesEnum ASSIGNEE = new RoleNamesEnum("assignee");

            /// <summary>
            /// Enum REVIEWER for value: reviewer
            /// </summary>
            public static readonly RoleNamesEnum REVIEWER = new RoleNamesEnum("reviewer");

            /// <summary>
            /// Enum SCORER for value: scorer
            /// </summary>
            public static readonly RoleNamesEnum SCORER = new RoleNamesEnum("scorer");

            /// <summary>
            /// Enum APPROVER for value: approver
            /// </summary>
            public static readonly RoleNamesEnum APPROVER = new RoleNamesEnum("approver");

            private static readonly Dictionary<string, RoleNamesEnum> StaticFields =
            new Dictionary<string, RoleNamesEnum>()
            {
                { "creator", CREATOR },
                { "assignee", ASSIGNEE },
                { "reviewer", REVIEWER },
                { "scorer", SCORER },
                { "approver", APPROVER },
            };

            private string _value;

            public RoleNamesEnum()
            {

            }

            public RoleNamesEnum(string value)
            {
                _value = value;
            }

            public static RoleNamesEnum FromValue(string value)
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

                if (this.Equals(obj as RoleNamesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RoleNamesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RoleNamesEnum a, RoleNamesEnum b)
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

            public static bool operator !=(RoleNamesEnum a, RoleNamesEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// **参数解释：** 资源类型。 - repo，仓库。 - mr，合并请求。  - member，成员。 - note，检视意见。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceTypeEnum ResourceType { get; set; }
        /// <summary>
        /// **参数解释：** 事件名。 - create，创建。 - open，开启。 - update，更新。  - delete，删除。 - merge，合并。 - review，检视。  - approve，审核。 - create_note，新建评审意见。 - resolve_note，解决评审意见。 - mention，被提及。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// **参数解释：** 启用事件通知
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// **参数解释：** 通知的角色ID列表
        /// </summary>
        [JsonProperty("role_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RoleIds { get; set; }

        /// <summary>
        /// **参数解释：** 通知的角色名称列表。 - creator，创建者。 - assignee，合并人。 - reviewer，评审人。 - scorer，审核人。 - approver，检视人。
        /// </summary>
        [JsonProperty("role_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<RoleNamesEnum> RoleNames { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepoSubscriptionEventDto {\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  roleIds: ").Append(RoleIds).Append("\n");
            sb.Append("  roleNames: ").Append(RoleNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepoSubscriptionEventDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepoSubscriptionEventDto input)
        {
            if (input == null) return false;
            if (this.ResourceType != input.ResourceType) return false;
            if (this.Action != input.Action) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.RoleIds != input.RoleIds || (this.RoleIds != null && input.RoleIds != null && !this.RoleIds.SequenceEqual(input.RoleIds))) return false;
            if (this.RoleNames != input.RoleNames || (this.RoleNames != null && input.RoleNames != null && !this.RoleNames.SequenceEqual(input.RoleNames))) return false;

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
                hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.RoleIds != null) hashCode = hashCode * 59 + this.RoleIds.GetHashCode();
                hashCode = hashCode * 59 + this.RoleNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
