using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListCloseAccountStatusesRequest 
    {
        /// <summary>
        /// pending_closure关闭中，suspended已关闭
        /// </summary>
        /// <value>pending_closure关闭中，suspended已关闭</value>
        [JsonConverter(typeof(EnumClassConverter<StatesEnum>))]
        public class StatesEnum
        {
            /// <summary>
            /// Enum PENDING_CLOSURE for value: pending_closure
            /// </summary>
            public static readonly StatesEnum PENDING_CLOSURE = new StatesEnum("pending_closure");

            /// <summary>
            /// Enum SUSPENDED for value: suspended
            /// </summary>
            public static readonly StatesEnum SUSPENDED = new StatesEnum("suspended");

            private static readonly Dictionary<string, StatesEnum> StaticFields =
            new Dictionary<string, StatesEnum>()
            {
                { "pending_closure", PENDING_CLOSURE },
                { "suspended", SUSPENDED },
            };

            private string _value;

            public StatesEnum()
            {

            }

            public StatesEnum(string value)
            {
                _value = value;
            }

            public static StatesEnum FromValue(string value)
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

                if (this.Equals(obj as StatesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatesEnum a, StatesEnum b)
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

            public static bool operator !=(StatesEnum a, StatesEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 如果正在使用临时安全凭据，则此header是必需的，该值是临时安全凭据的安全令牌（会话令牌）。
        /// </summary>
        [SDKProperty("X-Security-Token", IsHeader = true)]
        [JsonProperty("X-Security-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string XSecurityToken { get; set; }

        /// <summary>
        /// 要包含在响应中的一个或多个状态的列表。如果此参数不存在，则所有请求都包含在响应中。
        /// </summary>
        [SDKProperty("states", IsQuery = true)]
        [JsonProperty("states", NullValueHandling = NullValueHandling.Ignore)]
        public List<StatesEnum> States { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCloseAccountStatusesRequest {\n");
            sb.Append("  xSecurityToken: ").Append(XSecurityToken).Append("\n");
            sb.Append("  states: ").Append(States).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCloseAccountStatusesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCloseAccountStatusesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XSecurityToken == input.XSecurityToken ||
                    (this.XSecurityToken != null &&
                    this.XSecurityToken.Equals(input.XSecurityToken))
                ) && 
                (
                    this.States == input.States ||
                    this.States != null &&
                    input.States != null &&
                    this.States.SequenceEqual(input.States)
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
                if (this.XSecurityToken != null)
                    hashCode = hashCode * 59 + this.XSecurityToken.GetHashCode();
                if (this.States != null)
                    hashCode = hashCode * 59 + this.States.GetHashCode();
                return hashCode;
            }
        }
    }
}
