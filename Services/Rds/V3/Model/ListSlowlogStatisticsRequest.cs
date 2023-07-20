using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListSlowlogStatisticsRequest 
    {
        /// <summary>
        /// 语言
        /// </summary>
        /// <value>语言</value>
        [JsonConverter(typeof(EnumClassConverter<XLanguageEnum>))]
        public class XLanguageEnum
        {
            /// <summary>
            /// Enum ZH_CN for value: zh-cn
            /// </summary>
            public static readonly XLanguageEnum ZH_CN = new XLanguageEnum("zh-cn");

            /// <summary>
            /// Enum EN_US for value: en-us
            /// </summary>
            public static readonly XLanguageEnum EN_US = new XLanguageEnum("en-us");

            private static readonly Dictionary<string, XLanguageEnum> StaticFields =
            new Dictionary<string, XLanguageEnum>()
            {
                { "zh-cn", ZH_CN },
                { "en-us", EN_US },
            };

            private string _value;

            public XLanguageEnum()
            {

            }

            public XLanguageEnum(string value)
            {
                _value = value;
            }

            public static XLanguageEnum FromValue(string value)
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

                if (this.Equals(obj as XLanguageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(XLanguageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(XLanguageEnum a, XLanguageEnum b)
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

            public static bool operator !=(XLanguageEnum a, XLanguageEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 语句类型，ALL表示查询所有语句类型，也可指定日志类型 - INSERT - UPDATE - SELECT - DELETE - CREATE - ALL
        /// </summary>
        /// <value>语句类型，ALL表示查询所有语句类型，也可指定日志类型 - INSERT - UPDATE - SELECT - DELETE - CREATE - ALL</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum INSERT for value: INSERT
            /// </summary>
            public static readonly TypeEnum INSERT = new TypeEnum("INSERT");

            /// <summary>
            /// Enum UPDATE for value: UPDATE
            /// </summary>
            public static readonly TypeEnum UPDATE = new TypeEnum("UPDATE");

            /// <summary>
            /// Enum SELECT for value: SELECT
            /// </summary>
            public static readonly TypeEnum SELECT = new TypeEnum("SELECT");

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            public static readonly TypeEnum DELETE = new TypeEnum("DELETE");

            /// <summary>
            /// Enum CREATE for value: CREATE
            /// </summary>
            public static readonly TypeEnum CREATE = new TypeEnum("CREATE");

            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly TypeEnum ALL = new TypeEnum("ALL");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "INSERT", INSERT },
                { "UPDATE", UPDATE },
                { "SELECT", SELECT },
                { "DELETE", DELETE },
                { "CREATE", CREATE },
                { "ALL", ALL },
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 语言
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public XLanguageEnum XLanguage { get; set; }
        /// <summary>
        /// 实例ID。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 当前页号
        /// </summary>
        [SDKProperty("cur_page", IsQuery = true)]
        [JsonProperty("cur_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurPage { get; set; }

        /// <summary>
        /// 每页多少条记录，取值范围0~100
        /// </summary>
        [SDKProperty("per_page", IsQuery = true)]
        [JsonProperty("per_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerPage { get; set; }

        /// <summary>
        /// 开始时间，格式为“yyyy-mm-ddThh:mm:ssZ”。其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [SDKProperty("start_date", IsQuery = true)]
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public string StartDate { get; set; }

        /// <summary>
        /// 结束时间，格式为“yyyy-mm-ddThh:mm:ssZ”。其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [SDKProperty("end_date", IsQuery = true)]
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public string EndDate { get; set; }

        /// <summary>
        /// 语句类型，ALL表示查询所有语句类型，也可指定日志类型 - INSERT - UPDATE - SELECT - DELETE - CREATE - ALL
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 取值范围：\&quot;executeTime\&quot;,表示按执行时间降序排序，不传或者传其他表示按执行次数降序排序
        /// </summary>
        [SDKProperty("sort", IsQuery = true)]
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public string Sort { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSlowlogStatisticsRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  curPage: ").Append(CurPage).Append("\n");
            sb.Append("  perPage: ").Append(PerPage).Append("\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  endDate: ").Append(EndDate).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSlowlogStatisticsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSlowlogStatisticsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XLanguage == input.XLanguage ||
                    (this.XLanguage != null &&
                    this.XLanguage.Equals(input.XLanguage))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.CurPage == input.CurPage ||
                    (this.CurPage != null &&
                    this.CurPage.Equals(input.CurPage))
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    (this.PerPage != null &&
                    this.PerPage.Equals(input.PerPage))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.XLanguage != null)
                    hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.CurPage != null)
                    hashCode = hashCode * 59 + this.CurPage.GetHashCode();
                if (this.PerPage != null)
                    hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
                return hashCode;
            }
        }
    }
}
