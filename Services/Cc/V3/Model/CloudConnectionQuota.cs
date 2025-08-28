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
    /// 配额实例
    /// </summary>
    public class CloudConnectionQuota 
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

            public static bool operator !=(QuotaTypeEnum a, QuotaTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例所属账号ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 云连接实例ID。
        /// </summary>
        [JsonProperty("cloud_connection_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudConnectionId { get; set; }

        /// <summary>
        /// RegionID。
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// 配额类型： - cloud_connection: 可加载的云连接实例数 - cloud_connection_region: 某云连接实例下可加载的Region数 - cloud_connection_route: 某云连接实例下可加载的路由数 - region_network_instance: 某云连接实例下某个Region下可加载的网络实例数
        /// </summary>
        [JsonProperty("quota_type", NullValueHandling = NullValueHandling.Ignore)]
        public QuotaTypeEnum QuotaType { get; set; }
        /// <summary>
        /// 配额数量。
        /// </summary>
        [JsonProperty("quota_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotaNumber { get; set; }

        /// <summary>
        /// 配额使用数量。
        /// </summary>
        [JsonProperty("quota_used", NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotaUsed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudConnectionQuota {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  cloudConnectionId: ").Append(CloudConnectionId).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  quotaType: ").Append(QuotaType).Append("\n");
            sb.Append("  quotaNumber: ").Append(QuotaNumber).Append("\n");
            sb.Append("  quotaUsed: ").Append(QuotaUsed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloudConnectionQuota);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloudConnectionQuota input)
        {
            if (input == null) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.CloudConnectionId != input.CloudConnectionId || (this.CloudConnectionId != null && !this.CloudConnectionId.Equals(input.CloudConnectionId))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.QuotaType != input.QuotaType) return false;
            if (this.QuotaNumber != input.QuotaNumber || (this.QuotaNumber != null && !this.QuotaNumber.Equals(input.QuotaNumber))) return false;
            if (this.QuotaUsed != input.QuotaUsed || (this.QuotaUsed != null && !this.QuotaUsed.Equals(input.QuotaUsed))) return false;

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
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.CloudConnectionId != null) hashCode = hashCode * 59 + this.CloudConnectionId.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                hashCode = hashCode * 59 + this.QuotaType.GetHashCode();
                if (this.QuotaNumber != null) hashCode = hashCode * 59 + this.QuotaNumber.GetHashCode();
                if (this.QuotaUsed != null) hashCode = hashCode * 59 + this.QuotaUsed.GetHashCode();
                return hashCode;
            }
        }
    }
}
