using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListAgentInvocationsRequest 
    {
        /// <summary>
        /// **参数解释**: 主机类型，仅支持ECS弹性云服务器和BMS裸金属服务器 **约束限制**: 不涉及 **取值范围**: - ECS: 弹性云服务器 - BMS：裸金属服务器 **默认取值**: 不涉及 
        /// </summary>
        /// <value>**参数解释**: 主机类型，仅支持ECS弹性云服务器和BMS裸金属服务器 **约束限制**: 不涉及 **取值范围**: - ECS: 弹性云服务器 - BMS：裸金属服务器 **默认取值**: 不涉及 </value>
        [JsonConverter(typeof(EnumClassConverter<InstanceTypeEnum>))]
        public class InstanceTypeEnum
        {
            /// <summary>
            /// Enum ECS for value: ECS
            /// </summary>
            public static readonly InstanceTypeEnum ECS = new InstanceTypeEnum("ECS");

            /// <summary>
            /// Enum BMS for value: BMS
            /// </summary>
            public static readonly InstanceTypeEnum BMS = new InstanceTypeEnum("BMS");

            private static readonly Dictionary<string, InstanceTypeEnum> StaticFields =
            new Dictionary<string, InstanceTypeEnum>()
            {
                { "ECS", ECS },
                { "BMS", BMS },
            };

            private string _value;

            public InstanceTypeEnum()
            {

            }

            public InstanceTypeEnum(string value)
            {
                _value = value;
            }

            public static InstanceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as InstanceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InstanceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InstanceTypeEnum a, InstanceTypeEnum b)
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

            public static bool operator !=(InstanceTypeEnum a, InstanceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**: 任务类型, 仅包含：INSTALL安装, UPDATE升级, ROLLBACK回退，RETRY重试，SET_REMOTE_INSTALLER设置远程安装主机，REMOTE_INSTALL执行远程安装。 **约束限制**: 不涉及。 **取值范围**: - INSTALL：安装 - UPDATE：升级 - ROLLBACK：回退 - RETRY：重试 - SET_REMOTE_INSTALLER：设置远程安装主机 - REMOTE_INSTALL：执行远程安装 **默认取值**: 不涉及 
        /// </summary>
        /// <value>**参数解释**: 任务类型, 仅包含：INSTALL安装, UPDATE升级, ROLLBACK回退，RETRY重试，SET_REMOTE_INSTALLER设置远程安装主机，REMOTE_INSTALL执行远程安装。 **约束限制**: 不涉及。 **取值范围**: - INSTALL：安装 - UPDATE：升级 - ROLLBACK：回退 - RETRY：重试 - SET_REMOTE_INSTALLER：设置远程安装主机 - REMOTE_INSTALL：执行远程安装 **默认取值**: 不涉及 </value>
        [JsonConverter(typeof(EnumClassConverter<InvocationTypeEnum>))]
        public class InvocationTypeEnum
        {
            /// <summary>
            /// Enum INSTALL for value: INSTALL
            /// </summary>
            public static readonly InvocationTypeEnum INSTALL = new InvocationTypeEnum("INSTALL");

            /// <summary>
            /// Enum UPDATE for value: UPDATE
            /// </summary>
            public static readonly InvocationTypeEnum UPDATE = new InvocationTypeEnum("UPDATE");

            /// <summary>
            /// Enum ROLLBACK for value: ROLLBACK
            /// </summary>
            public static readonly InvocationTypeEnum ROLLBACK = new InvocationTypeEnum("ROLLBACK");

            /// <summary>
            /// Enum RETRY for value: RETRY
            /// </summary>
            public static readonly InvocationTypeEnum RETRY = new InvocationTypeEnum("RETRY");

            /// <summary>
            /// Enum SET_REMOTE_INSTALLER for value: SET_REMOTE_INSTALLER
            /// </summary>
            public static readonly InvocationTypeEnum SET_REMOTE_INSTALLER = new InvocationTypeEnum("SET_REMOTE_INSTALLER");

            /// <summary>
            /// Enum REMOTE_INSTALL for value: REMOTE_INSTALL
            /// </summary>
            public static readonly InvocationTypeEnum REMOTE_INSTALL = new InvocationTypeEnum("REMOTE_INSTALL");

            private static readonly Dictionary<string, InvocationTypeEnum> StaticFields =
            new Dictionary<string, InvocationTypeEnum>()
            {
                { "INSTALL", INSTALL },
                { "UPDATE", UPDATE },
                { "ROLLBACK", ROLLBACK },
                { "RETRY", RETRY },
                { "SET_REMOTE_INSTALLER", SET_REMOTE_INSTALLER },
                { "REMOTE_INSTALL", REMOTE_INSTALL },
            };

            private string _value;

            public InvocationTypeEnum()
            {

            }

            public InvocationTypeEnum(string value)
            {
                _value = value;
            }

            public static InvocationTypeEnum FromValue(string value)
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

                if (this.Equals(obj as InvocationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InvocationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InvocationTypeEnum a, InvocationTypeEnum b)
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

            public static bool operator !=(InvocationTypeEnum a, InvocationTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**: 任务对象, 支持telescope监控 **约束限制**: 不涉及。 **取值范围**: - telescope: 主机监控插件telescope **默认取值**: telescope。 
        /// </summary>
        /// <value>**参数解释**: 任务对象, 支持telescope监控 **约束限制**: 不涉及。 **取值范围**: - telescope: 主机监控插件telescope **默认取值**: telescope。 </value>
        [JsonConverter(typeof(EnumClassConverter<InvocationTargetEnum>))]
        public class InvocationTargetEnum
        {
            /// <summary>
            /// Enum TELESCOPE for value: telescope
            /// </summary>
            public static readonly InvocationTargetEnum TELESCOPE = new InvocationTargetEnum("telescope");

            private static readonly Dictionary<string, InvocationTargetEnum> StaticFields =
            new Dictionary<string, InvocationTargetEnum>()
            {
                { "telescope", TELESCOPE },
            };

            private string _value;

            public InvocationTargetEnum()
            {

            }

            public InvocationTargetEnum(string value)
            {
                _value = value;
            }

            public static InvocationTargetEnum FromValue(string value)
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

                if (this.Equals(obj as InvocationTargetEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InvocationTargetEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InvocationTargetEnum a, InvocationTargetEnum b)
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

            public static bool operator !=(InvocationTargetEnum a, InvocationTargetEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: 主机id **约束限制**: 不涉及 **取值范围**: 1到64个字符的字符串，且只包含字母、数字和连字符 **默认取值**: 不涉及 
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**: 主机类型，仅支持ECS弹性云服务器和BMS裸金属服务器 **约束限制**: 不涉及 **取值范围**: - ECS: 弹性云服务器 - BMS：裸金属服务器 **默认取值**: 不涉及 
        /// </summary>
        [SDKProperty("instance_type", IsQuery = true)]
        [JsonProperty("instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceTypeEnum InstanceType { get; set; }
        /// <summary>
        /// **参数解释**: 任务id **约束限制**: 不涉及 **取值范围**: 以字母或数字开头，后续可包含字母、数字、下划线或连字符的字符串，长度至少为 1 **默认取值**: 不涉及 
        /// </summary>
        [SDKProperty("invocation_id", IsQuery = true)]
        [JsonProperty("invocation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InvocationId { get; set; }

        /// <summary>
        /// **参数解释**: 任务类型, 仅包含：INSTALL安装, UPDATE升级, ROLLBACK回退，RETRY重试，SET_REMOTE_INSTALLER设置远程安装主机，REMOTE_INSTALL执行远程安装。 **约束限制**: 不涉及。 **取值范围**: - INSTALL：安装 - UPDATE：升级 - ROLLBACK：回退 - RETRY：重试 - SET_REMOTE_INSTALLER：设置远程安装主机 - REMOTE_INSTALL：执行远程安装 **默认取值**: 不涉及 
        /// </summary>
        [SDKProperty("invocation_type", IsQuery = true)]
        [JsonProperty("invocation_type", NullValueHandling = NullValueHandling.Ignore)]
        public InvocationTypeEnum InvocationType { get; set; }
        /// <summary>
        /// **参数解释**: 任务对象, 支持telescope监控 **约束限制**: 不涉及。 **取值范围**: - telescope: 主机监控插件telescope **默认取值**: telescope。 
        /// </summary>
        [SDKProperty("invocation_target", IsQuery = true)]
        [JsonProperty("invocation_target", NullValueHandling = NullValueHandling.Ignore)]
        public InvocationTargetEnum InvocationTarget { get; set; }
        /// <summary>
        /// **参数解释**: 分页偏移量 **约束限制**: 不涉及 **取值范围**: 数字范围为[0,9999999999999] **默认取值**: 0 
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public long? Offset { get; set; }

        /// <summary>
        /// **参数解释**: 分页大小。 **约束限制**: 不涉及。 **取值范围**: 数字范围为[1,100] **默认取值**: 100 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAgentInvocationsRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceType: ").Append(InstanceType).Append("\n");
            sb.Append("  invocationId: ").Append(InvocationId).Append("\n");
            sb.Append("  invocationType: ").Append(InvocationType).Append("\n");
            sb.Append("  invocationTarget: ").Append(InvocationTarget).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAgentInvocationsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAgentInvocationsRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceType != input.InstanceType) return false;
            if (this.InvocationId != input.InvocationId || (this.InvocationId != null && !this.InvocationId.Equals(input.InvocationId))) return false;
            if (this.InvocationType != input.InvocationType) return false;
            if (this.InvocationTarget != input.InvocationTarget) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                if (this.InvocationId != null) hashCode = hashCode * 59 + this.InvocationId.GetHashCode();
                hashCode = hashCode * 59 + this.InvocationType.GetHashCode();
                hashCode = hashCode * 59 + this.InvocationTarget.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
