using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 数据过滤规则请求体
    /// </summary>
    public class DataFilterRuleReq 
    {
        /// <summary>
        /// 校验请求的来源场景。用于区分数据过滤规则校验是来自数据同步任务执行场景，还是来自数据对比任务执行场景。 取值：job（数据同步任务执行时的过滤规则校验）/compare（数据对比任务执行时的过滤规则校验）
        /// </summary>
        /// <value>校验请求的来源场景。用于区分数据过滤规则校验是来自数据同步任务执行场景，还是来自数据对比任务执行场景。 取值：job（数据同步任务执行时的过滤规则校验）/compare（数据对比任务执行时的过滤规则校验）</value>
        [JsonConverter(typeof(EnumClassConverter<SourceEnum>))]
        public class SourceEnum
        {
            /// <summary>
            /// Enum JOB for value: job
            /// </summary>
            public static readonly SourceEnum JOB = new SourceEnum("job");

            /// <summary>
            /// Enum COMPARE for value: compare
            /// </summary>
            public static readonly SourceEnum COMPARE = new SourceEnum("compare");

            private static readonly Dictionary<string, SourceEnum> StaticFields =
            new Dictionary<string, SourceEnum>()
            {
                { "job", JOB },
                { "compare", COMPARE },
            };

            private string _value;

            public SourceEnum()
            {

            }

            public SourceEnum(string value)
            {
                _value = value;
            }

            public static SourceEnum FromValue(string value)
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

                if (this.Equals(obj as SourceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SourceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SourceEnum a, SourceEnum b)
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

            public static bool operator !=(SourceEnum a, SourceEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数据过滤条件列表。包含需要校验的数据过滤规则信息，当data_filter_type为common（简单条件过滤）时，此参数为必填项。列表中的每个元素代表一组过滤条件，包含过滤对象列表和源库过滤条件SQL。包含以下关键字段：filter_object_list（过滤对象列表）/source_filter_condition（源库过滤条件SQL）。适用条件：data_filter_type&#x3D;common时必填。
        /// </summary>
        [JsonProperty("general_filtering_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<GeneralTransformationReq> GeneralFilteringList { get; set; }

        /// <summary>
        /// 数据过滤高级设置列表。用于配置关联表场景下的高级过滤规则，包含数据库名、表名、列名、索引等详细过滤配置。当前Mysql-Mysql、Mysql-TaurusDB、TaurusDB-TaurusDB、TaurusDB-Mysql、Mysql-MariaDB、MariaDB-Mysql、MariaDB-TaurusDBL链路支持此功能。适用条件：data_filter_type&#x3D;config时必填。
        /// </summary>
        [JsonProperty("advanced_setting_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataFilteringAdvancedSetting> AdvancedSettingList { get; set; }

        /// <summary>
        /// 校验请求的来源场景。用于区分数据过滤规则校验是来自数据同步任务执行场景，还是来自数据对比任务执行场景。 取值：job（数据同步任务执行时的过滤规则校验）/compare（数据对比任务执行时的过滤规则校验）
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public SourceEnum Source { get; set; }
        /// <summary>
        /// 数据过滤类型。用于指定数据过滤规则的模式，common表示简单条件过滤（单表过滤条件），config表示关联表过滤（多表关联条件过滤）。 取值：common（简单条件过滤）/config（关联表过滤）。 约束：当简单条件过滤是子查询时，需要先校验关联条件，关联条件校验成功之后，需要保存关联条件。
        /// </summary>
        [JsonProperty("data_filter_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DataFilterType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataFilterRuleReq {\n");
            sb.Append("  generalFilteringList: ").Append(GeneralFilteringList).Append("\n");
            sb.Append("  advancedSettingList: ").Append(AdvancedSettingList).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  dataFilterType: ").Append(DataFilterType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataFilterRuleReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataFilterRuleReq input)
        {
            if (input == null) return false;
            if (this.GeneralFilteringList != input.GeneralFilteringList || (this.GeneralFilteringList != null && input.GeneralFilteringList != null && !this.GeneralFilteringList.SequenceEqual(input.GeneralFilteringList))) return false;
            if (this.AdvancedSettingList != input.AdvancedSettingList || (this.AdvancedSettingList != null && input.AdvancedSettingList != null && !this.AdvancedSettingList.SequenceEqual(input.AdvancedSettingList))) return false;
            if (this.Source != input.Source) return false;
            if (this.DataFilterType != input.DataFilterType || (this.DataFilterType != null && !this.DataFilterType.Equals(input.DataFilterType))) return false;

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
                if (this.GeneralFilteringList != null) hashCode = hashCode * 59 + this.GeneralFilteringList.GetHashCode();
                if (this.AdvancedSettingList != null) hashCode = hashCode * 59 + this.AdvancedSettingList.GetHashCode();
                hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.DataFilterType != null) hashCode = hashCode * 59 + this.DataFilterType.GetHashCode();
                return hashCode;
            }
        }
    }
}
