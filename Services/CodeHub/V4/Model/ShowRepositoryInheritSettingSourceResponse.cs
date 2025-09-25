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
    /// Response Object
    /// </summary>
    public class ShowRepositoryInheritSettingSourceResponse : SdkResponse
    {
        /// <summary>
        /// **参数解释：** 设置源类型。 **取值范围：** - project，项目。 - group，代码组。 - repository，仓库。
        /// </summary>
        /// <value>**参数解释：** 设置源类型。 **取值范围：** - project，项目。 - group，代码组。 - repository，仓库。</value>
        [JsonConverter(typeof(EnumClassConverter<SourceTypeEnum>))]
        public class SourceTypeEnum
        {
            /// <summary>
            /// Enum PROJECT for value: project
            /// </summary>
            public static readonly SourceTypeEnum PROJECT = new SourceTypeEnum("project");

            /// <summary>
            /// Enum GROUP for value: group
            /// </summary>
            public static readonly SourceTypeEnum GROUP = new SourceTypeEnum("group");

            /// <summary>
            /// Enum REPOSITORY for value: repository
            /// </summary>
            public static readonly SourceTypeEnum REPOSITORY = new SourceTypeEnum("repository");

            private static readonly Dictionary<string, SourceTypeEnum> StaticFields =
            new Dictionary<string, SourceTypeEnum>()
            {
                { "project", PROJECT },
                { "group", GROUP },
                { "repository", REPOSITORY },
            };

            private string _value;

            public SourceTypeEnum()
            {

            }

            public SourceTypeEnum(string value)
            {
                _value = value;
            }

            public static SourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SourceTypeEnum a, SourceTypeEnum b)
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

            public static bool operator !=(SourceTypeEnum a, SourceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 设置源类型。 **取值范围：** - project，项目。 - group，代码组。 - repository，仓库。
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public SourceTypeEnum SourceType { get; set; }
        /// <summary>
        /// **参数解释：** 设置源ID。 **取值范围：** 1-2147483647
        /// </summary>
        [JsonProperty("source_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        /// <summary>
        /// **参数解释：** 继承设置是否可修改。 **取值范围：** - true，可修改。 - false，不可修改。
        /// </summary>
        [JsonProperty("upward_inherit_editable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpwardInheritEditable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRepositoryInheritSettingSourceResponse {\n");
            sb.Append("  sourceType: ").Append(SourceType).Append("\n");
            sb.Append("  sourceId: ").Append(SourceId).Append("\n");
            sb.Append("  upwardInheritEditable: ").Append(UpwardInheritEditable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRepositoryInheritSettingSourceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRepositoryInheritSettingSourceResponse input)
        {
            if (input == null) return false;
            if (this.SourceType != input.SourceType) return false;
            if (this.SourceId != input.SourceId || (this.SourceId != null && !this.SourceId.Equals(input.SourceId))) return false;
            if (this.UpwardInheritEditable != input.UpwardInheritEditable || (this.UpwardInheritEditable != null && !this.UpwardInheritEditable.Equals(input.UpwardInheritEditable))) return false;

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
                hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.SourceId != null) hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.UpwardInheritEditable != null) hashCode = hashCode * 59 + this.UpwardInheritEditable.GetHashCode();
                return hashCode;
            }
        }
    }
}
