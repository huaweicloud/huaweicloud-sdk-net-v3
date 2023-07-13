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
    public class ObjectCompareResultOverview 
    {
        /// <summary>
        /// 对象类型。 - DB-数据库 - TABLE-表 - VIEW-视图 - EVENT-事件 - ROUTINE-存储过程和函数 - INDEX-索引,TRIGGER-触发器 - SYNONYM-同义词 - FUNCTION-函数 - PROCEDURE-存储过程 - TYPE-自定义类型 - RULE-规则 - DEFAULT_TYPE-缺省值 - PLAN_GUIDE-执行计划 - CONSTRAINT-约束 - FILE_GROUP-文件组 - PARTITION_FUNCTION-分区函数 - PARTITION_SCHEME-分区方案 - TABLE_COLLATION-表的排序规则
        /// </summary>
        /// <value>对象类型。 - DB-数据库 - TABLE-表 - VIEW-视图 - EVENT-事件 - ROUTINE-存储过程和函数 - INDEX-索引,TRIGGER-触发器 - SYNONYM-同义词 - FUNCTION-函数 - PROCEDURE-存储过程 - TYPE-自定义类型 - RULE-规则 - DEFAULT_TYPE-缺省值 - PLAN_GUIDE-执行计划 - CONSTRAINT-约束 - FILE_GROUP-文件组 - PARTITION_FUNCTION-分区函数 - PARTITION_SCHEME-分区方案 - TABLE_COLLATION-表的排序规则</value>
        [JsonConverter(typeof(EnumClassConverter<ObjectTypeEnum>))]
        public class ObjectTypeEnum
        {
            /// <summary>
            /// Enum DB for value: DB
            /// </summary>
            public static readonly ObjectTypeEnum DB = new ObjectTypeEnum("DB");

            /// <summary>
            /// Enum TABLE for value: TABLE
            /// </summary>
            public static readonly ObjectTypeEnum TABLE = new ObjectTypeEnum("TABLE");

            /// <summary>
            /// Enum VIEW for value: VIEW
            /// </summary>
            public static readonly ObjectTypeEnum VIEW = new ObjectTypeEnum("VIEW");

            /// <summary>
            /// Enum EVENT for value: EVENT
            /// </summary>
            public static readonly ObjectTypeEnum EVENT = new ObjectTypeEnum("EVENT");

            /// <summary>
            /// Enum ROUTINE for value: ROUTINE
            /// </summary>
            public static readonly ObjectTypeEnum ROUTINE = new ObjectTypeEnum("ROUTINE");

            /// <summary>
            /// Enum INDEX for value: INDEX
            /// </summary>
            public static readonly ObjectTypeEnum INDEX = new ObjectTypeEnum("INDEX");

            /// <summary>
            /// Enum TRIGGER for value: TRIGGER
            /// </summary>
            public static readonly ObjectTypeEnum TRIGGER = new ObjectTypeEnum("TRIGGER");

            /// <summary>
            /// Enum SYNONYM for value: SYNONYM
            /// </summary>
            public static readonly ObjectTypeEnum SYNONYM = new ObjectTypeEnum("SYNONYM");

            /// <summary>
            /// Enum FUNCTION for value: FUNCTION
            /// </summary>
            public static readonly ObjectTypeEnum FUNCTION = new ObjectTypeEnum("FUNCTION");

            /// <summary>
            /// Enum PROCEDURE for value: PROCEDURE
            /// </summary>
            public static readonly ObjectTypeEnum PROCEDURE = new ObjectTypeEnum("PROCEDURE");

            /// <summary>
            /// Enum TYPE for value: TYPE
            /// </summary>
            public static readonly ObjectTypeEnum TYPE = new ObjectTypeEnum("TYPE");

            /// <summary>
            /// Enum RULE for value: RULE
            /// </summary>
            public static readonly ObjectTypeEnum RULE = new ObjectTypeEnum("RULE");

            /// <summary>
            /// Enum DEFAULT_TYPE for value: DEFAULT_TYPE
            /// </summary>
            public static readonly ObjectTypeEnum DEFAULT_TYPE = new ObjectTypeEnum("DEFAULT_TYPE");

            /// <summary>
            /// Enum PLAN_GUIDE for value: PLAN_GUIDE
            /// </summary>
            public static readonly ObjectTypeEnum PLAN_GUIDE = new ObjectTypeEnum("PLAN_GUIDE");

            /// <summary>
            /// Enum CONSTRAINT for value: CONSTRAINT
            /// </summary>
            public static readonly ObjectTypeEnum CONSTRAINT = new ObjectTypeEnum("CONSTRAINT");

            /// <summary>
            /// Enum FILE_GROUP for value: FILE_GROUP
            /// </summary>
            public static readonly ObjectTypeEnum FILE_GROUP = new ObjectTypeEnum("FILE_GROUP");

            /// <summary>
            /// Enum PARTITION_FUNCTION for value: PARTITION_FUNCTION
            /// </summary>
            public static readonly ObjectTypeEnum PARTITION_FUNCTION = new ObjectTypeEnum("PARTITION_FUNCTION");

            /// <summary>
            /// Enum PARTITION_SCHEME for value: PARTITION_SCHEME
            /// </summary>
            public static readonly ObjectTypeEnum PARTITION_SCHEME = new ObjectTypeEnum("PARTITION_SCHEME");

            /// <summary>
            /// Enum TABLE_COLLATION for value: TABLE_COLLATION
            /// </summary>
            public static readonly ObjectTypeEnum TABLE_COLLATION = new ObjectTypeEnum("TABLE_COLLATION");

            private static readonly Dictionary<string, ObjectTypeEnum> StaticFields =
            new Dictionary<string, ObjectTypeEnum>()
            {
                { "DB", DB },
                { "TABLE", TABLE },
                { "VIEW", VIEW },
                { "EVENT", EVENT },
                { "ROUTINE", ROUTINE },
                { "INDEX", INDEX },
                { "TRIGGER", TRIGGER },
                { "SYNONYM", SYNONYM },
                { "FUNCTION", FUNCTION },
                { "PROCEDURE", PROCEDURE },
                { "TYPE", TYPE },
                { "RULE", RULE },
                { "DEFAULT_TYPE", DEFAULT_TYPE },
                { "PLAN_GUIDE", PLAN_GUIDE },
                { "CONSTRAINT", CONSTRAINT },
                { "FILE_GROUP", FILE_GROUP },
                { "PARTITION_FUNCTION", PARTITION_FUNCTION },
                { "PARTITION_SCHEME", PARTITION_SCHEME },
                { "TABLE_COLLATION", TABLE_COLLATION },
            };

            private string _value;

            public ObjectTypeEnum()
            {

            }

            public ObjectTypeEnum(string value)
            {
                _value = value;
            }

            public static ObjectTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ObjectTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ObjectTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ObjectTypeEnum a, ObjectTypeEnum b)
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

            public static bool operator !=(ObjectTypeEnum a, ObjectTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 对比结果。 - CONSISTENT-一致 - INCONSISTENT-不一致 - COMPARING-正在对比 - WAITING_FOR_COMPARISON-等待对比 - FAILED_TO_COMPARE-对比失败 - TARGET_DB_NOT_EXIT-目标库不存在 - CAN_NOT_COMPARE-无法对比
        /// </summary>
        /// <value>对比结果。 - CONSISTENT-一致 - INCONSISTENT-不一致 - COMPARING-正在对比 - WAITING_FOR_COMPARISON-等待对比 - FAILED_TO_COMPARE-对比失败 - TARGET_DB_NOT_EXIT-目标库不存在 - CAN_NOT_COMPARE-无法对比</value>
        [JsonConverter(typeof(EnumClassConverter<ObjectCompareResultEnum>))]
        public class ObjectCompareResultEnum
        {
            /// <summary>
            /// Enum CONSISTENT for value: CONSISTENT
            /// </summary>
            public static readonly ObjectCompareResultEnum CONSISTENT = new ObjectCompareResultEnum("CONSISTENT");

            /// <summary>
            /// Enum INCONSISTENT for value: INCONSISTENT
            /// </summary>
            public static readonly ObjectCompareResultEnum INCONSISTENT = new ObjectCompareResultEnum("INCONSISTENT");

            /// <summary>
            /// Enum COMPARING for value: COMPARING
            /// </summary>
            public static readonly ObjectCompareResultEnum COMPARING = new ObjectCompareResultEnum("COMPARING");

            /// <summary>
            /// Enum WAITING_FOR_COMPARISON for value: WAITING_FOR_COMPARISON
            /// </summary>
            public static readonly ObjectCompareResultEnum WAITING_FOR_COMPARISON = new ObjectCompareResultEnum("WAITING_FOR_COMPARISON");

            /// <summary>
            /// Enum FAILED_TO_COMPARE for value: FAILED_TO_COMPARE
            /// </summary>
            public static readonly ObjectCompareResultEnum FAILED_TO_COMPARE = new ObjectCompareResultEnum("FAILED_TO_COMPARE");

            /// <summary>
            /// Enum TARGET_DB_NOT_EXIT for value: TARGET_DB_NOT_EXIT
            /// </summary>
            public static readonly ObjectCompareResultEnum TARGET_DB_NOT_EXIT = new ObjectCompareResultEnum("TARGET_DB_NOT_EXIT");

            /// <summary>
            /// Enum CAN_NOT_COMPARE for value: CAN_NOT_COMPARE
            /// </summary>
            public static readonly ObjectCompareResultEnum CAN_NOT_COMPARE = new ObjectCompareResultEnum("CAN_NOT_COMPARE");

            private static readonly Dictionary<string, ObjectCompareResultEnum> StaticFields =
            new Dictionary<string, ObjectCompareResultEnum>()
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

            public ObjectCompareResultEnum()
            {

            }

            public ObjectCompareResultEnum(string value)
            {
                _value = value;
            }

            public static ObjectCompareResultEnum FromValue(string value)
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

                if (this.Equals(obj as ObjectCompareResultEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ObjectCompareResultEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ObjectCompareResultEnum a, ObjectCompareResultEnum b)
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

            public static bool operator !=(ObjectCompareResultEnum a, ObjectCompareResultEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 对象类型。 - DB-数据库 - TABLE-表 - VIEW-视图 - EVENT-事件 - ROUTINE-存储过程和函数 - INDEX-索引,TRIGGER-触发器 - SYNONYM-同义词 - FUNCTION-函数 - PROCEDURE-存储过程 - TYPE-自定义类型 - RULE-规则 - DEFAULT_TYPE-缺省值 - PLAN_GUIDE-执行计划 - CONSTRAINT-约束 - FILE_GROUP-文件组 - PARTITION_FUNCTION-分区函数 - PARTITION_SCHEME-分区方案 - TABLE_COLLATION-表的排序规则
        /// </summary>
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectTypeEnum ObjectType { get; set; }
        /// <summary>
        /// 对比结果。 - CONSISTENT-一致 - INCONSISTENT-不一致 - COMPARING-正在对比 - WAITING_FOR_COMPARISON-等待对比 - FAILED_TO_COMPARE-对比失败 - TARGET_DB_NOT_EXIT-目标库不存在 - CAN_NOT_COMPARE-无法对比
        /// </summary>
        [JsonProperty("object_compare_result", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectCompareResultEnum ObjectCompareResult { get; set; }
        /// <summary>
        /// 该类型的对象在目标库的个数。
        /// </summary>
        [JsonProperty("target_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetCount { get; set; }

        /// <summary>
        /// 该类型的对象在源库的个数。
        /// </summary>
        [JsonProperty("source_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceCount { get; set; }

        /// <summary>
        /// 源库和目标库的差异数量。
        /// </summary>
        [JsonProperty("diff_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiffCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectCompareResultOverview {\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
            sb.Append("  objectCompareResult: ").Append(ObjectCompareResult).Append("\n");
            sb.Append("  targetCount: ").Append(TargetCount).Append("\n");
            sb.Append("  sourceCount: ").Append(SourceCount).Append("\n");
            sb.Append("  diffCount: ").Append(DiffCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObjectCompareResultOverview);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObjectCompareResultOverview input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectType == input.ObjectType ||
                    (this.ObjectType != null &&
                    this.ObjectType.Equals(input.ObjectType))
                ) && 
                (
                    this.ObjectCompareResult == input.ObjectCompareResult ||
                    (this.ObjectCompareResult != null &&
                    this.ObjectCompareResult.Equals(input.ObjectCompareResult))
                ) && 
                (
                    this.TargetCount == input.TargetCount ||
                    (this.TargetCount != null &&
                    this.TargetCount.Equals(input.TargetCount))
                ) && 
                (
                    this.SourceCount == input.SourceCount ||
                    (this.SourceCount != null &&
                    this.SourceCount.Equals(input.SourceCount))
                ) && 
                (
                    this.DiffCount == input.DiffCount ||
                    (this.DiffCount != null &&
                    this.DiffCount.Equals(input.DiffCount))
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
                if (this.ObjectType != null)
                    hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.ObjectCompareResult != null)
                    hashCode = hashCode * 59 + this.ObjectCompareResult.GetHashCode();
                if (this.TargetCount != null)
                    hashCode = hashCode * 59 + this.TargetCount.GetHashCode();
                if (this.SourceCount != null)
                    hashCode = hashCode * 59 + this.SourceCount.GetHashCode();
                if (this.DiffCount != null)
                    hashCode = hashCode * 59 + this.DiffCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
