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
    public class DatabaseInfoItem 
    {

        /// <summary>
        /// 数据库名称, config admin 库不做展示。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 数据库存储大小（以GB为单位）,保留两位小数。 存储大小: 实际磁盘上占用的物理空间大小，包括数据文件、日志文件、索引文件等。
        /// </summary>
        [JsonProperty("data_size", NullValueHandling = NullValueHandling.Ignore)]
        public string DataSize { get; set; }

        /// <summary>
        /// 数据库逻辑大小 （以GB为单位）,保留两位小数。 逻辑大小指的是数据库中实际存储的数据大小，不包括索引大小、日志大小等。
        /// </summary>
        [JsonProperty("storage_size", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageSize { get; set; }

        /// <summary>
        /// 数据库中的集合数。
        /// </summary>
        [JsonProperty("collection_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CollectionNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatabaseInfoItem {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  dataSize: ").Append(DataSize).Append("\n");
            sb.Append("  storageSize: ").Append(StorageSize).Append("\n");
            sb.Append("  collectionNum: ").Append(CollectionNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DatabaseInfoItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DatabaseInfoItem input)
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
                    this.DataSize == input.DataSize ||
                    (this.DataSize != null &&
                    this.DataSize.Equals(input.DataSize))
                ) && 
                (
                    this.StorageSize == input.StorageSize ||
                    (this.StorageSize != null &&
                    this.StorageSize.Equals(input.StorageSize))
                ) && 
                (
                    this.CollectionNum == input.CollectionNum ||
                    (this.CollectionNum != null &&
                    this.CollectionNum.Equals(input.CollectionNum))
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
                if (this.DataSize != null)
                    hashCode = hashCode * 59 + this.DataSize.GetHashCode();
                if (this.StorageSize != null)
                    hashCode = hashCode * 59 + this.StorageSize.GetHashCode();
                if (this.CollectionNum != null)
                    hashCode = hashCode * 59 + this.CollectionNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
