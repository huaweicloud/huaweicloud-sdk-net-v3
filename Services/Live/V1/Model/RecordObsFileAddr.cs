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
    public class RecordObsFileAddr 
    {
        /// <summary>
        /// OBS Bucket所在RegionID
        /// </summary>
        /// <value>OBS Bucket所在RegionID</value>
        [JsonConverter(typeof(EnumClassConverter<LocationEnum>))]
        public class LocationEnum
        {
            /// <summary>
            /// Enum CN_NORTH_4 for value: cn-north-4
            /// </summary>
            public static readonly LocationEnum CN_NORTH_4 = new LocationEnum("cn-north-4");

            /// <summary>
            /// Enum CN_NORTH_5 for value: cn-north-5
            /// </summary>
            public static readonly LocationEnum CN_NORTH_5 = new LocationEnum("cn-north-5");

            /// <summary>
            /// Enum CN_NORTH_6 for value: cn-north-6
            /// </summary>
            public static readonly LocationEnum CN_NORTH_6 = new LocationEnum("cn-north-6");

            private static readonly Dictionary<string, LocationEnum> StaticFields =
            new Dictionary<string, LocationEnum>()
            {
                { "cn-north-4", CN_NORTH_4 },
                { "cn-north-5", CN_NORTH_5 },
                { "cn-north-6", CN_NORTH_6 },
            };

            private string _value;

            public LocationEnum()
            {

            }

            public LocationEnum(string value)
            {
                _value = value;
            }

            public static LocationEnum FromValue(string value)
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

                if (this.Equals(obj as LocationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LocationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LocationEnum a, LocationEnum b)
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

            public static bool operator !=(LocationEnum a, LocationEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// OBS的bucket名称
        /// </summary>
        [JsonProperty("bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string Bucket { get; set; }

        /// <summary>
        /// OBS Bucket所在RegionID
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public LocationEnum Location { get; set; }
        /// <summary>
        /// OBS对象路径，遵守OBS Object定义。如果为空则保存到根目录
        /// </summary>
        [JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
        public string Object { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordObsFileAddr {\n");
            sb.Append("  bucket: ").Append(Bucket).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecordObsFileAddr);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecordObsFileAddr input)
        {
            if (input == null) return false;
            if (this.Bucket != input.Bucket || (this.Bucket != null && !this.Bucket.Equals(input.Bucket))) return false;
            if (this.Location != input.Location) return false;
            if (this.Object != input.Object || (this.Object != null && !this.Object.Equals(input.Object))) return false;

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
                if (this.Bucket != null) hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Object != null) hashCode = hashCode * 59 + this.Object.GetHashCode();
                return hashCode;
            }
        }
    }
}
