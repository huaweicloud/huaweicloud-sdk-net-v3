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
    public class DeploymentGroupUpdateRequest 
    {
        /// <summary>
        /// 自动连通性验证 0不执行 1每日 2每周
        /// </summary>
        /// <value>自动连通性验证 0不执行 1每日 2每周</value>
        [JsonConverter(typeof(EnumClassConverter<AutoConnectionTestSwitchEnum>))]
        public class AutoConnectionTestSwitchEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly AutoConnectionTestSwitchEnum NUMBER_0 = new AutoConnectionTestSwitchEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly AutoConnectionTestSwitchEnum NUMBER_1 = new AutoConnectionTestSwitchEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly AutoConnectionTestSwitchEnum NUMBER_2 = new AutoConnectionTestSwitchEnum(2);

            private static readonly Dictionary<int?, AutoConnectionTestSwitchEnum> StaticFields =
            new Dictionary<int?, AutoConnectionTestSwitchEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
            };

            private int? _value;

            public AutoConnectionTestSwitchEnum()
            {

            }

            public AutoConnectionTestSwitchEnum(int? value)
            {
                _value = value;
            }

            public static AutoConnectionTestSwitchEnum FromValue(int? value)
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

                if (this.Equals(obj as AutoConnectionTestSwitchEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AutoConnectionTestSwitchEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AutoConnectionTestSwitchEnum a, AutoConnectionTestSwitchEnum b)
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

            public static bool operator !=(AutoConnectionTestSwitchEnum a, AutoConnectionTestSwitchEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 主机集群名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 自定义slave资源池id
        /// </summary>
        [JsonProperty("slave_cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaveClusterId { get; set; }

        /// <summary>
        /// 自动连通性验证 0不执行 1每日 2每周
        /// </summary>
        [JsonProperty("auto_connection_test_switch", NullValueHandling = NullValueHandling.Ignore)]
        public AutoConnectionTestSwitchEnum AutoConnectionTestSwitch { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeploymentGroupUpdateRequest {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  slaveClusterId: ").Append(SlaveClusterId).Append("\n");
            sb.Append("  autoConnectionTestSwitch: ").Append(AutoConnectionTestSwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeploymentGroupUpdateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeploymentGroupUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.SlaveClusterId == input.SlaveClusterId ||
                    (this.SlaveClusterId != null &&
                    this.SlaveClusterId.Equals(input.SlaveClusterId))
                ) && 
                (
                    this.AutoConnectionTestSwitch == input.AutoConnectionTestSwitch ||
                    (this.AutoConnectionTestSwitch != null &&
                    this.AutoConnectionTestSwitch.Equals(input.AutoConnectionTestSwitch))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SlaveClusterId != null)
                    hashCode = hashCode * 59 + this.SlaveClusterId.GetHashCode();
                if (this.AutoConnectionTestSwitch != null)
                    hashCode = hashCode * 59 + this.AutoConnectionTestSwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
