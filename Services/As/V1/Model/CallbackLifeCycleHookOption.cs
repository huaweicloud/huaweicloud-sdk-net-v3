using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 伸缩实例生命周期回调
    /// </summary>
    public class CallbackLifeCycleHookOption 
    {
        /// <summary>
        /// 生命周期回调操作。ABANDON：终止。CONTINUE：继续。EXTEND：延长超时时间，每次延长1小时。
        /// </summary>
        /// <value>生命周期回调操作。ABANDON：终止。CONTINUE：继续。EXTEND：延长超时时间，每次延长1小时。</value>
        [JsonConverter(typeof(EnumClassConverter<LifecycleActionResultEnum>))]
        public class LifecycleActionResultEnum
        {
            /// <summary>
            /// Enum ABANDON for value: ABANDON
            /// </summary>
            public static readonly LifecycleActionResultEnum ABANDON = new LifecycleActionResultEnum("ABANDON");

            /// <summary>
            /// Enum CONTINUE for value: CONTINUE
            /// </summary>
            public static readonly LifecycleActionResultEnum CONTINUE = new LifecycleActionResultEnum("CONTINUE");

            /// <summary>
            /// Enum EXTEND for value: EXTEND
            /// </summary>
            public static readonly LifecycleActionResultEnum EXTEND = new LifecycleActionResultEnum("EXTEND");

            private static readonly Dictionary<string, LifecycleActionResultEnum> StaticFields =
            new Dictionary<string, LifecycleActionResultEnum>()
            {
                { "ABANDON", ABANDON },
                { "CONTINUE", CONTINUE },
                { "EXTEND", EXTEND },
            };

            private string Value;

            public LifecycleActionResultEnum(string value)
            {
                Value = value;
            }

            public static LifecycleActionResultEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as LifecycleActionResultEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LifecycleActionResultEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(LifecycleActionResultEnum a, LifecycleActionResultEnum b)
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

            public static bool operator !=(LifecycleActionResultEnum a, LifecycleActionResultEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 生命周期操作令牌，通过查询伸缩实例挂起信息接口获取。指定生命周期回调对象，当不传入instance_id字段时，该字段为必选。当该字段与instance_id字段都传入，优先使用该字段进行回调。
        /// </summary>
        [JsonProperty("lifecycle_action_key", NullValueHandling = NullValueHandling.Ignore)]
        public string LifecycleActionKey { get; set; }

        /// <summary>
        /// 实例ID。指定生命周期回调对象，当不传入lifecycle_action_key字段时，该字段为必选。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 生命周期挂钩名称。指定生命周期回调对象，当不传入lifecycle_action_key字段时，该字段为必选。
        /// </summary>
        [JsonProperty("lifecycle_hook_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LifecycleHookName { get; set; }

        /// <summary>
        /// 生命周期回调操作。ABANDON：终止。CONTINUE：继续。EXTEND：延长超时时间，每次延长1小时。
        /// </summary>
        [JsonProperty("lifecycle_action_result", NullValueHandling = NullValueHandling.Ignore)]
        public LifecycleActionResultEnum LifecycleActionResult { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallbackLifeCycleHookOption {\n");
            sb.Append("  lifecycleActionKey: ").Append(LifecycleActionKey).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  lifecycleHookName: ").Append(LifecycleHookName).Append("\n");
            sb.Append("  lifecycleActionResult: ").Append(LifecycleActionResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CallbackLifeCycleHookOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CallbackLifeCycleHookOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LifecycleActionKey == input.LifecycleActionKey ||
                    (this.LifecycleActionKey != null &&
                    this.LifecycleActionKey.Equals(input.LifecycleActionKey))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.LifecycleHookName == input.LifecycleHookName ||
                    (this.LifecycleHookName != null &&
                    this.LifecycleHookName.Equals(input.LifecycleHookName))
                ) && 
                (
                    this.LifecycleActionResult == input.LifecycleActionResult ||
                    (this.LifecycleActionResult != null &&
                    this.LifecycleActionResult.Equals(input.LifecycleActionResult))
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
                if (this.LifecycleActionKey != null)
                    hashCode = hashCode * 59 + this.LifecycleActionKey.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.LifecycleHookName != null)
                    hashCode = hashCode * 59 + this.LifecycleHookName.GetHashCode();
                if (this.LifecycleActionResult != null)
                    hashCode = hashCode * 59 + this.LifecycleActionResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
