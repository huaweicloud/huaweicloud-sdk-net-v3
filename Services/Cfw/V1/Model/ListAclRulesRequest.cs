using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListAclRulesRequest 
    {
        /// <summary>
        /// **参数解释**： 规则类型，用于区分不同防护对象设置规则类型。 **约束限制**： 不涉及 **取值范围**： 0：互联网边界规则，源（source）和目的（destination）地址需要为公网IP或域名； 1：VPC间规则，源（source）和目的（destination）地址需要为私有ip； 2：NAT规则，源（source）地址需要为私网IP，目的地址为公网IP或域名。 **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 规则类型，用于区分不同防护对象设置规则类型。 **约束限制**： 不涉及 **取值范围**： 0：互联网边界规则，源（source）和目的（destination）地址需要为公网IP或域名； 1：VPC间规则，源（source）和目的（destination）地址需要为私有ip； 2：NAT规则，源（source）地址需要为私网IP，目的地址为公网IP或域名。 **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly TypeEnum NUMBER_0 = new TypeEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly TypeEnum NUMBER_1 = new TypeEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly TypeEnum NUMBER_2 = new TypeEnum(2);

            private static readonly Dictionary<int?, TypeEnum> StaticFields =
            new Dictionary<int?, TypeEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
            };

            private int? _value;

            public TypeEnum()
            {

            }

            public TypeEnum(int? value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(int? value)
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

            public int? GetValue()
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 规则启用状态，用于区分规则是否启用 **约束限制**： 仅能使用数字0和1 **取值范围**： 0表示启用，1表示禁用 **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 规则启用状态，用于区分规则是否启用 **约束限制**： 仅能使用数字0和1 **取值范围**： 0表示启用，1表示禁用 **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly StatusEnum NUMBER_0 = new StatusEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly StatusEnum NUMBER_1 = new StatusEnum(1);

            private static readonly Dictionary<int?, StatusEnum> StaticFields =
            new Dictionary<int?, StatusEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? _value;

            public StatusEnum()
            {

            }

            public StatusEnum(int? value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(int? value)
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

            public int? GetValue()
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
        /// **参数解释**： 规则动作类型，用于区分规则对流量的动作 **约束限制**： 仅能使用数字0和1 **取值范围**： 0表示允许通行（permit），1表示拒绝通行（deny） **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 规则动作类型，用于区分规则对流量的动作 **约束限制**： 仅能使用数字0和1 **取值范围**： 0表示允许通行（permit），1表示拒绝通行（deny） **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<ActionTypeEnum>))]
        public class ActionTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly ActionTypeEnum NUMBER_0 = new ActionTypeEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly ActionTypeEnum NUMBER_1 = new ActionTypeEnum(1);

            private static readonly Dictionary<int?, ActionTypeEnum> StaticFields =
            new Dictionary<int?, ActionTypeEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? _value;

            public ActionTypeEnum()
            {

            }

            public ActionTypeEnum(int? value)
            {
                _value = value;
            }

            public static ActionTypeEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as ActionTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionTypeEnum a, ActionTypeEnum b)
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

            public static bool operator !=(ActionTypeEnum a, ActionTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： IP地址的互联网协议类型，用于指定IP地址的互联网协议，由客户指定 **约束限制**： 不涉及 **取值范围**： 0表示IPv4，1表示IPv6 **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： IP地址的互联网协议类型，用于指定IP地址的互联网协议，由客户指定 **约束限制**： 不涉及 **取值范围**： 0表示IPv4，1表示IPv6 **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<AddressTypeEnum>))]
        public class AddressTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly AddressTypeEnum NUMBER_0 = new AddressTypeEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly AddressTypeEnum NUMBER_1 = new AddressTypeEnum(1);

            private static readonly Dictionary<int?, AddressTypeEnum> StaticFields =
            new Dictionary<int?, AddressTypeEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? _value;

            public AddressTypeEnum()
            {

            }

            public AddressTypeEnum(int? value)
            {
                _value = value;
            }

            public static AddressTypeEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as AddressTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AddressTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AddressTypeEnum a, AddressTypeEnum b)
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

            public static bool operator !=(AddressTypeEnum a, AddressTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 防护对象ID，是创建云防火墙后用于区分互联网边界防护和VPC边界防护的标志ID，可通过调用[查询防火墙实例接口](ListFirewallDetail.xml)获得，通过返回值中的data.records.protect_objects.object_id（.表示各对象之间层级的区分）获得 **约束限制**： type为0时，object_id为互联网边界防护对象ID，type为1时，object_id为VPC边界防护对象ID，type可通过data.records.protect_objects.type（.表示各对象之间层级的区分）获得 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("object_id", IsQuery = true)]
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// **参数解释**： 规则类型，用于区分不同防护对象设置规则类型。 **约束限制**： 不涉及 **取值范围**： 0：互联网边界规则，源（source）和目的（destination）地址需要为公网IP或域名； 1：VPC间规则，源（source）和目的（destination）地址需要为私有ip； 2：NAT规则，源（source）地址需要为私网IP，目的地址为公网IP或域名。 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释**： IP地址信息 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("ip", IsQuery = true)]
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// **参数解释**： 规则名称，由用户定义，用于标识规则 **约束限制**： 字符串长度为0到255 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 规则方向，用于指定规则是从云上至云下，还是云下至云上 **约束限制**： 当规则type&#x3D;0（互联网规则）或者type&#x3D; 2（nat规则）时方向值必填 **取值范围**： 0表示外到内（云下到云上），1表示内到外（云上到云下）， **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("direction", IsQuery = true)]
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public int? Direction { get; set; }

        /// <summary>
        /// **参数解释**： 规则启用状态，用于区分规则是否启用 **约束限制**： 仅能使用数字0和1 **取值范围**： 0表示启用，1表示禁用 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释**： 规则动作类型，用于区分规则对流量的动作 **约束限制**： 仅能使用数字0和1 **取值范围**： 0表示允许通行（permit），1表示拒绝通行（deny） **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("action_type", IsQuery = true)]
        [JsonProperty("action_type", NullValueHandling = NullValueHandling.Ignore)]
        public ActionTypeEnum ActionType { get; set; }
        /// <summary>
        /// **参数解释**： IP地址的互联网协议类型，用于指定IP地址的互联网协议，由客户指定 **约束限制**： 不涉及 **取值范围**： 0表示IPv4，1表示IPv6 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("address_type", IsQuery = true)]
        [JsonProperty("address_type", NullValueHandling = NullValueHandling.Ignore)]
        public AddressTypeEnum AddressType { get; set; }
        /// <summary>
        /// **参数解释**： 每页显示个数 **约束限制**： 必须为数字 **取值范围**： 1-1024 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**： 偏移量：指定返回记录的开始位置 **约束限制**： 必须为数字 **取值范围**： 大于或等于0 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释**： 企业项目ID，用户根据组织规划企业项目，对应的ID为企业项目ID，配置后可根据企业项目过滤不同企业项目下的资产，可通过[如何获取企业项目ID](cfw_02_0027.xml)获取 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**：  0
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙ID，用户创建防火墙实例后产生的唯一ID，配置后可区分不同防火墙，可通过[防火墙ID获取方式](cfw_02_0028.xml)获取 **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("fw_instance_id", IsQuery = true)]
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 规则标签id，创建规则时产生。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("tags_id", IsQuery = true)]
        [JsonProperty("tags_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TagsId { get; set; }

        /// <summary>
        /// **参数解释**： 源地址。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("source", IsQuery = true)]
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// **参数解释**： 目的地址。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("destination", IsQuery = true)]
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public string Destination { get; set; }

        /// <summary>
        /// **参数解释**： 服务端口 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("service", IsQuery = true)]
        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public string Service { get; set; }

        /// <summary>
        /// **参数解释**： 规则应用协议列表 **约束限制**： 不涉及 **取值范围**： 规则应用类型包括：“HTTP”，\&quot;HTTPS\&quot;，\&quot;TLS1\&quot;，“DNS”，“SSH”，“MYSQL”，“SMTP”，“RDP”，“RDPS”，“VNC”，“POP3”，“IMAP4”，“SMTPS”，“POP3S”，“FTPS”，“ANY”，“BGP”等。 **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("application", IsQuery = true)]
        [JsonProperty("application", NullValueHandling = NullValueHandling.Ignore)]
        public string Application { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAclRulesRequest {\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  actionType: ").Append(ActionType).Append("\n");
            sb.Append("  addressType: ").Append(AddressType).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  tagsId: ").Append(TagsId).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  destination: ").Append(Destination).Append("\n");
            sb.Append("  service: ").Append(Service).Append("\n");
            sb.Append("  application: ").Append(Application).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAclRulesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAclRulesRequest input)
        {
            if (input == null) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.Type != input.Type) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Direction != input.Direction || (this.Direction != null && !this.Direction.Equals(input.Direction))) return false;
            if (this.Status != input.Status) return false;
            if (this.ActionType != input.ActionType) return false;
            if (this.AddressType != input.AddressType) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;
            if (this.TagsId != input.TagsId || (this.TagsId != null && !this.TagsId.Equals(input.TagsId))) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.Destination != input.Destination || (this.Destination != null && !this.Destination.Equals(input.Destination))) return false;
            if (this.Service != input.Service || (this.Service != null && !this.Service.Equals(input.Service))) return false;
            if (this.Application != input.Application || (this.Application != null && !this.Application.Equals(input.Application))) return false;

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
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Direction != null) hashCode = hashCode * 59 + this.Direction.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.FwInstanceId != null) hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                if (this.TagsId != null) hashCode = hashCode * 59 + this.TagsId.GetHashCode();
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Destination != null) hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Service != null) hashCode = hashCode * 59 + this.Service.GetHashCode();
                if (this.Application != null) hashCode = hashCode * 59 + this.Application.GetHashCode();
                return hashCode;
            }
        }
    }
}
