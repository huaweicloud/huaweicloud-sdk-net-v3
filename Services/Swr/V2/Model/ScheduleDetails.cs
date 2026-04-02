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
    public class ScheduleDetails 
    {
        /// <summary>
        /// 计划类型。有效值为&#39;None&#39;（无）和 &#39;Custom&#39;（自定义）。  Custom&#39; 表示按照指定的 cron 计划触发，而 &#39;None&#39; 则表示取消定时计划。 
        /// </summary>
        /// <value>计划类型。有效值为&#39;None&#39;（无）和 &#39;Custom&#39;（自定义）。  Custom&#39; 表示按照指定的 cron 计划触发，而 &#39;None&#39; 则表示取消定时计划。 </value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum NONE for value: None
            /// </summary>
            public static readonly TypeEnum NONE = new TypeEnum("None");

            /// <summary>
            /// Enum CUSTOM for value: Custom
            /// </summary>
            public static readonly TypeEnum CUSTOM = new TypeEnum("Custom");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "None", NONE },
                { "Custom", CUSTOM },
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
        /// 计划类型。有效值为&#39;None&#39;（无）和 &#39;Custom&#39;（自定义）。  Custom&#39; 表示按照指定的 cron 计划触发，而 &#39;None&#39; 则表示取消定时计划。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// cron表达式，一种基于时间的任务调度器，type设置为Custom时，需要配置此值。
        /// </summary>
        [JsonProperty("cron", NullValueHandling = NullValueHandling.Ignore)]
        public string Cron { get; set; }

        /// <summary>
        /// 下次执行任务的时间。
        /// </summary>
        [JsonProperty("next_scheduled_time", NullValueHandling = NullValueHandling.Ignore)]
        public string NextScheduledTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleDetails {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  cron: ").Append(Cron).Append("\n");
            sb.Append("  nextScheduledTime: ").Append(NextScheduledTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduleDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScheduleDetails input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.Cron != input.Cron || (this.Cron != null && !this.Cron.Equals(input.Cron))) return false;
            if (this.NextScheduledTime != input.NextScheduledTime || (this.NextScheduledTime != null && !this.NextScheduledTime.Equals(input.NextScheduledTime))) return false;

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
                if (this.Cron != null) hashCode = hashCode * 59 + this.Cron.GetHashCode();
                if (this.NextScheduledTime != null) hashCode = hashCode * 59 + this.NextScheduledTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
