using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateriggerEventData 
    {
        /// <summary>
        /// 拉取周期单位
        /// </summary>
        /// <value>拉取周期单位</value>
        [JsonConverter(typeof(EnumClassConverter<PollingUnitEnum>))]
        public class PollingUnitEnum
        {
            /// <summary>
            /// Enum MS for value: ms
            /// </summary>
            public static readonly PollingUnitEnum MS = new PollingUnitEnum("ms");

            /// <summary>
            /// Enum S for value: s
            /// </summary>
            public static readonly PollingUnitEnum S = new PollingUnitEnum("s");

            private static readonly Dictionary<string, PollingUnitEnum> StaticFields =
            new Dictionary<string, PollingUnitEnum>()
            {
                { "ms", MS },
                { "s", S },
            };

            private string _value;

            public PollingUnitEnum()
            {

            }

            public PollingUnitEnum(string value)
            {
                _value = value;
            }

            public static PollingUnitEnum FromValue(string value)
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

                if (this.Equals(obj as PollingUnitEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PollingUnitEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PollingUnitEnum a, PollingUnitEnum b)
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

            public static bool operator !=(PollingUnitEnum a, PollingUnitEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 串行处理数据
        /// </summary>
        [JsonProperty("is_serial", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSerial { get; set; }

        /// <summary>
        /// 最大字节数
        /// </summary>
        [JsonProperty("max_fetch_bytes", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxFetchBytes { get; set; }

        /// <summary>
        /// 拉取周期
        /// </summary>
        [JsonProperty("polling_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? PollingInterval { get; set; }

        /// <summary>
        /// 拉取周期单位
        /// </summary>
        [JsonProperty("polling_unit", NullValueHandling = NullValueHandling.Ignore)]
        public PollingUnitEnum PollingUnit { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateriggerEventData {\n");
            sb.Append("  isSerial: ").Append(IsSerial).Append("\n");
            sb.Append("  maxFetchBytes: ").Append(MaxFetchBytes).Append("\n");
            sb.Append("  pollingInterval: ").Append(PollingInterval).Append("\n");
            sb.Append("  pollingUnit: ").Append(PollingUnit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateriggerEventData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateriggerEventData input)
        {
            if (input == null) return false;
            if (this.IsSerial != input.IsSerial || (this.IsSerial != null && !this.IsSerial.Equals(input.IsSerial))) return false;
            if (this.MaxFetchBytes != input.MaxFetchBytes || (this.MaxFetchBytes != null && !this.MaxFetchBytes.Equals(input.MaxFetchBytes))) return false;
            if (this.PollingInterval != input.PollingInterval || (this.PollingInterval != null && !this.PollingInterval.Equals(input.PollingInterval))) return false;
            if (this.PollingUnit != input.PollingUnit) return false;

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
                if (this.IsSerial != null) hashCode = hashCode * 59 + this.IsSerial.GetHashCode();
                if (this.MaxFetchBytes != null) hashCode = hashCode * 59 + this.MaxFetchBytes.GetHashCode();
                if (this.PollingInterval != null) hashCode = hashCode * 59 + this.PollingInterval.GetHashCode();
                hashCode = hashCode * 59 + this.PollingUnit.GetHashCode();
                return hashCode;
            }
        }
    }
}
