using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateRecycleBinOption 
    {
        /// <summary>
        /// 回收站开启开关
        /// </summary>
        /// <value>回收站开启开关</value>
        [JsonConverter(typeof(EnumClassConverter<SwitchEnum>))]
        public class SwitchEnum
        {
            /// <summary>
            /// Enum ON for value: on
            /// </summary>
            public static readonly SwitchEnum ON = new SwitchEnum("on");

            /// <summary>
            /// Enum OFF for value: off
            /// </summary>
            public static readonly SwitchEnum OFF = new SwitchEnum("off");

            private static readonly Dictionary<string, SwitchEnum> StaticFields =
            new Dictionary<string, SwitchEnum>()
            {
                { "on", ON },
                { "off", OFF },
            };

            private string _value;

            public SwitchEnum()
            {

            }

            public SwitchEnum(string value)
            {
                _value = value;
            }

            public static SwitchEnum FromValue(string value)
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

                if (this.Equals(obj as SwitchEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SwitchEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SwitchEnum a, SwitchEnum b)
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

            public static bool operator !=(SwitchEnum a, SwitchEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 回收站开启开关
        /// </summary>
        [JsonProperty("switch", NullValueHandling = NullValueHandling.Ignore)]
        public SwitchEnum Switch { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRecycleBinOption {\n");
            sb.Append("  Switch: ").Append(Switch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRecycleBinOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRecycleBinOption input)
        {
            if (input == null) return false;
            if (this.Switch != input.Switch) return false;

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
                hashCode = hashCode * 59 + this.Switch.GetHashCode();
                return hashCode;
            }
        }
    }
}
