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
    /// 内容对比概览信息体。
    /// </summary>
    public class ContentCompareOverviewInfo 
    {
        /// <summary>
        /// 对比结果。取值： - CONSISTENT：一致。 - INCONSISTENT：不一致。 - COMPARING：正在对比。 - WAITING_FOR_COMPARISON：等待对比。 - FAILED_TO_COMPARE：对比失败。 - TARGET_DB_NOT_EXIST：目标库不存在。 - CAN_NOT_COMPARE：无法对比。 - WAIT_FOR_COMPARE：命令已下发，等待对比结果 - CANCELED：已取消
        /// </summary>
        /// <value>对比结果。取值： - CONSISTENT：一致。 - INCONSISTENT：不一致。 - COMPARING：正在对比。 - WAITING_FOR_COMPARISON：等待对比。 - FAILED_TO_COMPARE：对比失败。 - TARGET_DB_NOT_EXIST：目标库不存在。 - CAN_NOT_COMPARE：无法对比。 - WAIT_FOR_COMPARE：命令已下发，等待对比结果 - CANCELED：已取消</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum CONSISTENT for value: CONSISTENT
            /// </summary>
            public static readonly StatusEnum CONSISTENT = new StatusEnum("CONSISTENT");

            /// <summary>
            /// Enum INCONSISTENT for value: INCONSISTENT
            /// </summary>
            public static readonly StatusEnum INCONSISTENT = new StatusEnum("INCONSISTENT");

            /// <summary>
            /// Enum COMPARING for value: COMPARING
            /// </summary>
            public static readonly StatusEnum COMPARING = new StatusEnum("COMPARING");

            /// <summary>
            /// Enum WAITING_FOR_COMPARISON for value: WAITING_FOR_COMPARISON
            /// </summary>
            public static readonly StatusEnum WAITING_FOR_COMPARISON = new StatusEnum("WAITING_FOR_COMPARISON");

            /// <summary>
            /// Enum FAILED_TO_COMPARE for value: FAILED_TO_COMPARE
            /// </summary>
            public static readonly StatusEnum FAILED_TO_COMPARE = new StatusEnum("FAILED_TO_COMPARE");

            /// <summary>
            /// Enum TARGET_DB_NOT_EXIST for value: TARGET_DB_NOT_EXIST
            /// </summary>
            public static readonly StatusEnum TARGET_DB_NOT_EXIST = new StatusEnum("TARGET_DB_NOT_EXIST");

            /// <summary>
            /// Enum CAN_NOT_COMPARE for value: CAN_NOT_COMPARE
            /// </summary>
            public static readonly StatusEnum CAN_NOT_COMPARE = new StatusEnum("CAN_NOT_COMPARE");

            /// <summary>
            /// Enum WAIT_FOR_COMPARE for value: WAIT_FOR_COMPARE
            /// </summary>
            public static readonly StatusEnum WAIT_FOR_COMPARE = new StatusEnum("WAIT_FOR_COMPARE");

            /// <summary>
            /// Enum CANCELED for value: CANCELED
            /// </summary>
            public static readonly StatusEnum CANCELED = new StatusEnum("CANCELED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "CONSISTENT", CONSISTENT },
                { "INCONSISTENT", INCONSISTENT },
                { "COMPARING", COMPARING },
                { "WAITING_FOR_COMPARISON", WAITING_FOR_COMPARISON },
                { "FAILED_TO_COMPARE", FAILED_TO_COMPARE },
                { "TARGET_DB_NOT_EXIST", TARGET_DB_NOT_EXIST },
                { "CAN_NOT_COMPARE", CAN_NOT_COMPARE },
                { "WAIT_FOR_COMPARE", WAIT_FOR_COMPARE },
                { "CANCELED", CANCELED },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 源库库名。
        /// </summary>
        [JsonProperty("source_db", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceDb { get; set; }

        /// <summary>
        /// 目标库库名。
        /// </summary>
        [JsonProperty("target_db", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetDb { get; set; }

        /// <summary>
        /// 对比结果。取值： - CONSISTENT：一致。 - INCONSISTENT：不一致。 - COMPARING：正在对比。 - WAITING_FOR_COMPARISON：等待对比。 - FAILED_TO_COMPARE：对比失败。 - TARGET_DB_NOT_EXIST：目标库不存在。 - CAN_NOT_COMPARE：无法对比。 - WAIT_FOR_COMPARE：命令已下发，等待对比结果 - CANCELED：已取消
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 对比结果。
        /// </summary>
        [JsonProperty("compare_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CompareResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentCompareOverviewInfo {\n");
            sb.Append("  sourceDb: ").Append(SourceDb).Append("\n");
            sb.Append("  targetDb: ").Append(TargetDb).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  compareResult: ").Append(CompareResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContentCompareOverviewInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ContentCompareOverviewInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceDb == input.SourceDb ||
                    (this.SourceDb != null &&
                    this.SourceDb.Equals(input.SourceDb))
                ) && 
                (
                    this.TargetDb == input.TargetDb ||
                    (this.TargetDb != null &&
                    this.TargetDb.Equals(input.TargetDb))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CompareResult == input.CompareResult ||
                    (this.CompareResult != null &&
                    this.CompareResult.Equals(input.CompareResult))
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
                if (this.SourceDb != null)
                    hashCode = hashCode * 59 + this.SourceDb.GetHashCode();
                if (this.TargetDb != null)
                    hashCode = hashCode * 59 + this.TargetDb.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CompareResult != null)
                    hashCode = hashCode * 59 + this.CompareResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
