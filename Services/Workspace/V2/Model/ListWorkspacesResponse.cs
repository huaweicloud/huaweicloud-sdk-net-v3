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
    /// Response Object
    /// </summary>
    public class ListWorkspacesResponse : SdkResponse
    {
        /// <summary>
        /// 云办公服务的状态。 - PREPARING：准备开通。 - SUBSCRIBING：开通中。 - SUBSCRIBED：已开通。 - SUBSCRIPTION_FAILED：开通失败。 - DEREGISTERING：销户中。 - DEREGISTRATION_FAILED：销户失败。 - RECYCLING：清理资源中。 - RECYCLED：清理资源成功。 - RECYCLE_FAILED：清理资源失败。 - CLOSED：已销户未开通。
        /// </summary>
        /// <value>云办公服务的状态。 - PREPARING：准备开通。 - SUBSCRIBING：开通中。 - SUBSCRIBED：已开通。 - SUBSCRIPTION_FAILED：开通失败。 - DEREGISTERING：销户中。 - DEREGISTRATION_FAILED：销户失败。 - RECYCLING：清理资源中。 - RECYCLED：清理资源成功。 - RECYCLE_FAILED：清理资源失败。 - CLOSED：已销户未开通。</value>
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
        /// 唯一标识ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 开通服务是否是全局服务
        /// </summary>
        [JsonProperty("is_global", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsGlobal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ad_domains", NullValueHandling = NullValueHandling.Ignore)]
        public AdInfo AdDomains { get; set; }

        /// <summary>
        /// VPC ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// VPC名称。
        /// </summary>
        [JsonProperty("vpc_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcName { get; set; }

        /// <summary>
        /// 接入方式。 - INTERNET：表示互联网接入。 - DEDICATED：表示专线接入。 - BOTH：表示同时支持互联网接入和专线接入。
        /// </summary>
        [JsonProperty("access_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessMode { get; set; }

        /// <summary>
        /// ADN上网冲突网段列表，多个网段信息用分号隔开，列表长度不超过50。
        /// </summary>
        [JsonProperty("adn_conflict_network", NullValueHandling = NullValueHandling.Ignore)]
        public string AdnConflictNetwork { get; set; }

        /// <summary>
        /// 专线接入网段，只有access_mode为“DEDICATED”或“BOTH”时才会返回该参数。
        /// </summary>
        [JsonProperty("dedicated_subnets", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedSubnets { get; set; }

        /// <summary>
        /// 专线接入地址，只有access_mode为“DEDICATED”或“BOTH”时才会返回该参数。
        /// </summary>
        [JsonProperty("dedicated_access_address", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedAccessAddress { get; set; }

        /// <summary>
        /// 互联网接入地址，只有access_mode为“INTERNET”或“BOTH”时才会返回该参数。
        /// </summary>
        [JsonProperty("internet_access_address", NullValueHandling = NullValueHandling.Ignore)]
        public string InternetAccessAddress { get; set; }

        /// <summary>
        /// 互联网接入端口。
        /// </summary>
        [JsonProperty("internet_access_port", NullValueHandling = NullValueHandling.Ignore)]
        public string InternetAccessPort { get; set; }

        /// <summary>
        /// 云办公服务的状态。 - PREPARING：准备开通。 - SUBSCRIBING：开通中。 - SUBSCRIBED：已开通。 - SUBSCRIPTION_FAILED：开通失败。 - DEREGISTERING：销户中。 - DEREGISTRATION_FAILED：销户失败。 - RECYCLING：清理资源中。 - RECYCLED：清理资源成功。 - RECYCLE_FAILED：清理资源失败。 - CLOSED：已销户未开通。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 互联网和专线切换任务的状态。 - init： 初始化 - 开通服务后的初始状态。 - available： 可用 - 执行过任务且成功后恢复的正常状态。 - internetOpening： 开启中 - 开通互联网接入开启中。 - dedicatedOpening： 开启中 - 开通专线接入开启中。 - internetOpenFailed： 开启失败 - 开通互联网接入开启失败。 - dedicatedOpenFailed： 开启失败 - 开通专线接入开启失败。 - openSuccess： 开启成功 - 开通接入方式成功。 - internetClosing： 关闭中 - 关闭互联网接入关闭中。 - dedicatedClosing： 关闭中 - 关闭专线接入关闭中。 - internetCloseFailed： 关闭失败 - 关闭互联网接入方式失败。 - dedicatedCloseFailed： 关闭失败 - 关闭专线接入方式失败。 - closeSuccess： 关闭成功 - 关闭接入方式成功。 - internetAccessPortModifying： 互联网接入端口修改中。 - internetAccessPortModifyFailed： 端口修改失败。
        /// </summary>
        [JsonProperty("access_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessStatus { get; set; }

        /// <summary>
        /// 业务子网，可以指定返回的网络ID订购桌面。
        /// </summary>
        [JsonProperty("subnet_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubnetInfo> SubnetIds { get; set; }

        /// <summary>
        /// VPC配置信息列表。
        /// </summary>
        [JsonProperty("vpc_config_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<VpcConfigInfo> VpcConfigInfos { get; set; }

        /// <summary>
        /// 管理组件的子网网段。
        /// </summary>
        [JsonProperty("management_subnet_cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagementSubnetCidr { get; set; }

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
        /// 是否可以取消服务。
        /// </summary>
        [JsonProperty("closable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Closable { get; set; }

        /// <summary>
        /// 配置状态。 - \&quot;0\&quot;： 开通服务成功，且对接AD成功。 - \&quot;1\&quot;： 开通服务成功，但AD配置失败。 - \&quot;2\&quot;： 开通服务成功，但AD配置失败后存在其他错误。 - \&quot;3\&quot;： 开通服务成功，AD未开启对接。
        /// </summary>
        [JsonProperty("config_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigStatus { get; set; }

        /// <summary>
        /// 开通服务或注销服务的进度，格式为百分比，如：100%。
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public string Progress { get; set; }

        /// <summary>
        /// 开通服务或取消服务的任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

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
        /// 企业ID。
        /// </summary>
        [JsonProperty("enterprise_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 桌面退订是否发送邮件通知。
        /// </summary>
        [JsonProperty("is_send_email", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSendEmail { get; set; }

        /// <summary>
        /// 是否授权收集日志。
        /// </summary>
        [JsonProperty("authorized_collect_log", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AuthorizedCollectLog { get; set; }

        /// <summary>
        /// 是否授权hda升级。
        /// </summary>
        [JsonProperty("authorized_hda_upgrade", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AuthorizedHdaUpgrade { get; set; }

        /// <summary>
        /// 站点配置。
        /// </summary>
        [JsonProperty("site_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<SiteConfigsResponse> SiteConfigs { get; set; }

        /// <summary>
        /// 自定义的专线VNC地址。
        /// </summary>
        [JsonProperty("dc_vnc_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DcVncIp { get; set; }

        /// <summary>
        /// 是否授权桌面自动安装agent插件。
        /// </summary>
        [JsonProperty("is_authorized_install_agent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAuthorizedInstallAgent { get; set; }

        /// <summary>
        /// 是否支持ipv6。
        /// </summary>
        [JsonProperty("is_support_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportIpv6 { get; set; }

        /// <summary>
        /// 是否授权最终租户创建快照。
        /// </summary>
        [JsonProperty("enable_user_create_snapshot", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableUserCreateSnapshot { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWorkspacesResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  isGlobal: ").Append(IsGlobal).Append("\n");
            sb.Append("  adDomains: ").Append(AdDomains).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  vpcName: ").Append(VpcName).Append("\n");
            sb.Append("  accessMode: ").Append(AccessMode).Append("\n");
            sb.Append("  adnConflictNetwork: ").Append(AdnConflictNetwork).Append("\n");
            sb.Append("  dedicatedSubnets: ").Append(DedicatedSubnets).Append("\n");
            sb.Append("  dedicatedAccessAddress: ").Append(DedicatedAccessAddress).Append("\n");
            sb.Append("  internetAccessAddress: ").Append(InternetAccessAddress).Append("\n");
            sb.Append("  internetAccessPort: ").Append(InternetAccessPort).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  accessStatus: ").Append(AccessStatus).Append("\n");
            sb.Append("  subnetIds: ").Append(SubnetIds).Append("\n");
            sb.Append("  vpcConfigInfos: ").Append(VpcConfigInfos).Append("\n");
            sb.Append("  managementSubnetCidr: ").Append(ManagementSubnetCidr).Append("\n");
            sb.Append("  infrastructureSecurityGroup: ").Append(InfrastructureSecurityGroup).Append("\n");
            sb.Append("  desktopSecurityGroup: ").Append(DesktopSecurityGroup).Append("\n");
            sb.Append("  closable: ").Append(Closable).Append("\n");
            sb.Append("  configStatus: ").Append(ConfigStatus).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  failCode: ").Append(FailCode).Append("\n");
            sb.Append("  failReason: ").Append(FailReason).Append("\n");
            sb.Append("  enterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  isSendEmail: ").Append(IsSendEmail).Append("\n");
            sb.Append("  authorizedCollectLog: ").Append(AuthorizedCollectLog).Append("\n");
            sb.Append("  authorizedHdaUpgrade: ").Append(AuthorizedHdaUpgrade).Append("\n");
            sb.Append("  siteConfigs: ").Append(SiteConfigs).Append("\n");
            sb.Append("  dcVncIp: ").Append(DcVncIp).Append("\n");
            sb.Append("  isAuthorizedInstallAgent: ").Append(IsAuthorizedInstallAgent).Append("\n");
            sb.Append("  isSupportIpv6: ").Append(IsSupportIpv6).Append("\n");
            sb.Append("  enableUserCreateSnapshot: ").Append(EnableUserCreateSnapshot).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWorkspacesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWorkspacesResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IsGlobal != input.IsGlobal || (this.IsGlobal != null && !this.IsGlobal.Equals(input.IsGlobal))) return false;
            if (this.AdDomains != input.AdDomains || (this.AdDomains != null && !this.AdDomains.Equals(input.AdDomains))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.VpcName != input.VpcName || (this.VpcName != null && !this.VpcName.Equals(input.VpcName))) return false;
            if (this.AccessMode != input.AccessMode || (this.AccessMode != null && !this.AccessMode.Equals(input.AccessMode))) return false;
            if (this.AdnConflictNetwork != input.AdnConflictNetwork || (this.AdnConflictNetwork != null && !this.AdnConflictNetwork.Equals(input.AdnConflictNetwork))) return false;
            if (this.DedicatedSubnets != input.DedicatedSubnets || (this.DedicatedSubnets != null && !this.DedicatedSubnets.Equals(input.DedicatedSubnets))) return false;
            if (this.DedicatedAccessAddress != input.DedicatedAccessAddress || (this.DedicatedAccessAddress != null && !this.DedicatedAccessAddress.Equals(input.DedicatedAccessAddress))) return false;
            if (this.InternetAccessAddress != input.InternetAccessAddress || (this.InternetAccessAddress != null && !this.InternetAccessAddress.Equals(input.InternetAccessAddress))) return false;
            if (this.InternetAccessPort != input.InternetAccessPort || (this.InternetAccessPort != null && !this.InternetAccessPort.Equals(input.InternetAccessPort))) return false;
            if (this.Status != input.Status) return false;
            if (this.AccessStatus != input.AccessStatus || (this.AccessStatus != null && !this.AccessStatus.Equals(input.AccessStatus))) return false;
            if (this.SubnetIds != input.SubnetIds || (this.SubnetIds != null && input.SubnetIds != null && !this.SubnetIds.SequenceEqual(input.SubnetIds))) return false;
            if (this.VpcConfigInfos != input.VpcConfigInfos || (this.VpcConfigInfos != null && input.VpcConfigInfos != null && !this.VpcConfigInfos.SequenceEqual(input.VpcConfigInfos))) return false;
            if (this.ManagementSubnetCidr != input.ManagementSubnetCidr || (this.ManagementSubnetCidr != null && !this.ManagementSubnetCidr.Equals(input.ManagementSubnetCidr))) return false;
            if (this.InfrastructureSecurityGroup != input.InfrastructureSecurityGroup || (this.InfrastructureSecurityGroup != null && !this.InfrastructureSecurityGroup.Equals(input.InfrastructureSecurityGroup))) return false;
            if (this.DesktopSecurityGroup != input.DesktopSecurityGroup || (this.DesktopSecurityGroup != null && !this.DesktopSecurityGroup.Equals(input.DesktopSecurityGroup))) return false;
            if (this.Closable != input.Closable || (this.Closable != null && !this.Closable.Equals(input.Closable))) return false;
            if (this.ConfigStatus != input.ConfigStatus || (this.ConfigStatus != null && !this.ConfigStatus.Equals(input.ConfigStatus))) return false;
            if (this.Progress != input.Progress || (this.Progress != null && !this.Progress.Equals(input.Progress))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.FailCode != input.FailCode || (this.FailCode != null && !this.FailCode.Equals(input.FailCode))) return false;
            if (this.FailReason != input.FailReason || (this.FailReason != null && !this.FailReason.Equals(input.FailReason))) return false;
            if (this.EnterpriseId != input.EnterpriseId || (this.EnterpriseId != null && !this.EnterpriseId.Equals(input.EnterpriseId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.IsSendEmail != input.IsSendEmail || (this.IsSendEmail != null && !this.IsSendEmail.Equals(input.IsSendEmail))) return false;
            if (this.AuthorizedCollectLog != input.AuthorizedCollectLog || (this.AuthorizedCollectLog != null && !this.AuthorizedCollectLog.Equals(input.AuthorizedCollectLog))) return false;
            if (this.AuthorizedHdaUpgrade != input.AuthorizedHdaUpgrade || (this.AuthorizedHdaUpgrade != null && !this.AuthorizedHdaUpgrade.Equals(input.AuthorizedHdaUpgrade))) return false;
            if (this.SiteConfigs != input.SiteConfigs || (this.SiteConfigs != null && input.SiteConfigs != null && !this.SiteConfigs.SequenceEqual(input.SiteConfigs))) return false;
            if (this.DcVncIp != input.DcVncIp || (this.DcVncIp != null && !this.DcVncIp.Equals(input.DcVncIp))) return false;
            if (this.IsAuthorizedInstallAgent != input.IsAuthorizedInstallAgent || (this.IsAuthorizedInstallAgent != null && !this.IsAuthorizedInstallAgent.Equals(input.IsAuthorizedInstallAgent))) return false;
            if (this.IsSupportIpv6 != input.IsSupportIpv6 || (this.IsSupportIpv6 != null && !this.IsSupportIpv6.Equals(input.IsSupportIpv6))) return false;
            if (this.EnableUserCreateSnapshot != input.EnableUserCreateSnapshot || (this.EnableUserCreateSnapshot != null && !this.EnableUserCreateSnapshot.Equals(input.EnableUserCreateSnapshot))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsGlobal != null) hashCode = hashCode * 59 + this.IsGlobal.GetHashCode();
                if (this.AdDomains != null) hashCode = hashCode * 59 + this.AdDomains.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.VpcName != null) hashCode = hashCode * 59 + this.VpcName.GetHashCode();
                if (this.AccessMode != null) hashCode = hashCode * 59 + this.AccessMode.GetHashCode();
                if (this.AdnConflictNetwork != null) hashCode = hashCode * 59 + this.AdnConflictNetwork.GetHashCode();
                if (this.DedicatedSubnets != null) hashCode = hashCode * 59 + this.DedicatedSubnets.GetHashCode();
                if (this.DedicatedAccessAddress != null) hashCode = hashCode * 59 + this.DedicatedAccessAddress.GetHashCode();
                if (this.InternetAccessAddress != null) hashCode = hashCode * 59 + this.InternetAccessAddress.GetHashCode();
                if (this.InternetAccessPort != null) hashCode = hashCode * 59 + this.InternetAccessPort.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AccessStatus != null) hashCode = hashCode * 59 + this.AccessStatus.GetHashCode();
                if (this.SubnetIds != null) hashCode = hashCode * 59 + this.SubnetIds.GetHashCode();
                if (this.VpcConfigInfos != null) hashCode = hashCode * 59 + this.VpcConfigInfos.GetHashCode();
                if (this.ManagementSubnetCidr != null) hashCode = hashCode * 59 + this.ManagementSubnetCidr.GetHashCode();
                if (this.InfrastructureSecurityGroup != null) hashCode = hashCode * 59 + this.InfrastructureSecurityGroup.GetHashCode();
                if (this.DesktopSecurityGroup != null) hashCode = hashCode * 59 + this.DesktopSecurityGroup.GetHashCode();
                if (this.Closable != null) hashCode = hashCode * 59 + this.Closable.GetHashCode();
                if (this.ConfigStatus != null) hashCode = hashCode * 59 + this.ConfigStatus.GetHashCode();
                if (this.Progress != null) hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.FailCode != null) hashCode = hashCode * 59 + this.FailCode.GetHashCode();
                if (this.FailReason != null) hashCode = hashCode * 59 + this.FailReason.GetHashCode();
                if (this.EnterpriseId != null) hashCode = hashCode * 59 + this.EnterpriseId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.IsSendEmail != null) hashCode = hashCode * 59 + this.IsSendEmail.GetHashCode();
                if (this.AuthorizedCollectLog != null) hashCode = hashCode * 59 + this.AuthorizedCollectLog.GetHashCode();
                if (this.AuthorizedHdaUpgrade != null) hashCode = hashCode * 59 + this.AuthorizedHdaUpgrade.GetHashCode();
                if (this.SiteConfigs != null) hashCode = hashCode * 59 + this.SiteConfigs.GetHashCode();
                if (this.DcVncIp != null) hashCode = hashCode * 59 + this.DcVncIp.GetHashCode();
                if (this.IsAuthorizedInstallAgent != null) hashCode = hashCode * 59 + this.IsAuthorizedInstallAgent.GetHashCode();
                if (this.IsSupportIpv6 != null) hashCode = hashCode * 59 + this.IsSupportIpv6.GetHashCode();
                if (this.EnableUserCreateSnapshot != null) hashCode = hashCode * 59 + this.EnableUserCreateSnapshot.GetHashCode();
                return hashCode;
            }
        }
    }
}
