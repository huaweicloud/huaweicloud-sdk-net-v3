using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V2.Model
{
    /// <summary>
    /// 配置app自动录制模式请求
    /// </summary>
    public class AutoRecordModeReq 
    {
        /// <summary>
        /// 录制模式。 - AUTO_RECORD_OFF：关闭自动录制。 - AUTO_INDIVIDUAL_RECORD：开启单流自动录制，此时record_rule_id必须非空。 
        /// </summary>
        /// <value>录制模式。 - AUTO_RECORD_OFF：关闭自动录制。 - AUTO_INDIVIDUAL_RECORD：开启单流自动录制，此时record_rule_id必须非空。 </value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum AUTO_RECORD_OFF for value: AUTO_RECORD_OFF
            /// </summary>
            public static readonly ModeEnum AUTO_RECORD_OFF = new ModeEnum("AUTO_RECORD_OFF");

            /// <summary>
            /// Enum AUTO_INDIVIDUAL_RECORD for value: AUTO_INDIVIDUAL_RECORD
            /// </summary>
            public static readonly ModeEnum AUTO_INDIVIDUAL_RECORD = new ModeEnum("AUTO_INDIVIDUAL_RECORD");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "AUTO_RECORD_OFF", AUTO_RECORD_OFF },
                { "AUTO_INDIVIDUAL_RECORD", AUTO_INDIVIDUAL_RECORD },
            };

            private string _value;

            public ModeEnum()
            {

            }

            public ModeEnum(string value)
            {
                _value = value;
            }

            public static ModeEnum FromValue(string value)
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 录制模式。 - AUTO_RECORD_OFF：关闭自动录制。 - AUTO_INDIVIDUAL_RECORD：开启单流自动录制，此时record_rule_id必须非空。 
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// 录制规则id。
        /// </summary>
        [JsonProperty("record_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordRuleId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoRecordModeReq {\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  recordRuleId: ").Append(RecordRuleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutoRecordModeReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutoRecordModeReq input)
        {
            if (input == null) return false;
            if (this.Mode != input.Mode) return false;
            if (this.RecordRuleId != input.RecordRuleId || (this.RecordRuleId != null && !this.RecordRuleId.Equals(input.RecordRuleId))) return false;

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
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.RecordRuleId != null) hashCode = hashCode * 59 + this.RecordRuleId.GetHashCode();
                return hashCode;
            }
        }
    }
}
