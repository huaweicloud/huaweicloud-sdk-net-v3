using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AuditAgentRequest 
    {
        /// <summary>
        /// 模式 - 0：创建agent - 1：选择已有agent
        /// </summary>
        /// <value>模式 - 0：创建agent - 1：选择已有agent</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly ModeEnum NUMBER_0 = new ModeEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly ModeEnum NUMBER_1 = new ModeEnum(1);

            private static readonly Dictionary<int?, ModeEnum> StaticFields =
            new Dictionary<int?, ModeEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? _value;

            public ModeEnum()
            {

            }

            public ModeEnum(int? value)
            {
                _value = value;
            }

            public static ModeEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// agent类型 - APP：应用端 - DB：数据库端
        /// </summary>
        /// <value>agent类型 - APP：应用端 - DB：数据库端</value>
        [JsonConverter(typeof(EnumClassConverter<AgentTypeEnum>))]
        public class AgentTypeEnum
        {
            /// <summary>
            /// Enum APP for value: APP
            /// </summary>
            public static readonly AgentTypeEnum APP = new AgentTypeEnum("APP");

            /// <summary>
            /// Enum DB for value: DB
            /// </summary>
            public static readonly AgentTypeEnum DB = new AgentTypeEnum("DB");

            private static readonly Dictionary<string, AgentTypeEnum> StaticFields =
            new Dictionary<string, AgentTypeEnum>()
            {
                { "APP", APP },
                { "DB", DB },
            };

            private string _value;

            public AgentTypeEnum()
            {

            }

            public AgentTypeEnum(string value)
            {
                _value = value;
            }

            public static AgentTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AgentTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AgentTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AgentTypeEnum a, AgentTypeEnum b)
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

            public static bool operator !=(AgentTypeEnum a, AgentTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// agent OS类型: - LINUX64_X86 - LINUX64_ARM - WINDOWS64
        /// </summary>
        /// <value>agent OS类型: - LINUX64_X86 - LINUX64_ARM - WINDOWS64</value>
        [JsonConverter(typeof(EnumClassConverter<AgentOsEnum>))]
        public class AgentOsEnum
        {
            /// <summary>
            /// Enum LINUX64_X86 for value: LINUX64_X86
            /// </summary>
            public static readonly AgentOsEnum LINUX64_X86 = new AgentOsEnum("LINUX64_X86");

            /// <summary>
            /// Enum LINUX64_ARM for value: LINUX64_ARM
            /// </summary>
            public static readonly AgentOsEnum LINUX64_ARM = new AgentOsEnum("LINUX64_ARM");

            /// <summary>
            /// Enum WINDOWS64 for value: WINDOWS64
            /// </summary>
            public static readonly AgentOsEnum WINDOWS64 = new AgentOsEnum("WINDOWS64");

            private static readonly Dictionary<string, AgentOsEnum> StaticFields =
            new Dictionary<string, AgentOsEnum>()
            {
                { "LINUX64_X86", LINUX64_X86 },
                { "LINUX64_ARM", LINUX64_ARM },
                { "WINDOWS64", WINDOWS64 },
            };

            private string _value;

            public AgentOsEnum()
            {

            }

            public AgentOsEnum(string value)
            {
                _value = value;
            }

            public static AgentOsEnum FromValue(string value)
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

                if (this.Equals(obj as AgentOsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AgentOsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AgentOsEnum a, AgentOsEnum b)
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

            public static bool operator !=(AgentOsEnum a, AgentOsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数据库ID, 可在查询数据库列表接口的ID字段获取。
        /// </summary>
        [JsonProperty("db_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DbId { get; set; }

        /// <summary>
        /// 模式 - 0：创建agent - 1：选择已有agent
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// 选择已有agent时必输
        /// </summary>
        [JsonProperty("agent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentId { get; set; }

        /// <summary>
        /// agent类型 - APP：应用端 - DB：数据库端
        /// </summary>
        [JsonProperty("agent_type", NullValueHandling = NullValueHandling.Ignore)]
        public AgentTypeEnum AgentType { get; set; }
        /// <summary>
        /// agent OS类型: - LINUX64_X86 - LINUX64_ARM - WINDOWS64
        /// </summary>
        [JsonProperty("agent_os", NullValueHandling = NullValueHandling.Ignore)]
        public AgentOsEnum AgentOs { get; set; }
        /// <summary>
        /// agent IP，安装节点类型为应用端时必输。
        /// </summary>
        [JsonProperty("agent_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentIp { get; set; }

        /// <summary>
        /// agent审计网卡名称
        /// </summary>
        [JsonProperty("agent_nic", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentNic { get; set; }

        /// <summary>
        /// CPU阈值
        /// </summary>
        [JsonProperty("cpu_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuThreshold { get; set; }

        /// <summary>
        /// 内存阈值
        /// </summary>
        [JsonProperty("mem_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemThreshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditAgentRequest {\n");
            sb.Append("  dbId: ").Append(DbId).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  agentId: ").Append(AgentId).Append("\n");
            sb.Append("  agentType: ").Append(AgentType).Append("\n");
            sb.Append("  agentOs: ").Append(AgentOs).Append("\n");
            sb.Append("  agentIp: ").Append(AgentIp).Append("\n");
            sb.Append("  agentNic: ").Append(AgentNic).Append("\n");
            sb.Append("  cpuThreshold: ").Append(CpuThreshold).Append("\n");
            sb.Append("  memThreshold: ").Append(MemThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuditAgentRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuditAgentRequest input)
        {
            if (input == null) return false;
            if (this.DbId != input.DbId || (this.DbId != null && !this.DbId.Equals(input.DbId))) return false;
            if (this.Mode != input.Mode) return false;
            if (this.AgentId != input.AgentId || (this.AgentId != null && !this.AgentId.Equals(input.AgentId))) return false;
            if (this.AgentType != input.AgentType) return false;
            if (this.AgentOs != input.AgentOs) return false;
            if (this.AgentIp != input.AgentIp || (this.AgentIp != null && !this.AgentIp.Equals(input.AgentIp))) return false;
            if (this.AgentNic != input.AgentNic || (this.AgentNic != null && !this.AgentNic.Equals(input.AgentNic))) return false;
            if (this.CpuThreshold != input.CpuThreshold || (this.CpuThreshold != null && !this.CpuThreshold.Equals(input.CpuThreshold))) return false;
            if (this.MemThreshold != input.MemThreshold || (this.MemThreshold != null && !this.MemThreshold.Equals(input.MemThreshold))) return false;

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
                if (this.DbId != null) hashCode = hashCode * 59 + this.DbId.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.AgentId != null) hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                hashCode = hashCode * 59 + this.AgentType.GetHashCode();
                hashCode = hashCode * 59 + this.AgentOs.GetHashCode();
                if (this.AgentIp != null) hashCode = hashCode * 59 + this.AgentIp.GetHashCode();
                if (this.AgentNic != null) hashCode = hashCode * 59 + this.AgentNic.GetHashCode();
                if (this.CpuThreshold != null) hashCode = hashCode * 59 + this.CpuThreshold.GetHashCode();
                if (this.MemThreshold != null) hashCode = hashCode * 59 + this.MemThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
