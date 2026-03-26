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
    public class CapacityReservationSpecification 
    {
        /// <summary>
        /// 实例启动的私有池容量选项
        /// </summary>
        /// <value>实例启动的私有池容量选项</value>
        [JsonConverter(typeof(EnumClassConverter<PreferenceEnum>))]
        public class PreferenceEnum
        {
            /// <summary>
            /// Enum NONE for value: none
            /// </summary>
            public static readonly PreferenceEnum NONE = new PreferenceEnum("none");

            /// <summary>
            /// Enum TARGETED for value: targeted
            /// </summary>
            public static readonly PreferenceEnum TARGETED = new PreferenceEnum("targeted");

            private static readonly Dictionary<string, PreferenceEnum> StaticFields =
            new Dictionary<string, PreferenceEnum>()
            {
                { "none", NONE },
                { "targeted", TARGETED },
            };

            private string _value;

            public PreferenceEnum()
            {

            }

            public PreferenceEnum(string value)
            {
                _value = value;
            }

            public static PreferenceEnum FromValue(string value)
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

                if (this.Equals(obj as PreferenceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PreferenceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PreferenceEnum a, PreferenceEnum b)
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

            public static bool operator !=(PreferenceEnum a, PreferenceEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 目标容量预留ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例启动的私有池容量选项
        /// </summary>
        [JsonProperty("preference", NullValueHandling = NullValueHandling.Ignore)]
        public PreferenceEnum Preference { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CapacityReservationSpecification {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  preference: ").Append(Preference).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CapacityReservationSpecification);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CapacityReservationSpecification input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Preference != input.Preference) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.Preference.GetHashCode();
                return hashCode;
            }
        }
    }
}
