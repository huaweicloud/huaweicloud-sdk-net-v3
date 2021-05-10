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
    public class NodePoolStatus 
    {
        /// <summary>
        /// 节点池状态，为空时节点池处于可用状态。 - Synchronizing：伸缩中 - Synchronized：节点池更新失败时会被置于此状态 - SoldOut：节点资源售罄 - Deleting：删除中 - Error：错误 
        /// </summary>
        /// <value>节点池状态，为空时节点池处于可用状态。 - Synchronizing：伸缩中 - Synchronized：节点池更新失败时会被置于此状态 - SoldOut：节点资源售罄 - Deleting：删除中 - Error：错误 </value>
        [JsonConverter(typeof(EnumClassConverter<PhaseEnum>))]
        public class PhaseEnum
        {
            /// <summary>
            /// Enum SYNCHRONIZING for value: Synchronizing
            /// </summary>
            public static readonly PhaseEnum SYNCHRONIZING = new PhaseEnum("Synchronizing");

            /// <summary>
            /// Enum SYNCHRONIZED for value: Synchronized
            /// </summary>
            public static readonly PhaseEnum SYNCHRONIZED = new PhaseEnum("Synchronized");

            /// <summary>
            /// Enum SOLDOUT for value: SoldOut
            /// </summary>
            public static readonly PhaseEnum SOLDOUT = new PhaseEnum("SoldOut");

            /// <summary>
            /// Enum DELETING for value: Deleting
            /// </summary>
            public static readonly PhaseEnum DELETING = new PhaseEnum("Deleting");

            /// <summary>
            /// Enum ERROR for value: Error
            /// </summary>
            public static readonly PhaseEnum ERROR = new PhaseEnum("Error");

            private static readonly Dictionary<string, PhaseEnum> StaticFields =
            new Dictionary<string, PhaseEnum>()
            {
                { "Synchronizing", SYNCHRONIZING },
                { "Synchronized", SYNCHRONIZED },
                { "SoldOut", SOLDOUT },
                { "Deleting", DELETING },
                { "Error", ERROR },
            };

            private string Value;

            public PhaseEnum(string value)
            {
                Value = value;
            }

            public static PhaseEnum FromValue(string value)
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

                if (this.Equals(obj as PhaseEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PhaseEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(PhaseEnum a, PhaseEnum b)
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

            public static bool operator !=(PhaseEnum a, PhaseEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 当前节点池中节点数量
        /// </summary>
        [JsonProperty("currentNode", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentNode { get; set; }

        /// <summary>
        /// 节点池状态，为空时节点池处于可用状态。 - Synchronizing：伸缩中 - Synchronized：节点池更新失败时会被置于此状态 - SoldOut：节点资源售罄 - Deleting：删除中 - Error：错误 
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public PhaseEnum Phase { get; set; }
        /// <summary>
        /// 节点池删除时的 JobID
        /// </summary>
        [JsonProperty("jobId", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodePoolStatus {\n");
            sb.Append("  currentNode: ").Append(CurrentNode).Append("\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodePoolStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodePoolStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentNode == input.CurrentNode ||
                    (this.CurrentNode != null &&
                    this.CurrentNode.Equals(input.CurrentNode))
                ) && 
                (
                    this.Phase == input.Phase ||
                    (this.Phase != null &&
                    this.Phase.Equals(input.Phase))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
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
                if (this.CurrentNode != null)
                    hashCode = hashCode * 59 + this.CurrentNode.GetHashCode();
                if (this.Phase != null)
                    hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                return hashCode;
            }
        }
    }
}
