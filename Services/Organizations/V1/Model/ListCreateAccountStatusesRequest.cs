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
    public class ListCreateAccountStatusesRequest 
    {
        /// <summary>
        /// 创建账号的状态，in_progress处理中，succeeded成功，failed失败
        /// </summary>
        /// <value>创建账号的状态，in_progress处理中，succeeded成功，failed失败</value>
        [JsonConverter(typeof(EnumClassConverter<StatesEnum>))]
        public class StatesEnum
        {
            /// <summary>
            /// Enum IN_PROGRESS for value: in_progress
            /// </summary>
            public static readonly StatesEnum IN_PROGRESS = new StatesEnum("in_progress");

            /// <summary>
            /// Enum SUCCEEDED for value: succeeded
            /// </summary>
            public static readonly StatesEnum SUCCEEDED = new StatesEnum("succeeded");

            /// <summary>
            /// Enum FAILED for value: failed
            /// </summary>
            public static readonly StatesEnum FAILED = new StatesEnum("failed");

            private static readonly Dictionary<string, StatesEnum> StaticFields =
            new Dictionary<string, StatesEnum>()
            {
                { "in_progress", IN_PROGRESS },
                { "succeeded", SUCCEEDED },
                { "failed", FAILED },
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
        /// 页面中最大结果数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页标记。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCreateAccountStatusesRequest {\n");
            sb.Append("  xSecurityToken: ").Append(XSecurityToken).Append("\n");
            sb.Append("  states: ").Append(States).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCreateAccountStatusesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCreateAccountStatusesRequest input)
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
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
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
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                return hashCode;
            }
        }
    }
}
