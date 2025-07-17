using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class SetQosThresholdRequest 
    {
        /// <summary>
        /// 阈值类型： * AUDIO：音频相关阈值 * VIDEO：视频相关阈值 * SCREEN：屏幕共享相关阈值 * CPU：CPU相关阈值
        /// </summary>
        /// <value>阈值类型： * AUDIO：音频相关阈值 * VIDEO：视频相关阈值 * SCREEN：屏幕共享相关阈值 * CPU：CPU相关阈值</value>
        [JsonConverter(typeof(EnumClassConverter<ThresholdTypeEnum>))]
        public class ThresholdTypeEnum
        {
            /// <summary>
            /// Enum AUDIO for value: AUDIO
            /// </summary>
            public static readonly ThresholdTypeEnum AUDIO = new ThresholdTypeEnum("AUDIO");

            /// <summary>
            /// Enum VIDEO for value: VIDEO
            /// </summary>
            public static readonly ThresholdTypeEnum VIDEO = new ThresholdTypeEnum("VIDEO");

            /// <summary>
            /// Enum SCREEN for value: SCREEN
            /// </summary>
            public static readonly ThresholdTypeEnum SCREEN = new ThresholdTypeEnum("SCREEN");

            /// <summary>
            /// Enum CPU for value: CPU
            /// </summary>
            public static readonly ThresholdTypeEnum CPU = new ThresholdTypeEnum("CPU");

            private static readonly Dictionary<string, ThresholdTypeEnum> StaticFields =
            new Dictionary<string, ThresholdTypeEnum>()
            {
                { "AUDIO", AUDIO },
                { "VIDEO", VIDEO },
                { "SCREEN", SCREEN },
                { "CPU", CPU },
            };

            private string _value;

            public ThresholdTypeEnum()
            {

            }

            public ThresholdTypeEnum(string value)
            {
                _value = value;
            }

            public static ThresholdTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ThresholdTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ThresholdTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ThresholdTypeEnum a, ThresholdTypeEnum b)
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

            public static bool operator !=(ThresholdTypeEnum a, ThresholdTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 阈值类型： * AUDIO：音频相关阈值 * VIDEO：视频相关阈值 * SCREEN：屏幕共享相关阈值 * CPU：CPU相关阈值
        /// </summary>
        [SDKProperty("thresholdType", IsQuery = true)]
        [JsonProperty("thresholdType", NullValueHandling = NullValueHandling.Ignore)]
        public ThresholdTypeEnum ThresholdType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public SetQosThresholdReq Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetQosThresholdRequest {\n");
            sb.Append("  thresholdType: ").Append(ThresholdType).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetQosThresholdRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetQosThresholdRequest input)
        {
            if (input == null) return false;
            if (this.ThresholdType != input.ThresholdType) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                hashCode = hashCode * 59 + this.ThresholdType.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
