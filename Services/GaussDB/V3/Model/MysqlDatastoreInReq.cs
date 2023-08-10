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
    public class MysqlDatastoreInReq 
    {

        /// <summary>
        /// 数据库引擎，现在只支持gaussdb-mysql。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 数据库版本。  两位数的大版本号，获取方法请参见[查询数据库引擎的版本](https://support.huaweicloud.com/api-gaussdb/ShowGaussMySqlEngineVersion.html)返回的name字段。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 内核数据库版本。如果需要指定具体的内核版本，请联系客服人员添加白名单。  完整的四位内核数据库版本，获取方法请参见[查询数据库引擎的版本](https://support.huaweicloud.com/api-gaussdb/ShowGaussMySqlEngineVersion.html)返回的kernel_version字段。
        /// </summary>
        [JsonProperty("kernel_version", NullValueHandling = NullValueHandling.Ignore)]
        public string KernelVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlDatastoreInReq {\n");
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
            return this.Equals(input as MysqlDatastoreInReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlDatastoreInReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.KernelVersion == input.KernelVersion ||
                    (this.KernelVersion != null &&
                    this.KernelVersion.Equals(input.KernelVersion))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.KernelVersion != null)
                    hashCode = hashCode * 59 + this.KernelVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
