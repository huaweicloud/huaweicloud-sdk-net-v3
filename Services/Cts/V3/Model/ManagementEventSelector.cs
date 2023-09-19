using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cts.V3.Model
{
    /// <summary>
    /// 管理类事件选择器。
    /// </summary>
    public class ManagementEventSelector 
    {

        /// <summary>
        /// 标识不转储的云服务名称。 目前只支持设置为KMS，表示屏蔽KMS服务的createDatakey事件。
        /// </summary>
        [JsonProperty("exclude_service", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExcludeService { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagementEventSelector {\n");
            sb.Append("  excludeService: ").Append(ExcludeService).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ManagementEventSelector);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ManagementEventSelector input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExcludeService == input.ExcludeService ||
                    this.ExcludeService != null &&
                    input.ExcludeService != null &&
                    this.ExcludeService.SequenceEqual(input.ExcludeService)
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
                if (this.ExcludeService != null)
                    hashCode = hashCode * 59 + this.ExcludeService.GetHashCode();
                return hashCode;
            }
        }
    }
}
