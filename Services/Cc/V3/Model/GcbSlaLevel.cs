using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 全域互联带宽的带宽等级。
    /// </summary>
    public class GcbSlaLevel 
    {
        /// <summary>
        /// 功能说明：描述网络等级，从高到低分为铂金、金、银。默认金，其余租户白名单控制。 - Pt: 铂金 - Au: 金 - Ag: 银
        /// </summary>
        /// <value>功能说明：描述网络等级，从高到低分为铂金、金、银。默认金，其余租户白名单控制。 - Pt: 铂金 - Au: 金 - Ag: 银</value>
        [JsonConverter(typeof(EnumClassConverter<SlaLevelEnum>))]
        public class SlaLevelEnum
        {
            /// <summary>
            /// Enum PT for value: Pt
            /// </summary>
            public static readonly SlaLevelEnum PT = new SlaLevelEnum("Pt");

            /// <summary>
            /// Enum AU for value: Au
            /// </summary>
            public static readonly SlaLevelEnum AU = new SlaLevelEnum("Au");

            /// <summary>
            /// Enum AG for value: Ag
            /// </summary>
            public static readonly SlaLevelEnum AG = new SlaLevelEnum("Ag");

            private static readonly Dictionary<string, SlaLevelEnum> StaticFields =
            new Dictionary<string, SlaLevelEnum>()
            {
                { "Pt", PT },
                { "Au", AU },
                { "Ag", AG },
            };

            private string _value;

            public SlaLevelEnum()
            {

            }

            public SlaLevelEnum(string value)
            {
                _value = value;
            }

            public static SlaLevelEnum FromValue(string value)
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

                if (this.Equals(obj as SlaLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SlaLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SlaLevelEnum a, SlaLevelEnum b)
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

            public static bool operator !=(SlaLevelEnum a, SlaLevelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 功能说明：描述网络等级，从高到低分为铂金、金、银。默认金，其余租户白名单控制。 - Pt: 铂金 - Au: 金 - Ag: 银
        /// </summary>
        [JsonProperty("sla_level", NullValueHandling = NullValueHandling.Ignore)]
        public SlaLevelEnum SlaLevel { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GcbSlaLevel {\n");
            sb.Append("  slaLevel: ").Append(SlaLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GcbSlaLevel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GcbSlaLevel input)
        {
            if (input == null) return false;
            if (this.SlaLevel != input.SlaLevel) return false;

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
                hashCode = hashCode * 59 + this.SlaLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
