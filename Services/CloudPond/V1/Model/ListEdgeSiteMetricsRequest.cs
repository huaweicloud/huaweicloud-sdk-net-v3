using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListEdgeSiteMetricsRequest 
    {
        /// <summary>
        /// 指定维度查询 - site_id: 按站点维度，查询站点下计算、存储资源容量信息 - flavor: 按规格维度，查询站点下各flavor的计算资源使用情况 - storage: 按存储维度，查询站点下各存储资源类型的使用情况 - flavor_capacity: 按规格容量维度，查询站点下各规格可发放数量预测 - storage_pool：按存储池维度，查询站点下各存储池的使用情况
        /// </summary>
        /// <value>指定维度查询 - site_id: 按站点维度，查询站点下计算、存储资源容量信息 - flavor: 按规格维度，查询站点下各flavor的计算资源使用情况 - storage: 按存储维度，查询站点下各存储资源类型的使用情况 - flavor_capacity: 按规格容量维度，查询站点下各规格可发放数量预测 - storage_pool：按存储池维度，查询站点下各存储池的使用情况</value>
        [JsonConverter(typeof(EnumClassConverter<DimEnum>))]
        public class DimEnum
        {
            /// <summary>
            /// Enum SITE_ID for value: site_id
            /// </summary>
            public static readonly DimEnum SITE_ID = new DimEnum("site_id");

            /// <summary>
            /// Enum FLAVOR for value: flavor
            /// </summary>
            public static readonly DimEnum FLAVOR = new DimEnum("flavor");

            /// <summary>
            /// Enum STORAGE for value: storage
            /// </summary>
            public static readonly DimEnum STORAGE = new DimEnum("storage");

            /// <summary>
            /// Enum FLAVOR_CAPACITY for value: flavor_capacity
            /// </summary>
            public static readonly DimEnum FLAVOR_CAPACITY = new DimEnum("flavor_capacity");

            /// <summary>
            /// Enum STORAGE_POOL for value: storage_pool
            /// </summary>
            public static readonly DimEnum STORAGE_POOL = new DimEnum("storage_pool");

            private static readonly Dictionary<string, DimEnum> StaticFields =
            new Dictionary<string, DimEnum>()
            {
                { "site_id", SITE_ID },
                { "flavor", FLAVOR },
                { "storage", STORAGE },
                { "flavor_capacity", FLAVOR_CAPACITY },
                { "storage_pool", STORAGE_POOL },
            };

            private string _value;

            public DimEnum()
            {

            }

            public DimEnum(string value)
            {
                _value = value;
            }

            public static DimEnum FromValue(string value)
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

                if (this.Equals(obj as DimEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DimEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DimEnum a, DimEnum b)
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

            public static bool operator !=(DimEnum a, DimEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 边缘小站ID
        /// </summary>
        [SDKProperty("site_id", IsPath = true)]
        [JsonProperty("site_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteId { get; set; }

        /// <summary>
        /// 指定维度查询 - site_id: 按站点维度，查询站点下计算、存储资源容量信息 - flavor: 按规格维度，查询站点下各flavor的计算资源使用情况 - storage: 按存储维度，查询站点下各存储资源类型的使用情况 - flavor_capacity: 按规格容量维度，查询站点下各规格可发放数量预测 - storage_pool：按存储池维度，查询站点下各存储池的使用情况
        /// </summary>
        [SDKProperty("dim", IsQuery = true)]
        [JsonProperty("dim", NullValueHandling = NullValueHandling.Ignore)]
        public DimEnum Dim { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEdgeSiteMetricsRequest {\n");
            sb.Append("  siteId: ").Append(SiteId).Append("\n");
            sb.Append("  dim: ").Append(Dim).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEdgeSiteMetricsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEdgeSiteMetricsRequest input)
        {
            if (input == null) return false;
            if (this.SiteId != input.SiteId || (this.SiteId != null && !this.SiteId.Equals(input.SiteId))) return false;
            if (this.Dim != input.Dim) return false;

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
                if (this.SiteId != null) hashCode = hashCode * 59 + this.SiteId.GetHashCode();
                hashCode = hashCode * 59 + this.Dim.GetHashCode();
                return hashCode;
            }
        }
    }
}
