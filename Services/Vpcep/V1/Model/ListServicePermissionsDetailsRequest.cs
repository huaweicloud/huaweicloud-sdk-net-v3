using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListServicePermissionsDetailsRequest 
    {
        /// <summary>
        /// 查询结果中白名单列表的排序字段，取值为create_at，表示白名单的添加时间。
        /// </summary>
        /// <value>查询结果中白名单列表的排序字段，取值为create_at，表示白名单的添加时间。</value>
        [JsonConverter(typeof(EnumClassConverter<SortKeyEnum>))]
        public class SortKeyEnum
        {
            /// <summary>
            /// Enum CREATE_AT for value: create_at
            /// </summary>
            public static readonly SortKeyEnum CREATE_AT = new SortKeyEnum("create_at");

            /// <summary>
            /// Enum UPDATE_AT for value: update_at
            /// </summary>
            public static readonly SortKeyEnum UPDATE_AT = new SortKeyEnum("update_at");

            private static readonly Dictionary<string, SortKeyEnum> StaticFields =
            new Dictionary<string, SortKeyEnum>()
            {
                { "create_at", CREATE_AT },
                { "update_at", UPDATE_AT },
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
        /// 查询结果中白名单列表的排序方式，取值为： ● desc：降序排序 ● asc：升序排序 默认值为desc。
        /// </summary>
        /// <value>查询结果中白名单列表的排序方式，取值为： ● desc：降序排序 ● asc：升序排序 默认值为desc。</value>
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
        /// 终端节点服务的ID。
        /// </summary>
        [SDKProperty("vpc_endpoint_service_id", IsPath = true)]
        [JsonProperty("vpc_endpoint_service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcEndpointServiceId { get; set; }

        /// <summary>
        /// 权限帐号ID，格式为“iam:domain::domain_id”。 其中“domain_id”为授权用户的帐号ID， 例如“iam:domain::6e9dfd51d1124e8d8498dce894923a0d”，支持模糊搜索。
        /// </summary>
        [SDKProperty("permission", IsQuery = true)]
        [JsonProperty("permission", NullValueHandling = NullValueHandling.Ignore)]
        public string Permission { get; set; }

        /// <summary>
        /// 查询返回终端节点服务的白名单数量限制，即每页返回的个数。 取值范围：0~500，取值一般为10，20或者50，默认为10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 偏移量。 偏移量为一个大于0小于终端节点服务总个数的整数， 表示从偏移量后面的终端节点服务开始查询。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询结果中白名单列表的排序字段，取值为create_at，表示白名单的添加时间。
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public SortKeyEnum SortKey { get; set; }
        /// <summary>
        /// 查询结果中白名单列表的排序方式，取值为： ● desc：降序排序 ● asc：升序排序 默认值为desc。
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public SortDirEnum SortDir { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListServicePermissionsDetailsRequest {\n");
            sb.Append("  vpcEndpointServiceId: ").Append(VpcEndpointServiceId).Append("\n");
            sb.Append("  permission: ").Append(Permission).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServicePermissionsDetailsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServicePermissionsDetailsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VpcEndpointServiceId == input.VpcEndpointServiceId ||
                    (this.VpcEndpointServiceId != null &&
                    this.VpcEndpointServiceId.Equals(input.VpcEndpointServiceId))
                ) && 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.SortKey == input.SortKey ||
                    (this.SortKey != null &&
                    this.SortKey.Equals(input.SortKey))
                ) && 
                (
                    this.SortDir == input.SortDir ||
                    (this.SortDir != null &&
                    this.SortDir.Equals(input.SortDir))
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
                if (this.VpcEndpointServiceId != null)
                    hashCode = hashCode * 59 + this.VpcEndpointServiceId.GetHashCode();
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.SortKey != null)
                    hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                if (this.SortDir != null)
                    hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                return hashCode;
            }
        }
    }
}
