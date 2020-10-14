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
    /// 
    /// </summary>
    public class CreateServerGroupOption 
    {
        /// <summary>
        /// Defines policies
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<PoliciesEnum>))]
        public class PoliciesEnum
        {
            /// <summary>
            /// Enum ANTI_AFFINITY for value: anti-affinity
            /// </summary>
            public static readonly PoliciesEnum ANTI_AFFINITY = new PoliciesEnum("anti-affinity");

            private static readonly Dictionary<string, PoliciesEnum> StaticFields =
            new Dictionary<string, PoliciesEnum>()
            {
                { "anti-affinity", ANTI_AFFINITY },
            };

            private string Value;

            public PoliciesEnum(string value)
            {
                Value = value;
            }

            public static PoliciesEnum FromValue(string value)
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

                if (this.Equals(obj as PoliciesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PoliciesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(PoliciesEnum a, PoliciesEnum b)
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

            public static bool operator !=(PoliciesEnum a, PoliciesEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 弹性云服务器组名称，长度大于0小于256字节。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 与云服务器组关联的策略名称列表。包括：  - anti-affinity：此组中的弹性云服务器必须安排到不同的主机。  - affinity：此组中的弹性云服务器必须安排在同一主机上。  - soft-anti-affinity：如果可能，应将此组中的云服务器尽量安排到不同的主机上，但如果无法实现，则仍应安排它们，而不是导致生成失败。  - soft-affinity：如果可能，应将此组中的弹性云服务器尽量安排在同一主机上， 但如果无法实现，则仍应安排它们，而不是导致生成失败。    &gt; 说明：  - 当前仅支持反亲和性anti-affinity策略。
        /// </summary>
        [JsonProperty("policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<PoliciesEnum> Policies { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateServerGroupOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  policies: ").Append(Policies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateServerGroupOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateServerGroupOption input)
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
                    this.Policies == input.Policies ||
                    this.Policies != null &&
                    input.Policies != null &&
                    this.Policies.SequenceEqual(input.Policies)
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
                if (this.Policies != null)
                    hashCode = hashCode * 59 + this.Policies.GetHashCode();
                return hashCode;
            }
        }
    }
}
