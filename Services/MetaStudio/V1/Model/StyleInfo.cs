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
    /// 服务开通请求
    /// </summary>
    public class StyleInfo 
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
        /// 数字人风格状态枚举 * CREATING：创建中 * PUBLISHED：已发布 * DELETED：已删除 * UNPUBLISHED：未发布 * PUBLISHING：发布中
        /// </summary>
        /// <value>数字人风格状态枚举 * CREATING：创建中 * PUBLISHED：已发布 * DELETED：已删除 * UNPUBLISHED：未发布 * PUBLISHING：发布中</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum CREATING for value: CREATING
            /// </summary>
            public static readonly StateEnum CREATING = new StateEnum("CREATING");

            /// <summary>
            /// Enum PUBLISHED for value: PUBLISHED
            /// </summary>
            public static readonly StateEnum PUBLISHED = new StateEnum("PUBLISHED");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly StateEnum DELETED = new StateEnum("DELETED");

            /// <summary>
            /// Enum UNPUBLISHED for value: UNPUBLISHED
            /// </summary>
            public static readonly StateEnum UNPUBLISHED = new StateEnum("UNPUBLISHED");

            /// <summary>
            /// Enum PUBLISHING for value: PUBLISHING
            /// </summary>
            public static readonly StateEnum PUBLISHING = new StateEnum("PUBLISHING");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "CREATING", CREATING },
                { "PUBLISHED", PUBLISHED },
                { "DELETED", DELETED },
                { "UNPUBLISHED", UNPUBLISHED },
                { "PUBLISHING", PUBLISHING },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
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
        /// 数字人风格ID
        /// </summary>
        [JsonProperty("style_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StyleId { get; set; }

        /// <summary>
        /// 数字人风格创建时间，格式遵循：RFC 3339。 例 “2020-07-30T10:43:17Z”。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 数字人风格更新时间，格式遵循：RFC 3339。 例 “2020-07-30T10:43:17Z”。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 数字人风格状态枚举 * CREATING：创建中 * PUBLISHED：已发布 * DELETED：已删除 * UNPUBLISHED：未发布 * PUBLISHING：发布中
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StyleInfo {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  styleAssets: ").Append(StyleAssets).Append("\n");
            sb.Append("  extraMeta: ").Append(ExtraMeta).Append("\n");
            sb.Append("  styleId: ").Append(StyleId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StyleInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StyleInfo input)
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
            if (this.StyleId != input.StyleId || (this.StyleId != null && !this.StyleId.Equals(input.StyleId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.State != input.State) return false;

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
                if (this.StyleId != null) hashCode = hashCode * 59 + this.StyleId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                return hashCode;
            }
        }
    }
}
