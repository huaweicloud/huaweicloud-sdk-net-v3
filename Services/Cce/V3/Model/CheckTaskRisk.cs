using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CheckTaskRisk 
    {
        /// <summary>
        /// **参数解释：** 风险等级 **取值范围：** - Warning: 中危，允许跳过 - Fatal: 高危，不允许跳过  
        /// </summary>
        /// <value>**参数解释：** 风险等级 **取值范围：** - Warning: 中危，允许跳过 - Fatal: 高危，不允许跳过  </value>
        [JsonConverter(typeof(EnumClassConverter<LevelEnum>))]
        public class LevelEnum
        {
            /// <summary>
            /// Enum WARNING for value: Warning
            /// </summary>
            public static readonly LevelEnum WARNING = new LevelEnum("Warning");

            /// <summary>
            /// Enum FATAL for value: Fatal
            /// </summary>
            public static readonly LevelEnum FATAL = new LevelEnum("Fatal");

            private static readonly Dictionary<string, LevelEnum> StaticFields =
            new Dictionary<string, LevelEnum>()
            {
                { "Warning", WARNING },
                { "Fatal", FATAL },
            };

            private string _value;

            public LevelEnum()
            {

            }

            public LevelEnum(string value)
            {
                _value = value;
            }

            public static LevelEnum FromValue(string value)
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

                if (this.Equals(obj as LevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LevelEnum a, LevelEnum b)
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

            public static bool operator !=(LevelEnum a, LevelEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 风险项检查状态 **取值范围：** - Init: 风险项检查状态，初始化 - Running: 风险项检查状态，检查中 - Failed: 风险项检查状态，检查完成有风险 - Success: 风险项检查状态，检查完成无风险  
        /// </summary>
        /// <value>**参数解释：** 风险项检查状态 **取值范围：** - Init: 风险项检查状态，初始化 - Running: 风险项检查状态，检查中 - Failed: 风险项检查状态，检查完成有风险 - Success: 风险项检查状态，检查完成无风险  </value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum INIT for value: Init
            /// </summary>
            public static readonly StatusEnum INIT = new StatusEnum("Init");

            /// <summary>
            /// Enum RUNNING for value: Running
            /// </summary>
            public static readonly StatusEnum RUNNING = new StatusEnum("Running");

            /// <summary>
            /// Enum FAILED for value: Failed
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("Failed");

            /// <summary>
            /// Enum SUCCESS for value: Success
            /// </summary>
            public static readonly StatusEnum SUCCESS = new StatusEnum("Success");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "Init", INIT },
                { "Running", RUNNING },
                { "Failed", FAILED },
                { "Success", SUCCESS },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 风险项名称 **取值范围：** 不涉及 
        /// </summary>
        [JsonProperty("riskName", NullValueHandling = NullValueHandling.Ignore)]
        public string RiskName { get; set; }

        /// <summary>
        /// **参数解释：** 风险等级 **取值范围：** - Warning: 中危，允许跳过 - Fatal: 高危，不允许跳过  
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public LevelEnum Level { get; set; }
        /// <summary>
        /// **参数解释：** 风险项检查状态 **取值范围：** - Init: 风险项检查状态，初始化 - Running: 风险项检查状态，检查中 - Failed: 风险项检查状态，检查完成有风险 - Success: 风险项检查状态，检查完成无风险  
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释：** 风险检查结果说明 **取值范围：** 不涉及 
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckTaskRisk {\n");
            sb.Append("  riskName: ").Append(RiskName).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckTaskRisk);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckTaskRisk input)
        {
            if (input == null) return false;
            if (this.RiskName != input.RiskName || (this.RiskName != null && !this.RiskName.Equals(input.RiskName))) return false;
            if (this.Level != input.Level) return false;
            if (this.Status != input.Status) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;

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
                if (this.RiskName != null) hashCode = hashCode * 59 + this.RiskName.GetHashCode();
                hashCode = hashCode * 59 + this.Level.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
