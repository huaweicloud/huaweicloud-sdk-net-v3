using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 负载均衡器产品升级接口
    /// </summary>
    public class UpgradeV3RequestBody 
    {
        /// <summary>
        /// 升级操作： - start：开始升级，仅负载均衡器的provisioning_status为ACTIVE时支持。 - complete：升级完成确认，仅实例的provision_status为UPGRADED时支持。确认后，实例无法再执行回退。 - rollback：回滚，仅实例的provision_status为UPGRADED,UPGRADE_FAILED,ROLLBACK_FAILED时支持。
        /// </summary>
        /// <value>升级操作： - start：开始升级，仅负载均衡器的provisioning_status为ACTIVE时支持。 - complete：升级完成确认，仅实例的provision_status为UPGRADED时支持。确认后，实例无法再执行回退。 - rollback：回滚，仅实例的provision_status为UPGRADED,UPGRADE_FAILED,ROLLBACK_FAILED时支持。</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum START for value: start
            /// </summary>
            public static readonly ActionEnum START = new ActionEnum("start");

            /// <summary>
            /// Enum COMPLETE for value: complete
            /// </summary>
            public static readonly ActionEnum COMPLETE = new ActionEnum("complete");

            /// <summary>
            /// Enum ROLLBACK for value: rollback
            /// </summary>
            public static readonly ActionEnum ROLLBACK = new ActionEnum("rollback");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "start", START },
                { "complete", COMPLETE },
                { "rollback", ROLLBACK },
            };

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(string value)
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

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 升级操作： - start：开始升级，仅负载均衡器的provisioning_status为ACTIVE时支持。 - complete：升级完成确认，仅实例的provision_status为UPGRADED时支持。确认后，实例无法再执行回退。 - rollback：回滚，仅实例的provision_status为UPGRADED,UPGRADE_FAILED,ROLLBACK_FAILED时支持。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// 四层规格ID。仅action为start时生效。 负载均衡器有四层监听器时该字段必须指定。 l4_flavor_id和l7_flavor_id不能同时为空。
        /// </summary>
        [JsonProperty("l4_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L4FlavorId { get; set; }

        /// <summary>
        /// 七层规格ID。仅action为start时生效。 负载均衡器有七层监听器时该字段必须指定。 l4_flavor_id和l7_flavor_id不能同时为空。
        /// </summary>
        [JsonProperty("l7_flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string L7FlavorId { get; set; }

        /// <summary>
        /// 可用区列表。仅在action为start时生效。且action为start时，该字段必传 可通过GET https://{ELB_Endpoint}/v3/{project_id}/elb/availability-zones 接口来查询可用区集合列表。创建负载均衡器时，从查询结果选择某一个可用区集合，并从中选择一个或多个可用区。
        /// </summary>
        [JsonProperty("availability_zone_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZoneList { get; set; }

        /// <summary>
        /// 双栈类型负载均衡器所在子网的IPv6网络ID。 若实例升级到独享型后期望使用IPv6功能，则升级时该字段必传。  可以通过GET https://{VPC_Endpoint}/v1/{project_id}/subnets 响应参数中的id得到。  使用说明： ipv6_vip_virsubnet_id需要属于原共享型实例所属VPC。 ipv6_vip_virsubnet_id所属子网需要开启IPv6。  [不支持IPv6，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("ipv6_vip_virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6VipVirsubnetId { get; set; }

        /// <summary>
        /// 负载均衡器的IPv6虚拟IP。该地址必须包含在所在子网的IPv6网段内，且未被占用。  使用说明：  传入ipv6_vip_address时必须传入ipv6_vip_virsubnet_id。 不传入ipv6_vip_address，但传入ipv6_vip_virsubnet_id，则自动分配IPv6虚拟IP。 不传入ipv6_vip_address，且不传ipv6_vip_virsubnet_id，则不分配虚拟IP，ipv6_vip_address&#x3D;null。  [不支持IPv6，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("ipv6_vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6VipAddress { get; set; }

        /// <summary>
        /// 下联面子网的网络ID列表。仅action为start时生效。 可以通过GET https://{VPC_Endpoint}/v1/{project_id}/subnets 响应参数中的neutron_network_id得到。  若不指定该字段，则选择vip_subnet_cidr_id子网对应的网络ID。  下联面子网必须属于该LB所在的VPC。
        /// </summary>
        [JsonProperty("elb_virsubnet_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ElbVirsubnetIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeV3RequestBody {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  l4FlavorId: ").Append(L4FlavorId).Append("\n");
            sb.Append("  l7FlavorId: ").Append(L7FlavorId).Append("\n");
            sb.Append("  availabilityZoneList: ").Append(AvailabilityZoneList).Append("\n");
            sb.Append("  ipv6VipVirsubnetId: ").Append(Ipv6VipVirsubnetId).Append("\n");
            sb.Append("  ipv6VipAddress: ").Append(Ipv6VipAddress).Append("\n");
            sb.Append("  elbVirsubnetIds: ").Append(ElbVirsubnetIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeV3RequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeV3RequestBody input)
        {
            if (input == null) return false;
            if (this.Action != input.Action) return false;
            if (this.L4FlavorId != input.L4FlavorId || (this.L4FlavorId != null && !this.L4FlavorId.Equals(input.L4FlavorId))) return false;
            if (this.L7FlavorId != input.L7FlavorId || (this.L7FlavorId != null && !this.L7FlavorId.Equals(input.L7FlavorId))) return false;
            if (this.AvailabilityZoneList != input.AvailabilityZoneList || (this.AvailabilityZoneList != null && input.AvailabilityZoneList != null && !this.AvailabilityZoneList.SequenceEqual(input.AvailabilityZoneList))) return false;
            if (this.Ipv6VipVirsubnetId != input.Ipv6VipVirsubnetId || (this.Ipv6VipVirsubnetId != null && !this.Ipv6VipVirsubnetId.Equals(input.Ipv6VipVirsubnetId))) return false;
            if (this.Ipv6VipAddress != input.Ipv6VipAddress || (this.Ipv6VipAddress != null && !this.Ipv6VipAddress.Equals(input.Ipv6VipAddress))) return false;
            if (this.ElbVirsubnetIds != input.ElbVirsubnetIds || (this.ElbVirsubnetIds != null && input.ElbVirsubnetIds != null && !this.ElbVirsubnetIds.SequenceEqual(input.ElbVirsubnetIds))) return false;

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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.L4FlavorId != null) hashCode = hashCode * 59 + this.L4FlavorId.GetHashCode();
                if (this.L7FlavorId != null) hashCode = hashCode * 59 + this.L7FlavorId.GetHashCode();
                if (this.AvailabilityZoneList != null) hashCode = hashCode * 59 + this.AvailabilityZoneList.GetHashCode();
                if (this.Ipv6VipVirsubnetId != null) hashCode = hashCode * 59 + this.Ipv6VipVirsubnetId.GetHashCode();
                if (this.Ipv6VipAddress != null) hashCode = hashCode * 59 + this.Ipv6VipAddress.GetHashCode();
                if (this.ElbVirsubnetIds != null) hashCode = hashCode * 59 + this.ElbVirsubnetIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
