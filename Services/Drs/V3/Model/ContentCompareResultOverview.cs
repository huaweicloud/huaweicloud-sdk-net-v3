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
    public class ContentCompareResultOverview 
    {
        /// <summary>
        /// 对比结果。 - CONSISTENT-一致 - INCONSISTENT-不一致 - COMPARING-正在对比 - WAITING_FOR_COMPARISON-等待对比 - FAILED_TO_COMPARE-对比失败 - TARGET_DB_NOT_EXIT-目标库不存在 - CAN_NOT_COMPARE-无法对比
        /// </summary>
        /// <value>对比结果。 - CONSISTENT-一致 - INCONSISTENT-不一致 - COMPARING-正在对比 - WAITING_FOR_COMPARISON-等待对比 - FAILED_TO_COMPARE-对比失败 - TARGET_DB_NOT_EXIT-目标库不存在 - CAN_NOT_COMPARE-无法对比</value>
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
        /// 对比结果。 - CONSISTENT-一致 - INCONSISTENT-不一致 - COMPARING-正在对比 - WAITING_FOR_COMPARISON-等待对比 - FAILED_TO_COMPARE-对比失败 - TARGET_DB_NOT_EXIT-目标库不存在 - CAN_NOT_COMPARE-无法对比
        /// </summary>
        [JsonProperty("content_compare_result", NullValueHandling = NullValueHandling.Ignore)]
        public ContentCompareResultEnum ContentCompareResult { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentCompareResultOverview {\n");
            sb.Append("  sourceDbName: ").Append(SourceDbName).Append("\n");
            sb.Append("  targetDbName: ").Append(TargetDbName).Append("\n");
            sb.Append("  contentCompareResult: ").Append(ContentCompareResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContentCompareResultOverview);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ContentCompareResultOverview input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceDbName == input.SourceDbName ||
                    (this.SourceDbName != null &&
                    this.SourceDbName.Equals(input.SourceDbName))
                ) && 
                (
                    this.TargetDbName == input.TargetDbName ||
                    (this.TargetDbName != null &&
                    this.TargetDbName.Equals(input.TargetDbName))
                ) && 
                (
                    this.ContentCompareResult == input.ContentCompareResult ||
                    (this.ContentCompareResult != null &&
                    this.ContentCompareResult.Equals(input.ContentCompareResult))
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
                if (this.SourceDbName != null)
                    hashCode = hashCode * 59 + this.SourceDbName.GetHashCode();
                if (this.TargetDbName != null)
                    hashCode = hashCode * 59 + this.TargetDbName.GetHashCode();
                if (this.ContentCompareResult != null)
                    hashCode = hashCode * 59 + this.ContentCompareResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
