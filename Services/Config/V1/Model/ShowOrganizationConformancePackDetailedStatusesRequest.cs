using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowOrganizationConformancePackDetailedStatusesRequest 
    {
        /// <summary>
        /// 部署状态，区分大小写
        /// </summary>
        /// <value>部署状态，区分大小写</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum CREATE_SUCCESSFUL for value: CREATE_SUCCESSFUL
            /// </summary>
            public static readonly StateEnum CREATE_SUCCESSFUL = new StateEnum("CREATE_SUCCESSFUL");

            /// <summary>
            /// Enum CREATE_IN_PROGRESS for value: CREATE_IN_PROGRESS
            /// </summary>
            public static readonly StateEnum CREATE_IN_PROGRESS = new StateEnum("CREATE_IN_PROGRESS");

            /// <summary>
            /// Enum CREATE_FAILED for value: CREATE_FAILED
            /// </summary>
            public static readonly StateEnum CREATE_FAILED = new StateEnum("CREATE_FAILED");

            /// <summary>
            /// Enum DELETE_IN_PROGRESS for value: DELETE_IN_PROGRESS
            /// </summary>
            public static readonly StateEnum DELETE_IN_PROGRESS = new StateEnum("DELETE_IN_PROGRESS");

            /// <summary>
            /// Enum DELETE_FAILED for value: DELETE_FAILED
            /// </summary>
            public static readonly StateEnum DELETE_FAILED = new StateEnum("DELETE_FAILED");

            /// <summary>
            /// Enum UPDATE_SUCCESSFUL for value: UPDATE_SUCCESSFUL
            /// </summary>
            public static readonly StateEnum UPDATE_SUCCESSFUL = new StateEnum("UPDATE_SUCCESSFUL");

            /// <summary>
            /// Enum UPDATE_IN_PROGRESS for value: UPDATE_IN_PROGRESS
            /// </summary>
            public static readonly StateEnum UPDATE_IN_PROGRESS = new StateEnum("UPDATE_IN_PROGRESS");

            /// <summary>
            /// Enum UPDATE_FAILED for value: UPDATE_FAILED
            /// </summary>
            public static readonly StateEnum UPDATE_FAILED = new StateEnum("UPDATE_FAILED");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "CREATE_SUCCESSFUL", CREATE_SUCCESSFUL },
                { "CREATE_IN_PROGRESS", CREATE_IN_PROGRESS },
                { "CREATE_FAILED", CREATE_FAILED },
                { "DELETE_IN_PROGRESS", DELETE_IN_PROGRESS },
                { "DELETE_FAILED", DELETE_FAILED },
                { "UPDATE_SUCCESSFUL", UPDATE_SUCCESSFUL },
                { "UPDATE_IN_PROGRESS", UPDATE_IN_PROGRESS },
                { "UPDATE_FAILED", UPDATE_FAILED },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 组织ID。
        /// </summary>
        [SDKProperty("organization_id", IsPath = true)]
        [JsonProperty("organization_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// 合规规则包名称。
        /// </summary>
        [SDKProperty("conformance_pack_name", IsQuery = true)]
        [JsonProperty("conformance_pack_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ConformancePackName { get; set; }

        /// <summary>
        /// 组织合规规则包ID。
        /// </summary>
        [SDKProperty("organization_conformance_pack_id", IsQuery = true)]
        [JsonProperty("organization_conformance_pack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationConformancePackId { get; set; }

        /// <summary>
        /// 部署状态，区分大小写
        /// </summary>
        [SDKProperty("state", IsQuery = true)]
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// 最大的返回数量
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页参数，通过上一个请求中返回的marker信息作为输入，获取当前页
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowOrganizationConformancePackDetailedStatusesRequest {\n");
            sb.Append("  organizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  conformancePackName: ").Append(ConformancePackName).Append("\n");
            sb.Append("  organizationConformancePackId: ").Append(OrganizationConformancePackId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowOrganizationConformancePackDetailedStatusesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowOrganizationConformancePackDetailedStatusesRequest input)
        {
            if (input == null) return false;
            if (this.OrganizationId != input.OrganizationId || (this.OrganizationId != null && !this.OrganizationId.Equals(input.OrganizationId))) return false;
            if (this.ConformancePackName != input.ConformancePackName || (this.ConformancePackName != null && !this.ConformancePackName.Equals(input.ConformancePackName))) return false;
            if (this.OrganizationConformancePackId != input.OrganizationConformancePackId || (this.OrganizationConformancePackId != null && !this.OrganizationConformancePackId.Equals(input.OrganizationConformancePackId))) return false;
            if (this.State != input.State) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;

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
                if (this.OrganizationId != null) hashCode = hashCode * 59 + this.OrganizationId.GetHashCode();
                if (this.ConformancePackName != null) hashCode = hashCode * 59 + this.ConformancePackName.GetHashCode();
                if (this.OrganizationConformancePackId != null) hashCode = hashCode * 59 + this.OrganizationConformancePackId.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                return hashCode;
            }
        }
    }
}
