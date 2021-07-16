using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 实例配置信息
    /// </summary>
    public class InstanceConfig 
    {
        /// <summary>
        /// 在专属主机上创建弹性云服务器。参数取值为dedicated。
        /// </summary>
        /// <value>在专属主机上创建弹性云服务器。参数取值为dedicated。</value>
        [JsonConverter(typeof(EnumClassConverter<TenancyEnum>))]
        public class TenancyEnum
        {
            /// <summary>
            /// Enum DEDICATED for value: dedicated
            /// </summary>
            public static readonly TenancyEnum DEDICATED = new TenancyEnum("dedicated");

            private static readonly Dictionary<string, TenancyEnum> StaticFields =
            new Dictionary<string, TenancyEnum>()
            {
                { "dedicated", DEDICATED },
            };

            private string Value;

            public TenancyEnum(string value)
            {
                Value = value;
            }

            public static TenancyEnum FromValue(string value)
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

                if (this.Equals(obj as TenancyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TenancyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(TenancyEnum a, TenancyEnum b)
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

            public static bool operator !=(TenancyEnum a, TenancyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 使用伸缩配置创建云主机的时候，多规格使用的优先级策略。PICK_FIRST（默认）：选择优先，虚拟机扩容时规格的选择按照flavorRef列表的顺序进行优先级排序。COST_FIRST：成本优化，虚拟机扩容时规格的选择按照价格最优原则进行优先级排序。
        /// </summary>
        /// <value>使用伸缩配置创建云主机的时候，多规格使用的优先级策略。PICK_FIRST（默认）：选择优先，虚拟机扩容时规格的选择按照flavorRef列表的顺序进行优先级排序。COST_FIRST：成本优化，虚拟机扩容时规格的选择按照价格最优原则进行优先级排序。</value>
        [JsonConverter(typeof(EnumClassConverter<MultiFlavorPriorityPolicyEnum>))]
        public class MultiFlavorPriorityPolicyEnum
        {
            /// <summary>
            /// Enum PICK_FIRST for value: PICK_FIRST
            /// </summary>
            public static readonly MultiFlavorPriorityPolicyEnum PICK_FIRST = new MultiFlavorPriorityPolicyEnum("PICK_FIRST");

            /// <summary>
            /// Enum COST_FIRST for value: COST_FIRST
            /// </summary>
            public static readonly MultiFlavorPriorityPolicyEnum COST_FIRST = new MultiFlavorPriorityPolicyEnum("COST_FIRST");

            private static readonly Dictionary<string, MultiFlavorPriorityPolicyEnum> StaticFields =
            new Dictionary<string, MultiFlavorPriorityPolicyEnum>()
            {
                { "PICK_FIRST", PICK_FIRST },
                { "COST_FIRST", COST_FIRST },
            };

            private string Value;

            public MultiFlavorPriorityPolicyEnum(string value)
            {
                Value = value;
            }

            public static MultiFlavorPriorityPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as MultiFlavorPriorityPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MultiFlavorPriorityPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(MultiFlavorPriorityPolicyEnum a, MultiFlavorPriorityPolicyEnum b)
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

            public static bool operator !=(MultiFlavorPriorityPolicyEnum a, MultiFlavorPriorityPolicyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 云服务器的计费模式，可以选择竞价计费或按需计费，取值如下：按需计费：不指定该字段。竞价计费：spot
        /// </summary>
        /// <value>云服务器的计费模式，可以选择竞价计费或按需计费，取值如下：按需计费：不指定该字段。竞价计费：spot</value>
        [JsonConverter(typeof(EnumClassConverter<MarketTypeEnum>))]
        public class MarketTypeEnum
        {
            /// <summary>
            /// Enum SPOT for value: spot
            /// </summary>
            public static readonly MarketTypeEnum SPOT = new MarketTypeEnum("spot");

            private static readonly Dictionary<string, MarketTypeEnum> StaticFields =
            new Dictionary<string, MarketTypeEnum>()
            {
                { "spot", SPOT },
            };

            private string Value;

            public MarketTypeEnum(string value)
            {
                Value = value;
            }

            public static MarketTypeEnum FromValue(string value)
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

                if (this.Equals(obj as MarketTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MarketTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(MarketTypeEnum a, MarketTypeEnum b)
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

            public static bool operator !=(MarketTypeEnum a, MarketTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 云服务器ID，当使用已存在的云服务器的规格为模板创建弹性伸缩配置时传入该字段，此时flavorRef、imageRef、disk、security_groups、tenancy和dedicated_host_id字段不生效。当不传入instance_id字段时flavorRef、imageRef、disk字段为必选。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 云服务器的规格ID。最多支持选择10个规格，多个规格ID以逗号分隔。云服务器的ID通过查询弹性云服务器规格详情和扩展信息列表接口获取，详情请参考 [查询云服务器规格详情和扩展信息列表](https://support.huaweicloud.com/api-ecs/zh-cn_topic_0020212656.html)。
        /// </summary>
        [JsonProperty("flavorRef", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// 镜像ID，同image_id，指定创建实例时选择的镜像资源。通过查询镜像服务镜像列表接口获取，请参考[查询镜像列表](https://support.huaweicloud.com/api-ims/ims_03_0602.html)。
        /// </summary>
        [JsonProperty("imageRef", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageRef { get; set; }

        /// <summary>
        /// 磁盘组信息，系统盘必选，数据盘可选。
        /// </summary>
        [JsonProperty("disk", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiskInfo> Disk { get; set; }

        /// <summary>
        /// 登录云服务器的SSH密钥名称。  获取密钥对方式请参考[创建及导入SSH密钥对](https://support.huaweicloud.com/api-dew/CreateKeypair.html)。  说明： 当key_name与user_data同时指定时，user_data只做用户数据注入。
        /// </summary>
        [JsonProperty("key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyName { get; set; }

        /// <summary>
        /// 注入文件信息。仅支持注入文本文件，最大支持注入5个文件，每个文件最大1KB。
        /// </summary>
        [JsonProperty("personality", NullValueHandling = NullValueHandling.Ignore)]
        public List<PersonalityInfo> Personality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public PublicIp PublicIp { get; set; }

        /// <summary>
        /// cloud-init用户数据。支持注入文本、文本文件或gzip文件。文件内容需要进行base64格式编码，注入内容（编码之前的内容）最大为32KB。说明：当key_name没有指定时，user_data注入的数据默认为云服务器root账号的登录密码。创建密码方式鉴权的Linux弹性云服务器时为必填项，为root用户注入自定义初始化密码。
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public VmMetaData Metadata { get; set; }

        /// <summary>
        /// 安全组信息。使用vpc_id通过查询VPC服务安全组列表接口获取，详见《虚拟私有云API参考》的“查询安全组列表”。当伸缩配置和伸缩组同时指定安全组时，将以伸缩配置中的安全组为准；当伸缩配置和伸缩组都没有指定安全组时，将使用默认安全组。为了使用灵活性更高，推荐在伸缩配置中指定安全组。
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecurityGroups> SecurityGroups { get; set; }

        /// <summary>
        /// 云服务器组ID。
        /// </summary>
        [JsonProperty("server_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// 在专属主机上创建弹性云服务器。参数取值为dedicated。
        /// </summary>
        [JsonProperty("tenancy", NullValueHandling = NullValueHandling.Ignore)]
        public TenancyEnum Tenancy { get; set; }
        /// <summary>
        /// 专属主机的ID。 说明：该字段仅在tenancy为dedicated时生效；如果指定该字段，云服务器将被创建到指定的专属主机上；如果不指定该字段，此时系统会将云服务器创建在符合规格的专属主机中剩余内存最大的那一台上，以使各专属主机尽量均衡负载。
        /// </summary>
        [JsonProperty("dedicated_host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// 使用伸缩配置创建云主机的时候，多规格使用的优先级策略。PICK_FIRST（默认）：选择优先，虚拟机扩容时规格的选择按照flavorRef列表的顺序进行优先级排序。COST_FIRST：成本优化，虚拟机扩容时规格的选择按照价格最优原则进行优先级排序。
        /// </summary>
        [JsonProperty("multi_flavor_priority_policy", NullValueHandling = NullValueHandling.Ignore)]
        public MultiFlavorPriorityPolicyEnum MultiFlavorPriorityPolicy { get; set; }
        /// <summary>
        /// 云服务器的计费模式，可以选择竞价计费或按需计费，取值如下：按需计费：不指定该字段。竞价计费：spot
        /// </summary>
        [JsonProperty("market_type", NullValueHandling = NullValueHandling.Ignore)]
        public MarketTypeEnum MarketType { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceConfig {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  imageRef: ").Append(ImageRef).Append("\n");
            sb.Append("  disk: ").Append(Disk).Append("\n");
            sb.Append("  keyName: ").Append(KeyName).Append("\n");
            sb.Append("  personality: ").Append(Personality).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  serverGroupId: ").Append(ServerGroupId).Append("\n");
            sb.Append("  tenancy: ").Append(Tenancy).Append("\n");
            sb.Append("  dedicatedHostId: ").Append(DedicatedHostId).Append("\n");
            sb.Append("  multiFlavorPriorityPolicy: ").Append(MultiFlavorPriorityPolicy).Append("\n");
            sb.Append("  marketType: ").Append(MarketType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.FlavorRef == input.FlavorRef ||
                    (this.FlavorRef != null &&
                    this.FlavorRef.Equals(input.FlavorRef))
                ) && 
                (
                    this.ImageRef == input.ImageRef ||
                    (this.ImageRef != null &&
                    this.ImageRef.Equals(input.ImageRef))
                ) && 
                (
                    this.Disk == input.Disk ||
                    this.Disk != null &&
                    input.Disk != null &&
                    this.Disk.SequenceEqual(input.Disk)
                ) && 
                (
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))
                ) && 
                (
                    this.Personality == input.Personality ||
                    this.Personality != null &&
                    input.Personality != null &&
                    this.Personality.SequenceEqual(input.Personality)
                ) && 
                (
                    this.PublicIp == input.PublicIp ||
                    (this.PublicIp != null &&
                    this.PublicIp.Equals(input.PublicIp))
                ) && 
                (
                    this.UserData == input.UserData ||
                    (this.UserData != null &&
                    this.UserData.Equals(input.UserData))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.SecurityGroups == input.SecurityGroups ||
                    this.SecurityGroups != null &&
                    input.SecurityGroups != null &&
                    this.SecurityGroups.SequenceEqual(input.SecurityGroups)
                ) && 
                (
                    this.ServerGroupId == input.ServerGroupId ||
                    (this.ServerGroupId != null &&
                    this.ServerGroupId.Equals(input.ServerGroupId))
                ) && 
                (
                    this.Tenancy == input.Tenancy ||
                    (this.Tenancy != null &&
                    this.Tenancy.Equals(input.Tenancy))
                ) && 
                (
                    this.DedicatedHostId == input.DedicatedHostId ||
                    (this.DedicatedHostId != null &&
                    this.DedicatedHostId.Equals(input.DedicatedHostId))
                ) && 
                (
                    this.MultiFlavorPriorityPolicy == input.MultiFlavorPriorityPolicy ||
                    (this.MultiFlavorPriorityPolicy != null &&
                    this.MultiFlavorPriorityPolicy.Equals(input.MultiFlavorPriorityPolicy))
                ) && 
                (
                    this.MarketType == input.MarketType ||
                    (this.MarketType != null &&
                    this.MarketType.Equals(input.MarketType))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.FlavorRef != null)
                    hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.ImageRef != null)
                    hashCode = hashCode * 59 + this.ImageRef.GetHashCode();
                if (this.Disk != null)
                    hashCode = hashCode * 59 + this.Disk.GetHashCode();
                if (this.KeyName != null)
                    hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.Personality != null)
                    hashCode = hashCode * 59 + this.Personality.GetHashCode();
                if (this.PublicIp != null)
                    hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.SecurityGroups != null)
                    hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.ServerGroupId != null)
                    hashCode = hashCode * 59 + this.ServerGroupId.GetHashCode();
                if (this.Tenancy != null)
                    hashCode = hashCode * 59 + this.Tenancy.GetHashCode();
                if (this.DedicatedHostId != null)
                    hashCode = hashCode * 59 + this.DedicatedHostId.GetHashCode();
                if (this.MultiFlavorPriorityPolicy != null)
                    hashCode = hashCode * 59 + this.MultiFlavorPriorityPolicy.GetHashCode();
                if (this.MarketType != null)
                    hashCode = hashCode * 59 + this.MarketType.GetHashCode();
                return hashCode;
            }
        }
    }
}
