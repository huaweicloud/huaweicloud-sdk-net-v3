using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateInstanceBandwidthAutoScalingPolicyResponse : SdkResponse
    {
        /// <summary>
        /// 带宽弹性的观测窗口，单位：分钟。支持的取值：1、5、10、15、30。
        /// </summary>
        /// <value>带宽弹性的观测窗口，单位：分钟。支持的取值：1、5、10、15、30。</value>
        [JsonConverter(typeof(EnumClassConverter<WindowSizeEnum>))]
        public class WindowSizeEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly WindowSizeEnum NUMBER_1 = new WindowSizeEnum(1);

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            public static readonly WindowSizeEnum NUMBER_5 = new WindowSizeEnum(5);

            /// <summary>
            /// Enum NUMBER_10 for value: 10
            /// </summary>
            public static readonly WindowSizeEnum NUMBER_10 = new WindowSizeEnum(10);

            /// <summary>
            /// Enum NUMBER_15 for value: 15
            /// </summary>
            public static readonly WindowSizeEnum NUMBER_15 = new WindowSizeEnum(15);

            /// <summary>
            /// Enum NUMBER_30 for value: 30
            /// </summary>
            public static readonly WindowSizeEnum NUMBER_30 = new WindowSizeEnum(30);

            private static readonly Dictionary<int?, WindowSizeEnum> StaticFields =
            new Dictionary<int?, WindowSizeEnum>()
            {
                { 1, NUMBER_1 },
                { 5, NUMBER_5 },
                { 10, NUMBER_10 },
                { 15, NUMBER_15 },
                { 30, NUMBER_30 },
            };

            private int? _value;

            public WindowSizeEnum()
            {

            }

            public WindowSizeEnum(int? value)
            {
                _value = value;
            }

            public static WindowSizeEnum FromValue(int? value)
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

                if (this.Equals(obj as WindowSizeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(WindowSizeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(WindowSizeEnum a, WindowSizeEnum b)
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

            public static bool operator !=(WindowSizeEnum a, WindowSizeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 触发带宽自动扩展的带宽平均使用率阈值，单位：百分比。支持的取值：50、60、70、80、90、95。
        /// </summary>
        /// <value>触发带宽自动扩展的带宽平均使用率阈值，单位：百分比。支持的取值：50、60、70、80、90、95。</value>
        [JsonConverter(typeof(EnumClassConverter<BandwidthUsageUpperThresholdEnum>))]
        public class BandwidthUsageUpperThresholdEnum
        {
            /// <summary>
            /// Enum NUMBER_50 for value: 50
            /// </summary>
            public static readonly BandwidthUsageUpperThresholdEnum NUMBER_50 = new BandwidthUsageUpperThresholdEnum(50);

            /// <summary>
            /// Enum NUMBER_60 for value: 60
            /// </summary>
            public static readonly BandwidthUsageUpperThresholdEnum NUMBER_60 = new BandwidthUsageUpperThresholdEnum(60);

            /// <summary>
            /// Enum NUMBER_70 for value: 70
            /// </summary>
            public static readonly BandwidthUsageUpperThresholdEnum NUMBER_70 = new BandwidthUsageUpperThresholdEnum(70);

            /// <summary>
            /// Enum NUMBER_80 for value: 80
            /// </summary>
            public static readonly BandwidthUsageUpperThresholdEnum NUMBER_80 = new BandwidthUsageUpperThresholdEnum(80);

            /// <summary>
            /// Enum NUMBER_90 for value: 90
            /// </summary>
            public static readonly BandwidthUsageUpperThresholdEnum NUMBER_90 = new BandwidthUsageUpperThresholdEnum(90);

            /// <summary>
            /// Enum NUMBER_95 for value: 95
            /// </summary>
            public static readonly BandwidthUsageUpperThresholdEnum NUMBER_95 = new BandwidthUsageUpperThresholdEnum(95);

            private static readonly Dictionary<int?, BandwidthUsageUpperThresholdEnum> StaticFields =
            new Dictionary<int?, BandwidthUsageUpperThresholdEnum>()
            {
                { 50, NUMBER_50 },
                { 60, NUMBER_60 },
                { 70, NUMBER_70 },
                { 80, NUMBER_80 },
                { 90, NUMBER_90 },
                { 95, NUMBER_95 },
            };

            private int? _value;

            public BandwidthUsageUpperThresholdEnum()
            {

            }

            public BandwidthUsageUpperThresholdEnum(int? value)
            {
                _value = value;
            }

            public static BandwidthUsageUpperThresholdEnum FromValue(int? value)
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

                if (this.Equals(obj as BandwidthUsageUpperThresholdEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BandwidthUsageUpperThresholdEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BandwidthUsageUpperThresholdEnum a, BandwidthUsageUpperThresholdEnum b)
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

            public static bool operator !=(BandwidthUsageUpperThresholdEnum a, BandwidthUsageUpperThresholdEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 带宽弹性的观测窗口，单位：分钟。支持的取值：1、5、10、15、30。
        /// </summary>
        [JsonProperty("window_size", NullValueHandling = NullValueHandling.Ignore)]
        public WindowSizeEnum WindowSize { get; set; }
        /// <summary>
        /// 触发带宽自动扩展的带宽平均使用率阈值，单位：百分比。支持的取值：50、60、70、80、90、95。
        /// </summary>
        [JsonProperty("bandwidth_usage_upper_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthUsageUpperThresholdEnum BandwidthUsageUpperThreshold { get; set; }
        /// <summary>
        /// 带宽扩展操作的静默时间（两次带宽扩展操作之间的最小间隔时间），单位：秒。 默认值：0。取值范围：0~86400。 
        /// </summary>
        [JsonProperty("scale_out_cooldown", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScaleOutCooldown { get; set; }

        /// <summary>
        /// 是否启用带宽自动回缩。默认值：false。该参数暂未启用。
        /// </summary>
        [JsonProperty("scale_in_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ScaleInEnabled { get; set; }

        /// <summary>
        /// 触发带宽自动回缩的带宽平均使用率阈值，单位：百分比。支持的取值：10、20、30。该参数暂未启用。
        /// </summary>
        [JsonProperty("bandwidth_usage_lower_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? BandwidthUsageLowerThreshold { get; set; }

        /// <summary>
        /// 带宽回缩操作的静默时间（两次带宽回缩操作之间的最小间隔时间），单位：秒。该参数暂未启用。 默认值：300。取值范围：0~86400。 
        /// </summary>
        [JsonProperty("scale_in_cooldown", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScaleInCooldown { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInstanceBandwidthAutoScalingPolicyResponse {\n");
            sb.Append("  windowSize: ").Append(WindowSize).Append("\n");
            sb.Append("  bandwidthUsageUpperThreshold: ").Append(BandwidthUsageUpperThreshold).Append("\n");
            sb.Append("  scaleOutCooldown: ").Append(ScaleOutCooldown).Append("\n");
            sb.Append("  scaleInEnabled: ").Append(ScaleInEnabled).Append("\n");
            sb.Append("  bandwidthUsageLowerThreshold: ").Append(BandwidthUsageLowerThreshold).Append("\n");
            sb.Append("  scaleInCooldown: ").Append(ScaleInCooldown).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateInstanceBandwidthAutoScalingPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateInstanceBandwidthAutoScalingPolicyResponse input)
        {
            if (input == null) return false;
            if (this.WindowSize != input.WindowSize) return false;
            if (this.BandwidthUsageUpperThreshold != input.BandwidthUsageUpperThreshold) return false;
            if (this.ScaleOutCooldown != input.ScaleOutCooldown || (this.ScaleOutCooldown != null && !this.ScaleOutCooldown.Equals(input.ScaleOutCooldown))) return false;
            if (this.ScaleInEnabled != input.ScaleInEnabled || (this.ScaleInEnabled != null && !this.ScaleInEnabled.Equals(input.ScaleInEnabled))) return false;
            if (this.BandwidthUsageLowerThreshold != input.BandwidthUsageLowerThreshold || (this.BandwidthUsageLowerThreshold != null && !this.BandwidthUsageLowerThreshold.Equals(input.BandwidthUsageLowerThreshold))) return false;
            if (this.ScaleInCooldown != input.ScaleInCooldown || (this.ScaleInCooldown != null && !this.ScaleInCooldown.Equals(input.ScaleInCooldown))) return false;

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
                hashCode = hashCode * 59 + this.WindowSize.GetHashCode();
                hashCode = hashCode * 59 + this.BandwidthUsageUpperThreshold.GetHashCode();
                if (this.ScaleOutCooldown != null) hashCode = hashCode * 59 + this.ScaleOutCooldown.GetHashCode();
                if (this.ScaleInEnabled != null) hashCode = hashCode * 59 + this.ScaleInEnabled.GetHashCode();
                if (this.BandwidthUsageLowerThreshold != null) hashCode = hashCode * 59 + this.BandwidthUsageLowerThreshold.GetHashCode();
                if (this.ScaleInCooldown != null) hashCode = hashCode * 59 + this.ScaleInCooldown.GetHashCode();
                return hashCode;
            }
        }
    }
}
