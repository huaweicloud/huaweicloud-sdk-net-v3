using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListPrivateHooksRequest 
    {
        /// <summary>
        /// Defines sortKey
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<SortKeyEnum>))]
        public class SortKeyEnum
        {
            /// <summary>
            /// Enum CREATE_TIME for value: create_time
            /// </summary>
            public static readonly SortKeyEnum CREATE_TIME = new SortKeyEnum("create_time");

            private static readonly Dictionary<string, SortKeyEnum> StaticFields =
            new Dictionary<string, SortKeyEnum>()
            {
                { "create_time", CREATE_TIME },
            };

            private string _value;

            public SortKeyEnum()
            {

            }

            public SortKeyEnum(string value)
            {
                _value = value;
            }

            public static SortKeyEnum FromValue(string value)
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

                if (this.Equals(obj as SortKeyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortKeyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortKeyEnum a, SortKeyEnum b)
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

            public static bool operator !=(SortKeyEnum a, SortKeyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines sortDir
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<SortDirEnum>))]
        public class SortDirEnum
        {
            /// <summary>
            /// Enum ASC for value: asc
            /// </summary>
            public static readonly SortDirEnum ASC = new SortDirEnum("asc");

            /// <summary>
            /// Enum DESC for value: desc
            /// </summary>
            public static readonly SortDirEnum DESC = new SortDirEnum("desc");

            private static readonly Dictionary<string, SortDirEnum> StaticFields =
            new Dictionary<string, SortDirEnum>()
            {
                { "asc", ASC },
                { "desc", DESC },
            };

            private string _value;

            public SortDirEnum()
            {

            }

            public SortDirEnum(string value)
            {
                _value = value;
            }

            public static SortDirEnum FromValue(string value)
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

                if (this.Equals(obj as SortDirEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortDirEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortDirEnum a, SortDirEnum b)
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

            public static bool operator !=(SortDirEnum a, SortDirEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 用户指定的，对于此请求的唯一Id，用于定位某个请求，推荐使用UUID
        /// </summary>
        [SDKProperty("Client-Request-Id", IsHeader = true)]
        [JsonProperty("Client-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// 排序字段，仅支持给予create_time
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public List<SortKeyEnum> SortKey { get; set; }
        /// <summary>
        /// 指定升序还是降序   * &#x60;asc&#x60; - 升序   * &#x60;desc&#x60; - 降序
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public List<SortDirEnum> SortDir { get; set; }
        /// <summary>
        /// 分页标记。当一页无法返回所有结果，上一次的请求将返回next_marker以指引还有更多页数，用户可以将next_marker中的值放到此处以查询下一页的信息。此marker只能用于与上一请求指定的相同参数的请求。不指定时默认从第一页开始查询。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 每页返回的最多结果数量
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPrivateHooksRequest {\n");
            sb.Append("  clientRequestId: ").Append(ClientRequestId).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPrivateHooksRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPrivateHooksRequest input)
        {
            if (input == null) return false;
            if (this.ClientRequestId != input.ClientRequestId || (this.ClientRequestId != null && !this.ClientRequestId.Equals(input.ClientRequestId))) return false;
            if (this.SortKey != input.SortKey || (this.SortKey != null && input.SortKey != null && !this.SortKey.SequenceEqual(input.SortKey))) return false;
            if (this.SortDir != input.SortDir || (this.SortDir != null && input.SortDir != null && !this.SortDir.SequenceEqual(input.SortDir))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.ClientRequestId != null) hashCode = hashCode * 59 + this.ClientRequestId.GetHashCode();
                hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
