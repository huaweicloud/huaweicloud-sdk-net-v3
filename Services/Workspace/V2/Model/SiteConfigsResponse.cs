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
    /// 站点配置。
    /// </summary>
    public class SiteConfigsResponse 
    {
        /// <summary>
        /// 配置状态。 - CENTER： 中心初始化 - IES： 边缘初始化
        /// </summary>
        /// <value>配置状态。 - CENTER： 中心初始化 - IES： 边缘初始化</value>
        [JsonConverter(typeof(EnumClassConverter<SiteTypeEnum>))]
        public class SiteTypeEnum
        {
            /// <summary>
            /// Enum CENTER for value: CENTER
            /// </summary>
            public static readonly SiteTypeEnum CENTER = new SiteTypeEnum("CENTER");

            /// <summary>
            /// Enum IES for value: IES
            /// </summary>
            public static readonly SiteTypeEnum IES = new SiteTypeEnum("IES");

            private static readonly Dictionary<string, SiteTypeEnum> StaticFields =
            new Dictionary<string, SiteTypeEnum>()
            {
                { "CENTER", CENTER },
                { "IES", IES },
            };

            private string _value;

            public SiteTypeEnum()
            {

            }

            public SiteTypeEnum(string value)
            {
                _value = value;
            }

            public static SiteTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SiteTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SiteTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SiteTypeEnum a, SiteTypeEnum b)
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

            public static bool operator !=(SiteTypeEnum a, SiteTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 云办公服务的状态。 - PREPARING：准备初始化服务 - SUBSCRIBING：初始化服务中 - SUBSCRIBED：已初始化服务 - SUBSCRIPTION_FAILED：初始化服务失败 - DEREGISTERING：清理资源中 - DEREGISTRATION_FAILED：清理资源失败 - RECYCLING：清理资源中。 - RECYCLED：清理资源成功。 - RECYCLE_FAILED：清理资源失败。 - CLOSED：已销户未初始化服务
        /// </summary>
        /// <value>云办公服务的状态。 - PREPARING：准备初始化服务 - SUBSCRIBING：初始化服务中 - SUBSCRIBED：已初始化服务 - SUBSCRIPTION_FAILED：初始化服务失败 - DEREGISTERING：清理资源中 - DEREGISTRATION_FAILED：清理资源失败 - RECYCLING：清理资源中。 - RECYCLED：清理资源成功。 - RECYCLE_FAILED：清理资源失败。 - CLOSED：已销户未初始化服务</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum PREPARING for value: PREPARING
            /// </summary>
            public static readonly StatusEnum PREPARING = new StatusEnum("PREPARING");

            /// <summary>
            /// Enum SUBSCRIBING for value: SUBSCRIBING
            /// </summary>
            public static readonly StatusEnum SUBSCRIBING = new StatusEnum("SUBSCRIBING");

            /// <summary>
            /// Enum SUBSCRIBED for value: SUBSCRIBED
            /// </summary>
            public static readonly StatusEnum SUBSCRIBED = new StatusEnum("SUBSCRIBED");

            /// <summary>
            /// Enum SUBSCRIPTION_FAILED for value: SUBSCRIPTION_FAILED
            /// </summary>
            public static readonly StatusEnum SUBSCRIPTION_FAILED = new StatusEnum("SUBSCRIPTION_FAILED");

            /// <summary>
            /// Enum DEREGISTERING for value: DEREGISTERING
            /// </summary>
            public static readonly StatusEnum DEREGISTERING = new StatusEnum("DEREGISTERING");

            /// <summary>
            /// Enum DEREGISTRATION_FAILED for value: DEREGISTRATION_FAILED
            /// </summary>
            public static readonly StatusEnum DEREGISTRATION_FAILED = new StatusEnum("DEREGISTRATION_FAILED");

            /// <summary>
            /// Enum RECYCLING for value: RECYCLING
            /// </summary>
            public static readonly StatusEnum RECYCLING = new StatusEnum("RECYCLING");

            /// <summary>
            /// Enum RECYCLED for value: RECYCLED
            /// </summary>
            public static readonly StatusEnum RECYCLED = new StatusEnum("RECYCLED");

            /// <summary>
            /// Enum RECYCLE_FAILED for value: RECYCLE_FAILED
            /// </summary>
            public static readonly StatusEnum RECYCLE_FAILED = new StatusEnum("RECYCLE_FAILED");

            /// <summary>
            /// Enum CLOSED for value: CLOSED
            /// </summary>
            public static readonly StatusEnum CLOSED = new StatusEnum("CLOSED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "PREPARING", PREPARING },
                { "SUBSCRIBING", SUBSCRIBING },
                { "SUBSCRIBED", SUBSCRIBED },
                { "SUBSCRIPTION_FAILED", SUBSCRIPTION_FAILED },
                { "DEREGISTERING", DEREGISTERING },
                { "DEREGISTRATION_FAILED", DEREGISTRATION_FAILED },
                { "RECYCLING", RECYCLING },
                { "RECYCLED", RECYCLED },
                { "RECYCLE_FAILED", RECYCLE_FAILED },
                { "CLOSED", CLOSED },
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 站点id。
        /// </summary>
        [JsonProperty("site_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteId { get; set; }

        /// <summary>
        /// 配置状态。 - CENTER： 中心初始化 - IES： 边缘初始化
        /// </summary>
        [JsonProperty("site_type", NullValueHandling = NullValueHandling.Ignore)]
        public SiteTypeEnum SiteType { get; set; }
        /// <summary>
        /// 站点名称。
        /// </summary>
        [JsonProperty("site_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteName { get; set; }

        /// <summary>
        /// 云办公服务的状态。 - PREPARING：准备初始化服务 - SUBSCRIBING：初始化服务中 - SUBSCRIBED：已初始化服务 - SUBSCRIPTION_FAILED：初始化服务失败 - DEREGISTERING：清理资源中 - DEREGISTRATION_FAILED：清理资源失败 - RECYCLING：清理资源中。 - RECYCLED：清理资源成功。 - RECYCLE_FAILED：清理资源失败。 - CLOSED：已销户未初始化服务
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 互联网和专线切换任务的状态。 - init： 初始化 - 开通服务后的初始状态 - available： 可用 - 执行过任务且成功后恢复的正常状态 - internetOpening： 开启中 - 开通互联网接入开启中 - dedicatedOpening： 开启中 - 开通专线接入开启中 - internetOpenFailed： 开启失败 - 开通互联网接入开启失败 - dedicatedOpenFailed： 开启失败 - 开通专线接入开启失败 - openSuccess： 开启成功 - 开通互联网接入成功 - internetClosing： 关闭中 - 关闭互联网接入关闭中 - dedicatedClosing： 关闭中 - 关闭专线接入关闭中 - internetCloseFailed： 关闭失败 - 关闭互联网接入方式失败 - dedicatedCloseFailed： 关闭失败 - 关闭专线接入方式失败 - closeSuccess： 关闭成功 - 关闭接入方式成功 - internetAccessPortModifying： 互联网接入端口修改中 - internetAccessPortModifyFailed: 端口修改失败
        /// </summary>
        [JsonProperty("access_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessStatus { get; set; }

        /// <summary>
        /// 配置状态。 - \&quot;0\&quot;： 开通服务成功，且对接AD成功 - \&quot;1\&quot;： 开通服务成功，但AD配置失败 - \&quot;2\&quot;： 开通服务成功，但AD配置失败后存在其他错误 - \&quot;3\&quot;： 开通服务成功，AD未开启对接
        /// </summary>
        [JsonProperty("config_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("infrastructure_security_group", NullValueHandling = NullValueHandling.Ignore)]
        public SecurityGroup InfrastructureSecurityGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("desktop_security_group", NullValueHandling = NullValueHandling.Ignore)]
        public SecurityGroup DesktopSecurityGroup { get; set; }

        /// <summary>
        /// 开通服务资源使用的可用分区。
        /// </summary>
        [JsonProperty("availability_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZones { get; set; }

        /// <summary>
        /// 开通服务或取消服务的任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 初始化服务或清理资源的进度，格式为100%。
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public string Progress { get; set; }

        /// <summary>
        /// 失败错误码。
        /// </summary>
        [JsonProperty("fail_code", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailCode { get; set; }

        /// <summary>
        /// 失败原因。
        /// </summary>
        [JsonProperty("fail_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("network_config", NullValueHandling = NullValueHandling.Ignore)]
        public NetworkConfig NetworkConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("access_config", NullValueHandling = NullValueHandling.Ignore)]
        public AccessConfig AccessConfig { get; set; }

        /// <summary>
        /// 是否可以取消服务。
        /// </summary>
        [JsonProperty("closable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Closable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SiteConfigsResponse {\n");
            sb.Append("  siteId: ").Append(SiteId).Append("\n");
            sb.Append("  siteType: ").Append(SiteType).Append("\n");
            sb.Append("  siteName: ").Append(SiteName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  accessStatus: ").Append(AccessStatus).Append("\n");
            sb.Append("  configStatus: ").Append(ConfigStatus).Append("\n");
            sb.Append("  infrastructureSecurityGroup: ").Append(InfrastructureSecurityGroup).Append("\n");
            sb.Append("  desktopSecurityGroup: ").Append(DesktopSecurityGroup).Append("\n");
            sb.Append("  availabilityZones: ").Append(AvailabilityZones).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  failCode: ").Append(FailCode).Append("\n");
            sb.Append("  failReason: ").Append(FailReason).Append("\n");
            sb.Append("  networkConfig: ").Append(NetworkConfig).Append("\n");
            sb.Append("  accessConfig: ").Append(AccessConfig).Append("\n");
            sb.Append("  closable: ").Append(Closable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SiteConfigsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SiteConfigsResponse input)
        {
            if (input == null) return false;
            if (this.SiteId != input.SiteId || (this.SiteId != null && !this.SiteId.Equals(input.SiteId))) return false;
            if (this.SiteType != input.SiteType) return false;
            if (this.SiteName != input.SiteName || (this.SiteName != null && !this.SiteName.Equals(input.SiteName))) return false;
            if (this.Status != input.Status) return false;
            if (this.AccessStatus != input.AccessStatus || (this.AccessStatus != null && !this.AccessStatus.Equals(input.AccessStatus))) return false;
            if (this.ConfigStatus != input.ConfigStatus || (this.ConfigStatus != null && !this.ConfigStatus.Equals(input.ConfigStatus))) return false;
            if (this.InfrastructureSecurityGroup != input.InfrastructureSecurityGroup || (this.InfrastructureSecurityGroup != null && !this.InfrastructureSecurityGroup.Equals(input.InfrastructureSecurityGroup))) return false;
            if (this.DesktopSecurityGroup != input.DesktopSecurityGroup || (this.DesktopSecurityGroup != null && !this.DesktopSecurityGroup.Equals(input.DesktopSecurityGroup))) return false;
            if (this.AvailabilityZones != input.AvailabilityZones || (this.AvailabilityZones != null && input.AvailabilityZones != null && !this.AvailabilityZones.SequenceEqual(input.AvailabilityZones))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Progress != input.Progress || (this.Progress != null && !this.Progress.Equals(input.Progress))) return false;
            if (this.FailCode != input.FailCode || (this.FailCode != null && !this.FailCode.Equals(input.FailCode))) return false;
            if (this.FailReason != input.FailReason || (this.FailReason != null && !this.FailReason.Equals(input.FailReason))) return false;
            if (this.NetworkConfig != input.NetworkConfig || (this.NetworkConfig != null && !this.NetworkConfig.Equals(input.NetworkConfig))) return false;
            if (this.AccessConfig != input.AccessConfig || (this.AccessConfig != null && !this.AccessConfig.Equals(input.AccessConfig))) return false;
            if (this.Closable != input.Closable || (this.Closable != null && !this.Closable.Equals(input.Closable))) return false;

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
                if (this.SiteId != null) hashCode = hashCode * 59 + this.SiteId.GetHashCode();
                hashCode = hashCode * 59 + this.SiteType.GetHashCode();
                if (this.SiteName != null) hashCode = hashCode * 59 + this.SiteName.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AccessStatus != null) hashCode = hashCode * 59 + this.AccessStatus.GetHashCode();
                if (this.ConfigStatus != null) hashCode = hashCode * 59 + this.ConfigStatus.GetHashCode();
                if (this.InfrastructureSecurityGroup != null) hashCode = hashCode * 59 + this.InfrastructureSecurityGroup.GetHashCode();
                if (this.DesktopSecurityGroup != null) hashCode = hashCode * 59 + this.DesktopSecurityGroup.GetHashCode();
                if (this.AvailabilityZones != null) hashCode = hashCode * 59 + this.AvailabilityZones.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.Progress != null) hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.FailCode != null) hashCode = hashCode * 59 + this.FailCode.GetHashCode();
                if (this.FailReason != null) hashCode = hashCode * 59 + this.FailReason.GetHashCode();
                if (this.NetworkConfig != null) hashCode = hashCode * 59 + this.NetworkConfig.GetHashCode();
                if (this.AccessConfig != null) hashCode = hashCode * 59 + this.AccessConfig.GetHashCode();
                if (this.Closable != null) hashCode = hashCode * 59 + this.Closable.GetHashCode();
                return hashCode;
            }
        }
    }
}
