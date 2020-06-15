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
        /// Defines cpuType
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<CpuTypeEnum>))]
        public class CpuTypeEnum
        {
            /// <summary>
            /// Enum X86_64 for value: X86_64
            /// </summary>
            public static readonly CpuTypeEnum X86_64 = new CpuTypeEnum("X86_64");

            /// <summary>
            /// Enum AARCH64 for value: aarch64
            /// </summary>
            public static readonly CpuTypeEnum AARCH64 = new CpuTypeEnum("aarch64");

            public static readonly Dictionary<string, CpuTypeEnum> StaticFields =
            new Dictionary<string, CpuTypeEnum>()
            {
                {"X86_64", X86_64},
                {"aarch64", AARCH64},
            };

            private string Value;

            public CpuTypeEnum(string Value)
            {
                this.Value = Value;
            }

            public static CpuTypeEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
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
        /// 
        /// </summary>
        [SDKProperty("Content-Type", IsHeader = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("spec_code", IsQuery = true)]
        public string SpecCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("cache_mode", IsQuery = true)]
        public string CacheMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("engine", IsQuery = true)]
        public string Engine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("engine_version", IsQuery = true)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("cpu_type", IsQuery = true)]
        public CpuTypeEnum CpuType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("capacity", IsQuery = true)]
        public string Capacity { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFlavorsRequest {\n");
            sb.Append("  contentType: ").Append(ContentType).Append("\n");
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
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
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
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
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
