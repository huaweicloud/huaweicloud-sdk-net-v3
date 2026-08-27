using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListServersByHostIdRequest 
    {
        /// <summary>
        /// 排序字段名称，需要结合sort_type字段一起使用。 - vcpu CPU核数 - memory 内存大小
        /// </summary>
        /// <value>排序字段名称，需要结合sort_type字段一起使用。 - vcpu CPU核数 - memory 内存大小</value>
        [JsonConverter(typeof(EnumClassConverter<SortFieldEnum>))]
        public class SortFieldEnum
        {
            /// <summary>
            /// Enum VCPU for value: vcpu
            /// </summary>
            public static readonly SortFieldEnum VCPU = new SortFieldEnum("vcpu");

            /// <summary>
            /// Enum MEMORY for value: memory
            /// </summary>
            public static readonly SortFieldEnum MEMORY = new SortFieldEnum("memory");

            private static readonly Dictionary<string, SortFieldEnum> StaticFields =
            new Dictionary<string, SortFieldEnum>()
            {
                { "vcpu", VCPU },
                { "memory", MEMORY },
            };

            private string _value;

            public SortFieldEnum()
            {

            }

            public SortFieldEnum(string value)
            {
                _value = value;
            }

            public static SortFieldEnum FromValue(string value)
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

                if (this.Equals(obj as SortFieldEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortFieldEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortFieldEnum a, SortFieldEnum b)
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

            public static bool operator !=(SortFieldEnum a, SortFieldEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 排序类型，默认升序，需要结合sort_field字段一起使用。 - ASC 升序。 - DESC 降序。
        /// </summary>
        /// <value>排序类型，默认升序，需要结合sort_field字段一起使用。 - ASC 升序。 - DESC 降序。</value>
        [JsonConverter(typeof(EnumClassConverter<SortTypeEnum>))]
        public class SortTypeEnum
        {
            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            public static readonly SortTypeEnum ASC = new SortTypeEnum("ASC");

            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            public static readonly SortTypeEnum DESC = new SortTypeEnum("DESC");

            private static readonly Dictionary<string, SortTypeEnum> StaticFields =
            new Dictionary<string, SortTypeEnum>()
            {
                { "ASC", ASC },
                { "DESC", DESC },
            };

            private string _value;

            public SortTypeEnum()
            {

            }

            public SortTypeEnum(string value)
            {
                _value = value;
            }

            public static SortTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SortTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortTypeEnum a, SortTypeEnum b)
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

            public static bool operator !=(SortTypeEnum a, SortTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 云办公主机id。
        /// </summary>
        [SDKProperty("host_id", IsPath = true)]
        [JsonProperty("host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HostId { get; set; }

        /// <summary>
        /// 排序字段名称，需要结合sort_type字段一起使用。 - vcpu CPU核数 - memory 内存大小
        /// </summary>
        [SDKProperty("sort_field", IsQuery = true)]
        [JsonProperty("sort_field", NullValueHandling = NullValueHandling.Ignore)]
        public SortFieldEnum SortField { get; set; }
        /// <summary>
        /// 排序类型，默认升序，需要结合sort_field字段一起使用。 - ASC 升序。 - DESC 降序。
        /// </summary>
        [SDKProperty("sort_type", IsQuery = true)]
        [JsonProperty("sort_type", NullValueHandling = NullValueHandling.Ignore)]
        public SortTypeEnum SortType { get; set; }
        /// <summary>
        /// 每页显示的数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 用于分页查询，查询的起始记录序号，从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListServersByHostIdRequest {\n");
            sb.Append("  hostId: ").Append(HostId).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("  sortType: ").Append(SortType).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServersByHostIdRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServersByHostIdRequest input)
        {
            if (input == null) return false;
            if (this.HostId != input.HostId || (this.HostId != null && !this.HostId.Equals(input.HostId))) return false;
            if (this.SortField != input.SortField) return false;
            if (this.SortType != input.SortType) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;

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
                if (this.HostId != null) hashCode = hashCode * 59 + this.HostId.GetHashCode();
                hashCode = hashCode * 59 + this.SortField.GetHashCode();
                hashCode = hashCode * 59 + this.SortType.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
