using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class CacheConfigRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cache_config", NullValueHandling = NullValueHandling.Ignore)]
        public CacheConfigRequest CacheConfig { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CacheConfigRequestBody {\n");
            sb.Append("  cacheConfig: ").Append(CacheConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CacheConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CacheConfigRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CacheConfig == input.CacheConfig ||
                    (this.CacheConfig != null &&
                    this.CacheConfig.Equals(input.CacheConfig))
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
                if (this.CacheConfig != null)
                    hashCode = hashCode * 59 + this.CacheConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
