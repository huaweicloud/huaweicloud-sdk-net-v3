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
    /// **参数解释：** 提交动作设置参数。
    /// </summary>
    public class ActionDto 
    {
        /// <summary>
        /// **参数解释：** 要执行的操作。 **取值范围：** - create，创建文件。 - create_dir，创建目录。 - update，更新。 - move，移动。 - delete，删除。 - chmod，更改权限。
        /// </summary>
        /// <value>**参数解释：** 要执行的操作。 **取值范围：** - create，创建文件。 - create_dir，创建目录。 - update，更新。 - move，移动。 - delete，删除。 - chmod，更改权限。</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum CREATE for value: create
            /// </summary>
            public static readonly ActionEnum CREATE = new ActionEnum("create");

            /// <summary>
            /// Enum CREATE_DIR for value: create_dir
            /// </summary>
            public static readonly ActionEnum CREATE_DIR = new ActionEnum("create_dir");

            /// <summary>
            /// Enum UPDATE for value: update
            /// </summary>
            public static readonly ActionEnum UPDATE = new ActionEnum("update");

            /// <summary>
            /// Enum MOVE for value: move
            /// </summary>
            public static readonly ActionEnum MOVE = new ActionEnum("move");

            /// <summary>
            /// Enum DELETE for value: delete
            /// </summary>
            public static readonly ActionEnum DELETE = new ActionEnum("delete");

            /// <summary>
            /// Enum CHMOD for value: chmod
            /// </summary>
            public static readonly ActionEnum CHMOD = new ActionEnum("chmod");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "create", CREATE },
                { "create_dir", CREATE_DIR },
                { "update", UPDATE },
                { "move", MOVE },
                { "delete", DELETE },
                { "chmod", CHMOD },
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
        /// **参数解释：** 要执行的操作。 **取值范围：** - create，创建文件。 - create_dir，创建目录。 - update，更新。 - move，移动。 - delete，删除。 - chmod，更改权限。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// **参数解释：** 文件路径。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// **参数解释：** 上一个路径。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("previous_path", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousPath { get; set; }

        /// <summary>
        /// **参数解释：** 文件内容。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// **参数解释：** 编码方式。 **取值范围：** - text。 - base64.
        /// </summary>
        [JsonProperty("encoding", NullValueHandling = NullValueHandling.Ignore)]
        public string Encoding { get; set; }

        /// <summary>
        /// **参数解释：** 上次已知的文件提交ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("last_commit_id", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LastCommitId { get; set; }

        /// <summary>
        /// **参数解释：** 执行文件模式。 **取值范围：** - true，启用文件上的执行标志。 - false，禁用文件上的执行标志
        /// </summary>
        [JsonProperty("execute_filemode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExecuteFilemode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionDto {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  previousPath: ").Append(PreviousPath).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  encoding: ").Append(Encoding).Append("\n");
            sb.Append("  lastCommitId: ").Append(LastCommitId).Append("\n");
            sb.Append("  executeFilemode: ").Append(ExecuteFilemode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ActionDto input)
        {
            if (input == null) return false;
            if (this.Action != input.Action) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.PreviousPath != input.PreviousPath || (this.PreviousPath != null && !this.PreviousPath.Equals(input.PreviousPath))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.Encoding != input.Encoding || (this.Encoding != null && !this.Encoding.Equals(input.Encoding))) return false;
            if (this.LastCommitId != input.LastCommitId || (this.LastCommitId != null && !this.LastCommitId.Equals(input.LastCommitId))) return false;
            if (this.ExecuteFilemode != input.ExecuteFilemode || (this.ExecuteFilemode != null && !this.ExecuteFilemode.Equals(input.ExecuteFilemode))) return false;

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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.PreviousPath != null) hashCode = hashCode * 59 + this.PreviousPath.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Encoding != null) hashCode = hashCode * 59 + this.Encoding.GetHashCode();
                if (this.LastCommitId != null) hashCode = hashCode * 59 + this.LastCommitId.GetHashCode();
                if (this.ExecuteFilemode != null) hashCode = hashCode * 59 + this.ExecuteFilemode.GetHashCode();
                return hashCode;
            }
        }
    }
}
