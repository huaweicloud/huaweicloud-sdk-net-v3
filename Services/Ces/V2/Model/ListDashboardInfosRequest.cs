using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListDashboardInfosRequest 
    {
        /// <summary>
        /// 监控看板类型, monitor_dashboard表示监控大盘,other表示自定义看板
        /// </summary>
        /// <value>监控看板类型, monitor_dashboard表示监控大盘,other表示自定义看板</value>
        [JsonConverter(typeof(EnumClassConverter<DashboardTypeEnum>))]
        public class DashboardTypeEnum
        {
            /// <summary>
            /// Enum MONITOR_DASHBOARD for value: monitor_dashboard
            /// </summary>
            public static readonly DashboardTypeEnum MONITOR_DASHBOARD = new DashboardTypeEnum("monitor_dashboard");

            /// <summary>
            /// Enum OTHER for value: other
            /// </summary>
            public static readonly DashboardTypeEnum OTHER = new DashboardTypeEnum("other");

            private static readonly Dictionary<string, DashboardTypeEnum> StaticFields =
            new Dictionary<string, DashboardTypeEnum>()
            {
                { "monitor_dashboard", MONITOR_DASHBOARD },
                { "other", OTHER },
            };

            private string _value;

            public DashboardTypeEnum()
            {

            }

            public DashboardTypeEnum(string value)
            {
                _value = value;
            }

            public static DashboardTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DashboardTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DashboardTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DashboardTypeEnum a, DashboardTypeEnum b)
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

            public static bool operator !=(DashboardTypeEnum a, DashboardTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 企业项目Id
        /// </summary>
        [SDKProperty("enterprise_id", IsQuery = true)]
        [JsonProperty("enterprise_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 指定企业项目下监控看板是否收藏，true:收藏，false:未收藏，填此参数时，enterprise_id必填
        /// </summary>
        [SDKProperty("is_favorite", IsQuery = true)]
        [JsonProperty("is_favorite", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// 监控看板名称
        /// </summary>
        [SDKProperty("dashboard_name", IsQuery = true)]
        [JsonProperty("dashboard_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DashboardName { get; set; }

        /// <summary>
        /// 监控看板id
        /// </summary>
        [SDKProperty("dashboard_id", IsQuery = true)]
        [JsonProperty("dashboard_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DashboardId { get; set; }

        /// <summary>
        /// 监控看板类型, monitor_dashboard表示监控大盘,other表示自定义看板
        /// </summary>
        [SDKProperty("dashboard_type", IsQuery = true)]
        [JsonProperty("dashboard_type", NullValueHandling = NullValueHandling.Ignore)]
        public DashboardTypeEnum DashboardType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDashboardInfosRequest {\n");
            sb.Append("  enterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  isFavorite: ").Append(IsFavorite).Append("\n");
            sb.Append("  dashboardName: ").Append(DashboardName).Append("\n");
            sb.Append("  dashboardId: ").Append(DashboardId).Append("\n");
            sb.Append("  dashboardType: ").Append(DashboardType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDashboardInfosRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDashboardInfosRequest input)
        {
            if (input == null) return false;
            if (this.EnterpriseId != input.EnterpriseId || (this.EnterpriseId != null && !this.EnterpriseId.Equals(input.EnterpriseId))) return false;
            if (this.IsFavorite != input.IsFavorite || (this.IsFavorite != null && !this.IsFavorite.Equals(input.IsFavorite))) return false;
            if (this.DashboardName != input.DashboardName || (this.DashboardName != null && !this.DashboardName.Equals(input.DashboardName))) return false;
            if (this.DashboardId != input.DashboardId || (this.DashboardId != null && !this.DashboardId.Equals(input.DashboardId))) return false;
            if (this.DashboardType != input.DashboardType) return false;

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
                if (this.EnterpriseId != null) hashCode = hashCode * 59 + this.EnterpriseId.GetHashCode();
                if (this.IsFavorite != null) hashCode = hashCode * 59 + this.IsFavorite.GetHashCode();
                if (this.DashboardName != null) hashCode = hashCode * 59 + this.DashboardName.GetHashCode();
                if (this.DashboardId != null) hashCode = hashCode * 59 + this.DashboardId.GetHashCode();
                hashCode = hashCode * 59 + this.DashboardType.GetHashCode();
                return hashCode;
            }
        }
    }
}
