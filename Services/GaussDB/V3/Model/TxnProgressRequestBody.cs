using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 查询大事务进度的请求体。
    /// </summary>
    public class TxnProgressRequestBody 
    {
        /// <summary>
        /// **参数解释**： 指定查询的事务动作类型。  **约束限制**：  不涉及。 **取值范围**：  rollback：查询事务的回滚进度。  **默认取值**：   rollback。
        /// </summary>
        /// <value>**参数解释**： 指定查询的事务动作类型。  **约束限制**：  不涉及。 **取值范围**：  rollback：查询事务的回滚进度。  **默认取值**：   rollback。</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum ROLLBACK for value: rollback
            /// </summary>
            public static readonly ActionEnum ROLLBACK = new ActionEnum("rollback");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "rollback", ROLLBACK },
            };

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(string value)
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

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 指定查询的事务动作类型。  **约束限制**：  不涉及。 **取值范围**：  rollback：查询事务的回滚进度。  **默认取值**：   rollback。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// **参数解释**：   事务唯一标识列表。   - 列表为空/不传：将执行全量查询，并根据limit和offset分页参数返回当前所有处于执行中的事务信息。   - 列表不为空：将精确匹配并返回transaction_ids中指定的事务信息，此时分页参数（limit/offset）无效。 **约束限制**：   单次查询最多支持100个事务ID。 **取值范围**：   符合事务ID格式的字符串列表。
        /// </summary>
        [JsonProperty("transaction_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TransactionIds { get; set; }

        /// <summary>
        /// **参数解释**：  查询记录数。  **约束限制**：  必须为整数，不能为负数。  **取值范围**：  1-100。  **默认取值**：  100。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**：    索引位置，偏移量。从第一条数据偏移offset条数据后开始查询。    **约束限制**：    必须为整数，不能为负数。    **取值范围**：    ≥0。  **默认取值**：    0。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TxnProgressRequestBody {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  transactionIds: ").Append(TransactionIds).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TxnProgressRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TxnProgressRequestBody input)
        {
            if (input == null) return false;
            if (this.Action != input.Action) return false;
            if (this.TransactionIds != input.TransactionIds || (this.TransactionIds != null && input.TransactionIds != null && !this.TransactionIds.SequenceEqual(input.TransactionIds))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;

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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.TransactionIds != null) hashCode = hashCode * 59 + this.TransactionIds.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
