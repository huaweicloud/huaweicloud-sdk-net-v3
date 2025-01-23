using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 数据库信息。
    /// </summary>
    public class MysqlDatastoreInRes 
    {

        /// <summary>
        /// 数据库引擎，现在只支持gaussdb-mysql。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 兼容的三位开源数据库版本号。  获取方法请参见[查询数据库引擎的版本](https://support.huaweicloud.com/api-taurusdb/ShowGaussMySqlEngineVersion.html)返回的version字段。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 内核数据库版本。  完整的四位内核数据库版本号，获取方法请参见[查询数据库引擎的版本](https://support.huaweicloud.com/api-taurusdb/ShowGaussMySqlEngineVersion.html)返回的kernel_version字段。
        /// </summary>
        [JsonProperty("kernel_version", NullValueHandling = NullValueHandling.Ignore)]
        public string KernelVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlDatastoreInRes {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  kernelVersion: ").Append(KernelVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlDatastoreInRes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlDatastoreInRes input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.KernelVersion != input.KernelVersion || (this.KernelVersion != null && !this.KernelVersion.Equals(input.KernelVersion))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.KernelVersion != null) hashCode = hashCode * 59 + this.KernelVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
