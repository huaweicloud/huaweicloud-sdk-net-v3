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
    public class WebHookBranchCfgDto 
    {
        /// <summary>
        /// **参数解释：** 分支类型。 **取值范围：** - 0，文本。 - 1，通配符。 - 2，正则。
        /// </summary>
        /// <value>**参数解释：** 分支类型。 **取值范围：** - 0，文本。 - 1，通配符。 - 2，正则。</value>
        [JsonConverter(typeof(EnumClassConverter<BranchTypeEnum>))]
        public class BranchTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly BranchTypeEnum NUMBER_0 = new BranchTypeEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly BranchTypeEnum NUMBER_1 = new BranchTypeEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly BranchTypeEnum NUMBER_2 = new BranchTypeEnum(2);

            private static readonly Dictionary<int?, BranchTypeEnum> StaticFields =
            new Dictionary<int?, BranchTypeEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
            };

            private int? _value;

            public BranchTypeEnum()
            {

            }

            public BranchTypeEnum(int? value)
            {
                _value = value;
            }

            public static BranchTypeEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as BranchTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BranchTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BranchTypeEnum a, BranchTypeEnum b)
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

            public static bool operator !=(BranchTypeEnum a, BranchTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 仓库名类型。 **取值范围：** - 0，文本。 - 1，通配符。 - 2，正则。
        /// </summary>
        /// <value>**参数解释：** 仓库名类型。 **取值范围：** - 0，文本。 - 1，通配符。 - 2，正则。</value>
        [JsonConverter(typeof(EnumClassConverter<ProjectTypeEnum>))]
        public class ProjectTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly ProjectTypeEnum NUMBER_0 = new ProjectTypeEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly ProjectTypeEnum NUMBER_1 = new ProjectTypeEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly ProjectTypeEnum NUMBER_2 = new ProjectTypeEnum(2);

            private static readonly Dictionary<int?, ProjectTypeEnum> StaticFields =
            new Dictionary<int?, ProjectTypeEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
            };

            private int? _value;

            public ProjectTypeEnum()
            {

            }

            public ProjectTypeEnum(int? value)
            {
                _value = value;
            }

            public static ProjectTypeEnum FromValue(int? value)
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

            public int? GetValue()
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
        /// **参数解释：** 分支类型。 **取值范围：** - 0，文本。 - 1，通配符。 - 2，正则。
        /// </summary>
        [JsonProperty("branch_type", NullValueHandling = NullValueHandling.Ignore)]
        public BranchTypeEnum BranchType { get; set; }
        /// <summary>
        /// **参数解释：** 分支名配置。 **取值范围：** 最小1个字节，最大255字节
        /// </summary>
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }

        /// <summary>
        /// **参数解释：** 仓库名类型。 **取值范围：** - 0，文本。 - 1，通配符。 - 2，正则。
        /// </summary>
        [JsonProperty("project_type", NullValueHandling = NullValueHandling.Ignore)]
        public ProjectTypeEnum ProjectType { get; set; }
        /// <summary>
        /// **参数解释：** 仓库名配置。 **取值范围：** 最小1个字节，最大255字节
        /// </summary>
        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public string Project { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebHookBranchCfgDto {\n");
            sb.Append("  branchType: ").Append(BranchType).Append("\n");
            sb.Append("  branch: ").Append(Branch).Append("\n");
            sb.Append("  projectType: ").Append(ProjectType).Append("\n");
            sb.Append("  project: ").Append(Project).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebHookBranchCfgDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WebHookBranchCfgDto input)
        {
            if (input == null) return false;
            if (this.BranchType != input.BranchType) return false;
            if (this.Branch != input.Branch || (this.Branch != null && !this.Branch.Equals(input.Branch))) return false;
            if (this.ProjectType != input.ProjectType) return false;
            if (this.Project != input.Project || (this.Project != null && !this.Project.Equals(input.Project))) return false;

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
                hashCode = hashCode * 59 + this.BranchType.GetHashCode();
                if (this.Branch != null) hashCode = hashCode * 59 + this.Branch.GetHashCode();
                hashCode = hashCode * 59 + this.ProjectType.GetHashCode();
                if (this.Project != null) hashCode = hashCode * 59 + this.Project.GetHashCode();
                return hashCode;
            }
        }
    }
}
