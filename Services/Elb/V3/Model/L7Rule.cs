using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// L7转发规则
    /// </summary>
    public class L7Rule 
    {
        /// <summary>
        /// 参数解释：转发规则类别。  约束限制： - 一个l7policy下创建的l7rule的HOST_NAME，PATH，METHOD，SOURCE_IP不能重复。 HEADER、QUERY_STRING支持重复的rule配置。  取值范围： - HOST_NAME：匹配域名。 - PATH：匹配请求路径。 - METHOD：匹配请求方法。 - HEADER：匹配请求头。 - QUERY_STRING：匹配请求查询参数。 - SOURCE_IP：匹配请求源IP地址。 - COOKIE: 匹配cookie信息。  [只支持取值为HOST_NAME，PATH。](tag:hcso_dt)
        /// </summary>
        /// <value>参数解释：转发规则类别。  约束限制： - 一个l7policy下创建的l7rule的HOST_NAME，PATH，METHOD，SOURCE_IP不能重复。 HEADER、QUERY_STRING支持重复的rule配置。  取值范围： - HOST_NAME：匹配域名。 - PATH：匹配请求路径。 - METHOD：匹配请求方法。 - HEADER：匹配请求头。 - QUERY_STRING：匹配请求查询参数。 - SOURCE_IP：匹配请求源IP地址。 - COOKIE: 匹配cookie信息。  [只支持取值为HOST_NAME，PATH。](tag:hcso_dt)</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum HOST_NAME for value: HOST_NAME
            /// </summary>
            public static readonly TypeEnum HOST_NAME = new TypeEnum("HOST_NAME");

            /// <summary>
            /// Enum PATH for value: PATH
            /// </summary>
            public static readonly TypeEnum PATH = new TypeEnum("PATH");

            /// <summary>
            /// Enum METHOD for value: METHOD
            /// </summary>
            public static readonly TypeEnum METHOD = new TypeEnum("METHOD");

            /// <summary>
            /// Enum HEADER for value: HEADER
            /// </summary>
            public static readonly TypeEnum HEADER = new TypeEnum("HEADER");

            /// <summary>
            /// Enum QUERY_STRING for value: QUERY_STRING
            /// </summary>
            public static readonly TypeEnum QUERY_STRING = new TypeEnum("QUERY_STRING");

            /// <summary>
            /// Enum SOURCE_IP for value: SOURCE_IP
            /// </summary>
            public static readonly TypeEnum SOURCE_IP = new TypeEnum("SOURCE_IP");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "HOST_NAME", HOST_NAME },
                { "PATH", PATH },
                { "METHOD", METHOD },
                { "HEADER", HEADER },
                { "QUERY_STRING", QUERY_STRING },
                { "SOURCE_IP", SOURCE_IP },
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
        /// 参数解释：转发规则的管理状，固定为true。  不支持该字段，请勿使用。
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 参数解释：转发规则的匹配方式。  取值范围：type为HOST_NAME时可以为EQUAL_TO。type为PATH时可以为REGEX，STARTS_WITH，EQUAL_TO。
        /// </summary>
        [JsonProperty("compare_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareType { get; set; }

        /// <summary>
        /// 参数解释：匹配内容的键值。  [约束限制：type为HOST_NAME和PATH时，该字段不生效。 ](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,srg,fcs,dt)  [不支持该字段，请勿使用。](tag:hcso_dt)
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 参数解释：转发规则所在的项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 参数解释：转发规则类别。  约束限制： - 一个l7policy下创建的l7rule的HOST_NAME，PATH，METHOD，SOURCE_IP不能重复。 HEADER、QUERY_STRING支持重复的rule配置。  取值范围： - HOST_NAME：匹配域名。 - PATH：匹配请求路径。 - METHOD：匹配请求方法。 - HEADER：匹配请求头。 - QUERY_STRING：匹配请求查询参数。 - SOURCE_IP：匹配请求源IP地址。 - COOKIE: 匹配cookie信息。  [只支持取值为HOST_NAME，PATH。](tag:hcso_dt)
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 参数解释：匹配内容的值。  约束限制：仅当conditions空时该字段生效。  取值范围： - 当type为HOST_NAME时，字符串只能包含英文字母、数字、-.*，必须以字母、数字或*开头。若域名中包含*，则*只能出现在开头且必须以*.开始。当*开头时表示通配0~任一个字符。  - 当type为PATH时，当转发规则的compare_type为STARTS_WITH、EQUAL_TO时，字符串只能包含英文字母、数字、_~&#39;;@^-%#&amp;$.*+?,&#x3D;!:|\\/()\\[\\]{}，且必须以/开头。  - 当type为METHOD、SOURCE_IP、HEADER, QUERY_STRING时，该字段无意义，使用conditions来指定key，value。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 参数解释：provisioning状态。该字段无效，默认为ACTIVE。  取值范围：ACTIVE、PENDING_CREATE 或者ERROR。
        /// </summary>
        [JsonProperty("provisioning_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvisioningStatus { get; set; }

        /// <summary>
        /// 参数解释：是否反向匹配。  约束限制：固定为false。该字段能更新但不会生效。
        /// </summary>
        [JsonProperty("invert", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invert { get; set; }

        /// <summary>
        /// 参数解释：规则ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 参数解释：转发规则的匹配条件。  约束限制： - 当监听器的高级转发策略功能（enhance_l7policy_enable）开启后才会生效。 - 若转发规则配置了conditions，字段key、字段value的值无意义。 - 同一个rule内的conditions列表中所有key必须相同，value不允许重复。  [不支持该字段，请勿使用。](tag:hcso_dt)  [荷兰region不支持该字段，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleCondition> Conditions { get; set; }

        /// <summary>
        /// 参数解释：创建时间。  取值范围：格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，UTC时区。  [注意：独享型实例的历史数据以及共享型实例下的资源，不返回该字段。 ](tag:hws,hws_hk,ocb,ctc,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,srg,fcs,dt,hk_tm)
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 参数解释：更新时间。  取值范围：格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，UTC时区。  [注意：独享型实例的历史数据以及共享型实例下的资源，不返回该字段。 ](tag:hws,hws_hk,ocb,ctc,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,srg,fcs,dt,hk_tm)
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class L7Rule {\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  compareType: ").Append(CompareType).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  provisioningStatus: ").Append(ProvisioningStatus).Append("\n");
            sb.Append("  invert: ").Append(Invert).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  conditions: ").Append(Conditions).Append("\n");
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
            return this.Equals(input as L7Rule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(L7Rule input)
        {
            if (input == null) return false;
            if (this.AdminStateUp != input.AdminStateUp || (this.AdminStateUp != null && !this.AdminStateUp.Equals(input.AdminStateUp))) return false;
            if (this.CompareType != input.CompareType || (this.CompareType != null && !this.CompareType.Equals(input.CompareType))) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Type != input.Type) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.ProvisioningStatus != input.ProvisioningStatus || (this.ProvisioningStatus != null && !this.ProvisioningStatus.Equals(input.ProvisioningStatus))) return false;
            if (this.Invert != input.Invert || (this.Invert != null && !this.Invert.Equals(input.Invert))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Conditions != input.Conditions || (this.Conditions != null && input.Conditions != null && !this.Conditions.SequenceEqual(input.Conditions))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                if (this.AdminStateUp != null) hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.CompareType != null) hashCode = hashCode * 59 + this.CompareType.GetHashCode();
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.ProvisioningStatus != null) hashCode = hashCode * 59 + this.ProvisioningStatus.GetHashCode();
                if (this.Invert != null) hashCode = hashCode * 59 + this.Invert.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Conditions != null) hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
