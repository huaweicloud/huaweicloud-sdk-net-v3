using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 删除账号请求
    /// </summary>
    public class RedisDeleteDbUserRequest 
    {

        /// <summary>
        /// 需要删除的数据库账号名称列表。
        /// </summary>
        [JsonProperty("names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Names { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RedisDeleteDbUserRequest {\n");
            sb.Append("  names: ").Append(Names).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RedisDeleteDbUserRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RedisDeleteDbUserRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Names == input.Names ||
                    this.Names != null &&
                    input.Names != null &&
                    this.Names.SequenceEqual(input.Names)
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
                if (this.Names != null)
                    hashCode = hashCode * 59 + this.Names.GetHashCode();
                return hashCode;
            }
        }
    }
}
