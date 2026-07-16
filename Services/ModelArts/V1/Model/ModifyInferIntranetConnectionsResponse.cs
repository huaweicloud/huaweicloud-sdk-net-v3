using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ModifyInferIntranetConnectionsResponse : SdkResponse
    {
        /// <summary>
        /// **参数解释：** 接入粒度：SERVICE、GLOBAL **取值范围：** 不涉及。
        /// </summary>
        /// <value>**参数解释：** 接入粒度：SERVICE、GLOBAL **取值范围：** 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum SERVICE for value: SERVICE
            /// </summary>
            public static readonly TypeEnum SERVICE = new TypeEnum("SERVICE");

            /// <summary>
            /// Enum GLOBAL for value: GLOBAL
            /// </summary>
            public static readonly TypeEnum GLOBAL = new TypeEnum("GLOBAL");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "SERVICE", SERVICE },
                { "GLOBAL", GLOBAL },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 申请方用户名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("applicant_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicantUserName { get; set; }

        /// <summary>
        /// **参数解释：** 内网接入id。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 申请描述。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// **参数解释：** 审核方domain name。  **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("owner_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerDomainName { get; set; }

        /// <summary>
        /// **参数解释：** 内网访问场景。 **约束限制：** 不涉及。 **取值范围：** - POOL：用户资源池接入场景 - VPC：用户VPC接入场景 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("scene", NullValueHandling = NullValueHandling.Ignore)]
        public string Scene { get; set; }

        /// <summary>
        /// **参数解释：** 服务ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }

        /// <summary>
        /// **参数解释：** 服务名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// **参数解释：** 内网接入状态，支持列表查询。 **约束限制：** 不涉及。 **取值范围：** - APPROVING：审批中 - REJECTED：拒绝 - CONNECTING：接入中 - CONNECTED：已接入 - CANCELED：已取消 - FAILED：失败 - DELETING：删除中 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** 子网ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// **参数解释：** 访问地址列表。
        /// </summary>
        [JsonProperty("url_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UrlList { get; set; }

        /// <summary>
        /// **参数解释：** 访问地址列表。
        /// </summary>
        [JsonProperty("custom_url_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CustomUrlList { get; set; }

        /// <summary>
        /// **参数解释：** VPC ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// **参数解释：** 服务绑定的dispatcher组ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("dispatcher_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DispatcherGroupId { get; set; }

        /// <summary>
        /// **参数解释：** 接入粒度：SERVICE、GLOBAL **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释：** 资源池网络名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("maos_network_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MaosNetworkName { get; set; }

        /// <summary>
        /// **参数解释：** 服务类型。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// **参数解释：** 资源池ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateAt { get; set; }

        /// <summary>
        /// **参数解释：** 修改时间。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyInferIntranetConnectionsResponse {\n");
            sb.Append("  applicantUserName: ").Append(ApplicantUserName).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  ownerDomainName: ").Append(OwnerDomainName).Append("\n");
            sb.Append("  scene: ").Append(Scene).Append("\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  serviceName: ").Append(ServiceName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  urlList: ").Append(UrlList).Append("\n");
            sb.Append("  customUrlList: ").Append(CustomUrlList).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  dispatcherGroupId: ").Append(DispatcherGroupId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  maosNetworkName: ").Append(MaosNetworkName).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyInferIntranetConnectionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyInferIntranetConnectionsResponse input)
        {
            if (input == null) return false;
            if (this.ApplicantUserName != input.ApplicantUserName || (this.ApplicantUserName != null && !this.ApplicantUserName.Equals(input.ApplicantUserName))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.OwnerDomainName != input.OwnerDomainName || (this.OwnerDomainName != null && !this.OwnerDomainName.Equals(input.OwnerDomainName))) return false;
            if (this.Scene != input.Scene || (this.Scene != null && !this.Scene.Equals(input.Scene))) return false;
            if (this.ServiceId != input.ServiceId || (this.ServiceId != null && !this.ServiceId.Equals(input.ServiceId))) return false;
            if (this.ServiceName != input.ServiceName || (this.ServiceName != null && !this.ServiceName.Equals(input.ServiceName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.UrlList != input.UrlList || (this.UrlList != null && input.UrlList != null && !this.UrlList.SequenceEqual(input.UrlList))) return false;
            if (this.CustomUrlList != input.CustomUrlList || (this.CustomUrlList != null && input.CustomUrlList != null && !this.CustomUrlList.SequenceEqual(input.CustomUrlList))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.DispatcherGroupId != input.DispatcherGroupId || (this.DispatcherGroupId != null && !this.DispatcherGroupId.Equals(input.DispatcherGroupId))) return false;
            if (this.Type != input.Type) return false;
            if (this.MaosNetworkName != input.MaosNetworkName || (this.MaosNetworkName != null && !this.MaosNetworkName.Equals(input.MaosNetworkName))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;

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
                if (this.ApplicantUserName != null) hashCode = hashCode * 59 + this.ApplicantUserName.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.OwnerDomainName != null) hashCode = hashCode * 59 + this.OwnerDomainName.GetHashCode();
                if (this.Scene != null) hashCode = hashCode * 59 + this.Scene.GetHashCode();
                if (this.ServiceId != null) hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.ServiceName != null) hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.UrlList != null) hashCode = hashCode * 59 + this.UrlList.GetHashCode();
                if (this.CustomUrlList != null) hashCode = hashCode * 59 + this.CustomUrlList.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.DispatcherGroupId != null) hashCode = hashCode * 59 + this.DispatcherGroupId.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.MaosNetworkName != null) hashCode = hashCode * 59 + this.MaosNetworkName.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
