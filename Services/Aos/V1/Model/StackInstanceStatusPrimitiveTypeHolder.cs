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
    public class StackInstanceStatusPrimitiveTypeHolder 
    {
        /// <summary>
        /// 资源栈实例的状态  * &#x60;WAIT_IN_PROGRESS&#x60; - 资源栈实例等待操作中 * &#x60;CANCEL_COMPLETE&#x60; - 资源栈实例操作取消完成 * &#x60;OPERATION_IN_PROGRESS&#x60; - 资源栈实例操作中 * &#x60;OPERATION_FAILED&#x60; - 资源栈实例操作失败 * &#x60;INOPERABLE&#x60; - 资源栈实例不可操作 * &#x60;OPERATION_COMPLETE&#x60; - 资源栈实例操作完成
        /// </summary>
        /// <value>资源栈实例的状态  * &#x60;WAIT_IN_PROGRESS&#x60; - 资源栈实例等待操作中 * &#x60;CANCEL_COMPLETE&#x60; - 资源栈实例操作取消完成 * &#x60;OPERATION_IN_PROGRESS&#x60; - 资源栈实例操作中 * &#x60;OPERATION_FAILED&#x60; - 资源栈实例操作失败 * &#x60;INOPERABLE&#x60; - 资源栈实例不可操作 * &#x60;OPERATION_COMPLETE&#x60; - 资源栈实例操作完成</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum WAIT_IN_PROGRESS for value: WAIT_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum WAIT_IN_PROGRESS = new StatusEnum("WAIT_IN_PROGRESS");

            /// <summary>
            /// Enum CANCEL_COMPLETE for value: CANCEL_COMPLETE
            /// </summary>
            public static readonly StatusEnum CANCEL_COMPLETE = new StatusEnum("CANCEL_COMPLETE");

            /// <summary>
            /// Enum OPERATION_IN_PROGRESS for value: OPERATION_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum OPERATION_IN_PROGRESS = new StatusEnum("OPERATION_IN_PROGRESS");

            /// <summary>
            /// Enum OPERATION_FAILED for value: OPERATION_FAILED
            /// </summary>
            public static readonly StatusEnum OPERATION_FAILED = new StatusEnum("OPERATION_FAILED");

            /// <summary>
            /// Enum INOPERABLE for value: INOPERABLE
            /// </summary>
            public static readonly StatusEnum INOPERABLE = new StatusEnum("INOPERABLE");

            /// <summary>
            /// Enum OPERATION_COMPLETE for value: OPERATION_COMPLETE
            /// </summary>
            public static readonly StatusEnum OPERATION_COMPLETE = new StatusEnum("OPERATION_COMPLETE");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "WAIT_IN_PROGRESS", WAIT_IN_PROGRESS },
                { "CANCEL_COMPLETE", CANCEL_COMPLETE },
                { "OPERATION_IN_PROGRESS", OPERATION_IN_PROGRESS },
                { "OPERATION_FAILED", OPERATION_FAILED },
                { "INOPERABLE", INOPERABLE },
                { "OPERATION_COMPLETE", OPERATION_COMPLETE },
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
        /// 资源栈实例的状态  * &#x60;WAIT_IN_PROGRESS&#x60; - 资源栈实例等待操作中 * &#x60;CANCEL_COMPLETE&#x60; - 资源栈实例操作取消完成 * &#x60;OPERATION_IN_PROGRESS&#x60; - 资源栈实例操作中 * &#x60;OPERATION_FAILED&#x60; - 资源栈实例操作失败 * &#x60;INOPERABLE&#x60; - 资源栈实例不可操作 * &#x60;OPERATION_COMPLETE&#x60; - 资源栈实例操作完成
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StackInstanceStatusPrimitiveTypeHolder {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StackInstanceStatusPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StackInstanceStatusPrimitiveTypeHolder input)
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
