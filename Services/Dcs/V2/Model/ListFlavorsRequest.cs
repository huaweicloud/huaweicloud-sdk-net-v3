using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListFlavorsRequest 
    {
        /// <summary>
        /// CPU架构类型。取值范围如下： - x86_64：X86架构 - aarch64：ARM架构 
        /// </summary>
        /// <value>CPU架构类型。取值范围如下： - x86_64：X86架构 - aarch64：ARM架构 </value>
        [JsonConverter(typeof(EnumClassConverter<CpuTypeEnum>))]
        public class CpuTypeEnum
        {
            /// <summary>
            /// Enum X86_64 for value: x86_64
            /// </summary>
            public static readonly CpuTypeEnum X86_64 = new CpuTypeEnum("x86_64");

            /// <summary>
            /// Enum AARCH64 for value: aarch64
            /// </summary>
            public static readonly CpuTypeEnum AARCH64 = new CpuTypeEnum("aarch64");

            private static readonly Dictionary<string, CpuTypeEnum> StaticFields =
            new Dictionary<string, CpuTypeEnum>()
            {
                { "x86_64", X86_64 },
                { "aarch64", AARCH64 },
            };

            private string Value;

            public CpuTypeEnum(string value)
            {
                Value = value;
            }

            public static CpuTypeEnum FromValue(string value)
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

                if (this.Equals(obj as CpuTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CpuTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(CpuTypeEnum a, CpuTypeEnum b)
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

            public static bool operator !=(CpuTypeEnum a, CpuTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 产品规格编码。
        /// </summary>
        [SDKProperty("spec_code", IsQuery = true)]
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// 缓存实例类型。取值范围如下： - single：表示单机实例 - ha：表示主备实例 - cluster：表示cluster集群实例 - proxy：表示Proxy集群实例 - ha_rw_split： 表示读写分离实例 
        /// </summary>
        [SDKProperty("cache_mode", IsQuery = true)]
        [JsonProperty("cache_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string CacheMode { get; set; }

        /// <summary>
        /// 缓存引擎类型。取值范围如下： - Redis - Memcached 
        /// </summary>
        [SDKProperty("engine", IsQuery = true)]
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public string Engine { get; set; }

        /// <summary>
        /// 缓存版本，当缓存引擎为Redis时，取值范围如下： - 3.0 - 4.0 - 5.0 
        /// </summary>
        [SDKProperty("engine_version", IsQuery = true)]
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// CPU架构类型。取值范围如下： - x86_64：X86架构 - aarch64：ARM架构 
        /// </summary>
        [SDKProperty("cpu_type", IsQuery = true)]
        [JsonProperty("cpu_type", NullValueHandling = NullValueHandling.Ignore)]
        public CpuTypeEnum CpuType { get; set; }
        /// <summary>
        /// 缓存容量（G Byte）。 - Redis3.0：单机和主备类型实例取值：2、4、8、16、32、64。Proxy集群实例规格支持64、128、256、512和1024。 - Redis4.0和Redis5.0：单机和主备类型实例取值：0.125、0.25、0.5、1、2、4、8、16、32、64。Cluster集群实例规格支持24、32、48、64、96、128、192、256、384、512、768、1024。 - Memcached：单机和主备类型实例取值：2、4、8、16、32、64。 
        /// </summary>
        [SDKProperty("capacity", IsQuery = true)]
        [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
        public string Capacity { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFlavorsRequest {\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  cacheMode: ").Append(CacheMode).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  cpuType: ").Append(CpuType).Append("\n");
            sb.Append("  capacity: ").Append(Capacity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFlavorsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFlavorsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
                ) && 
                (
                    this.CacheMode == input.CacheMode ||
                    (this.CacheMode != null &&
                    this.CacheMode.Equals(input.CacheMode))
                ) && 
                (
                    this.Engine == input.Engine ||
                    (this.Engine != null &&
                    this.Engine.Equals(input.Engine))
                ) && 
                (
                    this.EngineVersion == input.EngineVersion ||
                    (this.EngineVersion != null &&
                    this.EngineVersion.Equals(input.EngineVersion))
                ) && 
                (
                    this.CpuType == input.CpuType ||
                    (this.CpuType != null &&
                    this.CpuType.Equals(input.CpuType))
                ) && 
                (
                    this.Capacity == input.Capacity ||
                    (this.Capacity != null &&
                    this.Capacity.Equals(input.Capacity))
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
                if (this.SpecCode != null)
                    hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.CacheMode != null)
                    hashCode = hashCode * 59 + this.CacheMode.GetHashCode();
                if (this.Engine != null)
                    hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.EngineVersion != null)
                    hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.CpuType != null)
                    hashCode = hashCode * 59 + this.CpuType.GetHashCode();
                if (this.Capacity != null)
                    hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                return hashCode;
            }
        }
    }
}
