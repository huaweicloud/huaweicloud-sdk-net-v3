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
    public class StackSetOperationStatusPrimitiveTypeHolder 
    {
        /// <summary>
        /// 资源栈集操作状态   * &#x60;QUEUE_IN_PROGRESS&#x60; - 正在排队   * &#x60;OPERATION_IN_PROGRESS&#x60; - 正在操作   * &#x60;OPERATION_COMPLETE&#x60; - 操作完成   * &#x60;OPERATION_FAILED&#x60; - 操作失败   * &#x60;STOP_IN_PROGRESS&#x60; - 正在停止   * &#x60;STOP_COMPLETE&#x60; - 停止完成   * &#x60;STOP_FAILED&#x60; - 停止失败
        /// </summary>
        /// <value>资源栈集操作状态   * &#x60;QUEUE_IN_PROGRESS&#x60; - 正在排队   * &#x60;OPERATION_IN_PROGRESS&#x60; - 正在操作   * &#x60;OPERATION_COMPLETE&#x60; - 操作完成   * &#x60;OPERATION_FAILED&#x60; - 操作失败   * &#x60;STOP_IN_PROGRESS&#x60; - 正在停止   * &#x60;STOP_COMPLETE&#x60; - 停止完成   * &#x60;STOP_FAILED&#x60; - 停止失败</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum QUEUE_IN_PROGRESS for value: QUEUE_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum QUEUE_IN_PROGRESS = new StatusEnum("QUEUE_IN_PROGRESS");

            /// <summary>
            /// Enum OPERATION_IN_PROGRESS for value: OPERATION_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum OPERATION_IN_PROGRESS = new StatusEnum("OPERATION_IN_PROGRESS");

            /// <summary>
            /// Enum OPERATION_COMPLETE for value: OPERATION_COMPLETE
            /// </summary>
            public static readonly StatusEnum OPERATION_COMPLETE = new StatusEnum("OPERATION_COMPLETE");

            /// <summary>
            /// Enum OPERATION_FAILED for value: OPERATION_FAILED
            /// </summary>
            public static readonly StatusEnum OPERATION_FAILED = new StatusEnum("OPERATION_FAILED");

            /// <summary>
            /// Enum STOP_IN_PROGRESS for value: STOP_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum STOP_IN_PROGRESS = new StatusEnum("STOP_IN_PROGRESS");

            /// <summary>
            /// Enum STOP_COMPLETE for value: STOP_COMPLETE
            /// </summary>
            public static readonly StatusEnum STOP_COMPLETE = new StatusEnum("STOP_COMPLETE");

            /// <summary>
            /// Enum STOP_FAILED for value: STOP_FAILED
            /// </summary>
            public static readonly StatusEnum STOP_FAILED = new StatusEnum("STOP_FAILED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "QUEUE_IN_PROGRESS", QUEUE_IN_PROGRESS },
                { "OPERATION_IN_PROGRESS", OPERATION_IN_PROGRESS },
                { "OPERATION_COMPLETE", OPERATION_COMPLETE },
                { "OPERATION_FAILED", OPERATION_FAILED },
                { "STOP_IN_PROGRESS", STOP_IN_PROGRESS },
                { "STOP_COMPLETE", STOP_COMPLETE },
                { "STOP_FAILED", STOP_FAILED },
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
        /// 资源栈集操作状态   * &#x60;QUEUE_IN_PROGRESS&#x60; - 正在排队   * &#x60;OPERATION_IN_PROGRESS&#x60; - 正在操作   * &#x60;OPERATION_COMPLETE&#x60; - 操作完成   * &#x60;OPERATION_FAILED&#x60; - 操作失败   * &#x60;STOP_IN_PROGRESS&#x60; - 正在停止   * &#x60;STOP_COMPLETE&#x60; - 停止完成   * &#x60;STOP_FAILED&#x60; - 停止失败
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StackSetOperationStatusPrimitiveTypeHolder {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StackSetOperationStatusPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StackSetOperationStatusPrimitiveTypeHolder input)
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
