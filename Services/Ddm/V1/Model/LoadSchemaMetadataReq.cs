using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class LoadSchemaMetadataReq 
    {

        /// <summary>
        /// 逻辑库信息。
        /// </summary>
        [JsonProperty("compressed_databases_info", NullValueHandling = NullValueHandling.Ignore)]
        public string CompressedDatabasesInfo { get; set; }

        /// <summary>
        /// 关联的后端DN信息。
        /// </summary>
        [JsonProperty("dn_instance", NullValueHandling = NullValueHandling.Ignore)]
        public List<DNInstance> DnInstance { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoadSchemaMetadataReq {\n");
            sb.Append("  compressedDatabasesInfo: ").Append(CompressedDatabasesInfo).Append("\n");
            sb.Append("  dnInstance: ").Append(DnInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoadSchemaMetadataReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LoadSchemaMetadataReq input)
        {
            if (input == null) return false;
            if (this.CompressedDatabasesInfo != input.CompressedDatabasesInfo || (this.CompressedDatabasesInfo != null && !this.CompressedDatabasesInfo.Equals(input.CompressedDatabasesInfo))) return false;
            if (this.DnInstance != input.DnInstance || (this.DnInstance != null && input.DnInstance != null && !this.DnInstance.SequenceEqual(input.DnInstance))) return false;

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
                if (this.CompressedDatabasesInfo != null) hashCode = hashCode * 59 + this.CompressedDatabasesInfo.GetHashCode();
                if (this.DnInstance != null) hashCode = hashCode * 59 + this.DnInstance.GetHashCode();
                return hashCode;
            }
        }
    }
}
