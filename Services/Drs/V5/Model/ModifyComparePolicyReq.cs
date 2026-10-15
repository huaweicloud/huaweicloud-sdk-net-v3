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
    /// 修改对比策略请求体。
    /// </summary>
    public class ModifyComparePolicyReq 
    {
        /// <summary>
        /// 对比策略： - normal：普通对比。 - manyToOne：多对一对比。
        /// </summary>
        /// <value>对比策略： - normal：普通对比。 - manyToOne：多对一对比。</value>
        [JsonConverter(typeof(EnumClassConverter<ComparePolicyEnum>))]
        public class ComparePolicyEnum
        {
            /// <summary>
            /// Enum NORMAL for value: normal
            /// </summary>
            public static readonly ComparePolicyEnum NORMAL = new ComparePolicyEnum("normal");

            /// <summary>
            /// Enum MANYTOONE for value: manyToOne
            /// </summary>
            public static readonly ComparePolicyEnum MANYTOONE = new ComparePolicyEnum("manyToOne");

            private static readonly Dictionary<string, ComparePolicyEnum> StaticFields =
            new Dictionary<string, ComparePolicyEnum>()
            {
                { "normal", NORMAL },
                { "manyToOne", MANYTOONE },
            };

            private string _value;

            public ComparePolicyEnum()
            {

            }

            public ComparePolicyEnum(string value)
            {
                _value = value;
            }

            public static ComparePolicyEnum FromValue(string value)
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

                if (this.Equals(obj as ComparePolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ComparePolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ComparePolicyEnum a, ComparePolicyEnum b)
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

            public static bool operator !=(ComparePolicyEnum a, ComparePolicyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 冲突策略。 **约束限制：** 对存在正在执行中的对比任务时的周期性对比策略 支持链路范围：MySQL-MySQL、MySQL-TaurusDB迁移、MySQL-MySQL同步，MySQL-GaussDB集中式，GaussDB分布式-GaussDB集中式，GaussDB集中式-MySQL，GaussDBV1-GaussDB集中式，GaussDB集中式-GaussDBV1，MySQL-MySQL灾备，GaussDB集中式-GaussDB集中式，OpenGauss-GaussDB分布式，OpenGauss-GaussDB集中式，GaussDB集中式-Oracle，Oracle-GaussDB集中式，GaussDB分布式-GaussDB分布式，GaussDB分布式-Oracle，Oracle-GaussDB分布式，MySQL-TaurusDB，TaurusDB-TaurusDB，TaurusDB-MySQL，GaussDB集中式-GaussDB透明多写，GaussDB分布式-GaussDB透明多写，GaussDB透明多写-GaussDB透明多写，GaussDB透明多写-GaussDB分布式，GaussDB透明多写-GaussDB集中式，Oracle-GaussDB透明多写，GaussDB透明多写-Oracle，DB2-GaussDB分布式，DB2-GaussDB集中式，GaussDB分布式-DB2，GaussDB集中式-DB2 **取值范围：** cover: 覆盖表示取消正在执行的任务，开始新对比 ignore：忽略表示忽略本次周期性对比 **默认取值：** 不涉及
        /// </summary>
        /// <value>**参数解释：** 冲突策略。 **约束限制：** 对存在正在执行中的对比任务时的周期性对比策略 支持链路范围：MySQL-MySQL、MySQL-TaurusDB迁移、MySQL-MySQL同步，MySQL-GaussDB集中式，GaussDB分布式-GaussDB集中式，GaussDB集中式-MySQL，GaussDBV1-GaussDB集中式，GaussDB集中式-GaussDBV1，MySQL-MySQL灾备，GaussDB集中式-GaussDB集中式，OpenGauss-GaussDB分布式，OpenGauss-GaussDB集中式，GaussDB集中式-Oracle，Oracle-GaussDB集中式，GaussDB分布式-GaussDB分布式，GaussDB分布式-Oracle，Oracle-GaussDB分布式，MySQL-TaurusDB，TaurusDB-TaurusDB，TaurusDB-MySQL，GaussDB集中式-GaussDB透明多写，GaussDB分布式-GaussDB透明多写，GaussDB透明多写-GaussDB透明多写，GaussDB透明多写-GaussDB分布式，GaussDB透明多写-GaussDB集中式，Oracle-GaussDB透明多写，GaussDB透明多写-Oracle，DB2-GaussDB分布式，DB2-GaussDB集中式，GaussDB分布式-DB2，GaussDB集中式-DB2 **取值范围：** cover: 覆盖表示取消正在执行的任务，开始新对比 ignore：忽略表示忽略本次周期性对比 **默认取值：** 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<ConflictStrategyEnum>))]
        public class ConflictStrategyEnum
        {
            /// <summary>
            /// Enum COVER for value: cover
            /// </summary>
            public static readonly ConflictStrategyEnum COVER = new ConflictStrategyEnum("cover");

            /// <summary>
            /// Enum IGNORE for value: ignore
            /// </summary>
            public static readonly ConflictStrategyEnum IGNORE = new ConflictStrategyEnum("ignore");

            private static readonly Dictionary<string, ConflictStrategyEnum> StaticFields =
            new Dictionary<string, ConflictStrategyEnum>()
            {
                { "cover", COVER },
                { "ignore", IGNORE },
            };

            private string _value;

            public ConflictStrategyEnum()
            {

            }

            public ConflictStrategyEnum(string value)
            {
                _value = value;
            }

            public static ConflictStrategyEnum FromValue(string value)
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

                if (this.Equals(obj as ConflictStrategyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConflictStrategyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConflictStrategyEnum a, ConflictStrategyEnum b)
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

            public static bool operator !=(ConflictStrategyEnum a, ConflictStrategyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 对比策略开关-open|close。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 对比策略周期。 - 每周对比：格式示例：“* * 1,3,5” ，其中“1,3,5”对应星期一、星期三、星期五，根据实际填写。 - 每天对比：固定填写“* * 1,2,3,4,5,6,7”。 - 按小时对比：固定填写“* * 1,2,3,4,5,6,7”。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 对比策略生效开始时间，UTC时间，24小时制，时间格式HH:mm:ss，例如：00:00:00，表示UTC时间的00:00:00，北京时间（UTC+08:00）的08:00:00。
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 对比策略生效结束时间，UTC时间，24小时制，时间格式HH:mm:ss，例如：04:00:00，表示UTC时间的04:00:00，北京时间（UTC+08:00）的12:00:00。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 对比类型列表： - object_comparison：对象对比。 - lines：行对比。 - account：用户对比。 - contents: 内容对比。
        /// </summary>
        [JsonProperty("compare_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CompareType { get; set; }

        /// <summary>
        /// 对比策略： - normal：普通对比。 - manyToOne：多对一对比。
        /// </summary>
        [JsonProperty("compare_policy", NullValueHandling = NullValueHandling.Ignore)]
        public ComparePolicyEnum ComparePolicy { get; set; }
        /// <summary>
        /// 间隔时间，按小时对比时填写，表示每隔多久执行一次对比，单位是小时。
        /// </summary>
        [JsonProperty("interval_hour", NullValueHandling = NullValueHandling.Ignore)]
        public int? IntervalHour { get; set; }

        /// <summary>
        /// **参数解释：** 冲突策略。 **约束限制：** 对存在正在执行中的对比任务时的周期性对比策略 支持链路范围：MySQL-MySQL、MySQL-TaurusDB迁移、MySQL-MySQL同步，MySQL-GaussDB集中式，GaussDB分布式-GaussDB集中式，GaussDB集中式-MySQL，GaussDBV1-GaussDB集中式，GaussDB集中式-GaussDBV1，MySQL-MySQL灾备，GaussDB集中式-GaussDB集中式，OpenGauss-GaussDB分布式，OpenGauss-GaussDB集中式，GaussDB集中式-Oracle，Oracle-GaussDB集中式，GaussDB分布式-GaussDB分布式，GaussDB分布式-Oracle，Oracle-GaussDB分布式，MySQL-TaurusDB，TaurusDB-TaurusDB，TaurusDB-MySQL，GaussDB集中式-GaussDB透明多写，GaussDB分布式-GaussDB透明多写，GaussDB透明多写-GaussDB透明多写，GaussDB透明多写-GaussDB分布式，GaussDB透明多写-GaussDB集中式，Oracle-GaussDB透明多写，GaussDB透明多写-Oracle，DB2-GaussDB分布式，DB2-GaussDB集中式，GaussDB分布式-DB2，GaussDB集中式-DB2 **取值范围：** cover: 覆盖表示取消正在执行的任务，开始新对比 ignore：忽略表示忽略本次周期性对比 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("conflict_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public ConflictStrategyEnum ConflictStrategy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyComparePolicyReq {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  compareType: ").Append(CompareType).Append("\n");
            sb.Append("  comparePolicy: ").Append(ComparePolicy).Append("\n");
            sb.Append("  intervalHour: ").Append(IntervalHour).Append("\n");
            sb.Append("  conflictStrategy: ").Append(ConflictStrategy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyComparePolicyReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyComparePolicyReq input)
        {
            if (input == null) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.CompareType != input.CompareType || (this.CompareType != null && input.CompareType != null && !this.CompareType.SequenceEqual(input.CompareType))) return false;
            if (this.ComparePolicy != input.ComparePolicy) return false;
            if (this.IntervalHour != input.IntervalHour || (this.IntervalHour != null && !this.IntervalHour.Equals(input.IntervalHour))) return false;
            if (this.ConflictStrategy != input.ConflictStrategy) return false;

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
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.CompareType != null) hashCode = hashCode * 59 + this.CompareType.GetHashCode();
                hashCode = hashCode * 59 + this.ComparePolicy.GetHashCode();
                if (this.IntervalHour != null) hashCode = hashCode * 59 + this.IntervalHour.GetHashCode();
                hashCode = hashCode * 59 + this.ConflictStrategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
