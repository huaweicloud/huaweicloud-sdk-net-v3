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
    /// Request Object
    /// </summary>
    public class ListRepositoryTemplatesRequest 
    {
        /// <summary>
        /// **参数解释：** 是否支持自动创建流水线。 **约束限制：** 不涉及 **取值范围：** - SupportPipeline，支持自动创建流水线。 - UnsupportedPipeline 不支持自动创建流水线。 **默认取值：** 不涉及
        /// </summary>
        /// <value>**参数解释：** 是否支持自动创建流水线。 **约束限制：** 不涉及 **取值范围：** - SupportPipeline，支持自动创建流水线。 - UnsupportedPipeline 不支持自动创建流水线。 **默认取值：** 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<PipelineEnum>))]
        public class PipelineEnum
        {
            /// <summary>
            /// Enum SUPPORTPIPELINE for value: SupportPipeline
            /// </summary>
            public static readonly PipelineEnum SUPPORTPIPELINE = new PipelineEnum("SupportPipeline");

            /// <summary>
            /// Enum UNSUPPORTEDPIPELINE for value: UnsupportedPipeline
            /// </summary>
            public static readonly PipelineEnum UNSUPPORTEDPIPELINE = new PipelineEnum("UnsupportedPipeline");

            private static readonly Dictionary<string, PipelineEnum> StaticFields =
            new Dictionary<string, PipelineEnum>()
            {
                { "SupportPipeline", SUPPORTPIPELINE },
                { "UnsupportedPipeline", UNSUPPORTEDPIPELINE },
            };

            private string _value;

            public PipelineEnum()
            {

            }

            public PipelineEnum(string value)
            {
                _value = value;
            }

            public static PipelineEnum FromValue(string value)
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

                if (this.Equals(obj as PipelineEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PipelineEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PipelineEnum a, PipelineEnum b)
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

            public static bool operator !=(PipelineEnum a, PipelineEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 自动创建流水线。 **约束限制：** 不涉及 **取值范围：** - SYSTEM,USER，个人和官方模板。 - SYSTEM，官方模板。 - USER，个人模板。 **默认取值：** 不涉及
        /// </summary>
        /// <value>**参数解释：** 自动创建流水线。 **约束限制：** 不涉及 **取值范围：** - SYSTEM,USER，个人和官方模板。 - SYSTEM，官方模板。 - USER，个人模板。 **默认取值：** 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum SYSTEM_USER for value: SYSTEM,USER
            /// </summary>
            public static readonly TypeEnum SYSTEM_USER = new TypeEnum("SYSTEM,USER");

            /// <summary>
            /// Enum SYSTEM for value: SYSTEM
            /// </summary>
            public static readonly TypeEnum SYSTEM = new TypeEnum("SYSTEM");

            /// <summary>
            /// Enum USER for value: USER
            /// </summary>
            public static readonly TypeEnum USER = new TypeEnum("USER");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "SYSTEM,USER", SYSTEM_USER },
                { "SYSTEM", SYSTEM },
                { "USER", USER },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 按照模板仓的创建时间进行排序。 **约束限制：** 不涉及 **取值范围：** - up，升序。 - down，降序。 **默认取值：** 不涉及
        /// </summary>
        /// <value>**参数解释：** 按照模板仓的创建时间进行排序。 **约束限制：** 不涉及 **取值范围：** - up，升序。 - down，降序。 **默认取值：** 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<DateOrderEnum>))]
        public class DateOrderEnum
        {
            /// <summary>
            /// Enum UP for value: up
            /// </summary>
            public static readonly DateOrderEnum UP = new DateOrderEnum("up");

            /// <summary>
            /// Enum DOWN for value: down
            /// </summary>
            public static readonly DateOrderEnum DOWN = new DateOrderEnum("down");

            private static readonly Dictionary<string, DateOrderEnum> StaticFields =
            new Dictionary<string, DateOrderEnum>()
            {
                { "up", UP },
                { "down", DOWN },
            };

            private string _value;

            public DateOrderEnum()
            {

            }

            public DateOrderEnum(string value)
            {
                _value = value;
            }

            public static DateOrderEnum FromValue(string value)
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

                if (this.Equals(obj as DateOrderEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DateOrderEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DateOrderEnum a, DateOrderEnum b)
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

            public static bool operator !=(DateOrderEnum a, DateOrderEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 偏移量，从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释：** 返回数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释：** 应用类型。 **约束限制：** 不涉及 **取值范围：** - Android。 - Console。 - HarmonyOS。 - OTHERS。 - REST API。 - ServiceStage。 - Web网站。 - 图形用户界面。 **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("platform", IsQuery = true)]
        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <summary>
        /// **参数解释：** 是否支持自动创建流水线。 **约束限制：** 不涉及 **取值范围：** - SupportPipeline，支持自动创建流水线。 - UnsupportedPipeline 不支持自动创建流水线。 **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("pipeline", IsQuery = true)]
        [JsonProperty("pipeline", NullValueHandling = NullValueHandling.Ignore)]
        public PipelineEnum Pipeline { get; set; }
        /// <summary>
        /// **参数解释：** 自动创建流水线。 **约束限制：** 不涉及 **取值范围：** - SYSTEM,USER，个人和官方模板。 - SYSTEM，官方模板。 - USER，个人模板。 **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释：** 查询关键字，按模板仓标题搜索。 **约束限制：** 不涉及 **取值范围：** 字符串长度0至50。 **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("search", IsQuery = true)]
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// **参数解释：** 参赛类型。 **约束限制：** 不涉及 **取值范围：** - AI。 - 大数据。 - 小程序。 - 微服务。 **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("enter_type", IsQuery = true)]
        [JsonProperty("enter_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterType { get; set; }

        /// <summary>
        /// **参数解释：** 按照模板仓的创建时间进行排序。 **约束限制：** 不涉及 **取值范围：** - up，升序。 - down，降序。 **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("date_order", IsQuery = true)]
        [JsonProperty("date_order", NullValueHandling = NullValueHandling.Ignore)]
        public DateOrderEnum DateOrder { get; set; }
        /// <summary>
        /// **参数解释：** 编程语言。 **约束限制：** 不涉及 **取值范围：** - ArkTS。 - ASP.NET。 - C。 - C#。 - C++。 - Go。 - Groovy。 - HTML。 - Java。 - NodeJS。 - OTHERS。 - PHP。 - Python。 **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("language", IsQuery = true)]
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// **参数解释：** 项目的32位uuid，项目唯一标识，通过[[查询项目列表](https://support.huaweicloud.com/api-projectman/ListProjectsV4.html)](tag:hws)[[查询项目列表](https://support.huaweicloud.com/intl/en-us/api-projectman/ListProjectsV4.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm)接口查询项目列表获取。 **约束限制：** 当该参数不为空时，仅返回当前项目下符合搜索条件的模板仓 **取值范围：** 字符串长度32。 **取值范围：** 不涉及
        /// </summary>
        [SDKProperty("project_id", IsQuery = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRepositoryTemplatesRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  platform: ").Append(Platform).Append("\n");
            sb.Append("  pipeline: ").Append(Pipeline).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  search: ").Append(Search).Append("\n");
            sb.Append("  enterType: ").Append(EnterType).Append("\n");
            sb.Append("  dateOrder: ").Append(DateOrder).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRepositoryTemplatesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRepositoryTemplatesRequest input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Platform != input.Platform || (this.Platform != null && !this.Platform.Equals(input.Platform))) return false;
            if (this.Pipeline != input.Pipeline) return false;
            if (this.Type != input.Type) return false;
            if (this.Search != input.Search || (this.Search != null && !this.Search.Equals(input.Search))) return false;
            if (this.EnterType != input.EnterType || (this.EnterType != null && !this.EnterType.Equals(input.EnterType))) return false;
            if (this.DateOrder != input.DateOrder) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Platform != null) hashCode = hashCode * 59 + this.Platform.GetHashCode();
                hashCode = hashCode * 59 + this.Pipeline.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Search != null) hashCode = hashCode * 59 + this.Search.GetHashCode();
                if (this.EnterType != null) hashCode = hashCode * 59 + this.EnterType.GetHashCode();
                hashCode = hashCode * 59 + this.DateOrder.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
