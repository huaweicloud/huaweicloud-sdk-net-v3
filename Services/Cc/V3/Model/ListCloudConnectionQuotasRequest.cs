using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListCloudConnectionQuotasRequest 
    {
        /// <summary>
        /// 配额类型： - cloud_connection: 可加载的云连接实例数 - cloud_connection_region: 某云连接实例下可加载的Region数 - cloud_connection_route: 某云连接实例下可加载的路由数 - region_network_instance: 某云连接实例下某个Region下可加载的网络实例数
        /// </summary>
        /// <value>配额类型： - cloud_connection: 可加载的云连接实例数 - cloud_connection_region: 某云连接实例下可加载的Region数 - cloud_connection_route: 某云连接实例下可加载的路由数 - region_network_instance: 某云连接实例下某个Region下可加载的网络实例数</value>
        [JsonConverter(typeof(EnumClassConverter<QuotaTypeEnum>))]
        public class QuotaTypeEnum
        {
            /// <summary>
            /// Enum CLOUD_CONNECTION for value: cloud_connection
            /// </summary>
            public static readonly QuotaTypeEnum CLOUD_CONNECTION = new QuotaTypeEnum("cloud_connection");

            /// <summary>
            /// Enum CLOUD_CONNECTION_REGION for value: cloud_connection_region
            /// </summary>
            public static readonly QuotaTypeEnum CLOUD_CONNECTION_REGION = new QuotaTypeEnum("cloud_connection_region");

            /// <summary>
            /// Enum CLOUD_CONNECTION_ROUTE for value: cloud_connection_route
            /// </summary>
            public static readonly QuotaTypeEnum CLOUD_CONNECTION_ROUTE = new QuotaTypeEnum("cloud_connection_route");

            /// <summary>
            /// Enum REGION_NETWORK_INSTANCE for value: region_network_instance
            /// </summary>
            public static readonly QuotaTypeEnum REGION_NETWORK_INSTANCE = new QuotaTypeEnum("region_network_instance");

            private static readonly Dictionary<string, QuotaTypeEnum> StaticFields =
            new Dictionary<string, QuotaTypeEnum>()
            {
                { "cloud_connection", CLOUD_CONNECTION },
                { "cloud_connection_region", CLOUD_CONNECTION_REGION },
                { "cloud_connection_route", CLOUD_CONNECTION_ROUTE },
                { "region_network_instance", REGION_NETWORK_INSTANCE },
            };

            private string _value;

            public QuotaTypeEnum()
            {

            }

            public QuotaTypeEnum(string value)
            {
                _value = value;
            }

            public static QuotaTypeEnum FromValue(string value)
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

                if (this.Equals(obj as QuotaTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(QuotaTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(QuotaTypeEnum a, QuotaTypeEnum b)
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

            public static bool operator !=(QuotaTypeEnum a, QuotaTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 每页返回的个数。 取值范围：1~2000。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 翻页信息，从上次API调用返回的翻页数据中获取，可填写前一页marker或者后一页marker，填入前一页previous_marker就向前翻页，后一页next_marker就向后翻页。 翻页过程中，查询条件不能修改，包括过滤条件、排序条件、limit。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 配额类型： - cloud_connection: 可加载的云连接实例数 - cloud_connection_region: 某云连接实例下可加载的Region数 - cloud_connection_route: 某云连接实例下可加载的路由数 - region_network_instance: 某云连接实例下某个Region下可加载的网络实例数
        /// </summary>
        [SDKProperty("quota_type", IsQuery = true)]
        [JsonProperty("quota_type", NullValueHandling = NullValueHandling.Ignore)]
        public QuotaTypeEnum QuotaType { get; set; }
        /// <summary>
        /// 云连接ID。当查询cloud_connection_region、cloud_connection_route、region_network_instance三种类型的配额时需要填写此参数。
        /// </summary>
        [SDKProperty("cloud_connection_id", IsQuery = true)]
        [JsonProperty("cloud_connection_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudConnectionId { get; set; }

        /// <summary>
        /// 区域ID。当查询region_network_instance类型的配额时需要填写此参数。
        /// </summary>
        [SDKProperty("region_id", IsQuery = true)]
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCloudConnectionQuotasRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  quotaType: ").Append(QuotaType).Append("\n");
            sb.Append("  cloudConnectionId: ").Append(CloudConnectionId).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCloudConnectionQuotasRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCloudConnectionQuotasRequest input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.QuotaType != input.QuotaType) return false;
            if (this.CloudConnectionId != input.CloudConnectionId || (this.CloudConnectionId != null && !this.CloudConnectionId.Equals(input.CloudConnectionId))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                hashCode = hashCode * 59 + this.QuotaType.GetHashCode();
                if (this.CloudConnectionId != null) hashCode = hashCode * 59 + this.CloudConnectionId.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
