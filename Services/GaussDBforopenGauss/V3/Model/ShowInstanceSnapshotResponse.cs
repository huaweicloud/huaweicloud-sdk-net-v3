using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowInstanceSnapshotResponse : SdkResponse
    {
        /// <summary>
        /// 实例部署形态。集中式Ha(主备)、分布式Independent(独立部署)。
        /// </summary>
        /// <value>实例部署形态。集中式Ha(主备)、分布式Independent(独立部署)。</value>
        [JsonConverter(typeof(EnumClassConverter<ClusterModeEnum>))]
        public class ClusterModeEnum
        {
            /// <summary>
            /// Enum HA for value: Ha
            /// </summary>
            public static readonly ClusterModeEnum HA = new ClusterModeEnum("Ha");

            /// <summary>
            /// Enum INDEPENDENT for value: Independent
            /// </summary>
            public static readonly ClusterModeEnum INDEPENDENT = new ClusterModeEnum("Independent");

            private static readonly Dictionary<string, ClusterModeEnum> StaticFields =
            new Dictionary<string, ClusterModeEnum>()
            {
                { "Ha", HA },
                { "Independent", INDEPENDENT },
            };

            private string _value;

            public ClusterModeEnum()
            {

            }

            public ClusterModeEnum(string value)
            {
                _value = value;
            }

            public static ClusterModeEnum FromValue(string value)
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

                if (this.Equals(obj as ClusterModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ClusterModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ClusterModeEnum a, ClusterModeEnum b)
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

            public static bool operator !=(ClusterModeEnum a, ClusterModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 实例模型，企业版enterprise，标准版standard，基础版basic。
        /// </summary>
        /// <value>实例模型，企业版enterprise，标准版standard，基础版basic。</value>
        [JsonConverter(typeof(EnumClassConverter<InstanceModeEnum>))]
        public class InstanceModeEnum
        {
            /// <summary>
            /// Enum BASIC for value: basic
            /// </summary>
            public static readonly InstanceModeEnum BASIC = new InstanceModeEnum("basic");

            /// <summary>
            /// Enum STANDARD for value: standard
            /// </summary>
            public static readonly InstanceModeEnum STANDARD = new InstanceModeEnum("standard");

            /// <summary>
            /// Enum ENTERPRISE for value: enterprise
            /// </summary>
            public static readonly InstanceModeEnum ENTERPRISE = new InstanceModeEnum("enterprise");

            private static readonly Dictionary<string, InstanceModeEnum> StaticFields =
            new Dictionary<string, InstanceModeEnum>()
            {
                { "basic", BASIC },
                { "standard", STANDARD },
                { "enterprise", ENTERPRISE },
            };

            private string _value;

            public InstanceModeEnum()
            {

            }

            public InstanceModeEnum(string value)
            {
                _value = value;
            }

            public static InstanceModeEnum FromValue(string value)
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

                if (this.Equals(obj as InstanceModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InstanceModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InstanceModeEnum a, InstanceModeEnum b)
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

            public static bool operator !=(InstanceModeEnum a, InstanceModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 解决方案模板类型。集中式Ha一般用triset，分布式Independent一般为空或者默认hws。  描述如下：  triset：高可用(1主2备)  hws：默认。
        /// </summary>
        /// <value>解决方案模板类型。集中式Ha一般用triset，分布式Independent一般为空或者默认hws。  描述如下：  triset：高可用(1主2备)  hws：默认。</value>
        [JsonConverter(typeof(EnumClassConverter<SolutionEnum>))]
        public class SolutionEnum
        {
            /// <summary>
            /// Enum TRISET for value: triset
            /// </summary>
            public static readonly SolutionEnum TRISET = new SolutionEnum("triset");

            /// <summary>
            /// Enum HWS for value: hws
            /// </summary>
            public static readonly SolutionEnum HWS = new SolutionEnum("hws");

            private static readonly Dictionary<string, SolutionEnum> StaticFields =
            new Dictionary<string, SolutionEnum>()
            {
                { "triset", TRISET },
                { "hws", HWS },
            };

            private string _value;

            public SolutionEnum()
            {

            }

            public SolutionEnum(string value)
            {
                _value = value;
            }

            public static SolutionEnum FromValue(string value)
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

                if (this.Equals(obj as SolutionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SolutionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SolutionEnum a, SolutionEnum b)
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

            public static bool operator !=(SolutionEnum a, SolutionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例部署形态。集中式Ha(主备)、分布式Independent(独立部署)。
        /// </summary>
        [JsonProperty("cluster_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ClusterModeEnum ClusterMode { get; set; }
        /// <summary>
        /// 实例模型，企业版enterprise，标准版standard，基础版basic。
        /// </summary>
        [JsonProperty("instance_mode", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceModeEnum InstanceMode { get; set; }
        /// <summary>
        /// 磁盘大小，单位：GB。
        /// </summary>
        [JsonProperty("data_volume_size", NullValueHandling = NullValueHandling.Ignore)]
        public string DataVolumeSize { get; set; }

        /// <summary>
        /// 解决方案模板类型。集中式Ha一般用triset，分布式Independent一般为空或者默认hws。  描述如下：  triset：高可用(1主2备)  hws：默认。
        /// </summary>
        [JsonProperty("solution", NullValueHandling = NullValueHandling.Ignore)]
        public SolutionEnum Solution { get; set; }
        /// <summary>
        /// 节点数量。
        /// </summary>
        [JsonProperty("node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeNum { get; set; }

        /// <summary>
        /// 协调节点数量。
        /// </summary>
        [JsonProperty("coordinator_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CoordinatorNum { get; set; }

        /// <summary>
        /// 分片数量。
        /// </summary>
        [JsonProperty("sharding_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShardingNum { get; set; }

        /// <summary>
        /// 副本数量。
        /// </summary>
        [JsonProperty("replica_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReplicaNum { get; set; }

        /// <summary>
        /// 引擎版本。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceSnapshotResponse {\n");
            sb.Append("  clusterMode: ").Append(ClusterMode).Append("\n");
            sb.Append("  instanceMode: ").Append(InstanceMode).Append("\n");
            sb.Append("  dataVolumeSize: ").Append(DataVolumeSize).Append("\n");
            sb.Append("  solution: ").Append(Solution).Append("\n");
            sb.Append("  nodeNum: ").Append(NodeNum).Append("\n");
            sb.Append("  coordinatorNum: ").Append(CoordinatorNum).Append("\n");
            sb.Append("  shardingNum: ").Append(ShardingNum).Append("\n");
            sb.Append("  replicaNum: ").Append(ReplicaNum).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceSnapshotResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceSnapshotResponse input)
        {
            if (input == null) return false;
            if (this.ClusterMode != input.ClusterMode) return false;
            if (this.InstanceMode != input.InstanceMode) return false;
            if (this.DataVolumeSize != input.DataVolumeSize || (this.DataVolumeSize != null && !this.DataVolumeSize.Equals(input.DataVolumeSize))) return false;
            if (this.Solution != input.Solution) return false;
            if (this.NodeNum != input.NodeNum || (this.NodeNum != null && !this.NodeNum.Equals(input.NodeNum))) return false;
            if (this.CoordinatorNum != input.CoordinatorNum || (this.CoordinatorNum != null && !this.CoordinatorNum.Equals(input.CoordinatorNum))) return false;
            if (this.ShardingNum != input.ShardingNum || (this.ShardingNum != null && !this.ShardingNum.Equals(input.ShardingNum))) return false;
            if (this.ReplicaNum != input.ReplicaNum || (this.ReplicaNum != null && !this.ReplicaNum.Equals(input.ReplicaNum))) return false;
            if (this.EngineVersion != input.EngineVersion || (this.EngineVersion != null && !this.EngineVersion.Equals(input.EngineVersion))) return false;

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
                hashCode = hashCode * 59 + this.ClusterMode.GetHashCode();
                hashCode = hashCode * 59 + this.InstanceMode.GetHashCode();
                if (this.DataVolumeSize != null) hashCode = hashCode * 59 + this.DataVolumeSize.GetHashCode();
                hashCode = hashCode * 59 + this.Solution.GetHashCode();
                if (this.NodeNum != null) hashCode = hashCode * 59 + this.NodeNum.GetHashCode();
                if (this.CoordinatorNum != null) hashCode = hashCode * 59 + this.CoordinatorNum.GetHashCode();
                if (this.ShardingNum != null) hashCode = hashCode * 59 + this.ShardingNum.GetHashCode();
                if (this.ReplicaNum != null) hashCode = hashCode * 59 + this.ReplicaNum.GetHashCode();
                if (this.EngineVersion != null) hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
