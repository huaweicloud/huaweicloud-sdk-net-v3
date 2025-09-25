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
    /// 创建合并请求检视意见请求体
    /// </summary>
    public class CreateMergeRequestNoteDto 
    {
        /// <summary>
        /// **参数解释：** 检视意见严重程度。
        /// </summary>
        /// <value>**参数解释：** 检视意见严重程度。</value>
        [JsonConverter(typeof(EnumClassConverter<SeverityEnum>))]
        public class SeverityEnum
        {
            /// <summary>
            /// Enum SUGGESTION for value: suggestion
            /// </summary>
            public static readonly SeverityEnum SUGGESTION = new SeverityEnum("suggestion");

            /// <summary>
            /// Enum MINOR for value: minor
            /// </summary>
            public static readonly SeverityEnum MINOR = new SeverityEnum("minor");

            /// <summary>
            /// Enum MAJOR for value: major
            /// </summary>
            public static readonly SeverityEnum MAJOR = new SeverityEnum("major");

            /// <summary>
            /// Enum FATAL for value: fatal
            /// </summary>
            public static readonly SeverityEnum FATAL = new SeverityEnum("fatal");

            private static readonly Dictionary<string, SeverityEnum> StaticFields =
            new Dictionary<string, SeverityEnum>()
            {
                { "suggestion", SUGGESTION },
                { "minor", MINOR },
                { "major", MAJOR },
                { "fatal", FATAL },
            };

            private string _value;

            public SeverityEnum()
            {

            }

            public SeverityEnum(string value)
            {
                _value = value;
            }

            public static SeverityEnum FromValue(string value)
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

                if (this.Equals(obj as SeverityEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SeverityEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SeverityEnum a, SeverityEnum b)
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

            public static bool operator !=(SeverityEnum a, SeverityEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 检视意见所在行类型(代码行评论需要)。
        /// </summary>
        /// <value>**参数解释：** 检视意见所在行类型(代码行评论需要)。</value>
        [JsonConverter(typeof(EnumClassConverter<LineTypesEnum>))]
        public class LineTypesEnum
        {
            /// <summary>
            /// Enum NEW for value: new
            /// </summary>
            public static readonly LineTypesEnum NEW = new LineTypesEnum("new");

            /// <summary>
            /// Enum OLD for value: old
            /// </summary>
            public static readonly LineTypesEnum OLD = new LineTypesEnum("old");

            private static readonly Dictionary<string, LineTypesEnum> StaticFields =
            new Dictionary<string, LineTypesEnum>()
            {
                { "new", NEW },
                { "old", OLD },
            };

            private string _value;

            public LineTypesEnum()
            {

            }

            public LineTypesEnum(string value)
            {
                _value = value;
            }

            public static LineTypesEnum FromValue(string value)
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

                if (this.Equals(obj as LineTypesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LineTypesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LineTypesEnum a, LineTypesEnum b)
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

            public static bool operator !=(LineTypesEnum a, LineTypesEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 评论内容。  
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        /// <summary>
        /// **参数解释：** 检视意见严重程度。
        /// </summary>
        [JsonProperty("severity", NullValueHandling = NullValueHandling.Ignore)]
        public SeverityEnum Severity { get; set; }
        /// <summary>
        /// **参数解释：** 检视意见指派人id。
        /// </summary>
        [JsonProperty("assignee_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssigneeId { get; set; }

        /// <summary>
        /// **参数解释：** 检视意见分类。
        /// </summary>
        [JsonProperty("review_categories", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewCategories { get; set; }

        /// <summary>
        /// **参数解释：** 检视意见模块。
        /// </summary>
        [JsonProperty("review_modules", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewModules { get; set; }

        /// <summary>
        /// **参数解释：** 检视人。
        /// </summary>
        [JsonProperty("proposer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProposerId { get; set; }

        /// <summary>
        /// **参数解释：** 检视意见所在行类型(代码行评论需要)。
        /// </summary>
        [JsonProperty("line_types", NullValueHandling = NullValueHandling.Ignore)]
        public LineTypesEnum LineTypes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public PositionDto Position { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateMergeRequestNoteDto {\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  assigneeId: ").Append(AssigneeId).Append("\n");
            sb.Append("  reviewCategories: ").Append(ReviewCategories).Append("\n");
            sb.Append("  reviewModules: ").Append(ReviewModules).Append("\n");
            sb.Append("  proposerId: ").Append(ProposerId).Append("\n");
            sb.Append("  lineTypes: ").Append(LineTypes).Append("\n");
            sb.Append("  position: ").Append(Position).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateMergeRequestNoteDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateMergeRequestNoteDto input)
        {
            if (input == null) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;
            if (this.Severity != input.Severity) return false;
            if (this.AssigneeId != input.AssigneeId || (this.AssigneeId != null && !this.AssigneeId.Equals(input.AssigneeId))) return false;
            if (this.ReviewCategories != input.ReviewCategories || (this.ReviewCategories != null && !this.ReviewCategories.Equals(input.ReviewCategories))) return false;
            if (this.ReviewModules != input.ReviewModules || (this.ReviewModules != null && !this.ReviewModules.Equals(input.ReviewModules))) return false;
            if (this.ProposerId != input.ProposerId || (this.ProposerId != null && !this.ProposerId.Equals(input.ProposerId))) return false;
            if (this.LineTypes != input.LineTypes) return false;
            if (this.Position != input.Position || (this.Position != null && !this.Position.Equals(input.Position))) return false;

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
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.AssigneeId != null) hashCode = hashCode * 59 + this.AssigneeId.GetHashCode();
                if (this.ReviewCategories != null) hashCode = hashCode * 59 + this.ReviewCategories.GetHashCode();
                if (this.ReviewModules != null) hashCode = hashCode * 59 + this.ReviewModules.GetHashCode();
                if (this.ProposerId != null) hashCode = hashCode * 59 + this.ProposerId.GetHashCode();
                hashCode = hashCode * 59 + this.LineTypes.GetHashCode();
                if (this.Position != null) hashCode = hashCode * 59 + this.Position.GetHashCode();
                return hashCode;
            }
        }
    }
}
