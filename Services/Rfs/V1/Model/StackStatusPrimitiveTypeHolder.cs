using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rfs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StackStatusPrimitiveTypeHolder 
    {
        /// <summary>
        /// 资源栈的状态 * &#x60;CREATION_COMPLETE&#x60; - 生成空资源栈完成，并没有任何部署 * &#x60;DEPLOYMENT_IN_PROGRESS&#x60; - 正在部署，请等待 * &#x60;DEPLOYMENT_FAILED&#x60; - 部署失败。请从status_message获取错误信息汇总，或者调用ListStackEvents获得事件详情 * &#x60;DEPLOYMENT_COMPLETE&#x60; - 部署完成 * &#x60;ROLLBACK_IN_PROGRESS&#x60; - 部署失败，正在回滚，请等待 * &#x60;ROLLBACK_FAILED&#x60; - 回滚失败。请从status_message获取错误信息汇总，或者调用ListStackEvents获得事件详情 * &#x60;ROLLBACK_COMPLETE&#x60; - 回滚完成 * &#x60;DELETION_IN_PROGRESS&#x60; - 正在删除，请等待 * &#x60;DELETION_FAILED&#x60; - 删除失败。请从status_message获取错误信息汇总，或者调用ListStackEvents获得事件详情
        /// </summary>
        /// <value>资源栈的状态 * &#x60;CREATION_COMPLETE&#x60; - 生成空资源栈完成，并没有任何部署 * &#x60;DEPLOYMENT_IN_PROGRESS&#x60; - 正在部署，请等待 * &#x60;DEPLOYMENT_FAILED&#x60; - 部署失败。请从status_message获取错误信息汇总，或者调用ListStackEvents获得事件详情 * &#x60;DEPLOYMENT_COMPLETE&#x60; - 部署完成 * &#x60;ROLLBACK_IN_PROGRESS&#x60; - 部署失败，正在回滚，请等待 * &#x60;ROLLBACK_FAILED&#x60; - 回滚失败。请从status_message获取错误信息汇总，或者调用ListStackEvents获得事件详情 * &#x60;ROLLBACK_COMPLETE&#x60; - 回滚完成 * &#x60;DELETION_IN_PROGRESS&#x60; - 正在删除，请等待 * &#x60;DELETION_FAILED&#x60; - 删除失败。请从status_message获取错误信息汇总，或者调用ListStackEvents获得事件详情</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum CREATION_COMPLETE for value: CREATION_COMPLETE
            /// </summary>
            public static readonly StatusEnum CREATION_COMPLETE = new StatusEnum("CREATION_COMPLETE");

            /// <summary>
            /// Enum DEPLOYMENT_IN_PROGRESS for value: DEPLOYMENT_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum DEPLOYMENT_IN_PROGRESS = new StatusEnum("DEPLOYMENT_IN_PROGRESS");

            /// <summary>
            /// Enum DEPLOYMENT_FAILED for value: DEPLOYMENT_FAILED
            /// </summary>
            public static readonly StatusEnum DEPLOYMENT_FAILED = new StatusEnum("DEPLOYMENT_FAILED");

            /// <summary>
            /// Enum DEPLOYMENT_COMPLETE for value: DEPLOYMENT_COMPLETE
            /// </summary>
            public static readonly StatusEnum DEPLOYMENT_COMPLETE = new StatusEnum("DEPLOYMENT_COMPLETE");

            /// <summary>
            /// Enum ROLLBACK_IN_PROGRESS for value: ROLLBACK_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum ROLLBACK_IN_PROGRESS = new StatusEnum("ROLLBACK_IN_PROGRESS");

            /// <summary>
            /// Enum ROLLBACK_FAILED for value: ROLLBACK_FAILED
            /// </summary>
            public static readonly StatusEnum ROLLBACK_FAILED = new StatusEnum("ROLLBACK_FAILED");

            /// <summary>
            /// Enum ROLLBACK_COMPLETE for value: ROLLBACK_COMPLETE
            /// </summary>
            public static readonly StatusEnum ROLLBACK_COMPLETE = new StatusEnum("ROLLBACK_COMPLETE");

            /// <summary>
            /// Enum DELETION_IN_PROGRESS for value: DELETION_IN_PROGRESS
            /// </summary>
            public static readonly StatusEnum DELETION_IN_PROGRESS = new StatusEnum("DELETION_IN_PROGRESS");

            /// <summary>
            /// Enum DELETION_FAILED for value: DELETION_FAILED
            /// </summary>
            public static readonly StatusEnum DELETION_FAILED = new StatusEnum("DELETION_FAILED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "CREATION_COMPLETE", CREATION_COMPLETE },
                { "DEPLOYMENT_IN_PROGRESS", DEPLOYMENT_IN_PROGRESS },
                { "DEPLOYMENT_FAILED", DEPLOYMENT_FAILED },
                { "DEPLOYMENT_COMPLETE", DEPLOYMENT_COMPLETE },
                { "ROLLBACK_IN_PROGRESS", ROLLBACK_IN_PROGRESS },
                { "ROLLBACK_FAILED", ROLLBACK_FAILED },
                { "ROLLBACK_COMPLETE", ROLLBACK_COMPLETE },
                { "DELETION_IN_PROGRESS", DELETION_IN_PROGRESS },
                { "DELETION_FAILED", DELETION_FAILED },
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
        /// 资源栈的状态 * &#x60;CREATION_COMPLETE&#x60; - 生成空资源栈完成，并没有任何部署 * &#x60;DEPLOYMENT_IN_PROGRESS&#x60; - 正在部署，请等待 * &#x60;DEPLOYMENT_FAILED&#x60; - 部署失败。请从status_message获取错误信息汇总，或者调用ListStackEvents获得事件详情 * &#x60;DEPLOYMENT_COMPLETE&#x60; - 部署完成 * &#x60;ROLLBACK_IN_PROGRESS&#x60; - 部署失败，正在回滚，请等待 * &#x60;ROLLBACK_FAILED&#x60; - 回滚失败。请从status_message获取错误信息汇总，或者调用ListStackEvents获得事件详情 * &#x60;ROLLBACK_COMPLETE&#x60; - 回滚完成 * &#x60;DELETION_IN_PROGRESS&#x60; - 正在删除，请等待 * &#x60;DELETION_FAILED&#x60; - 删除失败。请从status_message获取错误信息汇总，或者调用ListStackEvents获得事件详情
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StackStatusPrimitiveTypeHolder {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StackStatusPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StackStatusPrimitiveTypeHolder input)
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
