using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AttachDevServerPortResponse : SdkResponse
    {
        /// <summary>
        /// **参数解释**：端口状态。 **取值范围**： - ACTIVE：端口处于活动状态，可以正常进行网络通信。 - BUILD：端口正在创建或配置中。 - DOWN：端口处于非活动状态，不能进行网络通信。
        /// </summary>
        /// <value>**参数解释**：端口状态。 **取值范围**： - ACTIVE：端口处于活动状态，可以正常进行网络通信。 - BUILD：端口正在创建或配置中。 - DOWN：端口处于非活动状态，不能进行网络通信。</value>
        [JsonConverter(typeof(EnumClassConverter<PortStateEnum>))]
        public class PortStateEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly PortStateEnum ACTIVE = new PortStateEnum("ACTIVE");

            /// <summary>
            /// Enum BUILD for value: BUILD
            /// </summary>
            public static readonly PortStateEnum BUILD = new PortStateEnum("BUILD");

            /// <summary>
            /// Enum DOWN for value: DOWN
            /// </summary>
            public static readonly PortStateEnum DOWN = new PortStateEnum("DOWN");

            private static readonly Dictionary<string, PortStateEnum> StaticFields =
            new Dictionary<string, PortStateEnum>()
            {
                { "ACTIVE", ACTIVE },
                { "BUILD", BUILD },
                { "DOWN", DOWN },
            };

            private string _value;

            public PortStateEnum()
            {

            }

            public PortStateEnum(string value)
            {
                _value = value;
            }

            public static PortStateEnum FromValue(string value)
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

                if (this.Equals(obj as PortStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PortStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PortStateEnum a, PortStateEnum b)
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

            public static bool operator !=(PortStateEnum a, PortStateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：端口MAC地址，由系统分配。
        /// </summary>
        [JsonProperty("mac_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string MacAddr { get; set; }

        /// <summary>
        /// **参数解释**：网卡ID。 **取值范围**：^[0-9a-f]{8}-[0-9a-f]{4}-[1-5][0-9a-f]{3}-[89ab][0-9a-f]{3}-[0-9a-f]{12}$。
        /// </summary>
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// **参数解释**：端口状态。 **取值范围**： - ACTIVE：端口处于活动状态，可以正常进行网络通信。 - BUILD：端口正在创建或配置中。 - DOWN：端口处于非活动状态，不能进行网络通信。
        /// </summary>
        [JsonProperty("port_state", NullValueHandling = NullValueHandling.Ignore)]
        public PortStateEnum PortState { get; set; }
        /// <summary>
        /// **参数解释**：端口所在子网ID。 **取值范围**：^[0-9a-f]{8}-[0-9a-f]{4}-[1-5][0-9a-f]{3}-[89ab][0-9a-f]{3}-[0-9a-f]{12}$。
        /// </summary>
        [JsonProperty("virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VirsubnetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachDevServerPortResponse {\n");
            sb.Append("  macAddr: ").Append(MacAddr).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  portState: ").Append(PortState).Append("\n");
            sb.Append("  virsubnetId: ").Append(VirsubnetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachDevServerPortResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachDevServerPortResponse input)
        {
            if (input == null) return false;
            if (this.MacAddr != input.MacAddr || (this.MacAddr != null && !this.MacAddr.Equals(input.MacAddr))) return false;
            if (this.PortId != input.PortId || (this.PortId != null && !this.PortId.Equals(input.PortId))) return false;
            if (this.PortState != input.PortState) return false;
            if (this.VirsubnetId != input.VirsubnetId || (this.VirsubnetId != null && !this.VirsubnetId.Equals(input.VirsubnetId))) return false;

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
                if (this.MacAddr != null) hashCode = hashCode * 59 + this.MacAddr.GetHashCode();
                if (this.PortId != null) hashCode = hashCode * 59 + this.PortId.GetHashCode();
                hashCode = hashCode * 59 + this.PortState.GetHashCode();
                if (this.VirsubnetId != null) hashCode = hashCode * 59 + this.VirsubnetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
