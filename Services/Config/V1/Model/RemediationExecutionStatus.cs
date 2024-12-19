using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 指定资源合规规则修正最新执行结果。
    /// </summary>
    public class RemediationExecutionStatus 
    {
        /// <summary>
        /// 合规规则修正执行的状态。
        /// </summary>
        /// <value>合规规则修正执行的状态。</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum IN_QUEUE for value: IN_QUEUE
            /// </summary>
            public static readonly StateEnum IN_QUEUE = new StateEnum("IN_QUEUE");

            /// <summary>
            /// Enum IN_PROGRESS for value: IN_PROGRESS
            /// </summary>
            public static readonly StateEnum IN_PROGRESS = new StateEnum("IN_PROGRESS");

            /// <summary>
            /// Enum SUCCEEDED for value: SUCCEEDED
            /// </summary>
            public static readonly StateEnum SUCCEEDED = new StateEnum("SUCCEEDED");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly StateEnum FAILED = new StateEnum("FAILED");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "IN_QUEUE", IN_QUEUE },
                { "IN_PROGRESS", IN_PROGRESS },
                { "SUCCEEDED", SUCCEEDED },
                { "FAILED", FAILED },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resource_key", NullValueHandling = NullValueHandling.Ignore)]
        public RemediationResourceKey ResourceKey { get; set; }

        /// <summary>
        /// 补救执行的开始时间。
        /// </summary>
        [JsonProperty("invocation_time", NullValueHandling = NullValueHandling.Ignore)]
        public string InvocationTime { get; set; }

        /// <summary>
        /// 合规规则修正执行的状态。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// 合规规则修正执行的信息。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemediationExecutionStatus {\n");
            sb.Append("  resourceKey: ").Append(ResourceKey).Append("\n");
            sb.Append("  invocationTime: ").Append(InvocationTime).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemediationExecutionStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemediationExecutionStatus input)
        {
            if (input == null) return false;
            if (this.ResourceKey != input.ResourceKey || (this.ResourceKey != null && !this.ResourceKey.Equals(input.ResourceKey))) return false;
            if (this.InvocationTime != input.InvocationTime || (this.InvocationTime != null && !this.InvocationTime.Equals(input.InvocationTime))) return false;
            if (this.State != input.State) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;

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
                if (this.ResourceKey != null) hashCode = hashCode * 59 + this.ResourceKey.GetHashCode();
                if (this.InvocationTime != null) hashCode = hashCode * 59 + this.InvocationTime.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
