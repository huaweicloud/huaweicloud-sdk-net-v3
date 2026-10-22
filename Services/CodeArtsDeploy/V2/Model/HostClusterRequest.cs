using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class HostClusterRequest 
    {
        /// <summary>
        /// 资源池类型，self-hosted 自托管资源池，exclusive 独享资源池
        /// </summary>
        /// <value>资源池类型，self-hosted 自托管资源池，exclusive 独享资源池</value>
        [JsonConverter(typeof(EnumClassConverter<SlaveResourceTypeEnum>))]
        public class SlaveResourceTypeEnum
        {
            /// <summary>
            /// Enum SELF_HOSTED for value: self-hosted
            /// </summary>
            public static readonly SlaveResourceTypeEnum SELF_HOSTED = new SlaveResourceTypeEnum("self-hosted");

            /// <summary>
            /// Enum EXCLUSIVE for value: exclusive
            /// </summary>
            public static readonly SlaveResourceTypeEnum EXCLUSIVE = new SlaveResourceTypeEnum("exclusive");

            private static readonly Dictionary<string, SlaveResourceTypeEnum> StaticFields =
            new Dictionary<string, SlaveResourceTypeEnum>()
            {
                { "self-hosted", SELF_HOSTED },
                { "exclusive", EXCLUSIVE },
            };

            private string _value;

            public SlaveResourceTypeEnum()
            {

            }

            public SlaveResourceTypeEnum(string value)
            {
                _value = value;
            }

            public static SlaveResourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SlaveResourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SlaveResourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SlaveResourceTypeEnum a, SlaveResourceTypeEnum b)
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

            public static bool operator !=(SlaveResourceTypeEnum a, SlaveResourceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 主机集群名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 主机集群描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// slave集群id，默认为null时使用八爪鱼slave集群，用户自定义slave时为slave集群id
        /// </summary>
        [JsonProperty("slave_cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaveClusterId { get; set; }

        /// <summary>
        /// 资源池类型，self-hosted 自托管资源池，exclusive 独享资源池
        /// </summary>
        [JsonProperty("slave_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public SlaveResourceTypeEnum SlaveResourceType { get; set; }
        /// <summary>
        /// 是否切换新系统支持，1：是 0：否
        /// </summary>
        [JsonProperty("ansible_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AnsibleType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HostClusterRequest {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  slaveClusterId: ").Append(SlaveClusterId).Append("\n");
            sb.Append("  slaveResourceType: ").Append(SlaveResourceType).Append("\n");
            sb.Append("  ansibleType: ").Append(AnsibleType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HostClusterRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HostClusterRequest input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.SlaveClusterId != input.SlaveClusterId || (this.SlaveClusterId != null && !this.SlaveClusterId.Equals(input.SlaveClusterId))) return false;
            if (this.SlaveResourceType != input.SlaveResourceType) return false;
            if (this.AnsibleType != input.AnsibleType || (this.AnsibleType != null && !this.AnsibleType.Equals(input.AnsibleType))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SlaveClusterId != null) hashCode = hashCode * 59 + this.SlaveClusterId.GetHashCode();
                hashCode = hashCode * 59 + this.SlaveResourceType.GetHashCode();
                if (this.AnsibleType != null) hashCode = hashCode * 59 + this.AnsibleType.GetHashCode();
                return hashCode;
            }
        }
    }
}
