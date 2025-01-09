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
    public class CreateDesktopReq 
    {
        /// <summary>
        /// 云桌面类型。 - DEDICATED：专属桌面，单用户。 - SHARED: 多用户共享桌面。
        /// </summary>
        /// <value>云桌面类型。 - DEDICATED：专属桌面，单用户。 - SHARED: 多用户共享桌面。</value>
        [JsonConverter(typeof(EnumClassConverter<DesktopTypeEnum>))]
        public class DesktopTypeEnum
        {
            /// <summary>
            /// Enum DEDICATED for value: DEDICATED
            /// </summary>
            public static readonly DesktopTypeEnum DEDICATED = new DesktopTypeEnum("DEDICATED");

            /// <summary>
            /// Enum SHARED for value: SHARED
            /// </summary>
            public static readonly DesktopTypeEnum SHARED = new DesktopTypeEnum("SHARED");

            private static readonly Dictionary<string, DesktopTypeEnum> StaticFields =
            new Dictionary<string, DesktopTypeEnum>()
            {
                { "DEDICATED", DEDICATED },
                { "SHARED", SHARED },
            };

            private string _value;

            public DesktopTypeEnum()
            {

            }

            public DesktopTypeEnum(string value)
            {
                _value = value;
            }

            public static DesktopTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DesktopTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DesktopTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DesktopTypeEnum a, DesktopTypeEnum b)
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

            public static bool operator !=(DesktopTypeEnum a, DesktopTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 桌面来源。  - DEFAULT：默认桌面来源 - ONEMOBILE：协同办公云桌面OneMobile
        /// </summary>
        /// <value>桌面来源。  - DEFAULT：默认桌面来源 - ONEMOBILE：协同办公云桌面OneMobile</value>
        [JsonConverter(typeof(EnumClassConverter<DesktopIsvEnum>))]
        public class DesktopIsvEnum
        {
            /// <summary>
            /// Enum DEFAULT for value: DEFAULT
            /// </summary>
            public static readonly DesktopIsvEnum DEFAULT = new DesktopIsvEnum("DEFAULT");

            /// <summary>
            /// Enum ONEMOBILE for value: ONEMOBILE
            /// </summary>
            public static readonly DesktopIsvEnum ONEMOBILE = new DesktopIsvEnum("ONEMOBILE");

            private static readonly Dictionary<string, DesktopIsvEnum> StaticFields =
            new Dictionary<string, DesktopIsvEnum>()
            {
                { "DEFAULT", DEFAULT },
                { "ONEMOBILE", ONEMOBILE },
            };

            private string _value;

            public DesktopIsvEnum()
            {

            }

            public DesktopIsvEnum(string value)
            {
                _value = value;
            }

            public static DesktopIsvEnum FromValue(string value)
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

                if (this.Equals(obj as DesktopIsvEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DesktopIsvEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DesktopIsvEnum a, DesktopIsvEnum b)
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

            public static bool operator !=(DesktopIsvEnum a, DesktopIsvEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 接入模式。在非对接AD场景首次创建桌面时使用。 - INTERNET：互联网接入。 - DEDICATED：专线接入。 - BOTH：代表两种接入方式都支持。
        /// </summary>
        /// <value>接入模式。在非对接AD场景首次创建桌面时使用。 - INTERNET：互联网接入。 - DEDICATED：专线接入。 - BOTH：代表两种接入方式都支持。</value>
        [JsonConverter(typeof(EnumClassConverter<AccessModeEnum>))]
        public class AccessModeEnum
        {
            /// <summary>
            /// Enum INTERNET for value: INTERNET
            /// </summary>
            public static readonly AccessModeEnum INTERNET = new AccessModeEnum("INTERNET");

            /// <summary>
            /// Enum DEDICATED for value: DEDICATED
            /// </summary>
            public static readonly AccessModeEnum DEDICATED = new AccessModeEnum("DEDICATED");

            /// <summary>
            /// Enum BOTH for value: BOTH
            /// </summary>
            public static readonly AccessModeEnum BOTH = new AccessModeEnum("BOTH");

            private static readonly Dictionary<string, AccessModeEnum> StaticFields =
            new Dictionary<string, AccessModeEnum>()
            {
                { "INTERNET", INTERNET },
                { "DEDICATED", DEDICATED },
                { "BOTH", BOTH },
            };

            private string _value;

            public AccessModeEnum()
            {

            }

            public AccessModeEnum(string value)
            {
                _value = value;
            }

            public static AccessModeEnum FromValue(string value)
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

                if (this.Equals(obj as AccessModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AccessModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AccessModeEnum a, AccessModeEnum b)
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

            public static bool operator !=(AccessModeEnum a, AccessModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 云桌面类型。 - DEDICATED：专属桌面，单用户。 - SHARED: 多用户共享桌面。
        /// </summary>
        [JsonProperty("desktop_type", NullValueHandling = NullValueHandling.Ignore)]
        public DesktopTypeEnum DesktopType { get; set; }
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
        /// 套餐flavorID。
        /// </summary>
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// 桌面协同资源SKU码
        /// </summary>
        [JsonProperty("share_resource_sku", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareResourceSku { get; set; }

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
        public Volume RootVolume { get; set; }

        /// <summary>
        /// 数据盘列表。
        /// </summary>
        [JsonProperty("data_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Volume> DataVolumes { get; set; }

        /// <summary>
        /// 桌面对应的网卡信息，如果不指定则使用默认网卡。
        /// </summary>
        [JsonProperty("nics", NullValueHandling = NullValueHandling.Ignore)]
        public List<Nic> Nics { get; set; }

        /// <summary>
        /// 桌面使用的安全组，如果不指定则默认使用桌面代理中指定的安全组。
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecurityGroup> SecurityGroups { get; set; }

        /// <summary>
        /// 创建桌面使用的参数列表。长度为1-100。  当前不支持一批桌面不同配置，所有桌面的配置和第一台的一致，如果第一台未设置参数，则取外层的同名参数。
        /// </summary>
        [JsonProperty("desktops", NullValueHandling = NullValueHandling.Ignore)]
        public List<Desktop> Desktops { get; set; }

        /// <summary>
        /// 搭配size使用，当size为1时代表桌面名，位数1-15，当size大于1时代表桌面名前缀，位数：1-13。
        /// </summary>
        [JsonProperty("desktop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopName { get; set; }

        /// <summary>
        /// 桌面指定分配的ip地址列表,最小为0，最大为100。
        /// </summary>
        [JsonProperty("desktop_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DesktopIps { get; set; }

        /// <summary>
        /// 创建不分配用户的桌面的个数，和desktops不能同时生效，搭配desktop_name使用。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 创建成功后是否发送邮件通知桌面用户，默认为true。
        /// </summary>
        [JsonProperty("email_notification", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EmailNotification { get; set; }

        /// <summary>
        /// 企业ID，在非对接AD场景首次创建桌面时使用。
        /// </summary>
        [JsonProperty("enterprise_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 企业项目ID，默认\&quot;0\&quot;
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 包周期订购ID，CBC订购回调时使用。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// OU名称，在对接AD时使用，需提前在AD中创建OU。
        /// </summary>
        [JsonProperty("ou_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OuName { get; set; }

        /// <summary>
        /// 在非对接AD场景首次创建桌面时使用。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 在非对接AD场景首次创建桌面时使用。
        /// </summary>
        [JsonProperty("subnet_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubnetIds { get; set; }

        /// <summary>
        /// 标签列表。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scheduler_hints", NullValueHandling = NullValueHandling.Ignore)]
        public WdhParam SchedulerHints { get; set; }

        /// <summary>
        /// 桌面来源。  - DEFAULT：默认桌面来源 - ONEMOBILE：协同办公云桌面OneMobile
        /// </summary>
        [JsonProperty("desktop_isv", NullValueHandling = NullValueHandling.Ignore)]
        public DesktopIsvEnum DesktopIsv { get; set; }
        /// <summary>
        /// 接入模式。在非对接AD场景首次创建桌面时使用。 - INTERNET：互联网接入。 - DEDICATED：专线接入。 - BOTH：代表两种接入方式都支持。
        /// </summary>
        [JsonProperty("access_mode", NullValueHandling = NullValueHandling.Ignore)]
        public AccessModeEnum AccessMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("apply_shared_vpc_dedicated_param", NullValueHandling = NullValueHandling.Ignore)]
        public ApplySharedVpcDedicatedParam ApplySharedVpcDedicatedParam { get; set; }

        /// <summary>
        /// 专线接入网段列表，多个网段信息用分号隔开，列表长度不超过5。在非对接AD场景首次创建桌面时使用。
        /// </summary>
        [JsonProperty("dedicated_subnets", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedSubnets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("eip", NullValueHandling = NullValueHandling.Ignore)]
        public Eip Eip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("adn", NullValueHandling = NullValueHandling.Ignore)]
        public Adn Adn { get; set; }

        /// <summary>
        /// 专享主机ID，创建专享桌面时如果在指定专享主机中创建则必选
        /// </summary>
        [JsonProperty("exclusive_host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExclusiveHostId { get; set; }

        /// <summary>
        /// 策略id，用于指定生成桌面名称策略，如果指定了桌面名称则优先使用指定的桌面名称。
        /// </summary>
        [JsonProperty("desktop_name_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopNamePolicyId { get; set; }

        /// <summary>
        /// 桌面小时包套餐ID。
        /// </summary>
        [JsonProperty("hour_package_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HourPackageProductId { get; set; }

        /// <summary>
        /// 桌面小时包offeringID。
        /// </summary>
        [JsonProperty("hour_package_offering_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HourPackageOfferingId { get; set; }

        /// <summary>
        /// 根资源ID列表，创建小时包桌面时使用，最小为0，最大为100。
        /// </summary>
        [JsonProperty("root_resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RootResourceIds { get; set; }

        /// <summary>
        /// instInfoId列表，创建小时包桌面时使用，最小为0，最大为100。
        /// </summary>
        [JsonProperty("inst_info_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstInfoIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDesktopReq {\n");
            sb.Append("  desktopType: ").Append(DesktopType).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  shareResourceSku: ").Append(ShareResourceSku).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  rootVolume: ").Append(RootVolume).Append("\n");
            sb.Append("  dataVolumes: ").Append(DataVolumes).Append("\n");
            sb.Append("  nics: ").Append(Nics).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  desktops: ").Append(Desktops).Append("\n");
            sb.Append("  desktopName: ").Append(DesktopName).Append("\n");
            sb.Append("  desktopIps: ").Append(DesktopIps).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  emailNotification: ").Append(EmailNotification).Append("\n");
            sb.Append("  enterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  ouName: ").Append(OuName).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetIds: ").Append(SubnetIds).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  schedulerHints: ").Append(SchedulerHints).Append("\n");
            sb.Append("  desktopIsv: ").Append(DesktopIsv).Append("\n");
            sb.Append("  accessMode: ").Append(AccessMode).Append("\n");
            sb.Append("  applySharedVpcDedicatedParam: ").Append(ApplySharedVpcDedicatedParam).Append("\n");
            sb.Append("  dedicatedSubnets: ").Append(DedicatedSubnets).Append("\n");
            sb.Append("  eip: ").Append(Eip).Append("\n");
            sb.Append("  adn: ").Append(Adn).Append("\n");
            sb.Append("  exclusiveHostId: ").Append(ExclusiveHostId).Append("\n");
            sb.Append("  desktopNamePolicyId: ").Append(DesktopNamePolicyId).Append("\n");
            sb.Append("  hourPackageProductId: ").Append(HourPackageProductId).Append("\n");
            sb.Append("  hourPackageOfferingId: ").Append(HourPackageOfferingId).Append("\n");
            sb.Append("  rootResourceIds: ").Append(RootResourceIds).Append("\n");
            sb.Append("  instInfoIds: ").Append(InstInfoIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDesktopReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDesktopReq input)
        {
            if (input == null) return false;
            if (this.DesktopType != input.DesktopType) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.FlavorId != input.FlavorId || (this.FlavorId != null && !this.FlavorId.Equals(input.FlavorId))) return false;
            if (this.ShareResourceSku != input.ShareResourceSku || (this.ShareResourceSku != null && !this.ShareResourceSku.Equals(input.ShareResourceSku))) return false;
            if (this.ImageType != input.ImageType || (this.ImageType != null && !this.ImageType.Equals(input.ImageType))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.RootVolume != input.RootVolume || (this.RootVolume != null && !this.RootVolume.Equals(input.RootVolume))) return false;
            if (this.DataVolumes != input.DataVolumes || (this.DataVolumes != null && input.DataVolumes != null && !this.DataVolumes.SequenceEqual(input.DataVolumes))) return false;
            if (this.Nics != input.Nics || (this.Nics != null && input.Nics != null && !this.Nics.SequenceEqual(input.Nics))) return false;
            if (this.SecurityGroups != input.SecurityGroups || (this.SecurityGroups != null && input.SecurityGroups != null && !this.SecurityGroups.SequenceEqual(input.SecurityGroups))) return false;
            if (this.Desktops != input.Desktops || (this.Desktops != null && input.Desktops != null && !this.Desktops.SequenceEqual(input.Desktops))) return false;
            if (this.DesktopName != input.DesktopName || (this.DesktopName != null && !this.DesktopName.Equals(input.DesktopName))) return false;
            if (this.DesktopIps != input.DesktopIps || (this.DesktopIps != null && input.DesktopIps != null && !this.DesktopIps.SequenceEqual(input.DesktopIps))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.EmailNotification != input.EmailNotification || (this.EmailNotification != null && !this.EmailNotification.Equals(input.EmailNotification))) return false;
            if (this.EnterpriseId != input.EnterpriseId || (this.EnterpriseId != null && !this.EnterpriseId.Equals(input.EnterpriseId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.OuName != input.OuName || (this.OuName != null && !this.OuName.Equals(input.OuName))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetIds != input.SubnetIds || (this.SubnetIds != null && input.SubnetIds != null && !this.SubnetIds.SequenceEqual(input.SubnetIds))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.SchedulerHints != input.SchedulerHints || (this.SchedulerHints != null && !this.SchedulerHints.Equals(input.SchedulerHints))) return false;
            if (this.DesktopIsv != input.DesktopIsv) return false;
            if (this.AccessMode != input.AccessMode) return false;
            if (this.ApplySharedVpcDedicatedParam != input.ApplySharedVpcDedicatedParam || (this.ApplySharedVpcDedicatedParam != null && !this.ApplySharedVpcDedicatedParam.Equals(input.ApplySharedVpcDedicatedParam))) return false;
            if (this.DedicatedSubnets != input.DedicatedSubnets || (this.DedicatedSubnets != null && !this.DedicatedSubnets.Equals(input.DedicatedSubnets))) return false;
            if (this.Eip != input.Eip || (this.Eip != null && !this.Eip.Equals(input.Eip))) return false;
            if (this.Adn != input.Adn || (this.Adn != null && !this.Adn.Equals(input.Adn))) return false;
            if (this.ExclusiveHostId != input.ExclusiveHostId || (this.ExclusiveHostId != null && !this.ExclusiveHostId.Equals(input.ExclusiveHostId))) return false;
            if (this.DesktopNamePolicyId != input.DesktopNamePolicyId || (this.DesktopNamePolicyId != null && !this.DesktopNamePolicyId.Equals(input.DesktopNamePolicyId))) return false;
            if (this.HourPackageProductId != input.HourPackageProductId || (this.HourPackageProductId != null && !this.HourPackageProductId.Equals(input.HourPackageProductId))) return false;
            if (this.HourPackageOfferingId != input.HourPackageOfferingId || (this.HourPackageOfferingId != null && !this.HourPackageOfferingId.Equals(input.HourPackageOfferingId))) return false;
            if (this.RootResourceIds != input.RootResourceIds || (this.RootResourceIds != null && input.RootResourceIds != null && !this.RootResourceIds.SequenceEqual(input.RootResourceIds))) return false;
            if (this.InstInfoIds != input.InstInfoIds || (this.InstInfoIds != null && input.InstInfoIds != null && !this.InstInfoIds.SequenceEqual(input.InstInfoIds))) return false;

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
                hashCode = hashCode * 59 + this.DesktopType.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.FlavorId != null) hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.ShareResourceSku != null) hashCode = hashCode * 59 + this.ShareResourceSku.GetHashCode();
                if (this.ImageType != null) hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.RootVolume != null) hashCode = hashCode * 59 + this.RootVolume.GetHashCode();
                if (this.DataVolumes != null) hashCode = hashCode * 59 + this.DataVolumes.GetHashCode();
                if (this.Nics != null) hashCode = hashCode * 59 + this.Nics.GetHashCode();
                if (this.SecurityGroups != null) hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.Desktops != null) hashCode = hashCode * 59 + this.Desktops.GetHashCode();
                if (this.DesktopName != null) hashCode = hashCode * 59 + this.DesktopName.GetHashCode();
                if (this.DesktopIps != null) hashCode = hashCode * 59 + this.DesktopIps.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.EmailNotification != null) hashCode = hashCode * 59 + this.EmailNotification.GetHashCode();
                if (this.EnterpriseId != null) hashCode = hashCode * 59 + this.EnterpriseId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.OuName != null) hashCode = hashCode * 59 + this.OuName.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetIds != null) hashCode = hashCode * 59 + this.SubnetIds.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.SchedulerHints != null) hashCode = hashCode * 59 + this.SchedulerHints.GetHashCode();
                hashCode = hashCode * 59 + this.DesktopIsv.GetHashCode();
                hashCode = hashCode * 59 + this.AccessMode.GetHashCode();
                if (this.ApplySharedVpcDedicatedParam != null) hashCode = hashCode * 59 + this.ApplySharedVpcDedicatedParam.GetHashCode();
                if (this.DedicatedSubnets != null) hashCode = hashCode * 59 + this.DedicatedSubnets.GetHashCode();
                if (this.Eip != null) hashCode = hashCode * 59 + this.Eip.GetHashCode();
                if (this.Adn != null) hashCode = hashCode * 59 + this.Adn.GetHashCode();
                if (this.ExclusiveHostId != null) hashCode = hashCode * 59 + this.ExclusiveHostId.GetHashCode();
                if (this.DesktopNamePolicyId != null) hashCode = hashCode * 59 + this.DesktopNamePolicyId.GetHashCode();
                if (this.HourPackageProductId != null) hashCode = hashCode * 59 + this.HourPackageProductId.GetHashCode();
                if (this.HourPackageOfferingId != null) hashCode = hashCode * 59 + this.HourPackageOfferingId.GetHashCode();
                if (this.RootResourceIds != null) hashCode = hashCode * 59 + this.RootResourceIds.GetHashCode();
                if (this.InstInfoIds != null) hashCode = hashCode * 59 + this.InstInfoIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
