using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateSubnetBandwidthControlListReq 
    {
        /// <summary>
        /// 控制模式 - BLACK：黑名单控制。 - WHITE：白名单控制。
        /// </summary>
        /// <value>控制模式 - BLACK：黑名单控制。 - WHITE：白名单控制。</value>
        [JsonConverter(typeof(EnumClassConverter<ControlModeEnum>))]
        public class ControlModeEnum
        {
            /// <summary>
            /// Enum BLACK for value: BLACK
            /// </summary>
            public static readonly ControlModeEnum BLACK = new ControlModeEnum("BLACK");

            /// <summary>
            /// Enum WHITE for value: WHITE
            /// </summary>
            public static readonly ControlModeEnum WHITE = new ControlModeEnum("WHITE");

            private static readonly Dictionary<string, ControlModeEnum> StaticFields =
            new Dictionary<string, ControlModeEnum>()
            {
                { "BLACK", BLACK },
                { "WHITE", WHITE },
            };

            private string _value;

            public ControlModeEnum()
            {

            }

            public ControlModeEnum(string value)
            {
                _value = value;
            }

            public static ControlModeEnum FromValue(string value)
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

                if (this.Equals(obj as ControlModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ControlModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ControlModeEnum a, ControlModeEnum b)
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

            public static bool operator !=(ControlModeEnum a, ControlModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 控制模式 - BLACK：黑名单控制。 - WHITE：白名单控制。
        /// </summary>
        [JsonProperty("control_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ControlModeEnum ControlMode { get; set; }
        /// <summary>
        /// 待添加的桌面。
        /// </summary>
        [JsonProperty("add_control_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AddControlList { get; set; }

        /// <summary>
        /// 待删除的桌面。
        /// </summary>
        [JsonProperty("remove_control_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RemoveControlList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSubnetBandwidthControlListReq {\n");
            sb.Append("  controlMode: ").Append(ControlMode).Append("\n");
            sb.Append("  addControlList: ").Append(AddControlList).Append("\n");
            sb.Append("  removeControlList: ").Append(RemoveControlList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSubnetBandwidthControlListReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSubnetBandwidthControlListReq input)
        {
            if (input == null) return false;
            if (this.ControlMode != input.ControlMode) return false;
            if (this.AddControlList != input.AddControlList || (this.AddControlList != null && input.AddControlList != null && !this.AddControlList.SequenceEqual(input.AddControlList))) return false;
            if (this.RemoveControlList != input.RemoveControlList || (this.RemoveControlList != null && input.RemoveControlList != null && !this.RemoveControlList.SequenceEqual(input.RemoveControlList))) return false;

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
                hashCode = hashCode * 59 + this.ControlMode.GetHashCode();
                if (this.AddControlList != null) hashCode = hashCode * 59 + this.AddControlList.GetHashCode();
                if (this.RemoveControlList != null) hashCode = hashCode * 59 + this.RemoveControlList.GetHashCode();
                return hashCode;
            }
        }
    }
}
