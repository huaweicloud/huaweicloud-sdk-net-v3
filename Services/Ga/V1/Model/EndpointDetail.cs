using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ga.V1.Model
{
    /// <summary>
    /// 终端节点实例。
    /// </summary>
    public class EndpointDetail 
    {
        /// <summary>
        /// 终端的健康状态，取值： - INITIAL：初始 - HEALTHY：正常 - UNHEALTHY：异常 - NO_MONITOR：未监控
        /// </summary>
        /// <value>终端的健康状态，取值： - INITIAL：初始 - HEALTHY：正常 - UNHEALTHY：异常 - NO_MONITOR：未监控</value>
        [JsonConverter(typeof(EnumClassConverter<HealthStateEnum>))]
        public class HealthStateEnum
        {
            /// <summary>
            /// Enum INITIAL for value: INITIAL
            /// </summary>
            public static readonly HealthStateEnum INITIAL = new HealthStateEnum("INITIAL");

            /// <summary>
            /// Enum HEALTHY for value: HEALTHY
            /// </summary>
            public static readonly HealthStateEnum HEALTHY = new HealthStateEnum("HEALTHY");

            /// <summary>
            /// Enum UNHEALTHY for value: UNHEALTHY
            /// </summary>
            public static readonly HealthStateEnum UNHEALTHY = new HealthStateEnum("UNHEALTHY");

            /// <summary>
            /// Enum NO_MONITOR for value: NO_MONITOR
            /// </summary>
            public static readonly HealthStateEnum NO_MONITOR = new HealthStateEnum("NO_MONITOR");

            private static readonly Dictionary<string, HealthStateEnum> StaticFields =
            new Dictionary<string, HealthStateEnum>()
            {
                { "INITIAL", INITIAL },
                { "HEALTHY", HEALTHY },
                { "UNHEALTHY", UNHEALTHY },
                { "NO_MONITOR", NO_MONITOR },
            };

            private string _value;

            public HealthStateEnum()
            {

            }

            public HealthStateEnum(string value)
            {
                _value = value;
            }

            public static HealthStateEnum FromValue(string value)
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

                if (this.Equals(obj as HealthStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HealthStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HealthStateEnum a, HealthStateEnum b)
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

            public static bool operator !=(HealthStateEnum a, HealthStateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 终端节点ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 对应后端资源ID。
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 终端节点组ID。
        /// </summary>
        [JsonProperty("endpoint_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public EndpointType? ResourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public ConfigStatus? Status { get; set; }

        /// <summary>
        /// 终端节点权重。
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }

        /// <summary>
        /// 终端的健康状态，取值： - INITIAL：初始 - HEALTHY：正常 - UNHEALTHY：异常 - NO_MONITOR：未监控
        /// </summary>
        [JsonProperty("health_state", NullValueHandling = NullValueHandling.Ignore)]
        public HealthStateEnum HealthState { get; set; }
        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 租户ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// IP地址。
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("frozen_info", NullValueHandling = NullValueHandling.Ignore)]
        public FrozenInfo FrozenInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndpointDetail {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  endpointGroupId: ").Append(EndpointGroupId).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("  healthState: ").Append(HealthState).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  frozenInfo: ").Append(FrozenInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EndpointDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EndpointDetail input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.EndpointGroupId != input.EndpointGroupId || (this.EndpointGroupId != null && !this.EndpointGroupId.Equals(input.EndpointGroupId))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Weight != input.Weight || (this.Weight != null && !this.Weight.Equals(input.Weight))) return false;
            if (this.HealthState != input.HealthState) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && !this.IpAddress.Equals(input.IpAddress))) return false;
            if (this.FrozenInfo != input.FrozenInfo || (this.FrozenInfo != null && !this.FrozenInfo.Equals(input.FrozenInfo))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.EndpointGroupId != null) hashCode = hashCode * 59 + this.EndpointGroupId.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Weight != null) hashCode = hashCode * 59 + this.Weight.GetHashCode();
                hashCode = hashCode * 59 + this.HealthState.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.FrozenInfo != null) hashCode = hashCode * 59 + this.FrozenInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
