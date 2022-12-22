using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// 连接终端节点列表请求结构体
    /// </summary>
    public class AcceptOrRejectEndpointRequestBody 
    {
        /// <summary>
        /// 允许或拒绝连接。 ● receive：允许连接。 ● reject：拒绝连接。
        /// </summary>
        /// <value>允许或拒绝连接。 ● receive：允许连接。 ● reject：拒绝连接。</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum RECEIVE for value: receive
            /// </summary>
            public static readonly ActionEnum RECEIVE = new ActionEnum("receive");

            /// <summary>
            /// Enum REJECT for value: reject
            /// </summary>
            public static readonly ActionEnum REJECT = new ActionEnum("reject");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "receive", RECEIVE },
                { "reject", REJECT },
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 允许或拒绝连接。 ● receive：允许连接。 ● reject：拒绝连接。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// 终端节点ID列表。 每次请求目前支持单条endpoint的接受或拒绝。
        /// </summary>
        [JsonProperty("endpoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Endpoints { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcceptOrRejectEndpointRequestBody {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  endpoints: ").Append(Endpoints).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AcceptOrRejectEndpointRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AcceptOrRejectEndpointRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Endpoints == input.Endpoints ||
                    this.Endpoints != null &&
                    input.Endpoints != null &&
                    this.Endpoints.SequenceEqual(input.Endpoints)
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
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Endpoints != null)
                    hashCode = hashCode * 59 + this.Endpoints.GetHashCode();
                return hashCode;
            }
        }
    }
}
