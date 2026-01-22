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
    /// **参数解释：** 批量自定义IPS规则请求体 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
    /// </summary>
    public class IpsCustomerBatchDto 
    {
        /// <summary>
        /// **参数解释**： 自定义IPS规则执行动作,仅更新自定义IPS规则场景下需要设置，其他场景无需设置 **约束限制**：   不涉及 **取值范围**： 0：只记录日志 1：重置/拦截 **默认取值**：   不涉及
        /// </summary>
        /// <value>**参数解释**： 自定义IPS规则执行动作,仅更新自定义IPS规则场景下需要设置，其他场景无需设置 **约束限制**：   不涉及 **取值范围**： 0：只记录日志 1：重置/拦截 **默认取值**：   不涉及</value>
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
        /// **参数解释**： 自定义IPS规则执行动作,仅更新自定义IPS规则场景下需要设置，其他场景无需设置 **约束限制**：   不涉及 **取值范围**： 0：只记录日志 1：重置/拦截 **默认取值**：   不涉及
        /// </summary>
        [JsonProperty("action_type", NullValueHandling = NullValueHandling.Ignore)]
        public ActionTypeEnum ActionType { get; set; }
        /// <summary>
        /// **参数解释**： ips规则ID， 可通过调用获取ips规则列表获取，通过data.records.ips_id获取。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("ips_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpsIds { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙ID，用户创建防火墙实例后产生的唯一ID，配置后可区分不同防火墙，可通过[防火墙ID获取方式](cfw_02_0028.xml)获取 **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpsCustomerBatchDto {\n");
            sb.Append("  actionType: ").Append(ActionType).Append("\n");
            sb.Append("  ipsIds: ").Append(IpsIds).Append("\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpsCustomerBatchDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpsCustomerBatchDto input)
        {
            if (input == null) return false;
            if (this.ActionType != input.ActionType) return false;
            if (this.IpsIds != input.IpsIds || (this.IpsIds != null && input.IpsIds != null && !this.IpsIds.SequenceEqual(input.IpsIds))) return false;
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;

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
                hashCode = hashCode * 59 + this.ActionType.GetHashCode();
                if (this.IpsIds != null) hashCode = hashCode * 59 + this.IpsIds.GetHashCode();
                if (this.FwInstanceId != null) hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
