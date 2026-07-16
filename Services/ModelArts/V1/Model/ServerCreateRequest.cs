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
    /// 
    /// </summary>
    public class ServerCreateRequest 
    {
        /// <summary>
        /// **参数解释**：服务器规格架构类型。 **约束限制**：不涉及。 **取值范围**： - X86：CPU架构为X86 - ARM：CPU架构为ARM **默认取值**：不涉及。
        /// </summary>
        /// <value>**参数解释**：服务器规格架构类型。 **约束限制**：不涉及。 **取值范围**： - X86：CPU架构为X86 - ARM：CPU架构为ARM **默认取值**：不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<ArchEnum>))]
        public class ArchEnum
        {
            /// <summary>
            /// Enum ARM for value: ARM
            /// </summary>
            public static readonly ArchEnum ARM = new ArchEnum("ARM");

            /// <summary>
            /// Enum X86 for value: X86
            /// </summary>
            public static readonly ArchEnum X86 = new ArchEnum("X86");

            private static readonly Dictionary<string, ArchEnum> StaticFields =
            new Dictionary<string, ArchEnum>()
            {
                { "ARM", ARM },
                { "X86", X86 },
            };

            private string _value;

            public ArchEnum()
            {

            }

            public ArchEnum(string value)
            {
                _value = value;
            }

            public static ArchEnum FromValue(string value)
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

                if (this.Equals(obj as ArchEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ArchEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ArchEnum a, ArchEnum b)
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

            public static bool operator !=(ArchEnum a, ArchEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：服务器类型。 **约束限制**：不涉及。 **取值范围**： - BMS：裸金属服务 - ECS：弹性云服务 - HPS：超节点服务 **默认取值**：不涉及。
        /// </summary>
        /// <value>**参数解释**：服务器类型。 **约束限制**：不涉及。 **取值范围**： - BMS：裸金属服务 - ECS：弹性云服务 - HPS：超节点服务 **默认取值**：不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<ServerTypeEnum>))]
        public class ServerTypeEnum
        {
            /// <summary>
            /// Enum BMS for value: BMS
            /// </summary>
            public static readonly ServerTypeEnum BMS = new ServerTypeEnum("BMS");

            /// <summary>
            /// Enum ECS for value: ECS
            /// </summary>
            public static readonly ServerTypeEnum ECS = new ServerTypeEnum("ECS");

            /// <summary>
            /// Enum HPS for value: HPS
            /// </summary>
            public static readonly ServerTypeEnum HPS = new ServerTypeEnum("HPS");

            private static readonly Dictionary<string, ServerTypeEnum> StaticFields =
            new Dictionary<string, ServerTypeEnum>()
            {
                { "BMS", BMS },
                { "ECS", ECS },
                { "HPS", HPS },
            };

            private string _value;

            public ServerTypeEnum()
            {

            }

            public ServerTypeEnum(string value)
            {
                _value = value;
            }

            public static ServerTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ServerTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ServerTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ServerTypeEnum a, ServerTypeEnum b)
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

            public static bool operator !=(ServerTypeEnum a, ServerTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：用于登录服务器的密码。admin_pass和key_pair_name必须二选一。密码规则： - 长度为8至26个字符 - 至少包含大写字母、小写字母、数字及特殊符号(!@%-_&#x3D;+[{}]:,./?)中的3种 - 不能与用户名或倒序的用户名相同 - 不能包含root或administrator及其逆序 **约束限制**：admin_pass和key_pair_name不能同时存在。 **取值范围**：长度为8至26个字符，满足上述密码规则。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("admin_pass", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminPass { get; set; }

        /// <summary>
        /// **参数解释**：服务器规格架构类型。 **约束限制**：不涉及。 **取值范围**： - X86：CPU架构为X86 - ARM：CPU架构为ARM **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("arch", NullValueHandling = NullValueHandling.Ignore)]
        public ArchEnum Arch { get; set; }
        /// <summary>
        /// **参数解释**：服务器所在的可用区。 **约束限制**：不涉及。 **取值范围**：长度为1至256个字符，只能包含字母、数字、中划线、下划线和点。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("charging_info", NullValueHandling = NullValueHandling.Ignore)]
        public ChargingInfo ChargingInfo { get; set; }

        /// <summary>
        /// **参数解释**：单次购买的服务器数量。 **约束限制**：不支持超节点。 **取值范围**：1至10。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// **参数解释**：企业ID。 **约束限制**：不涉及。 **取值范围**：长度为1至36个字符，只能包含字母、数字、中划线、下划线和点。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释**：服务器规格名称。 **约束限制**：flavor和resource_flavor二选一。 **取值范围**：长度为1至128个字符。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// **参数解释**：服务器资源规格名称。 **约束限制**：flavor和resource_flavor二选一。 **取值范围**：长度为1至256个字符，只能包含字母、数字、中划线、下划线和点。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("resource_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceFlavor { get; set; }

        /// <summary>
        /// **参数解释**：服务器镜像ID。 **约束限制**：不涉及。 **取值范围**：长度为36个字符，符合UUID格式。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// **参数解释**：服务器登录密钥对名称。admin_pass和key_pair_name必须二选一。注意超节点仅支持使用密钥对创建。 **约束限制**：admin_pass和key_pair_name不能同时存在。 **取值范围**：长度为1至64个字符，只能包含字母、数字、中划线、下划线和点。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("key_pair_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// **参数解释**：服务器名称。 **约束限制**：不涉及。 **取值范围**：长度为1至64个字符，只能包含字母、数字、中划线、下划线和点。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("network", NullValueHandling = NullValueHandling.Ignore)]
        public ServerNetwork Network { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("root_volume", NullValueHandling = NullValueHandling.Ignore)]
        public EvsVolume RootVolume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data_volume", NullValueHandling = NullValueHandling.Ignore)]
        public ServerDataVolume DataVolume { get; set; }

        /// <summary>
        /// **参数解释**：服务器类型。 **约束限制**：不涉及。 **取值范围**： - BMS：裸金属服务 - ECS：弹性云服务 - HPS：超节点服务 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("server_type", NullValueHandling = NullValueHandling.Ignore)]
        public ServerTypeEnum ServerType { get; set; }
        /// <summary>
        /// **参数解释**： 创建云服务器过程中待注入实例自定义数据。支持注入文本、文本文件。 示例： base64编码前： * Linux服务器： &#x60;&#x60;&#x60;bash #!/bin/bash echo user_test &gt; /home/user.txt &#x60;&#x60;&#x60; base64编码后： * Linux服务器： &#x60;&#x60;&#x60;bash IyEvYmluL2Jhc2gKZWNobyB1c2VyX3Rlc3QgPiAvaG9tZS91c2VyLnR4dA&#x3D;&#x3D; &#x60;&#x60;&#x60; 了解更多实例自定义数据注入请参考[[用户数据注入](https://support.huaweicloud.com/usermanual-ecs/zh-cn_topic_0032380449.html)](tag:hc)[[用户数据注入](https://support.huaweicloud.com/intl/zh-cn/usermanual-ecs/zh-cn_topic_0032380449.html)](tag:hk)[ECS服务“通过实例自定义数据配置ECS实例”章节](tag:fcs,hcso)。 用户需明确user_data的使用效果，可能产生的影响和风险由用户自行承担。 **约束限制**： - user_data的值为base64编码之后的内容。 - 注入内容（编码之前的内容）最大长度为32K。  **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

        /// <summary>
        /// **参数解释**：超节点集群网络信息。仅在创建超节点时需要该参数。 **约束限制**：仅用于创建HPS类型的服务器。 **取值范围**：长度为36个字符，符合UUID格式。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("hps_cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HpsClusterId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerCreateRequest {\n");
            sb.Append("  adminPass: ").Append(AdminPass).Append("\n");
            sb.Append("  arch: ").Append(Arch).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  chargingInfo: ").Append(ChargingInfo).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  resourceFlavor: ").Append(ResourceFlavor).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  keyPairName: ").Append(KeyPairName).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  network: ").Append(Network).Append("\n");
            sb.Append("  rootVolume: ").Append(RootVolume).Append("\n");
            sb.Append("  dataVolume: ").Append(DataVolume).Append("\n");
            sb.Append("  serverType: ").Append(ServerType).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  hpsClusterId: ").Append(HpsClusterId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerCreateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerCreateRequest input)
        {
            if (input == null) return false;
            if (this.AdminPass != input.AdminPass || (this.AdminPass != null && !this.AdminPass.Equals(input.AdminPass))) return false;
            if (this.Arch != input.Arch) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.ChargingInfo != input.ChargingInfo || (this.ChargingInfo != null && !this.ChargingInfo.Equals(input.ChargingInfo))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.ResourceFlavor != input.ResourceFlavor || (this.ResourceFlavor != null && !this.ResourceFlavor.Equals(input.ResourceFlavor))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.KeyPairName != input.KeyPairName || (this.KeyPairName != null && !this.KeyPairName.Equals(input.KeyPairName))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Network != input.Network || (this.Network != null && !this.Network.Equals(input.Network))) return false;
            if (this.RootVolume != input.RootVolume || (this.RootVolume != null && !this.RootVolume.Equals(input.RootVolume))) return false;
            if (this.DataVolume != input.DataVolume || (this.DataVolume != null && !this.DataVolume.Equals(input.DataVolume))) return false;
            if (this.ServerType != input.ServerType) return false;
            if (this.UserData != input.UserData || (this.UserData != null && !this.UserData.Equals(input.UserData))) return false;
            if (this.HpsClusterId != input.HpsClusterId || (this.HpsClusterId != null && !this.HpsClusterId.Equals(input.HpsClusterId))) return false;

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
                if (this.AdminPass != null) hashCode = hashCode * 59 + this.AdminPass.GetHashCode();
                hashCode = hashCode * 59 + this.Arch.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.ChargingInfo != null) hashCode = hashCode * 59 + this.ChargingInfo.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.ResourceFlavor != null) hashCode = hashCode * 59 + this.ResourceFlavor.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.KeyPairName != null) hashCode = hashCode * 59 + this.KeyPairName.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Network != null) hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.RootVolume != null) hashCode = hashCode * 59 + this.RootVolume.GetHashCode();
                if (this.DataVolume != null) hashCode = hashCode * 59 + this.DataVolume.GetHashCode();
                hashCode = hashCode * 59 + this.ServerType.GetHashCode();
                if (this.UserData != null) hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.HpsClusterId != null) hashCode = hashCode * 59 + this.HpsClusterId.GetHashCode();
                return hashCode;
            }
        }
    }
}
