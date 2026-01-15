using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 任务实例基本信息体。
    /// </summary>
    public class JobNodeBaseInfo 
    {
        /// <summary>
        /// 实例类型。取值： - single：单机。 - ha：主备。
        /// </summary>
        /// <value>实例类型。取值： - single：单机。 - ha：主备。</value>
        [JsonConverter(typeof(EnumClassConverter<InstanceTypeEnum>))]
        public class InstanceTypeEnum
        {
            /// <summary>
            /// Enum SINGLE for value: single
            /// </summary>
            public static readonly InstanceTypeEnum SINGLE = new InstanceTypeEnum("single");

            /// <summary>
            /// Enum HA for value: ha
            /// </summary>
            public static readonly InstanceTypeEnum HA = new InstanceTypeEnum("ha");

            private static readonly Dictionary<string, InstanceTypeEnum> StaticFields =
            new Dictionary<string, InstanceTypeEnum>()
            {
                { "single", SINGLE },
                { "ha", HA },
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

            public static bool operator !=(InstanceTypeEnum a, InstanceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// CPU架构。取值： - x86 - arm
        /// </summary>
        /// <value>CPU架构。取值： - x86 - arm</value>
        [JsonConverter(typeof(EnumClassConverter<ArchEnum>))]
        public class ArchEnum
        {
            /// <summary>
            /// Enum X86 for value: x86
            /// </summary>
            public static readonly ArchEnum X86 = new ArchEnum("x86");

            /// <summary>
            /// Enum ARM for value: arm
            /// </summary>
            public static readonly ArchEnum ARM = new ArchEnum("arm");

            private static readonly Dictionary<string, ArchEnum> StaticFields =
            new Dictionary<string, ArchEnum>()
            {
                { "x86", X86 },
                { "arm", ARM },
            };

            private string _value;

            public ArchEnum()
            {

            }

            public ArchEnum(string value)
            {
                _value = value;
            }

            public static ArchEnum FromValue(string value)
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

                if (this.Equals(obj as ArchEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ArchEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ArchEnum a, ArchEnum b)
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

            public static bool operator !=(ArchEnum a, ArchEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例类型。取值： - single：单机。 - ha：主备。
        /// </summary>
        [JsonProperty("instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceTypeEnum InstanceType { get; set; }
        /// <summary>
        /// CPU架构。取值： - x86 - arm
        /// </summary>
        [JsonProperty("arch", NullValueHandling = NullValueHandling.Ignore)]
        public ArchEnum Arch { get; set; }
        /// <summary>
        /// 可用区ID。 约束：对于任务实例类型不是单机的实例，需要分别为实例所有节点指定可用区，并用“,”英文逗号隔开。示例： - 实例类型为single：\&quot;cn-north-4a\&quot; - 实例类型为ha：\&quot;cn-north-4a,cn-north-4b\&quot;
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 状态。 CREATING：创建中，CREATE_FAILED：创建失败，CONFIGURATION：配置中，WAITING_FOR_START：等待启动中，RELEASE_RESOURCE_COMPLETE：已结束，DELETED：已删除，INCRE_TRANSFER_STARTED：增量迁移中，INCRE_TRANSFER_FAILED：增量迁移失败，FULL_TRANSFER_STARTED：全量迁移中，FULL_TRANSFER_COMPLETE：全量迁移完成，PAUSING：暂停中，FULL_TRANSFER_FAILED：全量迁移失败
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 任务主备角色。
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobNodeBaseInfo {\n");
            sb.Append("  instanceType: ").Append(InstanceType).Append("\n");
            sb.Append("  arch: ").Append(Arch).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobNodeBaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobNodeBaseInfo input)
        {
            if (input == null) return false;
            if (this.InstanceType != input.InstanceType) return false;
            if (this.Arch != input.Arch) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Role != input.Role || (this.Role != null && !this.Role.Equals(input.Role))) return false;

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
                hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                hashCode = hashCode * 59 + this.Arch.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Role != null) hashCode = hashCode * 59 + this.Role.GetHashCode();
                return hashCode;
            }
        }
    }
}
