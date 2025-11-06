using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListAlarmTemplatesRequest 
    {
        /// <summary>
        /// 模板类型(system代表默认指标模板，custom代表自定义指标模板，system_event代表默认事件模板，custom_event代表自定义事件模板，system_custom_event代表全部事件模板),不传返回全部指标模板
        /// </summary>
        /// <value>模板类型(system代表默认指标模板，custom代表自定义指标模板，system_event代表默认事件模板，custom_event代表自定义事件模板，system_custom_event代表全部事件模板),不传返回全部指标模板</value>
        [JsonConverter(typeof(EnumClassConverter<TemplateTypeEnum>))]
        public class TemplateTypeEnum
        {
            /// <summary>
            /// Enum SYSTEM for value: system
            /// </summary>
            public static readonly TemplateTypeEnum SYSTEM = new TemplateTypeEnum("system");

            /// <summary>
            /// Enum CUSTOM for value: custom
            /// </summary>
            public static readonly TemplateTypeEnum CUSTOM = new TemplateTypeEnum("custom");

            /// <summary>
            /// Enum SYSTEM_EVENT for value: system_event
            /// </summary>
            public static readonly TemplateTypeEnum SYSTEM_EVENT = new TemplateTypeEnum("system_event");

            /// <summary>
            /// Enum CUSTOM_EVENT for value: custom_event
            /// </summary>
            public static readonly TemplateTypeEnum CUSTOM_EVENT = new TemplateTypeEnum("custom_event");

            /// <summary>
            /// Enum SYSTEM_CUSTOM_EVENT for value: system_custom_event
            /// </summary>
            public static readonly TemplateTypeEnum SYSTEM_CUSTOM_EVENT = new TemplateTypeEnum("system_custom_event");

            private static readonly Dictionary<string, TemplateTypeEnum> StaticFields =
            new Dictionary<string, TemplateTypeEnum>()
            {
                { "system", SYSTEM },
                { "custom", CUSTOM },
                { "system_event", SYSTEM_EVENT },
                { "custom_event", CUSTOM_EVENT },
                { "system_custom_event", SYSTEM_CUSTOM_EVENT },
            };

            private string _value;

            public TemplateTypeEnum()
            {

            }

            public TemplateTypeEnum(string value)
            {
                _value = value;
            }

            public static TemplateTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TemplateTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TemplateTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TemplateTypeEnum a, TemplateTypeEnum b)
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

            public static bool operator !=(TemplateTypeEnum a, TemplateTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 分页查询时查询的起始位置，表示从第几条数据开始，默认为0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询结果条数的限制值，取值范围为[1,100]，默认值为100
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 查询服务的命名空间，各服务命名空间请参考“[服务命名空间](ces_03_0059.xml)”
        /// </summary>
        [SDKProperty("namespace", IsQuery = true)]
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 资源维度，必须以字母开头，多维度用\&quot;,\&quot;分隔，只能包含0-9/a-z/A-Z/_/-，每个维度的最大长度为32
        /// </summary>
        [SDKProperty("dim_name", IsQuery = true)]
        [JsonProperty("dim_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DimName { get; set; }

        /// <summary>
        /// 模板类型(system代表默认指标模板，custom代表自定义指标模板，system_event代表默认事件模板，custom_event代表自定义事件模板，system_custom_event代表全部事件模板),不传返回全部指标模板
        /// </summary>
        [SDKProperty("template_type", IsQuery = true)]
        [JsonProperty("template_type", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateTypeEnum TemplateType { get; set; }
        /// <summary>
        /// 告警模板的名称，以字母或汉字开头，可包含字母、数字、汉字、_、-，长度范围[1,128]，支持模糊匹配
        /// </summary>
        [SDKProperty("template_name", IsQuery = true)]
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// （已废弃）支持按照产品名称粒度进行查询告警模板，产品名称一般由\&quot;服务命名空间,服务首层维度名称\&quot;组成，如\&quot;SYS.ECS,instance_id\&quot;
        /// </summary>
        [SDKProperty("product_name", IsQuery = true)]
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAlarmTemplatesRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  dimName: ").Append(DimName).Append("\n");
            sb.Append("  templateType: ").Append(TemplateType).Append("\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  productName: ").Append(ProductName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAlarmTemplatesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAlarmTemplatesRequest input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.DimName != input.DimName || (this.DimName != null && !this.DimName.Equals(input.DimName))) return false;
            if (this.TemplateType != input.TemplateType) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;
            if (this.ProductName != input.ProductName || (this.ProductName != null && !this.ProductName.Equals(input.ProductName))) return false;

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
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.DimName != null) hashCode = hashCode * 59 + this.DimName.GetHashCode();
                hashCode = hashCode * 59 + this.TemplateType.GetHashCode();
                if (this.TemplateName != null) hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.ProductName != null) hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                return hashCode;
            }
        }
    }
}
