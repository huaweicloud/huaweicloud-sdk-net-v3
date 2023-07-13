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
    public class CreateDataLevelCompareReq 
    {
        /// <summary>
        /// 一个任务只允许有一个未完成的数据级对比任务，该字段决定对未完成数据级对比任务的处理方式。cancel-取消后重新创建,keep-保持未完成的不再创建。
        /// </summary>
        /// <value>一个任务只允许有一个未完成的数据级对比任务，该字段决定对未完成数据级对比任务的处理方式。cancel-取消后重新创建,keep-保持未完成的不再创建。</value>
        [JsonConverter(typeof(EnumClassConverter<ConflictPolicyEnum>))]
        public class ConflictPolicyEnum
        {
            /// <summary>
            /// Enum CANCEL for value: cancel
            /// </summary>
            public static readonly ConflictPolicyEnum CANCEL = new ConflictPolicyEnum("cancel");

            /// <summary>
            /// Enum KEEP for value: keep
            /// </summary>
            public static readonly ConflictPolicyEnum KEEP = new ConflictPolicyEnum("keep");

            private static readonly Dictionary<string, ConflictPolicyEnum> StaticFields =
            new Dictionary<string, ConflictPolicyEnum>()
            {
                { "cancel", CANCEL },
                { "keep", KEEP },
            };

            private string _value;

            public ConflictPolicyEnum()
            {

            }

            public ConflictPolicyEnum(string value)
            {
                _value = value;
            }

            public static ConflictPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as ConflictPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConflictPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConflictPolicyEnum a, ConflictPolicyEnum b)
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

            public static bool operator !=(ConflictPolicyEnum a, ConflictPolicyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 数据级对比类型，lines-行对比,contents-内容对比。
        /// </summary>
        /// <value>数据级对比类型，lines-行对比,contents-内容对比。</value>
        [JsonConverter(typeof(EnumClassConverter<CompareTypeEnum>))]
        public class CompareTypeEnum
        {
            /// <summary>
            /// Enum LINES for value: lines
            /// </summary>
            public static readonly CompareTypeEnum LINES = new CompareTypeEnum("lines");

            /// <summary>
            /// Enum CONTENTS for value: contents
            /// </summary>
            public static readonly CompareTypeEnum CONTENTS = new CompareTypeEnum("contents");

            private static readonly Dictionary<string, CompareTypeEnum> StaticFields =
            new Dictionary<string, CompareTypeEnum>()
            {
                { "lines", LINES },
                { "contents", CONTENTS },
            };

            private string _value;

            public CompareTypeEnum()
            {

            }

            public CompareTypeEnum(string value)
            {
                _value = value;
            }

            public static CompareTypeEnum FromValue(string value)
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

                if (this.Equals(obj as CompareTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CompareTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CompareTypeEnum a, CompareTypeEnum b)
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

            public static bool operator !=(CompareTypeEnum a, CompareTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 数据级对比模式，取值为空时需要在compare_object_infos或者compare_object_infos_with_token传对象信息，quick_comparison-快速对比，需要加入该功能的白名单才能使用。
        /// </summary>
        /// <value>数据级对比模式，取值为空时需要在compare_object_infos或者compare_object_infos_with_token传对象信息，quick_comparison-快速对比，需要加入该功能的白名单才能使用。</value>
        [JsonConverter(typeof(EnumClassConverter<CompareModeEnum>))]
        public class CompareModeEnum
        {
            /// <summary>
            /// Enum QUICK_COMPARISON for value: quick_comparison
            /// </summary>
            public static readonly CompareModeEnum QUICK_COMPARISON = new CompareModeEnum("quick_comparison");

            private static readonly Dictionary<string, CompareModeEnum> StaticFields =
            new Dictionary<string, CompareModeEnum>()
            {
                { "quick_comparison", QUICK_COMPARISON },
            };

            private string _value;

            public CompareModeEnum()
            {

            }

            public CompareModeEnum(string value)
            {
                _value = value;
            }

            public static CompareModeEnum FromValue(string value)
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

                if (this.Equals(obj as CompareModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CompareModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CompareModeEnum a, CompareModeEnum b)
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

            public static bool operator !=(CompareModeEnum a, CompareModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 一个任务只允许有一个未完成的数据级对比任务，该字段决定对未完成数据级对比任务的处理方式。cancel-取消后重新创建,keep-保持未完成的不再创建。
        /// </summary>
        [JsonProperty("conflict_policy", NullValueHandling = NullValueHandling.Ignore)]
        public ConflictPolicyEnum ConflictPolicy { get; set; }
        /// <summary>
        /// 数据级对比类型，lines-行对比,contents-内容对比。
        /// </summary>
        [JsonProperty("compare_type", NullValueHandling = NullValueHandling.Ignore)]
        public CompareTypeEnum CompareType { get; set; }
        /// <summary>
        /// 数据级对比模式，取值为空时需要在compare_object_infos或者compare_object_infos_with_token传对象信息，quick_comparison-快速对比，需要加入该功能的白名单才能使用。
        /// </summary>
        [JsonProperty("compare_mode", NullValueHandling = NullValueHandling.Ignore)]
        public CompareModeEnum CompareMode { get; set; }
        /// <summary>
        /// 对比任务启动时间，取值为空代表立即启动。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 数据级对比的对象。非“快速对比”模式时，compare_object_infos和compare_object_infos_with_token根据链路二选一传值，不允许都为空。
        /// </summary>
        [JsonProperty("compare_object_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<CompareObjectInfo> CompareObjectInfos { get; set; }

        /// <summary>
        /// 数据级对比的对象（Cassandra灾备专用，带token信息）。非“快速对比”模式时，compare_object_infos和compare_object_infos_with_token根据链路二选一传值，不允许都为空。
        /// </summary>
        [JsonProperty("compare_object_infos_with_token", NullValueHandling = NullValueHandling.Ignore)]
        public List<CompareObjectInfoWithToken> CompareObjectInfosWithToken { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDataLevelCompareReq {\n");
            sb.Append("  conflictPolicy: ").Append(ConflictPolicy).Append("\n");
            sb.Append("  compareType: ").Append(CompareType).Append("\n");
            sb.Append("  compareMode: ").Append(CompareMode).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  compareObjectInfos: ").Append(CompareObjectInfos).Append("\n");
            sb.Append("  compareObjectInfosWithToken: ").Append(CompareObjectInfosWithToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDataLevelCompareReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDataLevelCompareReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConflictPolicy == input.ConflictPolicy ||
                    (this.ConflictPolicy != null &&
                    this.ConflictPolicy.Equals(input.ConflictPolicy))
                ) && 
                (
                    this.CompareType == input.CompareType ||
                    (this.CompareType != null &&
                    this.CompareType.Equals(input.CompareType))
                ) && 
                (
                    this.CompareMode == input.CompareMode ||
                    (this.CompareMode != null &&
                    this.CompareMode.Equals(input.CompareMode))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.CompareObjectInfos == input.CompareObjectInfos ||
                    this.CompareObjectInfos != null &&
                    input.CompareObjectInfos != null &&
                    this.CompareObjectInfos.SequenceEqual(input.CompareObjectInfos)
                ) && 
                (
                    this.CompareObjectInfosWithToken == input.CompareObjectInfosWithToken ||
                    this.CompareObjectInfosWithToken != null &&
                    input.CompareObjectInfosWithToken != null &&
                    this.CompareObjectInfosWithToken.SequenceEqual(input.CompareObjectInfosWithToken)
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
                if (this.ConflictPolicy != null)
                    hashCode = hashCode * 59 + this.ConflictPolicy.GetHashCode();
                if (this.CompareType != null)
                    hashCode = hashCode * 59 + this.CompareType.GetHashCode();
                if (this.CompareMode != null)
                    hashCode = hashCode * 59 + this.CompareMode.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.CompareObjectInfos != null)
                    hashCode = hashCode * 59 + this.CompareObjectInfos.GetHashCode();
                if (this.CompareObjectInfosWithToken != null)
                    hashCode = hashCode * 59 + this.CompareObjectInfosWithToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
