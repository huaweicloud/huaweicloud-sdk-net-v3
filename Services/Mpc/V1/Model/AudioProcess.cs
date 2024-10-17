using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AudioProcess 
    {
        /// <summary>
        /// 音量调整方式： - auto：表示自动调整音量。 - dynamic：表示人为调整，需设定音量调整幅值。 
        /// </summary>
        /// <value>音量调整方式： - auto：表示自动调整音量。 - dynamic：表示人为调整，需设定音量调整幅值。 </value>
        [JsonConverter(typeof(EnumClassConverter<VolumeEnum>))]
        public class VolumeEnum
        {
            /// <summary>
            /// Enum AUTO for value: auto
            /// </summary>
            public static readonly VolumeEnum AUTO = new VolumeEnum("auto");

            /// <summary>
            /// Enum DYNAMIC for value: dynamic
            /// </summary>
            public static readonly VolumeEnum DYNAMIC = new VolumeEnum("dynamic");

            /// <summary>
            /// Enum ORIGINAL for value: original
            /// </summary>
            public static readonly VolumeEnum ORIGINAL = new VolumeEnum("original");

            private static readonly Dictionary<string, VolumeEnum> StaticFields =
            new Dictionary<string, VolumeEnum>()
            {
                { "auto", AUTO },
                { "dynamic", DYNAMIC },
                { "original", ORIGINAL },
            };

            private string _value;

            public VolumeEnum()
            {

            }

            public VolumeEnum(string value)
            {
                _value = value;
            }

            public static VolumeEnum FromValue(string value)
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

                if (this.Equals(obj as VolumeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VolumeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VolumeEnum a, VolumeEnum b)
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

            public static bool operator !=(VolumeEnum a, VolumeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 音量调整方式： - auto：表示自动调整音量。 - dynamic：表示人为调整，需设定音量调整幅值。 
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeEnum Volume { get; set; }
        /// <summary>
        /// 音量调整幅值，需指定volume为dynamic。  取值范围：[-15,15]  单位：dB 
        /// </summary>
        [JsonProperty("volume_expr", NullValueHandling = NullValueHandling.Ignore)]
        public int? VolumeExpr { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioProcess {\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("  volumeExpr: ").Append(VolumeExpr).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudioProcess);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AudioProcess input)
        {
            if (input == null) return false;
            if (this.Volume != input.Volume) return false;
            if (this.VolumeExpr != input.VolumeExpr || (this.VolumeExpr != null && !this.VolumeExpr.Equals(input.VolumeExpr))) return false;

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
                hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.VolumeExpr != null) hashCode = hashCode * 59 + this.VolumeExpr.GetHashCode();
                return hashCode;
            }
        }
    }
}
