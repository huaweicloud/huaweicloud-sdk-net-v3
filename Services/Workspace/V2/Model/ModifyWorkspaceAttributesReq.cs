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
    /// 
    /// </summary>
    public class ModifyWorkspaceAttributesReq 
    {
        /// <summary>
        /// 操作类型，做如下修改操作需要指定该参数。 - applyDedicatedStandbyNetwork: 开通专线备用线路 - cancelDedicatedStandbyNetwork: 关闭专线备用线路
        /// </summary>
        /// <value>操作类型，做如下修改操作需要指定该参数。 - applyDedicatedStandbyNetwork: 开通专线备用线路 - cancelDedicatedStandbyNetwork: 关闭专线备用线路</value>
        [JsonConverter(typeof(EnumClassConverter<OperateTypeEnum>))]
        public class OperateTypeEnum
        {
            /// <summary>
            /// Enum APPLYDEDICATEDSTANDBYNETWORK for value: applyDedicatedStandbyNetwork
            /// </summary>
            public static readonly OperateTypeEnum APPLYDEDICATEDSTANDBYNETWORK = new OperateTypeEnum("applyDedicatedStandbyNetwork");

            /// <summary>
            /// Enum CANCELDEDICATEDSTANDBYNETWORK for value: cancelDedicatedStandbyNetwork
            /// </summary>
            public static readonly OperateTypeEnum CANCELDEDICATEDSTANDBYNETWORK = new OperateTypeEnum("cancelDedicatedStandbyNetwork");

            private static readonly Dictionary<string, OperateTypeEnum> StaticFields =
            new Dictionary<string, OperateTypeEnum>()
            {
                { "applyDedicatedStandbyNetwork", APPLYDEDICATEDSTANDBYNETWORK },
                { "cancelDedicatedStandbyNetwork", CANCELDEDICATEDSTANDBYNETWORK },
            };

            private string _value;

            public OperateTypeEnum()
            {

            }

            public OperateTypeEnum(string value)
            {
                _value = value;
            }

            public static OperateTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OperateTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperateTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperateTypeEnum a, OperateTypeEnum b)
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

            public static bool operator !=(OperateTypeEnum a, OperateTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 主认证方式。 - KERBEROS：KERBEROS。 - KERBEROS_THIRD_SSO：第三方登录认证。
        /// </summary>
        /// <value>主认证方式。 - KERBEROS：KERBEROS。 - KERBEROS_THIRD_SSO：第三方登录认证。</value>
        [JsonConverter(typeof(EnumClassConverter<AuthTypeEnum>))]
        public class AuthTypeEnum
        {
            /// <summary>
            /// Enum KERBEROS for value: KERBEROS
            /// </summary>
            public static readonly AuthTypeEnum KERBEROS = new AuthTypeEnum("KERBEROS");

            /// <summary>
            /// Enum KERBEROS_THIRD_SSO for value: KERBEROS_THIRD_SSO
            /// </summary>
            public static readonly AuthTypeEnum KERBEROS_THIRD_SSO = new AuthTypeEnum("KERBEROS_THIRD_SSO");

            private static readonly Dictionary<string, AuthTypeEnum> StaticFields =
            new Dictionary<string, AuthTypeEnum>()
            {
                { "KERBEROS", KERBEROS },
                { "KERBEROS_THIRD_SSO", KERBEROS_THIRD_SSO },
            };

            private string _value;

            public AuthTypeEnum()
            {

            }

            public AuthTypeEnum(string value)
            {
                _value = value;
            }

            public static AuthTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AuthTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AuthTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AuthTypeEnum a, AuthTypeEnum b)
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

            public static bool operator !=(AuthTypeEnum a, AuthTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 接入模式。 - INTERNET：互联网接入。 - DEDICATED：专线接入。 - BOTH：代表两种接入方式都支持。
        /// </summary>
        /// <value>接入模式。 - INTERNET：互联网接入。 - DEDICATED：专线接入。 - BOTH：代表两种接入方式都支持。</value>
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
        /// 操作类型，做如下修改操作需要指定该参数。 - applyDedicatedStandbyNetwork: 开通专线备用线路 - cancelDedicatedStandbyNetwork: 关闭专线备用线路
        /// </summary>
        [JsonProperty("operate_type", NullValueHandling = NullValueHandling.Ignore)]
        public OperateTypeEnum OperateType { get; set; }
        /// <summary>
        /// 主认证方式。 - KERBEROS：KERBEROS。 - KERBEROS_THIRD_SSO：第三方登录认证。
        /// </summary>
        [JsonProperty("auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public AuthTypeEnum AuthType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ad_info", NullValueHandling = NullValueHandling.Ignore)]
        public AdDomainInfo AdInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("third_gateway_info", NullValueHandling = NullValueHandling.Ignore)]
        public ThirdGatewayConfigInfo ThirdGatewayInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ad_domains", NullValueHandling = NullValueHandling.Ignore)]
        public AdDomain AdDomains { get; set; }

        /// <summary>
        /// 接入模式。 - INTERNET：互联网接入。 - DEDICATED：专线接入。 - BOTH：代表两种接入方式都支持。
        /// </summary>
        [JsonProperty("access_mode", NullValueHandling = NullValueHandling.Ignore)]
        public AccessModeEnum AccessMode { get; set; }
        /// <summary>
        /// 专线接入网段列表，多个网段信息用分号隔开，列表长度不超过5。
        /// </summary>
        [JsonProperty("dedicated_subnets", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedSubnets { get; set; }

        /// <summary>
        /// ADN上网冲突网段列表，多个网段信息用分号隔开，列表长度不超过50。
        /// </summary>
        [JsonProperty("adn_conflict_network", NullValueHandling = NullValueHandling.Ignore)]
        public string AdnConflictNetwork { get; set; }

        /// <summary>
        /// 子网的网络ID列表。
        /// </summary>
        [JsonProperty("subnet_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubnetIds { get; set; }

        /// <summary>
        /// VPC配置信息列表。
        /// </summary>
        [JsonProperty("vpc_config_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<VpcConfigInfo> VpcConfigInfos { get; set; }

        /// <summary>
        /// 互联网接入端口。
        /// </summary>
        [JsonProperty("internet_access_port", NullValueHandling = NullValueHandling.Ignore)]
        public string InternetAccessPort { get; set; }

        /// <summary>
        /// 企业ID。
        /// </summary>
        [JsonProperty("enterprise_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 桌面退订是否发送邮件通知。
        /// </summary>
        [JsonProperty("is_send_email", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSendEmail { get; set; }

        /// <summary>
        /// 开通专线访问VNC功能，如果传入的是default则自动创建，如果传入的自定义的dc_vnc_ip则直接使用，如果传入的是close表示关闭自定义VNC
        /// </summary>
        [JsonProperty("dc_vnc_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DcVncIp { get; set; }

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
        /// 
        /// </summary>
        [JsonProperty("apply_shared_vpc_dedicated_param", NullValueHandling = NullValueHandling.Ignore)]
        public ApplySharedVpcDedicatedParam ApplySharedVpcDedicatedParam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("apply_dedicated_standby_network_param", NullValueHandling = NullValueHandling.Ignore)]
        public ApplyDedicatedStandbyNetworkParam ApplyDedicatedStandbyNetworkParam { get; set; }

        /// <summary>
        /// 是否授权桌面自动安装agent插件。
        /// </summary>
        [JsonProperty("is_authorized_install_agent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAuthorizedInstallAgent { get; set; }

        /// <summary>
        /// 是否授权最终租户创建快照。
        /// </summary>
        [JsonProperty("enable_user_create_snapshot", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableUserCreateSnapshot { get; set; }

        /// <summary>
        /// 是否开启ipv6。
        /// </summary>
        [JsonProperty("is_support_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportIpv6 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyWorkspaceAttributesReq {\n");
            sb.Append("  operateType: ").Append(OperateType).Append("\n");
            sb.Append("  authType: ").Append(AuthType).Append("\n");
            sb.Append("  adInfo: ").Append(AdInfo).Append("\n");
            sb.Append("  thirdGatewayInfo: ").Append(ThirdGatewayInfo).Append("\n");
            sb.Append("  adDomains: ").Append(AdDomains).Append("\n");
            sb.Append("  accessMode: ").Append(AccessMode).Append("\n");
            sb.Append("  dedicatedSubnets: ").Append(DedicatedSubnets).Append("\n");
            sb.Append("  adnConflictNetwork: ").Append(AdnConflictNetwork).Append("\n");
            sb.Append("  subnetIds: ").Append(SubnetIds).Append("\n");
            sb.Append("  vpcConfigInfos: ").Append(VpcConfigInfos).Append("\n");
            sb.Append("  internetAccessPort: ").Append(InternetAccessPort).Append("\n");
            sb.Append("  enterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  isSendEmail: ").Append(IsSendEmail).Append("\n");
            sb.Append("  dcVncIp: ").Append(DcVncIp).Append("\n");
            sb.Append("  authorizedCollectLog: ").Append(AuthorizedCollectLog).Append("\n");
            sb.Append("  authorizedHdaUpgrade: ").Append(AuthorizedHdaUpgrade).Append("\n");
            sb.Append("  applySharedVpcDedicatedParam: ").Append(ApplySharedVpcDedicatedParam).Append("\n");
            sb.Append("  applyDedicatedStandbyNetworkParam: ").Append(ApplyDedicatedStandbyNetworkParam).Append("\n");
            sb.Append("  isAuthorizedInstallAgent: ").Append(IsAuthorizedInstallAgent).Append("\n");
            sb.Append("  enableUserCreateSnapshot: ").Append(EnableUserCreateSnapshot).Append("\n");
            sb.Append("  isSupportIpv6: ").Append(IsSupportIpv6).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyWorkspaceAttributesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyWorkspaceAttributesReq input)
        {
            if (input == null) return false;
            if (this.OperateType != input.OperateType) return false;
            if (this.AuthType != input.AuthType) return false;
            if (this.AdInfo != input.AdInfo || (this.AdInfo != null && !this.AdInfo.Equals(input.AdInfo))) return false;
            if (this.ThirdGatewayInfo != input.ThirdGatewayInfo || (this.ThirdGatewayInfo != null && !this.ThirdGatewayInfo.Equals(input.ThirdGatewayInfo))) return false;
            if (this.AdDomains != input.AdDomains || (this.AdDomains != null && !this.AdDomains.Equals(input.AdDomains))) return false;
            if (this.AccessMode != input.AccessMode) return false;
            if (this.DedicatedSubnets != input.DedicatedSubnets || (this.DedicatedSubnets != null && !this.DedicatedSubnets.Equals(input.DedicatedSubnets))) return false;
            if (this.AdnConflictNetwork != input.AdnConflictNetwork || (this.AdnConflictNetwork != null && !this.AdnConflictNetwork.Equals(input.AdnConflictNetwork))) return false;
            if (this.SubnetIds != input.SubnetIds || (this.SubnetIds != null && input.SubnetIds != null && !this.SubnetIds.SequenceEqual(input.SubnetIds))) return false;
            if (this.VpcConfigInfos != input.VpcConfigInfos || (this.VpcConfigInfos != null && input.VpcConfigInfos != null && !this.VpcConfigInfos.SequenceEqual(input.VpcConfigInfos))) return false;
            if (this.InternetAccessPort != input.InternetAccessPort || (this.InternetAccessPort != null && !this.InternetAccessPort.Equals(input.InternetAccessPort))) return false;
            if (this.EnterpriseId != input.EnterpriseId || (this.EnterpriseId != null && !this.EnterpriseId.Equals(input.EnterpriseId))) return false;
            if (this.IsSendEmail != input.IsSendEmail || (this.IsSendEmail != null && !this.IsSendEmail.Equals(input.IsSendEmail))) return false;
            if (this.DcVncIp != input.DcVncIp || (this.DcVncIp != null && !this.DcVncIp.Equals(input.DcVncIp))) return false;
            if (this.AuthorizedCollectLog != input.AuthorizedCollectLog || (this.AuthorizedCollectLog != null && !this.AuthorizedCollectLog.Equals(input.AuthorizedCollectLog))) return false;
            if (this.AuthorizedHdaUpgrade != input.AuthorizedHdaUpgrade || (this.AuthorizedHdaUpgrade != null && !this.AuthorizedHdaUpgrade.Equals(input.AuthorizedHdaUpgrade))) return false;
            if (this.ApplySharedVpcDedicatedParam != input.ApplySharedVpcDedicatedParam || (this.ApplySharedVpcDedicatedParam != null && !this.ApplySharedVpcDedicatedParam.Equals(input.ApplySharedVpcDedicatedParam))) return false;
            if (this.ApplyDedicatedStandbyNetworkParam != input.ApplyDedicatedStandbyNetworkParam || (this.ApplyDedicatedStandbyNetworkParam != null && !this.ApplyDedicatedStandbyNetworkParam.Equals(input.ApplyDedicatedStandbyNetworkParam))) return false;
            if (this.IsAuthorizedInstallAgent != input.IsAuthorizedInstallAgent || (this.IsAuthorizedInstallAgent != null && !this.IsAuthorizedInstallAgent.Equals(input.IsAuthorizedInstallAgent))) return false;
            if (this.EnableUserCreateSnapshot != input.EnableUserCreateSnapshot || (this.EnableUserCreateSnapshot != null && !this.EnableUserCreateSnapshot.Equals(input.EnableUserCreateSnapshot))) return false;
            if (this.IsSupportIpv6 != input.IsSupportIpv6 || (this.IsSupportIpv6 != null && !this.IsSupportIpv6.Equals(input.IsSupportIpv6))) return false;

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
                hashCode = hashCode * 59 + this.OperateType.GetHashCode();
                hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.AdInfo != null) hashCode = hashCode * 59 + this.AdInfo.GetHashCode();
                if (this.ThirdGatewayInfo != null) hashCode = hashCode * 59 + this.ThirdGatewayInfo.GetHashCode();
                if (this.AdDomains != null) hashCode = hashCode * 59 + this.AdDomains.GetHashCode();
                hashCode = hashCode * 59 + this.AccessMode.GetHashCode();
                if (this.DedicatedSubnets != null) hashCode = hashCode * 59 + this.DedicatedSubnets.GetHashCode();
                if (this.AdnConflictNetwork != null) hashCode = hashCode * 59 + this.AdnConflictNetwork.GetHashCode();
                if (this.SubnetIds != null) hashCode = hashCode * 59 + this.SubnetIds.GetHashCode();
                if (this.VpcConfigInfos != null) hashCode = hashCode * 59 + this.VpcConfigInfos.GetHashCode();
                if (this.InternetAccessPort != null) hashCode = hashCode * 59 + this.InternetAccessPort.GetHashCode();
                if (this.EnterpriseId != null) hashCode = hashCode * 59 + this.EnterpriseId.GetHashCode();
                if (this.IsSendEmail != null) hashCode = hashCode * 59 + this.IsSendEmail.GetHashCode();
                if (this.DcVncIp != null) hashCode = hashCode * 59 + this.DcVncIp.GetHashCode();
                if (this.AuthorizedCollectLog != null) hashCode = hashCode * 59 + this.AuthorizedCollectLog.GetHashCode();
                if (this.AuthorizedHdaUpgrade != null) hashCode = hashCode * 59 + this.AuthorizedHdaUpgrade.GetHashCode();
                if (this.ApplySharedVpcDedicatedParam != null) hashCode = hashCode * 59 + this.ApplySharedVpcDedicatedParam.GetHashCode();
                if (this.ApplyDedicatedStandbyNetworkParam != null) hashCode = hashCode * 59 + this.ApplyDedicatedStandbyNetworkParam.GetHashCode();
                if (this.IsAuthorizedInstallAgent != null) hashCode = hashCode * 59 + this.IsAuthorizedInstallAgent.GetHashCode();
                if (this.EnableUserCreateSnapshot != null) hashCode = hashCode * 59 + this.EnableUserCreateSnapshot.GetHashCode();
                if (this.IsSupportIpv6 != null) hashCode = hashCode * 59 + this.IsSupportIpv6.GetHashCode();
                return hashCode;
            }
        }
    }
}
