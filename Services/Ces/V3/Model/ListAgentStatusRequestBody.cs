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
    /// 
    /// </summary>
    public class ListAgentStatusRequestBody 
    {
        /// <summary>
        /// **参数解释**: uniagent运行状态，不传值则查出所有状态 **约束限制**: 不涉及。 **取值范围**: - none: 未安装 - running: 运行中 - silent: 静默状态，用于大规模插件异常时，紧急规避的一种措施，现象是kill掉telescope，只保留uniagent的心跳功能 - unknown: 心跳故障，不上报心跳数据，属于连接丢失故障 **默认取值**: 不涉及 
        /// </summary>
        /// <value>**参数解释**: uniagent运行状态，不传值则查出所有状态 **约束限制**: 不涉及。 **取值范围**: - none: 未安装 - running: 运行中 - silent: 静默状态，用于大规模插件异常时，紧急规避的一种措施，现象是kill掉telescope，只保留uniagent的心跳功能 - unknown: 心跳故障，不上报心跳数据，属于连接丢失故障 **默认取值**: 不涉及 </value>
        [JsonConverter(typeof(EnumClassConverter<UniagentStatusEnum>))]
        public class UniagentStatusEnum
        {
            /// <summary>
            /// Enum NONE for value: none
            /// </summary>
            public static readonly UniagentStatusEnum NONE = new UniagentStatusEnum("none");

            /// <summary>
            /// Enum RUNNING for value: running
            /// </summary>
            public static readonly UniagentStatusEnum RUNNING = new UniagentStatusEnum("running");

            /// <summary>
            /// Enum SILENT for value: silent
            /// </summary>
            public static readonly UniagentStatusEnum SILENT = new UniagentStatusEnum("silent");

            /// <summary>
            /// Enum UNKNOWN for value: unknown
            /// </summary>
            public static readonly UniagentStatusEnum UNKNOWN = new UniagentStatusEnum("unknown");

            private static readonly Dictionary<string, UniagentStatusEnum> StaticFields =
            new Dictionary<string, UniagentStatusEnum>()
            {
                { "none", NONE },
                { "running", RUNNING },
                { "silent", SILENT },
                { "unknown", UNKNOWN },
            };

            private string _value;

            public UniagentStatusEnum()
            {

            }

            public UniagentStatusEnum(string value)
            {
                _value = value;
            }

            public static UniagentStatusEnum FromValue(string value)
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

                if (this.Equals(obj as UniagentStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UniagentStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UniagentStatusEnum a, UniagentStatusEnum b)
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

            public static bool operator !=(UniagentStatusEnum a, UniagentStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**: 插件名称，不传查所有插件 **约束限制**: 当前仅支持查询telescope插件 **取值范围**: - telescope: 主机监控插件telescope **默认取值**: telescope 
        /// </summary>
        /// <value>**参数解释**: 插件名称，不传查所有插件 **约束限制**: 当前仅支持查询telescope插件 **取值范围**: - telescope: 主机监控插件telescope **默认取值**: telescope </value>
        [JsonConverter(typeof(EnumClassConverter<ExtensionNameEnum>))]
        public class ExtensionNameEnum
        {
            /// <summary>
            /// Enum TELESCOPE for value: telescope
            /// </summary>
            public static readonly ExtensionNameEnum TELESCOPE = new ExtensionNameEnum("telescope");

            private static readonly Dictionary<string, ExtensionNameEnum> StaticFields =
            new Dictionary<string, ExtensionNameEnum>()
            {
                { "telescope", TELESCOPE },
            };

            private string _value;

            public ExtensionNameEnum()
            {

            }

            public ExtensionNameEnum(string value)
            {
                _value = value;
            }

            public static ExtensionNameEnum FromValue(string value)
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

                if (this.Equals(obj as ExtensionNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ExtensionNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ExtensionNameEnum a, ExtensionNameEnum b)
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

            public static bool operator !=(ExtensionNameEnum a, ExtensionNameEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**: 插件状态，不传查所有状态  **约束限制**: 不涉及 **取值范围**: - none: 未安装 - running: 运行中 - stopped：已停止 - fault: 进程故障，应该运行的插件，没运行，属于客户端故障 - unknown: 心跳故障，不上报心跳数据，属于连接丢失故障 **默认取值**: 不涉及 
        /// </summary>
        /// <value>**参数解释**: 插件状态，不传查所有状态  **约束限制**: 不涉及 **取值范围**: - none: 未安装 - running: 运行中 - stopped：已停止 - fault: 进程故障，应该运行的插件，没运行，属于客户端故障 - unknown: 心跳故障，不上报心跳数据，属于连接丢失故障 **默认取值**: 不涉及 </value>
        [JsonConverter(typeof(EnumClassConverter<ExtensionStatusEnum>))]
        public class ExtensionStatusEnum
        {
            /// <summary>
            /// Enum NONE for value: none
            /// </summary>
            public static readonly ExtensionStatusEnum NONE = new ExtensionStatusEnum("none");

            /// <summary>
            /// Enum RUNNING for value: running
            /// </summary>
            public static readonly ExtensionStatusEnum RUNNING = new ExtensionStatusEnum("running");

            /// <summary>
            /// Enum STOPPED for value: stopped
            /// </summary>
            public static readonly ExtensionStatusEnum STOPPED = new ExtensionStatusEnum("stopped");

            /// <summary>
            /// Enum FAULT for value: fault
            /// </summary>
            public static readonly ExtensionStatusEnum FAULT = new ExtensionStatusEnum("fault");

            /// <summary>
            /// Enum UNKNOWN for value: unknown
            /// </summary>
            public static readonly ExtensionStatusEnum UNKNOWN = new ExtensionStatusEnum("unknown");

            private static readonly Dictionary<string, ExtensionStatusEnum> StaticFields =
            new Dictionary<string, ExtensionStatusEnum>()
            {
                { "none", NONE },
                { "running", RUNNING },
                { "stopped", STOPPED },
                { "fault", FAULT },
                { "unknown", UNKNOWN },
            };

            private string _value;

            public ExtensionStatusEnum()
            {

            }

            public ExtensionStatusEnum(string value)
            {
                _value = value;
            }

            public static ExtensionStatusEnum FromValue(string value)
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

                if (this.Equals(obj as ExtensionStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ExtensionStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ExtensionStatusEnum a, ExtensionStatusEnum b)
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

            public static bool operator !=(ExtensionStatusEnum a, ExtensionStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: 机器实例id列表 **约束限制**: 包含的机器实例id最多为2000个，最少为1个 
        /// </summary>
        [JsonProperty("instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// **参数解释**: uniagent运行状态，不传值则查出所有状态 **约束限制**: 不涉及。 **取值范围**: - none: 未安装 - running: 运行中 - silent: 静默状态，用于大规模插件异常时，紧急规避的一种措施，现象是kill掉telescope，只保留uniagent的心跳功能 - unknown: 心跳故障，不上报心跳数据，属于连接丢失故障 **默认取值**: 不涉及 
        /// </summary>
        [JsonProperty("uniagent_status", NullValueHandling = NullValueHandling.Ignore)]
        public UniagentStatusEnum UniagentStatus { get; set; }
        /// <summary>
        /// **参数解释**: 插件名称，不传查所有插件 **约束限制**: 当前仅支持查询telescope插件 **取值范围**: - telescope: 主机监控插件telescope **默认取值**: telescope 
        /// </summary>
        [JsonProperty("extension_name", NullValueHandling = NullValueHandling.Ignore)]
        public ExtensionNameEnum ExtensionName { get; set; }
        /// <summary>
        /// **参数解释**: 插件状态，不传查所有状态  **约束限制**: 不涉及 **取值范围**: - none: 未安装 - running: 运行中 - stopped：已停止 - fault: 进程故障，应该运行的插件，没运行，属于客户端故障 - unknown: 心跳故障，不上报心跳数据，属于连接丢失故障 **默认取值**: 不涉及 
        /// </summary>
        [JsonProperty("extension_status", NullValueHandling = NullValueHandling.Ignore)]
        public ExtensionStatusEnum ExtensionStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAgentStatusRequestBody {\n");
            sb.Append("  instanceIds: ").Append(InstanceIds).Append("\n");
            sb.Append("  uniagentStatus: ").Append(UniagentStatus).Append("\n");
            sb.Append("  extensionName: ").Append(ExtensionName).Append("\n");
            sb.Append("  extensionStatus: ").Append(ExtensionStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAgentStatusRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAgentStatusRequestBody input)
        {
            if (input == null) return false;
            if (this.InstanceIds != input.InstanceIds || (this.InstanceIds != null && input.InstanceIds != null && !this.InstanceIds.SequenceEqual(input.InstanceIds))) return false;
            if (this.UniagentStatus != input.UniagentStatus) return false;
            if (this.ExtensionName != input.ExtensionName) return false;
            if (this.ExtensionStatus != input.ExtensionStatus) return false;

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
                if (this.InstanceIds != null) hashCode = hashCode * 59 + this.InstanceIds.GetHashCode();
                hashCode = hashCode * 59 + this.UniagentStatus.GetHashCode();
                hashCode = hashCode * 59 + this.ExtensionName.GetHashCode();
                hashCode = hashCode * 59 + this.ExtensionStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
