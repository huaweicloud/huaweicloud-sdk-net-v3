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
        /// 容器运行时, 默认场景： - 1.25以下集群：默认为\&quot;docker\&quot; - 1.25及以上集群，随操作系统变化，默认的容器运行时不同：操作系统为欧拉2.5、欧拉2.8的节点默认为\&quot;docker\&quot;，其余操作系统的节点默认为\&quot;containerd\&quot; 
        /// </summary>
        /// <value>容器运行时, 默认场景： - 1.25以下集群：默认为\&quot;docker\&quot; - 1.25及以上集群，随操作系统变化，默认的容器运行时不同：操作系统为欧拉2.5、欧拉2.8的节点默认为\&quot;docker\&quot;，其余操作系统的节点默认为\&quot;containerd\&quot; </value>
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

            public static bool operator !=(NameEnum a, NameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 容器运行时, 默认场景： - 1.25以下集群：默认为\&quot;docker\&quot; - 1.25及以上集群，随操作系统变化，默认的容器运行时不同：操作系统为欧拉2.5、欧拉2.8的节点默认为\&quot;docker\&quot;，其余操作系统的节点默认为\&quot;containerd\&quot; 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public NameEnum Name { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Runtime {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
