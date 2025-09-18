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
    /// 
    /// </summary>
    public class StackSetStatusPrimitiveTypeHolder 
    {
        /// <summary>
        /// 资源栈集的状态     * &#x60;IDLE&#x60; - 资源栈集空闲 * &#x60;OPERATION_IN_PROGRESS&#x60; - 资源栈集操作中 * &#x60;DEACTIVATED&#x60; - 资源栈集禁用
        /// </summary>
        /// <value>资源栈集的状态     * &#x60;IDLE&#x60; - 资源栈集空闲 * &#x60;OPERATION_IN_PROGRESS&#x60; - 资源栈集操作中 * &#x60;DEACTIVATED&#x60; - 资源栈集禁用</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum IDLE for value: IDLE
            /// </summary>
            public static readonly StatusEnum IDLE = new StatusEnum("IDLE");

            /// <summary>
            /// Enum OPERATION_IN_PROGRESS for value: OPERATION_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum OPERATION_IN_PROGRESS = new StatusEnum("OPERATION_IN_PROGRESS");

            /// <summary>
            /// Enum DEACTIVATED for value: DEACTIVATED
            /// </summary>
            public static readonly StatusEnum DEACTIVATED = new StatusEnum("DEACTIVATED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "IDLE", IDLE },
                { "OPERATION_IN_PROGRESS", OPERATION_IN_PROGRESS },
                { "DEACTIVATED", DEACTIVATED },
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
        /// 资源栈集的状态     * &#x60;IDLE&#x60; - 资源栈集空闲 * &#x60;OPERATION_IN_PROGRESS&#x60; - 资源栈集操作中 * &#x60;DEACTIVATED&#x60; - 资源栈集禁用
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StackSetStatusPrimitiveTypeHolder {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StackSetStatusPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StackSetStatusPrimitiveTypeHolder input)
        {
            if (input == null) return false;
            if (this.Status != input.Status) return false;

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
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
