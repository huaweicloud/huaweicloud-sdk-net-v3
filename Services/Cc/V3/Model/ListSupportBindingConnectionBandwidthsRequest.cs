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
    public class ListSupportBindingConnectionBandwidthsRequest 
    {
        /// <summary>
        /// 根据支持绑定实例类型过滤全域互联带宽列表。实例类型： - CC: 云连接 - GEIP: 全域弹性公网IP - GCN: 中心网络 - GSN: 分支网络
        /// </summary>
        /// <value>根据支持绑定实例类型过滤全域互联带宽列表。实例类型： - CC: 云连接 - GEIP: 全域弹性公网IP - GCN: 中心网络 - GSN: 分支网络</value>
        [JsonConverter(typeof(EnumClassConverter<BindingServiceEnum>))]
        public class BindingServiceEnum
        {
            /// <summary>
            /// Enum CC for value: CC
            /// </summary>
            public static readonly BindingServiceEnum CC = new BindingServiceEnum("CC");

            /// <summary>
            /// Enum GEIP for value: GEIP
            /// </summary>
            public static readonly BindingServiceEnum GEIP = new BindingServiceEnum("GEIP");

            /// <summary>
            /// Enum GCN for value: GCN
            /// </summary>
            public static readonly BindingServiceEnum GCN = new BindingServiceEnum("GCN");

            /// <summary>
            /// Enum GSN for value: GSN
            /// </summary>
            public static readonly BindingServiceEnum GSN = new BindingServiceEnum("GSN");

            private static readonly Dictionary<string, BindingServiceEnum> StaticFields =
            new Dictionary<string, BindingServiceEnum>()
            {
                { "CC", CC },
                { "GEIP", GEIP },
                { "GCN", GCN },
                { "GSN", GSN },
            };

            private string _value;

            public BindingServiceEnum()
            {

            }

            public BindingServiceEnum(string value)
            {
                _value = value;
            }

            public static BindingServiceEnum FromValue(string value)
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

                if (this.Equals(obj as BindingServiceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BindingServiceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BindingServiceEnum a, BindingServiceEnum b)
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

            public static bool operator !=(BindingServiceEnum a, BindingServiceEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 每页返回的个数。 取值范围：1~1000。
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
        /// 根据企业项目ID过滤列表。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }

        /// <summary>
        /// 功能说明：本端接入点。   如果是region类型，则返回所有满足条件的城域带宽，不进行该字段的匹配过滤   如果是其他类型，则会用该字段跟全域互联带宽的local_area进行匹配过滤   附带过滤条件：会通过local_area和remote_area推算最佳全域互联带宽类型进行过滤查询   限制：local_area和remote_area同为空或者同不为空，且站点类型需一致
        /// </summary>
        [SDKProperty("local_area", IsQuery = true)]
        [JsonProperty("local_area", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalArea { get; set; }

        /// <summary>
        /// 功能说明：远端接入点。   如果是region类型，则返回所有满足条件的城域带宽，不进行该字段的匹配过滤   如果是其他类型，则会用该字段跟全域互联带宽的remote_area进行匹配过滤   附带过滤条件：会通过local_area和remote_area推算最佳全域互联带宽类型进行过滤查询   限制：local_area和remote_area同为空或者同不为空，且站点类型需一致
        /// </summary>
        [SDKProperty("remote_area", IsQuery = true)]
        [JsonProperty("remote_area", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteArea { get; set; }

        /// <summary>
        /// 根据支持绑定实例类型过滤全域互联带宽列表。实例类型： - CC: 云连接 - GEIP: 全域弹性公网IP - GCN: 中心网络 - GSN: 分支网络
        /// </summary>
        [SDKProperty("binding_service", IsQuery = true)]
        [JsonProperty("binding_service", NullValueHandling = NullValueHandling.Ignore)]
        public BindingServiceEnum BindingService { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSupportBindingConnectionBandwidthsRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  localArea: ").Append(LocalArea).Append("\n");
            sb.Append("  remoteArea: ").Append(RemoteArea).Append("\n");
            sb.Append("  bindingService: ").Append(BindingService).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSupportBindingConnectionBandwidthsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSupportBindingConnectionBandwidthsRequest input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && input.EnterpriseProjectId != null && !this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId))) return false;
            if (this.LocalArea != input.LocalArea || (this.LocalArea != null && !this.LocalArea.Equals(input.LocalArea))) return false;
            if (this.RemoteArea != input.RemoteArea || (this.RemoteArea != null && !this.RemoteArea.Equals(input.RemoteArea))) return false;
            if (this.BindingService != input.BindingService) return false;

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
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.LocalArea != null) hashCode = hashCode * 59 + this.LocalArea.GetHashCode();
                if (this.RemoteArea != null) hashCode = hashCode * 59 + this.RemoteArea.GetHashCode();
                hashCode = hashCode * 59 + this.BindingService.GetHashCode();
                return hashCode;
            }
        }
    }
}
