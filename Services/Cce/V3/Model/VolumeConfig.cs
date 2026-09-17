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
    /// 节点池同步场景磁盘配置
    /// </summary>
    public class VolumeConfig 
    {
        /// <summary>
        /// **参数解释**： 节点重置时磁盘数据的保留策略。 不传或该字段为空时，默认使用reset_managed_volumes策略清空由CCE管理的数据盘。 **约束限制**： 当保留自定义挂载卷时，挂载到指定目录与作为持久存储卷的高级配置不允许修改。 **取值范围**： - reset_managed_volumes：清空由CCE管理的数据盘。 - retain_custom_volumes：保留用户自定义挂载卷（包括挂载到指定目录的卷和用作本地持久卷的卷），集群版本需为v1.29.15-r90、v1.30.14-r90、v1.31.14-r50、v1.32.13-r20、v1.33.12-r0、v1.34.8-r0、v1.35.5-r0、v1.36.1-r10或以上版本。  **默认取值**： reset_managed_volumes
        /// </summary>
        /// <value>**参数解释**： 节点重置时磁盘数据的保留策略。 不传或该字段为空时，默认使用reset_managed_volumes策略清空由CCE管理的数据盘。 **约束限制**： 当保留自定义挂载卷时，挂载到指定目录与作为持久存储卷的高级配置不允许修改。 **取值范围**： - reset_managed_volumes：清空由CCE管理的数据盘。 - retain_custom_volumes：保留用户自定义挂载卷（包括挂载到指定目录的卷和用作本地持久卷的卷），集群版本需为v1.29.15-r90、v1.30.14-r90、v1.31.14-r50、v1.32.13-r20、v1.33.12-r0、v1.34.8-r0、v1.35.5-r0、v1.36.1-r10或以上版本。  **默认取值**： reset_managed_volumes</value>
        [JsonConverter(typeof(EnumClassConverter<VolumeResetPolicyEnum>))]
        public class VolumeResetPolicyEnum
        {
            /// <summary>
            /// Enum RESET_MANAGED_VOLUMES for value: reset_managed_volumes
            /// </summary>
            public static readonly VolumeResetPolicyEnum RESET_MANAGED_VOLUMES = new VolumeResetPolicyEnum("reset_managed_volumes");

            /// <summary>
            /// Enum RETAIN_CUSTOM_VOLUMES for value: retain_custom_volumes
            /// </summary>
            public static readonly VolumeResetPolicyEnum RETAIN_CUSTOM_VOLUMES = new VolumeResetPolicyEnum("retain_custom_volumes");

            private static readonly Dictionary<string, VolumeResetPolicyEnum> StaticFields =
            new Dictionary<string, VolumeResetPolicyEnum>()
            {
                { "reset_managed_volumes", RESET_MANAGED_VOLUMES },
                { "retain_custom_volumes", RETAIN_CUSTOM_VOLUMES },
            };

            private string _value;

            public VolumeResetPolicyEnum()
            {

            }

            public VolumeResetPolicyEnum(string value)
            {
                _value = value;
            }

            public static VolumeResetPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as VolumeResetPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VolumeResetPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VolumeResetPolicyEnum a, VolumeResetPolicyEnum b)
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

            public static bool operator !=(VolumeResetPolicyEnum a, VolumeResetPolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 节点重置时磁盘数据的保留策略。 不传或该字段为空时，默认使用reset_managed_volumes策略清空由CCE管理的数据盘。 **约束限制**： 当保留自定义挂载卷时，挂载到指定目录与作为持久存储卷的高级配置不允许修改。 **取值范围**： - reset_managed_volumes：清空由CCE管理的数据盘。 - retain_custom_volumes：保留用户自定义挂载卷（包括挂载到指定目录的卷和用作本地持久卷的卷），集群版本需为v1.29.15-r90、v1.30.14-r90、v1.31.14-r50、v1.32.13-r20、v1.33.12-r0、v1.34.8-r0、v1.35.5-r0、v1.36.1-r10或以上版本。  **默认取值**： reset_managed_volumes
        /// </summary>
        [JsonProperty("volumeResetPolicy", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeResetPolicyEnum VolumeResetPolicy { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeConfig {\n");
            sb.Append("  volumeResetPolicy: ").Append(VolumeResetPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VolumeConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VolumeConfig input)
        {
            if (input == null) return false;
            if (this.VolumeResetPolicy != input.VolumeResetPolicy) return false;

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
                hashCode = hashCode * 59 + this.VolumeResetPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
