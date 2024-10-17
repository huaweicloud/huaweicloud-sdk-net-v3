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
    /// 触发器结构体
    /// </summary>
    public class Trigger 
    {
        /// <summary>
        /// 触发器类型 FLOWTIMER：定时触发器 SMN：SMN触发器 APIG：APIG触发器(共享版) APIG_DE：APIG触发器(专享版) OBS：OBS触发器
        /// </summary>
        /// <value>触发器类型 FLOWTIMER：定时触发器 SMN：SMN触发器 APIG：APIG触发器(共享版) APIG_DE：APIG触发器(专享版) OBS：OBS触发器</value>
        [JsonConverter(typeof(EnumClassConverter<TriggerTypeEnum>))]
        public class TriggerTypeEnum
        {
            /// <summary>
            /// Enum FLOWTIMER for value: FLOWTIMER
            /// </summary>
            public static readonly TriggerTypeEnum FLOWTIMER = new TriggerTypeEnum("FLOWTIMER");

            /// <summary>
            /// Enum SMN for value: SMN
            /// </summary>
            public static readonly TriggerTypeEnum SMN = new TriggerTypeEnum("SMN");

            /// <summary>
            /// Enum APIG for value: APIG
            /// </summary>
            public static readonly TriggerTypeEnum APIG = new TriggerTypeEnum("APIG");

            /// <summary>
            /// Enum APIG_DE for value: APIG_DE
            /// </summary>
            public static readonly TriggerTypeEnum APIG_DE = new TriggerTypeEnum("APIG_DE");

            /// <summary>
            /// Enum OBS for value: OBS
            /// </summary>
            public static readonly TriggerTypeEnum OBS = new TriggerTypeEnum("OBS");

            private static readonly Dictionary<string, TriggerTypeEnum> StaticFields =
            new Dictionary<string, TriggerTypeEnum>()
            {
                { "FLOWTIMER", FLOWTIMER },
                { "SMN", SMN },
                { "APIG", APIG },
                { "APIG_DE", APIG_DE },
                { "OBS", OBS },
            };

            private string _value;

            public TriggerTypeEnum()
            {

            }

            public TriggerTypeEnum(string value)
            {
                _value = value;
            }

            public static TriggerTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TriggerTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TriggerTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TriggerTypeEnum a, TriggerTypeEnum b)
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

            public static bool operator !=(TriggerTypeEnum a, TriggerTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 触发器名称
        /// </summary>
        [JsonProperty("trigger_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerName { get; set; }

        /// <summary>
        /// 触发器类型 FLOWTIMER：定时触发器 SMN：SMN触发器 APIG：APIG触发器(共享版) APIG_DE：APIG触发器(专享版) OBS：OBS触发器
        /// </summary>
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public TriggerTypeEnum TriggerType { get; set; }
        /// <summary>
        /// 是否启用触发器
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("trigger_config", NullValueHandling = NullValueHandling.Ignore)]
        public OBSTriggerConfig TriggerConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Trigger {\n");
            sb.Append("  triggerName: ").Append(TriggerName).Append("\n");
            sb.Append("  triggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  triggerConfig: ").Append(TriggerConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Trigger);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Trigger input)
        {
            if (input == null) return false;
            if (this.TriggerName != input.TriggerName || (this.TriggerName != null && !this.TriggerName.Equals(input.TriggerName))) return false;
            if (this.TriggerType != input.TriggerType) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.TriggerConfig != input.TriggerConfig || (this.TriggerConfig != null && !this.TriggerConfig.Equals(input.TriggerConfig))) return false;

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
                if (this.TriggerName != null) hashCode = hashCode * 59 + this.TriggerName.GetHashCode();
                hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.TriggerConfig != null) hashCode = hashCode * 59 + this.TriggerConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
