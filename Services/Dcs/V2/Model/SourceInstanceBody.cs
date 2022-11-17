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
    /// 源实例信息。
    /// </summary>
    public class SourceInstanceBody 
    {

        /// <summary>
        /// Redis实例名称(source_instance信息中填写)。
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
            sb.Append("class SourceInstanceBody {\n");
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
            return this.Equals(input as SourceInstanceBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SourceInstanceBody input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.Addrs != null)
                    hashCode = hashCode * 59 + this.Addrs.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                return hashCode;
            }
        }
    }
}
