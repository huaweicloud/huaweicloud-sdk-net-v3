using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RangeStatusRequest 
    {
        /// <summary>
        /// range状态（\&quot;off\&quot;/\&quot;on\&quot;）
        /// </summary>
        /// <value>range状态（\&quot;off\&quot;/\&quot;on\&quot;）</value>
        [JsonConverter(typeof(EnumClassConverter<RangeStatusEnum>))]
        public class RangeStatusEnum
        {
            /// <summary>
            /// Enum OFF for value: off
            /// </summary>
            public static readonly RangeStatusEnum OFF = new RangeStatusEnum("off");

            /// <summary>
            /// Enum ON for value: on
            /// </summary>
            public static readonly RangeStatusEnum ON = new RangeStatusEnum("on");

            private static readonly Dictionary<string, RangeStatusEnum> StaticFields =
            new Dictionary<string, RangeStatusEnum>()
            {
                { "off", OFF },
                { "on", ON },
            };

            private string _value;

            public RangeStatusEnum()
            {

            }

            public RangeStatusEnum(string value)
            {
                _value = value;
            }

            public static RangeStatusEnum FromValue(string value)
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

                if (this.Equals(obj as RangeStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RangeStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RangeStatusEnum a, RangeStatusEnum b)
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

            public static bool operator !=(RangeStatusEnum a, RangeStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// range状态（\&quot;off\&quot;/\&quot;on\&quot;）
        /// </summary>
        [JsonProperty("range_status", NullValueHandling = NullValueHandling.Ignore)]
        public RangeStatusEnum RangeStatus { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RangeStatusRequest {\n");
            sb.Append("  rangeStatus: ").Append(RangeStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RangeStatusRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RangeStatusRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RangeStatus == input.RangeStatus ||
                    (this.RangeStatus != null &&
                    this.RangeStatus.Equals(input.RangeStatus))
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
                if (this.RangeStatus != null)
                    hashCode = hashCode * 59 + this.RangeStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
