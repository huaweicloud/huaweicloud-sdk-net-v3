using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class LineCompareResultOverview 
    {
        /// <summary>
        /// 对比结果。 - CONSISTENT-一致 - INCONSISTENT-不一致 - COMPARING-正在对比 - WAITING_FOR_COMPARISON-等待对比 - FAILED_TO_COMPARE-对比失败 - TARGET_DB_NOT_EXIT-目标库不存在 - CAN_NOT_COMPARE-无法对比
        /// </summary>
        /// <value>对比结果。 - CONSISTENT-一致 - INCONSISTENT-不一致 - COMPARING-正在对比 - WAITING_FOR_COMPARISON-等待对比 - FAILED_TO_COMPARE-对比失败 - TARGET_DB_NOT_EXIT-目标库不存在 - CAN_NOT_COMPARE-无法对比</value>
        [JsonConverter(typeof(EnumClassConverter<LineCompareResultEnum>))]
        public class LineCompareResultEnum
        {
            /// <summary>
            /// Enum CONSISTENT for value: CONSISTENT
            /// </summary>
            public static readonly LineCompareResultEnum CONSISTENT = new LineCompareResultEnum("CONSISTENT");

            /// <summary>
            /// Enum INCONSISTENT for value: INCONSISTENT
            /// </summary>
            public static readonly LineCompareResultEnum INCONSISTENT = new LineCompareResultEnum("INCONSISTENT");

            /// <summary>
            /// Enum COMPARING for value: COMPARING
            /// </summary>
            public static readonly LineCompareResultEnum COMPARING = new LineCompareResultEnum("COMPARING");

            /// <summary>
            /// Enum WAITING_FOR_COMPARISON for value: WAITING_FOR_COMPARISON
            /// </summary>
            public static readonly LineCompareResultEnum WAITING_FOR_COMPARISON = new LineCompareResultEnum("WAITING_FOR_COMPARISON");

            /// <summary>
            /// Enum FAILED_TO_COMPARE for value: FAILED_TO_COMPARE
            /// </summary>
            public static readonly LineCompareResultEnum FAILED_TO_COMPARE = new LineCompareResultEnum("FAILED_TO_COMPARE");

            /// <summary>
            /// Enum TARGET_DB_NOT_EXIT for value: TARGET_DB_NOT_EXIT
            /// </summary>
            public static readonly LineCompareResultEnum TARGET_DB_NOT_EXIT = new LineCompareResultEnum("TARGET_DB_NOT_EXIT");

            /// <summary>
            /// Enum CAN_NOT_COMPARE for value: CAN_NOT_COMPARE
            /// </summary>
            public static readonly LineCompareResultEnum CAN_NOT_COMPARE = new LineCompareResultEnum("CAN_NOT_COMPARE");

            private static readonly Dictionary<string, LineCompareResultEnum> StaticFields =
            new Dictionary<string, LineCompareResultEnum>()
            {
                { "CONSISTENT", CONSISTENT },
                { "INCONSISTENT", INCONSISTENT },
                { "COMPARING", COMPARING },
                { "WAITING_FOR_COMPARISON", WAITING_FOR_COMPARISON },
                { "FAILED_TO_COMPARE", FAILED_TO_COMPARE },
                { "TARGET_DB_NOT_EXIT", TARGET_DB_NOT_EXIT },
                { "CAN_NOT_COMPARE", CAN_NOT_COMPARE },
            };

            private string _value;

            public LineCompareResultEnum()
            {

            }

            public LineCompareResultEnum(string value)
            {
                _value = value;
            }

            public static LineCompareResultEnum FromValue(string value)
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

                if (this.Equals(obj as LineCompareResultEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LineCompareResultEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LineCompareResultEnum a, LineCompareResultEnum b)
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

            public static bool operator !=(LineCompareResultEnum a, LineCompareResultEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 源库名称。
        /// </summary>
        [JsonProperty("source_db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDbName { get; set; }

        /// <summary>
        /// 目标库名称。
        /// </summary>
        [JsonProperty("target_db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDbName { get; set; }

        /// <summary>
        /// 对比结果。 - CONSISTENT-一致 - INCONSISTENT-不一致 - COMPARING-正在对比 - WAITING_FOR_COMPARISON-等待对比 - FAILED_TO_COMPARE-对比失败 - TARGET_DB_NOT_EXIT-目标库不存在 - CAN_NOT_COMPARE-无法对比
        /// </summary>
        [JsonProperty("line_compare_result", NullValueHandling = NullValueHandling.Ignore)]
        public LineCompareResultEnum LineCompareResult { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineCompareResultOverview {\n");
            sb.Append("  sourceDbName: ").Append(SourceDbName).Append("\n");
            sb.Append("  targetDbName: ").Append(TargetDbName).Append("\n");
            sb.Append("  lineCompareResult: ").Append(LineCompareResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LineCompareResultOverview);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LineCompareResultOverview input)
        {
            if (input == null) return false;
            if (this.SourceDbName != input.SourceDbName || (this.SourceDbName != null && !this.SourceDbName.Equals(input.SourceDbName))) return false;
            if (this.TargetDbName != input.TargetDbName || (this.TargetDbName != null && !this.TargetDbName.Equals(input.TargetDbName))) return false;
            if (this.LineCompareResult != input.LineCompareResult) return false;

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
                if (this.SourceDbName != null) hashCode = hashCode * 59 + this.SourceDbName.GetHashCode();
                if (this.TargetDbName != null) hashCode = hashCode * 59 + this.TargetDbName.GetHashCode();
                hashCode = hashCode * 59 + this.LineCompareResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
