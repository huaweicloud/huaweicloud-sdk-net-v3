using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 创建桌面请求。
    /// </summary>
    public class CreateDesktopPoolReq 
    {
        /// <summary>
        /// 桌面池类型，DYNAMIC：动态池，STATIC：静态池。
        /// </summary>
        /// <value>桌面池类型，DYNAMIC：动态池，STATIC：静态池。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum DYNAMIC for value: DYNAMIC
            /// </summary>
            public static readonly TypeEnum DYNAMIC = new TypeEnum("DYNAMIC");

            /// <summary>
            /// Enum STATIC for value: STATIC
            /// </summary>
            public static readonly TypeEnum STATIC = new TypeEnum("STATIC");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "DYNAMIC", DYNAMIC },
                { "STATIC", STATIC },
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
        /// 桌面池名称，桌面池名称必须保证唯一。桌面名称只允许输入中文、大写字母、小写字母、数字、中划线，长度范围为1~255。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 桌面池类型，DYNAMIC：动态池，STATIC：静态池。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 桌面池大小：当前桌面池要创建多少台桌面。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 桌面池描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 可用分区。将桌面创建到指定的可用分区。如果不指定则使用系统随机的可用分区。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 套餐ID。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 产品规格ID。可用区是边缘可用区时，必填此参数。
        /// </summary>
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// 镜像类型。默认值为private。  - private：私有镜像。 - gold：公共镜像。
        /// </summary>
        [JsonProperty("image_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageType { get; set; }

        /// <summary>
        /// 镜像ID，用于私有镜像创建桌面场景，配合product_id使用。
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("root_volume", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeInfo RootVolume { get; set; }

        /// <summary>
        /// 数据盘列表。
        /// </summary>
        [JsonProperty("data_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<VolumeInfo> DataVolumes { get; set; }

        /// <summary>
        /// 创建桌面时的VPC ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 创建桌面使用的子网ID。
        /// </summary>
        [JsonProperty("subnet_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubnetIds { get; set; }

        /// <summary>
        /// 桌面使用的安全组，如果不指定则默认使用桌面代理中指定的安全组。
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecurityGroup> SecurityGroups { get; set; }

        /// <summary>
        /// 要授权的用户/用户组列表。
        /// </summary>
        [JsonProperty("authorized_objects", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuthorizedObjects> AuthorizedObjects { get; set; }

        /// <summary>
        /// OU名称，在对接AD时使用，需提前在AD中创建OU。
        /// </summary>
        [JsonProperty("ou_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OuName { get; set; }

        /// <summary>
        /// 标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 企业项目ID，默认\&quot;0。\&quot;
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 动态池桌面断连多少分钟内，保留用户与桌面的绑定关系，超时后自动解绑。
        /// </summary>
        [JsonProperty("disconnected_retention_period", NullValueHandling = NullValueHandling.Ignore)]
        public int? DisconnectedRetentionPeriod { get; set; }

        /// <summary>
        /// 桌面池是否开启弹性伸缩类型，为false则表示不开启弹性伸缩，为true则表示开启弹性伸缩。
        /// </summary>
        [JsonProperty("enable_autoscale", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAutoscale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("autoscale_policy", NullValueHandling = NullValueHandling.Ignore)]
        public AutoscalePolicy AutoscalePolicy { get; set; }

        /// <summary>
        /// 策略id，用于指定生成桌面名称策略。
        /// </summary>
        [JsonProperty("desktop_name_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopNamePolicyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDesktopPoolReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  rootVolume: ").Append(RootVolume).Append("\n");
            sb.Append("  dataVolumes: ").Append(DataVolumes).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetIds: ").Append(SubnetIds).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  authorizedObjects: ").Append(AuthorizedObjects).Append("\n");
            sb.Append("  ouName: ").Append(OuName).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  disconnectedRetentionPeriod: ").Append(DisconnectedRetentionPeriod).Append("\n");
            sb.Append("  enableAutoscale: ").Append(EnableAutoscale).Append("\n");
            sb.Append("  autoscalePolicy: ").Append(AutoscalePolicy).Append("\n");
            sb.Append("  desktopNamePolicyId: ").Append(DesktopNamePolicyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDesktopPoolReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDesktopPoolReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.FlavorId != input.FlavorId || (this.FlavorId != null && !this.FlavorId.Equals(input.FlavorId))) return false;
            if (this.ImageType != input.ImageType || (this.ImageType != null && !this.ImageType.Equals(input.ImageType))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.RootVolume != input.RootVolume || (this.RootVolume != null && !this.RootVolume.Equals(input.RootVolume))) return false;
            if (this.DataVolumes != input.DataVolumes || (this.DataVolumes != null && input.DataVolumes != null && !this.DataVolumes.SequenceEqual(input.DataVolumes))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetIds != input.SubnetIds || (this.SubnetIds != null && input.SubnetIds != null && !this.SubnetIds.SequenceEqual(input.SubnetIds))) return false;
            if (this.SecurityGroups != input.SecurityGroups || (this.SecurityGroups != null && input.SecurityGroups != null && !this.SecurityGroups.SequenceEqual(input.SecurityGroups))) return false;
            if (this.AuthorizedObjects != input.AuthorizedObjects || (this.AuthorizedObjects != null && input.AuthorizedObjects != null && !this.AuthorizedObjects.SequenceEqual(input.AuthorizedObjects))) return false;
            if (this.OuName != input.OuName || (this.OuName != null && !this.OuName.Equals(input.OuName))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.DisconnectedRetentionPeriod != input.DisconnectedRetentionPeriod || (this.DisconnectedRetentionPeriod != null && !this.DisconnectedRetentionPeriod.Equals(input.DisconnectedRetentionPeriod))) return false;
            if (this.EnableAutoscale != input.EnableAutoscale || (this.EnableAutoscale != null && !this.EnableAutoscale.Equals(input.EnableAutoscale))) return false;
            if (this.AutoscalePolicy != input.AutoscalePolicy || (this.AutoscalePolicy != null && !this.AutoscalePolicy.Equals(input.AutoscalePolicy))) return false;
            if (this.DesktopNamePolicyId != input.DesktopNamePolicyId || (this.DesktopNamePolicyId != null && !this.DesktopNamePolicyId.Equals(input.DesktopNamePolicyId))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.FlavorId != null) hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.ImageType != null) hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.RootVolume != null) hashCode = hashCode * 59 + this.RootVolume.GetHashCode();
                if (this.DataVolumes != null) hashCode = hashCode * 59 + this.DataVolumes.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetIds != null) hashCode = hashCode * 59 + this.SubnetIds.GetHashCode();
                if (this.SecurityGroups != null) hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.AuthorizedObjects != null) hashCode = hashCode * 59 + this.AuthorizedObjects.GetHashCode();
                if (this.OuName != null) hashCode = hashCode * 59 + this.OuName.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.DisconnectedRetentionPeriod != null) hashCode = hashCode * 59 + this.DisconnectedRetentionPeriod.GetHashCode();
                if (this.EnableAutoscale != null) hashCode = hashCode * 59 + this.EnableAutoscale.GetHashCode();
                if (this.AutoscalePolicy != null) hashCode = hashCode * 59 + this.AutoscalePolicy.GetHashCode();
                if (this.DesktopNamePolicyId != null) hashCode = hashCode * 59 + this.DesktopNamePolicyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
