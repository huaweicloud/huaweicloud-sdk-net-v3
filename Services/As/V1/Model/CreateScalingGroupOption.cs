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
    /// 创建伸缩组请求
    /// </summary>
    public class CreateScalingGroupOption 
    {
        /// <summary>
        /// 伸缩组实例健康检查方式：ELB_AUDIT和NOVA_AUDIT。当伸缩组参数中设置负载均衡时，默认为ELB_AUDIT；否则默认为NOVA_AUDIT。ELB_AUDIT表示负载均衡健康检查方式，在有监听器的伸缩组中有效。NOVA_AUDIT表示弹性伸缩自带的健康检查方式。
        /// </summary>
        /// <value>伸缩组实例健康检查方式：ELB_AUDIT和NOVA_AUDIT。当伸缩组参数中设置负载均衡时，默认为ELB_AUDIT；否则默认为NOVA_AUDIT。ELB_AUDIT表示负载均衡健康检查方式，在有监听器的伸缩组中有效。NOVA_AUDIT表示弹性伸缩自带的健康检查方式。</value>
        [JsonConverter(typeof(EnumClassConverter<HealthPeriodicAuditMethodEnum>))]
        public class HealthPeriodicAuditMethodEnum
        {
            /// <summary>
            /// Enum ELB_AUDIT for value: ELB_AUDIT
            /// </summary>
            public static readonly HealthPeriodicAuditMethodEnum ELB_AUDIT = new HealthPeriodicAuditMethodEnum("ELB_AUDIT");

            /// <summary>
            /// Enum NOVA_AUDIT for value: NOVA_AUDIT
            /// </summary>
            public static readonly HealthPeriodicAuditMethodEnum NOVA_AUDIT = new HealthPeriodicAuditMethodEnum("NOVA_AUDIT");

            private static readonly Dictionary<string, HealthPeriodicAuditMethodEnum> StaticFields =
            new Dictionary<string, HealthPeriodicAuditMethodEnum>()
            {
                { "ELB_AUDIT", ELB_AUDIT },
                { "NOVA_AUDIT", NOVA_AUDIT },
            };

            private string _value;

            public HealthPeriodicAuditMethodEnum()
            {

            }

            public HealthPeriodicAuditMethodEnum(string value)
            {
                _value = value;
            }

            public static HealthPeriodicAuditMethodEnum FromValue(string value)
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

                if (this.Equals(obj as HealthPeriodicAuditMethodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HealthPeriodicAuditMethodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HealthPeriodicAuditMethodEnum a, HealthPeriodicAuditMethodEnum b)
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

            public static bool operator !=(HealthPeriodicAuditMethodEnum a, HealthPeriodicAuditMethodEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 伸缩组实例移除策略：OLD_CONFIG_OLD_INSTANCE（默认）：从根据“较早创建的配置”创建的实例中筛选出较早创建的实例被优先移除。OLD_CONFIG_NEW_INSTANCE：从根据“较早创建的配置”创建的实例中筛选出较新创建的实例被优先移除。OLD_INSTANCE：较早创建的实例被优先移除。NEW_INSTANCE：较新创建的实例将被优先移除。
        /// </summary>
        /// <value>伸缩组实例移除策略：OLD_CONFIG_OLD_INSTANCE（默认）：从根据“较早创建的配置”创建的实例中筛选出较早创建的实例被优先移除。OLD_CONFIG_NEW_INSTANCE：从根据“较早创建的配置”创建的实例中筛选出较新创建的实例被优先移除。OLD_INSTANCE：较早创建的实例被优先移除。NEW_INSTANCE：较新创建的实例将被优先移除。</value>
        [JsonConverter(typeof(EnumClassConverter<InstanceTerminatePolicyEnum>))]
        public class InstanceTerminatePolicyEnum
        {
            /// <summary>
            /// Enum OLD_CONFIG_OLD_INSTANCE for value: OLD_CONFIG_OLD_INSTANCE
            /// </summary>
            public static readonly InstanceTerminatePolicyEnum OLD_CONFIG_OLD_INSTANCE = new InstanceTerminatePolicyEnum("OLD_CONFIG_OLD_INSTANCE");

            /// <summary>
            /// Enum OLD_CONFIG_NEW_INSTANCE for value: OLD_CONFIG_NEW_INSTANCE
            /// </summary>
            public static readonly InstanceTerminatePolicyEnum OLD_CONFIG_NEW_INSTANCE = new InstanceTerminatePolicyEnum("OLD_CONFIG_NEW_INSTANCE");

            /// <summary>
            /// Enum OLD_INSTANCE for value: OLD_INSTANCE
            /// </summary>
            public static readonly InstanceTerminatePolicyEnum OLD_INSTANCE = new InstanceTerminatePolicyEnum("OLD_INSTANCE");

            /// <summary>
            /// Enum NEW_INSTANCE for value: NEW_INSTANCE
            /// </summary>
            public static readonly InstanceTerminatePolicyEnum NEW_INSTANCE = new InstanceTerminatePolicyEnum("NEW_INSTANCE");

            private static readonly Dictionary<string, InstanceTerminatePolicyEnum> StaticFields =
            new Dictionary<string, InstanceTerminatePolicyEnum>()
            {
                { "OLD_CONFIG_OLD_INSTANCE", OLD_CONFIG_OLD_INSTANCE },
                { "OLD_CONFIG_NEW_INSTANCE", OLD_CONFIG_NEW_INSTANCE },
                { "OLD_INSTANCE", OLD_INSTANCE },
                { "NEW_INSTANCE", NEW_INSTANCE },
            };

            private string _value;

            public InstanceTerminatePolicyEnum()
            {

            }

            public InstanceTerminatePolicyEnum(string value)
            {
                _value = value;
            }

            public static InstanceTerminatePolicyEnum FromValue(string value)
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

                if (this.Equals(obj as InstanceTerminatePolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InstanceTerminatePolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InstanceTerminatePolicyEnum a, InstanceTerminatePolicyEnum b)
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

            public static bool operator !=(InstanceTerminatePolicyEnum a, InstanceTerminatePolicyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 伸缩组扩缩容时目标AZ选择的优先级策略：EQUILIBRIUM_DISTRIBUTE（默认）：均衡分布，云服务器扩缩容时优先保证available_zones列表中各AZ下虚拟机数量均衡，当无法在目标AZ下完成虚拟机扩容时，按照PICK_FIRST原则选择其他可用AZ。PICK_FIRST：选择优先，虚拟机扩缩容时目标AZ的选择按照available_zones列表的顺序进行优先级排序。
        /// </summary>
        /// <value>伸缩组扩缩容时目标AZ选择的优先级策略：EQUILIBRIUM_DISTRIBUTE（默认）：均衡分布，云服务器扩缩容时优先保证available_zones列表中各AZ下虚拟机数量均衡，当无法在目标AZ下完成虚拟机扩容时，按照PICK_FIRST原则选择其他可用AZ。PICK_FIRST：选择优先，虚拟机扩缩容时目标AZ的选择按照available_zones列表的顺序进行优先级排序。</value>
        [JsonConverter(typeof(EnumClassConverter<MultiAzPriorityPolicyEnum>))]
        public class MultiAzPriorityPolicyEnum
        {
            /// <summary>
            /// Enum EQUILIBRIUM_DISTRIBUTE for value: EQUILIBRIUM_DISTRIBUTE
            /// </summary>
            public static readonly MultiAzPriorityPolicyEnum EQUILIBRIUM_DISTRIBUTE = new MultiAzPriorityPolicyEnum("EQUILIBRIUM_DISTRIBUTE");

            /// <summary>
            /// Enum PICK_FIRST for value: PICK_FIRST
            /// </summary>
            public static readonly MultiAzPriorityPolicyEnum PICK_FIRST = new MultiAzPriorityPolicyEnum("PICK_FIRST");

            private static readonly Dictionary<string, MultiAzPriorityPolicyEnum> StaticFields =
            new Dictionary<string, MultiAzPriorityPolicyEnum>()
            {
                { "EQUILIBRIUM_DISTRIBUTE", EQUILIBRIUM_DISTRIBUTE },
                { "PICK_FIRST", PICK_FIRST },
            };

            private string _value;

            public MultiAzPriorityPolicyEnum()
            {

            }

            public MultiAzPriorityPolicyEnum(string value)
            {
                _value = value;
            }

            public static MultiAzPriorityPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as MultiAzPriorityPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MultiAzPriorityPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MultiAzPriorityPolicyEnum a, MultiAzPriorityPolicyEnum b)
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

            public static bool operator !=(MultiAzPriorityPolicyEnum a, MultiAzPriorityPolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 伸缩组名称(1-64个字符)，只能包含中文、字母、数字、下划线、中划线。
        /// </summary>
        [JsonProperty("scaling_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingGroupName { get; set; }

        /// <summary>
        /// 伸缩配置ID，通过查询弹性伸缩配置列表接口获取。
        /// </summary>
        [JsonProperty("scaling_configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingConfigurationId { get; set; }

        /// <summary>
        /// 期望实例数量，默认值为最小实例数。最小实例数&lt;&#x3D;期望实例数&lt;&#x3D;最大实例数
        /// </summary>
        [JsonProperty("desire_instance_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? DesireInstanceNumber { get; set; }

        /// <summary>
        /// 最小实例数量，默认值为0。
        /// </summary>
        [JsonProperty("min_instance_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinInstanceNumber { get; set; }

        /// <summary>
        /// 最大实例数量，默认值为0。
        /// </summary>
        [JsonProperty("max_instance_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxInstanceNumber { get; set; }

        /// <summary>
        /// 冷却时间，取值范围0-86400，默认为300，单位是秒。 只针对告警策略生效，定时、周期策略和手动触发策略不受该参数限制。
        /// </summary>
        [JsonProperty("cool_down_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? CoolDownTime { get; set; }

        /// <summary>
        /// 弹性负载均衡（经典型）监听器ID，最多支持绑定6个负载均衡监听器，多个负载均衡监听器ID以逗号分隔。首先使用vpc_id通过查询ELB服务负载均衡器列表接口获取负载均衡器的ID，详见《弹性负载均衡API参考》的“查询负载均衡器列表”，再使用该ID查询监听器列表获取，详见《弹性负载均衡API参考》的“查询监听器列表”。
        /// </summary>
        [JsonProperty("lb_listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LbListenerId { get; set; }

        /// <summary>
        /// 弹性负载均衡器（增强型）信息，最多支持绑定6个负载均衡。该字段与lb_listener_id互斥。
        /// </summary>
        [JsonProperty("lbaas_listeners", NullValueHandling = NullValueHandling.Ignore)]
        public List<LbaasListeners> LbaasListeners { get; set; }

        /// <summary>
        /// 可用分区信息。弹性伸缩活动中自动添加的云服务器会被创建在指定的可用区中。如果没有指定可用分区，会由系统自动指定可用分区。详情请参考地区和终端节点。
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// 网络信息，最多支持选择5个子网，传入的第一个子网默认作为云服务器的主网卡。获取子网信息请参考[查询子网列表](https://support.huaweicloud.com/api-vpc/vpc_subnet01_0003.html)。
        /// </summary>
        [JsonProperty("networks", NullValueHandling = NullValueHandling.Ignore)]
        public List<Networks> Networks { get; set; }

        /// <summary>
        /// 安全组信息，最多支持选择1个安全组。使用vpc_id通过查询VPC服务安全组列表接口获取，详见《虚拟私有云API参考》的“查询安全组列表”。当伸缩配置和伸缩组同时指定安全组时，将以伸缩配置中的安全组为准；当伸缩配置和伸缩组都没有指定安全组时，将使用默认安全组。为了使用灵活性更高，推荐在伸缩配置中指定安全组。
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecurityGroup> SecurityGroups { get; set; }

        /// <summary>
        /// VPC信息，通过查询VPC服务VPC列表接口获取，详见《虚拟私有云API参考》的“查询VPC列表”。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 伸缩组实例健康检查方式：ELB_AUDIT和NOVA_AUDIT。当伸缩组参数中设置负载均衡时，默认为ELB_AUDIT；否则默认为NOVA_AUDIT。ELB_AUDIT表示负载均衡健康检查方式，在有监听器的伸缩组中有效。NOVA_AUDIT表示弹性伸缩自带的健康检查方式。
        /// </summary>
        [JsonProperty("health_periodic_audit_method", NullValueHandling = NullValueHandling.Ignore)]
        public HealthPeriodicAuditMethodEnum HealthPeriodicAuditMethod { get; set; }
        /// <summary>
        /// 伸缩组实例的健康检查周期，可设置为1、5、15、60、180（分钟），若不设置该参数，默认为5。若设置为0，可以实现10秒级健康检查。
        /// </summary>
        [JsonProperty("health_periodic_audit_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? HealthPeriodicAuditTime { get; set; }

        /// <summary>
        /// 伸缩组实例健康状况检查宽限期，取值范围0-86400，单位是秒。当实例加入伸缩组并且进入已启用状态后，健康状况检查宽限期才会启动，伸缩组会等健康状况检查宽限期结束后才检查实例的运行状况。当伸缩组实例健康检查方式为ELB_AUDIT时，该参数生效，若不设置该参数，默认为600秒。
        /// </summary>
        [JsonProperty("health_periodic_audit_grace_period", NullValueHandling = NullValueHandling.Ignore)]
        public int? HealthPeriodicAuditGracePeriod { get; set; }

        /// <summary>
        /// 伸缩组实例移除策略：OLD_CONFIG_OLD_INSTANCE（默认）：从根据“较早创建的配置”创建的实例中筛选出较早创建的实例被优先移除。OLD_CONFIG_NEW_INSTANCE：从根据“较早创建的配置”创建的实例中筛选出较新创建的实例被优先移除。OLD_INSTANCE：较早创建的实例被优先移除。NEW_INSTANCE：较新创建的实例将被优先移除。
        /// </summary>
        [JsonProperty("instance_terminate_policy", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceTerminatePolicyEnum InstanceTerminatePolicy { get; set; }
        /// <summary>
        /// 通知方式：EMAIL为发送邮件通知。该通知方式即将被废除，建议给弹性伸缩组配置通知功能。详见通知。
        /// </summary>
        [JsonProperty("notifications", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Notifications { get; set; }

        /// <summary>
        /// 配置删除云服务器时是否删除云服务器绑定的弹性IP。取值为true或false，默认为false。true：删除云服务器时，会同时删除绑定在云服务器上的弹性IP。当弹性IP的计费方式为包年包月时，不会被删除。false：删除云服务器时，仅解绑定在云服务器上的弹性IP，不删除弹性IP。
        /// </summary>
        [JsonProperty("delete_publicip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeletePublicip { get; set; }

        /// <summary>
        /// 配置删除云服务器时是否删除云服务器绑定的数据盘。取值为true或false，默认为false。 true：删除云服务器时，会同时删除绑定在云服务器上的数据盘。当数据盘的计费方式为包年包月时，不会被删除。 false：删除云服务器时，仅解绑定在云服务器上的数据盘，不删除数据盘。
        /// </summary>
        [JsonProperty("delete_volume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteVolume { get; set; }

        /// <summary>
        /// 企业项目ID，用于指定伸缩组归属的企业项目。取值为0或无该值，表示属于default企业项目。取值为UUID，表示属于该UUID对应的企业项目，如何获取企业项目ID，请参考[查询企业项目列表](https://support.huaweicloud.com/api-em/zh-cn_topic_0121230880.html)。当伸缩组配置企业项目时，由该伸缩组创建的弹性云服务器将归属于该企业项目。否则将使用默认企业项目。说明：关于企业项目特性的详细信息，请参见[企业项目管理](https://support.huaweicloud.com/usermanual-em/zh-cn_topic_0131965280.html)。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 伸缩组扩缩容时目标AZ选择的优先级策略：EQUILIBRIUM_DISTRIBUTE（默认）：均衡分布，云服务器扩缩容时优先保证available_zones列表中各AZ下虚拟机数量均衡，当无法在目标AZ下完成虚拟机扩容时，按照PICK_FIRST原则选择其他可用AZ。PICK_FIRST：选择优先，虚拟机扩缩容时目标AZ的选择按照available_zones列表的顺序进行优先级排序。
        /// </summary>
        [JsonProperty("multi_az_priority_policy", NullValueHandling = NullValueHandling.Ignore)]
        public MultiAzPriorityPolicyEnum MultiAzPriorityPolicy { get; set; }
        /// <summary>
        /// 委托的名称委托是由租户管理员在统一身份认证服务（Identity and Access Management，IAM）上创建的，可以为弹性云服务器提供访问云服务的临时凭证。
        /// </summary>
        [JsonProperty("iam_agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IamAgencyName { get; set; }

        /// <summary>
        /// 伸缩组描述信息(0-256个字符)
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateScalingGroupOption {\n");
            sb.Append("  scalingGroupName: ").Append(ScalingGroupName).Append("\n");
            sb.Append("  scalingConfigurationId: ").Append(ScalingConfigurationId).Append("\n");
            sb.Append("  desireInstanceNumber: ").Append(DesireInstanceNumber).Append("\n");
            sb.Append("  minInstanceNumber: ").Append(MinInstanceNumber).Append("\n");
            sb.Append("  maxInstanceNumber: ").Append(MaxInstanceNumber).Append("\n");
            sb.Append("  coolDownTime: ").Append(CoolDownTime).Append("\n");
            sb.Append("  lbListenerId: ").Append(LbListenerId).Append("\n");
            sb.Append("  lbaasListeners: ").Append(LbaasListeners).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  networks: ").Append(Networks).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  healthPeriodicAuditMethod: ").Append(HealthPeriodicAuditMethod).Append("\n");
            sb.Append("  healthPeriodicAuditTime: ").Append(HealthPeriodicAuditTime).Append("\n");
            sb.Append("  healthPeriodicAuditGracePeriod: ").Append(HealthPeriodicAuditGracePeriod).Append("\n");
            sb.Append("  instanceTerminatePolicy: ").Append(InstanceTerminatePolicy).Append("\n");
            sb.Append("  notifications: ").Append(Notifications).Append("\n");
            sb.Append("  deletePublicip: ").Append(DeletePublicip).Append("\n");
            sb.Append("  deleteVolume: ").Append(DeleteVolume).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  multiAzPriorityPolicy: ").Append(MultiAzPriorityPolicy).Append("\n");
            sb.Append("  iamAgencyName: ").Append(IamAgencyName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateScalingGroupOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateScalingGroupOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScalingGroupName == input.ScalingGroupName ||
                    (this.ScalingGroupName != null &&
                    this.ScalingGroupName.Equals(input.ScalingGroupName))
                ) && 
                (
                    this.ScalingConfigurationId == input.ScalingConfigurationId ||
                    (this.ScalingConfigurationId != null &&
                    this.ScalingConfigurationId.Equals(input.ScalingConfigurationId))
                ) && 
                (
                    this.DesireInstanceNumber == input.DesireInstanceNumber ||
                    (this.DesireInstanceNumber != null &&
                    this.DesireInstanceNumber.Equals(input.DesireInstanceNumber))
                ) && 
                (
                    this.MinInstanceNumber == input.MinInstanceNumber ||
                    (this.MinInstanceNumber != null &&
                    this.MinInstanceNumber.Equals(input.MinInstanceNumber))
                ) && 
                (
                    this.MaxInstanceNumber == input.MaxInstanceNumber ||
                    (this.MaxInstanceNumber != null &&
                    this.MaxInstanceNumber.Equals(input.MaxInstanceNumber))
                ) && 
                (
                    this.CoolDownTime == input.CoolDownTime ||
                    (this.CoolDownTime != null &&
                    this.CoolDownTime.Equals(input.CoolDownTime))
                ) && 
                (
                    this.LbListenerId == input.LbListenerId ||
                    (this.LbListenerId != null &&
                    this.LbListenerId.Equals(input.LbListenerId))
                ) && 
                (
                    this.LbaasListeners == input.LbaasListeners ||
                    this.LbaasListeners != null &&
                    input.LbaasListeners != null &&
                    this.LbaasListeners.SequenceEqual(input.LbaasListeners)
                ) && 
                (
                    this.AvailableZones == input.AvailableZones ||
                    this.AvailableZones != null &&
                    input.AvailableZones != null &&
                    this.AvailableZones.SequenceEqual(input.AvailableZones)
                ) && 
                (
                    this.Networks == input.Networks ||
                    this.Networks != null &&
                    input.Networks != null &&
                    this.Networks.SequenceEqual(input.Networks)
                ) && 
                (
                    this.SecurityGroups == input.SecurityGroups ||
                    this.SecurityGroups != null &&
                    input.SecurityGroups != null &&
                    this.SecurityGroups.SequenceEqual(input.SecurityGroups)
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.HealthPeriodicAuditMethod == input.HealthPeriodicAuditMethod ||
                    (this.HealthPeriodicAuditMethod != null &&
                    this.HealthPeriodicAuditMethod.Equals(input.HealthPeriodicAuditMethod))
                ) && 
                (
                    this.HealthPeriodicAuditTime == input.HealthPeriodicAuditTime ||
                    (this.HealthPeriodicAuditTime != null &&
                    this.HealthPeriodicAuditTime.Equals(input.HealthPeriodicAuditTime))
                ) && 
                (
                    this.HealthPeriodicAuditGracePeriod == input.HealthPeriodicAuditGracePeriod ||
                    (this.HealthPeriodicAuditGracePeriod != null &&
                    this.HealthPeriodicAuditGracePeriod.Equals(input.HealthPeriodicAuditGracePeriod))
                ) && 
                (
                    this.InstanceTerminatePolicy == input.InstanceTerminatePolicy ||
                    (this.InstanceTerminatePolicy != null &&
                    this.InstanceTerminatePolicy.Equals(input.InstanceTerminatePolicy))
                ) && 
                (
                    this.Notifications == input.Notifications ||
                    this.Notifications != null &&
                    input.Notifications != null &&
                    this.Notifications.SequenceEqual(input.Notifications)
                ) && 
                (
                    this.DeletePublicip == input.DeletePublicip ||
                    (this.DeletePublicip != null &&
                    this.DeletePublicip.Equals(input.DeletePublicip))
                ) && 
                (
                    this.DeleteVolume == input.DeleteVolume ||
                    (this.DeleteVolume != null &&
                    this.DeleteVolume.Equals(input.DeleteVolume))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.MultiAzPriorityPolicy == input.MultiAzPriorityPolicy ||
                    (this.MultiAzPriorityPolicy != null &&
                    this.MultiAzPriorityPolicy.Equals(input.MultiAzPriorityPolicy))
                ) && 
                (
                    this.IamAgencyName == input.IamAgencyName ||
                    (this.IamAgencyName != null &&
                    this.IamAgencyName.Equals(input.IamAgencyName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.ScalingGroupName != null)
                    hashCode = hashCode * 59 + this.ScalingGroupName.GetHashCode();
                if (this.ScalingConfigurationId != null)
                    hashCode = hashCode * 59 + this.ScalingConfigurationId.GetHashCode();
                if (this.DesireInstanceNumber != null)
                    hashCode = hashCode * 59 + this.DesireInstanceNumber.GetHashCode();
                if (this.MinInstanceNumber != null)
                    hashCode = hashCode * 59 + this.MinInstanceNumber.GetHashCode();
                if (this.MaxInstanceNumber != null)
                    hashCode = hashCode * 59 + this.MaxInstanceNumber.GetHashCode();
                if (this.CoolDownTime != null)
                    hashCode = hashCode * 59 + this.CoolDownTime.GetHashCode();
                if (this.LbListenerId != null)
                    hashCode = hashCode * 59 + this.LbListenerId.GetHashCode();
                if (this.LbaasListeners != null)
                    hashCode = hashCode * 59 + this.LbaasListeners.GetHashCode();
                if (this.AvailableZones != null)
                    hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.Networks != null)
                    hashCode = hashCode * 59 + this.Networks.GetHashCode();
                if (this.SecurityGroups != null)
                    hashCode = hashCode * 59 + this.SecurityGroups.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.HealthPeriodicAuditMethod != null)
                    hashCode = hashCode * 59 + this.HealthPeriodicAuditMethod.GetHashCode();
                if (this.HealthPeriodicAuditTime != null)
                    hashCode = hashCode * 59 + this.HealthPeriodicAuditTime.GetHashCode();
                if (this.HealthPeriodicAuditGracePeriod != null)
                    hashCode = hashCode * 59 + this.HealthPeriodicAuditGracePeriod.GetHashCode();
                if (this.InstanceTerminatePolicy != null)
                    hashCode = hashCode * 59 + this.InstanceTerminatePolicy.GetHashCode();
                if (this.Notifications != null)
                    hashCode = hashCode * 59 + this.Notifications.GetHashCode();
                if (this.DeletePublicip != null)
                    hashCode = hashCode * 59 + this.DeletePublicip.GetHashCode();
                if (this.DeleteVolume != null)
                    hashCode = hashCode * 59 + this.DeleteVolume.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.MultiAzPriorityPolicy != null)
                    hashCode = hashCode * 59 + this.MultiAzPriorityPolicy.GetHashCode();
                if (this.IamAgencyName != null)
                    hashCode = hashCode * 59 + this.IamAgencyName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
