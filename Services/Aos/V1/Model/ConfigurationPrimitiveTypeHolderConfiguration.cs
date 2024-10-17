using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 私有hook配置项，可以指定私有hook生效的目标资源栈以及私有hook校验失败后资源栈的行为。可通过UpdatePrivateHook API更新私有hook配置项。
    /// </summary>
    public class ConfigurationPrimitiveTypeHolderConfiguration 
    {
        /// <summary>
        /// 指定私有hook生效的目标资源栈，有效值为NONE或ALL。  NONE：指定此私有hook不会作用于任何资源栈 ALL：指定此私有hook将会应用于账号下的所有资源栈
        /// </summary>
        /// <value>指定私有hook生效的目标资源栈，有效值为NONE或ALL。  NONE：指定此私有hook不会作用于任何资源栈 ALL：指定此私有hook将会应用于账号下的所有资源栈</value>
        [JsonConverter(typeof(EnumClassConverter<TargetStacksEnum>))]
        public class TargetStacksEnum
        {
            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            public static readonly TargetStacksEnum NONE = new TargetStacksEnum("NONE");

            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly TargetStacksEnum ALL = new TargetStacksEnum("ALL");

            private static readonly Dictionary<string, TargetStacksEnum> StaticFields =
            new Dictionary<string, TargetStacksEnum>()
            {
                { "NONE", NONE },
                { "ALL", ALL },
            };

            private string _value;

            public TargetStacksEnum()
            {

            }

            public TargetStacksEnum(string value)
            {
                _value = value;
            }

            public static TargetStacksEnum FromValue(string value)
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

                if (this.Equals(obj as TargetStacksEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TargetStacksEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TargetStacksEnum a, TargetStacksEnum b)
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

            public static bool operator !=(TargetStacksEnum a, TargetStacksEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 指定私有hook校验失败后的行为，有效值为FAIL或WARN。  FAIL：指定此私有hook校验失败后资源栈将停止部署，资源栈状态将更新为DEPLOYMENT_FAILED。 WARN：指定此私有hook校验失败后仅通过资源栈事件展示警告消息，但不影响资源栈部署。
        /// </summary>
        /// <value>指定私有hook校验失败后的行为，有效值为FAIL或WARN。  FAIL：指定此私有hook校验失败后资源栈将停止部署，资源栈状态将更新为DEPLOYMENT_FAILED。 WARN：指定此私有hook校验失败后仅通过资源栈事件展示警告消息，但不影响资源栈部署。</value>
        [JsonConverter(typeof(EnumClassConverter<FailureModeEnum>))]
        public class FailureModeEnum
        {
            /// <summary>
            /// Enum WARN for value: WARN
            /// </summary>
            public static readonly FailureModeEnum WARN = new FailureModeEnum("WARN");

            /// <summary>
            /// Enum FAIL for value: FAIL
            /// </summary>
            public static readonly FailureModeEnum FAIL = new FailureModeEnum("FAIL");

            private static readonly Dictionary<string, FailureModeEnum> StaticFields =
            new Dictionary<string, FailureModeEnum>()
            {
                { "WARN", WARN },
                { "FAIL", FAIL },
            };

            private string _value;

            public FailureModeEnum()
            {

            }

            public FailureModeEnum(string value)
            {
                _value = value;
            }

            public static FailureModeEnum FromValue(string value)
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

                if (this.Equals(obj as FailureModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FailureModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FailureModeEnum a, FailureModeEnum b)
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

            public static bool operator !=(FailureModeEnum a, FailureModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 指定私有hook生效的目标资源栈，有效值为NONE或ALL。  NONE：指定此私有hook不会作用于任何资源栈 ALL：指定此私有hook将会应用于账号下的所有资源栈
        /// </summary>
        [JsonProperty("target_stacks", NullValueHandling = NullValueHandling.Ignore)]
        public TargetStacksEnum TargetStacks { get; set; }
        /// <summary>
        /// 指定私有hook校验失败后的行为，有效值为FAIL或WARN。  FAIL：指定此私有hook校验失败后资源栈将停止部署，资源栈状态将更新为DEPLOYMENT_FAILED。 WARN：指定此私有hook校验失败后仅通过资源栈事件展示警告消息，但不影响资源栈部署。
        /// </summary>
        [JsonProperty("failure_mode", NullValueHandling = NullValueHandling.Ignore)]
        public FailureModeEnum FailureMode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationPrimitiveTypeHolderConfiguration {\n");
            sb.Append("  targetStacks: ").Append(TargetStacks).Append("\n");
            sb.Append("  failureMode: ").Append(FailureMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigurationPrimitiveTypeHolderConfiguration);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigurationPrimitiveTypeHolderConfiguration input)
        {
            if (input == null) return false;
            if (this.TargetStacks != input.TargetStacks) return false;
            if (this.FailureMode != input.FailureMode) return false;

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
                hashCode = hashCode * 59 + this.TargetStacks.GetHashCode();
                hashCode = hashCode * 59 + this.FailureMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
