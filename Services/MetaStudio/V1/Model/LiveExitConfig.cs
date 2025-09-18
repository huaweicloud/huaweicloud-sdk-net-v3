using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 直播任务退出配置
    /// </summary>
    public class LiveExitConfig 
    {
        /// <summary>
        /// **参数解释**： 自动停止直播模式。 * FORCE_EXIT：立即强制停止，不做其他逻辑处理。 * SEGMENT_END:等待段落结束停止。 * SCENE_END：等待场景结束停止。 * SCRIPT_END：等待剧本结束停止。 **约束限制**： 不涉及 **默认取值**： 不设置则表示FORCE_EXIT。
        /// </summary>
        /// <value>**参数解释**： 自动停止直播模式。 * FORCE_EXIT：立即强制停止，不做其他逻辑处理。 * SEGMENT_END:等待段落结束停止。 * SCENE_END：等待场景结束停止。 * SCRIPT_END：等待剧本结束停止。 **约束限制**： 不涉及 **默认取值**： 不设置则表示FORCE_EXIT。</value>
        [JsonConverter(typeof(EnumClassConverter<AutoStopModeEnum>))]
        public class AutoStopModeEnum
        {
            /// <summary>
            /// Enum FORCE_EXIT for value: FORCE_EXIT
            /// </summary>
            public static readonly AutoStopModeEnum FORCE_EXIT = new AutoStopModeEnum("FORCE_EXIT");

            /// <summary>
            /// Enum SEGMENT_END for value: SEGMENT_END
            /// </summary>
            public static readonly AutoStopModeEnum SEGMENT_END = new AutoStopModeEnum("SEGMENT_END");

            /// <summary>
            /// Enum SCENE_END for value: SCENE_END
            /// </summary>
            public static readonly AutoStopModeEnum SCENE_END = new AutoStopModeEnum("SCENE_END");

            /// <summary>
            /// Enum SCRIPT_END for value: SCRIPT_END
            /// </summary>
            public static readonly AutoStopModeEnum SCRIPT_END = new AutoStopModeEnum("SCRIPT_END");

            private static readonly Dictionary<string, AutoStopModeEnum> StaticFields =
            new Dictionary<string, AutoStopModeEnum>()
            {
                { "FORCE_EXIT", FORCE_EXIT },
                { "SEGMENT_END", SEGMENT_END },
                { "SCENE_END", SCENE_END },
                { "SCRIPT_END", SCRIPT_END },
            };

            private string _value;

            public AutoStopModeEnum()
            {

            }

            public AutoStopModeEnum(string value)
            {
                _value = value;
            }

            public static AutoStopModeEnum FromValue(string value)
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

                if (this.Equals(obj as AutoStopModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AutoStopModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AutoStopModeEnum a, AutoStopModeEnum b)
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

            public static bool operator !=(AutoStopModeEnum a, AutoStopModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 最大直播时长。单位小时。 此数值配置为n，则标识起播后n小时后触发停止直播逻辑。 当前数值最大为168（一周），特殊的，0表示不限时。 **约束限制**： 停止直播逻辑配置为立即停止则直播停止误差在5分钟之内。其他逻辑则加上处理时长。 **默认取值**： 不设置则表示不限时。
        /// </summary>
        [JsonProperty("max_live_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxLiveDuration { get; set; }

        /// <summary>
        /// **参数解释**： 自动停止直播模式。 * FORCE_EXIT：立即强制停止，不做其他逻辑处理。 * SEGMENT_END:等待段落结束停止。 * SCENE_END：等待场景结束停止。 * SCRIPT_END：等待剧本结束停止。 **约束限制**： 不涉及 **默认取值**： 不设置则表示FORCE_EXIT。
        /// </summary>
        [JsonProperty("auto_stop_mode", NullValueHandling = NullValueHandling.Ignore)]
        public AutoStopModeEnum AutoStopMode { get; set; }
        /// <summary>
        /// **参数解释**： 最大异常等待时长。单位分钟。  此数值配置为n，则标识检测到异常n分钟后触发立即停止直播逻辑。 当前数值最大为60（1小时），特殊的，0表示不限时。 **约束限制**： 不涉及 **默认取值**： 不设置则为系统默认值，当前为3分钟，默认值可能会根据服务运行状态进行少许调整。
        /// </summary>
        [JsonProperty("max_exception_waiting_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxExceptionWaitingDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveExitConfig {\n");
            sb.Append("  maxLiveDuration: ").Append(MaxLiveDuration).Append("\n");
            sb.Append("  autoStopMode: ").Append(AutoStopMode).Append("\n");
            sb.Append("  maxExceptionWaitingDuration: ").Append(MaxExceptionWaitingDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LiveExitConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LiveExitConfig input)
        {
            if (input == null) return false;
            if (this.MaxLiveDuration != input.MaxLiveDuration || (this.MaxLiveDuration != null && !this.MaxLiveDuration.Equals(input.MaxLiveDuration))) return false;
            if (this.AutoStopMode != input.AutoStopMode) return false;
            if (this.MaxExceptionWaitingDuration != input.MaxExceptionWaitingDuration || (this.MaxExceptionWaitingDuration != null && !this.MaxExceptionWaitingDuration.Equals(input.MaxExceptionWaitingDuration))) return false;

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
                if (this.MaxLiveDuration != null) hashCode = hashCode * 59 + this.MaxLiveDuration.GetHashCode();
                hashCode = hashCode * 59 + this.AutoStopMode.GetHashCode();
                if (this.MaxExceptionWaitingDuration != null) hashCode = hashCode * 59 + this.MaxExceptionWaitingDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
