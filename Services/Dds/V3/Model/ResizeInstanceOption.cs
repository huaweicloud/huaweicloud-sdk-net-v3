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
    public class ResizeInstanceOption 
    {
        /// <summary>
        /// 对象类型。 - 对于集群实例，该参数为必选。变更mongos节点规格时，取值为“mongos”；变更shard组规格时，取值为“shard”。 - 对于副本集和单节点实例，不传该参数。
        /// </summary>
        /// <value>对象类型。 - 对于集群实例，该参数为必选。变更mongos节点规格时，取值为“mongos”；变更shard组规格时，取值为“shard”。 - 对于副本集和单节点实例，不传该参数。</value>
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

            private static readonly Dictionary<string, TargetTypeEnum> StaticFields =
            new Dictionary<string, TargetTypeEnum>()
            {
                { "mongos", MONGOS },
                { "shard", SHARD },
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
        /// 对象类型。 - 对于集群实例，该参数为必选。变更mongos节点规格时，取值为“mongos”；变更shard组规格时，取值为“shard”。 - 对于副本集和单节点实例，不传该参数。
        /// </summary>
        [JsonProperty("target_type", NullValueHandling = NullValueHandling.Ignore)]
        public TargetTypeEnum TargetType { get; set; }
        /// <summary>
        /// 待变更规格的节点ID或实例ID。 - 对于集群实例，变更mongos节点规格时，取值为mongos节点ID；变更shard组规格时，取值为shard组ID。 - 对于副本集实例，取值为相应的实例ID。 - 对于单节点实例，取值为相应的实例ID。
        /// </summary>
        [JsonProperty("target_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetId { get; set; }

        /// <summary>
        /// 变更至新规格的资源规格编码。
        /// </summary>
        [JsonProperty("target_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetSpecCode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizeInstanceOption {\n");
            sb.Append("  targetType: ").Append(TargetType).Append("\n");
            sb.Append("  targetId: ").Append(TargetId).Append("\n");
            sb.Append("  targetSpecCode: ").Append(TargetSpecCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResizeInstanceOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizeInstanceOption input)
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
                ) && 
                (
                    this.TargetSpecCode == input.TargetSpecCode ||
                    (this.TargetSpecCode != null &&
                    this.TargetSpecCode.Equals(input.TargetSpecCode))
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
                if (this.TargetSpecCode != null)
                    hashCode = hashCode * 59 + this.TargetSpecCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
