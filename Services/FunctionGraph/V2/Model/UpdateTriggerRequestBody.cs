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
    public class UpdateTriggerRequestBody 
    {
        /// <summary>
        /// 触发器状态
        /// </summary>
        /// <value>触发器状态</value>
        [JsonConverter(typeof(EnumClassConverter<TriggerStatusEnum>))]
        public class TriggerStatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly TriggerStatusEnum ACTIVE = new TriggerStatusEnum("ACTIVE");

            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly TriggerStatusEnum DISABLED = new TriggerStatusEnum("DISABLED");

            private static readonly Dictionary<string, TriggerStatusEnum> StaticFields =
            new Dictionary<string, TriggerStatusEnum>()
            {
                { "ACTIVE", ACTIVE },
                { "DISABLED", DISABLED },
            };

            private string _value;

            public TriggerStatusEnum()
            {

            }

            public TriggerStatusEnum(string value)
            {
                _value = value;
            }

            public static TriggerStatusEnum FromValue(string value)
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

                if (this.Equals(obj as TriggerStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TriggerStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TriggerStatusEnum a, TriggerStatusEnum b)
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

            public static bool operator !=(TriggerStatusEnum a, TriggerStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 触发器状态
        /// </summary>
        [JsonProperty("trigger_status", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerStatusEnum TriggerStatus { get; set; }
        /// <summary>
        /// 触发器更新事件
        /// </summary>
        [JsonProperty("event_data", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpdateriggerEventData> EventData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTriggerRequestBody {\n");
            sb.Append("  triggerStatus: ").Append(TriggerStatus).Append("\n");
            sb.Append("  eventData: ").Append(EventData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTriggerRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTriggerRequestBody input)
        {
            if (input == null) return false;
            if (this.TriggerStatus != input.TriggerStatus) return false;
            if (this.EventData != input.EventData || (this.EventData != null && input.EventData != null && !this.EventData.SequenceEqual(input.EventData))) return false;

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
                hashCode = hashCode * 59 + this.TriggerStatus.GetHashCode();
                if (this.EventData != null) hashCode = hashCode * 59 + this.EventData.GetHashCode();
                return hashCode;
            }
        }
    }
}
