using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ObsAuthorityConfig 
    {
        /// <summary>
        /// 查询bucket所在的region - cn-north-4 - cn-north-1 - cn-north-5 - cn-north-6 - cn-south-1 - cn-east-2
        /// </summary>
        /// <value>查询bucket所在的region - cn-north-4 - cn-north-1 - cn-north-5 - cn-north-6 - cn-south-1 - cn-east-2</value>
        [JsonConverter(typeof(EnumClassConverter<LocationEnum>))]
        public class LocationEnum
        {
            /// <summary>
            /// Enum CN_NORTH_4 for value: cn-north-4
            /// </summary>
            public static readonly LocationEnum CN_NORTH_4 = new LocationEnum("cn-north-4");

            /// <summary>
            /// Enum CN_NORTH_1 for value: cn-north-1
            /// </summary>
            public static readonly LocationEnum CN_NORTH_1 = new LocationEnum("cn-north-1");

            /// <summary>
            /// Enum CN_NORTH_5 for value: cn-north-5
            /// </summary>
            public static readonly LocationEnum CN_NORTH_5 = new LocationEnum("cn-north-5");

            /// <summary>
            /// Enum CN_NORTH_6 for value: cn-north-6
            /// </summary>
            public static readonly LocationEnum CN_NORTH_6 = new LocationEnum("cn-north-6");

            /// <summary>
            /// Enum CN_SOUTH_1 for value: cn-south-1
            /// </summary>
            public static readonly LocationEnum CN_SOUTH_1 = new LocationEnum("cn-south-1");

            /// <summary>
            /// Enum CN_EAST_2 for value: cn-east-2
            /// </summary>
            public static readonly LocationEnum CN_EAST_2 = new LocationEnum("cn-east-2");

            private static readonly Dictionary<string, LocationEnum> StaticFields =
            new Dictionary<string, LocationEnum>()
            {
                { "cn-north-4", CN_NORTH_4 },
                { "cn-north-1", CN_NORTH_1 },
                { "cn-north-5", CN_NORTH_5 },
                { "cn-north-6", CN_NORTH_6 },
                { "cn-south-1", CN_SOUTH_1 },
                { "cn-east-2", CN_EAST_2 },
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

            public static bool operator !=(LocationEnum a, LocationEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// OBS桶名
        /// </summary>
        [JsonProperty("bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string Bucket { get; set; }

        /// <summary>
        /// 操作，1-授权；0-取消授权
        /// </summary>
        [JsonProperty("operation", NullValueHandling = NullValueHandling.Ignore)]
        public int? Operation { get; set; }

        /// <summary>
        /// 查询bucket所在的region - cn-north-4 - cn-north-1 - cn-north-5 - cn-north-6 - cn-south-1 - cn-east-2
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public LocationEnum Location { get; set; }
        /// <summary>
        /// 租户华为云账号projectid
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObsAuthorityConfig {\n");
            sb.Append("  bucket: ").Append(Bucket).Append("\n");
            sb.Append("  operation: ").Append(Operation).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObsAuthorityConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObsAuthorityConfig input)
        {
            if (input == null) return false;
            if (this.Bucket != input.Bucket || (this.Bucket != null && !this.Bucket.Equals(input.Bucket))) return false;
            if (this.Operation != input.Operation || (this.Operation != null && !this.Operation.Equals(input.Operation))) return false;
            if (this.Location != input.Location) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;

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
                if (this.Operation != null) hashCode = hashCode * 59 + this.Operation.GetHashCode();
                hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
