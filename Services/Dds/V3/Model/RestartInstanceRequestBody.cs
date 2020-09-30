using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RestartInstanceRequestBody 
    {
        /// <summary>
        /// 待重启对象的类型。 - 重启集群实例下的节点时，该参数必选。取值为“mongos”、“shard”、或“config”。 - 重启整个实例时，不传该参数。
        /// </summary>
        /// <value>待重启对象的类型。 - 重启集群实例下的节点时，该参数必选。取值为“mongos”、“shard”、或“config”。 - 重启整个实例时，不传该参数。</value>
        [JsonConverter(typeof(EnumClassConverter<TargetTypeEnum>))]
        public class TargetTypeEnum
        {
            /// <summary>
            /// Enum MONGOS for value: mongos
            /// </summary>
            public static readonly TargetTypeEnum MONGOS = new TargetTypeEnum("mongos");

            /// <summary>
            /// Enum SHARD for value: shard
            /// </summary>
            public static readonly TargetTypeEnum SHARD = new TargetTypeEnum("shard");

            /// <summary>
            /// Enum CONFIG for value: config
            /// </summary>
            public static readonly TargetTypeEnum CONFIG = new TargetTypeEnum("config");

            private static readonly Dictionary<string, TargetTypeEnum> StaticFields =
            new Dictionary<string, TargetTypeEnum>()
            {
                { "mongos", MONGOS },
                { "shard", SHARD },
                { "config", CONFIG },
            };

            private string Value;

            private TargetTypeEnum(string value)
            {
                this.Value = value;
            }

            public static TargetTypeEnum FromValue(string value)
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
                return this.Value;
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

                if (this.Equals(obj as TargetTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TargetTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(TargetTypeEnum a, TargetTypeEnum b)
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

            public static bool operator !=(TargetTypeEnum a, TargetTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 待重启对象的类型。 - 重启集群实例下的节点时，该参数必选。取值为“mongos”、“shard”、或“config”。 - 重启整个实例时，不传该参数。
        /// </summary>
        [JsonProperty("target_type", NullValueHandling = NullValueHandling.Ignore)]
        public TargetTypeEnum TargetType { get; set; }
        /// <summary>
        /// 待重启对象的ID。 - 重启集群实例下的节点时，对于mongos节点，取值为mongos节点ID，对于shard和config组，取值为shard和config组ID。 - 重启整个实例时，取值为实例ID。
        /// </summary>
        [JsonProperty("target_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestartInstanceRequestBody {\n");
            sb.Append("  targetType: ").Append(TargetType).Append("\n");
            sb.Append("  targetId: ").Append(TargetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestartInstanceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestartInstanceRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TargetType == input.TargetType ||
                    (this.TargetType != null &&
                    this.TargetType.Equals(input.TargetType))
                ) && 
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
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
                if (this.TargetType != null)
                    hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                if (this.TargetId != null)
                    hashCode = hashCode * 59 + this.TargetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
