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
    /// 磁盘初始化配置管理参数。  该参数配置逻辑较为复杂，详细说明请参见[节点磁盘挂载](node_storage_example.xml)。  该参数缺省时，按照extendParam中的DockerLVMConfigOverride参数进行磁盘管理。此参数对1.15.11及以上集群版本支持。 
    /// </summary>
    public class Storage 
    {

        /// <summary>
        /// 磁盘选择，根据matchLabels和storageType对匹配的磁盘进行管理。磁盘匹配存在先后顺序，靠前的匹配规则优先匹配。
        /// </summary>
        [JsonProperty("storageSelectors", NullValueHandling = NullValueHandling.Ignore)]
        public List<StorageSelectors> StorageSelectors { get; set; }

        /// <summary>
        /// 由多个存储设备组成的存储组，用于各个存储空间的划分。
        /// </summary>
        [JsonProperty("storageGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<StorageGroups> StorageGroups { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Storage {\n");
            sb.Append("  storageSelectors: ").Append(StorageSelectors).Append("\n");
            sb.Append("  storageGroups: ").Append(StorageGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Storage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Storage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StorageSelectors == input.StorageSelectors ||
                    this.StorageSelectors != null &&
                    input.StorageSelectors != null &&
                    this.StorageSelectors.SequenceEqual(input.StorageSelectors)
                ) && 
                (
                    this.StorageGroups == input.StorageGroups ||
                    this.StorageGroups != null &&
                    input.StorageGroups != null &&
                    this.StorageGroups.SequenceEqual(input.StorageGroups)
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
                if (this.StorageSelectors != null)
                    hashCode = hashCode * 59 + this.StorageSelectors.GetHashCode();
                if (this.StorageGroups != null)
                    hashCode = hashCode * 59 + this.StorageGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
