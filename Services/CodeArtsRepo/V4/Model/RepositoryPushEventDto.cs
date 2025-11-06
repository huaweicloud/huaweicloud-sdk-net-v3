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
    /// **参数解释：** 推送动态。
    /// </summary>
    public class RepositoryPushEventDto 
    {
        /// <summary>
        /// **参数解释：** 操作名称。 - pushed to，表示推送。 - pushed new，表示推送并新建。 - deleted，表示删除。
        /// </summary>
        /// <value>**参数解释：** 操作名称。 - pushed to，表示推送。 - pushed new，表示推送并新建。 - deleted，表示删除。</value>
        [JsonConverter(typeof(EnumClassConverter<ActionNameEnum>))]
        public class ActionNameEnum
        {
            /// <summary>
            /// Enum PUSHED_TO for value: pushed to
            /// </summary>
            public static readonly ActionNameEnum PUSHED_TO = new ActionNameEnum("pushed to");

            /// <summary>
            /// Enum PUSHED_NEW for value: pushed new
            /// </summary>
            public static readonly ActionNameEnum PUSHED_NEW = new ActionNameEnum("pushed new");

            /// <summary>
            /// Enum DELETED for value: deleted
            /// </summary>
            public static readonly ActionNameEnum DELETED = new ActionNameEnum("deleted");

            private static readonly Dictionary<string, ActionNameEnum> StaticFields =
            new Dictionary<string, ActionNameEnum>()
            {
                { "pushed to", PUSHED_TO },
                { "pushed new", PUSHED_NEW },
                { "deleted", DELETED },
            };

            private string _value;

            public ActionNameEnum()
            {

            }

            public ActionNameEnum(string value)
            {
                _value = value;
            }

            public static ActionNameEnum FromValue(string value)
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

                if (this.Equals(obj as ActionNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionNameEnum a, ActionNameEnum b)
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

            public static bool operator !=(ActionNameEnum a, ActionNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 操作名称。 - pushed to，表示推送。 - pushed new，表示推送并新建。 - deleted，表示删除。
        /// </summary>
        [JsonProperty("action_name", NullValueHandling = NullValueHandling.Ignore)]
        public ActionNameEnum ActionName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public RepositoryEventAuthorDto Author { get; set; }

        /// <summary>
        /// **参数解释：** 触发者ID。
        /// </summary>
        [JsonProperty("author_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? AuthorId { get; set; }

        /// <summary>
        /// **参数解释：** 触发者名称。
        /// </summary>
        [JsonProperty("author_username", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorUsername { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 仓库ID。
        /// </summary>
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// **参数解释：** 仓库名。
        /// </summary>
        [JsonProperty("repository_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("push_data", NullValueHandling = NullValueHandling.Ignore)]
        public PushEventPayloadDto PushData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryPushEventDto {\n");
            sb.Append("  actionName: ").Append(ActionName).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  authorId: ").Append(AuthorId).Append("\n");
            sb.Append("  authorUsername: ").Append(AuthorUsername).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  repositoryName: ").Append(RepositoryName).Append("\n");
            sb.Append("  pushData: ").Append(PushData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryPushEventDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoryPushEventDto input)
        {
            if (input == null) return false;
            if (this.ActionName != input.ActionName) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.AuthorId != input.AuthorId || (this.AuthorId != null && !this.AuthorId.Equals(input.AuthorId))) return false;
            if (this.AuthorUsername != input.AuthorUsername || (this.AuthorUsername != null && !this.AuthorUsername.Equals(input.AuthorUsername))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.RepositoryName != input.RepositoryName || (this.RepositoryName != null && !this.RepositoryName.Equals(input.RepositoryName))) return false;
            if (this.PushData != input.PushData || (this.PushData != null && !this.PushData.Equals(input.PushData))) return false;

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
                hashCode = hashCode * 59 + this.ActionName.GetHashCode();
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.AuthorId != null) hashCode = hashCode * 59 + this.AuthorId.GetHashCode();
                if (this.AuthorUsername != null) hashCode = hashCode * 59 + this.AuthorUsername.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.RepositoryName != null) hashCode = hashCode * 59 + this.RepositoryName.GetHashCode();
                if (this.PushData != null) hashCode = hashCode * 59 + this.PushData.GetHashCode();
                return hashCode;
            }
        }
    }
}
