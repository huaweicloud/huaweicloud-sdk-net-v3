using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListDatastoreVersionsRequest 
    {
        /// <summary>
        /// 数据库版本类型。取值为“DDS-Community”。
        /// </summary>
        /// <value>数据库版本类型。取值为“DDS-Community”。</value>
        [JsonConverter(typeof(EnumClassConverter<DatastoreNameEnum>))]
        public class DatastoreNameEnum
        {
            /// <summary>
            /// Enum DDS_COMMUNITY for value: DDS-Community
            /// </summary>
            public static readonly DatastoreNameEnum DDS_COMMUNITY = new DatastoreNameEnum("DDS-Community");

            /// <summary>
            /// Enum DDS_ENHANCED for value: DDS-Enhanced
            /// </summary>
            public static readonly DatastoreNameEnum DDS_ENHANCED = new DatastoreNameEnum("DDS-Enhanced");

            private static readonly Dictionary<string, DatastoreNameEnum> StaticFields =
            new Dictionary<string, DatastoreNameEnum>()
            {
                { "DDS-Community", DDS_COMMUNITY },
                { "DDS-Enhanced", DDS_ENHANCED },
            };

            private string _value;

            public DatastoreNameEnum()
            {

            }

            public DatastoreNameEnum(string value)
            {
                _value = value;
            }

            public static DatastoreNameEnum FromValue(string value)
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

                if (this.Equals(obj as DatastoreNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DatastoreNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DatastoreNameEnum a, DatastoreNameEnum b)
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

            public static bool operator !=(DatastoreNameEnum a, DatastoreNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数据库版本类型。取值为“DDS-Community”。
        /// </summary>
        [SDKProperty("datastore_name", IsPath = true)]
        [JsonProperty("datastore_name", NullValueHandling = NullValueHandling.Ignore)]
        public DatastoreNameEnum DatastoreName { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDatastoreVersionsRequest {\n");
            sb.Append("  datastoreName: ").Append(DatastoreName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDatastoreVersionsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDatastoreVersionsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatastoreName == input.DatastoreName ||
                    (this.DatastoreName != null &&
                    this.DatastoreName.Equals(input.DatastoreName))
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
                if (this.DatastoreName != null)
                    hashCode = hashCode * 59 + this.DatastoreName.GetHashCode();
                return hashCode;
            }
        }
    }
}
