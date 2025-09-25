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
    /// 更新合并请求检视意见请求体
    /// </summary>
    public class UpdateMergeRequestNoteDto 
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
        /// **参数解释：** 检视意见检视人id。
        /// </summary>
        [JsonProperty("proposer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProposerId { get; set; }

        /// <summary>
        /// **参数解释：** 解决或取消解决检视意见(使用时需仅传此参数)。
        /// </summary>
        [JsonProperty("resolved", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Resolved { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMergeRequestNoteDto {\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("  severity: ").Append(Severity).Append("\n");
            sb.Append("  assigneeId: ").Append(AssigneeId).Append("\n");
            sb.Append("  reviewCategories: ").Append(ReviewCategories).Append("\n");
            sb.Append("  reviewModules: ").Append(ReviewModules).Append("\n");
            sb.Append("  proposerId: ").Append(ProposerId).Append("\n");
            sb.Append("  resolved: ").Append(Resolved).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateMergeRequestNoteDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateMergeRequestNoteDto input)
        {
            if (input == null) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;
            if (this.Severity != input.Severity) return false;
            if (this.AssigneeId != input.AssigneeId || (this.AssigneeId != null && !this.AssigneeId.Equals(input.AssigneeId))) return false;
            if (this.ReviewCategories != input.ReviewCategories || (this.ReviewCategories != null && !this.ReviewCategories.Equals(input.ReviewCategories))) return false;
            if (this.ReviewModules != input.ReviewModules || (this.ReviewModules != null && !this.ReviewModules.Equals(input.ReviewModules))) return false;
            if (this.ProposerId != input.ProposerId || (this.ProposerId != null && !this.ProposerId.Equals(input.ProposerId))) return false;
            if (this.Resolved != input.Resolved || (this.Resolved != null && !this.Resolved.Equals(input.Resolved))) return false;

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
                if (this.Resolved != null) hashCode = hashCode * 59 + this.Resolved.GetHashCode();
                return hashCode;
            }
        }
    }
}
