using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListIpdLabelsRequest 
    {
        /// <summary>
        /// 标签归属的工作项分类，不传该参数时默认查询所有类型下的标签。不推荐使用此参数，建议使用category_types参数。
        /// </summary>
        /// <value>标签归属的工作项分类，不传该参数时默认查询所有类型下的标签。不推荐使用此参数，建议使用category_types参数。</value>
        [JsonConverter(typeof(EnumClassConverter<LabelTypeEnum>))]
        public class LabelTypeEnum
        {
            /// <summary>
            /// Enum FEATURE for value: feature
            /// </summary>
            public static readonly LabelTypeEnum FEATURE = new LabelTypeEnum("feature");

            /// <summary>
            /// Enum RAW_REQUIREMENT for value: raw requirement
            /// </summary>
            public static readonly LabelTypeEnum RAW_REQUIREMENT = new LabelTypeEnum("raw requirement");

            /// <summary>
            /// Enum REQUIREMENT for value: requirement
            /// </summary>
            public static readonly LabelTypeEnum REQUIREMENT = new LabelTypeEnum("requirement");

            /// <summary>
            /// Enum TASK for value: task
            /// </summary>
            public static readonly LabelTypeEnum TASK = new LabelTypeEnum("task");

            /// <summary>
            /// Enum BUG for value: bug
            /// </summary>
            public static readonly LabelTypeEnum BUG = new LabelTypeEnum("bug");

            private static readonly Dictionary<string, LabelTypeEnum> StaticFields =
            new Dictionary<string, LabelTypeEnum>()
            {
                { "feature", FEATURE },
                { "raw requirement", RAW_REQUIREMENT },
                { "requirement", REQUIREMENT },
                { "task", TASK },
                { "bug", BUG },
            };

            private string _value;

            public LabelTypeEnum()
            {

            }

            public LabelTypeEnum(string value)
            {
                _value = value;
            }

            public static LabelTypeEnum FromValue(string value)
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

                if (this.Equals(obj as LabelTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LabelTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LabelTypeEnum a, LabelTypeEnum b)
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

            public static bool operator !=(LabelTypeEnum a, LabelTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 项目32位ID，项目唯一标识。通过查询IPD项目列表获取，响应消息体中的id字段的值就是项目ID。
        /// </summary>
        [SDKProperty("project_id", IsPath = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 标签归属的工作项分类，不传该参数时默认查询所有类型下的标签。不推荐使用此参数，建议使用category_types参数。
        /// </summary>
        [SDKProperty("label_type", IsQuery = true)]
        [JsonProperty("label_type", NullValueHandling = NullValueHandling.Ignore)]
        public LabelTypeEnum LabelType { get; set; }
        /// <summary>
        /// 标签名称
        /// </summary>
        [SDKProperty("title", IsQuery = true)]
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 工作项类型编码。
        /// </summary>
        [SDKProperty("category_types", IsQuery = true)]
        [JsonProperty("category_types", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryTypes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListIpdLabelsRequest {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  labelType: ").Append(LabelType).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  categoryTypes: ").Append(CategoryTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListIpdLabelsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListIpdLabelsRequest input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.LabelType != input.LabelType) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.CategoryTypes != input.CategoryTypes || (this.CategoryTypes != null && !this.CategoryTypes.Equals(input.CategoryTypes))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                hashCode = hashCode * 59 + this.LabelType.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.CategoryTypes != null) hashCode = hashCode * 59 + this.CategoryTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
