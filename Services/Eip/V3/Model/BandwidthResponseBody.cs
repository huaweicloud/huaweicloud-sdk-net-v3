using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// 带宽对象
    /// </summary>
    public class BandwidthResponseBody 
    {
        /// <summary>
        /// - 功能说明：带宽类型，标识是否是共享带宽 - 取值范围：WHOLE，PER。  WHOLE表示共享带宽；PER表示独享带宽
        /// </summary>
        /// <value>- 功能说明：带宽类型，标识是否是共享带宽 - 取值范围：WHOLE，PER。  WHOLE表示共享带宽；PER表示独享带宽</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum WHOLE for value: WHOLE
            /// </summary>
            public static readonly TypeEnum WHOLE = new TypeEnum("WHOLE");

            /// <summary>
            /// Enum PER for value: PER
            /// </summary>
            public static readonly TypeEnum PER = new TypeEnum("PER");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "WHOLE", WHOLE },
                { "PER", PER },
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// - 功能说明：带宽状态 - 取值范围：normal，freezed
        /// </summary>
        [JsonProperty("admin_state", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminState { get; set; }

        /// <summary>
        /// - 功能说明：入网大小，单位Mbit/s
        /// </summary>
        [JsonProperty("ingress_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? IngressSize { get; set; }

        /// <summary>
        /// - 功能说明：规则数值，最低阈值可调节
        /// </summary>
        [JsonProperty("rule_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? RuleQuota { get; set; }

        /// <summary>
        /// - 功能说明：增强型95带宽保底率，最低保底率为20
        /// </summary>
        [JsonProperty("ratio_95peak_plus", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ratio95peakPlus { get; set; }

        /// <summary>
        /// - 功能说明：带宽分组使能，表明开启带宽分组限速功能。
        /// </summary>
        [JsonProperty("enable_bandwidth_rules", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableBandwidthRules { get; set; }

        /// <summary>
        /// - 功能说明：带宽规则对象（该字段仅在上海1局点返回）
        /// </summary>
        [JsonProperty("bandwidth_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<BandWidthRules> BandwidthRules { get; set; }

        /// <summary>
        /// - 功能说明：带宽AZ属性，表征中心和边缘。中心带宽默认为center
        /// </summary>
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }

        /// <summary>
        /// - 功能说明：带宽类型，共享带宽默认为share。 - 取值范围：share，bgp，telcom，sbgp等。  share：共享带宽；  bgp：动态bgp；  telcom ：联通；  sbgp：静态bgp。
        /// </summary>
        [JsonProperty("bandwidth_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BandwidthType { get; set; }

        /// <summary>
        /// - 功能说明：账单信息，
        /// </summary>
        [JsonProperty("billinginfo", NullValueHandling = NullValueHandling.Ignore)]
        public string Billinginfo { get; set; }

        /// <summary>
        /// - 功能说明：带宽唯一标识
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// - 功能说明：带宽名称 - 取值范围：1-64个字符，支持数字、字母、中文、_(下划线)、-（中划线）、.（点）
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// - 功能说明：带宽对应的弹性公网IP信息 - 约束：WHOLE类型的带宽支持多个弹性公网IP，PER类型的带宽只能对应一个弹性公网IP
        /// </summary>
        [JsonProperty("publicip_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<PublicipInfoResponseBody> PublicipInfo { get; set; }

        /// <summary>
        /// - 功能说明：带宽类型，标识是否是共享带宽 - 取值范围：WHOLE，PER。  WHOLE表示共享带宽；PER表示独享带宽
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// - 功能说明：带宽大小 - 取值范围：默认5Mbit/s~2000Mbit/s（具体范围以各区域配置为准，请参见控制台对应页面显示）。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// - 功能说明：用户所属项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// - 功能说明：\&quot;公网EIP标签\&quot;
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// - 功能说明：资源创建时间，采用UTC时间，格式：YYYY-MM-DDTHH:MM:SS
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// - 功能说明：资源更新时间，采用UTC时间，格式：YYYY-MM-DDTHH:MM:SS
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BandwidthResponseBody {\n");
            sb.Append("  adminState: ").Append(AdminState).Append("\n");
            sb.Append("  ingressSize: ").Append(IngressSize).Append("\n");
            sb.Append("  ruleQuota: ").Append(RuleQuota).Append("\n");
            sb.Append("  ratio95peakPlus: ").Append(Ratio95peakPlus).Append("\n");
            sb.Append("  enableBandwidthRules: ").Append(EnableBandwidthRules).Append("\n");
            sb.Append("  bandwidthRules: ").Append(BandwidthRules).Append("\n");
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("  bandwidthType: ").Append(BandwidthType).Append("\n");
            sb.Append("  billinginfo: ").Append(Billinginfo).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  publicipInfo: ").Append(PublicipInfo).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BandwidthResponseBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BandwidthResponseBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdminState == input.AdminState ||
                    (this.AdminState != null &&
                    this.AdminState.Equals(input.AdminState))
                ) && 
                (
                    this.IngressSize == input.IngressSize ||
                    (this.IngressSize != null &&
                    this.IngressSize.Equals(input.IngressSize))
                ) && 
                (
                    this.RuleQuota == input.RuleQuota ||
                    (this.RuleQuota != null &&
                    this.RuleQuota.Equals(input.RuleQuota))
                ) && 
                (
                    this.Ratio95peakPlus == input.Ratio95peakPlus ||
                    (this.Ratio95peakPlus != null &&
                    this.Ratio95peakPlus.Equals(input.Ratio95peakPlus))
                ) && 
                (
                    this.EnableBandwidthRules == input.EnableBandwidthRules ||
                    (this.EnableBandwidthRules != null &&
                    this.EnableBandwidthRules.Equals(input.EnableBandwidthRules))
                ) && 
                (
                    this.BandwidthRules == input.BandwidthRules ||
                    this.BandwidthRules != null &&
                    input.BandwidthRules != null &&
                    this.BandwidthRules.SequenceEqual(input.BandwidthRules)
                ) && 
                (
                    this.PublicBorderGroup == input.PublicBorderGroup ||
                    (this.PublicBorderGroup != null &&
                    this.PublicBorderGroup.Equals(input.PublicBorderGroup))
                ) && 
                (
                    this.BandwidthType == input.BandwidthType ||
                    (this.BandwidthType != null &&
                    this.BandwidthType.Equals(input.BandwidthType))
                ) && 
                (
                    this.Billinginfo == input.Billinginfo ||
                    (this.Billinginfo != null &&
                    this.Billinginfo.Equals(input.Billinginfo))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PublicipInfo == input.PublicipInfo ||
                    this.PublicipInfo != null &&
                    input.PublicipInfo != null &&
                    this.PublicipInfo.SequenceEqual(input.PublicipInfo)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.AdminState != null)
                    hashCode = hashCode * 59 + this.AdminState.GetHashCode();
                if (this.IngressSize != null)
                    hashCode = hashCode * 59 + this.IngressSize.GetHashCode();
                if (this.RuleQuota != null)
                    hashCode = hashCode * 59 + this.RuleQuota.GetHashCode();
                if (this.Ratio95peakPlus != null)
                    hashCode = hashCode * 59 + this.Ratio95peakPlus.GetHashCode();
                if (this.EnableBandwidthRules != null)
                    hashCode = hashCode * 59 + this.EnableBandwidthRules.GetHashCode();
                if (this.BandwidthRules != null)
                    hashCode = hashCode * 59 + this.BandwidthRules.GetHashCode();
                if (this.PublicBorderGroup != null)
                    hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                if (this.BandwidthType != null)
                    hashCode = hashCode * 59 + this.BandwidthType.GetHashCode();
                if (this.Billinginfo != null)
                    hashCode = hashCode * 59 + this.Billinginfo.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PublicipInfo != null)
                    hashCode = hashCode * 59 + this.PublicipInfo.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
