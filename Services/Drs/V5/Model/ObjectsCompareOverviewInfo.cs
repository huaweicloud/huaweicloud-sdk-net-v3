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
    /// 对象对比结果信息体。
    /// </summary>
    public class ObjectsCompareOverviewInfo 
    {
        /// <summary>
        /// 对象类型。取值： - DB：数据库。 - TABLE：表。 - VIEW：视图。 - EVENT：事件。 - ROUTINE：存储过程和函数。 - INDEX：索引。 - TRIGGER：触发器。 - SYNONYM：同义词。 - FUNCTION：函数。 - PROCEDURE：存储过程。 - TYPE：自定义类型。 - RULE：规则。 - DEFAULT_TYPE：缺省值。 - PLAN_GUIDE：执行计划。 - CONSTRAINT：约束。 - FILE_GROUP：文件组。 - PARTITION_FUNCTION：分区函数。 - PARTITION_SCHEME：分区方案。 - TABLE_COLLATION：表的排序规则。 - EXTENSIONS：插件。
        /// </summary>
        /// <value>对象类型。取值： - DB：数据库。 - TABLE：表。 - VIEW：视图。 - EVENT：事件。 - ROUTINE：存储过程和函数。 - INDEX：索引。 - TRIGGER：触发器。 - SYNONYM：同义词。 - FUNCTION：函数。 - PROCEDURE：存储过程。 - TYPE：自定义类型。 - RULE：规则。 - DEFAULT_TYPE：缺省值。 - PLAN_GUIDE：执行计划。 - CONSTRAINT：约束。 - FILE_GROUP：文件组。 - PARTITION_FUNCTION：分区函数。 - PARTITION_SCHEME：分区方案。 - TABLE_COLLATION：表的排序规则。 - EXTENSIONS：插件。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum DB for value: DB
            /// </summary>
            public static readonly TypeEnum DB = new TypeEnum("DB");

            /// <summary>
            /// Enum TABLE for value: TABLE
            /// </summary>
            public static readonly TypeEnum TABLE = new TypeEnum("TABLE");

            /// <summary>
            /// Enum VIEW for value: VIEW
            /// </summary>
            public static readonly TypeEnum VIEW = new TypeEnum("VIEW");

            /// <summary>
            /// Enum EVENT for value: EVENT
            /// </summary>
            public static readonly TypeEnum EVENT = new TypeEnum("EVENT");

            /// <summary>
            /// Enum ROUTINE for value: ROUTINE
            /// </summary>
            public static readonly TypeEnum ROUTINE = new TypeEnum("ROUTINE");

            /// <summary>
            /// Enum INDEX for value: INDEX
            /// </summary>
            public static readonly TypeEnum INDEX = new TypeEnum("INDEX");

            /// <summary>
            /// Enum TRIGGER for value: TRIGGER
            /// </summary>
            public static readonly TypeEnum TRIGGER = new TypeEnum("TRIGGER");

            /// <summary>
            /// Enum SYNONYM for value: SYNONYM
            /// </summary>
            public static readonly TypeEnum SYNONYM = new TypeEnum("SYNONYM");

            /// <summary>
            /// Enum FUNCTION for value: FUNCTION
            /// </summary>
            public static readonly TypeEnum FUNCTION = new TypeEnum("FUNCTION");

            /// <summary>
            /// Enum PROCEDURE for value: PROCEDURE
            /// </summary>
            public static readonly TypeEnum PROCEDURE = new TypeEnum("PROCEDURE");

            /// <summary>
            /// Enum TYPE for value: TYPE
            /// </summary>
            public static readonly TypeEnum TYPE = new TypeEnum("TYPE");

            /// <summary>
            /// Enum RULE for value: RULE
            /// </summary>
            public static readonly TypeEnum RULE = new TypeEnum("RULE");

            /// <summary>
            /// Enum DEFAULT_TYPE for value: DEFAULT_TYPE
            /// </summary>
            public static readonly TypeEnum DEFAULT_TYPE = new TypeEnum("DEFAULT_TYPE");

            /// <summary>
            /// Enum PLAN_GUIDE for value: PLAN_GUIDE
            /// </summary>
            public static readonly TypeEnum PLAN_GUIDE = new TypeEnum("PLAN_GUIDE");

            /// <summary>
            /// Enum CONSTRAINT for value: CONSTRAINT
            /// </summary>
            public static readonly TypeEnum CONSTRAINT = new TypeEnum("CONSTRAINT");

            /// <summary>
            /// Enum FILE_GROUP for value: FILE_GROUP
            /// </summary>
            public static readonly TypeEnum FILE_GROUP = new TypeEnum("FILE_GROUP");

            /// <summary>
            /// Enum PARTITION_FUNCTION for value: PARTITION_FUNCTION
            /// </summary>
            public static readonly TypeEnum PARTITION_FUNCTION = new TypeEnum("PARTITION_FUNCTION");

            /// <summary>
            /// Enum PARTITION_SCHEME for value: PARTITION_SCHEME
            /// </summary>
            public static readonly TypeEnum PARTITION_SCHEME = new TypeEnum("PARTITION_SCHEME");

            /// <summary>
            /// Enum TABLE_COLLATION for value: TABLE_COLLATION
            /// </summary>
            public static readonly TypeEnum TABLE_COLLATION = new TypeEnum("TABLE_COLLATION");

            /// <summary>
            /// Enum EXTENSIONS for value: EXTENSIONS
            /// </summary>
            public static readonly TypeEnum EXTENSIONS = new TypeEnum("EXTENSIONS");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
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
                { "EXTENSIONS", EXTENSIONS },
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
        /// 对比结果。取值： CONSISTENT：一致。 INCONSISTENT：不一致。 COMPARING：正在对比。 WAITING_FOR_COMPARISON：等待对比。 FAILED_TO_COMPARE：对比失败。 TARGET_DB_NOT_EXIST：目标库不存在。 CAN_NOT_COMPARE：无法对比。
        /// </summary>
        /// <value>对比结果。取值： CONSISTENT：一致。 INCONSISTENT：不一致。 COMPARING：正在对比。 WAITING_FOR_COMPARISON：等待对比。 FAILED_TO_COMPARE：对比失败。 TARGET_DB_NOT_EXIST：目标库不存在。 CAN_NOT_COMPARE：无法对比。</value>
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
        /// 对象类型。取值： - DB：数据库。 - TABLE：表。 - VIEW：视图。 - EVENT：事件。 - ROUTINE：存储过程和函数。 - INDEX：索引。 - TRIGGER：触发器。 - SYNONYM：同义词。 - FUNCTION：函数。 - PROCEDURE：存储过程。 - TYPE：自定义类型。 - RULE：规则。 - DEFAULT_TYPE：缺省值。 - PLAN_GUIDE：执行计划。 - CONSTRAINT：约束。 - FILE_GROUP：文件组。 - PARTITION_FUNCTION：分区函数。 - PARTITION_SCHEME：分区方案。 - TABLE_COLLATION：表的排序规则。 - EXTENSIONS：插件。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 源数量。
        /// </summary>
        [JsonProperty("source_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? SourceCount { get; set; }

        /// <summary>
        /// 目标数量。
        /// </summary>
        [JsonProperty("target_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? TargetCount { get; set; }

        /// <summary>
        /// 对比结果。取值： CONSISTENT：一致。 INCONSISTENT：不一致。 COMPARING：正在对比。 WAITING_FOR_COMPARISON：等待对比。 FAILED_TO_COMPARE：对比失败。 TARGET_DB_NOT_EXIST：目标库不存在。 CAN_NOT_COMPARE：无法对比。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectsCompareOverviewInfo {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  sourceCount: ").Append(SourceCount).Append("\n");
            sb.Append("  targetCount: ").Append(TargetCount).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObjectsCompareOverviewInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObjectsCompareOverviewInfo input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.SourceCount != input.SourceCount || (this.SourceCount != null && !this.SourceCount.Equals(input.SourceCount))) return false;
            if (this.TargetCount != input.TargetCount || (this.TargetCount != null && !this.TargetCount.Equals(input.TargetCount))) return false;
            if (this.Status != input.Status) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SourceCount != null) hashCode = hashCode * 59 + this.SourceCount.GetHashCode();
                if (this.TargetCount != null) hashCode = hashCode * 59 + this.TargetCount.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
