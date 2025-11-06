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
    /// **参数解释：** 可集成系统CodeArts Req设置信息。
    /// </summary>
    public class ReqSettingDto 
    {
        /// <summary>
        /// **参数解释：** 分支的类型，文本或者正则表达式。 **取值范围：** plain代表文本，regex代表正则表达式。
        /// </summary>
        /// <value>**参数解释：** 分支的类型，文本或者正则表达式。 **取值范围：** plain代表文本，regex代表正则表达式。</value>
        [JsonConverter(typeof(EnumClassConverter<BranchesTypeEnum>))]
        public class BranchesTypeEnum
        {
            /// <summary>
            /// Enum PLAIN for value: plain
            /// </summary>
            public static readonly BranchesTypeEnum PLAIN = new BranchesTypeEnum("plain");

            /// <summary>
            /// Enum REGEX for value: regex
            /// </summary>
            public static readonly BranchesTypeEnum REGEX = new BranchesTypeEnum("regex");

            private static readonly Dictionary<string, BranchesTypeEnum> StaticFields =
            new Dictionary<string, BranchesTypeEnum>()
            {
                { "plain", PLAIN },
                { "regex", REGEX },
            };

            private string _value;

            public BranchesTypeEnum()
            {

            }

            public BranchesTypeEnum(string value)
            {
                _value = value;
            }

            public static BranchesTypeEnum FromValue(string value)
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

                if (this.Equals(obj as BranchesTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BranchesTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BranchesTypeEnum a, BranchesTypeEnum b)
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

            public static bool operator !=(BranchesTypeEnum a, BranchesTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 关联的CodeArts Req项目类型。 **取值范围：** scrum代表scrum类型项目，ipd代表IPD类型项目, xboard为看板类型项目。
        /// </summary>
        /// <value>**参数解释：** 关联的CodeArts Req项目类型。 **取值范围：** scrum代表scrum类型项目，ipd代表IPD类型项目, xboard为看板类型项目。</value>
        [JsonConverter(typeof(EnumClassConverter<ProjectTypeEnum>))]
        public class ProjectTypeEnum
        {
            /// <summary>
            /// Enum SCRUM for value: scrum
            /// </summary>
            public static readonly ProjectTypeEnum SCRUM = new ProjectTypeEnum("scrum");

            /// <summary>
            /// Enum IPD for value: ipd
            /// </summary>
            public static readonly ProjectTypeEnum IPD = new ProjectTypeEnum("ipd");

            /// <summary>
            /// Enum XBOARD for value: xboard
            /// </summary>
            public static readonly ProjectTypeEnum XBOARD = new ProjectTypeEnum("xboard");

            private static readonly Dictionary<string, ProjectTypeEnum> StaticFields =
            new Dictionary<string, ProjectTypeEnum>()
            {
                { "scrum", SCRUM },
                { "ipd", IPD },
                { "xboard", XBOARD },
            };

            private string _value;

            public ProjectTypeEnum()
            {

            }

            public ProjectTypeEnum(string value)
            {
                _value = value;
            }

            public static ProjectTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ProjectTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProjectTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProjectTypeEnum a, ProjectTypeEnum b)
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

            public static bool operator !=(ProjectTypeEnum a, ProjectTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 是否开启集成CodeArts Req **取值范围：** true：开启集成CodeArts Req，false：未开启集成CodeArts Req。
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        /// <summary>
        /// **参数解释：** 应用排除状态和可关联类别限制的分支列表，该分支指代合并请求的目标分支，可支持多个分支用英文逗号拼接或者正则表达式，在项目层级和代码组层级只支持配置正则表达式。
        /// </summary>
        [JsonProperty("branches", NullValueHandling = NullValueHandling.Ignore)]
        public string Branches { get; set; }

        /// <summary>
        /// **参数解释：** 分支的类型，文本或者正则表达式。 **取值范围：** plain代表文本，regex代表正则表达式。
        /// </summary>
        [JsonProperty("branches_type", NullValueHandling = NullValueHandling.Ignore)]
        public BranchesTypeEnum BranchesType { get; set; }
        /// <summary>
        /// **参数解释：** 关联的CodeArts Req项目类型。 **取值范围：** scrum代表scrum类型项目，ipd代表IPD类型项目, xboard为看板类型项目。
        /// </summary>
        [JsonProperty("project_type", NullValueHandling = NullValueHandling.Ignore)]
        public ProjectTypeEnum ProjectType { get; set; }
        /// <summary>
        /// **参数解释：** 可关联类型列表，逗号分隔。
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public string Categories { get; set; }

        /// <summary>
        /// **参数解释：** 可关联类型编码列表，逗号分隔。
        /// </summary>
        [JsonProperty("category_codes", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryCodes { get; set; }

        /// <summary>
        /// **参数解释：** 排除状态列表，逗号分隔。
        /// </summary>
        [JsonProperty("exclude_statuses", NullValueHandling = NullValueHandling.Ignore)]
        public string ExcludeStatuses { get; set; }

        /// <summary>
        /// **参数解释：** 排除状态编码列表，逗号分隔。
        /// </summary>
        [JsonProperty("exclude_status_codes", NullValueHandling = NullValueHandling.Ignore)]
        public string ExcludeStatusCodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReqSettingDto {\n");
            sb.Append("  active: ").Append(Active).Append("\n");
            sb.Append("  branches: ").Append(Branches).Append("\n");
            sb.Append("  branchesType: ").Append(BranchesType).Append("\n");
            sb.Append("  projectType: ").Append(ProjectType).Append("\n");
            sb.Append("  categories: ").Append(Categories).Append("\n");
            sb.Append("  categoryCodes: ").Append(CategoryCodes).Append("\n");
            sb.Append("  excludeStatuses: ").Append(ExcludeStatuses).Append("\n");
            sb.Append("  excludeStatusCodes: ").Append(ExcludeStatusCodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReqSettingDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReqSettingDto input)
        {
            if (input == null) return false;
            if (this.Active != input.Active || (this.Active != null && !this.Active.Equals(input.Active))) return false;
            if (this.Branches != input.Branches || (this.Branches != null && !this.Branches.Equals(input.Branches))) return false;
            if (this.BranchesType != input.BranchesType) return false;
            if (this.ProjectType != input.ProjectType) return false;
            if (this.Categories != input.Categories || (this.Categories != null && !this.Categories.Equals(input.Categories))) return false;
            if (this.CategoryCodes != input.CategoryCodes || (this.CategoryCodes != null && !this.CategoryCodes.Equals(input.CategoryCodes))) return false;
            if (this.ExcludeStatuses != input.ExcludeStatuses || (this.ExcludeStatuses != null && !this.ExcludeStatuses.Equals(input.ExcludeStatuses))) return false;
            if (this.ExcludeStatusCodes != input.ExcludeStatusCodes || (this.ExcludeStatusCodes != null && !this.ExcludeStatusCodes.Equals(input.ExcludeStatusCodes))) return false;

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
                if (this.Active != null) hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Branches != null) hashCode = hashCode * 59 + this.Branches.GetHashCode();
                hashCode = hashCode * 59 + this.BranchesType.GetHashCode();
                hashCode = hashCode * 59 + this.ProjectType.GetHashCode();
                if (this.Categories != null) hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.CategoryCodes != null) hashCode = hashCode * 59 + this.CategoryCodes.GetHashCode();
                if (this.ExcludeStatuses != null) hashCode = hashCode * 59 + this.ExcludeStatuses.GetHashCode();
                if (this.ExcludeStatusCodes != null) hashCode = hashCode * 59 + this.ExcludeStatusCodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
