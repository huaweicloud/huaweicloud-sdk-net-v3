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
    /// Request Object
    /// </summary>
    public class ListObsBucketObjectsRequest 
    {
        /// <summary>
        /// 查询类似，取值“folders”“objects”前者为查询目录，后者为查询对象
        /// </summary>
        /// <value>查询类似，取值“folders”“objects”前者为查询目录，后者为查询对象</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum FOLDERS for value: folders
            /// </summary>
            public static readonly TypeEnum FOLDERS = new TypeEnum("folders");

            /// <summary>
            /// Enum OBJECTS for value: objects
            /// </summary>
            public static readonly TypeEnum OBJECTS = new TypeEnum("objects");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "folders", FOLDERS },
                { "objects", OBJECTS },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 查询bucket所在的region
        /// </summary>
        /// <value>查询bucket所在的region</value>
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
        /// 要查询的桶名
        /// </summary>
        [SDKProperty("bucket", IsQuery = true)]
        [JsonProperty("bucket", NullValueHandling = NullValueHandling.Ignore)]
        public string Bucket { get; set; }

        /// <summary>
        /// 对象名前缀，可以理解为文件夹路径
        /// </summary>
        [SDKProperty("prefix", IsQuery = true)]
        [JsonProperty("prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string Prefix { get; set; }

        /// <summary>
        /// 查询类似，取值“folders”“objects”前者为查询目录，后者为查询对象
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 查询bucket所在的region
        /// </summary>
        [SDKProperty("location", IsQuery = true)]
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public LocationEnum Location { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListObsBucketObjectsRequest {\n");
            sb.Append("  bucket: ").Append(Bucket).Append("\n");
            sb.Append("  prefix: ").Append(Prefix).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListObsBucketObjectsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListObsBucketObjectsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bucket == input.Bucket ||
                    (this.Bucket != null &&
                    this.Bucket.Equals(input.Bucket))
                ) && 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Bucket != null)
                    hashCode = hashCode * 59 + this.Bucket.GetHashCode();
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                return hashCode;
            }
        }
    }
}
