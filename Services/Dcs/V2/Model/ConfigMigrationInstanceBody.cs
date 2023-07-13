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
    /// 迁移任务实例信息
    /// </summary>
    public class ConfigMigrationInstanceBody 
    {

        /// <summary>
        /// Redis实例ID。（Redis类型为云服务Redis时必须填写）
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Redis实例地址。（Redis类型为自建Redis时必须填写）。
        /// </summary>
        [JsonProperty("addrs", NullValueHandling = NullValueHandling.Ignore)]
        public string Addrs { get; set; }

        /// <summary>
        /// Redis密码，如果设置了密码，则必须填写。
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore)]
        public string Password { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigMigrationInstanceBody {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  addrs: ").Append(Addrs).Append("\n");
            sb.Append("  password: ").Append(Password).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigMigrationInstanceBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigMigrationInstanceBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Addrs == input.Addrs ||
                    (this.Addrs != null &&
                    this.Addrs.Equals(input.Addrs))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Addrs != null)
                    hashCode = hashCode * 59 + this.Addrs.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                return hashCode;
            }
        }
    }
}
