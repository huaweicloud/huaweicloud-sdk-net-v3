using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TriggerConfig 
    {
        /// <summary>
        /// 触发类型，老化规则只支持manual(手动)、scheduled(定时+手动)；同步策略支持manual(手动)、scheduled(定时+手动)、event_based(事件触发+手动);镜像签名支持manual(手动)、event_based(事件触发+手动)
        /// </summary>
        /// <value>触发类型，老化规则只支持manual(手动)、scheduled(定时+手动)；同步策略支持manual(手动)、scheduled(定时+手动)、event_based(事件触发+手动);镜像签名支持manual(手动)、event_based(事件触发+手动)</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum MANUAL for value: manual
            /// </summary>
            public static readonly TypeEnum MANUAL = new TypeEnum("manual");

            /// <summary>
            /// Enum SCHEDULED for value: scheduled
            /// </summary>
            public static readonly TypeEnum SCHEDULED = new TypeEnum("scheduled");

            /// <summary>
            /// Enum EVENT_BASED for value: event_based
            /// </summary>
            public static readonly TypeEnum EVENT_BASED = new TypeEnum("event_based");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "manual", MANUAL },
                { "scheduled", SCHEDULED },
                { "event_based", EVENT_BASED },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 触发类型，老化规则只支持manual(手动)、scheduled(定时+手动)；同步策略支持manual(手动)、scheduled(定时+手动)、event_based(事件触发+手动);镜像签名支持manual(手动)、event_based(事件触发+手动)
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("trigger_settings", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerSetting TriggerSettings { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TriggerConfig {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  triggerSettings: ").Append(TriggerSettings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TriggerConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TriggerConfig input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.TriggerSettings != input.TriggerSettings || (this.TriggerSettings != null && !this.TriggerSettings.Equals(input.TriggerSettings))) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TriggerSettings != null) hashCode = hashCode * 59 + this.TriggerSettings.GetHashCode();
                return hashCode;
            }
        }
    }
}
