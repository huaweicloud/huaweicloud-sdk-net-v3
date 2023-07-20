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
    /// Response Object
    /// </summary>
    public class ShowComparePolicyResponse : SdkResponse
    {
        /// <summary>
        /// 对比策略状态。 - OPEN：开启 - CLOSED：关闭 - NO_SUPPORT：不支持
        /// </summary>
        /// <value>对比策略状态。 - OPEN：开启 - CLOSED：关闭 - NO_SUPPORT：不支持</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum OPEN for value: OPEN
            /// </summary>
            public static readonly StatusEnum OPEN = new StatusEnum("OPEN");

            /// <summary>
            /// Enum CLOSED for value: CLOSED
            /// </summary>
            public static readonly StatusEnum CLOSED = new StatusEnum("CLOSED");

            /// <summary>
            /// Enum NO_SUPPORT for value: NO_SUPPORT
            /// </summary>
            public static readonly StatusEnum NO_SUPPORT = new StatusEnum("NO_SUPPORT");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "OPEN", OPEN },
                { "CLOSED", CLOSED },
                { "NO_SUPPORT", NO_SUPPORT },
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
        /// 对比时间。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 对比策略状态。 - OPEN：开启 - CLOSED：关闭 - NO_SUPPORT：不支持
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 对比开始时间。
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 对比结束时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 对比类型。 - object：对象对比 - lines：行对比 - contents：内容对比 - account：用户对比
        /// </summary>
        [JsonProperty("compare_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CompareType { get; set; }

        /// <summary>
        /// 下次对比时间，UTC时间，例如：2023-06-12T08:00:00Z
        /// </summary>
        [JsonProperty("next_compare_time", NullValueHandling = NullValueHandling.Ignore)]
        public string NextCompareTime { get; set; }

        /// <summary>
        /// 对比策略。 - normal：普通对比 - manyToOne：多对一对比
        /// </summary>
        [JsonProperty("compare_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string ComparePolicy { get; set; }

        /// <summary>
        /// 间隔时间。
        /// </summary>
        [JsonProperty("interval_hour", NullValueHandling = NullValueHandling.Ignore)]
        public int? IntervalHour { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowComparePolicyResponse {\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  compareType: ").Append(CompareType).Append("\n");
            sb.Append("  nextCompareTime: ").Append(NextCompareTime).Append("\n");
            sb.Append("  comparePolicy: ").Append(ComparePolicy).Append("\n");
            sb.Append("  intervalHour: ").Append(IntervalHour).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowComparePolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowComparePolicyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.BeginTime == input.BeginTime ||
                    (this.BeginTime != null &&
                    this.BeginTime.Equals(input.BeginTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.CompareType == input.CompareType ||
                    this.CompareType != null &&
                    input.CompareType != null &&
                    this.CompareType.SequenceEqual(input.CompareType)
                ) && 
                (
                    this.NextCompareTime == input.NextCompareTime ||
                    (this.NextCompareTime != null &&
                    this.NextCompareTime.Equals(input.NextCompareTime))
                ) && 
                (
                    this.ComparePolicy == input.ComparePolicy ||
                    (this.ComparePolicy != null &&
                    this.ComparePolicy.Equals(input.ComparePolicy))
                ) && 
                (
                    this.IntervalHour == input.IntervalHour ||
                    (this.IntervalHour != null &&
                    this.IntervalHour.Equals(input.IntervalHour))
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
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.BeginTime != null)
                    hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.CompareType != null)
                    hashCode = hashCode * 59 + this.CompareType.GetHashCode();
                if (this.NextCompareTime != null)
                    hashCode = hashCode * 59 + this.NextCompareTime.GetHashCode();
                if (this.ComparePolicy != null)
                    hashCode = hashCode * 59 + this.ComparePolicy.GetHashCode();
                if (this.IntervalHour != null)
                    hashCode = hashCode * 59 + this.IntervalHour.GetHashCode();
                return hashCode;
            }
        }
    }
}
