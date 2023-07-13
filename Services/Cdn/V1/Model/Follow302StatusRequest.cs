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
    /// This is a auto create Body Object
    /// </summary>
    public class Follow302StatusRequest 
    {
        /// <summary>
        /// follow302状态，off：关闭，on：开启。
        /// </summary>
        /// <value>follow302状态，off：关闭，on：开启。</value>
        [JsonConverter(typeof(EnumClassConverter<Follow302StatusEnum>))]
        public class Follow302StatusEnum
        {
            /// <summary>
            /// Enum OFF for value: off
            /// </summary>
            public static readonly Follow302StatusEnum OFF = new Follow302StatusEnum("off");

            /// <summary>
            /// Enum ON for value: on
            /// </summary>
            public static readonly Follow302StatusEnum ON = new Follow302StatusEnum("on");

            private static readonly Dictionary<string, Follow302StatusEnum> StaticFields =
            new Dictionary<string, Follow302StatusEnum>()
            {
                { "off", OFF },
                { "on", ON },
            };

            private string _value;

            public Follow302StatusEnum()
            {

            }

            public Follow302StatusEnum(string value)
            {
                _value = value;
            }

            public static Follow302StatusEnum FromValue(string value)
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

                if (this.Equals(obj as Follow302StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(Follow302StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(Follow302StatusEnum a, Follow302StatusEnum b)
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

            public static bool operator !=(Follow302StatusEnum a, Follow302StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// follow302状态，off：关闭，on：开启。
        /// </summary>
        [JsonProperty("follow302_status", NullValueHandling = NullValueHandling.Ignore)]
        public Follow302StatusEnum Follow302Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Follow302StatusRequest {\n");
            sb.Append("  follow302Status: ").Append(Follow302Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Follow302StatusRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Follow302StatusRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Follow302Status == input.Follow302Status ||
                    (this.Follow302Status != null &&
                    this.Follow302Status.Equals(input.Follow302Status))
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
                if (this.Follow302Status != null)
                    hashCode = hashCode * 59 + this.Follow302Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
