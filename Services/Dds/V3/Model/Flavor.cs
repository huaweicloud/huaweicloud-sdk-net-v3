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
    /// 规格信息。
    /// </summary>
    public class Flavor 
    {

        /// <summary>
        /// 引擎名称。
        /// </summary>
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineName { get; set; }

        /// <summary>
        /// 节点类型。文档数据库包含以下几种节点类型： - mongos - shard - config - replica - single
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// CPU核数。
        /// </summary>
        [JsonProperty("vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public string Vcpus { get; set; }

        /// <summary>
        /// 内存大小，单位为兆字节。
        /// </summary>
        [JsonProperty("ram", NullValueHandling = NullValueHandling.Ignore)]
        public string Ram { get; set; }

        /// <summary>
        /// 资源规格编码。例如：dds.mongodb.c6.xlarge.2.shard。  - “dds”表示文档数据库服务产品。 - “c6.xlarge.2”表示节点性能规格，为高内存类型。 - “shard”表示节点类型。
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// &#39;支持该规格的可用区ID。&#39; 示例：[\&quot;cn-east-2a\&quot;,\&quot;cn-east-2b\&quot;,\&quot;cn-east-2c\&quot;]。
        /// </summary>
        [JsonProperty("az_status", NullValueHandling = NullValueHandling.Ignore)]
        public Object AzStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Flavor {\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  vcpus: ").Append(Vcpus).Append("\n");
            sb.Append("  ram: ").Append(Ram).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  azStatus: ").Append(AzStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Flavor);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Flavor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EngineName == input.EngineName ||
                    (this.EngineName != null &&
                    this.EngineName.Equals(input.EngineName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Vcpus == input.Vcpus ||
                    (this.Vcpus != null &&
                    this.Vcpus.Equals(input.Vcpus))
                ) && 
                (
                    this.Ram == input.Ram ||
                    (this.Ram != null &&
                    this.Ram.Equals(input.Ram))
                ) && 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
                ) && 
                (
                    this.AzStatus == input.AzStatus ||
                    (this.AzStatus != null &&
                    this.AzStatus.Equals(input.AzStatus))
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
                if (this.EngineName != null)
                    hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Vcpus != null)
                    hashCode = hashCode * 59 + this.Vcpus.GetHashCode();
                if (this.Ram != null)
                    hashCode = hashCode * 59 + this.Ram.GetHashCode();
                if (this.SpecCode != null)
                    hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.AzStatus != null)
                    hashCode = hashCode * 59 + this.AzStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
