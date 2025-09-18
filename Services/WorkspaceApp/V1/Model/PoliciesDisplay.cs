using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 显示。
    /// </summary>
    public class PoliciesDisplay 
    {
        /// <summary>
        /// 显示级别。取值为： LEVEL1：表示等级1。 LEVEL2：表示等级2。 LEVEL3：表示等级3。 LEVEL4：表示等级4（默认/推荐）。 LEVEL5：表示等级5。
        /// </summary>
        /// <value>显示级别。取值为： LEVEL1：表示等级1。 LEVEL2：表示等级2。 LEVEL3：表示等级3。 LEVEL4：表示等级4（默认/推荐）。 LEVEL5：表示等级5。</value>
        [JsonConverter(typeof(EnumClassConverter<DisplayLevelEnum>))]
        public class DisplayLevelEnum
        {
            /// <summary>
            /// Enum LEVEL1 for value: LEVEL1
            /// </summary>
            public static readonly DisplayLevelEnum LEVEL1 = new DisplayLevelEnum("LEVEL1");

            /// <summary>
            /// Enum LEVEL2 for value: LEVEL2
            /// </summary>
            public static readonly DisplayLevelEnum LEVEL2 = new DisplayLevelEnum("LEVEL2");

            /// <summary>
            /// Enum LEVEL3 for value: LEVEL3
            /// </summary>
            public static readonly DisplayLevelEnum LEVEL3 = new DisplayLevelEnum("LEVEL3");

            /// <summary>
            /// Enum LEVEL4 for value: LEVEL4
            /// </summary>
            public static readonly DisplayLevelEnum LEVEL4 = new DisplayLevelEnum("LEVEL4");

            /// <summary>
            /// Enum LEVEL5 for value: LEVEL5
            /// </summary>
            public static readonly DisplayLevelEnum LEVEL5 = new DisplayLevelEnum("LEVEL5");

            private static readonly Dictionary<string, DisplayLevelEnum> StaticFields =
            new Dictionary<string, DisplayLevelEnum>()
            {
                { "LEVEL1", LEVEL1 },
                { "LEVEL2", LEVEL2 },
                { "LEVEL3", LEVEL3 },
                { "LEVEL4", LEVEL4 },
                { "LEVEL5", LEVEL5 },
            };

            private string _value;

            public DisplayLevelEnum()
            {

            }

            public DisplayLevelEnum(string value)
            {
                _value = value;
            }

            public static DisplayLevelEnum FromValue(string value)
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

                if (this.Equals(obj as DisplayLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DisplayLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DisplayLevelEnum a, DisplayLevelEnum b)
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

            public static bool operator !=(DisplayLevelEnum a, DisplayLevelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 显示级别。取值为： LEVEL1：表示等级1。 LEVEL2：表示等级2。 LEVEL3：表示等级3。 LEVEL4：表示等级4（默认/推荐）。 LEVEL5：表示等级5。
        /// </summary>
        [JsonProperty("display_level", NullValueHandling = NullValueHandling.Ignore)]
        public DisplayLevelEnum DisplayLevel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public DisplayOptions Options { get; set; }

        /// <summary>
        /// 是否开启渲染加速。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("rendering_acceleration_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RenderingAccelerationEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rendering_acceleration_options", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesDisplayRenderingAccelerationOptions RenderingAccelerationOptions { get; set; }

        /// <summary>
        /// 显卡缓存（MB）。取值范围为[0-64]。默认：64。
        /// </summary>
        [JsonProperty("video_card_memory_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? VideoCardMemorySize { get; set; }

        /// <summary>
        /// 是否开启驱动托管模式。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("driver_delegation_mode_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DriverDelegationModeEnable { get; set; }

        /// <summary>
        /// 驱动托管延时（*30ms）。取值范围为[1-100]。默认：80。
        /// </summary>
        [JsonProperty("driver_delegation_latency", NullValueHandling = NullValueHandling.Ignore)]
        public int? DriverDelegationLatency { get; set; }

        /// <summary>
        /// 驱动托管视频延时（*30ms）。取值范围为[1-100]。默认：80。
        /// </summary>
        [JsonProperty("video_latency", NullValueHandling = NullValueHandling.Ignore)]
        public int? VideoLatency { get; set; }

        /// <summary>
        /// 计算机修改分辨率：取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("change_resolution_vm", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChangeResolutionVm { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesDisplay {\n");
            sb.Append("  displayLevel: ").Append(DisplayLevel).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("  renderingAccelerationEnable: ").Append(RenderingAccelerationEnable).Append("\n");
            sb.Append("  renderingAccelerationOptions: ").Append(RenderingAccelerationOptions).Append("\n");
            sb.Append("  videoCardMemorySize: ").Append(VideoCardMemorySize).Append("\n");
            sb.Append("  driverDelegationModeEnable: ").Append(DriverDelegationModeEnable).Append("\n");
            sb.Append("  driverDelegationLatency: ").Append(DriverDelegationLatency).Append("\n");
            sb.Append("  videoLatency: ").Append(VideoLatency).Append("\n");
            sb.Append("  changeResolutionVm: ").Append(ChangeResolutionVm).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesDisplay);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesDisplay input)
        {
            if (input == null) return false;
            if (this.DisplayLevel != input.DisplayLevel) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;
            if (this.RenderingAccelerationEnable != input.RenderingAccelerationEnable || (this.RenderingAccelerationEnable != null && !this.RenderingAccelerationEnable.Equals(input.RenderingAccelerationEnable))) return false;
            if (this.RenderingAccelerationOptions != input.RenderingAccelerationOptions || (this.RenderingAccelerationOptions != null && !this.RenderingAccelerationOptions.Equals(input.RenderingAccelerationOptions))) return false;
            if (this.VideoCardMemorySize != input.VideoCardMemorySize || (this.VideoCardMemorySize != null && !this.VideoCardMemorySize.Equals(input.VideoCardMemorySize))) return false;
            if (this.DriverDelegationModeEnable != input.DriverDelegationModeEnable || (this.DriverDelegationModeEnable != null && !this.DriverDelegationModeEnable.Equals(input.DriverDelegationModeEnable))) return false;
            if (this.DriverDelegationLatency != input.DriverDelegationLatency || (this.DriverDelegationLatency != null && !this.DriverDelegationLatency.Equals(input.DriverDelegationLatency))) return false;
            if (this.VideoLatency != input.VideoLatency || (this.VideoLatency != null && !this.VideoLatency.Equals(input.VideoLatency))) return false;
            if (this.ChangeResolutionVm != input.ChangeResolutionVm || (this.ChangeResolutionVm != null && !this.ChangeResolutionVm.Equals(input.ChangeResolutionVm))) return false;

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
                hashCode = hashCode * 59 + this.DisplayLevel.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.RenderingAccelerationEnable != null) hashCode = hashCode * 59 + this.RenderingAccelerationEnable.GetHashCode();
                if (this.RenderingAccelerationOptions != null) hashCode = hashCode * 59 + this.RenderingAccelerationOptions.GetHashCode();
                if (this.VideoCardMemorySize != null) hashCode = hashCode * 59 + this.VideoCardMemorySize.GetHashCode();
                if (this.DriverDelegationModeEnable != null) hashCode = hashCode * 59 + this.DriverDelegationModeEnable.GetHashCode();
                if (this.DriverDelegationLatency != null) hashCode = hashCode * 59 + this.DriverDelegationLatency.GetHashCode();
                if (this.VideoLatency != null) hashCode = hashCode * 59 + this.VideoLatency.GetHashCode();
                if (this.ChangeResolutionVm != null) hashCode = hashCode * 59 + this.ChangeResolutionVm.GetHashCode();
                return hashCode;
            }
        }
    }
}
