using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NoDataCondition 
    {
        /// <summary>
        /// 数据不足时，阈值规则的状态。 - “no_data”：数据不足并发送通知 - “alerting”：告警 - “ok”：正常 - “pre_state”：保持上一个状态
        /// </summary>
        /// <value>数据不足时，阈值规则的状态。 - “no_data”：数据不足并发送通知 - “alerting”：告警 - “ok”：正常 - “pre_state”：保持上一个状态</value>
        [JsonConverter(typeof(EnumClassConverter<NoDataAlertStateEnum>))]
        public class NoDataAlertStateEnum
        {
            /// <summary>
            /// Enum NO_DATA for value: no_data
            /// </summary>
            public static readonly NoDataAlertStateEnum NO_DATA = new NoDataAlertStateEnum("no_data");

            /// <summary>
            /// Enum ALERTING for value: alerting
            /// </summary>
            public static readonly NoDataAlertStateEnum ALERTING = new NoDataAlertStateEnum("alerting");

            /// <summary>
            /// Enum OK for value: ok
            /// </summary>
            public static readonly NoDataAlertStateEnum OK = new NoDataAlertStateEnum("ok");

            /// <summary>
            /// Enum PRE_STATE for value: pre_state
            /// </summary>
            public static readonly NoDataAlertStateEnum PRE_STATE = new NoDataAlertStateEnum("pre_state");

            private static readonly Dictionary<string, NoDataAlertStateEnum> StaticFields =
            new Dictionary<string, NoDataAlertStateEnum>()
            {
                { "no_data", NO_DATA },
                { "alerting", ALERTING },
                { "ok", OK },
                { "pre_state", PRE_STATE },
            };

            private string _value;

            public NoDataAlertStateEnum()
            {

            }

            public NoDataAlertStateEnum(string value)
            {
                _value = value;
            }

            public static NoDataAlertStateEnum FromValue(string value)
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

                if (this.Equals(obj as NoDataAlertStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NoDataAlertStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NoDataAlertStateEnum a, NoDataAlertStateEnum b)
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

            public static bool operator !=(NoDataAlertStateEnum a, NoDataAlertStateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 无数据周期的个数。
        /// </summary>
        [JsonProperty("no_data_timeframe", NullValueHandling = NullValueHandling.Ignore)]
        public int? NoDataTimeframe { get; set; }

        /// <summary>
        /// 数据不足时，阈值规则的状态。 - “no_data”：数据不足并发送通知 - “alerting”：告警 - “ok”：正常 - “pre_state”：保持上一个状态
        /// </summary>
        [JsonProperty("no_data_alert_state", NullValueHandling = NullValueHandling.Ignore)]
        public NoDataAlertStateEnum NoDataAlertState { get; set; }
        /// <summary>
        /// 数据不足是否通知。
        /// </summary>
        [JsonProperty("notify_no_data", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotifyNoData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NoDataCondition {\n");
            sb.Append("  noDataTimeframe: ").Append(NoDataTimeframe).Append("\n");
            sb.Append("  noDataAlertState: ").Append(NoDataAlertState).Append("\n");
            sb.Append("  notifyNoData: ").Append(NotifyNoData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NoDataCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NoDataCondition input)
        {
            if (input == null) return false;
            if (this.NoDataTimeframe != input.NoDataTimeframe || (this.NoDataTimeframe != null && !this.NoDataTimeframe.Equals(input.NoDataTimeframe))) return false;
            if (this.NoDataAlertState != input.NoDataAlertState) return false;
            if (this.NotifyNoData != input.NotifyNoData || (this.NotifyNoData != null && !this.NotifyNoData.Equals(input.NotifyNoData))) return false;

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
                if (this.NoDataTimeframe != null) hashCode = hashCode * 59 + this.NoDataTimeframe.GetHashCode();
                hashCode = hashCode * 59 + this.NoDataAlertState.GetHashCode();
                if (this.NotifyNoData != null) hashCode = hashCode * 59 + this.NotifyNoData.GetHashCode();
                return hashCode;
            }
        }
    }
}
