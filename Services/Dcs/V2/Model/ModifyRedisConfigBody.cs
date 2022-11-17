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
    /// 修改配置参数请求体
    /// </summary>
    public class ModifyRedisConfigBody 
    {

        /// <summary>
        /// 实例配置项数组。
        /// </summary>
        [JsonProperty("redis_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<RedisConfig> RedisConfig { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyRedisConfigBody {\n");
            sb.Append("  redisConfig: ").Append(RedisConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyRedisConfigBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyRedisConfigBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RedisConfig == input.RedisConfig ||
                    this.RedisConfig != null &&
                    input.RedisConfig != null &&
                    this.RedisConfig.SequenceEqual(input.RedisConfig)
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
                if (this.RedisConfig != null)
                    hashCode = hashCode * 59 + this.RedisConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
