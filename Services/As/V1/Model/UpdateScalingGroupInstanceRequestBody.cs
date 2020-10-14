using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 批量操作实例
    /// </summary>
    public class UpdateScalingGroupInstanceRequestBody 
    {
        /// <summary>
        /// 批量操作实例action标识：添加：ADD  移除： REMOVE  设置实例保护： PROTECT  取消实例保护： UNPROTECT；转入备用状态：ENTER_STANDBY 移出备用状态:EXIT_STANDBY
        /// </summary>
        /// <value>批量操作实例action标识：添加：ADD  移除： REMOVE  设置实例保护： PROTECT  取消实例保护： UNPROTECT；转入备用状态：ENTER_STANDBY 移出备用状态:EXIT_STANDBY</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum ADD for value: ADD
            /// </summary>
            public static readonly ActionEnum ADD = new ActionEnum("ADD");

            /// <summary>
            /// Enum REMOVE for value: REMOVE
            /// </summary>
            public static readonly ActionEnum REMOVE = new ActionEnum("REMOVE");

            /// <summary>
            /// Enum PROTECT for value: PROTECT
            /// </summary>
            public static readonly ActionEnum PROTECT = new ActionEnum("PROTECT");

            /// <summary>
            /// Enum UNPROTECT for value: UNPROTECT
            /// </summary>
            public static readonly ActionEnum UNPROTECT = new ActionEnum("UNPROTECT");

            /// <summary>
            /// Enum ENTER_STANDBY for value: ENTER_STANDBY
            /// </summary>
            public static readonly ActionEnum ENTER_STANDBY = new ActionEnum("ENTER_STANDBY");

            /// <summary>
            /// Enum EXIT_STANDBY for value: EXIT_STANDBY
            /// </summary>
            public static readonly ActionEnum EXIT_STANDBY = new ActionEnum("EXIT_STANDBY");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "ADD", ADD },
                { "REMOVE", REMOVE },
                { "PROTECT", PROTECT },
                { "UNPROTECT", UNPROTECT },
                { "ENTER_STANDBY", ENTER_STANDBY },
                { "EXIT_STANDBY", EXIT_STANDBY },
            };

            private string Value;

            public ActionEnum(string value)
            {
                Value = value;
            }

            public static ActionEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 云服务器ID。
        /// </summary>
        [JsonProperty("instances_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstancesId { get; set; }

        /// <summary>
        /// 从伸缩组中移出实例时，是否删除云服务器。默认为no；可选值为yes或no。只有action为REMOVE时，这个字段才生效。
        /// </summary>
        [JsonProperty("instance_delete", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceDelete { get; set; }

        /// <summary>
        /// 批量操作实例action标识：添加：ADD  移除： REMOVE  设置实例保护： PROTECT  取消实例保护： UNPROTECT；转入备用状态：ENTER_STANDBY 移出备用状态:EXIT_STANDBY
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// 将实例移入备用状态时，是否补充新的云服务器。取值如下：no：不补充新的实例，默认情况为no。yes：补充新的实例。只有action为ENTER_STANDBY时，这个字段才生效。
        /// </summary>
        [JsonProperty("instance_append", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceAppend { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateScalingGroupInstanceRequestBody {\n");
            sb.Append("  instancesId: ").Append(InstancesId).Append("\n");
            sb.Append("  instanceDelete: ").Append(InstanceDelete).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  instanceAppend: ").Append(InstanceAppend).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateScalingGroupInstanceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateScalingGroupInstanceRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstancesId == input.InstancesId ||
                    this.InstancesId != null &&
                    input.InstancesId != null &&
                    this.InstancesId.SequenceEqual(input.InstancesId)
                ) && 
                (
                    this.InstanceDelete == input.InstanceDelete ||
                    (this.InstanceDelete != null &&
                    this.InstanceDelete.Equals(input.InstanceDelete))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.InstanceAppend == input.InstanceAppend ||
                    (this.InstanceAppend != null &&
                    this.InstanceAppend.Equals(input.InstanceAppend))
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
                if (this.InstancesId != null)
                    hashCode = hashCode * 59 + this.InstancesId.GetHashCode();
                if (this.InstanceDelete != null)
                    hashCode = hashCode * 59 + this.InstanceDelete.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.InstanceAppend != null)
                    hashCode = hashCode * 59 + this.InstanceAppend.GetHashCode();
                return hashCode;
            }
        }
    }
}
