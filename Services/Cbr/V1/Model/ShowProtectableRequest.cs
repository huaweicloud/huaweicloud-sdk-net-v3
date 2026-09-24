using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowProtectableRequest 
    {
        /// <summary>
        /// **参数解释：** 可保护性类型 **约束限制：** 不涉及 **取值范围：** 可选参数为server,disk,turbo,workspace和workspace_v2 server： 云服务器类型 disk：云硬盘类型 turbo：turbo类型 workspace：workspace类型 workspace_v2：workspace_v2类型 **默认取值：** 不涉及
        /// </summary>
        /// <value>**参数解释：** 可保护性类型 **约束限制：** 不涉及 **取值范围：** 可选参数为server,disk,turbo,workspace和workspace_v2 server： 云服务器类型 disk：云硬盘类型 turbo：turbo类型 workspace：workspace类型 workspace_v2：workspace_v2类型 **默认取值：** 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<ProtectableTypeEnum>))]
        public class ProtectableTypeEnum
        {
            /// <summary>
            /// Enum SERVER for value: server
            /// </summary>
            public static readonly ProtectableTypeEnum SERVER = new ProtectableTypeEnum("server");

            /// <summary>
            /// Enum DISK for value: disk
            /// </summary>
            public static readonly ProtectableTypeEnum DISK = new ProtectableTypeEnum("disk");

            /// <summary>
            /// Enum TURBO for value: turbo
            /// </summary>
            public static readonly ProtectableTypeEnum TURBO = new ProtectableTypeEnum("turbo");

            /// <summary>
            /// Enum WORKSPACE for value: workspace
            /// </summary>
            public static readonly ProtectableTypeEnum WORKSPACE = new ProtectableTypeEnum("workspace");

            /// <summary>
            /// Enum WORKSPACE_V2 for value: workspace_v2
            /// </summary>
            public static readonly ProtectableTypeEnum WORKSPACE_V2 = new ProtectableTypeEnum("workspace_v2");

            private static readonly Dictionary<string, ProtectableTypeEnum> StaticFields =
            new Dictionary<string, ProtectableTypeEnum>()
            {
                { "server", SERVER },
                { "disk", DISK },
                { "turbo", TURBO },
                { "workspace", WORKSPACE },
                { "workspace_v2", WORKSPACE_V2 },
            };

            private string _value;

            public ProtectableTypeEnum()
            {

            }

            public ProtectableTypeEnum(string value)
            {
                _value = value;
            }

            public static ProtectableTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ProtectableTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtectableTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProtectableTypeEnum a, ProtectableTypeEnum b)
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

            public static bool operator !=(ProtectableTypeEnum a, ProtectableTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 资源ID
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释：** 可保护性类型 **约束限制：** 不涉及 **取值范围：** 可选参数为server,disk,turbo,workspace和workspace_v2 server： 云服务器类型 disk：云硬盘类型 turbo：turbo类型 workspace：workspace类型 workspace_v2：workspace_v2类型 **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("protectable_type", IsPath = true)]
        [JsonProperty("protectable_type", NullValueHandling = NullValueHandling.Ignore)]
        public ProtectableTypeEnum ProtectableType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowProtectableRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  protectableType: ").Append(ProtectableType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowProtectableRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowProtectableRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.ProtectableType != input.ProtectableType) return false;

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
                hashCode = hashCode * 59 + this.ProtectableType.GetHashCode();
                return hashCode;
            }
        }
    }
}
