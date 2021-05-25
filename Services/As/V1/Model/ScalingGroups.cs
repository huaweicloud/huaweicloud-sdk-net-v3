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
    /// 伸缩组详情
    /// </summary>
    public class ScalingGroups 
    {
        /// <summary>
        /// 伸缩组状态。
        /// </summary>
        /// <value>伸缩组状态。</value>
        [JsonConverter(typeof(EnumClassConverter<ScalingGroupStatusEnum>))]
        public class ScalingGroupStatusEnum
        {
            /// <summary>
            /// Enum INSERVICE for value: INSERVICE
            /// </summary>
            public static readonly ScalingGroupStatusEnum INSERVICE = new ScalingGroupStatusEnum("INSERVICE");

            /// <summary>
            /// Enum PAUSED for value: PAUSED
            /// </summary>
            public static readonly ScalingGroupStatusEnum PAUSED = new ScalingGroupStatusEnum("PAUSED");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly ScalingGroupStatusEnum ERROR = new ScalingGroupStatusEnum("ERROR");

            /// <summary>
            /// Enum DELETING for value: DELETING
            /// </summary>
            public static readonly ScalingGroupStatusEnum DELETING = new ScalingGroupStatusEnum("DELETING");

            /// <summary>
            /// Enum FREEZED for value: FREEZED
            /// </summary>
            public static readonly ScalingGroupStatusEnum FREEZED = new ScalingGroupStatusEnum("FREEZED");

            private static readonly Dictionary<string, ScalingGroupStatusEnum> StaticFields =
            new Dictionary<string, ScalingGroupStatusEnum>()
            {
                { "INSERVICE", INSERVICE },
                { "PAUSED", PAUSED },
                { "ERROR", ERROR },
                { "DELETING", DELETING },
                { "FREEZED", FREEZED },
            };

            private string Value;

            public ScalingGroupStatusEnum(string value)
            {
                Value = value;
            }

            public static ScalingGroupStatusEnum FromValue(string value)
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

                if (this.Equals(obj as ScalingGroupStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ScalingGroupStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ScalingGroupStatusEnum a, ScalingGroupStatusEnum b)
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

            public static bool operator !=(ScalingGroupStatusEnum a, ScalingGroupStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 健康检查方式。
        /// </summary>
        /// <value>健康检查方式。</value>
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

            private string Value;

            public HealthPeriodicAuditMethodEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 移除策略。
        /// </summary>
        /// <value>移除策略。</value>
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

            private string Value;

            public InstanceTerminatePolicyEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 伸缩组名称。
        /// </summary>
        [JsonProperty("scaling_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingGroupName { get; set; }

        /// <summary>
        /// 伸缩组ID。
        /// </summary>
        [JsonProperty("scaling_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// 伸缩组状态。
        /// </summary>
        [JsonProperty("scaling_group_status", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingGroupStatusEnum ScalingGroupStatus { get; set; }
        /// <summary>
        /// 伸缩配置ID。
        /// </summary>
        [JsonProperty("scaling_configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingConfigurationId { get; set; }

        /// <summary>
        /// 伸缩配置名称。
        /// </summary>
        [JsonProperty("scaling_configuration_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingConfigurationName { get; set; }

        /// <summary>
        /// 伸缩组中当前实例数。
        /// </summary>
        [JsonProperty("current_instance_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentInstanceNumber { get; set; }

        /// <summary>
        /// 伸缩组期望实例数。
        /// </summary>
        [JsonProperty("desire_instance_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? DesireInstanceNumber { get; set; }

        /// <summary>
        /// 伸缩组最小实例数。
        /// </summary>
        [JsonProperty("min_instance_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinInstanceNumber { get; set; }

        /// <summary>
        /// 伸缩组最大实例数
        /// </summary>
        [JsonProperty("max_instance_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxInstanceNumber { get; set; }

        /// <summary>
        /// 冷却时间，单位是秒。
        /// </summary>
        [JsonProperty("cool_down_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? CoolDownTime { get; set; }

        /// <summary>
        /// 经典型负载均衡监听器ID，多个负载均衡监听器ID以逗号分隔。
        /// </summary>
        [JsonProperty("lb_listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LbListenerId { get; set; }

        /// <summary>
        /// 增强型负载均衡器信息，该参数为预留字段。
        /// </summary>
        [JsonProperty("lbaas_listeners", NullValueHandling = NullValueHandling.Ignore)]
        public List<LbaasListenersResult> LbaasListeners { get; set; }

        /// <summary>
        /// 可用分区信息
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// 网络信息
        /// </summary>
        [JsonProperty("networks", NullValueHandling = NullValueHandling.Ignore)]
        public List<NetworksResult> Networks { get; set; }

        /// <summary>
        /// 安全组信息
        /// </summary>
        [JsonProperty("security_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecurityGroupsResult> SecurityGroups { get; set; }

        /// <summary>
        /// 创建伸缩组时间，遵循UTC时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 伸缩组所在的VPC ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 伸缩组详情。
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public string Detail { get; set; }

        /// <summary>
        /// 伸缩组伸缩标志。
        /// </summary>
        [JsonProperty("is_scaling", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsScaling { get; set; }

        /// <summary>
        /// 健康检查方式。
        /// </summary>
        [JsonProperty("health_periodic_audit_method", NullValueHandling = NullValueHandling.Ignore)]
        public HealthPeriodicAuditMethodEnum HealthPeriodicAuditMethod { get; set; }
        /// <summary>
        /// 健康检查的间隔时间。
        /// </summary>
        [JsonProperty("health_periodic_audit_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? HealthPeriodicAuditTime { get; set; }

        /// <summary>
        /// 健康状况检查宽限期。
        /// </summary>
        [JsonProperty("health_periodic_audit_grace_period", NullValueHandling = NullValueHandling.Ignore)]
        public int? HealthPeriodicAuditGracePeriod { get; set; }

        /// <summary>
        /// 移除策略。
        /// </summary>
        [JsonProperty("instance_terminate_policy", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceTerminatePolicyEnum InstanceTerminatePolicy { get; set; }
        /// <summary>
        /// 通知方式：EMAIL为发送邮件通知。
        /// </summary>
        [JsonProperty("notifications", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Notifications { get; set; }

        /// <summary>
        /// 删除云服务器是否删除云服务器绑定的弹性IP。
        /// </summary>
        [JsonProperty("delete_publicip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeletePublicip { get; set; }

        /// <summary>
        /// 删除云服务器是否删除云服务器绑定的数据盘
        /// </summary>
        [JsonProperty("delete_volume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteVolume { get; set; }

        /// <summary>
        /// 该参数为预留字段
        /// </summary>
        [JsonProperty("cloud_location_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudLocationId { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 伸缩组活动类型
        /// </summary>
        [JsonProperty("activity_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivityType { get; set; }

        /// <summary>
        /// 伸缩组扩缩容时目标AZ选择的优先级策略
        /// </summary>
        [JsonProperty("multi_az_priority_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string MultiAzPriorityPolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScalingGroups {\n");
            sb.Append("  scalingGroupName: ").Append(ScalingGroupName).Append("\n");
            sb.Append("  scalingGroupId: ").Append(ScalingGroupId).Append("\n");
            sb.Append("  scalingGroupStatus: ").Append(ScalingGroupStatus).Append("\n");
            sb.Append("  scalingConfigurationId: ").Append(ScalingConfigurationId).Append("\n");
            sb.Append("  scalingConfigurationName: ").Append(ScalingConfigurationName).Append("\n");
            sb.Append("  currentInstanceNumber: ").Append(CurrentInstanceNumber).Append("\n");
            sb.Append("  desireInstanceNumber: ").Append(DesireInstanceNumber).Append("\n");
            sb.Append("  minInstanceNumber: ").Append(MinInstanceNumber).Append("\n");
            sb.Append("  maxInstanceNumber: ").Append(MaxInstanceNumber).Append("\n");
            sb.Append("  coolDownTime: ").Append(CoolDownTime).Append("\n");
            sb.Append("  lbListenerId: ").Append(LbListenerId).Append("\n");
            sb.Append("  lbaasListeners: ").Append(LbaasListeners).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  networks: ").Append(Networks).Append("\n");
            sb.Append("  securityGroups: ").Append(SecurityGroups).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  detail: ").Append(Detail).Append("\n");
            sb.Append("  isScaling: ").Append(IsScaling).Append("\n");
            sb.Append("  healthPeriodicAuditMethod: ").Append(HealthPeriodicAuditMethod).Append("\n");
            sb.Append("  healthPeriodicAuditTime: ").Append(HealthPeriodicAuditTime).Append("\n");
            sb.Append("  healthPeriodicAuditGracePeriod: ").Append(HealthPeriodicAuditGracePeriod).Append("\n");
            sb.Append("  instanceTerminatePolicy: ").Append(InstanceTerminatePolicy).Append("\n");
            sb.Append("  notifications: ").Append(Notifications).Append("\n");
            sb.Append("  deletePublicip: ").Append(DeletePublicip).Append("\n");
            sb.Append("  deleteVolume: ").Append(DeleteVolume).Append("\n");
            sb.Append("  cloudLocationId: ").Append(CloudLocationId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  activityType: ").Append(ActivityType).Append("\n");
            sb.Append("  multiAzPriorityPolicy: ").Append(MultiAzPriorityPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScalingGroups);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScalingGroups input)
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
                    this.ScalingGroupId == input.ScalingGroupId ||
                    (this.ScalingGroupId != null &&
                    this.ScalingGroupId.Equals(input.ScalingGroupId))
                ) && 
                (
                    this.ScalingGroupStatus == input.ScalingGroupStatus ||
                    (this.ScalingGroupStatus != null &&
                    this.ScalingGroupStatus.Equals(input.ScalingGroupStatus))
                ) && 
                (
                    this.ScalingConfigurationId == input.ScalingConfigurationId ||
                    (this.ScalingConfigurationId != null &&
                    this.ScalingConfigurationId.Equals(input.ScalingConfigurationId))
                ) && 
                (
                    this.ScalingConfigurationName == input.ScalingConfigurationName ||
                    (this.ScalingConfigurationName != null &&
                    this.ScalingConfigurationName.Equals(input.ScalingConfigurationName))
                ) && 
                (
                    this.CurrentInstanceNumber == input.CurrentInstanceNumber ||
                    (this.CurrentInstanceNumber != null &&
                    this.CurrentInstanceNumber.Equals(input.CurrentInstanceNumber))
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
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.IsScaling == input.IsScaling ||
                    (this.IsScaling != null &&
                    this.IsScaling.Equals(input.IsScaling))
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
                    this.CloudLocationId == input.CloudLocationId ||
                    (this.CloudLocationId != null &&
                    this.CloudLocationId.Equals(input.CloudLocationId))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.ActivityType == input.ActivityType ||
                    (this.ActivityType != null &&
                    this.ActivityType.Equals(input.ActivityType))
                ) && 
                (
                    this.MultiAzPriorityPolicy == input.MultiAzPriorityPolicy ||
                    (this.MultiAzPriorityPolicy != null &&
                    this.MultiAzPriorityPolicy.Equals(input.MultiAzPriorityPolicy))
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
                if (this.ScalingGroupId != null)
                    hashCode = hashCode * 59 + this.ScalingGroupId.GetHashCode();
                if (this.ScalingGroupStatus != null)
                    hashCode = hashCode * 59 + this.ScalingGroupStatus.GetHashCode();
                if (this.ScalingConfigurationId != null)
                    hashCode = hashCode * 59 + this.ScalingConfigurationId.GetHashCode();
                if (this.ScalingConfigurationName != null)
                    hashCode = hashCode * 59 + this.ScalingConfigurationName.GetHashCode();
                if (this.CurrentInstanceNumber != null)
                    hashCode = hashCode * 59 + this.CurrentInstanceNumber.GetHashCode();
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
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.IsScaling != null)
                    hashCode = hashCode * 59 + this.IsScaling.GetHashCode();
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
                if (this.CloudLocationId != null)
                    hashCode = hashCode * 59 + this.CloudLocationId.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ActivityType != null)
                    hashCode = hashCode * 59 + this.ActivityType.GetHashCode();
                if (this.MultiAzPriorityPolicy != null)
                    hashCode = hashCode * 59 + this.MultiAzPriorityPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
