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
    /// **参数解释** 维度信息列表。 
    /// </summary>
    public class DimensionInfoResp 
    {
        /// <summary>
        /// **参数解释**： 资源类型。 **取值范围**： - all_instances: 全部资源 - specific_instances: 指定资源 
        /// </summary>
        /// <value>**参数解释**： 资源类型。 **取值范围**： - all_instances: 全部资源 - specific_instances: 指定资源 </value>
        [JsonConverter(typeof(EnumClassConverter<FilterTypeEnum>))]
        public class FilterTypeEnum
        {
            /// <summary>
            /// Enum ALL_INSTANCES for value: all_instances
            /// </summary>
            public static readonly FilterTypeEnum ALL_INSTANCES = new FilterTypeEnum("all_instances");

            /// <summary>
            /// Enum SPECIFIC_INSTANCES for value: specific_instances
            /// </summary>
            public static readonly FilterTypeEnum SPECIFIC_INSTANCES = new FilterTypeEnum("specific_instances");

            private static readonly Dictionary<string, FilterTypeEnum> StaticFields =
            new Dictionary<string, FilterTypeEnum>()
            {
                { "all_instances", ALL_INSTANCES },
                { "specific_instances", SPECIFIC_INSTANCES },
            };

            private string _value;

            public FilterTypeEnum()
            {

            }

            public FilterTypeEnum(string value)
            {
                _value = value;
            }

            public static FilterTypeEnum FromValue(string value)
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

                if (this.Equals(obj as FilterTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FilterTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FilterTypeEnum a, FilterTypeEnum b)
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

            public static bool operator !=(FilterTypeEnum a, FilterTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 维度名称。 **取值范围**： 多维度用逗号分隔，各服务资源的维度名称，请参阅具体云服务的文档。您可以直接从[[支持监控的服务列表](https://support.huaweicloud.com/api-ces/ces_03_0059.html)](tag:hc)[[支持监控的服务列表](https://support.huaweicloud.com/intl/en-us/api-ces/ces_03_0059.html)](tag:hk)[[支持监控的服务列表](https://support.huaweicloud.com/eu/en-us/api-ces/ces_03_0059.html)](tag:hws_eu)[[支持监控的服务列表](ces_03_0059.xml)](tag:ax,cmcc,ctc,dt,dt_test,hcso_dt,fcs,fcs_vm,mix,g42,hk_g42,hk_sbc,hk_tm,hk_vdf,hws_ocb,ocb,sbc,srg)页面导航至相应文档。。必须以字母开头，只能包含0-9/a-z/A-Z/_/-，多维度用\&quot;,\&quot;分隔，每个维度的最大长度为32。总长度为[1,131]个字符。目前最大支持4个维度。举例：单维度场景：instance_id；多维度场景：instance_id,disk 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 资源类型。 **取值范围**： - all_instances: 全部资源 - specific_instances: 指定资源 
        /// </summary>
        [JsonProperty("filter_type", NullValueHandling = NullValueHandling.Ignore)]
        public FilterTypeEnum FilterType { get; set; }
        /// <summary>
        /// **参数解释**： 维度值列表。 
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Values { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DimensionInfoResp {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  filterType: ").Append(FilterType).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DimensionInfoResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DimensionInfoResp input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.FilterType != input.FilterType) return false;
            if (this.Values != input.Values || (this.Values != null && input.Values != null && !this.Values.SequenceEqual(input.Values))) return false;

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
                hashCode = hashCode * 59 + this.FilterType.GetHashCode();
                if (this.Values != null) hashCode = hashCode * 59 + this.Values.GetHashCode();
                return hashCode;
            }
        }
    }
}
