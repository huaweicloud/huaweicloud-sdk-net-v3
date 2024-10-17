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
    /// 内容对比结果详情。
    /// </summary>
    public class ContentCompareDetail 
    {
        /// <summary>
        /// 行对比结果。 - CONSISTENT-一致 - INCONSISTENT-不一致 - COMPARING-正在对比 - WAITING_FOR_COMPARISON-等待对比 - FAILED_TO_COMPARE-对比失败 - TARGET_DB_NOT_EXIT-目标库不存在 - CAN_NOT_COMPARE-无法对比
        /// </summary>
        /// <value>行对比结果。 - CONSISTENT-一致 - INCONSISTENT-不一致 - COMPARING-正在对比 - WAITING_FOR_COMPARISON-等待对比 - FAILED_TO_COMPARE-对比失败 - TARGET_DB_NOT_EXIT-目标库不存在 - CAN_NOT_COMPARE-无法对比</value>
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
        /// 内容对比结果。 - CONSISTENT-一致 - INCONSISTENT-不一致 - COMPARING-正在对比 - WAITING_FOR_COMPARISON-等待对比 - FAILED_TO_COMPARE-对比失败 - TARGET_DB_NOT_EXIT-目标库不存在 - CAN_NOT_COMPARE-无法对比
        /// </summary>
        /// <value>内容对比结果。 - CONSISTENT-一致 - INCONSISTENT-不一致 - COMPARING-正在对比 - WAITING_FOR_COMPARISON-等待对比 - FAILED_TO_COMPARE-对比失败 - TARGET_DB_NOT_EXIT-目标库不存在 - CAN_NOT_COMPARE-无法对比</value>
        [JsonConverter(typeof(EnumClassConverter<ContentCompareResultEnum>))]
        public class ContentCompareResultEnum
        {
            /// <summary>
            /// Enum CONSISTENT for value: CONSISTENT
            /// </summary>
            public static readonly ContentCompareResultEnum CONSISTENT = new ContentCompareResultEnum("CONSISTENT");

            /// <summary>
            /// Enum INCONSISTENT for value: INCONSISTENT
            /// </summary>
            public static readonly ContentCompareResultEnum INCONSISTENT = new ContentCompareResultEnum("INCONSISTENT");

            /// <summary>
            /// Enum COMPARING for value: COMPARING
            /// </summary>
            public static readonly ContentCompareResultEnum COMPARING = new ContentCompareResultEnum("COMPARING");

            /// <summary>
            /// Enum WAITING_FOR_COMPARISON for value: WAITING_FOR_COMPARISON
            /// </summary>
            public static readonly ContentCompareResultEnum WAITING_FOR_COMPARISON = new ContentCompareResultEnum("WAITING_FOR_COMPARISON");

            /// <summary>
            /// Enum FAILED_TO_COMPARE for value: FAILED_TO_COMPARE
            /// </summary>
            public static readonly ContentCompareResultEnum FAILED_TO_COMPARE = new ContentCompareResultEnum("FAILED_TO_COMPARE");

            /// <summary>
            /// Enum TARGET_DB_NOT_EXIT for value: TARGET_DB_NOT_EXIT
            /// </summary>
            public static readonly ContentCompareResultEnum TARGET_DB_NOT_EXIT = new ContentCompareResultEnum("TARGET_DB_NOT_EXIT");

            /// <summary>
            /// Enum CAN_NOT_COMPARE for value: CAN_NOT_COMPARE
            /// </summary>
            public static readonly ContentCompareResultEnum CAN_NOT_COMPARE = new ContentCompareResultEnum("CAN_NOT_COMPARE");

            private static readonly Dictionary<string, ContentCompareResultEnum> StaticFields =
            new Dictionary<string, ContentCompareResultEnum>()
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

            public ContentCompareResultEnum()
            {

            }

            public ContentCompareResultEnum(string value)
            {
                _value = value;
            }

            public static ContentCompareResultEnum FromValue(string value)
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

                if (this.Equals(obj as ContentCompareResultEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ContentCompareResultEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ContentCompareResultEnum a, ContentCompareResultEnum b)
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

            public static bool operator !=(ContentCompareResultEnum a, ContentCompareResultEnum b)
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
        /// 源库的表名称。
        /// </summary>
        [JsonProperty("source_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceTableName { get; set; }

        /// <summary>
        /// 目标库的表名称。
        /// </summary>
        [JsonProperty("target_table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetTableName { get; set; }

        /// <summary>
        /// 源库的表的行数。
        /// </summary>
        [JsonProperty("source_row_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceRowNum { get; set; }

        /// <summary>
        /// 目标库的表的行数。
        /// </summary>
        [JsonProperty("target_row_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetRowNum { get; set; }

        /// <summary>
        /// 源库的表和目标库的表的差异值。
        /// </summary>
        [JsonProperty("diff_row_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiffRowNum { get; set; }

        /// <summary>
        /// 行对比结果。 - CONSISTENT-一致 - INCONSISTENT-不一致 - COMPARING-正在对比 - WAITING_FOR_COMPARISON-等待对比 - FAILED_TO_COMPARE-对比失败 - TARGET_DB_NOT_EXIT-目标库不存在 - CAN_NOT_COMPARE-无法对比
        /// </summary>
        [JsonProperty("line_compare_result", NullValueHandling = NullValueHandling.Ignore)]
        public LineCompareResultEnum LineCompareResult { get; set; }
        /// <summary>
        /// 内容对比结果。 - CONSISTENT-一致 - INCONSISTENT-不一致 - COMPARING-正在对比 - WAITING_FOR_COMPARISON-等待对比 - FAILED_TO_COMPARE-对比失败 - TARGET_DB_NOT_EXIT-目标库不存在 - CAN_NOT_COMPARE-无法对比
        /// </summary>
        [JsonProperty("content_compare_result", NullValueHandling = NullValueHandling.Ignore)]
        public ContentCompareResultEnum ContentCompareResult { get; set; }
        /// <summary>
        /// 附加信息。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentCompareDetail {\n");
            sb.Append("  sourceDbName: ").Append(SourceDbName).Append("\n");
            sb.Append("  targetDbName: ").Append(TargetDbName).Append("\n");
            sb.Append("  sourceTableName: ").Append(SourceTableName).Append("\n");
            sb.Append("  targetTableName: ").Append(TargetTableName).Append("\n");
            sb.Append("  sourceRowNum: ").Append(SourceRowNum).Append("\n");
            sb.Append("  targetRowNum: ").Append(TargetRowNum).Append("\n");
            sb.Append("  diffRowNum: ").Append(DiffRowNum).Append("\n");
            sb.Append("  lineCompareResult: ").Append(LineCompareResult).Append("\n");
            sb.Append("  contentCompareResult: ").Append(ContentCompareResult).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContentCompareDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ContentCompareDetail input)
        {
            if (input == null) return false;
            if (this.SourceDbName != input.SourceDbName || (this.SourceDbName != null && !this.SourceDbName.Equals(input.SourceDbName))) return false;
            if (this.TargetDbName != input.TargetDbName || (this.TargetDbName != null && !this.TargetDbName.Equals(input.TargetDbName))) return false;
            if (this.SourceTableName != input.SourceTableName || (this.SourceTableName != null && !this.SourceTableName.Equals(input.SourceTableName))) return false;
            if (this.TargetTableName != input.TargetTableName || (this.TargetTableName != null && !this.TargetTableName.Equals(input.TargetTableName))) return false;
            if (this.SourceRowNum != input.SourceRowNum || (this.SourceRowNum != null && !this.SourceRowNum.Equals(input.SourceRowNum))) return false;
            if (this.TargetRowNum != input.TargetRowNum || (this.TargetRowNum != null && !this.TargetRowNum.Equals(input.TargetRowNum))) return false;
            if (this.DiffRowNum != input.DiffRowNum || (this.DiffRowNum != null && !this.DiffRowNum.Equals(input.DiffRowNum))) return false;
            if (this.LineCompareResult != input.LineCompareResult) return false;
            if (this.ContentCompareResult != input.ContentCompareResult) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;

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
                if (this.SourceTableName != null) hashCode = hashCode * 59 + this.SourceTableName.GetHashCode();
                if (this.TargetTableName != null) hashCode = hashCode * 59 + this.TargetTableName.GetHashCode();
                if (this.SourceRowNum != null) hashCode = hashCode * 59 + this.SourceRowNum.GetHashCode();
                if (this.TargetRowNum != null) hashCode = hashCode * 59 + this.TargetRowNum.GetHashCode();
                if (this.DiffRowNum != null) hashCode = hashCode * 59 + this.DiffRowNum.GetHashCode();
                hashCode = hashCode * 59 + this.LineCompareResult.GetHashCode();
                hashCode = hashCode * 59 + this.ContentCompareResult.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
