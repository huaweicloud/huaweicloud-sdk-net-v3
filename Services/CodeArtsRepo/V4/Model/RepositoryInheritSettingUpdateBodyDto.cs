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
    public class RepositoryInheritSettingUpdateBodyDto 
    {
        /// <summary>
        /// **参数解释：** 设置源类型。 **约束限制：** 不涉及。 **取值范围：** - protected_branches，保护分支设置。 - protected_tags，保护Tag设置。 - repository_settings，仓库设置。 - push_rules，提交规则设置。 - merge_requests，合并请求设置。 - e2e_settings，E2E设置。 - watermark，水印设置。 **默认取值：** 不涉及。
        /// </summary>
        /// <value>**参数解释：** 设置源类型。 **约束限制：** 不涉及。 **取值范围：** - protected_branches，保护分支设置。 - protected_tags，保护Tag设置。 - repository_settings，仓库设置。 - push_rules，提交规则设置。 - merge_requests，合并请求设置。 - e2e_settings，E2E设置。 - watermark，水印设置。 **默认取值：** 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<NameEnum>))]
        public class NameEnum
        {
            /// <summary>
            /// Enum PROTECTED_BRANCHES for value: protected_branches
            /// </summary>
            public static readonly NameEnum PROTECTED_BRANCHES = new NameEnum("protected_branches");

            /// <summary>
            /// Enum PROTECTED_TAGS for value: protected_tags
            /// </summary>
            public static readonly NameEnum PROTECTED_TAGS = new NameEnum("protected_tags");

            /// <summary>
            /// Enum REPOSITORY_SETTINGS for value: repository_settings
            /// </summary>
            public static readonly NameEnum REPOSITORY_SETTINGS = new NameEnum("repository_settings");

            /// <summary>
            /// Enum PUSH_RULES for value: push_rules
            /// </summary>
            public static readonly NameEnum PUSH_RULES = new NameEnum("push_rules");

            /// <summary>
            /// Enum MERGE_REQUESTS for value: merge_requests
            /// </summary>
            public static readonly NameEnum MERGE_REQUESTS = new NameEnum("merge_requests");

            /// <summary>
            /// Enum E2E_SETTINGS for value: e2e_settings
            /// </summary>
            public static readonly NameEnum E2E_SETTINGS = new NameEnum("e2e_settings");

            /// <summary>
            /// Enum WATERMARK for value: watermark
            /// </summary>
            public static readonly NameEnum WATERMARK = new NameEnum("watermark");

            private static readonly Dictionary<string, NameEnum> StaticFields =
            new Dictionary<string, NameEnum>()
            {
                { "protected_branches", PROTECTED_BRANCHES },
                { "protected_tags", PROTECTED_TAGS },
                { "repository_settings", REPOSITORY_SETTINGS },
                { "push_rules", PUSH_RULES },
                { "merge_requests", MERGE_REQUESTS },
                { "e2e_settings", E2E_SETTINGS },
                { "watermark", WATERMARK },
            };

            private string _value;

            public NameEnum()
            {

            }

            public NameEnum(string value)
            {
                _value = value;
            }

            public static NameEnum FromValue(string value)
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

                if (this.Equals(obj as NameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NameEnum a, NameEnum b)
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

            public static bool operator !=(NameEnum a, NameEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 继承设置。 **约束限制：** 不涉及。 **取值范围：** - inherit，继承上级配置。 - custom，使用当前仓库配置。 **默认取值：** 不涉及。
        /// </summary>
        /// <value>**参数解释：** 继承设置。 **约束限制：** 不涉及。 **取值范围：** - inherit，继承上级配置。 - custom，使用当前仓库配置。 **默认取值：** 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<InheritModEnum>))]
        public class InheritModEnum
        {
            /// <summary>
            /// Enum INHERIT for value: inherit
            /// </summary>
            public static readonly InheritModEnum INHERIT = new InheritModEnum("inherit");

            /// <summary>
            /// Enum CUSTOM for value: custom
            /// </summary>
            public static readonly InheritModEnum CUSTOM = new InheritModEnum("custom");

            private static readonly Dictionary<string, InheritModEnum> StaticFields =
            new Dictionary<string, InheritModEnum>()
            {
                { "inherit", INHERIT },
                { "custom", CUSTOM },
            };

            private string _value;

            public InheritModEnum()
            {

            }

            public InheritModEnum(string value)
            {
                _value = value;
            }

            public static InheritModEnum FromValue(string value)
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

                if (this.Equals(obj as InheritModEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InheritModEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InheritModEnum a, InheritModEnum b)
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

            public static bool operator !=(InheritModEnum a, InheritModEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 设置源类型。 **约束限制：** 不涉及。 **取值范围：** - protected_branches，保护分支设置。 - protected_tags，保护Tag设置。 - repository_settings，仓库设置。 - push_rules，提交规则设置。 - merge_requests，合并请求设置。 - e2e_settings，E2E设置。 - watermark，水印设置。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public NameEnum Name { get; set; }
        /// <summary>
        /// **参数解释：** 继承设置。 **约束限制：** 不涉及。 **取值范围：** - inherit，继承上级配置。 - custom，使用当前仓库配置。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("inherit_mod", NullValueHandling = NullValueHandling.Ignore)]
        public InheritModEnum InheritMod { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryInheritSettingUpdateBodyDto {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  inheritMod: ").Append(InheritMod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryInheritSettingUpdateBodyDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoryInheritSettingUpdateBodyDto input)
        {
            if (input == null) return false;
            if (this.Name != input.Name) return false;
            if (this.InheritMod != input.InheritMod) return false;

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
                hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.InheritMod.GetHashCode();
                return hashCode;
            }
        }
    }
}
