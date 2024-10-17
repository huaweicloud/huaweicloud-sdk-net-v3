using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cts.V3.Model
{
    /// <summary>
    /// 追踪桶信息。
    /// </summary>
    public class DataBucketQuery 
    {
        /// <summary>
        /// Defines dataEvent
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<DataEventEnum>))]
        public class DataEventEnum
        {
            /// <summary>
            /// Enum WRITE for value: WRITE
            /// </summary>
            public static readonly DataEventEnum WRITE = new DataEventEnum("WRITE");

            /// <summary>
            /// Enum READ for value: READ
            /// </summary>
            public static readonly DataEventEnum READ = new DataEventEnum("READ");

            private static readonly Dictionary<string, DataEventEnum> StaticFields =
            new Dictionary<string, DataEventEnum>()
            {
                { "WRITE", WRITE },
                { "READ", READ },
            };

            private string _value;

            public DataEventEnum()
            {

            }

            public DataEventEnum(string value)
            {
                _value = value;
            }

            public static DataEventEnum FromValue(string value)
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

                if (this.Equals(obj as DataEventEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DataEventEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DataEventEnum a, DataEventEnum b)
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

            public static bool operator !=(DataEventEnum a, DataEventEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 标识OBS桶名称。由数字或字母开头，支持小写字母、数字、“-”、“.”，长度为3～63个字符。
        /// </summary>
        [JsonProperty("data_bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DataBucketName { get; set; }

        /// <summary>
        /// 追踪桶日志是否支持搜索。
        /// </summary>
        [JsonProperty("search_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SearchEnabled { get; set; }

        /// <summary>
        /// 数据类追踪器追踪对象的桶名。 - 当启用或者停用数据类追踪器时，该参数为必选。 - 管理类追踪器无此参数。 - 追踪器一旦创建追踪桶无法修改。
        /// </summary>
        [JsonProperty("data_event", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataEventEnum> DataEvent { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataBucketQuery {\n");
            sb.Append("  dataBucketName: ").Append(DataBucketName).Append("\n");
            sb.Append("  searchEnabled: ").Append(SearchEnabled).Append("\n");
            sb.Append("  dataEvent: ").Append(DataEvent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataBucketQuery);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataBucketQuery input)
        {
            if (input == null) return false;
            if (this.DataBucketName != input.DataBucketName || (this.DataBucketName != null && !this.DataBucketName.Equals(input.DataBucketName))) return false;
            if (this.SearchEnabled != input.SearchEnabled || (this.SearchEnabled != null && !this.SearchEnabled.Equals(input.SearchEnabled))) return false;
            if (this.DataEvent != input.DataEvent || (this.DataEvent != null && input.DataEvent != null && !this.DataEvent.SequenceEqual(input.DataEvent))) return false;

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
                if (this.DataBucketName != null) hashCode = hashCode * 59 + this.DataBucketName.GetHashCode();
                if (this.SearchEnabled != null) hashCode = hashCode * 59 + this.SearchEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.DataEvent.GetHashCode();
                return hashCode;
            }
        }
    }
}
