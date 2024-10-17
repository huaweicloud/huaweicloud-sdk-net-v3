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
    /// 数据参数信息体
    /// </summary>
    public class ModelParams 
    {
        /// <summary>
        /// 参数对比结果
        /// </summary>
        /// <value>参数对比结果</value>
        [JsonConverter(typeof(EnumClassConverter<CompareResultEnum>))]
        public class CompareResultEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly CompareResultEnum TRUE = new CompareResultEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly CompareResultEnum FALSE = new CompareResultEnum("false");

            private static readonly Dictionary<string, CompareResultEnum> StaticFields =
            new Dictionary<string, CompareResultEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public CompareResultEnum()
            {

            }

            public CompareResultEnum(string value)
            {
                _value = value;
            }

            public static CompareResultEnum FromValue(string value)
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

                if (this.Equals(obj as CompareResultEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CompareResultEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CompareResultEnum a, CompareResultEnum b)
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

            public static bool operator !=(CompareResultEnum a, CompareResultEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 分组。 - common-常规参数 - performance-性能参数
        /// </summary>
        /// <value>分组。 - common-常规参数 - performance-性能参数</value>
        [JsonConverter(typeof(EnumClassConverter<GroupEnum>))]
        public class GroupEnum
        {
            /// <summary>
            /// Enum COMMON for value: common
            /// </summary>
            public static readonly GroupEnum COMMON = new GroupEnum("common");

            /// <summary>
            /// Enum PERFORMANCE for value: performance
            /// </summary>
            public static readonly GroupEnum PERFORMANCE = new GroupEnum("performance");

            private static readonly Dictionary<string, GroupEnum> StaticFields =
            new Dictionary<string, GroupEnum>()
            {
                { "common", COMMON },
                { "performance", PERFORMANCE },
            };

            private string _value;

            public GroupEnum()
            {

            }

            public GroupEnum(string value)
            {
                _value = value;
            }

            public static GroupEnum FromValue(string value)
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

                if (this.Equals(obj as GroupEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(GroupEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(GroupEnum a, GroupEnum b)
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

            public static bool operator !=(GroupEnum a, GroupEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否需要重启
        /// </summary>
        /// <value>是否需要重启</value>
        [JsonConverter(typeof(EnumClassConverter<NeedRestartEnum>))]
        public class NeedRestartEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly NeedRestartEnum TRUE = new NeedRestartEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly NeedRestartEnum FALSE = new NeedRestartEnum("false");

            private static readonly Dictionary<string, NeedRestartEnum> StaticFields =
            new Dictionary<string, NeedRestartEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public NeedRestartEnum()
            {

            }

            public NeedRestartEnum(string value)
            {
                _value = value;
            }

            public static NeedRestartEnum FromValue(string value)
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

                if (this.Equals(obj as NeedRestartEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NeedRestartEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NeedRestartEnum a, NeedRestartEnum b)
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

            public static bool operator !=(NeedRestartEnum a, NeedRestartEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 参数对比结果
        /// </summary>
        [JsonProperty("compare_result", NullValueHandling = NullValueHandling.Ignore)]
        public CompareResultEnum CompareResult { get; set; }
        /// <summary>
        /// 参数类型
        /// </summary>
        [JsonProperty("data_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DataType { get; set; }

        /// <summary>
        /// 分组。 - common-常规参数 - performance-性能参数
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public GroupEnum Group { get; set; }
        /// <summary>
        /// 参数名
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 是否需要重启
        /// </summary>
        [JsonProperty("need_restart", NullValueHandling = NullValueHandling.Ignore)]
        public NeedRestartEnum NeedRestart { get; set; }
        /// <summary>
        /// 源数据库参数值
        /// </summary>
        [JsonProperty("source_value", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceValue { get; set; }

        /// <summary>
        /// 目标数据库参数值
        /// </summary>
        [JsonProperty("target_value", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetValue { get; set; }

        /// <summary>
        /// 参数范围
        /// </summary>
        [JsonProperty("value_range", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueRange { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelParams {\n");
            sb.Append("  compareResult: ").Append(CompareResult).Append("\n");
            sb.Append("  dataType: ").Append(DataType).Append("\n");
            sb.Append("  group: ").Append(Group).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  needRestart: ").Append(NeedRestart).Append("\n");
            sb.Append("  sourceValue: ").Append(SourceValue).Append("\n");
            sb.Append("  targetValue: ").Append(TargetValue).Append("\n");
            sb.Append("  valueRange: ").Append(ValueRange).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModelParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModelParams input)
        {
            if (input == null) return false;
            if (this.CompareResult != input.CompareResult) return false;
            if (this.DataType != input.DataType || (this.DataType != null && !this.DataType.Equals(input.DataType))) return false;
            if (this.Group != input.Group) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.NeedRestart != input.NeedRestart) return false;
            if (this.SourceValue != input.SourceValue || (this.SourceValue != null && !this.SourceValue.Equals(input.SourceValue))) return false;
            if (this.TargetValue != input.TargetValue || (this.TargetValue != null && !this.TargetValue.Equals(input.TargetValue))) return false;
            if (this.ValueRange != input.ValueRange || (this.ValueRange != null && !this.ValueRange.Equals(input.ValueRange))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMessage != input.ErrorMessage || (this.ErrorMessage != null && !this.ErrorMessage.Equals(input.ErrorMessage))) return false;

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
                hashCode = hashCode * 59 + this.CompareResult.GetHashCode();
                if (this.DataType != null) hashCode = hashCode * 59 + this.DataType.GetHashCode();
                hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                hashCode = hashCode * 59 + this.NeedRestart.GetHashCode();
                if (this.SourceValue != null) hashCode = hashCode * 59 + this.SourceValue.GetHashCode();
                if (this.TargetValue != null) hashCode = hashCode * 59 + this.TargetValue.GetHashCode();
                if (this.ValueRange != null) hashCode = hashCode * 59 + this.ValueRange.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
