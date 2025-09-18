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
    public class AgentStatusInfo 
    {
        /// <summary>
        /// **参数解释**: uniagent运行状态 **取值范围**: - none: 未安装 - running: 运行中 - silent: 静默状态，用于大规模插件异常时，紧急规避的一种措施，现象是kill掉telescope，只保留uniagent的心跳功能 - unknown: 心跳故障，不上报心跳数据，属于连接丢失故障 
        /// </summary>
        /// <value>**参数解释**: uniagent运行状态 **取值范围**: - none: 未安装 - running: 运行中 - silent: 静默状态，用于大规模插件异常时，紧急规避的一种措施，现象是kill掉telescope，只保留uniagent的心跳功能 - unknown: 心跳故障，不上报心跳数据，属于连接丢失故障 </value>
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
        /// **参数解释**: 机器id **取值范围**: 1到64个字符的字符串，且只包含字母、数字和连字符 
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**: uniagent运行状态 **取值范围**: - none: 未安装 - running: 运行中 - silent: 静默状态，用于大规模插件异常时，紧急规避的一种措施，现象是kill掉telescope，只保留uniagent的心跳功能 - unknown: 心跳故障，不上报心跳数据，属于连接丢失故障 
        /// </summary>
        [JsonProperty("uniagent_status", NullValueHandling = NullValueHandling.Ignore)]
        public UniagentStatusEnum UniagentStatus { get; set; }
        /// <summary>
        /// **参数解释**: 插件信息列表 **取值范围**: 数组长度为[1,10] 
        /// </summary>
        [JsonProperty("extensions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtensionInfo> Extensions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentStatusInfo {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  uniagentStatus: ").Append(UniagentStatus).Append("\n");
            sb.Append("  extensions: ").Append(Extensions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgentStatusInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgentStatusInfo input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.UniagentStatus != input.UniagentStatus) return false;
            if (this.Extensions != input.Extensions || (this.Extensions != null && input.Extensions != null && !this.Extensions.SequenceEqual(input.Extensions))) return false;

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
                hashCode = hashCode * 59 + this.UniagentStatus.GetHashCode();
                if (this.Extensions != null) hashCode = hashCode * 59 + this.Extensions.GetHashCode();
                return hashCode;
            }
        }
    }
}
