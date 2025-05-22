using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoDescriptions 
    {
        /// <summary>
        /// 自定义gop时长，单位秒，有效取值[0,10]. 默认值0，表示跟随源流，不支持7和9，值无效时按默认值处理
        /// </summary>
        /// <value>自定义gop时长，单位秒，有效取值[0,10]. 默认值0，表示跟随源流，不支持7和9，值无效时按默认值处理</value>
        [JsonConverter(typeof(EnumClassConverter<GopDurationSecondsEnum>))]
        public class GopDurationSecondsEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly GopDurationSecondsEnum NUMBER_0 = new GopDurationSecondsEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly GopDurationSecondsEnum NUMBER_1 = new GopDurationSecondsEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly GopDurationSecondsEnum NUMBER_2 = new GopDurationSecondsEnum(2);

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            public static readonly GopDurationSecondsEnum NUMBER_3 = new GopDurationSecondsEnum(3);

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            public static readonly GopDurationSecondsEnum NUMBER_4 = new GopDurationSecondsEnum(4);

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            public static readonly GopDurationSecondsEnum NUMBER_5 = new GopDurationSecondsEnum(5);

            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            public static readonly GopDurationSecondsEnum NUMBER_6 = new GopDurationSecondsEnum(6);

            /// <summary>
            /// Enum NUMBER_8 for value: 8
            /// </summary>
            public static readonly GopDurationSecondsEnum NUMBER_8 = new GopDurationSecondsEnum(8);

            /// <summary>
            /// Enum NUMBER_10 for value: 10
            /// </summary>
            public static readonly GopDurationSecondsEnum NUMBER_10 = new GopDurationSecondsEnum(10);

            private static readonly Dictionary<int?, GopDurationSecondsEnum> StaticFields =
            new Dictionary<int?, GopDurationSecondsEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
                { 3, NUMBER_3 },
                { 4, NUMBER_4 },
                { 5, NUMBER_5 },
                { 6, NUMBER_6 },
                { 8, NUMBER_8 },
                { 10, NUMBER_10 },
            };

            private int? _value;

            public GopDurationSecondsEnum()
            {

            }

            public GopDurationSecondsEnum(int? value)
            {
                _value = value;
            }

            public static GopDurationSecondsEnum FromValue(int? value)
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

                if (this.Equals(obj as GopDurationSecondsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(GopDurationSecondsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(GopDurationSecondsEnum a, GopDurationSecondsEnum b)
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

            public static bool operator !=(GopDurationSecondsEnum a, GopDurationSecondsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 自定义gop时长，单位秒，有效取值[0,10]. 默认值0，表示跟随源流，不支持7和9，值无效时按默认值处理
        /// </summary>
        [JsonProperty("gop_duration_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public GopDurationSecondsEnum GopDurationSeconds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoDescriptions {\n");
            sb.Append("  gopDurationSeconds: ").Append(GopDurationSeconds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoDescriptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoDescriptions input)
        {
            if (input == null) return false;
            if (this.GopDurationSeconds != input.GopDurationSeconds) return false;

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
                hashCode = hashCode * 59 + this.GopDurationSeconds.GetHashCode();
                return hashCode;
            }
        }
    }
}
