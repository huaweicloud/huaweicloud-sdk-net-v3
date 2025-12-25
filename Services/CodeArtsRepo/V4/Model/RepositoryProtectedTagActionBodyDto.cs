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
    /// 
    /// </summary>
    public class RepositoryProtectedTagActionBodyDto 
    {
        /// <summary>
        /// **参数解释：** 事件名称。 **约束限制：** 不涉及 **取值范围：** - create，创建。 **默认取值：** 不涉及。
        /// </summary>
        /// <value>**参数解释：** 事件名称。 **约束限制：** 不涉及 **取值范围：** - create，创建。 **默认取值：** 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum CREATE for value: create
            /// </summary>
            public static readonly ActionEnum CREATE = new ActionEnum("create");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "create", CREATE },
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
        /// **参数解释：** 是否启用。 **约束限制：** 不涉及。 **取值范围：** - true，开启规则限制 - false，关闭规则限制 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// **参数解释：** 用户ID列表。 **约束限制：** 不涉及。 **取值范围：** Integer **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("user_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> UserIds { get; set; }

        /// <summary>
        /// **参数解释：** 成员组ID列表。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("user_team_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> UserTeamIds { get; set; }

        /// <summary>
        /// **参数解释：** 关联角色ID列表。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("related_role_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RelatedRoleIds { get; set; }

        /// <summary>
        /// **参数解释：** 事件名称。 **约束限制：** 不涉及 **取值范围：** - create，创建。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryProtectedTagActionBodyDto {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  userIds: ").Append(UserIds).Append("\n");
            sb.Append("  userTeamIds: ").Append(UserTeamIds).Append("\n");
            sb.Append("  relatedRoleIds: ").Append(RelatedRoleIds).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryProtectedTagActionBodyDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoryProtectedTagActionBodyDto input)
        {
            if (input == null) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.UserIds != input.UserIds || (this.UserIds != null && input.UserIds != null && !this.UserIds.SequenceEqual(input.UserIds))) return false;
            if (this.UserTeamIds != input.UserTeamIds || (this.UserTeamIds != null && input.UserTeamIds != null && !this.UserTeamIds.SequenceEqual(input.UserTeamIds))) return false;
            if (this.RelatedRoleIds != input.RelatedRoleIds || (this.RelatedRoleIds != null && input.RelatedRoleIds != null && !this.RelatedRoleIds.SequenceEqual(input.RelatedRoleIds))) return false;
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
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.UserIds != null) hashCode = hashCode * 59 + this.UserIds.GetHashCode();
                if (this.UserTeamIds != null) hashCode = hashCode * 59 + this.UserTeamIds.GetHashCode();
                if (this.RelatedRoleIds != null) hashCode = hashCode * 59 + this.RelatedRoleIds.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                return hashCode;
            }
        }
    }
}
