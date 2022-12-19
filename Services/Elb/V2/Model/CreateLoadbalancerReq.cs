using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// 创建负载均衡器的请求体
    /// </summary>
    public class CreateLoadbalancerReq 
    {
        /// <summary>
        /// 负载均衡器的供应者名称。只支持vlb
        /// </summary>
        /// <value>负载均衡器的供应者名称。只支持vlb</value>
        [JsonConverter(typeof(EnumClassConverter<ProviderEnum>))]
        public class ProviderEnum
        {
            /// <summary>
            /// Enum VLB for value: vlb
            /// </summary>
            public static readonly ProviderEnum VLB = new ProviderEnum("vlb");

            private static readonly Dictionary<string, ProviderEnum> StaticFields =
            new Dictionary<string, ProviderEnum>()
            {
                { "vlb", VLB },
            };

            private string Value;

            public ProviderEnum(string value)
            {
                Value = value;
            }

            public static ProviderEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as ProviderEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProviderEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ProviderEnum a, ProviderEnum b)
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

            public static bool operator !=(ProviderEnum a, ProviderEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 负载均衡器所在的项目ID。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 负载均衡器名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 负载均衡器的描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 负载均衡器所在的子网IPv4子网ID
        /// </summary>
        [JsonProperty("vip_subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VipSubnetId { get; set; }

        /// <summary>
        /// 负载均衡器的虚拟IP。
        /// </summary>
        [JsonProperty("vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string VipAddress { get; set; }

        /// <summary>
        /// 负载均衡器的供应者名称。只支持vlb
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public ProviderEnum Provider { get; set; }
        /// <summary>
        /// 负载均衡器的管理状态。只支持设定为true，该字段的值无实际意义。
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 企业项目ID。创建负载均衡器时，给负载均衡器绑定企业项目ID。取值范围：最大长度36字节，带“-”连字符的UUID格式，或者是字符串“0”。“0”表示默认企业项目。 关于企业项目ID的获取及企业项目特性的详细信息，请参见《企业管理用户指南》。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLoadbalancerReq {\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  vipSubnetId: ").Append(VipSubnetId).Append("\n");
            sb.Append("  vipAddress: ").Append(VipAddress).Append("\n");
            sb.Append("  provider: ").Append(Provider).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLoadbalancerReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateLoadbalancerReq input)
        {
            if (input == null)
                return false;

            return 
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
                    this.VipSubnetId == input.VipSubnetId ||
                    (this.VipSubnetId != null &&
                    this.VipSubnetId.Equals(input.VipSubnetId))
                ) && 
                (
                    this.VipAddress == input.VipAddress ||
                    (this.VipAddress != null &&
                    this.VipAddress.Equals(input.VipAddress))
                ) && 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.VipSubnetId != null)
                    hashCode = hashCode * 59 + this.VipSubnetId.GetHashCode();
                if (this.VipAddress != null)
                    hashCode = hashCode * 59 + this.VipAddress.GetHashCode();
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
