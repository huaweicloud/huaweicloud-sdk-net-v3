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
    public class ExecutionPlanStatusPrimitiveTypeHolder 
    {
        /// <summary>
        /// 执行计划的状态     * &#x60;CREATION_IN_PROGRESS&#x60; - 正在创建，请等待     * &#x60;CREATION_FAILED&#x60; - 创建失败，请从status_message获取错误信息汇总     * &#x60;AVAILABLE&#x60; - 创建完成，可以调用ApplyExecutionPlan API进行执行     * &#x60;APPLY_IN_PROGRESS&#x60; - 执行中，可通过GetStackMetadata查询资源栈状态，通过ListStackEvents获取执行过程中产生的资源栈事件     * &#x60;APPLIED&#x60; - 已执行
        /// </summary>
        /// <value>执行计划的状态     * &#x60;CREATION_IN_PROGRESS&#x60; - 正在创建，请等待     * &#x60;CREATION_FAILED&#x60; - 创建失败，请从status_message获取错误信息汇总     * &#x60;AVAILABLE&#x60; - 创建完成，可以调用ApplyExecutionPlan API进行执行     * &#x60;APPLY_IN_PROGRESS&#x60; - 执行中，可通过GetStackMetadata查询资源栈状态，通过ListStackEvents获取执行过程中产生的资源栈事件     * &#x60;APPLIED&#x60; - 已执行</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum CREATION_IN_PROGRESS for value: CREATION_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum CREATION_IN_PROGRESS = new StatusEnum("CREATION_IN_PROGRESS");

            /// <summary>
            /// Enum CREATION_FAILED for value: CREATION_FAILED
            /// </summary>
            public static readonly StatusEnum CREATION_FAILED = new StatusEnum("CREATION_FAILED");

            /// <summary>
            /// Enum AVAILABLE for value: AVAILABLE
            /// </summary>
            public static readonly StatusEnum AVAILABLE = new StatusEnum("AVAILABLE");

            /// <summary>
            /// Enum APPLY_IN_PROGRESS for value: APPLY_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum APPLY_IN_PROGRESS = new StatusEnum("APPLY_IN_PROGRESS");

            /// <summary>
            /// Enum APPLIED for value: APPLIED
            /// </summary>
            public static readonly StatusEnum APPLIED = new StatusEnum("APPLIED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "CREATION_IN_PROGRESS", CREATION_IN_PROGRESS },
                { "CREATION_FAILED", CREATION_FAILED },
                { "AVAILABLE", AVAILABLE },
                { "APPLY_IN_PROGRESS", APPLY_IN_PROGRESS },
                { "APPLIED", APPLIED },
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 执行计划的状态     * &#x60;CREATION_IN_PROGRESS&#x60; - 正在创建，请等待     * &#x60;CREATION_FAILED&#x60; - 创建失败，请从status_message获取错误信息汇总     * &#x60;AVAILABLE&#x60; - 创建完成，可以调用ApplyExecutionPlan API进行执行     * &#x60;APPLY_IN_PROGRESS&#x60; - 执行中，可通过GetStackMetadata查询资源栈状态，通过ListStackEvents获取执行过程中产生的资源栈事件     * &#x60;APPLIED&#x60; - 已执行
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecutionPlanStatusPrimitiveTypeHolder {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecutionPlanStatusPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecutionPlanStatusPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
