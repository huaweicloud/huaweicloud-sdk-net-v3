using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 自定义CPU选项。
    /// </summary>
    public class CpuOptions 
    {
        /// <summary>
        /// CPU超线程数， 决定CPU是否开启超线程。取值范围：1，2。  - 1: 关闭超线程。 - 2: 打开超线程。  取值不能大于flavor中的   hw:cpu_threads，并且目标flavor配置需满足 \&quot;hw:cpu_policy\&quot;: \&quot;dedicated\&quot;,\&quot;hw:cpu_threads\&quot;: \&quot;2\&quot;需要同时满足如下条件，才能设置为“关闭超线程”  - 只能在实例创建或者resize时指定。 - 只有目标flavor的extra_specs参数： - 存在“hw:cpu_policy”并取值为“dedicated”。 - 存在“hw:cpu_threads”并取值为“2”。
        /// </summary>
        /// <value>CPU超线程数， 决定CPU是否开启超线程。取值范围：1，2。  - 1: 关闭超线程。 - 2: 打开超线程。  取值不能大于flavor中的   hw:cpu_threads，并且目标flavor配置需满足 \&quot;hw:cpu_policy\&quot;: \&quot;dedicated\&quot;,\&quot;hw:cpu_threads\&quot;: \&quot;2\&quot;需要同时满足如下条件，才能设置为“关闭超线程”  - 只能在实例创建或者resize时指定。 - 只有目标flavor的extra_specs参数： - 存在“hw:cpu_policy”并取值为“dedicated”。 - 存在“hw:cpu_threads”并取值为“2”。</value>
        [JsonConverter(typeof(EnumClassConverter<HwcpuThreadsEnum>))]
        public class HwcpuThreadsEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly HwcpuThreadsEnum NUMBER_1 = new HwcpuThreadsEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly HwcpuThreadsEnum NUMBER_2 = new HwcpuThreadsEnum(2);

            private static readonly Dictionary<int?, HwcpuThreadsEnum> StaticFields =
            new Dictionary<int?, HwcpuThreadsEnum>()
            {
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
            };

            private int? _value;

            public HwcpuThreadsEnum()
            {

            }

            public HwcpuThreadsEnum(int? value)
            {
                _value = value;
            }

            public static HwcpuThreadsEnum FromValue(int? value)
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

                if (this.Equals(obj as HwcpuThreadsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HwcpuThreadsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HwcpuThreadsEnum a, HwcpuThreadsEnum b)
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

            public static bool operator !=(HwcpuThreadsEnum a, HwcpuThreadsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// CPU超线程数， 决定CPU是否开启超线程。取值范围：1，2。  - 1: 关闭超线程。 - 2: 打开超线程。  取值不能大于flavor中的   hw:cpu_threads，并且目标flavor配置需满足 \&quot;hw:cpu_policy\&quot;: \&quot;dedicated\&quot;,\&quot;hw:cpu_threads\&quot;: \&quot;2\&quot;需要同时满足如下条件，才能设置为“关闭超线程”  - 只能在实例创建或者resize时指定。 - 只有目标flavor的extra_specs参数： - 存在“hw:cpu_policy”并取值为“dedicated”。 - 存在“hw:cpu_threads”并取值为“2”。
        /// </summary>
        [JsonProperty("hw:cpu_threads", NullValueHandling = NullValueHandling.Ignore)]
        public HwcpuThreadsEnum HwcpuThreads { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CpuOptions {\n");
            sb.Append("  hwcpuThreads: ").Append(HwcpuThreads).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CpuOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CpuOptions input)
        {
            if (input == null) return false;
            if (this.HwcpuThreads != input.HwcpuThreads) return false;

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
                hashCode = hashCode * 59 + this.HwcpuThreads.GetHashCode();
                return hashCode;
            }
        }
    }
}
