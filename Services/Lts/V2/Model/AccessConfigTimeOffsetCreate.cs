using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 日志接入偏移时间
    /// </summary>
    public class AccessConfigTimeOffsetCreate 
    {
        /// <summary>
        /// 偏移时间单位。day ：天，hour：小时，sec：秒
        /// </summary>
        /// <value>偏移时间单位。day ：天，hour：小时，sec：秒</value>
        [JsonConverter(typeof(EnumClassConverter<UnitEnum>))]
        public class UnitEnum
        {
            /// <summary>
            /// Enum DAY for value: day
            /// </summary>
            public static readonly UnitEnum DAY = new UnitEnum("day");

            /// <summary>
            /// Enum HOUR for value: hour
            /// </summary>
            public static readonly UnitEnum HOUR = new UnitEnum("hour");

            /// <summary>
            /// Enum SEC for value: sec
            /// </summary>
            public static readonly UnitEnum SEC = new UnitEnum("sec");

            private static readonly Dictionary<string, UnitEnum> StaticFields =
            new Dictionary<string, UnitEnum>()
            {
                { "day", DAY },
                { "hour", HOUR },
                { "sec", SEC },
            };

            private string _value;

            public UnitEnum()
            {

            }

            public UnitEnum(string value)
            {
                _value = value;
            }

            public static UnitEnum FromValue(string value)
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

                if (this.Equals(obj as UnitEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UnitEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UnitEnum a, UnitEnum b)
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

            public static bool operator !=(UnitEnum a, UnitEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 偏移时间。 当\&quot;unit\&quot;选择\&quot;day\&quot;时，范围为1~7天。 当\&quot;unit\&quot;选择\&quot;hour\&quot;时，范围为1~168小时。 当\&quot;unit\&quot;选择\&quot;sec\&quot;时，范围为1~604800秒。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? Offset { get; set; }

        /// <summary>
        /// 偏移时间单位。day ：天，hour：小时，sec：秒
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public UnitEnum Unit { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessConfigTimeOffsetCreate {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessConfigTimeOffsetCreate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessConfigTimeOffsetCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                return hashCode;
            }
        }
    }
}
