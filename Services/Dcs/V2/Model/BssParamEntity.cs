using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BssParamEntity 
    {
        /// <summary>
        /// 功能说明：下单订购后，是否自动从客户的账户中支付；默认是“不自动支付” 。  取值范围： - true：是（自动支付，从账户余额自动扣费） - false：否（默认值，只提交订单不支付，需要客户手动去支付）  约束： 自动支付时，只能使用账户的现金支付；如果要使用代金券，请选择不自动支付，然后在用户费用中心，选择代金券支付。  **如果没有设置成自动支付，即设置为false时，在创建实例之后，实例状态为“支付中”，用户必须在“费用中心 &gt; 我的订单”，完成订单支付，否则订单一直在支付中，实例没有创建成功**。 
        /// </summary>
        /// <value>功能说明：下单订购后，是否自动从客户的账户中支付；默认是“不自动支付” 。  取值范围： - true：是（自动支付，从账户余额自动扣费） - false：否（默认值，只提交订单不支付，需要客户手动去支付）  约束： 自动支付时，只能使用账户的现金支付；如果要使用代金券，请选择不自动支付，然后在用户费用中心，选择代金券支付。  **如果没有设置成自动支付，即设置为false时，在创建实例之后，实例状态为“支付中”，用户必须在“费用中心 &gt; 我的订单”，完成订单支付，否则订单一直在支付中，实例没有创建成功**。 </value>
        [JsonConverter(typeof(EnumClassConverter<IsAutoPayEnum>))]
        public class IsAutoPayEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly IsAutoPayEnum TRUE = new IsAutoPayEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly IsAutoPayEnum FALSE = new IsAutoPayEnum("false");

            private static readonly Dictionary<string, IsAutoPayEnum> StaticFields =
            new Dictionary<string, IsAutoPayEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public IsAutoPayEnum()
            {

            }

            public IsAutoPayEnum(string value)
            {
                _value = value;
            }

            public static IsAutoPayEnum FromValue(string value)
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

                if (this.Equals(obj as IsAutoPayEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IsAutoPayEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IsAutoPayEnum a, IsAutoPayEnum b)
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

            public static bool operator !=(IsAutoPayEnum a, IsAutoPayEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 功能说明：下单订购后，是否自动从客户的账户中支付；默认是“不自动支付” 。  取值范围： - true：是（自动支付，从账户余额自动扣费） - false：否（默认值，只提交订单不支付，需要客户手动去支付）  约束： 自动支付时，只能使用账户的现金支付；如果要使用代金券，请选择不自动支付，然后在用户费用中心，选择代金券支付。  **如果没有设置成自动支付，即设置为false时，在创建实例之后，实例状态为“支付中”，用户必须在“费用中心 &gt; 我的订单”，完成订单支付，否则订单一直在支付中，实例没有创建成功**。 
        /// </summary>
        [JsonProperty("is_auto_pay", NullValueHandling = NullValueHandling.Ignore)]
        public IsAutoPayEnum IsAutoPay { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BssParamEntity {\n");
            sb.Append("  isAutoPay: ").Append(IsAutoPay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BssParamEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BssParamEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsAutoPay == input.IsAutoPay ||
                    (this.IsAutoPay != null &&
                    this.IsAutoPay.Equals(input.IsAutoPay))
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
                if (this.IsAutoPay != null)
                    hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                return hashCode;
            }
        }
    }
}
