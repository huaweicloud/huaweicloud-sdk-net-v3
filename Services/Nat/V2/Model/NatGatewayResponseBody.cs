using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// 公网NAT网关实例的响应体。
    /// </summary>
    public class NatGatewayResponseBody 
    {
        /// <summary>
        /// 公网NAT网关的规格。 取值为： “1”：小型，SNAT最大连接数10000 “2”：中型，SNAT最大连接数50000 “3”：大型，SNAT最大连接数200000 “4”：超大型，SNAT最大连接数1000000 
        /// </summary>
        /// <value>公网NAT网关的规格。 取值为： “1”：小型，SNAT最大连接数10000 “2”：中型，SNAT最大连接数50000 “3”：大型，SNAT最大连接数200000 “4”：超大型，SNAT最大连接数1000000 </value>
        [JsonConverter(typeof(EnumClassConverter<SpecEnum>))]
        public class SpecEnum
        {
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly SpecEnum _1 = new SpecEnum("1");

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            public static readonly SpecEnum _2 = new SpecEnum("2");

            /// <summary>
            /// Enum _3 for value: 3
            /// </summary>
            public static readonly SpecEnum _3 = new SpecEnum("3");

            /// <summary>
            /// Enum _4 for value: 4
            /// </summary>
            public static readonly SpecEnum _4 = new SpecEnum("4");

            private static readonly Dictionary<string, SpecEnum> StaticFields =
            new Dictionary<string, SpecEnum>()
            {
                { "1", _1 },
                { "2", _2 },
                { "3", _3 },
                { "4", _4 },
            };

            private string _value;

            public SpecEnum()
            {

            }

            public SpecEnum(string value)
            {
                _value = value;
            }

            public static SpecEnum FromValue(string value)
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

                if (this.Equals(obj as SpecEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SpecEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SpecEnum a, SpecEnum b)
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

            public static bool operator !=(SpecEnum a, SpecEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 公网NAT网关实例的状态。
        /// </summary>
        /// <value>公网NAT网关实例的状态。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("ACTIVE");

            /// <summary>
            /// Enum PENDING_CREATE for value: PENDING_CREATE
            /// </summary>
            public static readonly StatusEnum PENDING_CREATE = new StatusEnum("PENDING_CREATE");

            /// <summary>
            /// Enum PENDING_UPDATE for value: PENDING_UPDATE
            /// </summary>
            public static readonly StatusEnum PENDING_UPDATE = new StatusEnum("PENDING_UPDATE");

            /// <summary>
            /// Enum PENDING_DELETE for value: PENDING_DELETE
            /// </summary>
            public static readonly StatusEnum PENDING_DELETE = new StatusEnum("PENDING_DELETE");

            /// <summary>
            /// Enum INACTIVE for value: INACTIVE
            /// </summary>
            public static readonly StatusEnum INACTIVE = new StatusEnum("INACTIVE");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ACTIVE", ACTIVE },
                { "PENDING_CREATE", PENDING_CREATE },
                { "PENDING_UPDATE", PENDING_UPDATE },
                { "PENDING_DELETE", PENDING_DELETE },
                { "INACTIVE", INACTIVE },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 公网NAT网关实例的ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 项目的ID。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 公网NAT网关实例的名字，长度限制为64。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 公网NAT网关实例的描述，长度限制为255。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 公网NAT网关的规格。 取值为： “1”：小型，SNAT最大连接数10000 “2”：中型，SNAT最大连接数50000 “3”：大型，SNAT最大连接数200000 “4”：超大型，SNAT最大连接数1000000 
        /// </summary>
        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public SpecEnum Spec { get; set; }
        /// <summary>
        /// 公网NAT网关实例的状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 解冻/冻结状态。 取值范围： - \&quot;true\&quot;：解冻 - \&quot;false\&quot;：冻结
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 公网NAT网关实例的创建时间，格式是yyyy-mm-dd hh:mm:ss.SSSSSS。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// VPC的id。
        /// </summary>
        [JsonProperty("router_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RouterId { get; set; }

        /// <summary>
        /// 公网NAT网关下行口（DVR的下一跳）所属的network id。
        /// </summary>
        [JsonProperty("internal_network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InternalNetworkId { get; set; }

        /// <summary>
        /// 企业项目ID。 创建公网NAT网关实例时，关联的企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("session_conf", NullValueHandling = NullValueHandling.Ignore)]
        public SessionConfiguration SessionConf { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NatGatewayResponseBody {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  spec: ").Append(Spec).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  routerId: ").Append(RouterId).Append("\n");
            sb.Append("  internalNetworkId: ").Append(InternalNetworkId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  sessionConf: ").Append(SessionConf).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NatGatewayResponseBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NatGatewayResponseBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Spec == input.Spec ||
                    (this.Spec != null &&
                    this.Spec.Equals(input.Spec))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.RouterId == input.RouterId ||
                    (this.RouterId != null &&
                    this.RouterId.Equals(input.RouterId))
                ) && 
                (
                    this.InternalNetworkId == input.InternalNetworkId ||
                    (this.InternalNetworkId != null &&
                    this.InternalNetworkId.Equals(input.InternalNetworkId))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.SessionConf == input.SessionConf ||
                    (this.SessionConf != null &&
                    this.SessionConf.Equals(input.SessionConf))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Spec != null)
                    hashCode = hashCode * 59 + this.Spec.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.RouterId != null)
                    hashCode = hashCode * 59 + this.RouterId.GetHashCode();
                if (this.InternalNetworkId != null)
                    hashCode = hashCode * 59 + this.InternalNetworkId.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.SessionConf != null)
                    hashCode = hashCode * 59 + this.SessionConf.GetHashCode();
                return hashCode;
            }
        }
    }
}
