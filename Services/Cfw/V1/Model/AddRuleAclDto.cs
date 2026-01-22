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
    /// AddRuleAclDto
    /// </summary>
    public class AddRuleAclDto 
    {
        /// <summary>
        /// **参数解释**： 规则类型，用于区分不同防护对象设置规则类型。 **约束限制**： 不涉及 **取值范围**：  0：互联网边界规则，源（source）和目的（destination）地址需要为公网IP或域名； 1：VPC间规则，源（source）和目的（destination）地址需要为私有ip； 2：NAT规则，源（source）地址需要为私网IP，目的地址为公网IP或域名。 **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 规则类型，用于区分不同防护对象设置规则类型。 **约束限制**： 不涉及 **取值范围**：  0：互联网边界规则，源（source）和目的（destination）地址需要为公网IP或域名； 1：VPC间规则，源（source）和目的（destination）地址需要为私有ip； 2：NAT规则，源（source）地址需要为私网IP，目的地址为公网IP或域名。 **默认取值**： 不涉及</value>
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
        /// **参数解释**： 防护对象ID，是创建云防火墙后用于区分互联网边界防护和VPC边界防护的标志ID，可通过调用[查询防火墙实例接口](ListFirewallDetail.xml)获得，通过返回值中的data.records.protect_objects.object_id（.表示各对象之间层级的区分）获得 **约束限制**： type为0时，object_id为互联网边界防护对象ID，type为1时，object_id为VPC边界防护对象ID，type可通过data.records.protect_objects.type（.表示各对象之间层级的区分）获得 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// **参数解释**： 规则类型，用于区分不同防护对象设置规则类型。 **约束限制**： 不涉及 **取值范围**：  0：互联网边界规则，源（source）和目的（destination）地址需要为公网IP或域名； 1：VPC间规则，源（source）和目的（destination）地址需要为私有ip； 2：NAT规则，源（source）地址需要为私网IP，目的地址为公网IP或域名。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释**： 添加规则请求规则列表 **约束限制**： 不涉及
        /// </summary>
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddRuleAclDtoRules> Rules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddRuleAclDto {\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  rules: ").Append(Rules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddRuleAclDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddRuleAclDto input)
        {
            if (input == null) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.Type != input.Type) return false;
            if (this.Rules != input.Rules || (this.Rules != null && input.Rules != null && !this.Rules.SequenceEqual(input.Rules))) return false;

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
                if (this.Rules != null) hashCode = hashCode * 59 + this.Rules.GetHashCode();
                return hashCode;
            }
        }
    }
}
