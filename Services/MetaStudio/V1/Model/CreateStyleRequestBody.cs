using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 创建风格请求
    /// </summary>
    public class CreateStyleRequestBody 
    {
        /// <summary>
        /// 性别
        /// </summary>
        /// <value>性别</value>
        [JsonConverter(typeof(EnumClassConverter<SexEnum>))]
        public class SexEnum
        {
            /// <summary>
            /// Enum UNKNOW for value: UNKNOW
            /// </summary>
            public static readonly SexEnum UNKNOW = new SexEnum("UNKNOW");

            /// <summary>
            /// Enum MALE for value: MALE
            /// </summary>
            public static readonly SexEnum MALE = new SexEnum("MALE");

            /// <summary>
            /// Enum FEMALE for value: FEMALE
            /// </summary>
            public static readonly SexEnum FEMALE = new SexEnum("FEMALE");

            private static readonly Dictionary<string, SexEnum> StaticFields =
            new Dictionary<string, SexEnum>()
            {
                { "UNKNOW", UNKNOW },
                { "MALE", MALE },
                { "FEMALE", FEMALE },
            };

            private string _value;

            public SexEnum()
            {

            }

            public SexEnum(string value)
            {
                _value = value;
            }

            public static SexEnum FromValue(string value)
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

                if (this.Equals(obj as SexEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SexEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SexEnum a, SexEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(SexEnum a, SexEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数字人风格化名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 数字人风格化描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public SexEnum Sex { get; set; }
        /// <summary>
        /// 标签。单个标签16字节，多个用逗号分隔，最多50个。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 风格化素材资产组合。
        /// </summary>
        [JsonProperty("style_assets", NullValueHandling = NullValueHandling.Ignore)]
        public List<StyleAssetItem> StyleAssets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extra_meta", NullValueHandling = NullValueHandling.Ignore)]
        public StyleExtraMeta ExtraMeta { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateStyleRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  styleAssets: ").Append(StyleAssets).Append("\n");
            sb.Append("  extraMeta: ").Append(ExtraMeta).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateStyleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateStyleRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Sex != input.Sex) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.StyleAssets != input.StyleAssets || (this.StyleAssets != null && input.StyleAssets != null && !this.StyleAssets.SequenceEqual(input.StyleAssets))) return false;
            if (this.ExtraMeta != input.ExtraMeta || (this.ExtraMeta != null && !this.ExtraMeta.Equals(input.ExtraMeta))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.StyleAssets != null) hashCode = hashCode * 59 + this.StyleAssets.GetHashCode();
                if (this.ExtraMeta != null) hashCode = hashCode * 59 + this.ExtraMeta.GetHashCode();
                return hashCode;
            }
        }
    }
}
