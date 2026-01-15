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
    /// 申请开通云办公服务请求。
    /// </summary>
    public class ApplyWorkspaceReq 
    {
        /// <summary>
        /// 接入方式。 - INTERNET：表示Internet接入。 - DEDICATED：表示专线接入。 - BOTH：表示两种接入方式都支持。
        /// </summary>
        /// <value>接入方式。 - INTERNET：表示Internet接入。 - DEDICATED：表示专线接入。 - BOTH：表示两种接入方式都支持。</value>
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

            public static bool operator !=(AccessModeEnum a, AccessModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ad_domains", NullValueHandling = NullValueHandling.Ignore)]
        public ApplyWorkspaceAdDomain AdDomains { get; set; }

        /// <summary>
        /// 企业ID。 企业ID是您在云桌面服务的唯一标识，终端用户登录时需要填写企业ID，若不自定义设置企业ID，系统将自动生成您的企业ID。格式为由半角数字、字母、_-组成，长度范围小于等于32个字符。
        /// </summary>
        [JsonProperty("enterprise_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// VPC ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 指定业务子网的网络ID，子网不能与172.16.0.0/12冲突。
        /// </summary>
        [JsonProperty("subnet_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<Subnet> SubnetIds { get; set; }

        /// <summary>
        /// 管理子网网段。 注：不能与172.16.0.0/12以及subnet_ids参数下子网的网段冲突。
        /// </summary>
        [JsonProperty("manage_subnet_cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string ManageSubnetCidr { get; set; }

        /// <summary>
        /// 接入方式。 - INTERNET：表示Internet接入。 - DEDICATED：表示专线接入。 - BOTH：表示两种接入方式都支持。
        /// </summary>
        [JsonProperty("access_mode", NullValueHandling = NullValueHandling.Ignore)]
        public AccessModeEnum AccessMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("apply_shared_vpc_dedicated_param", NullValueHandling = NullValueHandling.Ignore)]
        public ApplySharedVpcDedicatedParam ApplySharedVpcDedicatedParam { get; set; }

        /// <summary>
        /// 专线接入网段列表，多个网段信息用分号隔开，列表长度不超过5。
        /// </summary>
        [JsonProperty("dedicated_subnets", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedSubnets { get; set; }

        /// <summary>
        /// 桌面退订是否发送邮件通知。
        /// </summary>
        [JsonProperty("is_send_email", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSendEmail { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyWorkspaceReq {\n");
            sb.Append("  adDomains: ").Append(AdDomains).Append("\n");
            sb.Append("  enterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetIds: ").Append(SubnetIds).Append("\n");
            sb.Append("  manageSubnetCidr: ").Append(ManageSubnetCidr).Append("\n");
            sb.Append("  accessMode: ").Append(AccessMode).Append("\n");
            sb.Append("  applySharedVpcDedicatedParam: ").Append(ApplySharedVpcDedicatedParam).Append("\n");
            sb.Append("  dedicatedSubnets: ").Append(DedicatedSubnets).Append("\n");
            sb.Append("  isSendEmail: ").Append(IsSendEmail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplyWorkspaceReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplyWorkspaceReq input)
        {
            if (input == null) return false;
            if (this.AdDomains != input.AdDomains || (this.AdDomains != null && !this.AdDomains.Equals(input.AdDomains))) return false;
            if (this.EnterpriseId != input.EnterpriseId || (this.EnterpriseId != null && !this.EnterpriseId.Equals(input.EnterpriseId))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetIds != input.SubnetIds || (this.SubnetIds != null && input.SubnetIds != null && !this.SubnetIds.SequenceEqual(input.SubnetIds))) return false;
            if (this.ManageSubnetCidr != input.ManageSubnetCidr || (this.ManageSubnetCidr != null && !this.ManageSubnetCidr.Equals(input.ManageSubnetCidr))) return false;
            if (this.AccessMode != input.AccessMode) return false;
            if (this.ApplySharedVpcDedicatedParam != input.ApplySharedVpcDedicatedParam || (this.ApplySharedVpcDedicatedParam != null && !this.ApplySharedVpcDedicatedParam.Equals(input.ApplySharedVpcDedicatedParam))) return false;
            if (this.DedicatedSubnets != input.DedicatedSubnets || (this.DedicatedSubnets != null && !this.DedicatedSubnets.Equals(input.DedicatedSubnets))) return false;
            if (this.IsSendEmail != input.IsSendEmail || (this.IsSendEmail != null && !this.IsSendEmail.Equals(input.IsSendEmail))) return false;

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
                if (this.AdDomains != null) hashCode = hashCode * 59 + this.AdDomains.GetHashCode();
                if (this.EnterpriseId != null) hashCode = hashCode * 59 + this.EnterpriseId.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetIds != null) hashCode = hashCode * 59 + this.SubnetIds.GetHashCode();
                if (this.ManageSubnetCidr != null) hashCode = hashCode * 59 + this.ManageSubnetCidr.GetHashCode();
                hashCode = hashCode * 59 + this.AccessMode.GetHashCode();
                if (this.ApplySharedVpcDedicatedParam != null) hashCode = hashCode * 59 + this.ApplySharedVpcDedicatedParam.GetHashCode();
                if (this.DedicatedSubnets != null) hashCode = hashCode * 59 + this.DedicatedSubnets.GetHashCode();
                if (this.IsSendEmail != null) hashCode = hashCode * 59 + this.IsSendEmail.GetHashCode();
                return hashCode;
            }
        }
    }
}
