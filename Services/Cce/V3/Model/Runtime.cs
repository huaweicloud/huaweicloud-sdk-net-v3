using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Runtime 
    {
        /// <summary>
        /// 容器运行时，默认场景： - v1.25以下集群：默认为\&quot;docker\&quot; - v1.25及以上集群，随操作系统变化，默认的容器运行时不同：操作系统为EulerOS 2.5[、EulerOS 2.8](tag:hws,hws_hk)的节点默认为\&quot;docker\&quot;，其余操作系统的节点默认为\&quot;containerd\&quot; 
        /// </summary>
        /// <value>容器运行时，默认场景： - v1.25以下集群：默认为\&quot;docker\&quot; - v1.25及以上集群，随操作系统变化，默认的容器运行时不同：操作系统为EulerOS 2.5[、EulerOS 2.8](tag:hws,hws_hk)的节点默认为\&quot;docker\&quot;，其余操作系统的节点默认为\&quot;containerd\&quot; </value>
        [JsonConverter(typeof(EnumClassConverter<NameEnum>))]
        public class NameEnum
        {
            /// <summary>
            /// Enum DOCKER for value: docker
            /// </summary>
            public static readonly NameEnum DOCKER = new NameEnum("docker");

            /// <summary>
            /// Enum CONTAINERD for value: containerd
            /// </summary>
            public static readonly NameEnum CONTAINERD = new NameEnum("containerd");

            private static readonly Dictionary<string, NameEnum> StaticFields =
            new Dictionary<string, NameEnum>()
            {
                { "docker", DOCKER },
                { "containerd", CONTAINERD },
            };

            private string _value;

            public NameEnum()
            {

            }

            public NameEnum(string value)
            {
                _value = value;
            }

            public static NameEnum FromValue(string value)
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

                if (this.Equals(obj as NameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NameEnum a, NameEnum b)
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

            public static bool operator !=(NameEnum a, NameEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 容器运行时子类别。 **约束限制**： 仅CCE Turbo集群下弹性云服务器-物理机类型节点且上级运行时为containerd场景支持使用安全运行时。 **取值范围**： - runc: 普通运行时。 - kata: 安全运行时，需配套c6、c7系列弹性云服务器-物理机，支持的操作系统为EulerOS 2.10。 - kuasar-vmm: 安全运行时v2，支持kc2、ki2、c7、ac8h系列弹性服务器-物理机，配套操作系统为HCE 2.0，集群版本需为v1.28.15-r70、v1.29.15-r30、v1.30.14-r30、v1.31.10-r30、v1.32.6-r30、v1.33.5-r20或以上版本。  **默认取值**： runc
        /// </summary>
        /// <value>**参数解释**： 容器运行时子类别。 **约束限制**： 仅CCE Turbo集群下弹性云服务器-物理机类型节点且上级运行时为containerd场景支持使用安全运行时。 **取值范围**： - runc: 普通运行时。 - kata: 安全运行时，需配套c6、c7系列弹性云服务器-物理机，支持的操作系统为EulerOS 2.10。 - kuasar-vmm: 安全运行时v2，支持kc2、ki2、c7、ac8h系列弹性服务器-物理机，配套操作系统为HCE 2.0，集群版本需为v1.28.15-r70、v1.29.15-r30、v1.30.14-r30、v1.31.10-r30、v1.32.6-r30、v1.33.5-r20或以上版本。  **默认取值**： runc</value>
        [JsonConverter(typeof(EnumClassConverter<RuntimeClassEnum>))]
        public class RuntimeClassEnum
        {
            /// <summary>
            /// Enum RUNC for value: runc
            /// </summary>
            public static readonly RuntimeClassEnum RUNC = new RuntimeClassEnum("runc");

            /// <summary>
            /// Enum KATA for value: kata
            /// </summary>
            public static readonly RuntimeClassEnum KATA = new RuntimeClassEnum("kata");

            /// <summary>
            /// Enum KUASAR_VMM for value: kuasar-vmm
            /// </summary>
            public static readonly RuntimeClassEnum KUASAR_VMM = new RuntimeClassEnum("kuasar-vmm");

            private static readonly Dictionary<string, RuntimeClassEnum> StaticFields =
            new Dictionary<string, RuntimeClassEnum>()
            {
                { "runc", RUNC },
                { "kata", KATA },
                { "kuasar-vmm", KUASAR_VMM },
            };

            private string _value;

            public RuntimeClassEnum()
            {

            }

            public RuntimeClassEnum(string value)
            {
                _value = value;
            }

            public static RuntimeClassEnum FromValue(string value)
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

                if (this.Equals(obj as RuntimeClassEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RuntimeClassEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RuntimeClassEnum a, RuntimeClassEnum b)
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

            public static bool operator !=(RuntimeClassEnum a, RuntimeClassEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 容器运行时，默认场景： - v1.25以下集群：默认为\&quot;docker\&quot; - v1.25及以上集群，随操作系统变化，默认的容器运行时不同：操作系统为EulerOS 2.5[、EulerOS 2.8](tag:hws,hws_hk)的节点默认为\&quot;docker\&quot;，其余操作系统的节点默认为\&quot;containerd\&quot; 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public NameEnum Name { get; set; }
        /// <summary>
        /// **参数解释**： 容器运行时子类别。 **约束限制**： 仅CCE Turbo集群下弹性云服务器-物理机类型节点且上级运行时为containerd场景支持使用安全运行时。 **取值范围**： - runc: 普通运行时。 - kata: 安全运行时，需配套c6、c7系列弹性云服务器-物理机，支持的操作系统为EulerOS 2.10。 - kuasar-vmm: 安全运行时v2，支持kc2、ki2、c7、ac8h系列弹性服务器-物理机，配套操作系统为HCE 2.0，集群版本需为v1.28.15-r70、v1.29.15-r30、v1.30.14-r30、v1.31.10-r30、v1.32.6-r30、v1.33.5-r20或以上版本。  **默认取值**： runc
        /// </summary>
        [JsonProperty("runtimeClass", NullValueHandling = NullValueHandling.Ignore)]
        public RuntimeClassEnum RuntimeClass { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Runtime {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  runtimeClass: ").Append(RuntimeClass).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Runtime);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Runtime input)
        {
            if (input == null) return false;
            if (this.Name != input.Name) return false;
            if (this.RuntimeClass != input.RuntimeClass) return false;

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
                hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.RuntimeClass.GetHashCode();
                return hashCode;
            }
        }
    }
}
